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
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace WindowsFormsApplication2 {

    public class MyDateEdit : DateEdit {
        static MyDateEdit() {
            RepositoryItemMyDateEdit.Register();
        }
        public MyDateEdit() { }

        public override string EditorTypeName {
            get { return RepositoryItemMyDateEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyDateEdit Properties {
            get { return base.Properties as RepositoryItemMyDateEdit; }
        }
        protected override PopupBaseForm CreatePopupForm() {
            if (Properties.VistaDisplayMode != DevExpress.Utils.DefaultBoolean.False && Properties.ShowYearArrows) return new MyVistaPopupDateEditForm(this);
            return base.CreatePopupForm();
        }
    }
}
