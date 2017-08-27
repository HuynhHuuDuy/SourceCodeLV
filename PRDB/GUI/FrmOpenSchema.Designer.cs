namespace FPRDB.GUI
{
    partial class FrmOpenSchema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenSchema));
            this.panelControlOpenSchema = new DevExpress.XtraEditors.PanelControl();
            this.btCancelOpenSchema = new DevExpress.XtraEditors.SimpleButton();
            this.btOkOpenSchema = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxOpenSchema = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenSchema)).BeginInit();
            this.panelControlOpenSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOpenSchema.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlOpenSchema
            // 
            this.panelControlOpenSchema.Controls.Add(this.btCancelOpenSchema);
            this.panelControlOpenSchema.Controls.Add(this.btOkOpenSchema);
            this.panelControlOpenSchema.Controls.Add(this.comboBoxOpenSchema);
            this.panelControlOpenSchema.Controls.Add(this.labelControl1);
            this.panelControlOpenSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlOpenSchema.Location = new System.Drawing.Point(0, 0);
            this.panelControlOpenSchema.Name = "panelControlOpenSchema";
            this.panelControlOpenSchema.Size = new System.Drawing.Size(452, 92);
            this.panelControlOpenSchema.TabIndex = 0;
            // 
            // btCancelOpenSchema
            // 
            this.btCancelOpenSchema.Location = new System.Drawing.Point(362, 57);
            this.btCancelOpenSchema.Name = "btCancelOpenSchema";
            this.btCancelOpenSchema.Size = new System.Drawing.Size(75, 23);
            this.btCancelOpenSchema.TabIndex = 5;
            this.btCancelOpenSchema.Text = "&Cancel";
            this.btCancelOpenSchema.Click += new System.EventHandler(this.btCancelOpenSchema_Click);
            // 
            // btOkOpenSchema
            // 
            this.btOkOpenSchema.Location = new System.Drawing.Point(270, 57);
            this.btOkOpenSchema.Name = "btOkOpenSchema";
            this.btOkOpenSchema.Size = new System.Drawing.Size(75, 23);
            this.btOkOpenSchema.TabIndex = 1;
            this.btOkOpenSchema.Text = "&OK";
            this.btOkOpenSchema.Click += new System.EventHandler(this.btOkOpenSchema_Click);
            // 
            // comboBoxOpenSchema
            // 
            this.comboBoxOpenSchema.Location = new System.Drawing.Point(97, 20);
            this.comboBoxOpenSchema.Name = "comboBoxOpenSchema";
            this.comboBoxOpenSchema.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxOpenSchema.Size = new System.Drawing.Size(340, 20);
            this.comboBoxOpenSchema.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Choose schema:";
            // 
            // FrmOpenSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 92);
            this.Controls.Add(this.panelControlOpenSchema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(468, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(468, 131);
            this.Name = "FrmOpenSchema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Schema";
            this.Load += new System.EventHandler(this.FrmOpenSchema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenSchema)).EndInit();
            this.panelControlOpenSchema.ResumeLayout(false);
            this.panelControlOpenSchema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOpenSchema.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlOpenSchema;
        private DevExpress.XtraEditors.SimpleButton btCancelOpenSchema;
        private DevExpress.XtraEditors.SimpleButton btOkOpenSchema;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxOpenSchema;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}