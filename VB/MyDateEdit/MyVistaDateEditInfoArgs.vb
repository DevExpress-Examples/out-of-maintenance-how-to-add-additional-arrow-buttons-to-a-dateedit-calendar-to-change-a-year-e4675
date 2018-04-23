Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Calendar
Imports System.Drawing
Imports DevExpress.Utils.Drawing

Namespace WindowsFormsApplication2
	Public Class MyVistaDateEditInfoArgs
		Inherits VistaDateEditInfoArgs
		Private _RightYearArrowInfo As EditorButtonObjectInfoArgs
		Private _LeftYearArrowInfo As EditorButtonObjectInfoArgs
		Private leftYearArrowButton As EditorButton
		Private rightYearArrowButton As EditorButton
		Public Sub New(ByVal calendar As DateEditCalendarBase)
			MyBase.New(calendar)

		End Sub
		Public Property LeftYearArrowInfo() As EditorButtonObjectInfoArgs
			Get
				Return _LeftYearArrowInfo
			End Get
			Set(ByVal value As EditorButtonObjectInfoArgs)
				_LeftYearArrowInfo = value
			End Set
		End Property
		Public Property RightYearArrowInfo() As EditorButtonObjectInfoArgs
			Get
				Return _RightYearArrowInfo
			End Get
			Set(ByVal value As EditorButtonObjectInfoArgs)
				_RightYearArrowInfo = value
			End Set
		End Property
		Protected Overrides Sub CreateArrowsButtonInfo()
			MyBase.CreateArrowsButtonInfo()
			Me.leftYearArrowButton = New EditorButton(ButtonPredefines.Left)
			Me.rightYearArrowButton = New EditorButton(ButtonPredefines.Right)
			Me.LeftYearArrowInfo = New EditorButtonObjectInfoArgs(Cache, Me.leftYearArrowButton, HeaderAppearance)
			Me.RightYearArrowInfo = New EditorButtonObjectInfoArgs(Cache, Me.rightYearArrowButton, HeaderAppearance)
		End Sub

		Protected Overrides Sub CalcHeaderInfo()
			MyBase.CalcHeaderInfo()
			Dim buttonSize As Size = CalcArrowButtonSize()
			LeftYearArrowInfo.Bounds = New Rectangle(New Point(Content.Left + DistanceFromBorderToArrow, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize)
			RightYearArrowInfo.Bounds = New Rectangle(New Point(Content.Right - DistanceFromBorderToArrow - buttonSize.Width, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize)

			LeftArrowInfo.Bounds = New Rectangle(New Point(LeftYearArrowInfo.Bounds.Right + DistanceFromBorderToArrow, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize)
			RightArrowInfo.Bounds = New Rectangle(New Point(RightArrowInfo.Bounds.Left - DistanceFromBorderToArrow - buttonSize.Width, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize)
		End Sub

		Public Overrides Function GetHitInfo(ByVal e As System.Windows.Forms.MouseEventArgs) As CalendarHitInfo
			Dim hitInfo As CalendarHitInfo = MyBase.GetHitInfo(e)
			Dim newHitInfo As New MyCalendarHitInfo(e.Location)
			newHitInfo.Assign(hitInfo)
			If RightYearArrowInfo.Bounds.Contains(e.Location) Then
				newHitInfo.InRightYearButton = True
				newHitInfo.HitObject = RightYearArrowInfo
			End If
			If LeftYearArrowInfo.Bounds.Contains(e.Location) Then
				newHitInfo.InLeftYearButton = LeftYearArrowInfo.Bounds.Contains(e.Location)
				newHitInfo.HitObject = LeftYearArrowInfo
			End If
			Return newHitInfo
		End Function

		Private Shadows ReadOnly Property Calendar() As MyVistaDataEditCalendar
			Get
				Return TryCast(MyBase.Calendar, MyVistaDataEditCalendar)
			End Get
		End Property
	End Class
End Namespace
