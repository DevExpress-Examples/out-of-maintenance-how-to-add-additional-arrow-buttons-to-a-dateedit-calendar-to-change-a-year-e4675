namespace WindowsFormsApplication2 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.myDateEdit1 = new WindowsFormsApplication2.MyDateEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myDateEdit1
            // 
            this.myDateEdit1.EditValue = null;
            this.myDateEdit1.Location = new System.Drawing.Point(75, 96);
            this.myDateEdit1.Name = "myDateEdit1";
            this.myDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myDateEdit1.Properties.ShowYearArrows = false;
            this.myDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myDateEdit1.Size = new System.Drawing.Size(260, 20);
            this.myDateEdit1.TabIndex = 0;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(75, 54);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "ShowYearArrows";
            this.checkEdit1.Size = new System.Drawing.Size(135, 19);
            this.checkEdit1.TabIndex = 1;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 242);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.myDateEdit1);
            this.Name = "Main";
            this.Text = "How to change a year in a calendar";
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyDateEdit myDateEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;

    }
}

