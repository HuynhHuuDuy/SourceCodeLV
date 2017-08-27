namespace FPRDB.GUI
{
    partial class FrmEditSchema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSchema));
            this.panelControlEditSchema = new DevExpress.XtraEditors.PanelControl();
            this.groupCtrSchemaAttr = new DevExpress.XtraEditors.GroupControl();
            this.gridControlEditSchema = new DevExpress.XtraGrid.GridControl();
            this.gridViewEditSchema = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColPrimaryKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckPrimarySchema = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColAttributeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlButtonEditSchema = new DevExpress.XtraEditors.PanelControl();
            this.biCancelEditSchema = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveEditSchema = new DevExpress.XtraEditors.SimpleButton();
            this.groupCtrlListSchema = new DevExpress.XtraEditors.GroupControl();
            this.lblInfomation = new DevExpress.XtraEditors.LabelControl();
            this.txtSchemeName = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxListSchema = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCurrentName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlEditSchema)).BeginInit();
            this.panelControlEditSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrSchemaAttr)).BeginInit();
            this.groupCtrSchemaAttr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEditSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEditSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckPrimarySchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonEditSchema)).BeginInit();
            this.panelControlButtonEditSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlListSchema)).BeginInit();
            this.groupCtrlListSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchemeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxListSchema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlEditSchema
            // 
            this.panelControlEditSchema.Controls.Add(this.groupCtrSchemaAttr);
            this.panelControlEditSchema.Controls.Add(this.panelControlButtonEditSchema);
            this.panelControlEditSchema.Controls.Add(this.groupCtrlListSchema);
            this.panelControlEditSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlEditSchema.Location = new System.Drawing.Point(0, 0);
            this.panelControlEditSchema.Name = "panelControlEditSchema";
            this.panelControlEditSchema.Size = new System.Drawing.Size(818, 458);
            this.panelControlEditSchema.TabIndex = 0;
            // 
            // groupCtrSchemaAttr
            // 
            this.groupCtrSchemaAttr.Controls.Add(this.gridControlEditSchema);
            this.groupCtrSchemaAttr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCtrSchemaAttr.Location = new System.Drawing.Point(2, 104);
            this.groupCtrSchemaAttr.Name = "groupCtrSchemaAttr";
            this.groupCtrSchemaAttr.Size = new System.Drawing.Size(814, 307);
            this.groupCtrSchemaAttr.TabIndex = 3;
            this.groupCtrSchemaAttr.Text = "Schema Attribute";
            // 
            // gridControlEditSchema
            // 
            this.gridControlEditSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEditSchema.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControlEditSchema.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlEditSchema.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControlEditSchema.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlEditSchema.Location = new System.Drawing.Point(2, 20);
            this.gridControlEditSchema.MainView = this.gridViewEditSchema;
            this.gridControlEditSchema.Name = "gridControlEditSchema";
            this.gridControlEditSchema.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckPrimarySchema});
            this.gridControlEditSchema.Size = new System.Drawing.Size(810, 285);
            this.gridControlEditSchema.TabIndex = 2;
            this.gridControlEditSchema.UseEmbeddedNavigator = true;
            this.gridControlEditSchema.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEditSchema});
            this.gridControlEditSchema.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControlEditSchema_ProcessGridKey);
            // 
            // gridViewEditSchema
            // 
            this.gridViewEditSchema.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColPrimaryKey,
            this.gridColAttributeName,
            this.gridColDataType,
            this.gridColDomain,
            this.gridColDescription});
            this.gridViewEditSchema.GridControl = this.gridControlEditSchema;
            this.gridViewEditSchema.Name = "gridViewEditSchema";
            this.gridViewEditSchema.OptionsCustomization.AllowFilter = false;
            this.gridViewEditSchema.OptionsCustomization.AllowSort = false;
            this.gridViewEditSchema.OptionsFilter.AllowMRUFilterList = false;
            this.gridViewEditSchema.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewEditSchema.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewEditSchema.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewEditSchema.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewEditSchema.OptionsView.ShowGroupPanel = false;
            this.gridViewEditSchema.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewEditSchema_RowCellClick);
            this.gridViewEditSchema.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewEditSchema_InvalidRowException);
            this.gridViewEditSchema.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewEditSchema_ValidateRow);
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
            // panelControlButtonEditSchema
            // 
            this.panelControlButtonEditSchema.Controls.Add(this.biCancelEditSchema);
            this.panelControlButtonEditSchema.Controls.Add(this.btSaveEditSchema);
            this.panelControlButtonEditSchema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButtonEditSchema.Location = new System.Drawing.Point(2, 411);
            this.panelControlButtonEditSchema.Name = "panelControlButtonEditSchema";
            this.panelControlButtonEditSchema.Size = new System.Drawing.Size(814, 45);
            this.panelControlButtonEditSchema.TabIndex = 2;
            // 
            // biCancelEditSchema
            // 
            this.biCancelEditSchema.Location = new System.Drawing.Point(705, 12);
            this.biCancelEditSchema.Name = "biCancelEditSchema";
            this.biCancelEditSchema.Size = new System.Drawing.Size(75, 23);
            this.biCancelEditSchema.TabIndex = 5;
            this.biCancelEditSchema.Text = "&Cancel";
            this.biCancelEditSchema.Click += new System.EventHandler(this.biCancelEditSchema_Click);
            // 
            // btSaveEditSchema
            // 
            this.btSaveEditSchema.Location = new System.Drawing.Point(610, 12);
            this.btSaveEditSchema.Name = "btSaveEditSchema";
            this.btSaveEditSchema.Size = new System.Drawing.Size(75, 23);
            this.btSaveEditSchema.TabIndex = 4;
            this.btSaveEditSchema.Text = "&Save";
            this.btSaveEditSchema.Click += new System.EventHandler(this.btSaveEditSchema_Click);
            // 
            // groupCtrlListSchema
            // 
            this.groupCtrlListSchema.Controls.Add(this.lblInfomation);
            this.groupCtrlListSchema.Controls.Add(this.txtSchemeName);
            this.groupCtrlListSchema.Controls.Add(this.comboBoxListSchema);
            this.groupCtrlListSchema.Controls.Add(this.lblCurrentName);
            this.groupCtrlListSchema.Controls.Add(this.labelControl1);
            this.groupCtrlListSchema.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCtrlListSchema.Location = new System.Drawing.Point(2, 2);
            this.groupCtrlListSchema.Name = "groupCtrlListSchema";
            this.groupCtrlListSchema.Size = new System.Drawing.Size(814, 102);
            this.groupCtrlListSchema.TabIndex = 0;
            this.groupCtrlListSchema.Text = "List Schema";
            // 
            // lblInfomation
            // 
            this.lblInfomation.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInfomation.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblInfomation.Location = new System.Drawing.Point(502, 33);
            this.lblInfomation.Name = "lblInfomation";
            this.lblInfomation.Size = new System.Drawing.Size(278, 26);
            this.lblInfomation.TabIndex = 4;
            this.lblInfomation.Text = "(*) This schema is  is inherited by some relations.\r\n(*)  You can\'t edit !";
            // 
            // txtSchemeName
            // 
            this.txtSchemeName.Enabled = false;
            this.txtSchemeName.Location = new System.Drawing.Point(113, 70);
            this.txtSchemeName.Margin = new System.Windows.Forms.Padding(8);
            this.txtSchemeName.Name = "txtSchemeName";
            this.txtSchemeName.Properties.Mask.BeepOnError = true;
            this.txtSchemeName.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.txtSchemeName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSchemeName.Properties.Mask.ShowPlaceHolders = false;
            this.txtSchemeName.Size = new System.Drawing.Size(369, 20);
            this.txtSchemeName.TabIndex = 1;
            // 
            // comboBoxListSchema
            // 
            this.comboBoxListSchema.Location = new System.Drawing.Point(113, 30);
            this.comboBoxListSchema.Name = "comboBoxListSchema";
            this.comboBoxListSchema.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxListSchema.Size = new System.Drawing.Size(369, 20);
            this.comboBoxListSchema.TabIndex = 0;
            this.comboBoxListSchema.SelectedIndexChanged += new System.EventHandler(this.comboBoxListSchema_SelectedIndexChanged);
            // 
            // lblCurrentName
            // 
            this.lblCurrentName.Location = new System.Drawing.Point(26, 73);
            this.lblCurrentName.Name = "lblCurrentName";
            this.lblCurrentName.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentName.TabIndex = 1;
            this.lblCurrentName.Text = "Current name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Select a schema:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmEditSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.panelControlEditSchema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmEditSchema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Schema";
            this.Load += new System.EventHandler(this.FrmEditSchema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlEditSchema)).EndInit();
            this.panelControlEditSchema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrSchemaAttr)).EndInit();
            this.groupCtrSchemaAttr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEditSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEditSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckPrimarySchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonEditSchema)).EndInit();
            this.panelControlButtonEditSchema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupCtrlListSchema)).EndInit();
            this.groupCtrlListSchema.ResumeLayout(false);
            this.groupCtrlListSchema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchemeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxListSchema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlEditSchema;
        private DevExpress.XtraEditors.GroupControl groupCtrlListSchema;
        private DevExpress.XtraEditors.TextEdit txtSchemeName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxListSchema;
        private DevExpress.XtraEditors.LabelControl lblCurrentName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupCtrSchemaAttr;
        private DevExpress.XtraGrid.GridControl gridControlEditSchema;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEditSchema;
        private DevExpress.XtraGrid.Columns.GridColumn gridColPrimaryKey;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckPrimarySchema;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAttributeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDataType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDomain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDescription;
        private DevExpress.XtraEditors.PanelControl panelControlButtonEditSchema;
        private DevExpress.XtraEditors.LabelControl lblInfomation;
        private DevExpress.XtraEditors.SimpleButton biCancelEditSchema;
        private DevExpress.XtraEditors.SimpleButton btSaveEditSchema;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
    }
}