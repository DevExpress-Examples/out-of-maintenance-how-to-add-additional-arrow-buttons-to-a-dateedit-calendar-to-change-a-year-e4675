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
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace WindowsFormsApplication2

	Public Class MyDateEdit
		Inherits DateEdit
		Shared Sub New()
			RepositoryItemMyDateEdit.Register()
		End Sub
		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyDateEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyDateEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyDateEdit)
			End Get
		End Property
		Protected Overrides Function CreatePopupForm() As PopupBaseForm
			If Properties.VistaDisplayMode <> DevExpress.Utils.DefaultBoolean.False AndAlso Properties.ShowYearArrows Then
				Return New MyVistaPopupDateEditForm(Me)
			End If
			Return MyBase.CreatePopupForm()
		End Function
	End Class
End Namespace
