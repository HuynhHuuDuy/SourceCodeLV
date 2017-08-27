namespace FPRDB.GUI
{
    partial class FrmAddContinuousFuzzySet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddContinuousFuzzySet));
            this.panelCtrolNewConsFuzzy = new DevExpress.XtraEditors.PanelControl();
            this.btCancelConFuzzy = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveConFuzzy = new DevExpress.XtraEditors.SimpleButton();
            this.txtBotRight = new DevExpress.XtraEditors.TextEdit();
            this.txtTopRight = new DevExpress.XtraEditors.TextEdit();
            this.txtTopLeft = new DevExpress.XtraEditors.TextEdit();
            this.txtBotLeft = new DevExpress.XtraEditors.TextEdit();
            this.txtNameConsFuzzy = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrolNewConsFuzzy)).BeginInit();
            this.panelCtrolNewConsFuzzy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameConsFuzzy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCtrolNewConsFuzzy
            // 
            this.panelCtrolNewConsFuzzy.Controls.Add(this.btCancelConFuzzy);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.btSaveConFuzzy);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.txtBotRight);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.txtTopRight);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.txtTopLeft);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.txtBotLeft);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.txtNameConsFuzzy);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.labelControl6);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.labelControl5);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.labelControl4);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.labelControl3);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.labelControl2);
            this.panelCtrolNewConsFuzzy.Controls.Add(this.labelControl1);
            this.panelCtrolNewConsFuzzy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrolNewConsFuzzy.Location = new System.Drawing.Point(0, 0);
            this.panelCtrolNewConsFuzzy.Name = "panelCtrolNewConsFuzzy";
            this.panelCtrolNewConsFuzzy.Size = new System.Drawing.Size(384, 268);
            this.panelCtrolNewConsFuzzy.TabIndex = 0;
            // 
            // btCancelConFuzzy
            // 
            this.btCancelConFuzzy.Location = new System.Drawing.Point(283, 226);
            this.btCancelConFuzzy.Name = "btCancelConFuzzy";
            this.btCancelConFuzzy.Size = new System.Drawing.Size(75, 23);
            this.btCancelConFuzzy.TabIndex = 6;
            this.btCancelConFuzzy.Text = "&Cancel";
            this.btCancelConFuzzy.Click += new System.EventHandler(this.btCancelConFuzzy_Click);
            // 
            // btSaveConFuzzy
            // 
            this.btSaveConFuzzy.Location = new System.Drawing.Point(188, 226);
            this.btSaveConFuzzy.Name = "btSaveConFuzzy";
            this.btSaveConFuzzy.Size = new System.Drawing.Size(75, 23);
            this.btSaveConFuzzy.TabIndex = 5;
            this.btSaveConFuzzy.Text = "&Save";
            this.btSaveConFuzzy.Click += new System.EventHandler(this.btSaveConFuzzy_Click);
            // 
            // txtBotRight
            // 
            this.txtBotRight.Location = new System.Drawing.Point(139, 189);
            this.txtBotRight.Name = "txtBotRight";
            this.txtBotRight.Properties.Mask.BeepOnError = true;
            this.txtBotRight.Properties.Mask.EditMask = "(\\d+(\\R.\\d+)?)";
            this.txtBotRight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBotRight.Properties.Mask.ShowPlaceHolders = false;
            this.txtBotRight.Size = new System.Drawing.Size(188, 20);
            this.txtBotRight.TabIndex = 4;
            // 
            // txtTopRight
            // 
            this.txtTopRight.Location = new System.Drawing.Point(139, 156);
            this.txtTopRight.Name = "txtTopRight";
            this.txtTopRight.Properties.Mask.BeepOnError = true;
            this.txtTopRight.Properties.Mask.EditMask = "(\\d+(\\R.\\d+)?)";
            this.txtTopRight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTopRight.Properties.Mask.ShowPlaceHolders = false;
            this.txtTopRight.Size = new System.Drawing.Size(188, 20);
            this.txtTopRight.TabIndex = 3;
            // 
            // txtTopLeft
            // 
            this.txtTopLeft.Location = new System.Drawing.Point(139, 123);
            this.txtTopLeft.Name = "txtTopLeft";
            this.txtTopLeft.Properties.Mask.BeepOnError = true;
            this.txtTopLeft.Properties.Mask.EditMask = "(\\d+(\\R.\\d+)?)";
            this.txtTopLeft.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTopLeft.Properties.Mask.ShowPlaceHolders = false;
            this.txtTopLeft.Size = new System.Drawing.Size(188, 20);
            this.txtTopLeft.TabIndex = 2;
            // 
            // txtBotLeft
            // 
            this.txtBotLeft.Location = new System.Drawing.Point(139, 88);
            this.txtBotLeft.Name = "txtBotLeft";
            this.txtBotLeft.Properties.Mask.BeepOnError = true;
            this.txtBotLeft.Properties.Mask.EditMask = "(\\d+(\\R.\\d+)?)";
            this.txtBotLeft.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBotLeft.Properties.Mask.ShowPlaceHolders = false;
            this.txtBotLeft.Size = new System.Drawing.Size(188, 20);
            this.txtBotLeft.TabIndex = 1;
            // 
            // txtNameConsFuzzy
            // 
            this.txtNameConsFuzzy.Location = new System.Drawing.Point(122, 21);
            this.txtNameConsFuzzy.Name = "txtNameConsFuzzy";
            this.txtNameConsFuzzy.Size = new System.Drawing.Size(236, 20);
            this.txtNameConsFuzzy.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(55, 196);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Bottom-Right:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 163);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Top-Right:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Top-Left:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Bottom-Left:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(155, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "X-Coordinates for the FuzzySet:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Linguistic Lable:";
            // 
            // FrmAddContinuousFuzzySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 268);
            this.Controls.Add(this.panelCtrolNewConsFuzzy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 307);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 307);
            this.Name = "FrmAddContinuousFuzzySet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Continuous FuzzySet";
            this.Load += new System.EventHandler(this.FrmAddContinuousFuzzySet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrolNewConsFuzzy)).EndInit();
            this.panelCtrolNewConsFuzzy.ResumeLayout(false);
            this.panelCtrolNewConsFuzzy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameConsFuzzy.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelCtrolNewConsFuzzy;
        private DevExpress.XtraEditors.SimpleButton btCancelConFuzzy;
        private DevExpress.XtraEditors.SimpleButton btSaveConFuzzy;
        private DevExpress.XtraEditors.TextEdit txtBotRight;
        private DevExpress.XtraEditors.TextEdit txtTopRight;
        private DevExpress.XtraEditors.TextEdit txtTopLeft;
        private DevExpress.XtraEditors.TextEdit txtBotLeft;
        private DevExpress.XtraEditors.TextEdit txtNameConsFuzzy;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}