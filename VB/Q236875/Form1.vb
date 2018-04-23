Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.IO
Imports DXSample
Imports System.Collections

Namespace Q236875
	Partial Public Class Form1
		Inherits XtraForm
		Private layoutSettingsHelper As LayoutSettingsPersistHelper
		Private Const layoutPath As String = "..\..\layout.xml"
		Public Sub New()
			InitializeComponent()
			Dim controls As New List(Of ControlWithName)()
			controls.Add(New ControlWithName(dockManager1, "dockManager1"))
			controls.Add(New ControlWithName(gridView1, "gridView1"))
			layoutSettingsHelper = New LayoutSettingsPersistHelper(controls.ToArray())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
		End Sub

		Private Sub OnSaveLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			layoutSettingsHelper.SaveLayout(layoutPath)
			XtraMessageBox.Show("Complete!", "DXSample")
		End Sub

		Private Sub OnRestoreLayoutClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			layoutSettingsHelper.RestoreLayout(layoutPath)
			XtraMessageBox.Show("Complete!", "DXSample")
		End Sub

		Private Sub OnSaveDockLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			layoutSettingsHelper.SaveLayout(layoutPath, dockManager1)
			XtraMessageBox.Show("Complete!", "DXSample")
		End Sub

		Private Sub OnRestoreDockLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			layoutSettingsHelper.RestoreLayout(layoutPath, dockManager1)
			XtraMessageBox.Show("Complete!", "DXSample")
		End Sub

		Private Sub OnSaveGridLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton5.Click
			layoutSettingsHelper.SaveLayout(layoutPath, gridView1)
			XtraMessageBox.Show("Complete!", "DXSample")
		End Sub

		Private Sub OnRestoreGridLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton6.Click
			layoutSettingsHelper.RestoreLayout(layoutPath, gridView1)
			XtraMessageBox.Show("Complete!", "DXSample")
		End Sub
	End Class
End Namespace