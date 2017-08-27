namespace FPRDB.GUI
{
    partial class FrmOpenRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenRelation));
            this.panelControlOpenRelation = new DevExpress.XtraEditors.PanelControl();
            this.btCancelOpenRelation = new DevExpress.XtraEditors.SimpleButton();
            this.btOkOpenRelation = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxOpenRelation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenRelation)).BeginInit();
            this.panelControlOpenRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOpenRelation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlOpenRelation
            // 
            this.panelControlOpenRelation.Controls.Add(this.btCancelOpenRelation);
            this.panelControlOpenRelation.Controls.Add(this.btOkOpenRelation);
            this.panelControlOpenRelation.Controls.Add(this.comboBoxOpenRelation);
            this.panelControlOpenRelation.Controls.Add(this.labelControl1);
            this.panelControlOpenRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlOpenRelation.Location = new System.Drawing.Point(0, 0);
            this.panelControlOpenRelation.Name = "panelControlOpenRelation";
            this.panelControlOpenRelation.Size = new System.Drawing.Size(455, 92);
            this.panelControlOpenRelation.TabIndex = 0;
            // 
            // btCancelOpenRelation
            // 
            this.btCancelOpenRelation.Location = new System.Drawing.Point(365, 57);
            this.btCancelOpenRelation.Name = "btCancelOpenRelation";
            this.btCancelOpenRelation.Size = new System.Drawing.Size(75, 23);
            this.btCancelOpenRelation.TabIndex = 5;
            this.btCancelOpenRelation.Text = "&Cancel";
            this.btCancelOpenRelation.Click += new System.EventHandler(this.btCancelOpenRelation_Click);
            // 
            // btOkOpenRelation
            // 
            this.btOkOpenRelation.Location = new System.Drawing.Point(273, 57);
            this.btOkOpenRelation.Name = "btOkOpenRelation";
            this.btOkOpenRelation.Size = new System.Drawing.Size(75, 23);
            this.btOkOpenRelation.TabIndex = 1;
            this.btOkOpenRelation.Text = "&OK";
            this.btOkOpenRelation.Click += new System.EventHandler(this.btOkOpenRelation_Click);
            // 
            // comboBoxOpenRelation
            // 
            this.comboBoxOpenRelation.Location = new System.Drawing.Point(100, 20);
            this.comboBoxOpenRelation.Name = "comboBoxOpenRelation";
            this.comboBoxOpenRelation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxOpenRelation.Size = new System.Drawing.Size(340, 20);
            this.comboBoxOpenRelation.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Choose relation :";
            // 
            // FrmOpenRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 92);
            this.Controls.Add(this.panelControlOpenRelation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(471, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(471, 131);
            this.Name = "FrmOpenRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Relation";
            this.Load += new System.EventHandler(this.FrmOpenRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlOpenRelation)).EndInit();
            this.panelControlOpenRelation.ResumeLayout(false);
            this.panelControlOpenRelation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxOpenRelation.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlOpenRelation;
        private DevExpress.XtraEditors.SimpleButton btCancelOpenRelation;
        private DevExpress.XtraEditors.SimpleButton btOkOpenRelation;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxOpenRelation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}