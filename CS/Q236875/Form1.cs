using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DXSample;
using System.Collections;

namespace Q236875 {
    public partial class Form1 : XtraForm {
        LayoutSettingsPersistHelper layoutSettingsHelper;
        private const string layoutPath = @"..\..\layout.xml";
        public Form1() {
            InitializeComponent();
            List<ControlWithName> controls = new List<ControlWithName>();
            controls.Add(new ControlWithName(dockManager1, "dockManager1"));
            controls.Add(new ControlWithName(gridView1, "gridView1"));
            layoutSettingsHelper = new LayoutSettingsPersistHelper(controls.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
        }

        private void OnSaveLayoutButtonClick(object sender, EventArgs e) {
            layoutSettingsHelper.SaveLayout(layoutPath);
            XtraMessageBox.Show("Complete!", "DXSample");
        }

        private void OnRestoreLayoutClick(object sender, EventArgs e) {
            layoutSettingsHelper.RestoreLayout(layoutPath);
            XtraMessageBox.Show("Complete!", "DXSample");
        }

        private void OnSaveDockLayoutButtonClick(object sender, EventArgs e) {
            layoutSettingsHelper.SaveLayout(layoutPath, dockManager1);
            XtraMessageBox.Show("Complete!", "DXSample");
        }

        private void OnRestoreDockLayoutButtonClick(object sender, EventArgs e) {
            layoutSettingsHelper.RestoreLayout(layoutPath, dockManager1);
            XtraMessageBox.Show("Complete!", "DXSample");
        }

        private void OnSaveGridLayoutButtonClick(object sender, EventArgs e) {
            layoutSettingsHelper.SaveLayout(layoutPath, gridView1);
            XtraMessageBox.Show("Complete!", "DXSample");
        }

        private void OnRestoreGridLayoutButtonClick(object sender, EventArgs e) {
            layoutSettingsHelper.RestoreLayout(layoutPath, gridView1);
            XtraMessageBox.Show("Complete!", "DXSample");
        }
    }
}