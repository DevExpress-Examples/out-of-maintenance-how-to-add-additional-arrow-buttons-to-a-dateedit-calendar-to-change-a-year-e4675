Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Calendar
Imports System.Drawing

Namespace WindowsFormsApplication2
	Public Class MyCalendarHitInfo
		Inherits CalendarHitInfo
		Public Sub New(ByVal pt As Point)
			MyBase.New(pt)

		End Sub

		' Fields...
		Private _InRightYearButton As Boolean = False
		Private _InLeftYearButton As Boolean = False

		Public Property InLeftYearButton() As Boolean
			Get
				Return _InLeftYearButton
			End Get
			Set(ByVal value As Boolean)
				_InLeftYearButton = value
			End Set
		End Property


		Public Property InRightYearButton() As Boolean
			Get
				Return _InRightYearButton
			End Get
			Set(ByVal value As Boolean)
				_InRightYearButton = value
			End Set
		End Property

		Public Sub Assign(ByVal hitInfo As CalendarHitInfo)
			Bounds = hitInfo.Bounds
			HitDate = hitInfo.HitDate
			HitObject = hitInfo.HitObject
			InfoType = hitInfo.InfoType
		End Sub

	End Class
End Namespace
