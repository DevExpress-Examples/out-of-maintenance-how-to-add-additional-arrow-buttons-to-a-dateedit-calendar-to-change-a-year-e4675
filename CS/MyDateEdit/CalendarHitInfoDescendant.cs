using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Calendar;
using System.Drawing;

namespace WindowsFormsApplication2
{
    public class MyCalendarHitInfo : CalendarHitInfo
    {
        public MyCalendarHitInfo(Point pt)
            : base(pt)
        {

        }

        // Fields...
        private bool _InRightYearButton = false;
        private bool _InLeftYearButton = false;

        public bool InLeftYearButton
        {
            get { return _InLeftYearButton; }
            set { _InLeftYearButton = value; }
        }


        public bool InRightYearButton
        {
            get { return _InRightYearButton; }
            set
            {
                _InRightYearButton = value;
            }
        }

        public void Assign(CalendarHitInfo hitInfo)
        {
            Bounds = hitInfo.Bounds;
            HitDate = hitInfo.HitDate;
            HitObject = hitInfo.HitObject;
            InfoType = hitInfo.InfoType;
        }
        
    }
}
