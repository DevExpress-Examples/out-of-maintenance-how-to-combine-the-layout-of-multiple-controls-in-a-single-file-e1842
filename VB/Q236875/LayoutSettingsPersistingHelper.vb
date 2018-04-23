Imports Microsoft.VisualBasic
Imports System.Collections
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml.Serialization
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace DXSample
	Public Class LayoutSettingsPersistHelper
		Private fControls As New Dictionary(Of Object, String)()
		Private deserializedCache As IList(Of ControlLayout) = New List(Of ControlLayout)()

		Public Sub New(ByVal controls As IEnumerable(Of ControlWithName))
			For Each control As ControlWithName In controls
				fControls.Add(control.Control, control.Name)
			Next control
		End Sub

		Public Sub SaveLayout(ByVal fileName As String)
			RefreshCache(fileName)
			For Each control As KeyValuePair(Of Object, String) In fControls
				SaveLayout(GetControlLayout(control.Key), control.Key)
			Next control
			If File.Exists(fileName) Then
				File.Delete(fileName)
			End If
			FlushCache(fileName)
			deserializedCache.Clear()
		End Sub

		Public Sub SaveLayout(ByVal fileName As String, ByVal control As Object)
			RefreshCache(fileName)
			SaveLayout(GetControlLayout(control), control)
			CType(New FileInfo(fileName), FileInfo).Delete()
			If File.Exists(fileName) Then
				File.Delete(fileName)
			End If
			FlushCache(fileName)
			deserializedCache.Clear()
		End Sub

		Public Sub RestoreLayout(ByVal fileName As String)
			RefreshCache(fileName)
			For Each control As KeyValuePair(Of Object, String) In fControls
				RestoreLayout(GetControlLayout(control.Key), control.Key)
			Next control
			deserializedCache.Clear()
		End Sub

		Public Sub RestoreLayout(ByVal fileName As String, ByVal control As Object)
			RefreshCache(fileName)
			RestoreLayout(GetControlLayout(control), control)
			deserializedCache.Clear()
		End Sub

		Private Function GetControlLayout(ByVal control As Object) As ControlLayout
			Dim layout As ControlLayout = Nothing
			Dim key As String = fControls(control)
			For Each item As ControlLayout In deserializedCache
				If item.ControlID = key Then
					layout = item
					Exit For
				End If
			Next item
			If layout Is Nothing Then
				layout = New ControlLayout(key)
				deserializedCache.Add(layout)
			End If
			Return layout
		End Function

		Private Sub SaveLayout(ByVal layout As ControlLayout, ByVal control As Object)
			Using stream As New MemoryStream()
				Try
					Dim mi As MethodInfo = GetLayoutMethod(control.GetType(), "SaveLayoutToStream")
					mi.Invoke(control, New Object() { stream })
					layout.Layout = stream.ToArray()
				Finally
					stream.Close()
				End Try
			End Using
		End Sub

		Private Sub RestoreLayout(ByVal layout As ControlLayout, ByVal control As Object)
			If layout.Layout Is Nothing Then
				Return
			End If
			Using stream As New MemoryStream(layout.Layout)
				Try
					Dim mi As MethodInfo = GetLayoutMethod(control.GetType(), "RestoreLayoutFromStream")
					mi.Invoke(control, New Object() { stream })
				Finally
					stream.Close()
				End Try
			End Using
		End Sub

		Private Shared Function GetLayoutMethod(ByVal type As Type, ByVal methodName As String) As MethodInfo
			Dim mi As MethodInfo = type.GetMethod(methodName, BindingFlags.Instance Or BindingFlags.Public, Nothing, New Type() { GetType(Stream) }, Nothing)
			If mi Is Nothing Then
				Throw New ArgumentException("The specified control can't save layout")
			End If
			Return mi
		End Function

		Private Sub RefreshCache(ByVal fileName As String)
			If (Not File.Exists(fileName)) Then
				Return
			End If
			Using stream As Stream = New FileStream(fileName, FileMode.OpenOrCreate)
				Try
					deserializedCache = CType(New XmlSerializer(GetType(List(Of ControlLayout))).Deserialize(stream), IList(Of ControlLayout))
				Catch
					deserializedCache.Clear()
					XtraMessageBox.Show("Operation wasn't completed. The xml file is corrupted")
				Finally
					stream.Close()
				End Try
			End Using
		End Sub

		Private Sub FlushCache(ByVal fileName As String)
			Using stream As Stream = New FileStream(fileName, FileMode.OpenOrCreate)
				Try
					CType(New XmlSerializer(GetType(List(Of ControlLayout))), XmlSerializer).Serialize(stream, deserializedCache)
				Finally
					stream.Close()
				End Try
			End Using
		End Sub
	End Class

	Public Class ControlLayout
		Public Sub New(ByVal id As String)
			ControlID = id
		End Sub
		Private Sub New()
		End Sub
		Public ControlID As String
		Public Layout() As Byte
	End Class

	Public Class ControlWithName
		Public Sub New(ByVal ctrl As Object, ByVal n As String)
			Control = ctrl
			Name = n
		End Sub
		Public Control As Object
		Public Name As String
	End Class
End Namespace