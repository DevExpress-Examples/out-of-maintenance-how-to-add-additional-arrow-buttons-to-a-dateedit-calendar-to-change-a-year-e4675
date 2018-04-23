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
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyDateEdit
		Inherits RepositoryItemDateEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Private _ShowYearArrows As Boolean
		Friend Const EditorName As String = "MyDateEdit"

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyDateEdit), GetType(RepositoryItemMyDateEdit), GetType(DevExpress.XtraEditors.ViewInfo.DateEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Public Property ShowYearArrows() As Boolean
			Get
				Return _ShowYearArrows
			End Get
			Set(ByVal value As Boolean)
				If _ShowYearArrows <> value Then
					_ShowYearArrows = value
					OnPropertiesChanged()
				End If
			End Set
		End Property

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemMyDateEdit = TryCast(item, RepositoryItemMyDateEdit)
				If source Is Nothing Then
					Return
				End If
				ShowYearArrows = source.ShowYearArrows
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
