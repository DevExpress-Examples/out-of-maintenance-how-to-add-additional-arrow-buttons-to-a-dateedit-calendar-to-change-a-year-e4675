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

namespace WindowsFormsApplication2
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyDateEdit : RepositoryItemDateEdit
    {
        static RepositoryItemMyDateEdit()
        {
            Register();
        }
        public RepositoryItemMyDateEdit() { }

        private bool _ShowYearArrows;
        internal const string EditorName = "MyDateEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyDateEdit),
                typeof(RepositoryItemMyDateEdit), typeof(DevExpress.XtraEditors.ViewInfo.DateEditViewInfo),
                new DevExpress.XtraEditors.Drawing.ButtonEditPainter(), true));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        public bool ShowYearArrows
        {
            get { return _ShowYearArrows; }
            set
            {
                if (_ShowYearArrows != value)
                {
                    _ShowYearArrows = value;
                    OnPropertiesChanged();
                }
            }
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemMyDateEdit source = item as RepositoryItemMyDateEdit;
                if (source == null) return;
                ShowYearArrows = source.ShowYearArrows;
            }
            finally
            {
                EndUpdate();
            }
        }
    }
}
