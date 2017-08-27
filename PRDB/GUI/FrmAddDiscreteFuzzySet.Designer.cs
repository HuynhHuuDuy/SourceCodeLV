namespace FPRDB.GUI
{
    partial class FrmAddDiscreteFuzzySet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddDiscreteFuzzySet));
            this.panelControlNewDis = new DevExpress.XtraEditors.PanelControl();
            this.btCancelDis = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveDis = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDisCreteFuzzy = new DevExpress.XtraGrid.GridControl();
            this.gridViewDisCreteFuzzy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnValueDis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnMembershipDis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtNewNameDis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNewDis)).BeginInit();
            this.panelControlNewDis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDisCreteFuzzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisCreteFuzzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewNameDis.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlNewDis
            // 
            this.panelControlNewDis.Controls.Add(this.btCancelDis);
            this.panelControlNewDis.Controls.Add(this.btSaveDis);
            this.panelControlNewDis.Controls.Add(this.gridControlDisCreteFuzzy);
            this.panelControlNewDis.Controls.Add(this.txtNewNameDis);
            this.panelControlNewDis.Controls.Add(this.labelControl1);
            this.panelControlNewDis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlNewDis.Location = new System.Drawing.Point(0, 0);
            this.panelControlNewDis.Name = "panelControlNewDis";
            this.panelControlNewDis.Size = new System.Drawing.Size(406, 312);
            this.panelControlNewDis.TabIndex = 0;
            // 
            // btCancelDis
            // 
            this.btCancelDis.Location = new System.Drawing.Point(308, 272);
            this.btCancelDis.Name = "btCancelDis";
            this.btCancelDis.Size = new System.Drawing.Size(75, 23);
            this.btCancelDis.TabIndex = 3;
            this.btCancelDis.Text = "&Cancel";
            this.btCancelDis.Click += new System.EventHandler(this.btCancelDis_Click);
            // 
            // btSaveDis
            // 
            this.btSaveDis.Location = new System.Drawing.Point(210, 272);
            this.btSaveDis.Name = "btSaveDis";
            this.btSaveDis.Size = new System.Drawing.Size(75, 23);
            this.btSaveDis.TabIndex = 2;
            this.btSaveDis.Text = "&Save";
            this.btSaveDis.Click += new System.EventHandler(this.btSaveDis_Click);
            // 
            // gridControlDisCreteFuzzy
            // 
            this.gridControlDisCreteFuzzy.Location = new System.Drawing.Point(23, 57);
            this.gridControlDisCreteFuzzy.MainView = this.gridViewDisCreteFuzzy;
            this.gridControlDisCreteFuzzy.Name = "gridControlDisCreteFuzzy";
            this.gridControlDisCreteFuzzy.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gridControlDisCreteFuzzy.Size = new System.Drawing.Size(360, 200);
            this.gridControlDisCreteFuzzy.TabIndex = 1;
            this.gridControlDisCreteFuzzy.UseEmbeddedNavigator = true;
            this.gridControlDisCreteFuzzy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDisCreteFuzzy});
            this.gridControlDisCreteFuzzy.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControlDisCreteFuzzy_ProcessGridKey);
            // 
            // gridViewDisCreteFuzzy
            // 
            this.gridViewDisCreteFuzzy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnValueDis,
            this.gridColumnMembershipDis});
            this.gridViewDisCreteFuzzy.GridControl = this.gridControlDisCreteFuzzy;
            this.gridViewDisCreteFuzzy.Name = "gridViewDisCreteFuzzy";
            this.gridViewDisCreteFuzzy.OptionsView.ShowGroupPanel = false;
            this.gridViewDisCreteFuzzy.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewDisCreteFuzzy_InvalidRowException);
            this.gridViewDisCreteFuzzy.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewDisCreteFuzzy_ValidateRow);
            // 
            // gridColumnValueDis
            // 
            this.gridColumnValueDis.Caption = "Value";
            this.gridColumnValueDis.ColumnEdit = this.repositoryItemTextEdit2;
            this.gridColumnValueDis.FieldName = "gridColumnValueDis";
            this.gridColumnValueDis.Name = "gridColumnValueDis";
            this.gridColumnValueDis.Visible = true;
            this.gridColumnValueDis.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "(\\d+(\\R.\\d+)?)";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gridColumnMembershipDis
            // 
            this.gridColumnMembershipDis.Caption = "Membership";
            this.gridColumnMembershipDis.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumnMembershipDis.FieldName = "gridColumnMembershipDis";
            this.gridColumnMembershipDis.Name = "gridColumnMembershipDis";
            this.gridColumnMembershipDis.Visible = true;
            this.gridColumnMembershipDis.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.BeepOnError = true;
            this.repositoryItemTextEdit1.Mask.EditMask = "(0(\\R.)(\\d+)?)|(1(\\R.)0)";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit1.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // txtNewNameDis
            // 
            this.txtNewNameDis.Location = new System.Drawing.Point(118, 20);
            this.txtNewNameDis.Name = "txtNewNameDis";
            this.txtNewNameDis.Size = new System.Drawing.Size(234, 20);
            this.txtNewNameDis.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Linguistic Lable:";
            // 
            // FrmAddDiscreteFuzzySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 312);
            this.Controls.Add(this.panelControlNewDis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(422, 351);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 351);
            this.Name = "FrmAddDiscreteFuzzySet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DisCrete FuzzySet";
            this.Load += new System.EventHandler(this.FrmAddDiscreteFuzzySet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNewDis)).EndInit();
            this.panelControlNewDis.ResumeLayout(false);
            this.panelControlNewDis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDisCreteFuzzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDisCreteFuzzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewNameDis.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlNewDis;
        private DevExpress.XtraEditors.SimpleButton btCancelDis;
        private DevExpress.XtraEditors.SimpleButton btSaveDis;
        private DevExpress.XtraGrid.GridControl gridControlDisCreteFuzzy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDisCreteFuzzy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValueDis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMembershipDis;
        private DevExpress.XtraEditors.TextEdit txtNewNameDis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}