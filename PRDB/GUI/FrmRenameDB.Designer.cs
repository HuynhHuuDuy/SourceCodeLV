namespace FPRDB.GUI
{
    partial class FrmRenameDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenameDB));
            this.panelControlRenameDB = new DevExpress.XtraEditors.PanelControl();
            this.txtNewNameDB = new DevExpress.XtraEditors.TextEdit();
            this.btCancelRenameDB = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveRenameDB = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProviderRenameDB = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRenameDB)).BeginInit();
            this.panelControlRenameDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewNameDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderRenameDB)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlRenameDB
            // 
            this.panelControlRenameDB.Controls.Add(this.txtNewNameDB);
            this.panelControlRenameDB.Controls.Add(this.btCancelRenameDB);
            this.panelControlRenameDB.Controls.Add(this.btSaveRenameDB);
            this.panelControlRenameDB.Controls.Add(this.labelControl1);
            this.panelControlRenameDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlRenameDB.Location = new System.Drawing.Point(0, 0);
            this.panelControlRenameDB.Name = "panelControlRenameDB";
            this.panelControlRenameDB.Size = new System.Drawing.Size(507, 92);
            this.panelControlRenameDB.TabIndex = 0;
            // 
            // txtNewNameDB
            // 
            this.txtNewNameDB.Location = new System.Drawing.Point(125, 20);
            this.txtNewNameDB.Name = "txtNewNameDB";
            this.txtNewNameDB.Properties.Mask.BeepOnError = true;
            this.txtNewNameDB.Properties.Mask.EditMask = "[a-zA-Z][a-zA-Z0-9]+";
            this.txtNewNameDB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNewNameDB.Properties.Mask.ShowPlaceHolders = false;
            this.txtNewNameDB.Size = new System.Drawing.Size(370, 20);
            this.txtNewNameDB.TabIndex = 0;
            // 
            // btCancelRenameDB
            // 
            this.btCancelRenameDB.Location = new System.Drawing.Point(420, 57);
            this.btCancelRenameDB.Name = "btCancelRenameDB";
            this.btCancelRenameDB.Size = new System.Drawing.Size(75, 23);
            this.btCancelRenameDB.TabIndex = 5;
            this.btCancelRenameDB.Text = "&Cancel";
            this.btCancelRenameDB.Click += new System.EventHandler(this.btCancelRenameDB_Click);
            // 
            // btSaveRenameDB
            // 
            this.btSaveRenameDB.Location = new System.Drawing.Point(328, 57);
            this.btSaveRenameDB.Name = "btSaveRenameDB";
            this.btSaveRenameDB.Size = new System.Drawing.Size(75, 23);
            this.btSaveRenameDB.TabIndex = 1;
            this.btSaveRenameDB.Text = "&Save";
            this.btSaveRenameDB.Click += new System.EventHandler(this.btSaveRenameDB_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Enter database name:";
            // 
            // dxErrorProviderRenameDB
            // 
            this.dxErrorProviderRenameDB.ContainerControl = this;
            // 
            // FrmRenameDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 92);
            this.Controls.Add(this.panelControlRenameDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(523, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 131);
            this.Name = "FrmRenameDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rename Database";
            this.Load += new System.EventHandler(this.FrmRenameDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRenameDB)).EndInit();
            this.panelControlRenameDB.ResumeLayout(false);
            this.panelControlRenameDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewNameDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderRenameDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlRenameDB;
        private DevExpress.XtraEditors.SimpleButton btCancelRenameDB;
        private DevExpress.XtraEditors.SimpleButton btSaveRenameDB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNewNameDB;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProviderRenameDB;
    }
}