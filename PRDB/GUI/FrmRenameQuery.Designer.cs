namespace FPRDB.GUI
{
    partial class FrmRenameQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenameQuery));
            this.panelControlRenameQuery = new DevExpress.XtraEditors.PanelControl();
            this.txtRenameQuery = new DevExpress.XtraEditors.TextEdit();
            this.btCancelRenameQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveRenameQuery = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBox_RenameQuery = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRenameQuery)).BeginInit();
            this.panelControlRenameQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenameQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_RenameQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlRenameQuery
            // 
            this.panelControlRenameQuery.Controls.Add(this.txtRenameQuery);
            this.panelControlRenameQuery.Controls.Add(this.btCancelRenameQuery);
            this.panelControlRenameQuery.Controls.Add(this.btSaveRenameQuery);
            this.panelControlRenameQuery.Controls.Add(this.ComboBox_RenameQuery);
            this.panelControlRenameQuery.Controls.Add(this.labelControl3);
            this.panelControlRenameQuery.Controls.Add(this.labelControl2);
            this.panelControlRenameQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlRenameQuery.Location = new System.Drawing.Point(0, 0);
            this.panelControlRenameQuery.Name = "panelControlRenameQuery";
            this.panelControlRenameQuery.Size = new System.Drawing.Size(520, 148);
            this.panelControlRenameQuery.TabIndex = 0;
            // 
            // txtRenameQuery
            // 
            this.txtRenameQuery.Location = new System.Drawing.Point(171, 68);
            this.txtRenameQuery.Name = "txtRenameQuery";
            this.txtRenameQuery.Properties.Mask.BeepOnError = true;
            this.txtRenameQuery.Properties.Mask.EditMask = "[a-zA-Z][a-zA-Z0-9]+";
            this.txtRenameQuery.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRenameQuery.Properties.Mask.ShowPlaceHolders = false;
            this.txtRenameQuery.Size = new System.Drawing.Size(318, 20);
            this.txtRenameQuery.TabIndex = 1;
            // 
            // btCancelRenameQuery
            // 
            this.btCancelRenameQuery.Location = new System.Drawing.Point(414, 105);
            this.btCancelRenameQuery.Name = "btCancelRenameQuery";
            this.btCancelRenameQuery.Size = new System.Drawing.Size(75, 23);
            this.btCancelRenameQuery.TabIndex = 6;
            this.btCancelRenameQuery.Text = "&Cancel";
            this.btCancelRenameQuery.Click += new System.EventHandler(this.btCancelRenameQuery_Click);
            // 
            // btSaveRenameQuery
            // 
            this.btSaveRenameQuery.Location = new System.Drawing.Point(311, 105);
            this.btSaveRenameQuery.Name = "btSaveRenameQuery";
            this.btSaveRenameQuery.Size = new System.Drawing.Size(75, 23);
            this.btSaveRenameQuery.TabIndex = 2;
            this.btSaveRenameQuery.Text = "&Save";
            this.btSaveRenameQuery.Click += new System.EventHandler(this.btSaveRenameQuery_Click);
            // 
            // ComboBox_RenameQuery
            // 
            this.ComboBox_RenameQuery.Location = new System.Drawing.Point(171, 24);
            this.ComboBox_RenameQuery.Name = "ComboBox_RenameQuery";
            this.ComboBox_RenameQuery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBox_RenameQuery.Size = new System.Drawing.Size(318, 20);
            this.ComboBox_RenameQuery.TabIndex = 0;
            this.ComboBox_RenameQuery.SelectedIndexChanged += new System.EventHandler(this.ComboBox_RenameQuery_SelectedIndexChanged);
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
            this.labelControl2.Size = new System.Drawing.Size(135, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Choose a query to rename :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmRenameQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 148);
            this.Controls.Add(this.panelControlRenameQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 187);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 187);
            this.Name = "FrmRenameQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rename Query";
            this.Load += new System.EventHandler(this.FrmRenameQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRenameQuery)).EndInit();
            this.panelControlRenameQuery.ResumeLayout(false);
            this.panelControlRenameQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenameQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_RenameQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlRenameQuery;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btCancelRenameQuery;
        private DevExpress.XtraEditors.SimpleButton btSaveRenameQuery;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBox_RenameQuery;
        private DevExpress.XtraEditors.TextEdit txtRenameQuery;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;

    }
}