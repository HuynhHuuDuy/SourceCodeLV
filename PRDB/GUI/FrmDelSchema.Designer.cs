namespace FPRDB.GUI
{
    partial class FrmDelSchema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDelSchema));
            this.panelControlDelSchema = new DevExpress.XtraEditors.PanelControl();
            this.btCancelDelSchema = new DevExpress.XtraEditors.SimpleButton();
            this.btOkDelSchema = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxDelSchema = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelSchema)).BeginInit();
            this.panelControlDelSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDelSchema.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlDelSchema
            // 
            this.panelControlDelSchema.Controls.Add(this.btCancelDelSchema);
            this.panelControlDelSchema.Controls.Add(this.btOkDelSchema);
            this.panelControlDelSchema.Controls.Add(this.comboBoxDelSchema);
            this.panelControlDelSchema.Controls.Add(this.labelControl1);
            this.panelControlDelSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlDelSchema.Location = new System.Drawing.Point(0, 0);
            this.panelControlDelSchema.Name = "panelControlDelSchema";
            this.panelControlDelSchema.Size = new System.Drawing.Size(507, 92);
            this.panelControlDelSchema.TabIndex = 0;
            this.panelControlDelSchema.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlDelSchema_Paint);
            // 
            // btCancelDelSchema
            // 
            this.btCancelDelSchema.Location = new System.Drawing.Point(420, 57);
            this.btCancelDelSchema.Name = "btCancelDelSchema";
            this.btCancelDelSchema.Size = new System.Drawing.Size(75, 23);
            this.btCancelDelSchema.TabIndex = 2;
            this.btCancelDelSchema.Text = "&Cancel";
            this.btCancelDelSchema.Click += new System.EventHandler(this.btCancelDelSchema_Click);
            // 
            // btOkDelSchema
            // 
            this.btOkDelSchema.Location = new System.Drawing.Point(328, 57);
            this.btOkDelSchema.Name = "btOkDelSchema";
            this.btOkDelSchema.Size = new System.Drawing.Size(75, 23);
            this.btOkDelSchema.TabIndex = 1;
            this.btOkDelSchema.Text = "&OK";
            this.btOkDelSchema.Click += new System.EventHandler(this.btOkDelSchema_Click);
            // 
            // comboBoxDelSchema
            // 
            this.comboBoxDelSchema.Location = new System.Drawing.Point(155, 20);
            this.comboBoxDelSchema.Name = "comboBoxDelSchema";
            this.comboBoxDelSchema.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxDelSchema.Size = new System.Drawing.Size(340, 20);
            this.comboBoxDelSchema.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Choose a schema to delete :";
            // 
            // FrmDelSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 92);
            this.Controls.Add(this.panelControlDelSchema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(523, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 131);
            this.Name = "FrmDelSchema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Schema";
            this.Load += new System.EventHandler(this.FrmDelSchema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelSchema)).EndInit();
            this.panelControlDelSchema.ResumeLayout(false);
            this.panelControlDelSchema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDelSchema.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlDelSchema;
        private DevExpress.XtraEditors.SimpleButton btCancelDelSchema;
        private DevExpress.XtraEditors.SimpleButton btOkDelSchema;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDelSchema;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}