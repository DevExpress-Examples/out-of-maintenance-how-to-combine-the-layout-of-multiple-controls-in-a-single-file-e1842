Imports Microsoft.VisualBasic
Imports System
Namespace Q236875
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q236875.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.productsTableAdapter = New Q236875.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton6 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton5 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelContainer1.SuspendLayout()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(200, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(423, 235)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Products"
			Me.bindingSource1.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.ActiveFilterString = My.Settings.Default.gridView1ActiveFilterString
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colCategoryID})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategoryID, DevExpress.Data.ColumnSortOrder.Ascending)})
			' 
			' colProductID
			' 
			Me.colProductID.Caption = "Product ID"
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.Caption = "Product Name"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' colCategoryID
			' 
			Me.colCategoryID.Caption = "Category ID"
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 2
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraEditors.PanelControl"})
			' 
			' panelContainer1
			' 
			Me.panelContainer1.ActiveChild = Me.dockPanel1
			Me.panelContainer1.Controls.Add(Me.dockPanel2)
			Me.panelContainer1.Controls.Add(Me.dockPanel1)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.panelContainer1.ID = New System.Guid("f19c63cc-2f19-4a8b-b342-765a49b4c231")
			Me.panelContainer1.Location = New System.Drawing.Point(0, 0)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.Size = New System.Drawing.Size(200, 235)
			Me.panelContainer1.Tabbed = True
			Me.panelContainer1.Text = "panelContainer1"
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel1.FloatVertical = True
			Me.dockPanel1.ID = New System.Guid("74264703-fc88-4938-bc25-58e125700bbb")
			Me.dockPanel1.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.Size = New System.Drawing.Size(194, 185)
			Me.dockPanel1.Text = "dockPanel1"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 185)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel2.ID = New System.Guid("6a46455e-16a9-4876-9c19-ebc09181ef08")
			Me.dockPanel2.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.Size = New System.Drawing.Size(194, 185)
			Me.dockPanel2.Text = "dockPanel2"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(194, 185)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton6)
			Me.panelControl1.Controls.Add(Me.simpleButton5)
			Me.panelControl1.Controls.Add(Me.simpleButton4)
			Me.panelControl1.Controls.Add(Me.simpleButton3)
			Me.panelControl1.Controls.Add(Me.simpleButton2)
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 235)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(623, 38)
			Me.panelControl1.TabIndex = 2
			' 
			' simpleButton6
			' 
			Me.simpleButton6.Location = New System.Drawing.Point(506, 8)
			Me.simpleButton6.Name = "simpleButton6"
			Me.simpleButton6.Size = New System.Drawing.Size(111, 23)
			Me.simpleButton6.TabIndex = 5
			Me.simpleButton6.Text = "Restore Grid Layout"
'			Me.simpleButton6.Click += New System.EventHandler(Me.OnRestoreGridLayoutButtonClick);
			' 
			' simpleButton5
			' 
			Me.simpleButton5.Location = New System.Drawing.Point(409, 8)
			Me.simpleButton5.Name = "simpleButton5"
			Me.simpleButton5.Size = New System.Drawing.Size(91, 23)
			Me.simpleButton5.TabIndex = 4
			Me.simpleButton5.Text = "Save Grid Layout"
'			Me.simpleButton5.Click += New System.EventHandler(Me.OnSaveGridLayoutButtonClick);
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Location = New System.Drawing.Point(289, 8)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(114, 23)
			Me.simpleButton4.TabIndex = 3
			Me.simpleButton4.Text = "Restore Dock Layout"
'			Me.simpleButton4.Click += New System.EventHandler(Me.OnRestoreDockLayoutButtonClick);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(179, 8)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(104, 23)
			Me.simpleButton3.TabIndex = 2
			Me.simpleButton3.Text = "Save Dock Layout"
'			Me.simpleButton3.Click += New System.EventHandler(Me.OnSaveDockLayoutButtonClick);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(86, 8)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(87, 23)
			Me.simpleButton2.TabIndex = 1
			Me.simpleButton2.Text = "Restore Layout"
'			Me.simpleButton2.Click += New System.EventHandler(Me.OnRestoreLayoutClick);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(5, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Save Layout"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnSaveLayoutButtonClick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(623, 273)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelContainer1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelContainer1.ResumeLayout(False)
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private productsTableAdapter As Q236875.nwindDataSetTableAdapters.ProductsTableAdapter
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton6 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton5 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

