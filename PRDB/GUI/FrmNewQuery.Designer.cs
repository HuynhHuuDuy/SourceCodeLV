namespace FPRDB.GUI
{
    partial class FrmNewQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewQuery));
            this.panelControlDelQuery = new DevExpress.XtraEditors.PanelControl();
            this.txtQueryName = new DevExpress.XtraEditors.TextEdit();
            this.btCancelNewQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btOkNewQuery = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelQuery)).BeginInit();
            this.panelControlDelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlDelQuery
            // 
            this.panelControlDelQuery.Controls.Add(this.txtQueryName);
            this.panelControlDelQuery.Controls.Add(this.btCancelNewQuery);
            this.panelControlDelQuery.Controls.Add(this.btOkNewQuery);
            this.panelControlDelQuery.Controls.Add(this.labelControl1);
            this.panelControlDelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlDelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelControlDelQuery.Name = "panelControlDelQuery";
            this.panelControlDelQuery.Size = new System.Drawing.Size(428, 92);
            this.panelControlDelQuery.TabIndex = 0;
            // 
            // txtQueryName
            // 
            this.txtQueryName.Location = new System.Drawing.Point(108, 20);
            this.txtQueryName.Name = "txtQueryName";
            this.txtQueryName.Properties.Mask.BeepOnError = true;
            this.txtQueryName.Properties.Mask.EditMask = "[a-zA-Z][a-zA-Z0-9]+";
            this.txtQueryName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtQueryName.Properties.Mask.ShowPlaceHolders = false;
            this.txtQueryName.Size = new System.Drawing.Size(305, 20);
            this.txtQueryName.TabIndex = 0;
            // 
            // btCancelNewQuery
            // 
            this.btCancelNewQuery.Location = new System.Drawing.Point(336, 57);
            this.btCancelNewQuery.Name = "btCancelNewQuery";
            this.btCancelNewQuery.Size = new System.Drawing.Size(75, 23);
            this.btCancelNewQuery.TabIndex = 5;
            this.btCancelNewQuery.Text = "&Cancel";
            this.btCancelNewQuery.Click += new System.EventHandler(this.btCancelNewQuery_Click);
            // 
            // btOkNewQuery
            // 
            this.btOkNewQuery.Location = new System.Drawing.Point(244, 57);
            this.btOkNewQuery.Name = "btOkNewQuery";
            this.btOkNewQuery.Size = new System.Drawing.Size(75, 23);
            this.btOkNewQuery.TabIndex = 1;
            this.btOkNewQuery.Text = "&OK";
            this.btOkNewQuery.Click += new System.EventHandler(this.btOkNewQuery_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Enter query name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmNewQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 92);
            this.Controls.Add(this.panelControlDelQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(444, 131);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(444, 131);
            this.Name = "FrmNewQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Query";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDelQuery)).EndInit();
            this.panelControlDelQuery.ResumeLayout(false);
            this.panelControlDelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlDelQuery;
        private DevExpress.XtraEditors.SimpleButton btCancelNewQuery;
        private DevExpress.XtraEditors.SimpleButton btOkNewQuery;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtQueryName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}