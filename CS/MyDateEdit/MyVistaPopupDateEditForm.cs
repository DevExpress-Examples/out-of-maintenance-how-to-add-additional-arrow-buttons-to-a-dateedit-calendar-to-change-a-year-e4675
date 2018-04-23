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

namespace WindowsFormsApplication2 {
    public class MyVistaPopupDateEditForm : VistaPopupDateEditForm {

        public MyVistaPopupDateEditForm(DateEdit ownerEdit)
            : base(ownerEdit) {
        }

        protected override DateEditCalendar CreateCalendar() {
            return new MyVistaDataEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
        }
    }
}
