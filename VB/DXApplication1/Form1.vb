Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			dateEdit1.Properties.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True
		End Sub
	End Class
End Namespace
