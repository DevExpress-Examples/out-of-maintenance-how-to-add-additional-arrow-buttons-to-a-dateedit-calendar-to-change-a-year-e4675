using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public class MyVistaDateEditPainter : VistaDateEditPainter
    {
        public MyVistaDateEditPainter(DateEditCalendarBase calendar)
            : base(calendar)
        {

        }

        public override void DrawArrows(DevExpress.XtraEditors.ViewInfo.VistaDateEditInfoArgs vdi)
        {
            base.DrawArrows(vdi);
            MyVistaDateEditInfoArgs args = vdi as MyVistaDateEditInfoArgs;
            args.RightYearArrowInfo.Cache = args.Cache;
            args.LeftYearArrowInfo.Cache = args.Cache;
            ButtonPainter.DrawObject(args.RightYearArrowInfo);
            ButtonPainter.DrawObject(args.LeftYearArrowInfo);
        }
    }
}
