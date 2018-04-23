using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;

namespace WindowsFormsApplication2
{
    public class MyVistaDataEditCalendar : VistaDateEditCalendar
    {
        public MyVistaDataEditCalendar(RepositoryItemDateEdit item, object editDate)
            : base(item, editDate)
        {
        }

        protected override DevExpress.XtraEditors.Drawing.DateEditPainter CreatePainter()
        {
            return new MyVistaDateEditPainter(this);
        }

        protected override DevExpress.XtraEditors.ViewInfo.DateEditInfoArgs CreateInfoArgs()
        {
            return new MyVistaDateEditInfoArgs(calendar: this);
        }

        internal new Rectangle CaptionRect
        {
            get { return base.CaptionRect; }
        }

        protected override void OnPressedObjectChanged(DevExpress.XtraEditors.Calendar.CalendarHitInfo prev, DevExpress.XtraEditors.Calendar.CalendarHitInfo curr)
        {
            base.OnPressedObjectChanged(prev, curr);
            MyVistaDateEditInfoArgs vdi = Calendars[0] as MyVistaDateEditInfoArgs;
            MyCalendarHitInfo hitInfo = curr as MyCalendarHitInfo;
            Invalidate(prev.Bounds);
            if (curr.HitObject != null)
            {
                if (hitInfo.InLeftYearButton)
                    vdi.LeftYearArrowInfo.State = ObjectState.Pressed;
                if(hitInfo.InRightYearButton)
                    vdi.RightYearArrowInfo.State = ObjectState.Pressed;
            }
            if (curr == null) Invalidate(Bounds);
            else Invalidate(curr.Bounds);
        }

        protected override void OnPressedObjectChanging(DevExpress.XtraEditors.Calendar.CalendarHitInfo prev, DevExpress.XtraEditors.Calendar.CalendarHitInfo curr)
        {
            base.OnPressedObjectChanging(prev, curr);
            MyVistaDateEditInfoArgs vdi = Calendars[0] as MyVistaDateEditInfoArgs;
            MyCalendarHitInfo hitInfo = curr as MyCalendarHitInfo;
            if (curr.HitObject != null)
            {
                vdi.LeftYearArrowInfo.State = hitInfo.InLeftYearButton ? ObjectState.Hot : ObjectState.Normal;
                vdi.RightYearArrowInfo.State = hitInfo.InRightYearButton ? ObjectState.Hot : ObjectState.Normal;
            }
        }

        protected override void OnHotObjectChanged(DevExpress.XtraEditors.Calendar.CalendarHitInfo prevInfo, DevExpress.XtraEditors.Calendar.CalendarHitInfo currInfo)
        {
            base.OnHotObjectChanged(prevInfo, currInfo);
            Invalidate(prevInfo.Bounds);
            MyVistaDateEditInfoArgs vdi = Calendars[0] as MyVistaDateEditInfoArgs;
            MyCalendarHitInfo hitInfo = currInfo as MyCalendarHitInfo;
            vdi.OnAnimationChanged(prevInfo, currInfo);
            if (currInfo != null && currInfo.HitObject != null)
            {
                if (hitInfo.InLeftYearButton && vdi.LeftYearArrowInfo.State != ObjectState.Pressed)
                    vdi.LeftYearArrowInfo.State = ObjectState.Hot;
                if (hitInfo.InRightYearButton && vdi.RightYearArrowInfo.State != ObjectState.Pressed)
                    vdi.RightYearArrowInfo.State = ObjectState.Hot;
            }
        }

        protected override void OnHotObjectChanging(DevExpress.XtraEditors.Calendar.CalendarHitInfo prevInfo, DevExpress.XtraEditors.Calendar.CalendarHitInfo currInfo)
        {
            base.OnHotObjectChanging(prevInfo, currInfo);
            MyVistaDateEditInfoArgs vdi = Calendars[0] as MyVistaDateEditInfoArgs;
            vdi.OnAnimationChanging(prevInfo, currInfo);
            vdi.RightYearArrowInfo.State = ObjectState.Normal;
            vdi.LeftYearArrowInfo.State = ObjectState.Normal;
        }

        protected override void ProcessClick(DevExpress.XtraEditors.Calendar.CalendarHitInfo hit)
        {
            base.ProcessClick(hit);
            if (hit.HitObject != null)
            {
                SwitchType = SwitchStateType.SwitchToRight;
                OnStateChanging(View, View, false, true);
                MyVistaDateEditInfoArgs vdi = Calendars[0] as MyVistaDateEditInfoArgs;
                MyCalendarHitInfo hitInfo = hit as MyCalendarHitInfo;
                if (hitInfo.InRightYearButton)
                    DateTime = DateTime.AddYears(1);
                if (hitInfo.InLeftYearButton)
                    DateTime = DateTime.AddYears(-1);
                OnStateChanged(View, View, false, true);
            }
        }

        internal new bool PrepareAnimation
        {
            get { return base.PrepareAnimation; }
            set { base.PrepareAnimation = value; }
        }
    }
}
