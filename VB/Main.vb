Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WindowsFormsApplication2
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			Dim edit As CheckEdit = TryCast(sender, CheckEdit)
			myDateEdit1.Properties.ShowYearArrows = edit.Checked
		End Sub
	End Class
End Namespace
