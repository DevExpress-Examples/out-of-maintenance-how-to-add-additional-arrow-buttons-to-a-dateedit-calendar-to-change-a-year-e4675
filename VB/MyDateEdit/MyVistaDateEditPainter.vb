Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Diagnostics

Namespace WindowsFormsApplication2
	Public Class MyVistaDateEditPainter
		Inherits VistaDateEditPainter
		Public Sub New(ByVal calendar As DateEditCalendarBase)
			MyBase.New(calendar)

		End Sub

		Public Overrides Sub DrawArrows(ByVal vdi As DevExpress.XtraEditors.ViewInfo.VistaDateEditInfoArgs)
			MyBase.DrawArrows(vdi)
			Dim args As MyVistaDateEditInfoArgs = TryCast(vdi, MyVistaDateEditInfoArgs)
			args.RightYearArrowInfo.Cache = args.Cache
			args.LeftYearArrowInfo.Cache = args.Cache
			ButtonPainter.DrawObject(args.RightYearArrowInfo)
			ButtonPainter.DrawObject(args.LeftYearArrowInfo)
		End Sub
	End Class
End Namespace
