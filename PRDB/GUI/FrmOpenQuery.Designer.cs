namespace FPRDB.GUI
{
    partial class FrmOpenQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenQuery));
            this.panelControlOpenQuery = new DevExpress.XtraEditors.PanelControl();
            this.btCancelOpenQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btOkOpenQuery = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxOpenQuery = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenQuery)).BeginInit();
            this.panelControlOpenQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOpenQuery.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlOpenQuery
            // 
            this.panelControlOpenQuery.Controls.Add(this.btCancelOpenQuery);
            this.panelControlOpenQuery.Controls.Add(this.btOkOpenQuery);
            this.panelControlOpenQuery.Controls.Add(this.comboBoxOpenQuery);
            this.panelControlOpenQuery.Controls.Add(this.labelControl1);
            this.panelControlOpenQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlOpenQuery.Location = new System.Drawing.Point(0, 0);
            this.panelControlOpenQuery.Name = "panelControlOpenQuery";
            this.panelControlOpenQuery.Size = new System.Drawing.Size(507, 92);
            this.panelControlOpenQuery.TabIndex = 0;
            // 
            // btCancelOpenQuery
            // 
            this.btCancelOpenQuery.Location = new System.Drawing.Point(420, 57);
            this.btCancelOpenQuery.Name = "btCancelOpenQuery";
            this.btCancelOpenQuery.Size = new System.Drawing.Size(75, 23);
            this.btCancelOpenQuery.TabIndex = 5;
            this.btCancelOpenQuery.Text = "&Cancel";
            this.btCancelOpenQuery.Click += new System.EventHandler(this.btCancelOpenQuery_Click);
            // 
            // btOkOpenQuery
            // 
            this.btOkOpenQuery.Location = new System.Drawing.Point(328, 57);
            this.btOkOpenQuery.Name = "btOkOpenQuery";
            this.btOkOpenQuery.Size = new System.Drawing.Size(75, 23);
            this.btOkOpenQuery.TabIndex = 1;
            this.btOkOpenQuery.Text = "&OK";
            this.btOkOpenQuery.Click += new System.EventHandler(this.btOkOpenQuery_Click);
            // 
            // comboBoxOpenQuery
            // 
            this.comboBoxOpenQuery.Location = new System.Drawing.Point(147, 20);
            this.comboBoxOpenQuery.Name = "comboBoxOpenQuery";
            this.comboBoxOpenQuery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxOpenQuery.Size = new System.Drawing.Size(348, 20);
            this.comboBoxOpenQuery.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Choose a query to open :";
            // 
            // FrmOpenQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 92);
            this.Controls.Add(this.panelControlOpenQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(523, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 131);
            this.Name = "FrmOpenQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Query";
            this.Load += new System.EventHandler(this.FrmOpenQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenQuery)).EndInit();
            this.panelControlOpenQuery.ResumeLayout(false);
            this.panelControlOpenQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOpenQuery.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlOpenQuery;
        private DevExpress.XtraEditors.SimpleButton btCancelOpenQuery;
        private DevExpress.XtraEditors.SimpleButton btOkOpenQuery;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxOpenQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}