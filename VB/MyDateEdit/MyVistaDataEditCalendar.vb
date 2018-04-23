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
Imports DevExpress.Utils.Drawing

Namespace WindowsFormsApplication2
	Public Class MyVistaDataEditCalendar
		Inherits VistaDateEditCalendar
		Public Sub New(ByVal item As RepositoryItemDateEdit, ByVal editDate As Object)
			MyBase.New(item, editDate)
		End Sub

		Protected Overrides Function CreatePainter() As DevExpress.XtraEditors.Drawing.DateEditPainter
			Return New MyVistaDateEditPainter(Me)
		End Function

		Protected Overrides Function CreateInfoArgs() As DevExpress.XtraEditors.ViewInfo.DateEditInfoArgs
			Return New MyVistaDateEditInfoArgs(calendar:=Me)
		End Function

		Friend Shadows ReadOnly Property CaptionRect() As Rectangle
			Get
				Return MyBase.CaptionRect
			End Get
		End Property

		Protected Overrides Sub OnPressedObjectChanged(ByVal prev As DevExpress.XtraEditors.Calendar.CalendarHitInfo, ByVal curr As DevExpress.XtraEditors.Calendar.CalendarHitInfo)
			MyBase.OnPressedObjectChanged(prev, curr)
			Dim vdi As MyVistaDateEditInfoArgs = TryCast(Calendars(0), MyVistaDateEditInfoArgs)
			Dim hitInfo As MyCalendarHitInfo = TryCast(curr, MyCalendarHitInfo)
			Invalidate(prev.Bounds)
			If curr.HitObject IsNot Nothing Then
				If hitInfo.InLeftYearButton Then
					vdi.LeftYearArrowInfo.State = ObjectState.Pressed
				End If
				If hitInfo.InRightYearButton Then
					vdi.RightYearArrowInfo.State = ObjectState.Pressed
				End If
			End If
			If curr Is Nothing Then
				Invalidate(Bounds)
			Else
				Invalidate(curr.Bounds)
			End If
		End Sub

		Protected Overrides Sub OnPressedObjectChanging(ByVal prev As DevExpress.XtraEditors.Calendar.CalendarHitInfo, ByVal curr As DevExpress.XtraEditors.Calendar.CalendarHitInfo)
			MyBase.OnPressedObjectChanging(prev, curr)
			Dim vdi As MyVistaDateEditInfoArgs = TryCast(Calendars(0), MyVistaDateEditInfoArgs)
			Dim hitInfo As MyCalendarHitInfo = TryCast(curr, MyCalendarHitInfo)
			If curr.HitObject IsNot Nothing Then
				vdi.LeftYearArrowInfo.State = If(hitInfo.InLeftYearButton, ObjectState.Hot, ObjectState.Normal)
				vdi.RightYearArrowInfo.State = If(hitInfo.InRightYearButton, ObjectState.Hot, ObjectState.Normal)
			End If
		End Sub

		Protected Overrides Sub OnHotObjectChanged(ByVal prevInfo As DevExpress.XtraEditors.Calendar.CalendarHitInfo, ByVal currInfo As DevExpress.XtraEditors.Calendar.CalendarHitInfo)
			MyBase.OnHotObjectChanged(prevInfo, currInfo)
			Invalidate(prevInfo.Bounds)
			Dim vdi As MyVistaDateEditInfoArgs = TryCast(Calendars(0), MyVistaDateEditInfoArgs)
			Dim hitInfo As MyCalendarHitInfo = TryCast(currInfo, MyCalendarHitInfo)
			vdi.OnAnimationChanged(prevInfo, currInfo)
			If currInfo IsNot Nothing AndAlso currInfo.HitObject IsNot Nothing Then
				If hitInfo.InLeftYearButton AndAlso vdi.LeftYearArrowInfo.State <> ObjectState.Pressed Then
					vdi.LeftYearArrowInfo.State = ObjectState.Hot
				End If
				If hitInfo.InRightYearButton AndAlso vdi.RightYearArrowInfo.State <> ObjectState.Pressed Then
					vdi.RightYearArrowInfo.State = ObjectState.Hot
				End If
			End If
		End Sub

		Protected Overrides Sub OnHotObjectChanging(ByVal prevInfo As DevExpress.XtraEditors.Calendar.CalendarHitInfo, ByVal currInfo As DevExpress.XtraEditors.Calendar.CalendarHitInfo)
			MyBase.OnHotObjectChanging(prevInfo, currInfo)
			Dim vdi As MyVistaDateEditInfoArgs = TryCast(Calendars(0), MyVistaDateEditInfoArgs)
			vdi.OnAnimationChanging(prevInfo, currInfo)
			vdi.RightYearArrowInfo.State = ObjectState.Normal
			vdi.LeftYearArrowInfo.State = ObjectState.Normal
		End Sub

		Protected Overrides Sub ProcessClick(ByVal hit As DevExpress.XtraEditors.Calendar.CalendarHitInfo)
			MyBase.ProcessClick(hit)
			If hit.HitObject IsNot Nothing Then
				SwitchType = SwitchStateType.SwitchToRight
				OnStateChanging(View, View, False, True)
				Dim vdi As MyVistaDateEditInfoArgs = TryCast(Calendars(0), MyVistaDateEditInfoArgs)
				Dim hitInfo As MyCalendarHitInfo = TryCast(hit, MyCalendarHitInfo)
				If hitInfo.InRightYearButton Then
					DateTime = DateTime.AddYears(1)
				End If
				If hitInfo.InLeftYearButton Then
					DateTime = DateTime.AddYears(-1)
				End If
				OnStateChanged(View, View, False, True)
			End If
		End Sub

		Friend Shadows Property PrepareAnimation() As Boolean
			Get
				Return MyBase.PrepareAnimation
			End Get
			Set(ByVal value As Boolean)
				MyBase.PrepareAnimation = value
			End Set
		End Property
	End Class
End Namespace
