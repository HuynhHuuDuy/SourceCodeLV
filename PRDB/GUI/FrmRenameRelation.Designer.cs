namespace FPRDB.GUI
{
    partial class FrmRenameRelation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenameRelation));
            this.panelControlRenameRelation = new DevExpress.XtraEditors.PanelControl();
            this.txtRenameRelation = new DevExpress.XtraEditors.TextEdit();
            this.btCancelRenameRelation = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveRenameRelation = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBox_RenameRelation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRenameRelation)).BeginInit();
            this.panelControlRenameRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenameRelation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_RenameRelation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlRenameRelation
            // 
            this.panelControlRenameRelation.Controls.Add(this.txtRenameRelation);
            this.panelControlRenameRelation.Controls.Add(this.btCancelRenameRelation);
            this.panelControlRenameRelation.Controls.Add(this.btSaveRenameRelation);
            this.panelControlRenameRelation.Controls.Add(this.ComboBox_RenameRelation);
            this.panelControlRenameRelation.Controls.Add(this.labelControl3);
            this.panelControlRenameRelation.Controls.Add(this.labelControl2);
            this.panelControlRenameRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlRenameRelation.Location = new System.Drawing.Point(0, 0);
            this.panelControlRenameRelation.Name = "panelControlRenameRelation";
            this.panelControlRenameRelation.Size = new System.Drawing.Size(520, 148);
            this.panelControlRenameRelation.TabIndex = 0;
            // 
            // txtRenameRelation
            // 
            this.txtRenameRelation.Location = new System.Drawing.Point(171, 68);
            this.txtRenameRelation.Name = "txtRenameRelation";
            this.txtRenameRelation.Properties.Mask.BeepOnError = true;
            this.txtRenameRelation.Properties.Mask.EditMask = "[a-zA-Z][a-zA-Z0-9]+";
            this.txtRenameRelation.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRenameRelation.Properties.Mask.ShowPlaceHolders = false;
            this.txtRenameRelation.Size = new System.Drawing.Size(318, 20);
            this.txtRenameRelation.TabIndex = 1;
            // 
            // btCancelRenameRelation
            // 
            this.btCancelRenameRelation.Location = new System.Drawing.Point(414, 105);
            this.btCancelRenameRelation.Name = "btCancelRenameRelation";
            this.btCancelRenameRelation.Size = new System.Drawing.Size(75, 23);
            this.btCancelRenameRelation.TabIndex = 6;
            this.btCancelRenameRelation.Text = "&Cancel";
            this.btCancelRenameRelation.Click += new System.EventHandler(this.btCancelRenameRelation_Click);
            // 
            // btSaveRenameRelation
            // 
            this.btSaveRenameRelation.Location = new System.Drawing.Point(311, 105);
            this.btSaveRenameRelation.Name = "btSaveRenameRelation";
            this.btSaveRenameRelation.Size = new System.Drawing.Size(75, 23);
            this.btSaveRenameRelation.TabIndex = 2;
            this.btSaveRenameRelation.Text = "&Save";
            this.btSaveRenameRelation.Click += new System.EventHandler(this.btSaveRenameRelation_Click);
            // 
            // ComboBox_RenameRelation
            // 
            this.ComboBox_RenameRelation.Location = new System.Drawing.Point(171, 24);
            this.ComboBox_RenameRelation.Name = "ComboBox_RenameRelation";
            this.ComboBox_RenameRelation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBox_RenameRelation.Size = new System.Drawing.Size(318, 20);
            this.ComboBox_RenameRelation.TabIndex = 0;
            this.ComboBox_RenameRelation.SelectedIndexChanged += new System.EventHandler(this.ComboBox_RenameRelation_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Enter new name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(143, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Choose a relation to rename :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmRenameRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 148);
            this.Controls.Add(this.panelControlRenameRelation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 187);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 187);
            this.Name = "FrmRenameRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rename Relation";
            this.Load += new System.EventHandler(this.FrmRenameRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRenameRelation)).EndInit();
            this.panelControlRenameRelation.ResumeLayout(false);
            this.panelControlRenameRelation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenameRelation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_RenameRelation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlRenameRelation;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btCancelRenameRelation;
        private DevExpress.XtraEditors.SimpleButton btSaveRenameRelation;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBox_RenameRelation;
        private DevExpress.XtraEditors.TextEdit txtRenameRelation;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;

    }
}