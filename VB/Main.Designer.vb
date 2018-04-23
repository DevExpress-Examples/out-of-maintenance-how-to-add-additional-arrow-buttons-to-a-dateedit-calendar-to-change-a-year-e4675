Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication2
	Partial Public Class Main
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
			Me.myDateEdit1 = New WindowsFormsApplication2.MyDateEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.myDateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myDateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myDateEdit1
			' 
			Me.myDateEdit1.EditValue = Nothing
			Me.myDateEdit1.Location = New System.Drawing.Point(75, 96)
			Me.myDateEdit1.Name = "myDateEdit1"
			Me.myDateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.myDateEdit1.Properties.ShowYearArrows = False
			Me.myDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.myDateEdit1.Size = New System.Drawing.Size(260, 20)
			Me.myDateEdit1.TabIndex = 0
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(75, 54)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "ShowYearArrows"
			Me.checkEdit1.Size = New System.Drawing.Size(135, 19)
			Me.checkEdit1.TabIndex = 1
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.OnCheckedChanged);
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(432, 242)
			Me.Controls.Add(Me.checkEdit1)
			Me.Controls.Add(Me.myDateEdit1)
			Me.Name = "Main"
			Me.Text = "How to change a year in a calendar"
			CType(Me.myDateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myDateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myDateEdit1 As MyDateEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace

