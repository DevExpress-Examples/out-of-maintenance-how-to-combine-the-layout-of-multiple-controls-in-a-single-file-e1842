using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace DXSample {
    public class LayoutSettingsPersistHelper {
        private Dictionary<object, string> fControls = new Dictionary<object, string>();
        IList<ControlLayout> deserializedCache = new List<ControlLayout>();

        public LayoutSettingsPersistHelper(IEnumerable<ControlWithName> controls) {
            foreach (ControlWithName control in controls)
                fControls.Add(control.Control, control.Name);
        }

        public void SaveLayout(string fileName) {
            RefreshCache(fileName);
            foreach (KeyValuePair<object, string> control in fControls)
                SaveLayout(GetControlLayout(control.Key), control.Key);
            if (File.Exists(fileName)) File.Delete(fileName);
            FlushCache(fileName);
            deserializedCache.Clear();
        }

        public void SaveLayout(string fileName, object control) {
            RefreshCache(fileName);
            SaveLayout(GetControlLayout(control), control);
            new FileInfo(fileName).Delete();
            if (File.Exists(fileName)) File.Delete(fileName);
            FlushCache(fileName);
            deserializedCache.Clear();
        }

        public void RestoreLayout(string fileName) {
            RefreshCache(fileName);
            foreach (KeyValuePair<object, string> control in fControls)
                RestoreLayout(GetControlLayout(control.Key), control.Key);
            deserializedCache.Clear();
        }

        public void RestoreLayout(string fileName, object control) {
            RefreshCache(fileName);
            RestoreLayout(GetControlLayout(control), control);
            deserializedCache.Clear();
        }

        private ControlLayout GetControlLayout(object control) {
            ControlLayout layout = null;
            string key = fControls[control];
            foreach (ControlLayout item in deserializedCache)
                if (item.ControlID == key) {
                    layout = item;
                    break;
                }
            if (layout == null) {
                layout = new ControlLayout(key);
                deserializedCache.Add(layout);
            }
            return layout;
        }

        private void SaveLayout(ControlLayout layout, object control) {
            using (MemoryStream stream = new MemoryStream()) {
                try {
                    MethodInfo mi = GetLayoutMethod(control.GetType(), "SaveLayoutToStream");
                    mi.Invoke(control, new object[] { stream });
                    layout.Layout = stream.ToArray();
                } finally { stream.Close(); }
            }
        }

        private void RestoreLayout(ControlLayout layout, object control) {
            if (layout.Layout == null) return;
            using (MemoryStream stream = new MemoryStream(layout.Layout)) {
                try {
                    MethodInfo mi = GetLayoutMethod(control.GetType(), "RestoreLayoutFromStream");
                    mi.Invoke(control, new object[] { stream });
                } finally { stream.Close(); }
            }
        }

        private static MethodInfo GetLayoutMethod(Type type, string methodName) {
            MethodInfo mi = type.GetMethod(methodName,
                BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Stream) },
                null);
            if (mi == null)
                throw new ArgumentException("The specified control can't save layout");
            return mi;
        }

        private void RefreshCache(string fileName) {
            if (!File.Exists(fileName)) return;
            using (Stream stream = new FileStream(fileName, FileMode.OpenOrCreate)) {
                try {
                    deserializedCache =
                        (IList<ControlLayout>)new XmlSerializer(typeof(List<ControlLayout>)).Deserialize(stream);
                } catch { 
                    deserializedCache.Clear();
                    XtraMessageBox.Show("Operation wasn't completed. The xml file is corrupted");
                } 
                finally { stream.Close(); }
            }
        }

        private void FlushCache(string fileName) {
            using (Stream stream = new FileStream(fileName, FileMode.OpenOrCreate)) {
                try {
                    new XmlSerializer(typeof(List<ControlLayout>)).Serialize(stream, deserializedCache);
                } finally { stream.Close(); }
            }
        }
    }

    public class ControlLayout {
        public ControlLayout(string id) {
            ControlID = id;
        }
        private ControlLayout() { }
        public string ControlID;
        public byte[] Layout;
    }

    public class ControlWithName {
        public ControlWithName(object ctrl, string n) {
            Control = ctrl; Name = n;
        }
        public object Control;
        public string Name;
    }
}