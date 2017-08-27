namespace FPRDB.GUI
{
    partial class FrmNewSchema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewSchema));
            this.panelControlEditSchema = new DevExpress.XtraEditors.PanelControl();
            this.groupCtrSchemaAttr = new DevExpress.XtraEditors.GroupControl();
            this.gridControlNewSchema = new DevExpress.XtraGrid.GridControl();
            this.gridViewNewSchema = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColPrimaryKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckPrimarySchema = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColAttributeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlButtonNewSchema = new DevExpress.XtraEditors.PanelControl();
            this.biCancelNewSchema = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveNewSchema = new DevExpress.XtraEditors.SimpleButton();
            this.groupCtrNameSchema = new DevExpress.XtraEditors.GroupControl();
            this.txtSchemeName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProviderNewSchema = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlEditSchema)).BeginInit();
            this.panelControlEditSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrSchemaAttr)).BeginInit();
            this.groupCtrSchemaAttr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNewSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNewSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckPrimarySchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonNewSchema)).BeginInit();
            this.panelControlButtonNewSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrNameSchema)).BeginInit();
            this.groupCtrNameSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchemeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderNewSchema)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlEditSchema
            // 
            this.panelControlEditSchema.Controls.Add(this.groupCtrSchemaAttr);
            this.panelControlEditSchema.Controls.Add(this.panelControlButtonNewSchema);
            this.panelControlEditSchema.Controls.Add(this.groupCtrNameSchema);
            this.panelControlEditSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlEditSchema.Location = new System.Drawing.Point(0, 0);
            this.panelControlEditSchema.Name = "panelControlEditSchema";
            this.panelControlEditSchema.Size = new System.Drawing.Size(818, 458);
            this.panelControlEditSchema.TabIndex = 0;
            // 
            // groupCtrSchemaAttr
            // 
            this.groupCtrSchemaAttr.Controls.Add(this.gridControlNewSchema);
            this.groupCtrSchemaAttr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCtrSchemaAttr.Location = new System.Drawing.Point(2, 71);
            this.groupCtrSchemaAttr.Name = "groupCtrSchemaAttr";
            this.groupCtrSchemaAttr.Size = new System.Drawing.Size(814, 340);
            this.groupCtrSchemaAttr.TabIndex = 1;
            this.groupCtrSchemaAttr.Text = "Schema Attribute";
            // 
            // gridControlNewSchema
            // 
            this.gridControlNewSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNewSchema.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlNewSchema.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlNewSchema.Location = new System.Drawing.Point(2, 20);
            this.gridControlNewSchema.MainView = this.gridViewNewSchema;
            this.gridControlNewSchema.Name = "gridControlNewSchema";
            this.gridControlNewSchema.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckPrimarySchema});
            this.gridControlNewSchema.Size = new System.Drawing.Size(810, 318);
            this.gridControlNewSchema.TabIndex = 1;
            this.gridControlNewSchema.UseEmbeddedNavigator = true;
            this.gridControlNewSchema.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNewSchema});
            this.gridControlNewSchema.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControlNewSchema_ProcessGridKey);
            // 
            // gridViewNewSchema
            // 
            this.gridViewNewSchema.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColPrimaryKey,
            this.gridColAttributeName,
            this.gridColDataType,
            this.gridColDomain,
            this.gridColDescription});
            this.gridViewNewSchema.GridControl = this.gridControlNewSchema;
            this.gridViewNewSchema.Name = "gridViewNewSchema";
            this.gridViewNewSchema.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewNewSchema.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewNewSchema.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewNewSchema.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewNewSchema.OptionsView.ShowGroupPanel = false;
            this.gridViewNewSchema.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewNewSchema_RowCellClick);
            this.gridViewNewSchema.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewNewSchema_InvalidRowException);
            this.gridViewNewSchema.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewNewSchema_ValidateRow);
            // 
            // gridColPrimaryKey
            // 
            this.gridColPrimaryKey.Caption = "Primary Key";
            this.gridColPrimaryKey.ColumnEdit = this.repositoryItemCheckPrimarySchema;
            this.gridColPrimaryKey.FieldName = "gridColPrimaryKey";
            this.gridColPrimaryKey.Name = "gridColPrimaryKey";
            this.gridColPrimaryKey.Visible = true;
            this.gridColPrimaryKey.VisibleIndex = 0;
            // 
            // repositoryItemCheckPrimarySchema
            // 
            this.repositoryItemCheckPrimarySchema.AutoHeight = false;
            this.repositoryItemCheckPrimarySchema.Name = "repositoryItemCheckPrimarySchema";
            // 
            // gridColAttributeName
            // 
            this.gridColAttributeName.Caption = "Attribute Name";
            this.gridColAttributeName.FieldName = "gridColAttributeName";
            this.gridColAttributeName.Name = "gridColAttributeName";
            this.gridColAttributeName.OptionsEditForm.StartNewRow = true;
            this.gridColAttributeName.Visible = true;
            this.gridColAttributeName.VisibleIndex = 1;
            // 
            // gridColDataType
            // 
            this.gridColDataType.Caption = "Data Type";
            this.gridColDataType.FieldName = "gridColDataType";
            this.gridColDataType.Name = "gridColDataType";
            this.gridColDataType.OptionsColumn.AllowEdit = false;
            this.gridColDataType.OptionsColumn.ReadOnly = true;
            this.gridColDataType.Visible = true;
            this.gridColDataType.VisibleIndex = 2;
            // 
            // gridColDomain
            // 
            this.gridColDomain.Caption = "Domain";
            this.gridColDomain.FieldName = "gridColDomain";
            this.gridColDomain.Name = "gridColDomain";
            this.gridColDomain.OptionsColumn.AllowEdit = false;
            this.gridColDomain.OptionsColumn.ReadOnly = true;
            this.gridColDomain.Visible = true;
            this.gridColDomain.VisibleIndex = 3;
            // 
            // gridColDescription
            // 
            this.gridColDescription.Caption = "Description";
            this.gridColDescription.FieldName = "gridColDescription";
            this.gridColDescription.Name = "gridColDescription";
            this.gridColDescription.Visible = true;
            this.gridColDescription.VisibleIndex = 4;
            // 
            // panelControlButtonNewSchema
            // 
            this.panelControlButtonNewSchema.Controls.Add(this.biCancelNewSchema);
            this.panelControlButtonNewSchema.Controls.Add(this.btSaveNewSchema);
            this.panelControlButtonNewSchema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButtonNewSchema.Location = new System.Drawing.Point(2, 411);
            this.panelControlButtonNewSchema.Name = "panelControlButtonNewSchema";
            this.panelControlButtonNewSchema.Size = new System.Drawing.Size(814, 45);
            this.panelControlButtonNewSchema.TabIndex = 2;
            // 
            // biCancelNewSchema
            // 
            this.biCancelNewSchema.Location = new System.Drawing.Point(705, 12);
            this.biCancelNewSchema.Name = "biCancelNewSchema";
            this.biCancelNewSchema.Size = new System.Drawing.Size(75, 23);
            this.biCancelNewSchema.TabIndex = 1;
            this.biCancelNewSchema.Text = "&Cancel";
            this.biCancelNewSchema.Click += new System.EventHandler(this.biCancelNewSchema_Click);
            // 
            // btSaveNewSchema
            // 
            this.btSaveNewSchema.Location = new System.Drawing.Point(610, 12);
            this.btSaveNewSchema.Name = "btSaveNewSchema";
            this.btSaveNewSchema.Size = new System.Drawing.Size(75, 23);
            this.btSaveNewSchema.TabIndex = 2;
            this.btSaveNewSchema.Text = "&Save";
            this.btSaveNewSchema.Click += new System.EventHandler(this.btSaveNewSchema_Click);
            // 
            // groupCtrNameSchema
            // 
            this.groupCtrNameSchema.Controls.Add(this.txtSchemeName);
            this.groupCtrNameSchema.Controls.Add(this.labelControl1);
            this.groupCtrNameSchema.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCtrNameSchema.Location = new System.Drawing.Point(2, 2);
            this.groupCtrNameSchema.Name = "groupCtrNameSchema";
            this.groupCtrNameSchema.Size = new System.Drawing.Size(814, 69);
            this.groupCtrNameSchema.TabIndex = 0;
            this.groupCtrNameSchema.Text = "Schema Name";
            // 
            // txtSchemeName
            // 
            this.txtSchemeName.Location = new System.Drawing.Point(118, 30);
            this.txtSchemeName.Margin = new System.Windows.Forms.Padding(8);
            this.txtSchemeName.Name = "txtSchemeName";
            this.txtSchemeName.Properties.Mask.BeepOnError = true;
            this.txtSchemeName.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.txtSchemeName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSchemeName.Properties.Mask.ShowPlaceHolders = false;
            this.txtSchemeName.Size = new System.Drawing.Size(414, 20);
            this.txtSchemeName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Schema Name:";
            // 
            // dxErrorProviderNewSchema
            // 
            this.dxErrorProviderNewSchema.ContainerControl = this;
            // 
            // FrmNewSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.panelControlEditSchema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmNewSchema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Schema";
            this.Load += new System.EventHandler(this.FrmNewSchema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlEditSchema)).EndInit();
            this.panelControlEditSchema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrSchemaAttr)).EndInit();
            this.groupCtrSchemaAttr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNewSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNewSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckPrimarySchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonNewSchema)).EndInit();
            this.panelControlButtonNewSchema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrNameSchema)).EndInit();
            this.groupCtrNameSchema.ResumeLayout(false);
            this.groupCtrNameSchema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchemeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderNewSchema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlEditSchema;
        private DevExpress.XtraEditors.GroupControl groupCtrNameSchema;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupCtrSchemaAttr;
        private DevExpress.XtraGrid.GridControl gridControlNewSchema;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNewSchema;
        private DevExpress.XtraGrid.Columns.GridColumn gridColPrimaryKey;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckPrimarySchema;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAttributeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDataType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDomain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDescription;
        private DevExpress.XtraEditors.PanelControl panelControlButtonNewSchema;
        private DevExpress.XtraEditors.SimpleButton biCancelNewSchema;
        private DevExpress.XtraEditors.SimpleButton btSaveNewSchema;
        private DevExpress.XtraEditors.TextEdit txtSchemeName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProviderNewSchema;
    }
}