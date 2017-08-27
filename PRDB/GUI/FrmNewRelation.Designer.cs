namespace FPRDB.GUI
{
    partial class FrmNewRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewRelation));
            this.panelControlCreateNewRel = new DevExpress.XtraEditors.PanelControl();
            this.btCancelCreateNewRel = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveCreateNewRel = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBox_RelationName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtRelationName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCreateNewRel)).BeginInit();
            this.panelControlCreateNewRel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_RelationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlCreateNewRel
            // 
            this.panelControlCreateNewRel.Controls.Add(this.btCancelCreateNewRel);
            this.panelControlCreateNewRel.Controls.Add(this.btSaveCreateNewRel);
            this.panelControlCreateNewRel.Controls.Add(this.ComboBox_RelationName);
            this.panelControlCreateNewRel.Controls.Add(this.txtRelationName);
            this.panelControlCreateNewRel.Controls.Add(this.labelControl3);
            this.panelControlCreateNewRel.Controls.Add(this.labelControl2);
            this.panelControlCreateNewRel.Controls.Add(this.labelControl1);
            this.panelControlCreateNewRel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlCreateNewRel.Location = new System.Drawing.Point(0, 0);
            this.panelControlCreateNewRel.Name = "panelControlCreateNewRel";
            this.panelControlCreateNewRel.Size = new System.Drawing.Size(459, 191);
            this.panelControlCreateNewRel.TabIndex = 0;
            // 
            // btCancelCreateNewRel
            // 
            this.btCancelCreateNewRel.Location = new System.Drawing.Point(353, 147);
            this.btCancelCreateNewRel.Name = "btCancelCreateNewRel";
            this.btCancelCreateNewRel.Size = new System.Drawing.Size(75, 23);
            this.btCancelCreateNewRel.TabIndex = 3;
            this.btCancelCreateNewRel.Text = "&Cancel";
            this.btCancelCreateNewRel.Click += new System.EventHandler(this.btCancelCreateNewRel_Click);
            // 
            // btSaveCreateNewRel
            // 
            this.btSaveCreateNewRel.Location = new System.Drawing.Point(255, 147);
            this.btSaveCreateNewRel.Name = "btSaveCreateNewRel";
            this.btSaveCreateNewRel.Size = new System.Drawing.Size(75, 23);
            this.btSaveCreateNewRel.TabIndex = 2;
            this.btSaveCreateNewRel.Text = "&Save";
            this.btSaveCreateNewRel.Click += new System.EventHandler(this.btSaveCreateNewRel_Click);
            // 
            // ComboBox_RelationName
            // 
            this.ComboBox_RelationName.Location = new System.Drawing.Point(128, 105);
            this.ComboBox_RelationName.Name = "ComboBox_RelationName";
            this.ComboBox_RelationName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBox_RelationName.Size = new System.Drawing.Size(300, 20);
            this.ComboBox_RelationName.TabIndex = 1;
            // 
            // txtRelationName
            // 
            this.txtRelationName.Location = new System.Drawing.Point(128, 61);
            this.txtRelationName.Name = "txtRelationName";
            this.txtRelationName.Properties.Mask.BeepOnError = true;
            this.txtRelationName.Properties.Mask.EditMask = "[a-zA-Z][a-zA-Z0-9]+";
            this.txtRelationName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRelationName.Properties.Mask.ShowPlaceHolders = false;
            this.txtRelationName.Size = new System.Drawing.Size(300, 20);
            this.txtRelationName.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Select Schema:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Relation Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Location = new System.Drawing.Point(107, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(241, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Create New Relation";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmNewRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 191);
            this.Controls.Add(this.panelControlCreateNewRel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 230);
            this.Name = "FrmNewRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Relation";
            this.Load += new System.EventHandler(this.FrmNewRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCreateNewRel)).EndInit();
            this.panelControlCreateNewRel.ResumeLayout(false);
            this.panelControlCreateNewRel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_RelationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlCreateNewRel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btCancelCreateNewRel;
        private DevExpress.XtraEditors.SimpleButton btSaveCreateNewRel;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBox_RelationName;
        private DevExpress.XtraEditors.TextEdit txtRelationName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;

    }
}