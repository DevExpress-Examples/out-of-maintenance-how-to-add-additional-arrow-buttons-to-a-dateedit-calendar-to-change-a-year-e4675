using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Calendar;
using System.Drawing;
using DevExpress.Utils.Drawing;

namespace WindowsFormsApplication2
{
    public class MyVistaDateEditInfoArgs : VistaDateEditInfoArgs
    {
        private EditorButtonObjectInfoArgs _RightYearArrowInfo;
        private EditorButtonObjectInfoArgs _LeftYearArrowInfo;
        private EditorButton leftYearArrowButton;
        private EditorButton rightYearArrowButton;
        public MyVistaDateEditInfoArgs(DateEditCalendarBase calendar)
            : base(calendar)
        {

        }
        public EditorButtonObjectInfoArgs LeftYearArrowInfo
        {
            get
            {
                return _LeftYearArrowInfo;
            }
            set
            {
                _LeftYearArrowInfo = value;
            }
        }
        public EditorButtonObjectInfoArgs RightYearArrowInfo
        {
            get
            {
                return _RightYearArrowInfo;
            }
            set
            {
                _RightYearArrowInfo = value;
            }
        }
        protected override void CreateArrowsButtonInfo()
        {
            base.CreateArrowsButtonInfo();
            this.leftYearArrowButton = new EditorButton(ButtonPredefines.Left);
            this.rightYearArrowButton = new EditorButton(ButtonPredefines.Right);
            this.LeftYearArrowInfo = new EditorButtonObjectInfoArgs(Cache, this.leftYearArrowButton, HeaderAppearance);
            this.RightYearArrowInfo = new EditorButtonObjectInfoArgs(Cache, this.rightYearArrowButton, HeaderAppearance); 
        }

        protected override void CalcHeaderInfo()
        {
            base.CalcHeaderInfo();
            Size buttonSize = CalcArrowButtonSize();
            LeftYearArrowInfo.Bounds = new Rectangle(new Point(Content.Left + DistanceFromBorderToArrow, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize);
            RightYearArrowInfo.Bounds = new Rectangle(new Point(Content.Right - DistanceFromBorderToArrow - buttonSize.Width, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize);
            
            LeftArrowInfo.Bounds = new Rectangle(new Point(LeftYearArrowInfo.Bounds.Right + DistanceFromBorderToArrow, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize);
            RightArrowInfo.Bounds = new Rectangle(new Point(RightArrowInfo.Bounds.Left - DistanceFromBorderToArrow - buttonSize.Width, Calendar.CaptionRect.Top + (Calendar.CaptionRect.Height - buttonSize.Height) / 2), buttonSize);
        }

        public override CalendarHitInfo GetHitInfo(System.Windows.Forms.MouseEventArgs e)
        {
            CalendarHitInfo hitInfo = base.GetHitInfo(e);
            MyCalendarHitInfo newHitInfo = new MyCalendarHitInfo(e.Location);
            newHitInfo.Assign(hitInfo);
            if (RightYearArrowInfo.Bounds.Contains(e.Location))
            {
                newHitInfo.InRightYearButton = true;
                newHitInfo.HitObject = RightYearArrowInfo;
            }
            if (LeftYearArrowInfo.Bounds.Contains(e.Location))
            {
                newHitInfo.InLeftYearButton = LeftYearArrowInfo.Bounds.Contains(e.Location);
                newHitInfo.HitObject = LeftYearArrowInfo;
            }
            return newHitInfo;
        }

        new MyVistaDataEditCalendar Calendar
        {
            get { return base.Calendar as MyVistaDataEditCalendar; }
        }
    }
}
