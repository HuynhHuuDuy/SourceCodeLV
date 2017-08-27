namespace FPRDB.GUI
{
    partial class FrmDelQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDelQuery));
            this.panelControlDelQuery = new DevExpress.XtraEditors.PanelControl();
            this.btCancelDelQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btOkDelQuery = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxDelQuery = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelQuery)).BeginInit();
            this.panelControlDelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDelQuery.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlDelQuery
            // 
            this.panelControlDelQuery.Controls.Add(this.btCancelDelQuery);
            this.panelControlDelQuery.Controls.Add(this.btOkDelQuery);
            this.panelControlDelQuery.Controls.Add(this.comboBoxDelQuery);
            this.panelControlDelQuery.Controls.Add(this.labelControl1);
            this.panelControlDelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlDelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelControlDelQuery.Name = "panelControlDelQuery";
            this.panelControlDelQuery.Size = new System.Drawing.Size(507, 92);
            this.panelControlDelQuery.TabIndex = 0;
            // 
            // btCancelDelQuery
            // 
            this.btCancelDelQuery.Location = new System.Drawing.Point(420, 57);
            this.btCancelDelQuery.Name = "btCancelDelQuery";
            this.btCancelDelQuery.Size = new System.Drawing.Size(75, 23);
            this.btCancelDelQuery.TabIndex = 2;
            this.btCancelDelQuery.Text = "&Cancel";
            this.btCancelDelQuery.Click += new System.EventHandler(this.btCancelDelQuery_Click);
            // 
            // btOkDelQuery
            // 
            this.btOkDelQuery.Location = new System.Drawing.Point(328, 57);
            this.btOkDelQuery.Name = "btOkDelQuery";
            this.btOkDelQuery.Size = new System.Drawing.Size(75, 23);
            this.btOkDelQuery.TabIndex = 1;
            this.btOkDelQuery.Text = "&OK";
            this.btOkDelQuery.Click += new System.EventHandler(this.btOkDelQuery_Click);
            // 
            // comboBoxDelQuery
            // 
            this.comboBoxDelQuery.Location = new System.Drawing.Point(147, 20);
            this.comboBoxDelQuery.Name = "comboBoxDelQuery";
            this.comboBoxDelQuery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxDelQuery.Size = new System.Drawing.Size(348, 20);
            this.comboBoxDelQuery.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Choose a query to delete :";
            // 
            // FrmDelQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 92);
            this.Controls.Add(this.panelControlDelQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(523, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 131);
            this.Name = "FrmDelQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Query";
            this.Load += new System.EventHandler(this.FrmDelQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelQuery)).EndInit();
            this.panelControlDelQuery.ResumeLayout(false);
            this.panelControlDelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDelQuery.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlDelQuery;
        private DevExpress.XtraEditors.SimpleButton btCancelDelQuery;
        private DevExpress.XtraEditors.SimpleButton btOkDelQuery;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDelQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}