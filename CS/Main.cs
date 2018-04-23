using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            myDateEdit1.Properties.ShowYearArrows = edit.Checked; 
        }
    }
}
