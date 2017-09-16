namespace FPRDB.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.RelationsplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.xtraTabControlDatabase = new DevExpress.XtraTab.XtraTabControl();
            this.SchemaXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlScheme = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPrimary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAttribute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDataType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.iNewDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iClose = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.iCloseCurrentSchema = new DevExpress.XtraBars.BarButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.iBoldFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iItalicFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iUnderlinedFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iLeftTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iCenterTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iRightTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.iNewSchema = new DevExpress.XtraBars.BarButtonItem();
            this.iEditSchema = new DevExpress.XtraBars.BarButtonItem();
            this.iOpenSchema = new DevExpress.XtraBars.BarButtonItem();
            this.iDeleteSchema = new DevExpress.XtraBars.BarButtonItem();
            this.iNewRelation = new DevExpress.XtraBars.BarButtonItem();
            this.iOpenRelation = new DevExpress.XtraBars.BarButtonItem();
            this.iDeleteRelation = new DevExpress.XtraBars.BarButtonItem();
            this.iCloseRelation = new DevExpress.XtraBars.BarButtonItem();
            this.iNewQuery = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveQuery = new DevExpress.XtraBars.BarButtonItem();
            this.iOpenQuery = new DevExpress.XtraBars.BarButtonItem();
            this.iDeleteQuery = new DevExpress.XtraBars.BarButtonItem();
            this.iCloseQuery = new DevExpress.XtraBars.BarButtonItem();
            this.iExcuteQuery = new DevExpress.XtraBars.BarButtonItem();
            this.iAddDiscrete = new DevExpress.XtraBars.BarButtonItem();
            this.iLibraryDiscrete = new DevExpress.XtraBars.BarButtonItem();
            this.iAddContinuous = new DevExpress.XtraBars.BarButtonItem();
            this.iLibraryContinuous = new DevExpress.XtraBars.BarButtonItem();
            this.iConjunctionIgnorance = new DevExpress.XtraBars.BarButtonItem();
            this.iConjunctionIndependence = new DevExpress.XtraBars.BarButtonItem();
            this.iConjunctionMutual = new DevExpress.XtraBars.BarButtonItem();
            this.iDisjunctionIgnorance = new DevExpress.XtraBars.BarButtonItem();
            this.iDisjunctionIndependence = new DevExpress.XtraBars.BarButtonItem();
            this.iDisjunctionMutual = new DevExpress.XtraBars.BarButtonItem();
            this.iDifferenceIgnorance = new DevExpress.XtraBars.BarButtonItem();
            this.iDifferenceIndependence = new DevExpress.XtraBars.BarButtonItem();
            this.iDiferenceMutual = new DevExpress.XtraBars.BarButtonItem();
            this.iEqualityIg = new DevExpress.XtraBars.BarButtonItem();
            this.iEqualityIn = new DevExpress.XtraBars.BarButtonItem();
            this.iEqualityMe = new DevExpress.XtraBars.BarButtonItem();
            this.iOperator = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveRelation = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.DatabaseRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SchemaRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileSchemaRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.closeSchemaribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RelationRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileRelationRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.closeRelationRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.QueryRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileQueryRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.conjunctionRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.disjunctionRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.differenceRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.equalityRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.operatorRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.excuteQueryribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.closeQueryribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.FuzzySetRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.discreteFuzzySetribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.continuousFuzzySetRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.RelationXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.RelationPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.gridControlRelation = new DevExpress.XtraGrid.GridControl();
            this.gridViewRelation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlValueRelation = new DevExpress.XtraGrid.GridControl();
            this.gridViewValueRelation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMinProb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaxProb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemoEditTxtValueRelation = new DevExpress.XtraEditors.MemoEdit();
            this.panelControlRelation = new DevExpress.XtraEditors.PanelControl();
            this.Checkbox_UD = new DevExpress.XtraEditors.CheckEdit();
            this.Checkbox_UUD = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaxProb = new DevExpress.XtraEditors.TextEdit();
            this.txtMinProb = new DevExpress.XtraEditors.TextEdit();
            this.QueryXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.memoEditTxtQuery = new System.Windows.Forms.RichTextBox();
            this.xtraTabControlResultQuery = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageQueryResult = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlResultQuery = new DevExpress.XtraGrid.GridControl();
            this.gridViewResultQuery = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPageMessage = new DevExpress.XtraTab.XtraTabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.FuzzysetXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ContextMenu_RelationNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuRelNode_OpenRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuRelNode_DeleteRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuRelNode_RenameRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Relation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuRelation_NewRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuRelation_DeleteRelations = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_QueryNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuQueryNode_OpenQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuQuery_DeleteQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuQuery_RenameQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Database = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuDB_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuDB_CloseDB = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Schema = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuSchema_NewSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuSchema_EditSchemas = new System.Windows.Forms.ToolStripMenuItem();
            this.openSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Query = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuQuery_NewQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuQuery_DeleteQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList_TreeView = new System.Windows.Forms.ImageList(this.components);
            this.ContextMenu_SchemaNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CTMenuSchNode_EditSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuSchNode_OpenSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.CTMenuSchNode_DeleteSchema = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelationsplitContainerControl)).BeginInit();
            this.RelationsplitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlDatabase)).BeginInit();
            this.xtraTabControlDatabase.SuspendLayout();
            this.SchemaXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            this.RelationXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RelationPanelControl)).BeginInit();
            this.RelationPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValueRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewValueRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoEditTxtValueRelation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRelation)).BeginInit();
            this.panelControlRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Checkbox_UD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkbox_UUD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxProb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinProb.Properties)).BeginInit();
            this.QueryXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlResultQuery)).BeginInit();
            this.xtraTabControlResultQuery.SuspendLayout();
            this.xtraTabPageQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResultQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResultQuery)).BeginInit();
            this.xtraTabPageMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            this.ContextMenu_RelationNode.SuspendLayout();
            this.ContextMenu_Relation.SuspendLayout();
            this.contextMenu_QueryNode.SuspendLayout();
            this.ContextMenu_Database.SuspendLayout();
            this.ContextMenu_Schema.SuspendLayout();
            this.ContextMenu_Query.SuspendLayout();
            this.ContextMenu_SchemaNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // RelationsplitContainerControl
            // 
            this.RelationsplitContainerControl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationsplitContainerControl.Appearance.Options.UseFont = true;
            this.RelationsplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelationsplitContainerControl.Location = new System.Drawing.Point(0, 162);
            this.RelationsplitContainerControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RelationsplitContainerControl.Name = "RelationsplitContainerControl";
            this.RelationsplitContainerControl.Padding = new System.Windows.Forms.Padding(10);
            this.RelationsplitContainerControl.Panel1.Controls.Add(this.TreeView);
            this.RelationsplitContainerControl.Panel1.Text = "PanelRelation";
            this.RelationsplitContainerControl.Panel2.Controls.Add(this.xtraTabControlDatabase);
            this.RelationsplitContainerControl.Panel2.Text = "Panel2";
            this.RelationsplitContainerControl.Size = new System.Drawing.Size(970, 406);
            this.RelationsplitContainerControl.SplitterPosition = 165;
            this.RelationsplitContainerControl.TabIndex = 0;
            this.RelationsplitContainerControl.Text = "RelationsplitContainerControl";
            // 
            // TreeView
            // 
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView.Location = new System.Drawing.Point(0, 0);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(165, 386);
            this.TreeView.TabIndex = 0;
            // 
            // xtraTabControlDatabase
            // 
            this.xtraTabControlDatabase.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControlDatabase.Appearance.Options.UseFont = true;
            this.xtraTabControlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlDatabase.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlDatabase.Name = "xtraTabControlDatabase";
            this.xtraTabControlDatabase.SelectedTabPage = this.SchemaXtraTabPage;
            this.xtraTabControlDatabase.Size = new System.Drawing.Size(780, 386);
            this.xtraTabControlDatabase.TabIndex = 0;
            this.xtraTabControlDatabase.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.SchemaXtraTabPage,
            this.RelationXtraTabPage,
            this.QueryXtraTabPage,
            this.FuzzysetXtraTabPage});
            // 
            // SchemaXtraTabPage
            // 
            this.SchemaXtraTabPage.Controls.Add(this.gridControlScheme);
            this.SchemaXtraTabPage.Name = "SchemaXtraTabPage";
            this.SchemaXtraTabPage.Size = new System.Drawing.Size(774, 358);
            this.SchemaXtraTabPage.Text = "Schema";
            // 
            // gridControlScheme
            // 
            this.gridControlScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlScheme.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControlScheme.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlScheme.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridControlScheme.Location = new System.Drawing.Point(0, 0);
            this.gridControlScheme.MainView = this.gridView;
            this.gridControlScheme.MenuManager = this.ribbonControl;
            this.gridControlScheme.Name = "gridControlScheme";
            this.gridControlScheme.Size = new System.Drawing.Size(774, 358);
            this.gridControlScheme.TabIndex = 1;
            this.gridControlScheme.UseEmbeddedNavigator = true;
            this.gridControlScheme.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPrimary,
            this.gridColumnAttribute,
            this.gridColumnDataType,
            this.gridColumnDomain,
            this.gridColumnDescription});
            this.gridView.GridControl = this.gridControlScheme;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnPrimary
            // 
            this.gridColumnPrimary.Caption = "Primary key";
            this.gridColumnPrimary.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumnPrimary.FieldName = "gridColumnPrimary";
            this.gridColumnPrimary.Name = "gridColumnPrimary";
            this.gridColumnPrimary.Visible = true;
            this.gridColumnPrimary.VisibleIndex = 0;
            // 
            // gridColumnAttribute
            // 
            this.gridColumnAttribute.Caption = "Attribute name";
            this.gridColumnAttribute.FieldName = "gridColumnAttribute";
            this.gridColumnAttribute.Name = "gridColumnAttribute";
            this.gridColumnAttribute.Visible = true;
            this.gridColumnAttribute.VisibleIndex = 1;
            // 
            // gridColumnDataType
            // 
            this.gridColumnDataType.Caption = "Data Type";
            this.gridColumnDataType.FieldName = "gridColumnDataType";
            this.gridColumnDataType.Name = "gridColumnDataType";
            this.gridColumnDataType.Visible = true;
            this.gridColumnDataType.VisibleIndex = 2;
            // 
            // gridColumnDomain
            // 
            this.gridColumnDomain.Caption = "Domain";
            this.gridColumnDomain.FieldName = "gridColumnDomain";
            this.gridColumnDomain.Name = "gridColumnDomain";
            this.gridColumnDomain.Visible = true;
            this.gridColumnDomain.VisibleIndex = 4;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Description";
            this.gridColumnDescription.FieldName = "gridColumnDescription";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 3;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.iNewDatabase,
            this.iOpen,
            this.iClose,
            this.iSave,
            this.iSaveAs,
            this.iCloseCurrentSchema,
            this.iHelp,
            this.iAbout,
            this.iBoldFontStyle,
            this.iItalicFontStyle,
            this.iUnderlinedFontStyle,
            this.iLeftTextAlign,
            this.iCenterTextAlign,
            this.iRightTextAlign,
            this.rgbiSkins,
            this.iExit,
            this.iNewSchema,
            this.iEditSchema,
            this.iOpenSchema,
            this.iDeleteSchema,
            this.iNewRelation,
            this.iOpenRelation,
            this.iDeleteRelation,
            this.iCloseRelation,
            this.iNewQuery,
            this.iSaveQuery,
            this.iOpenQuery,
            this.iDeleteQuery,
            this.iCloseQuery,
            this.iExcuteQuery,
            this.iAddDiscrete,
            this.iLibraryDiscrete,
            this.iAddContinuous,
            this.iLibraryContinuous,
            this.iConjunctionIgnorance,
            this.iConjunctionIndependence,
            this.iConjunctionMutual,
            this.iDisjunctionIgnorance,
            this.iDisjunctionIndependence,
            this.iDisjunctionMutual,
            this.iDifferenceIgnorance,
            this.iDifferenceIndependence,
            this.iDiferenceMutual,
            this.iEqualityIg,
            this.iEqualityIn,
            this.iEqualityMe,
            this.iOperator,
            this.iSaveRelation});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DatabaseRibbonPage,
            this.SchemaRibbonPage,
            this.RelationRibbonPage,
            this.QueryRibbonPage,
            this.FuzzySetRibbonPage,
            this.helpRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(970, 162);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iNewDatabase);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iOpen);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iSave);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iSaveAs);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.iNewDatabase);
            this.appMenu.ItemLinks.Add(this.iOpen);
            this.appMenu.ItemLinks.Add(this.iSave);
            this.appMenu.ItemLinks.Add(this.iExit);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            // 
            // iNewDatabase
            // 
            this.iNewDatabase.Caption = "New";
            this.iNewDatabase.Description = "Creates a new, blank database";
            this.iNewDatabase.Hint = "Creates a new, blank database";
            this.iNewDatabase.Id = 1;
            this.iNewDatabase.ImageIndex = 0;
            this.iNewDatabase.ImageUri.Uri = "AddNewDataSource";
            this.iNewDatabase.LargeImageIndex = 0;
            this.iNewDatabase.Name = "iNewDatabase";
            this.iNewDatabase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewDatabase_ItemClick);
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Open";
            this.iOpen.Description = "Opens a database.";
            this.iOpen.Hint = "Opens a database.";
            this.iOpen.Id = 2;
            this.iOpen.ImageIndex = 1;
            this.iOpen.LargeImageIndex = 1;
            this.iOpen.Name = "iOpen";
            this.iOpen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.iOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpen_ItemClick);
            // 
            // iSave
            // 
            this.iSave.Caption = "&Save";
            this.iSave.Description = "Saves the active database.";
            this.iSave.Hint = "Saves the active database.";
            this.iSave.Id = 16;
            this.iSave.ImageIndex = 4;
            this.iSave.LargeImageIndex = 4;
            this.iSave.Name = "iSave";
            this.iSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSave_ItemClick);
            // 
            // iExit
            // 
            this.iExit.Caption = "Exit";
            this.iExit.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iExit.Description = "Exit the program";
            this.iExit.Hint = "Exit the program";
            this.iExit.Id = 3;
            this.iExit.ImageIndex = 6;
            this.iExit.LargeImageIndex = 6;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
            // 
            // iClose
            // 
            this.iClose.Caption = "&Close";
            this.iClose.Description = "Closes the active database.";
            this.iClose.Hint = "Closes the active database.";
            this.iClose.Id = 3;
            this.iClose.ImageIndex = 2;
            this.iClose.LargeImageIndex = 2;
            this.iClose.Name = "iClose";
            this.iClose.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.iClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iClose_ItemClick);
            // 
            // iSaveAs
            // 
            this.iSaveAs.Caption = "Save As";
            this.iSaveAs.Description = "Saves the active database in a different location.";
            this.iSaveAs.Hint = "Saves the active database in a different location.";
            this.iSaveAs.Id = 17;
            this.iSaveAs.ImageIndex = 5;
            this.iSaveAs.LargeImageIndex = 5;
            this.iSaveAs.Name = "iSaveAs";
            this.iSaveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSaveAs_ItemClick);
            // 
            // iCloseCurrentSchema
            // 
            this.iCloseCurrentSchema.Caption = "Close";
            this.iCloseCurrentSchema.Description = "Close Current Schema";
            this.iCloseCurrentSchema.Hint = "Close Current Schema";
            this.iCloseCurrentSchema.Id = 20;
            this.iCloseCurrentSchema.ImageIndex = 2;
            this.iCloseCurrentSchema.LargeImageIndex = 2;
            this.iCloseCurrentSchema.Name = "iCloseCurrentSchema";
            this.iCloseCurrentSchema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iCloseCurrentSchema_ItemClick);
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Help";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageIndex = 7;
            this.iHelp.LargeImageIndex = 7;
            this.iHelp.Name = "iHelp";
            this.iHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iHelp_ItemClick);
            // 
            // iAbout
            // 
            this.iAbout.Caption = "About";
            this.iAbout.Description = "Displays general program information.";
            this.iAbout.Hint = "Displays general program information";
            this.iAbout.Id = 24;
            this.iAbout.ImageIndex = 8;
            this.iAbout.LargeImageIndex = 8;
            this.iAbout.Name = "iAbout";
            this.iAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAbout_ItemClick);
            // 
            // iBoldFontStyle
            // 
            this.iBoldFontStyle.Caption = "Bold";
            this.iBoldFontStyle.Id = 53;
            this.iBoldFontStyle.ImageIndex = 9;
            this.iBoldFontStyle.Name = "iBoldFontStyle";
            // 
            // iItalicFontStyle
            // 
            this.iItalicFontStyle.Caption = "Italic";
            this.iItalicFontStyle.Id = 54;
            this.iItalicFontStyle.ImageIndex = 10;
            this.iItalicFontStyle.Name = "iItalicFontStyle";
            // 
            // iUnderlinedFontStyle
            // 
            this.iUnderlinedFontStyle.Caption = "Underlined";
            this.iUnderlinedFontStyle.Id = 55;
            this.iUnderlinedFontStyle.ImageIndex = 11;
            this.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle";
            // 
            // iLeftTextAlign
            // 
            this.iLeftTextAlign.Caption = "Left";
            this.iLeftTextAlign.Id = 57;
            this.iLeftTextAlign.ImageIndex = 12;
            this.iLeftTextAlign.Name = "iLeftTextAlign";
            // 
            // iCenterTextAlign
            // 
            this.iCenterTextAlign.Caption = "Center";
            this.iCenterTextAlign.Id = 58;
            this.iCenterTextAlign.ImageIndex = 13;
            this.iCenterTextAlign.Name = "iCenterTextAlign";
            // 
            // iRightTextAlign
            // 
            this.iRightTextAlign.Caption = "Right";
            this.iRightTextAlign.Id = 59;
            this.iRightTextAlign.ImageIndex = 14;
            this.iRightTextAlign.Name = "iRightTextAlign";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // iNewSchema
            // 
            this.iNewSchema.Caption = "New";
            this.iNewSchema.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iNewSchema.Description = "Creates a new, blank schema";
            this.iNewSchema.Hint = "Creates a new, blank schema";
            this.iNewSchema.Id = 4;
            this.iNewSchema.ImageIndex = 0;
            this.iNewSchema.LargeImageIndex = 0;
            this.iNewSchema.Name = "iNewSchema";
            this.iNewSchema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewSchema_ItemClick);
            // 
            // iEditSchema
            // 
            this.iEditSchema.Caption = "Edit";
            this.iEditSchema.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iEditSchema.Description = "Edit the active schema.";
            this.iEditSchema.Hint = "Edit the active schema.";
            this.iEditSchema.Id = 5;
            this.iEditSchema.ImageUri.Uri = "Edit";
            this.iEditSchema.Name = "iEditSchema";
            this.iEditSchema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iEditSchema_ItemClick);
            // 
            // iOpenSchema
            // 
            this.iOpenSchema.Caption = "Open";
            this.iOpenSchema.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iOpenSchema.Description = "Open a schema";
            this.iOpenSchema.Hint = "Open a schema";
            this.iOpenSchema.Id = 6;
            this.iOpenSchema.ImageIndex = 1;
            this.iOpenSchema.ImageUri.Uri = "Open";
            this.iOpenSchema.LargeImageIndex = 1;
            this.iOpenSchema.Name = "iOpenSchema";
            this.iOpenSchema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpenSchema_ItemClick);
            // 
            // iDeleteSchema
            // 
            this.iDeleteSchema.Caption = "Delete";
            this.iDeleteSchema.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDeleteSchema.Description = "Delete current Schema. ";
            this.iDeleteSchema.Hint = "Delete current Schema. ";
            this.iDeleteSchema.Id = 7;
            this.iDeleteSchema.ImageUri.Uri = "Delete";
            this.iDeleteSchema.Name = "iDeleteSchema";
            this.iDeleteSchema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDeleteSchema_ItemClick);
            // 
            // iNewRelation
            // 
            this.iNewRelation.Caption = "New";
            this.iNewRelation.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iNewRelation.Description = "Creates a new, blank relation";
            this.iNewRelation.Hint = "Creates a new, blank relation";
            this.iNewRelation.Id = 8;
            this.iNewRelation.ImageIndex = 0;
            this.iNewRelation.LargeImageIndex = 0;
            this.iNewRelation.Name = "iNewRelation";
            this.iNewRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewRelation_ItemClick);
            // 
            // iOpenRelation
            // 
            this.iOpenRelation.Caption = "Open";
            this.iOpenRelation.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iOpenRelation.Description = "Open a relation.";
            this.iOpenRelation.Hint = "Open a relation.";
            this.iOpenRelation.Id = 9;
            this.iOpenRelation.ImageIndex = 1;
            this.iOpenRelation.LargeImageIndex = 1;
            this.iOpenRelation.Name = "iOpenRelation";
            this.iOpenRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpenRelation_ItemClick);
            // 
            // iDeleteRelation
            // 
            this.iDeleteRelation.Caption = "Delete";
            this.iDeleteRelation.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDeleteRelation.Description = "Delete current relation.";
            this.iDeleteRelation.Hint = "Delete current relation.";
            this.iDeleteRelation.Id = 10;
            this.iDeleteRelation.ImageUri.Uri = "Delete";
            this.iDeleteRelation.Name = "iDeleteRelation";
            this.iDeleteRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDeleteRelation_ItemClick);
            // 
            // iCloseRelation
            // 
            this.iCloseRelation.Caption = "Close";
            this.iCloseRelation.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iCloseRelation.Description = "Close current relation.";
            this.iCloseRelation.Enabled = false;
            this.iCloseRelation.Hint = "Close current relation.";
            this.iCloseRelation.Id = 11;
            this.iCloseRelation.ImageIndex = 2;
            this.iCloseRelation.LargeImageIndex = 2;
            this.iCloseRelation.Name = "iCloseRelation";
            this.iCloseRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iCloseRelation_ItemClick);
            // 
            // iNewQuery
            // 
            this.iNewQuery.Caption = "New";
            this.iNewQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iNewQuery.Description = "Creates a new, blank query";
            this.iNewQuery.Hint = "Creates a new, blank query";
            this.iNewQuery.Id = 1;
            this.iNewQuery.ImageIndex = 0;
            this.iNewQuery.LargeImageIndex = 0;
            this.iNewQuery.Name = "iNewQuery";
            this.iNewQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNewQuery_ItemClick);
            // 
            // iSaveQuery
            // 
            this.iSaveQuery.Caption = "Save";
            this.iSaveQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iSaveQuery.Description = "Save current query.";
            this.iSaveQuery.Enabled = false;
            this.iSaveQuery.Hint = "Save current query.";
            this.iSaveQuery.Id = 2;
            this.iSaveQuery.ImageIndex = 4;
            this.iSaveQuery.LargeImageIndex = 4;
            this.iSaveQuery.Name = "iSaveQuery";
            this.iSaveQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSaveQuery_ItemClick);
            // 
            // iOpenQuery
            // 
            this.iOpenQuery.Caption = "Open";
            this.iOpenQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iOpenQuery.Description = "Open a query.";
            this.iOpenQuery.Hint = "Open a query.";
            this.iOpenQuery.Id = 3;
            this.iOpenQuery.ImageIndex = 1;
            this.iOpenQuery.LargeImageIndex = 1;
            this.iOpenQuery.Name = "iOpenQuery";
            this.iOpenQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpenQuery_ItemClick);
            // 
            // iDeleteQuery
            // 
            this.iDeleteQuery.Caption = "Delete";
            this.iDeleteQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDeleteQuery.Description = "Delete current query.";
            this.iDeleteQuery.Hint = "Delete current query.";
            this.iDeleteQuery.Id = 4;
            this.iDeleteQuery.ImageUri.Uri = "Delete";
            this.iDeleteQuery.Name = "iDeleteQuery";
            this.iDeleteQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDeleteQuery_ItemClick);
            // 
            // iCloseQuery
            // 
            this.iCloseQuery.Caption = "Close";
            this.iCloseQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iCloseQuery.Description = "Close current query.";
            this.iCloseQuery.Hint = "Close current query.";
            this.iCloseQuery.Id = 5;
            this.iCloseQuery.ImageIndex = 2;
            this.iCloseQuery.LargeImageIndex = 2;
            this.iCloseQuery.Name = "iCloseQuery";
            this.iCloseQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iCloseQuery_ItemClick);
            // 
            // iExcuteQuery
            // 
            this.iExcuteQuery.Caption = "Excute_Query";
            this.iExcuteQuery.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iExcuteQuery.Description = "Excute current query.";
            this.iExcuteQuery.Glyph = ((System.Drawing.Image)(resources.GetObject("iExcuteQuery.Glyph")));
            this.iExcuteQuery.Hint = "Excute current query.";
            this.iExcuteQuery.Id = 6;
            this.iExcuteQuery.ImageUri.Uri = "Apply";
            this.iExcuteQuery.Name = "iExcuteQuery";
            this.iExcuteQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExcuteQuery_ItemClick);
            // 
            // iAddDiscrete
            // 
            this.iAddDiscrete.Caption = "Add";
            this.iAddDiscrete.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iAddDiscrete.Description = "Add a discrete fuzzyset.";
            this.iAddDiscrete.Hint = "Add a discrete fuzzyset.";
            this.iAddDiscrete.Id = 7;
            this.iAddDiscrete.ImageUri.Uri = "AddItem";
            this.iAddDiscrete.Name = "iAddDiscrete";
            this.iAddDiscrete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAddDiscrete_ItemClick);
            // 
            // iLibraryDiscrete
            // 
            this.iLibraryDiscrete.Caption = "Library";
            this.iLibraryDiscrete.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iLibraryDiscrete.Description = "Discrete fuzzyset library.";
            this.iLibraryDiscrete.Hint = "Discrete fuzzyset library.";
            this.iLibraryDiscrete.Id = 8;
            this.iLibraryDiscrete.ImageUri.Uri = "Chart";
            this.iLibraryDiscrete.Name = "iLibraryDiscrete";
            this.iLibraryDiscrete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iLibraryDiscrete_ItemClick);
            // 
            // iAddContinuous
            // 
            this.iAddContinuous.Caption = "Add";
            this.iAddContinuous.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iAddContinuous.Description = "Add a continuous fuzzyset.";
            this.iAddContinuous.Hint = "Add a continuous fuzzyset.";
            this.iAddContinuous.Id = 9;
            this.iAddContinuous.ImageUri.Uri = "AddItem";
            this.iAddContinuous.Name = "iAddContinuous";
            this.iAddContinuous.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAddContinuous_ItemClick);
            // 
            // iLibraryContinuous
            // 
            this.iLibraryContinuous.Caption = "Library";
            this.iLibraryContinuous.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iLibraryContinuous.Description = "Continuous fuzzyset library.";
            this.iLibraryContinuous.Hint = "Continuous fuzzyset library.";
            this.iLibraryContinuous.Id = 10;
            this.iLibraryContinuous.ImageUri.Uri = "Pie";
            this.iLibraryContinuous.Name = "iLibraryContinuous";
            this.iLibraryContinuous.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iLibraryContinuous_ItemClick);
            // 
            // iConjunctionIgnorance
            // 
            this.iConjunctionIgnorance.Caption = "⊗_ig";
            this.iConjunctionIgnorance.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iConjunctionIgnorance.Description = "⊗_ig (ignorance)";
            this.iConjunctionIgnorance.Hint = "⊕_ig (ignorance)";
            this.iConjunctionIgnorance.Id = 11;
            this.iConjunctionIgnorance.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemAppearance.Disabled.Options.UseFont = true;
            this.iConjunctionIgnorance.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemAppearance.Hovered.Options.UseFont = true;
            this.iConjunctionIgnorance.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemAppearance.Normal.Options.UseFont = true;
            this.iConjunctionIgnorance.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemAppearance.Pressed.Options.UseFont = true;
            this.iConjunctionIgnorance.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iConjunctionIgnorance.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iConjunctionIgnorance.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iConjunctionIgnorance.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIgnorance.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iConjunctionIgnorance.Name = "iConjunctionIgnorance";
            this.iConjunctionIgnorance.SmallWithTextWidth = 85;
            this.iConjunctionIgnorance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iConjunctionIgnorance_ItemClick);
            // 
            // iConjunctionIndependence
            // 
            this.iConjunctionIndependence.Caption = "⊗_in";
            this.iConjunctionIndependence.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iConjunctionIndependence.Description = "⊗_in (independence)";
            this.iConjunctionIndependence.Hint = "⊗_in (independence)";
            this.iConjunctionIndependence.Id = 12;
            this.iConjunctionIndependence.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemAppearance.Disabled.Options.UseFont = true;
            this.iConjunctionIndependence.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemAppearance.Hovered.Options.UseFont = true;
            this.iConjunctionIndependence.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemAppearance.Normal.Options.UseFont = true;
            this.iConjunctionIndependence.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemAppearance.Pressed.Options.UseFont = true;
            this.iConjunctionIndependence.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iConjunctionIndependence.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iConjunctionIndependence.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iConjunctionIndependence.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionIndependence.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iConjunctionIndependence.Name = "iConjunctionIndependence";
            this.iConjunctionIndependence.SmallWithTextWidth = 85;
            this.iConjunctionIndependence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iConjunctionIndependence_ItemClick);
            // 
            // iConjunctionMutual
            // 
            this.iConjunctionMutual.Caption = "⊗_me";
            this.iConjunctionMutual.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iConjunctionMutual.Description = "⊗_me (mutual exclusion)";
            this.iConjunctionMutual.Hint = "⊗_me (mutual exclusion)";
            this.iConjunctionMutual.Id = 13;
            this.iConjunctionMutual.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemAppearance.Disabled.Options.UseFont = true;
            this.iConjunctionMutual.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemAppearance.Hovered.Options.UseFont = true;
            this.iConjunctionMutual.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemAppearance.Normal.Options.UseFont = true;
            this.iConjunctionMutual.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemAppearance.Pressed.Options.UseFont = true;
            this.iConjunctionMutual.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iConjunctionMutual.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iConjunctionMutual.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iConjunctionMutual.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iConjunctionMutual.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iConjunctionMutual.Name = "iConjunctionMutual";
            this.iConjunctionMutual.SmallWithTextWidth = 85;
            this.iConjunctionMutual.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iConjunctionMutual_ItemClick);
            // 
            // iDisjunctionIgnorance
            // 
            this.iDisjunctionIgnorance.Caption = "⊕_ig";
            this.iDisjunctionIgnorance.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDisjunctionIgnorance.Description = "⊕_ig (ignorance)";
            this.iDisjunctionIgnorance.Hint = "⊕_ig (ignorance)";
            this.iDisjunctionIgnorance.Id = 14;
            this.iDisjunctionIgnorance.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemAppearance.Disabled.Options.UseFont = true;
            this.iDisjunctionIgnorance.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemAppearance.Hovered.Options.UseFont = true;
            this.iDisjunctionIgnorance.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemAppearance.Normal.Options.UseFont = true;
            this.iDisjunctionIgnorance.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemAppearance.Pressed.Options.UseFont = true;
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIgnorance.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iDisjunctionIgnorance.Name = "iDisjunctionIgnorance";
            this.iDisjunctionIgnorance.SmallWithTextWidth = 80;
            this.iDisjunctionIgnorance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDisjunctionIgnorance_ItemClick);
            // 
            // iDisjunctionIndependence
            // 
            this.iDisjunctionIndependence.Caption = "⊕_in";
            this.iDisjunctionIndependence.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDisjunctionIndependence.Description = "⊕_in (independence)";
            this.iDisjunctionIndependence.Hint = "⊕_in (independence)";
            this.iDisjunctionIndependence.Id = 15;
            this.iDisjunctionIndependence.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemAppearance.Disabled.Options.UseFont = true;
            this.iDisjunctionIndependence.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemAppearance.Hovered.Options.UseFont = true;
            this.iDisjunctionIndependence.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemAppearance.Normal.Options.UseFont = true;
            this.iDisjunctionIndependence.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemAppearance.Pressed.Options.UseFont = true;
            this.iDisjunctionIndependence.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iDisjunctionIndependence.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iDisjunctionIndependence.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iDisjunctionIndependence.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionIndependence.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iDisjunctionIndependence.Name = "iDisjunctionIndependence";
            this.iDisjunctionIndependence.SmallWithTextWidth = 80;
            this.iDisjunctionIndependence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDisjunctionIndependence_ItemClick);
            // 
            // iDisjunctionMutual
            // 
            this.iDisjunctionMutual.Caption = "⊕_me";
            this.iDisjunctionMutual.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDisjunctionMutual.Description = "⊕_me (mutual exclusion)";
            this.iDisjunctionMutual.Hint = "⊕_me (mutual exclusion)";
            this.iDisjunctionMutual.Id = 16;
            this.iDisjunctionMutual.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemAppearance.Disabled.Options.UseFont = true;
            this.iDisjunctionMutual.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemAppearance.Hovered.Options.UseFont = true;
            this.iDisjunctionMutual.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemAppearance.Normal.Options.UseFont = true;
            this.iDisjunctionMutual.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemAppearance.Pressed.Options.UseFont = true;
            this.iDisjunctionMutual.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iDisjunctionMutual.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iDisjunctionMutual.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iDisjunctionMutual.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDisjunctionMutual.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iDisjunctionMutual.Name = "iDisjunctionMutual";
            this.iDisjunctionMutual.SmallWithTextWidth = 80;
            this.iDisjunctionMutual.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDisjunctionMutual_ItemClick);
            // 
            // iDifferenceIgnorance
            // 
            this.iDifferenceIgnorance.Caption = "⊖_ig";
            this.iDifferenceIgnorance.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDifferenceIgnorance.Description = "⊖_ig (ignorance)";
            this.iDifferenceIgnorance.Hint = "⊖_ig (ignorance)";
            this.iDifferenceIgnorance.Id = 17;
            this.iDifferenceIgnorance.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemAppearance.Disabled.Options.UseFont = true;
            this.iDifferenceIgnorance.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemAppearance.Hovered.Options.UseFont = true;
            this.iDifferenceIgnorance.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemAppearance.Normal.Options.UseFont = true;
            this.iDifferenceIgnorance.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemAppearance.Pressed.Options.UseFont = true;
            this.iDifferenceIgnorance.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iDifferenceIgnorance.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iDifferenceIgnorance.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iDifferenceIgnorance.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIgnorance.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iDifferenceIgnorance.Name = "iDifferenceIgnorance";
            this.iDifferenceIgnorance.SmallWithTextWidth = 80;
            this.iDifferenceIgnorance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDifferenceIgnorance_ItemClick);
            // 
            // iDifferenceIndependence
            // 
            this.iDifferenceIndependence.Caption = "⊖_in";
            this.iDifferenceIndependence.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDifferenceIndependence.Description = "⊖_in (independence)";
            this.iDifferenceIndependence.Hint = "⊖_in (independence)";
            this.iDifferenceIndependence.Id = 18;
            this.iDifferenceIndependence.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemAppearance.Disabled.Options.UseFont = true;
            this.iDifferenceIndependence.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemAppearance.Hovered.Options.UseFont = true;
            this.iDifferenceIndependence.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemAppearance.Normal.Options.UseFont = true;
            this.iDifferenceIndependence.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemAppearance.Pressed.Options.UseFont = true;
            this.iDifferenceIndependence.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iDifferenceIndependence.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iDifferenceIndependence.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iDifferenceIndependence.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDifferenceIndependence.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iDifferenceIndependence.Name = "iDifferenceIndependence";
            this.iDifferenceIndependence.SmallWithTextWidth = 80;
            this.iDifferenceIndependence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDifferenceIndependence_ItemClick);
            // 
            // iDiferenceMutual
            // 
            this.iDiferenceMutual.Caption = "⊖_me";
            this.iDiferenceMutual.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iDiferenceMutual.Description = "⊖_me (mutual exclusion)";
            this.iDiferenceMutual.Hint = "⊖_me (mutual exclusion)";
            this.iDiferenceMutual.Id = 19;
            this.iDiferenceMutual.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemAppearance.Disabled.Options.UseFont = true;
            this.iDiferenceMutual.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemAppearance.Hovered.Options.UseFont = true;
            this.iDiferenceMutual.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemAppearance.Normal.Options.UseFont = true;
            this.iDiferenceMutual.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemAppearance.Pressed.Options.UseFont = true;
            this.iDiferenceMutual.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iDiferenceMutual.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iDiferenceMutual.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iDiferenceMutual.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDiferenceMutual.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iDiferenceMutual.Name = "iDiferenceMutual";
            this.iDiferenceMutual.SmallWithTextWidth = 80;
            this.iDiferenceMutual.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iDiferenceMutual_ItemClick);
            // 
            // iEqualityIg
            // 
            this.iEqualityIg.Caption = "EQUAL_ig";
            this.iEqualityIg.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iEqualityIg.Description = "EQUAL_ig - ignorance";
            this.iEqualityIg.Hint = "EQUAL_ig - ignorance";
            this.iEqualityIg.Id = 20;
            this.iEqualityIg.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iEqualityIg.ItemAppearance.Disabled.Options.UseFont = true;
            this.iEqualityIg.Name = "iEqualityIg";
            this.iEqualityIg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iEqualityIg_ItemClick);
            // 
            // iEqualityIn
            // 
            this.iEqualityIn.Caption = "EQUAL_in";
            this.iEqualityIn.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iEqualityIn.Description = "EQUAL_in - independence";
            this.iEqualityIn.Hint = "EQUAL_in - independence";
            this.iEqualityIn.Id = 21;
            this.iEqualityIn.Name = "iEqualityIn";
            this.iEqualityIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iEqualityIn_ItemClick);
            // 
            // iEqualityMe
            // 
            this.iEqualityMe.Caption = "EQUAL_me";
            this.iEqualityMe.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iEqualityMe.Description = "EQUAL_me - mutual exclusion";
            this.iEqualityMe.Hint = "EQUAL_me - mutual exclusion";
            this.iEqualityMe.Id = 22;
            this.iEqualityMe.Name = "iEqualityMe";
            this.iEqualityMe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iEqualityMe_ItemClick);
            // 
            // iOperator
            // 
            this.iOperator.Caption = "→";
            this.iOperator.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iOperator.Description = "Operator";
            this.iOperator.Hint = "Operator";
            this.iOperator.Id = 23;
            this.iOperator.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemAppearance.Disabled.Options.UseFont = true;
            this.iOperator.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemAppearance.Hovered.Options.UseFont = true;
            this.iOperator.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemAppearance.Normal.Options.UseFont = true;
            this.iOperator.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemAppearance.Pressed.Options.UseFont = true;
            this.iOperator.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.iOperator.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.iOperator.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.iOperator.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iOperator.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.iOperator.Name = "iOperator";
            this.iOperator.SmallWithTextWidth = 80;
            this.iOperator.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOperator_ItemClick);
            // 
            // iSaveRelation
            // 
            this.iSaveRelation.Caption = "Save";
            this.iSaveRelation.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.iSaveRelation.Description = "Save current relation.";
            this.iSaveRelation.Enabled = false;
            this.iSaveRelation.Id = 3;
            this.iSaveRelation.ImageIndex = 4;
            this.iSaveRelation.LargeImageIndex = 4;
            this.iSaveRelation.Name = "iSaveRelation";
            this.iSaveRelation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSaveRelation_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            // 
            // DatabaseRibbonPage
            // 
            this.DatabaseRibbonPage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseRibbonPage.Appearance.Options.UseFont = true;
            this.DatabaseRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRibbonPageGroup,
            this.skinsRibbonPageGroup,
            this.exitRibbonPageGroup});
            this.DatabaseRibbonPage.Image = ((System.Drawing.Image)(resources.GetObject("DatabaseRibbonPage.Image")));
            this.DatabaseRibbonPage.Name = "DatabaseRibbonPage";
            this.DatabaseRibbonPage.Text = "Home Database";
            // 
            // fileRibbonPageGroup
            // 
            this.fileRibbonPageGroup.ItemLinks.Add(this.iNewDatabase);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iOpen);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iClose);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iSave);
            this.fileRibbonPageGroup.ItemLinks.Add(this.iSaveAs);
            this.fileRibbonPageGroup.Name = "fileRibbonPageGroup";
            this.fileRibbonPageGroup.Text = "File";
            // 
            // skinsRibbonPageGroup
            // 
            this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
            this.skinsRibbonPageGroup.ShowCaptionButton = false;
            this.skinsRibbonPageGroup.Text = "Skins";
            // 
            // exitRibbonPageGroup
            // 
            this.exitRibbonPageGroup.ItemLinks.Add(this.iExit);
            this.exitRibbonPageGroup.Name = "exitRibbonPageGroup";
            this.exitRibbonPageGroup.Text = "Exit";
            // 
            // SchemaRibbonPage
            // 
            this.SchemaRibbonPage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchemaRibbonPage.Appearance.Options.UseFont = true;
            this.SchemaRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileSchemaRibbonPageGroup,
            this.closeSchemaribbonPageGroup});
            this.SchemaRibbonPage.Name = "SchemaRibbonPage";
            this.SchemaRibbonPage.Text = "Scheme";
            // 
            // fileSchemaRibbonPageGroup
            // 
            this.fileSchemaRibbonPageGroup.ItemLinks.Add(this.iNewSchema);
            this.fileSchemaRibbonPageGroup.ItemLinks.Add(this.iEditSchema);
            this.fileSchemaRibbonPageGroup.ItemLinks.Add(this.iOpenSchema);
            this.fileSchemaRibbonPageGroup.ItemLinks.Add(this.iDeleteSchema);
            this.fileSchemaRibbonPageGroup.Name = "fileSchemaRibbonPageGroup";
            this.fileSchemaRibbonPageGroup.Text = "File";
            // 
            // closeSchemaribbonPageGroup
            // 
            this.closeSchemaribbonPageGroup.ItemLinks.Add(this.iCloseCurrentSchema);
            this.closeSchemaribbonPageGroup.Name = "closeSchemaribbonPageGroup";
            this.closeSchemaribbonPageGroup.Text = "Close";
            // 
            // RelationRibbonPage
            // 
            this.RelationRibbonPage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationRibbonPage.Appearance.Options.UseFont = true;
            this.RelationRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRelationRibbonPageGroup,
            this.closeRelationRibbonPageGroup});
            this.RelationRibbonPage.Name = "RelationRibbonPage";
            this.RelationRibbonPage.Text = "Relation";
            // 
            // fileRelationRibbonPageGroup
            // 
            this.fileRelationRibbonPageGroup.ItemLinks.Add(this.iNewRelation);
            this.fileRelationRibbonPageGroup.ItemLinks.Add(this.iOpenRelation);
            this.fileRelationRibbonPageGroup.ItemLinks.Add(this.iDeleteRelation);
            this.fileRelationRibbonPageGroup.ItemLinks.Add(this.iSaveRelation);
            this.fileRelationRibbonPageGroup.Name = "fileRelationRibbonPageGroup";
            this.fileRelationRibbonPageGroup.Text = "File";
            // 
            // closeRelationRibbonPageGroup
            // 
            this.closeRelationRibbonPageGroup.ItemLinks.Add(this.iCloseRelation);
            this.closeRelationRibbonPageGroup.Name = "closeRelationRibbonPageGroup";
            this.closeRelationRibbonPageGroup.Text = "Close";
            // 
            // QueryRibbonPage
            // 
            this.QueryRibbonPage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryRibbonPage.Appearance.Options.UseFont = true;
            this.QueryRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileQueryRibbonPageGroup,
            this.conjunctionRibbonPageGroup,
            this.disjunctionRibbonPageGroup,
            this.differenceRibbonPageGroup,
            this.equalityRibbonPageGroup,
            this.operatorRibbonPageGroup,
            this.excuteQueryribbonPageGroup,
            this.closeQueryribbonPageGroup});
            this.QueryRibbonPage.Name = "QueryRibbonPage";
            this.QueryRibbonPage.Text = "Query";
            // 
            // fileQueryRibbonPageGroup
            // 
            this.fileQueryRibbonPageGroup.ItemLinks.Add(this.iNewQuery);
            this.fileQueryRibbonPageGroup.ItemLinks.Add(this.iOpenQuery);
            this.fileQueryRibbonPageGroup.ItemLinks.Add(this.iSaveQuery);
            this.fileQueryRibbonPageGroup.ItemLinks.Add(this.iDeleteQuery);
            this.fileQueryRibbonPageGroup.Name = "fileQueryRibbonPageGroup";
            this.fileQueryRibbonPageGroup.Text = "File";
            // 
            // conjunctionRibbonPageGroup
            // 
            this.conjunctionRibbonPageGroup.ItemLinks.Add(this.iConjunctionIgnorance);
            this.conjunctionRibbonPageGroup.ItemLinks.Add(this.iConjunctionIndependence);
            this.conjunctionRibbonPageGroup.ItemLinks.Add(this.iConjunctionMutual);
            this.conjunctionRibbonPageGroup.Name = "conjunctionRibbonPageGroup";
            this.conjunctionRibbonPageGroup.Text = "Conjunction";
            // 
            // disjunctionRibbonPageGroup
            // 
            this.disjunctionRibbonPageGroup.ItemLinks.Add(this.iDisjunctionIgnorance);
            this.disjunctionRibbonPageGroup.ItemLinks.Add(this.iDisjunctionIndependence);
            this.disjunctionRibbonPageGroup.ItemLinks.Add(this.iDisjunctionMutual);
            this.disjunctionRibbonPageGroup.Name = "disjunctionRibbonPageGroup";
            this.disjunctionRibbonPageGroup.Text = "Disjunction";
            // 
            // differenceRibbonPageGroup
            // 
            this.differenceRibbonPageGroup.ItemLinks.Add(this.iDifferenceIgnorance);
            this.differenceRibbonPageGroup.ItemLinks.Add(this.iDifferenceIndependence);
            this.differenceRibbonPageGroup.ItemLinks.Add(this.iDiferenceMutual);
            this.differenceRibbonPageGroup.Name = "differenceRibbonPageGroup";
            this.differenceRibbonPageGroup.Text = "Difference";
            // 
            // equalityRibbonPageGroup
            // 
            this.equalityRibbonPageGroup.ItemLinks.Add(this.iEqualityIg);
            this.equalityRibbonPageGroup.ItemLinks.Add(this.iEqualityIn);
            this.equalityRibbonPageGroup.ItemLinks.Add(this.iEqualityMe);
            this.equalityRibbonPageGroup.Name = "equalityRibbonPageGroup";
            this.equalityRibbonPageGroup.Text = "Equality";
            // 
            // operatorRibbonPageGroup
            // 
            this.operatorRibbonPageGroup.ItemLinks.Add(this.iOperator);
            this.operatorRibbonPageGroup.Name = "operatorRibbonPageGroup";
            this.operatorRibbonPageGroup.Text = "Operator";
            // 
            // excuteQueryribbonPageGroup
            // 
            this.excuteQueryribbonPageGroup.ItemLinks.Add(this.iExcuteQuery);
            this.excuteQueryribbonPageGroup.Name = "excuteQueryribbonPageGroup";
            this.excuteQueryribbonPageGroup.Text = "Excute";
            // 
            // closeQueryribbonPageGroup
            // 
            this.closeQueryribbonPageGroup.ItemLinks.Add(this.iCloseQuery);
            this.closeQueryribbonPageGroup.Name = "closeQueryribbonPageGroup";
            this.closeQueryribbonPageGroup.Text = "Close";
            // 
            // FuzzySetRibbonPage
            // 
            this.FuzzySetRibbonPage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuzzySetRibbonPage.Appearance.Options.UseFont = true;
            this.FuzzySetRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.discreteFuzzySetribbonPageGroup,
            this.continuousFuzzySetRibbonPageGroup});
            this.FuzzySetRibbonPage.Name = "FuzzySetRibbonPage";
            this.FuzzySetRibbonPage.Text = "FuzzySet";
            // 
            // discreteFuzzySetribbonPageGroup
            // 
            this.discreteFuzzySetribbonPageGroup.ItemLinks.Add(this.iAddDiscrete);
            this.discreteFuzzySetribbonPageGroup.ItemLinks.Add(this.iLibraryDiscrete);
            this.discreteFuzzySetribbonPageGroup.Name = "discreteFuzzySetribbonPageGroup";
            this.discreteFuzzySetribbonPageGroup.Text = "Discrete";
            // 
            // continuousFuzzySetRibbonPageGroup
            // 
            this.continuousFuzzySetRibbonPageGroup.ItemLinks.Add(this.iAddContinuous);
            this.continuousFuzzySetRibbonPageGroup.ItemLinks.Add(this.iLibraryContinuous);
            this.continuousFuzzySetRibbonPageGroup.Name = "continuousFuzzySetRibbonPageGroup";
            this.continuousFuzzySetRibbonPageGroup.Text = "Continuous";
            // 
            // helpRibbonPage
            // 
            this.helpRibbonPage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpRibbonPage.Appearance.Options.UseFont = true;
            this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.helpRibbonPageGroup});
            this.helpRibbonPage.Name = "helpRibbonPage";
            this.helpRibbonPage.Text = "Help";
            // 
            // helpRibbonPageGroup
            // 
            this.helpRibbonPageGroup.ItemLinks.Add(this.iHelp);
            this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
            this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
            this.helpRibbonPageGroup.Text = "Help";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(970, 31);
            // 
            // RelationXtraTabPage
            // 
            this.RelationXtraTabPage.Controls.Add(this.splitContainerControl);
            this.RelationXtraTabPage.Name = "RelationXtraTabPage";
            this.RelationXtraTabPage.Size = new System.Drawing.Size(774, 358);
            this.RelationXtraTabPage.Text = "Relation";
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Horizontal = false;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.RelationPanelControl);
            this.splitContainerControl.Panel1.Text = "PanelRelation";
            this.splitContainerControl.Panel2.Controls.Add(this.gridControlValueRelation);
            this.splitContainerControl.Panel2.Controls.Add(this.MemoEditTxtValueRelation);
            this.splitContainerControl.Panel2.Controls.Add(this.panelControlRelation);
            this.splitContainerControl.Panel2.Text = "PanelValueRelation";
            this.splitContainerControl.Size = new System.Drawing.Size(774, 358);
            this.splitContainerControl.SplitterPosition = 199;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "RelationsplitContainerControl";
            // 
            // RelationPanelControl
            // 
            this.RelationPanelControl.Controls.Add(this.gridControlRelation);
            this.RelationPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelationPanelControl.Location = new System.Drawing.Point(0, 0);
            this.RelationPanelControl.Name = "RelationPanelControl";
            this.RelationPanelControl.Size = new System.Drawing.Size(774, 199);
            this.RelationPanelControl.TabIndex = 0;
            // 
            // gridControlRelation
            // 
            this.gridControlRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRelation.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlRelation.EmbeddedNavigator.Buttons.ImageList = this.ribbonImageCollection;
            this.gridControlRelation.Location = new System.Drawing.Point(2, 2);
            this.gridControlRelation.MainView = this.gridViewRelation;
            this.gridControlRelation.MenuManager = this.ribbonControl;
            this.gridControlRelation.Name = "gridControlRelation";
            this.gridControlRelation.Size = new System.Drawing.Size(770, 195);
            this.gridControlRelation.TabIndex = 0;
            this.gridControlRelation.UseEmbeddedNavigator = true;
            this.gridControlRelation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRelation});
            // 
            // gridViewRelation
            // 
            this.gridViewRelation.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewRelation.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewRelation.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewRelation.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewRelation.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewRelation.Appearance.Row.Options.UseFont = true;
            this.gridViewRelation.GridControl = this.gridControlRelation;
            this.gridViewRelation.Name = "gridViewRelation";
            this.gridViewRelation.OptionsBehavior.ReadOnly = true;
            this.gridViewRelation.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewRelation.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewRelation.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewRelation.OptionsView.ShowGroupPanel = false;
            this.gridViewRelation.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewRelation_RowCellClick);
            this.gridViewRelation.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewRelation_InvalidRowException);
            this.gridViewRelation.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewRelation_ValidateRow);
            // 
            // gridControlValueRelation
            // 
            this.gridControlValueRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlValueRelation.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlValueRelation.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlValueRelation.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControlValueRelation.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlValueRelation.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlValueRelation.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlValueRelation.Location = new System.Drawing.Point(0, 39);
            this.gridControlValueRelation.MainView = this.gridViewValueRelation;
            this.gridControlValueRelation.MenuManager = this.ribbonControl;
            this.gridControlValueRelation.Name = "gridControlValueRelation";
            this.gridControlValueRelation.Size = new System.Drawing.Size(774, 115);
            this.gridControlValueRelation.TabIndex = 12;
            this.gridControlValueRelation.UseEmbeddedNavigator = true;
            this.gridControlValueRelation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewValueRelation});
            // 
            // gridViewValueRelation
            // 
            this.gridViewValueRelation.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewValueRelation.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewValueRelation.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewValueRelation.Appearance.Row.Options.UseFont = true;
            this.gridViewValueRelation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnValue,
            this.gridColumnMinProb,
            this.gridColumnMaxProb});
            this.gridViewValueRelation.GridControl = this.gridControlValueRelation;
            this.gridViewValueRelation.Name = "gridViewValueRelation";
            this.gridViewValueRelation.OptionsBehavior.ReadOnly = true;
            this.gridViewValueRelation.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewValueRelation.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewValueRelation.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewValueRelation.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnValue
            // 
            this.gridColumnValue.Caption = "Value";
            this.gridColumnValue.FieldName = "gridColumnValue";
            this.gridColumnValue.Name = "gridColumnValue";
            this.gridColumnValue.OptionsColumn.ReadOnly = true;
            this.gridColumnValue.Visible = true;
            this.gridColumnValue.VisibleIndex = 0;
            // 
            // gridColumnMinProb
            // 
            this.gridColumnMinProb.Caption = "MinProb";
            this.gridColumnMinProb.FieldName = "gridColumnMinProb";
            this.gridColumnMinProb.Name = "gridColumnMinProb";
            this.gridColumnMinProb.OptionsColumn.ReadOnly = true;
            this.gridColumnMinProb.Visible = true;
            this.gridColumnMinProb.VisibleIndex = 1;
            // 
            // gridColumnMaxProb
            // 
            this.gridColumnMaxProb.Caption = "MaxProb";
            this.gridColumnMaxProb.FieldName = "gridColumnMaxProb";
            this.gridColumnMaxProb.Name = "gridColumnMaxProb";
            this.gridColumnMaxProb.OptionsColumn.ReadOnly = true;
            this.gridColumnMaxProb.Visible = true;
            this.gridColumnMaxProb.VisibleIndex = 2;
            // 
            // MemoEditTxtValueRelation
            // 
            this.MemoEditTxtValueRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoEditTxtValueRelation.Location = new System.Drawing.Point(0, 39);
            this.MemoEditTxtValueRelation.Name = "MemoEditTxtValueRelation";
            this.MemoEditTxtValueRelation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoEditTxtValueRelation.Properties.Appearance.Options.UseFont = true;
            this.MemoEditTxtValueRelation.Properties.ReadOnly = true;
            this.MemoEditTxtValueRelation.Size = new System.Drawing.Size(774, 115);
            this.MemoEditTxtValueRelation.TabIndex = 11;
            this.MemoEditTxtValueRelation.Visible = false;
            // 
            // panelControlRelation
            // 
            this.panelControlRelation.Controls.Add(this.Checkbox_UD);
            this.panelControlRelation.Controls.Add(this.Checkbox_UUD);
            this.panelControlRelation.Controls.Add(this.labelControl2);
            this.panelControlRelation.Controls.Add(this.labelControl1);
            this.panelControlRelation.Controls.Add(this.txtMaxProb);
            this.panelControlRelation.Controls.Add(this.txtMinProb);
            this.panelControlRelation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlRelation.Location = new System.Drawing.Point(0, 0);
            this.panelControlRelation.Name = "panelControlRelation";
            this.panelControlRelation.Size = new System.Drawing.Size(774, 39);
            this.panelControlRelation.TabIndex = 0;
            // 
            // Checkbox_UD
            // 
            this.Checkbox_UD.Location = new System.Drawing.Point(228, 11);
            this.Checkbox_UD.MenuManager = this.ribbonControl;
            this.Checkbox_UD.Name = "Checkbox_UD";
            this.Checkbox_UD.Properties.Caption = "Uniform Distribution";
            this.Checkbox_UD.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.Checkbox_UD.Properties.RadioGroupIndex = 1;
            this.Checkbox_UD.Size = new System.Drawing.Size(140, 19);
            this.Checkbox_UD.TabIndex = 23;
            this.Checkbox_UD.TabStop = false;
            this.Checkbox_UD.CheckedChanged += new System.EventHandler(this.Checkbox_UD_CheckedChanged);
            // 
            // Checkbox_UUD
            // 
            this.Checkbox_UUD.EditValue = true;
            this.Checkbox_UUD.Location = new System.Drawing.Point(27, 11);
            this.Checkbox_UUD.MenuManager = this.ribbonControl;
            this.Checkbox_UUD.Name = "Checkbox_UUD";
            this.Checkbox_UUD.Properties.Caption = "UnUniform Distribution";
            this.Checkbox_UUD.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.Checkbox_UUD.Properties.RadioGroupIndex = 1;
            this.Checkbox_UUD.Size = new System.Drawing.Size(144, 19);
            this.Checkbox_UUD.TabIndex = 22;
            this.Checkbox_UUD.CheckedChanged += new System.EventHandler(this.Checkbox_UUD_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(764, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Sum of MaxProb:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(506, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Sum of MinProb:";
            // 
            // txtMaxProb
            // 
            this.txtMaxProb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxProb.Enabled = false;
            this.txtMaxProb.Location = new System.Drawing.Point(862, 10);
            this.txtMaxProb.Name = "txtMaxProb";
            this.txtMaxProb.Properties.Mask.BeepOnError = true;
            this.txtMaxProb.Properties.Mask.EditMask = "[0-9.]+";
            this.txtMaxProb.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMaxProb.Properties.Mask.ShowPlaceHolders = false;
            this.txtMaxProb.Size = new System.Drawing.Size(772, 20);
            this.txtMaxProb.TabIndex = 19;
            // 
            // txtMinProb
            // 
            this.txtMinProb.Enabled = false;
            this.txtMinProb.Location = new System.Drawing.Point(599, 10);
            this.txtMinProb.Name = "txtMinProb";
            this.txtMinProb.Properties.Mask.BeepOnError = true;
            this.txtMinProb.Properties.Mask.EditMask = "[0-9.]+";
            this.txtMinProb.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMinProb.Properties.Mask.ShowPlaceHolders = false;
            this.txtMinProb.Size = new System.Drawing.Size(124, 20);
            this.txtMinProb.TabIndex = 18;
            // 
            // QueryXtraTabPage
            // 
            this.QueryXtraTabPage.Controls.Add(this.splitContainerControl1);
            this.QueryXtraTabPage.Name = "QueryXtraTabPage";
            this.QueryXtraTabPage.Size = new System.Drawing.Size(774, 358);
            this.QueryXtraTabPage.Text = "Query";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.memoEditTxtQuery);
            this.splitContainerControl1.Panel1.Text = "PanelQuery";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControlResultQuery);
            this.splitContainerControl1.Panel2.Text = "PanelResultQuery";
            this.splitContainerControl1.Size = new System.Drawing.Size(774, 358);
            this.splitContainerControl1.SplitterPosition = 132;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControlquery";
            // 
            // memoEditTxtQuery
            // 
            this.memoEditTxtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEditTxtQuery.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEditTxtQuery.ForeColor = System.Drawing.Color.Black;
            this.memoEditTxtQuery.Location = new System.Drawing.Point(0, 0);
            this.memoEditTxtQuery.Name = "memoEditTxtQuery";
            this.memoEditTxtQuery.Size = new System.Drawing.Size(774, 132);
            this.memoEditTxtQuery.TabIndex = 5;
            this.memoEditTxtQuery.Text = "";
            this.memoEditTxtQuery.TextChanged += new System.EventHandler(this.memoEditTxtQuery_TextChanged);
            // 
            // xtraTabControlResultQuery
            // 
            this.xtraTabControlResultQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControlResultQuery.Appearance.Options.UseFont = true;
            this.xtraTabControlResultQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlResultQuery.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlResultQuery.Name = "xtraTabControlResultQuery";
            this.xtraTabControlResultQuery.SelectedTabPage = this.xtraTabPageQueryResult;
            this.xtraTabControlResultQuery.Size = new System.Drawing.Size(774, 221);
            this.xtraTabControlResultQuery.TabIndex = 0;
            this.xtraTabControlResultQuery.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageQueryResult,
            this.xtraTabPageMessage});
            // 
            // xtraTabPageQueryResult
            // 
            this.xtraTabPageQueryResult.Appearance.PageClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPageQueryResult.Appearance.PageClient.Options.UseFont = true;
            this.xtraTabPageQueryResult.Controls.Add(this.gridControlResultQuery);
            this.xtraTabPageQueryResult.Name = "xtraTabPageQueryResult";
            this.xtraTabPageQueryResult.Size = new System.Drawing.Size(768, 193);
            this.xtraTabPageQueryResult.Text = "Query Result";
            // 
            // gridControlResultQuery
            // 
            this.gridControlResultQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlResultQuery.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlResultQuery.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlResultQuery.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlResultQuery.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlResultQuery.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlResultQuery.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.gridControlResultQuery.Location = new System.Drawing.Point(0, 0);
            this.gridControlResultQuery.MainView = this.gridViewResultQuery;
            this.gridControlResultQuery.MenuManager = this.ribbonControl;
            this.gridControlResultQuery.Name = "gridControlResultQuery";
            this.gridControlResultQuery.Size = new System.Drawing.Size(768, 193);
            this.gridControlResultQuery.TabIndex = 0;
            this.gridControlResultQuery.UseEmbeddedNavigator = true;
            this.gridControlResultQuery.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewResultQuery});
            // 
            // gridViewResultQuery
            // 
            this.gridViewResultQuery.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewResultQuery.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewResultQuery.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewResultQuery.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewResultQuery.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewResultQuery.Appearance.Row.Options.UseFont = true;
            this.gridViewResultQuery.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewResultQuery.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewResultQuery.GridControl = this.gridControlResultQuery;
            this.gridViewResultQuery.Name = "gridViewResultQuery";
            this.gridViewResultQuery.OptionsBehavior.Editable = false;
            this.gridViewResultQuery.OptionsBehavior.ReadOnly = true;
            this.gridViewResultQuery.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewResultQuery.OptionsView.ShowGroupPanel = false;
            this.gridViewResultQuery.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewResultQuery_RowCellClick);
            // 
            // xtraTabPageMessage
            // 
            this.xtraTabPageMessage.Appearance.PageClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPageMessage.Appearance.PageClient.Options.UseFont = true;
            this.xtraTabPageMessage.Controls.Add(this.txtMessage);
            this.xtraTabPageMessage.Name = "xtraTabPageMessage";
            this.xtraTabPageMessage.Size = new System.Drawing.Size(768, 193);
            this.xtraTabPageMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.Red;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(768, 193);
            this.txtMessage.TabIndex = 2;
            // 
            // FuzzysetXtraTabPage
            // 
            this.FuzzysetXtraTabPage.Appearance.PageClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuzzysetXtraTabPage.Appearance.PageClient.Options.UseFont = true;
            this.FuzzysetXtraTabPage.Name = "FuzzysetXtraTabPage";
            this.FuzzysetXtraTabPage.Size = new System.Drawing.Size(774, 358);
            this.FuzzysetXtraTabPage.Text = "Fuzzy Set";
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(90, 244);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.SelectedTab = null;
            this.backstageViewControl1.Size = new System.Drawing.Size(533, 150);
            this.backstageViewControl1.TabIndex = 6;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(132, 0);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(401, 150);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer2.Appearance.Options.UseBackColor = true;
            this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer2.Controls.Add(this.buttonEdit);
            this.popupControlContainer2.Location = new System.Drawing.Point(397, 421);
            this.popupControlContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Ribbon = this.ribbonControl;
            this.popupControlContainer2.Size = new System.Drawing.Size(197, 41);
            this.popupControlContainer2.TabIndex = 3;
            this.popupControlContainer2.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.EditValue = "Some Text";
            this.buttonEdit.Location = new System.Drawing.Point(4, 7);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEdit.MenuManager = this.ribbonControl;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(167, 20);
            this.buttonEdit.TabIndex = 0;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(184, 288);
            this.popupControlContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl;
            this.popupControlContainer1.Size = new System.Drawing.Size(127, 102);
            this.popupControlContainer1.TabIndex = 2;
            this.popupControlContainer1.Visible = false;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(4, 83);
            this.someLabelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "Some Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(4, 3);
            this.someLabelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(49, 13);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "Some Info";
            // 
            // ContextMenu_RelationNode
            // 
            this.ContextMenu_RelationNode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_RelationNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuRelNode_OpenRelation,
            this.CTMenuRelNode_DeleteRelation,
            this.CTMenuRelNode_RenameRelation});
            this.ContextMenu_RelationNode.Name = "ContextMenu_Table";
            this.ContextMenu_RelationNode.Size = new System.Drawing.Size(181, 70);
            // 
            // CTMenuRelNode_OpenRelation
            // 
            this.CTMenuRelNode_OpenRelation.Name = "CTMenuRelNode_OpenRelation";
            this.CTMenuRelNode_OpenRelation.Size = new System.Drawing.Size(180, 22);
            this.CTMenuRelNode_OpenRelation.Text = "&Open Relation";
            this.CTMenuRelNode_OpenRelation.ToolTipText = "Tạo quan hệ mới";
            this.CTMenuRelNode_OpenRelation.Click += new System.EventHandler(this.CTMenuRelNode_OpenRelation_Click);
            // 
            // CTMenuRelNode_DeleteRelation
            // 
            this.CTMenuRelNode_DeleteRelation.Name = "CTMenuRelNode_DeleteRelation";
            this.CTMenuRelNode_DeleteRelation.Size = new System.Drawing.Size(180, 22);
            this.CTMenuRelNode_DeleteRelation.Text = "&Delete Relation";
            this.CTMenuRelNode_DeleteRelation.Click += new System.EventHandler(this.CTMenuRelNode_DeleteRelation_Click);
            // 
            // CTMenuRelNode_RenameRelation
            // 
            this.CTMenuRelNode_RenameRelation.Name = "CTMenuRelNode_RenameRelation";
            this.CTMenuRelNode_RenameRelation.Size = new System.Drawing.Size(180, 22);
            this.CTMenuRelNode_RenameRelation.Text = "&Rename Relation";
            this.CTMenuRelNode_RenameRelation.Click += new System.EventHandler(this.CTMenuRelNode_RenameRelation_Click);
            // 
            // ContextMenu_Relation
            // 
            this.ContextMenu_Relation.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_Relation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuRelation_NewRelation,
            this.CTMenuRelation_DeleteRelations});
            this.ContextMenu_Relation.Name = "ContextMenu_Table";
            this.ContextMenu_Relation.Size = new System.Drawing.Size(200, 48);
            // 
            // CTMenuRelation_NewRelation
            // 
            this.CTMenuRelation_NewRelation.Name = "CTMenuRelation_NewRelation";
            this.CTMenuRelation_NewRelation.Size = new System.Drawing.Size(199, 22);
            this.CTMenuRelation_NewRelation.Text = "&New Relation";
            this.CTMenuRelation_NewRelation.ToolTipText = "Tạo quan hệ mới";
            this.CTMenuRelation_NewRelation.Click += new System.EventHandler(this.CTMenuRelation_NewRelation_Click);
            // 
            // CTMenuRelation_DeleteRelations
            // 
            this.CTMenuRelation_DeleteRelations.Name = "CTMenuRelation_DeleteRelations";
            this.CTMenuRelation_DeleteRelations.Size = new System.Drawing.Size(199, 22);
            this.CTMenuRelation_DeleteRelations.Text = "&Delete All Relations";
            this.CTMenuRelation_DeleteRelations.ToolTipText = "Xóa toàn bộ các quan hệ";
            this.CTMenuRelation_DeleteRelations.Click += new System.EventHandler(this.CTMenuRelation_DeleteRelations_Click);
            // 
            // contextMenu_QueryNode
            // 
            this.contextMenu_QueryNode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu_QueryNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuQueryNode_OpenQuery,
            this.CTMenuQuery_DeleteQuery,
            this.CTMenuQuery_RenameQuery});
            this.contextMenu_QueryNode.Name = "ContextMenu_Query";
            this.contextMenu_QueryNode.Size = new System.Drawing.Size(167, 70);
            // 
            // CTMenuQueryNode_OpenQuery
            // 
            this.CTMenuQueryNode_OpenQuery.Name = "CTMenuQueryNode_OpenQuery";
            this.CTMenuQueryNode_OpenQuery.Size = new System.Drawing.Size(166, 22);
            this.CTMenuQueryNode_OpenQuery.Text = "&Open Query";
            this.CTMenuQueryNode_OpenQuery.Click += new System.EventHandler(this.CTMenuQueryNode_OpenQuery_Click);
            // 
            // CTMenuQuery_DeleteQuery
            // 
            this.CTMenuQuery_DeleteQuery.Name = "CTMenuQuery_DeleteQuery";
            this.CTMenuQuery_DeleteQuery.Size = new System.Drawing.Size(166, 22);
            this.CTMenuQuery_DeleteQuery.Text = "&Delete Query";
            this.CTMenuQuery_DeleteQuery.Click += new System.EventHandler(this.CTMenuQuery_DeleteQuery_Click);
            // 
            // CTMenuQuery_RenameQuery
            // 
            this.CTMenuQuery_RenameQuery.Name = "CTMenuQuery_RenameQuery";
            this.CTMenuQuery_RenameQuery.Size = new System.Drawing.Size(166, 22);
            this.CTMenuQuery_RenameQuery.Text = "&Rename Query";
            this.CTMenuQuery_RenameQuery.Click += new System.EventHandler(this.CTMenuQuery_RenameQuery_Click);
            // 
            // ContextMenu_Database
            // 
            this.ContextMenu_Database.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuDB_Rename,
            this.CTMenuDB_CloseDB});
            this.ContextMenu_Database.Name = "contextMenuStrip";
            this.ContextMenu_Database.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ContextMenu_Database.Size = new System.Drawing.Size(169, 48);
            this.ContextMenu_Database.Text = "Database Properties";
            // 
            // CTMenuDB_Rename
            // 
            this.CTMenuDB_Rename.Name = "CTMenuDB_Rename";
            this.CTMenuDB_Rename.Size = new System.Drawing.Size(168, 22);
            this.CTMenuDB_Rename.Text = "Re&name Database";
            this.CTMenuDB_Rename.Click += new System.EventHandler(this.CTMenuDB_Rename_Click);
            // 
            // CTMenuDB_CloseDB
            // 
            this.CTMenuDB_CloseDB.Name = "CTMenuDB_CloseDB";
            this.CTMenuDB_CloseDB.Size = new System.Drawing.Size(168, 22);
            this.CTMenuDB_CloseDB.Text = "&Close Database";
            this.CTMenuDB_CloseDB.Click += new System.EventHandler(this.CTMenuDB_CloseDB_Click);
            // 
            // ContextMenu_Schema
            // 
            this.ContextMenu_Schema.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_Schema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuSchema_NewSchema,
            this.CTMenuSchema_EditSchemas,
            this.openSchemeToolStripMenuItem,
            this.deleteSchemeToolStripMenuItem,
            this.closeCurrentSchemeToolStripMenuItem});
            this.ContextMenu_Schema.Name = "ContextMenu_Schema";
            this.ContextMenu_Schema.Size = new System.Drawing.Size(215, 114);
            // 
            // CTMenuSchema_NewSchema
            // 
            this.CTMenuSchema_NewSchema.Name = "CTMenuSchema_NewSchema";
            this.CTMenuSchema_NewSchema.Size = new System.Drawing.Size(214, 22);
            this.CTMenuSchema_NewSchema.Text = "&New Scheme";
            this.CTMenuSchema_NewSchema.Click += new System.EventHandler(this.CTMenuSchema_NewSchema_Click);
            // 
            // CTMenuSchema_EditSchemas
            // 
            this.CTMenuSchema_EditSchemas.Name = "CTMenuSchema_EditSchemas";
            this.CTMenuSchema_EditSchemas.Size = new System.Drawing.Size(214, 22);
            this.CTMenuSchema_EditSchemas.Text = "&Edit Scheme";
            this.CTMenuSchema_EditSchemas.Click += new System.EventHandler(this.CTMenuSchema_EditSchemas_Click);
            // 
            // openSchemeToolStripMenuItem
            // 
            this.openSchemeToolStripMenuItem.Name = "openSchemeToolStripMenuItem";
            this.openSchemeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.openSchemeToolStripMenuItem.Text = "&Open Scheme";
            this.openSchemeToolStripMenuItem.Click += new System.EventHandler(this.openSchemeToolStripMenuItem_Click);
            // 
            // deleteSchemeToolStripMenuItem
            // 
            this.deleteSchemeToolStripMenuItem.Name = "deleteSchemeToolStripMenuItem";
            this.deleteSchemeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteSchemeToolStripMenuItem.Text = "&Delete Scheme";
            this.deleteSchemeToolStripMenuItem.Click += new System.EventHandler(this.deleteSchemeToolStripMenuItem_Click);
            // 
            // closeCurrentSchemeToolStripMenuItem
            // 
            this.closeCurrentSchemeToolStripMenuItem.Name = "closeCurrentSchemeToolStripMenuItem";
            this.closeCurrentSchemeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.closeCurrentSchemeToolStripMenuItem.Text = "&Close Current Scheme";
            this.closeCurrentSchemeToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentSchemeToolStripMenuItem_Click);
            // 
            // ContextMenu_Query
            // 
            this.ContextMenu_Query.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_Query.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuQuery_NewQuery,
            this.CTMenuQuery_DeleteQueries});
            this.ContextMenu_Query.Name = "ContextMenu_Query";
            this.ContextMenu_Query.Size = new System.Drawing.Size(190, 48);
            // 
            // CTMenuQuery_NewQuery
            // 
            this.CTMenuQuery_NewQuery.Name = "CTMenuQuery_NewQuery";
            this.CTMenuQuery_NewQuery.Size = new System.Drawing.Size(189, 22);
            this.CTMenuQuery_NewQuery.Text = "&New Query";
            this.CTMenuQuery_NewQuery.Click += new System.EventHandler(this.CTMenuQuery_NewQuery_Click);
            // 
            // CTMenuQuery_DeleteQueries
            // 
            this.CTMenuQuery_DeleteQueries.Name = "CTMenuQuery_DeleteQueries";
            this.CTMenuQuery_DeleteQueries.Size = new System.Drawing.Size(189, 22);
            this.CTMenuQuery_DeleteQueries.Text = "&Delete All Queries";
            this.CTMenuQuery_DeleteQueries.Click += new System.EventHandler(this.CTMenuQuery_DeleteQueries_Click);
            // 
            // ImageList_TreeView
            // 
            this.ImageList_TreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_TreeView.ImageStream")));
            this.ImageList_TreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList_TreeView.Images.SetKeyName(0, "DB.png");
            this.ImageList_TreeView.Images.SetKeyName(1, "Folder.png");
            this.ImageList_TreeView.Images.SetKeyName(2, "OpenFolder.png");
            this.ImageList_TreeView.Images.SetKeyName(3, "Relation.png");
            this.ImageList_TreeView.Images.SetKeyName(4, "QueryIcon.png");
            this.ImageList_TreeView.Images.SetKeyName(5, "key.png");
            this.ImageList_TreeView.Images.SetKeyName(6, "attribute.png");
            // 
            // ContextMenu_SchemaNode
            // 
            this.ContextMenu_SchemaNode.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenu_SchemaNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CTMenuSchNode_EditSchema,
            this.CTMenuSchNode_OpenSchema,
            this.CTMenuSchNode_DeleteSchema});
            this.ContextMenu_SchemaNode.Name = "ContextMenu_Table";
            this.ContextMenu_SchemaNode.Size = new System.Drawing.Size(169, 70);
            // 
            // CTMenuSchNode_EditSchema
            // 
            this.CTMenuSchNode_EditSchema.Name = "CTMenuSchNode_EditSchema";
            this.CTMenuSchNode_EditSchema.Size = new System.Drawing.Size(168, 22);
            this.CTMenuSchNode_EditSchema.Text = "&Edit Scheme";
            this.CTMenuSchNode_EditSchema.Click += new System.EventHandler(this.CTMenuSchNode_EditSchema_Click);
            // 
            // CTMenuSchNode_OpenSchema
            // 
            this.CTMenuSchNode_OpenSchema.Name = "CTMenuSchNode_OpenSchema";
            this.CTMenuSchNode_OpenSchema.Size = new System.Drawing.Size(168, 22);
            this.CTMenuSchNode_OpenSchema.Text = "&Open Scheme";
            this.CTMenuSchNode_OpenSchema.ToolTipText = "Tạo quan hệ mới";
            this.CTMenuSchNode_OpenSchema.Click += new System.EventHandler(this.CTMenuSchNode_OpenSchema_Click);
            // 
            // CTMenuSchNode_DeleteSchema
            // 
            this.CTMenuSchNode_DeleteSchema.Name = "CTMenuSchNode_DeleteSchema";
            this.CTMenuSchNode_DeleteSchema.Size = new System.Drawing.Size(168, 22);
            this.CTMenuSchNode_DeleteSchema.Text = "&Delete Scheme";
            this.CTMenuSchNode_DeleteSchema.Click += new System.EventHandler(this.CTMenuSchNode_DeleteSchema_Click);
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 599);
            this.Controls.Add(this.RelationsplitContainerControl);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.popupControlContainer2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbonControl);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FPRDB Visual Management System";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelationsplitContainerControl)).EndInit();
            this.RelationsplitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlDatabase)).EndInit();
            this.xtraTabControlDatabase.ResumeLayout(false);
            this.SchemaXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            this.RelationXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RelationPanelControl)).EndInit();
            this.RelationPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValueRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewValueRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoEditTxtValueRelation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRelation)).EndInit();
            this.panelControlRelation.ResumeLayout(false);
            this.panelControlRelation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Checkbox_UD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkbox_UUD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxProb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinProb.Properties)).EndInit();
            this.QueryXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlResultQuery)).EndInit();
            this.xtraTabControlResultQuery.ResumeLayout(false);
            this.xtraTabPageQueryResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResultQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResultQuery)).EndInit();
            this.xtraTabPageMessage.ResumeLayout(false);
            this.xtraTabPageMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            this.ContextMenu_RelationNode.ResumeLayout(false);
            this.ContextMenu_Relation.ResumeLayout(false);
            this.contextMenu_QueryNode.ResumeLayout(false);
            this.ContextMenu_Database.ResumeLayout(false);
            this.ContextMenu_Schema.ResumeLayout(false);
            this.ContextMenu_Query.ResumeLayout(false);
            this.ContextMenu_SchemaNode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl RelationsplitContainerControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem iNewDatabase;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iClose;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iSaveAs;
        private DevExpress.XtraBars.BarButtonItem iCloseCurrentSchema;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarButtonItem iBoldFontStyle;
        private DevExpress.XtraBars.BarButtonItem iItalicFontStyle;
        private DevExpress.XtraBars.BarButtonItem iUnderlinedFontStyle;
        private DevExpress.XtraBars.BarButtonItem iLeftTextAlign;
        private DevExpress.XtraBars.BarButtonItem iCenterTextAlign;
        private DevExpress.XtraBars.BarButtonItem iRightTextAlign;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage DatabaseRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraBars.Ribbon.RibbonPage SchemaRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage RelationRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage QueryRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage FuzzySetRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileSchemaRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup closeSchemaribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iNewSchema;
        private DevExpress.XtraBars.BarButtonItem iEditSchema;
        private DevExpress.XtraBars.BarButtonItem iOpenSchema;
        private DevExpress.XtraBars.BarButtonItem iDeleteSchema;
        private DevExpress.XtraBars.BarButtonItem iNewRelation;
        private DevExpress.XtraBars.BarButtonItem iOpenRelation;
        private DevExpress.XtraBars.BarButtonItem iDeleteRelation;
        private DevExpress.XtraBars.BarButtonItem iCloseRelation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRelationRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup closeRelationRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem iNewQuery;
        private DevExpress.XtraBars.BarButtonItem iSaveQuery;
        private DevExpress.XtraBars.BarButtonItem iOpenQuery;
        private DevExpress.XtraBars.BarButtonItem iDeleteQuery;
        private DevExpress.XtraBars.BarButtonItem iCloseQuery;
        private DevExpress.XtraBars.BarButtonItem iExcuteQuery;
        private DevExpress.XtraBars.BarButtonItem iAddDiscrete;
        private DevExpress.XtraBars.BarButtonItem iLibraryDiscrete;
        private DevExpress.XtraBars.BarButtonItem iAddContinuous;
        private DevExpress.XtraBars.BarButtonItem iLibraryContinuous;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileQueryRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup conjunctionRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup disjunctionRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup differenceRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup equalityRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup operatorRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup excuteQueryribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup closeQueryribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup discreteFuzzySetribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup continuousFuzzySetRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem iConjunctionIgnorance;
        private DevExpress.XtraBars.BarButtonItem iConjunctionIndependence;
        private DevExpress.XtraBars.BarButtonItem iConjunctionMutual;
        private DevExpress.XtraBars.BarButtonItem iDisjunctionIgnorance;
        private DevExpress.XtraBars.BarButtonItem iDisjunctionIndependence;
        private DevExpress.XtraBars.BarButtonItem iDisjunctionMutual;
        private DevExpress.XtraBars.BarButtonItem iDifferenceIgnorance;
        private DevExpress.XtraBars.BarButtonItem iDifferenceIndependence;
        private DevExpress.XtraBars.BarButtonItem iDiferenceMutual;
        private DevExpress.XtraBars.BarButtonItem iEqualityIg;
        private DevExpress.XtraBars.BarButtonItem iEqualityIn;
        private DevExpress.XtraBars.BarButtonItem iEqualityMe;
        private DevExpress.XtraBars.BarButtonItem iOperator;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlDatabase;
        private DevExpress.XtraTab.XtraTabPage SchemaXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage RelationXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage QueryXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage FuzzysetXtraTabPage;
        private DevExpress.XtraGrid.GridControl gridControlScheme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrimary;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAttribute;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDataType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDomain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.PanelControl RelationPanelControl;
        private DevExpress.XtraEditors.PanelControl panelControlRelation;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl gridControlRelation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRelation;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_RelationNode;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelNode_OpenRelation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelNode_DeleteRelation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelNode_RenameRelation;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Relation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelation_NewRelation;
        private System.Windows.Forms.ToolStripMenuItem CTMenuRelation_DeleteRelations;
        private System.Windows.Forms.ContextMenuStrip contextMenu_QueryNode;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQueryNode_OpenQuery;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_DeleteQuery;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_RenameQuery;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Database;
        private System.Windows.Forms.ToolStripMenuItem CTMenuDB_Rename;
        private System.Windows.Forms.ToolStripMenuItem CTMenuDB_CloseDB;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Schema;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchema_NewSchema;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchema_EditSchemas;
        private System.Windows.Forms.ToolStripMenuItem openSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentSchemeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Query;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_NewQuery;
        private System.Windows.Forms.ToolStripMenuItem CTMenuQuery_DeleteQueries;
        private System.Windows.Forms.ImageList ImageList_TreeView;
        private DevExpress.XtraGrid.GridControl gridControlValueRelation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewValueRelation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMinProb;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaxProb;
        private DevExpress.XtraEditors.MemoEdit MemoEditTxtValueRelation;
        private DevExpress.XtraEditors.CheckEdit Checkbox_UD;
        private DevExpress.XtraEditors.CheckEdit Checkbox_UUD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaxProb;
        private DevExpress.XtraEditors.TextEdit txtMinProb;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlResultQuery;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageQueryResult;
        private DevExpress.XtraGrid.GridControl gridControlResultQuery;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewResultQuery;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMessage;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_SchemaNode;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchNode_EditSchema;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchNode_OpenSchema;
        private System.Windows.Forms.ToolStripMenuItem CTMenuSchNode_DeleteSchema;
        private DevExpress.XtraBars.BarButtonItem iSaveRelation;
        private System.Windows.Forms.RichTextBox memoEditTxtQuery;
        private System.Windows.Forms.TextBox txtMessage;

    }
}
