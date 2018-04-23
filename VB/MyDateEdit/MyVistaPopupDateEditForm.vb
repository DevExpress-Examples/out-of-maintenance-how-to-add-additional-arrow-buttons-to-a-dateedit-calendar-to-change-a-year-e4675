Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication2
	Public Class MyVistaPopupDateEditForm
		Inherits VistaPopupDateEditForm

		Public Sub New(ByVal ownerEdit As DateEdit)
			MyBase.New(ownerEdit)
		End Sub

		Protected Overrides Function CreateCalendar() As DateEditCalendar
			Return New MyVistaDataEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue)
		End Function
	End Class
End Namespace
