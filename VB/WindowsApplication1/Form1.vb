Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Diagnostics

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(224, 24)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(432, 224)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(736, 438)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub InitData()
			Dim records(4) As Record
			records(0) = New Record(1, "Chai", "Beverages", True, 18)
			records(1) = New Record(2, "Aniseed Syrup", "Condiments", False, 10)
			records(2) = New Record(3, "Ikura", "Seafood", False, 30.5)
			records(3) = New Record(4, "Queso Cabrales", "Dairy Products", True, 21)
			records(4) = New Record(5, "Carnarvon Tigers", "Seafood", True, 62.5)
			gridControl1.DataSource = records
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			gridView1.PopulateColumns()
			AddHandler gridView1.FocusedColumnChanged, AddressOf gridView1_FocusedColumnChanged
			AddHandler gridView1.FocusedRowChanged, AddressOf gridView1_FocusedRowChanged
		End Sub

		Private internalChanging As Boolean = False

        Public Delegate Sub DoViewFocusedCellChangedDelegate(byval sender as GridView)

        Public Sub DoViewFocusedCellChanged(ByVal sender As GridView)
            ViewFocusedCellChanged(sender)
            internalChanging = False
        End Sub

		Private Sub DoFocusedCellChanged(ByVal sender As GridView)
			If internalChanging Then
				Return
			End If
			internalChanging = True
            'INSTANT VB TODO TASK: Anonymous methods are not converted by Instant VB if local variables of the outer method are referenced within the anonymous method:
            BeginInvoke(New DoViewFocusedCellChangedDelegate(AddressOf DoViewFocusedCellChanged), sender)
        End Sub

		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
			DoFocusedCellChanged(TryCast(sender, GridView))
		End Sub

		Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs)
			DoFocusedCellChanged(TryCast(sender, GridView))
		End Sub

		Private Sub ViewFocusedCellChanged(ByVal sender As GridView)
			MessageBox.Show("Focused cell has been changed!")
		End Sub

	End Class
End Namespace
