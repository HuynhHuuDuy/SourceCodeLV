namespace FPRDB.GUI
{
    partial class FrmDelRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDelRelation));
            this.panelControlDelRelation = new DevExpress.XtraEditors.PanelControl();
            this.btCancelDelRelation = new DevExpress.XtraEditors.SimpleButton();
            this.btOkDelRelation = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxDelRelation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelRelation)).BeginInit();
            this.panelControlDelRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDelRelation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlDelRelation
            // 
            this.panelControlDelRelation.Controls.Add(this.btCancelDelRelation);
            this.panelControlDelRelation.Controls.Add(this.btOkDelRelation);
            this.panelControlDelRelation.Controls.Add(this.comboBoxDelRelation);
            this.panelControlDelRelation.Controls.Add(this.labelControl1);
            this.panelControlDelRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlDelRelation.Location = new System.Drawing.Point(0, 0);
            this.panelControlDelRelation.Name = "panelControlDelRelation";
            this.panelControlDelRelation.Size = new System.Drawing.Size(507, 92);
            this.panelControlDelRelation.TabIndex = 0;
            // 
            // btCancelDelRelation
            // 
            this.btCancelDelRelation.Location = new System.Drawing.Point(420, 57);
            this.btCancelDelRelation.Name = "btCancelDelRelation";
            this.btCancelDelRelation.Size = new System.Drawing.Size(75, 23);
            this.btCancelDelRelation.TabIndex = 2;
            this.btCancelDelRelation.Text = "&Cancel";
            this.btCancelDelRelation.Click += new System.EventHandler(this.btCancelDelRelation_Click);
            // 
            // btOkDelRelation
            // 
            this.btOkDelRelation.Location = new System.Drawing.Point(328, 57);
            this.btOkDelRelation.Name = "btOkDelRelation";
            this.btOkDelRelation.Size = new System.Drawing.Size(75, 23);
            this.btOkDelRelation.TabIndex = 1;
            this.btOkDelRelation.Text = "&OK";
            this.btOkDelRelation.Click += new System.EventHandler(this.btOkDelRelation_Click);
            // 
            // comboBoxDelRelation
            // 
            this.comboBoxDelRelation.Location = new System.Drawing.Point(155, 20);
            this.comboBoxDelRelation.Name = "comboBoxDelRelation";
            this.comboBoxDelRelation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxDelRelation.Size = new System.Drawing.Size(340, 20);
            this.comboBoxDelRelation.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Choose a relation to delete :";
            // 
            // FrmDelRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 92);
            this.Controls.Add(this.panelControlDelRelation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(523, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 131);
            this.Name = "FrmDelRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Relation";
            this.Load += new System.EventHandler(this.FrmDelRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelRelation)).EndInit();
            this.panelControlDelRelation.ResumeLayout(false);
            this.panelControlDelRelation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDelRelation.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlDelRelation;
        private DevExpress.XtraEditors.SimpleButton btCancelDelRelation;
        private DevExpress.XtraEditors.SimpleButton btOkDelRelation;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDelRelation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}