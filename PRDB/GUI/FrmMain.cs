using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using FPRDB.BLL;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraCharts;

namespace FPRDB.GUI
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        #region *FProbDatabase
        DataTable dtschema = new DataTable();
        DataTable dtrelation = new DataTable();
        DataTable dtvalrelation = new DataTable();
        FProbDatabaseBLL probDatabase;
        FProbRelationBLL currentRelationOpen = new FProbRelationBLL();
        FProbSchemaBLL currentSchema;
        FProbQueryBLL currentQuery;
        QueryExecutionBLL query;
        #endregion

        #region * TreeView
        TreeNode NodeDB, NodeSchema, NodeRelation, NodeQuery, NewNode, NodeAttribute;
        #endregion

        #region * Images
        public struct ImageIndex
        {
            public int UnselectedState;
            public int SelectedState;
        }
        #endregion

        #region * Variables
        ImageIndex DB_ImgIndex, Folder_ImgIndex, Schema_ImgIndex, Relation_ImgIndex, Query_ImgIndex, Attribute_ImgIndex;
        static public string[] Operator = new string[21] {"and","or", "→", "<", ">", "<=", ">=", "=", "!=", "⊗_in", "⊗_ig", "⊗_me", "⊕_in", "⊕_ig", "⊕_me", "⊖_in", "⊖_ig", "⊖_me", "equal_in", "equal_ig", "equal_me" };
        public FProbTripleBLL row { get; set; }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFPRDB();
        }

        #region Active DB
        private void LoadFPRDB()
        {
            SwitchValueState(true);
            ActivateDatabase(false);
        }
        private void SwitchValueState(bool state)
        {
            gridControlValueRelation.Visible = state;

            Checkbox_UUD.Checked = state;
            Checkbox_UD.Checked = !state;
            labelControl1.Enabled = !state;
            labelControl2.Enabled = !state;
            txtMaxProb.Text = "";
            txtMinProb.Text = "";
            txtMinProb.Enabled = !state;
            txtMaxProb.Enabled = !state;

            MemoEditTxtValueRelation.Visible = !state;
        }
        private void ActivateDatabase(bool state)
        {
            ResetSchemaPage(state);
            ResetRelationPage(state);
            ResetQueryPage(state);
            ResetInputValue(state);
            ResetMenuBar(state);
            ResetFuzzyPage(state);
        }
        private void ResetMenuBar(bool state)
        {
            iSave.Enabled = state;
            iSaveAs.Enabled = state;
            iClose.Enabled = state;
            SchemaRibbonPage.Visible = state;
            RelationRibbonPage.Visible = state;
            QueryRibbonPage.Visible = state;
        }
        private void ResetInputValue(bool state)
        {
            txtMinProb.Text = "";
            txtMaxProb.Text = "";
            MemoEditTxtValueRelation.ResetText();
            gridControlValueRelation.DataSource = null;
            gridViewValueRelation.Columns.Clear();

            Checkbox_UUD.Enabled = state;
            Checkbox_UD.Enabled = state;

            txtMinProb.Enabled = state;
            txtMaxProb.Enabled = state;
        }
        private void ResetQueryPage(bool state)
        {
            currentQuery = null;
            xtraTabControlDatabase.TabPages[2].Text = "Query";
            memoEditTxtQuery.Text = "";
            iExcuteQuery.Enabled = false;
            iSaveQuery.Enabled = false;
            iCloseQuery.Enabled = false;

            conjunctionRibbonPageGroup.Visible = false;
            differenceRibbonPageGroup.Visible = false;
            disjunctionRibbonPageGroup.Visible = false;
            equalityRibbonPageGroup.Visible = false;
            operatorRibbonPageGroup.Visible = false;
            QueryXtraTabPage.PageEnabled = false;
        }
        private void ResetRelationPage(bool state)
        {
            xtraTabControlDatabase.TabPages[1].Text = "Relation";
            gridControlRelation.DataSource = null;
            gridViewRelation.Columns.Clear();
            gridControlValueRelation.DataSource = null;
            gridViewValueRelation.Columns.Clear();
            RelationXtraTabPage.PageEnabled = state;
        }
        private void ResetSchemaPage(bool state)
        {
            xtraTabControlDatabase.TabPages[0].Text = "Schema";

            gridControlScheme.DataSource = null;
            gridControlScheme.Enabled = state;
            SchemaXtraTabPage.PageEnabled = state;
        }
        private void ResetFuzzyPage(bool state)
        {
            xtraTabControlDatabase.TabPages[3].Text = "FuzzySet";
            xtraTabControlDatabase.SelectedTabPage = FuzzysetXtraTabPage;
            FuzzysetXtraTabPage.PageEnabled = state;
        }
        #endregion
        #region TreeView
        private void LoadImageCollection()
        {
            try
            {
                TreeView.ImageList = ImageList_TreeView;
                DB_ImgIndex.SelectedState = DB_ImgIndex.UnselectedState = 0;
                Folder_ImgIndex.UnselectedState = 1;
                Folder_ImgIndex.SelectedState = 2;
                Schema_ImgIndex.SelectedState = Schema_ImgIndex.UnselectedState = 3;
                Relation_ImgIndex.SelectedState = Relation_ImgIndex.UnselectedState = 3;
                Query_ImgIndex.SelectedState = Query_ImgIndex.UnselectedState = 4;
                Attribute_ImgIndex.SelectedState = 5;
                Attribute_ImgIndex.UnselectedState = 6;
            }
            catch (Exception)
            {    }     
        }
        private void Load_TreeView()
        {
            try
            {
                TreeView.Nodes.Clear();
                TreeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(TreeView_NodeMouseClick);
                LoadImageCollection();

                NodeDB = new TreeNode();
                NodeDB.Text = probDatabase.DbName.ToUpper();
                NodeDB.ToolTipText = "Database " + probDatabase.DbName.ToUpper() ;
                NodeDB.ContextMenuStrip = ContextMenu_Database;
                NodeDB.ImageIndex = DB_ImgIndex.UnselectedState;
                NodeDB.SelectedImageIndex = DB_ImgIndex.SelectedState;
                TreeView.Nodes.Add(NodeDB);

                NodeSchema = new TreeNode();
                NodeSchema.Text = "Schemas";
                NodeSchema.ToolTipText = "Schemas";
                NodeSchema.ContextMenuStrip = ContextMenu_Schema;
                NodeSchema.ImageIndex = Folder_ImgIndex.UnselectedState;
                NodeSchema.SelectedImageIndex = Folder_ImgIndex.UnselectedState;
                NodeDB.Nodes.Add(NodeSchema);

                NodeRelation = new TreeNode();
                NodeRelation.Text = "Relations";
                NodeRelation.ToolTipText = "Relations";
                NodeRelation.ContextMenuStrip = ContextMenu_Relation;
                NodeRelation.ImageIndex = Folder_ImgIndex.UnselectedState;
                NodeRelation.SelectedImageIndex = Folder_ImgIndex.UnselectedState;               
                NodeDB.Nodes.Add(NodeRelation);

                NodeQuery = new TreeNode();
                NodeQuery.Text = "Queries";
                NodeQuery.ToolTipText = "Queries";
                NodeQuery.ContextMenuStrip = ContextMenu_Query;
                NodeQuery.ImageIndex = Folder_ImgIndex.UnselectedState;
                NodeQuery.SelectedImageIndex = Folder_ImgIndex.UnselectedState;
                NodeDB.Nodes.Add(NodeQuery);

                LoadTreeViewNode();
            }
            catch 
            {
                
               
            }
        
        }
        private void OpenNodeRelation(string nodeName)
        {
            gridControlValueRelation.DataSource = null;
            gridViewValueRelation.Columns.Clear();
            GridColumn col = new GridColumn();
            col.Caption = "Value";
            col.Name = "gridColumnValue";
            col.FieldName = "gridColumnValue";
            col.OptionsColumn.ReadOnly = true;
            col.OptionsColumn.AllowEdit = false;
            col.Visible = true;
            col.VisibleIndex = 0;
            gridViewValueRelation.Columns.Add(col);
            GridColumn col1 = new GridColumn();
            col1.Caption = "MinProb";
            col1.Name = "gridColumnMinProb";
            col1.FieldName = "gridColumnMinProb";
            col1.OptionsColumn.ReadOnly = true;
            col1.OptionsColumn.AllowEdit = false;
            col1.Visible = true;
            col1.VisibleIndex = 1;
            gridViewValueRelation.Columns.Add(col1);
            GridColumn col2 = new GridColumn();
            col2.Caption = "MaxProb";
            col2.Name = "gridColumnMaxProb";
            col2.FieldName = "gridColumnMaxProb";
            col2.OptionsColumn.ReadOnly = true;
            col2.OptionsColumn.AllowEdit = false;
            col2.Visible = true;
            col2.VisibleIndex = 2;
            gridViewValueRelation.Columns.Add(col2);
            MemoEditTxtValueRelation.Text = "";
            txtMaxProb.Text = "";
            txtMinProb.Text = "";
            OpenRelationByName(nodeName);    
        }
        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeView.SelectedNode = e.Node;       
            }

            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    string nodeName = e.Node.Name;
                    if (e.Node.Parent.Text == "Schemas" )
                    {
                        OpenSchemeByNameScheme(nodeName);
                    }
                    else
                        if (e.Node.Parent.Text == "Relations" )
                        {
                            OpenNodeRelation(nodeName);
                        }
                        else
                            if (e.Node.Parent.Text == "Queries" )
                            {
                               OpenQueryByName(nodeName);
                            }  
                }
                catch {}
            }
        }
        public void LoadAttributeScheme()
        {
            try
            {
                if( NodeAttribute != null)
                    NodeAttribute.Nodes.Clear();

                for (int i = 0; i < NodeSchema.GetNodeCount(true); i++)
                {
                    NodeSchema.Nodes[i].Nodes.Clear();
                    string schemaName = NodeSchema.Nodes[i].Name;
                    FProbSchemaBLL schme = this.probDatabase.FproSchemas.SingleOrDefault(c => c.SchemaName == schemaName);
                    foreach (FProbAttributeBLL attr in schme.FproAttributes)
                    {
                          NodeAttribute = new TreeNode();
                          NodeAttribute.Text = attr.AttributeName;
                          NodeAttribute.Name = attr.AttributeName;
                          NodeAttribute.ToolTipText = "Attribute " + attr.AttributeName;

                          if (attr.PrimaryKey == true)
                          {
                              NodeAttribute.ImageIndex = 5;
                              NodeAttribute.SelectedImageIndex = 5;
                          }
                          else
                          {
                              NodeAttribute.ImageIndex = 6;
                              NodeAttribute.SelectedImageIndex = 6;
                          }
                          NodeSchema.Nodes[i].Nodes.Add(NodeAttribute);
                    }
                }
            }
            catch (Exception)
            {}     
        }
        public void LoadAttributeRelation()
        {
            try
            {
                if (NodeAttribute != null)
                    NodeAttribute.Nodes.Clear();

                for (int i = 0; i < NodeRelation.GetNodeCount(true); i++)
                {
                    NodeRelation.Nodes[i].Nodes.Clear();
                    string relationName = NodeRelation.Nodes[i].Name;
                    FProbRelationBLL relation = this.probDatabase.FproRelations.SingleOrDefault(c => c.RelationName == relationName);

                    foreach (FProbAttributeBLL attr in relation.FproSchema.FproAttributes)
                    {
                        NodeAttribute = new TreeNode();
                        NodeAttribute.Text = attr.AttributeName;
                        NodeAttribute.Name = attr.AttributeName + "relation";
                        NodeAttribute.ToolTipText = "Attribute " + attr.AttributeName;

                        if (attr.PrimaryKey == true)
                        {
                            NodeAttribute.ImageIndex = 5;
                            NodeAttribute.SelectedImageIndex = 5;
                        }
                        else
                        {
                            NodeAttribute.ImageIndex = 6;
                            NodeAttribute.SelectedImageIndex = 6;
                        }
                        NodeRelation.Nodes[i].Nodes.Add(NodeAttribute);
                    }
                }
            }
            catch
            {}
        }
        public void LoadSchemaNode()
        {
            try
            {

                NodeSchema.Nodes.Clear();
                foreach (FProbSchemaBLL scheme in probDatabase.FproSchemas)
                {
                    NewNode = new TreeNode();
                    NewNode.Text = scheme.SchemaName.ToLower();
                    NewNode.Name = scheme.SchemaName;
                    NewNode.ToolTipText = "Schema " + scheme.SchemaName;
                    NewNode.ContextMenuStrip = ContextMenu_SchemaNode;
                    NewNode.ImageIndex = Schema_ImgIndex.UnselectedState;
                    NewNode.SelectedImageIndex = Schema_ImgIndex.UnselectedState;
                    NodeSchema.Nodes.Add(NewNode);
                }
                LoadAttributeScheme();
            }
            catch 
            {}     
        }
        public void LoadRelationNode()
        {
            try
            {
                NodeRelation.Nodes.Clear();
                foreach (FProbRelationBLL relation in probDatabase.FproRelations)
                {
                    NewNode = new TreeNode();
                    NewNode.Text = relation.RelationName.ToLower();
                    NewNode.Name = relation.RelationName;
                    NewNode.ToolTipText = "Relation " + relation.RelationName.ToLower();
                    NewNode.ContextMenuStrip = ContextMenu_RelationNode;
                    NewNode.ImageIndex = Relation_ImgIndex.UnselectedState;
                    NewNode.SelectedImageIndex = Relation_ImgIndex.UnselectedState;
                    NodeRelation.Nodes.Add(NewNode);
                }
                LoadAttributeRelation();
            }
            catch 
            {}        
        }
        public void LoadQueryNode()
        {
            try
            {
                NodeQuery.Nodes.Clear();
                foreach (FProbQueryBLL query in probDatabase.FproQueries)
                {
                    NewNode = new TreeNode();
                    NewNode.Text = query.QueryName.ToLower();
                    NewNode.Name = query.QueryName;
                    NewNode.ToolTipText = "Query " + query.QueryName;
                    NewNode.ContextMenuStrip = contextMenu_QueryNode;
                    NewNode.ImageIndex = Query_ImgIndex.UnselectedState;
                    NewNode.SelectedImageIndex = Query_ImgIndex.SelectedState;
                    NodeQuery.Nodes.Add(NewNode);
                }
            }
            catch 
            {}    
        }
        private void LoadTreeViewNode()
        {
            try
            {
                LoadSchemaNode();
                LoadRelationNode();
                LoadQueryNode();
            }
            catch 
            {}          
        }   
        #endregion
        #region *Database
        private string GetRootPath(string path)
        {
            string root = "";
            try
            {
                for (int i = 0; i < path.Length; i++)
                    if (path[i] == '\\')
                    {
                        root = path.Substring(0, i + 1);
                        break;
                    }
                return root;
            }
            catch (Exception)
            { }
            return root;
        }
        #region *New Database
        private void iNewDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog DialogSave = new SaveFileDialog();
                DialogSave.Title = "Create New Fuzzy Probabilistic Relational Database (FPRDB)";

                //DialogSave.Filter = "Database file (*.pdb)|*.pdb";
                //DialogSave.DefaultExt = "pdb";

                DialogSave.Filter = "Database file (*.pdb)|*.pdb";
                DialogSave.DefaultExt = "sql";

                DialogSave.AddExtension = true;
                DialogSave.RestoreDirectory = true;                                
                //DialogSave.Filter = "Database file (*.pdb)|*.pdb|All files (*.*)|*.*";               
                DialogSave.InitialDirectory = GetRootPath(AppDomain.CurrentDomain.BaseDirectory.ToString());
                DialogSave.SupportMultiDottedExtensions = true;

                if (DialogSave.ShowDialog() == DialogResult.OK)
                {
                    this.probDatabase = new FProbDatabaseBLL(DialogSave.FileName);
                    Resource.ConnectionString = probDatabase.ConnectString;

                    if (!probDatabase.CreateNewDatabase())
                    {
                        XtraMessageBox.Show("Error : Cannot create new database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Load_TreeView();
                        this.ActivateDatabase(true);
                    }
                }
                DialogSave.Dispose();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
                return;
            }
        }
        #endregion
        #region *Open Database
        private void iOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                OpenFileDialog DialogOpen = new OpenFileDialog();
                DialogOpen.DefaultExt = "pdb";
                DialogOpen.Filter = "Database file (*.pdb)|*.pdb";
                DialogOpen.AddExtension = true;
                DialogOpen.RestoreDirectory = true;
                DialogOpen.Title = "Open Fuzzy Probabilistic Relational Database (FPRDB)...";
                DialogOpen.InitialDirectory = GetRootPath(AppDomain.CurrentDomain.BaseDirectory.ToString());
                DialogOpen.SupportMultiDottedExtensions = true;

                if (DialogOpen.ShowDialog() == DialogResult.OK)
                {
                    this.probDatabase = new FProbDatabaseBLL(DialogOpen.FileName);
                    Resource.ConnectionString = this.probDatabase.ConnectString;
                    this.probDatabase = probDatabase.OpenExistingDatabase();
                    if (probDatabase == null)
                    {
                        XtraMessageBox.Show("Error : Cannot connect to the database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Load_TreeView();
                        this.ActivateDatabase(true);
                    }
                }
                DialogOpen.Dispose();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
                return;
            }
        }
        #endregion
        #region *Save Database
        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!probDatabase.SaveDatabase())
                {
                    XtraMessageBox.Show("Error : Cannot save the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show("Save successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Save As Database
        private void iSaveAs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog DialogSave = new SaveFileDialog();
                DialogSave.Title = "Save As Fuzzy Probabilistic Relational Database (FPRDB)";
                DialogSave.Filter = "Database file (*.pdb)|*.pdb";
                DialogSave.DefaultExt = "pdb";
                DialogSave.AddExtension = true;
                DialogSave.RestoreDirectory = true;
                //DialogSave.Filter = "Database file (*.pdb)|*.pdb|All files (*.*)|*.*";               
                DialogSave.InitialDirectory = GetRootPath(AppDomain.CurrentDomain.BaseDirectory.ToString());
                DialogSave.SupportMultiDottedExtensions = true;

                if (DialogSave.ShowDialog() == DialogResult.OK)
                {
                    this.probDatabase = new FProbDatabaseBLL(DialogSave.FileName, probDatabase);
                    Resource.ConnectionString = probDatabase.ConnectString;

                    if (!probDatabase.CreateNewDatabase())
                    {
                        XtraMessageBox.Show("Error : Cannot save as database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!probDatabase.SaveDatabase())
                        {
                            XtraMessageBox.Show("Error : Cannot save the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Load_TreeView();
                            this.ActivateDatabase(true);
                            XtraMessageBox.Show("Save successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                DialogSave.Dispose();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
                return;
            }
        }
        #endregion
        #region *Close Database
        private void CloseDatabase()
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = XtraMessageBox.Show("Are you sure want to close this Database ?", "Close database " + probDatabase.DbName + "...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.TreeView.Nodes.Clear();
                    this.probDatabase = null;
                    ActivateDatabase(false);
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseDatabase();
        }
        private void CTMenuDB_CloseDB_Click(object sender, EventArgs e)
        {
            CloseDatabase();
        }
        #endregion
        #region *Exit Database
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DialogResult result = XtraMessageBox.Show("Are you sure want to exit?", "Exit FPRDB Visual Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Rename Database
        private void CTMenuDB_Rename_Click(object sender, EventArgs e)
        {
            FrmRenameDB frm = new FrmRenameDB(this.probDatabase);
            frm.ShowDialog();
            this.probDatabase = frm.probDatabase;
            NodeDB.Text = this.probDatabase.DbName.ToUpper();
            NodeDB.ToolTipText = "Database " + this.probDatabase.DbName.ToUpper();
        }
        #endregion
        #endregion
        #region *Schema
        private void ResetGridViewSchema(List<FProbAttributeBLL>list)
        {
            gridControlScheme.DataSource = null;
            dtschema = new DataTable();
            dtschema.Columns.Add("gridColumnPrimary", typeof(Boolean));
            dtschema.Columns.Add("gridColumnAttribute", typeof(String));
            dtschema.Columns.Add("gridColumnDataType", typeof(String));
            dtschema.Columns.Add("gridColumnDomain", typeof(String));
            dtschema.Columns.Add("gridColumnDescription", typeof(String));
            foreach (FProbAttributeBLL att in list)
            {
                DataRow row = dtschema.NewRow();
                row[0] = att.PrimaryKey;
                row[1] = att.AttributeName;
                row[2] = att.FproDataType.TypeName;
                row[3] = att.FproDataType.DomainString;
                row[4] = att.Description;
                dtschema.Rows.Add(row);
            }
            gridControlScheme.DataSource = dtschema;
        }
        #region *New Schema
        private void CreateNewScheme()
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmNewSchema frm = new FrmNewSchema(probDatabase);
                frm.ShowDialog();

                foreach (FProbSchemaBLL scheme in frm.listProbScheme)
                {
                    this.probDatabase.FproSchemas.Add(scheme);
                    TreeNode NewNode = new TreeNode();
                    NewNode.Name = scheme.SchemaName;
                    NewNode.Text = scheme.SchemaName.ToLower();
                    NewNode.ToolTipText = "Schema " + scheme.SchemaName;
                    NewNode.ContextMenuStrip = ContextMenu_SchemaNode;
                    NewNode.ImageIndex = Schema_ImgIndex.UnselectedState;
                    NewNode.SelectedImageIndex = Schema_ImgIndex.UnselectedState;
                    NodeSchema.Nodes.Add(NewNode);
                }
                LoadAttributeScheme();
                LoadRelationNode();
                OpenNodeRelation(probDatabase.FproRelations[probDatabase.FproRelations.Count - 1].RelationName);
            }
            catch(Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iNewSchema_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                CreateNewScheme();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuSchema_NewSchema_Click(object sender, EventArgs e)
        {
            try
            {
                CreateNewScheme();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Open Schema
        private void OpenSchemeByNameScheme(string schemeName)
        {
            try
            {
                xtraTabControlDatabase.SelectedTabPage = xtraTabControlDatabase.TabPages[0];
                schemeName = schemeName.ToLower();
                SchemaXtraTabPage.Text = "Schema " + schemeName;

                currentSchema = this.probDatabase.FproSchemas.SingleOrDefault(c => c.SchemaName.ToLower() == schemeName);
                //add attribute into GridViewDesign
                ResetGridViewSchema(currentSchema.FproAttributes);
                ribbonControl.SelectedPage = SchemaRibbonPage;
            }
            catch(Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }

        }
        private void OpenScheme()
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmOpenSchema frm = new FrmOpenSchema(this.probDatabase.ListOfSchemeNameToLower());
                frm.ShowDialog();

                string schemeSelected = frm.selected;
                if (schemeSelected != string.Empty)
                {
                    OpenSchemeByNameScheme(schemeSelected);
                    iCloseCurrentSchema.Enabled = true;
                }
                ribbonControl.SelectedPage = SchemaRibbonPage;
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iOpenSchema_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                OpenScheme();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void openSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenScheme();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuSchNode_OpenSchema_Click(object sender, EventArgs e)
        {
            try
            {
                string schemeName = TreeView.SelectedNode.Name;
                OpenSchemeByNameScheme(schemeName);
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Edit Schema
        private void EditScheme(string schemeName)
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Cannot find the Database !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                FrmEditSchema frm = new FrmEditSchema(this.probDatabase, schemeName);
                frm.ShowDialog();

                this.probDatabase = frm.probDatabase;
                this.LoadSchemaNode();
                if (currentSchema != null)
                {
                    SchemaXtraTabPage.Text = "Schema " + currentSchema.SchemaName;
                }
                xtraTabControlDatabase.SelectedTabPage = xtraTabControlDatabase.TabPages[0];
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void EditScheme()
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmEditSchema frm = new FrmEditSchema(this.probDatabase);
                frm.ShowDialog();

                if (currentSchema != null)
                {
                    SchemaXtraTabPage.Text = "Schema " + currentSchema.SchemaName;
                }

                this.probDatabase = frm.probDatabase;
                this.LoadSchemaNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iEditSchema_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                EditScheme();

            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuSchema_EditSchemas_Click(object sender, EventArgs e)
        {
            try
            {
                EditScheme();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuSchNode_EditSchema_Click(object sender, EventArgs e)
        {
            try
            {
                string schemeName = TreeView.SelectedNode.Name;
                EditScheme(schemeName.ToLower());

            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Delete Schema
        private void DeleteScheme(string SchemeName)
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmDelSchema frm = new FrmDelSchema(this.probDatabase, SchemeName);
                frm.ShowDialog();
                this.probDatabase = frm.probDatabase;
                if (!this.probDatabase.ListOfSchemeNameToLower().Contains((SchemaXtraTabPage.Text.Substring(SchemaXtraTabPage.Text.IndexOf("Schema") + 1)).Trim().ToLower()))
                {

                    SchemaXtraTabPage.Text = "Schema";
                    gridControlScheme.DataSource = null;
                    gridControlScheme.Update();
                }

                if (SchemaXtraTabPage.Text == "Schema")
                    iCloseCurrentSchema.Enabled = false;
                else
                    iCloseCurrentSchema.Enabled = true;
                LoadSchemaNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }

        }
        private void DeleteScheme()
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmDelSchema frm = new FrmDelSchema(this.probDatabase);
                frm.ShowDialog();
                this.probDatabase = frm.probDatabase;

                if (!this.probDatabase.ListOfSchemeNameToLower().Contains((SchemaXtraTabPage.Text.Substring(SchemaXtraTabPage.Text.IndexOf("Schema") + 1)).Trim().ToLower()))
                {
                    SchemaXtraTabPage.Text = "Schema";
                    gridControlScheme.DataSource = null;
                    gridControlScheme.Update();
                    iCloseCurrentSchema.Enabled = false;

                }

                if (SchemaXtraTabPage.Text == "Schema")
                    iCloseCurrentSchema.Enabled = false;
                else
                    iCloseCurrentSchema.Enabled = true;
                LoadSchemaNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iDeleteSchema_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DeleteScheme();

            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void deleteSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteScheme();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuSchNode_DeleteSchema_Click(object sender, EventArgs e)
        {
            try
            {
                string schemeName = TreeView.SelectedNode.Name;
                DeleteScheme(schemeName);

            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Close Schema
        private void iCloseCurrentSchema_ItemClick(object sender, ItemClickEventArgs e)
        {
            SchemaXtraTabPage.Text = "Schema ";
            gridControlScheme.DataSource = null;
            iCloseCurrentSchema.Enabled = false;
        }
        private void closeCurrentSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SchemaXtraTabPage.Text = "Schema ";
                gridControlScheme.DataSource = null;
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion           
        #endregion
        #region *Relation
        private void ResetGridViewRelation(FProbRelationBLL currentRelationOpen)
        {
            gridControlRelation.DataSource = null;
            gridViewRelation.Columns.Clear();
            dtrelation = new DataTable();
            int i = 0;
            foreach (FProbAttributeBLL att in currentRelationOpen.FproSchema.FproAttributes)
            {
                dtrelation.Columns.Add("Column" + i, typeof(String));
                GridColumn columnDiff = new GridColumn();
                columnDiff.Caption = att.AttributeName;
                columnDiff.Name = "Column" + i;
                columnDiff.FieldName = "Column" + i;
                columnDiff.OptionsColumn.ReadOnly = false;
                columnDiff.OptionsColumn.AllowEdit = false;
                if (att.FproDataType.TypeName == "DiscreteFuzzySet" || att.FproDataType.TypeName == "ContinuousFuzzySet")
                {
                    columnDiff.OptionsColumn.ReadOnly = true;
                }
                columnDiff.Visible = true;
                columnDiff.VisibleIndex = i;
                gridViewRelation.Columns.Add(columnDiff);
                i++;
            }
            if (currentRelationOpen.FproTuples.Count > 0)
            {
                int nRow = currentRelationOpen.FproTuples.Count;
                int nCol = currentRelationOpen.FproSchema.FproAttributes.Count;
                FProbTupleBLL tuple;
                for (i = 0; i < nRow; i++)      // Assign data for GridViewData
                {
                    tuple = currentRelationOpen.FproTuples[i];
                    DataRow row = dtrelation.NewRow();
                    for (int j = 0; j < nCol; j++)                       
                        row[j] = tuple.FproTriples[j].GetStrValue();
                    dtrelation.Rows.Add(row);
                }
            }
            gridControlRelation.DataSource = dtrelation;
        }
        #region *New Relation
        private void NewRelation()
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.probDatabase.FproSchemas.Count == 0)
                {
                    XtraMessageBox.Show("The first, you must create some schema, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmNewRelation frm = new FrmNewRelation(this.probDatabase);
                frm.ShowDialog();
                this.probDatabase = frm.probDatabase;
                LoadRelationNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iNewRelation_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                NewRelation();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuRelation_NewRelation_Click(object sender, EventArgs e)
        {
            try
            {
                NewRelation();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Open Relation
        private void OpenRelationByName(string RelationName)
        {
            try
            {
                RelationXtraTabPage.PageEnabled = true;
                RelationXtraTabPage.Text = "Relation " + RelationName;
                xtraTabControlDatabase.SelectedTabPage = xtraTabControlDatabase.TabPages[1];
                currentRelationOpen = this.probDatabase.FproRelations.SingleOrDefault(c => c.RelationName == RelationName);
                ResetGridViewRelation(currentRelationOpen);
                iCloseRelation.Enabled = true;
                ribbonControl.SelectedPage = RelationRibbonPage;
                iSaveRelation.Enabled = true;
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iOpenRelation_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.probDatabase.FproRelations.Count == 0)
                {
                    XtraMessageBox.Show("The first, you must create some relation, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmOpenRelation frm = new FrmOpenRelation(this.probDatabase.ListOfRelationNameToLower());
                frm.ShowDialog();

                if (frm.relationName != string.Empty)
                {
                    OpenRelationByName(frm.relationName);
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuRelNode_OpenRelation_Click(object sender, EventArgs e)
        {
            try
            {
                string relationName = TreeView.SelectedNode.Name;
                OpenRelationByName(relationName);

            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion 
        #region *Delete Relation
        private void iDeleteRelation_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.probDatabase.FproRelations.Count == 0)
                {
                    XtraMessageBox.Show("The first, you must create some relation, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmDelRelation frm = new FrmDelRelation(this.probDatabase);
                frm.ShowDialog();

                if (xtraTabControlDatabase.TabPages[1].Text.Contains(frm.relationNameRemove))
                {
                    xtraTabControlDatabase.TabPages[1].Text = "Relation";
                    gridControlRelation.DataSource = null;
                    gridViewRelation.Columns.Clear();
                    xtraTabControlDatabase.TabPages[1].PageEnabled = false;
                }

                if (RelationXtraTabPage.Text.Trim() == "Relation")
                {
                    iSaveRelation.Enabled = false;
                    iCloseRelation.Enabled = false;
                }
                else
                {
                    iSaveRelation.Enabled = true;
                    iCloseRelation.Enabled = true;
                }

                this.probDatabase = frm.probDatabase;
                LoadRelationNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuRelNode_DeleteRelation_Click(object sender, EventArgs e)
        {
            try
            {
                string relationName = TreeView.SelectedNode.Name;
                FrmDelRelation frm = new FrmDelRelation(this.probDatabase, relationName);
                frm.ShowDialog();
                this.probDatabase = frm.probDatabase;

                if (xtraTabControlDatabase.TabPages[1].Text.Contains(frm.relationNameRemove))
                {
                    xtraTabControlDatabase.TabPages[1].Text = "Relation";
                    gridControlRelation.DataSource = null;
                    gridViewRelation.Columns.Clear();
                    xtraTabControlDatabase.TabPages[1].PageEnabled = false;
                }

                if (RelationXtraTabPage.Text.Trim() == "Relation")
                {
                    iSaveRelation.Enabled = false;
                    iCloseRelation.Enabled = false;
                }
                else
                {
                    iSaveRelation.Enabled = true;
                    iCloseRelation.Enabled = true;
                }

                LoadRelationNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuRelation_DeleteRelations_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.probDatabase.FproRelations.Count <= 0)
                {
                    XtraMessageBox.Show("No relation to delete ", "Delete All Relations", MessageBoxButtons.OK);
                }

                else
                {
                    DialogResult result = new DialogResult();
                    result = XtraMessageBox.Show("Are you sure want to delete all relations ?", "Delete All Relations", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        NodeRelation.Nodes.Clear();

                        xtraTabControlDatabase.TabPages[1].Text = "Relation";
                        gridControlRelation.DataSource = null;
                        gridViewRelation.Columns.Clear();

                        if (RelationXtraTabPage.Text.Trim() == "Relation")
                        {
                            iSaveRelation.Enabled = false;
                            iCloseRelation.Enabled = false;
                        }
                        else
                        {
                            iSaveRelation.Enabled = true;
                            iCloseRelation.Enabled = true;
                        }

                        foreach (FProbRelationBLL relation in this.probDatabase.FproRelations)
                        {
                            relation.DropTableByTableName();
                            relation.DeleteRelationById();
                        }
                        this.probDatabase.FproRelations = new List<FProbRelationBLL>();
                        NodeRelation.ImageIndex = NodeRelation.SelectedImageIndex = Folder_ImgIndex.UnselectedState;
                    }
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Close Relation
        private void iCloseRelation_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabControlDatabase.TabPages[1].Text = "Relation";
            gridControlRelation.DataSource = null;
            gridViewRelation.Columns.Clear();
            xtraTabControlDatabase.TabPages[1].PageEnabled = false;
            iCloseRelation.Enabled = false;
            iSaveRelation.Enabled = false;
        }
        #endregion
        #region *Rename Relation
        private void CTMenuRelNode_RenameRelation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Cannot find the Database !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.probDatabase.FproRelations.Count == 0)
                {
                    XtraMessageBox.Show("You must create some relation first !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string relationName = TreeView.SelectedNode.Name;
                FrmRenameRelation frm = new FrmRenameRelation(this.probDatabase, relationName);
                frm.ShowDialog();

                this.probDatabase = frm.probDatabase;

                RelationXtraTabPage.Text = "Relation " + this.currentRelationOpen.RelationName;

                LoadRelationNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Save Relation
        private void SaveRelation()
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Cannot find the Database !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string RelationName = currentRelationOpen.RelationName;
                int nRow, nCol;
                nRow = gridViewRelation.DataRowCount;
                nCol = gridViewRelation.Columns.Count;
                if (nRow == 0)
                {
                    if (XtraMessageBox.Show("Relation: " + RelationName + " is not value!\nDo you save?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        currentRelationOpen.DropTableByTableName();
                        currentRelationOpen.CreateTableRelation();
                        currentRelationOpen.FproTuples.Clear();
                        XtraMessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    currentRelationOpen.DropTableByTableName();
                    currentRelationOpen.CreateTableRelation();
                    currentRelationOpen.FproTuples.Clear();

                    for (int i = 0; i < nRow; i++)
                    {
                        FProbTupleBLL tuple = new FProbTupleBLL();
                        for (int j = 0; j < nCol; j++)
                        {
                            FProbTripleBLL triple = new FProbTripleBLL(gridViewRelation.GetRowCellValue(i, gridViewRelation.Columns[j]).ToString().Trim());
                            tuple.FproTriples.Add(triple);
                        }
                        currentRelationOpen.FproTuples.Add(tuple);
                    }
                    currentRelationOpen.InsertTupleIntoTableRelation();
                    XtraMessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch(Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private bool CheckValue()
        {
            string sErr = null;
            bool bVali = true;
            int nRow = gridViewRelation.DataRowCount;
            int col = gridViewRelation.Columns.Count;
            // kiem tra 6 cell cua mot dong dang Edit xem co rong ko
            if(nRow>=1)
            {
                for (int i = 0; i < col; i++)
                {
                    if (gridViewRelation.GetRowCellValue(gridViewRelation.FocusedRowHandle, gridViewRelation.Columns[i]).ToString() == "")
                    {
                        string defaultValue = currentRelationOpen.FproSchema.FproAttributes[i].FproDataType.getDefaultValue();
                        gridViewRelation.SetRowCellValue(gridViewRelation.FocusedRowHandle, gridViewRelation.Columns[i], defaultValue);
                    }
                    else
                    {

                        if (!new FProbTripleBLL().isProbTripleValue(gridViewRelation.GetRowCellValue(gridViewRelation.FocusedRowHandle, gridViewRelation.Columns[i]).ToString()))
                        {
                            sErr = "Syntax Error! Cannot convert this value to a Probabilistic Triple!";
                            bVali = false;
                            break;
                        }

                        if (!currentRelationOpen.FproSchema.FproAttributes[i].FproDataType.CheckDataType(gridViewRelation.GetRowCellValue(gridViewRelation.FocusedRowHandle, gridViewRelation.Columns[i]).ToString()))
                        {
                            sErr = "Attribute value does not match the data type !";
                            bVali = false;
                            break;
                        }
                    }
                }
                List<int> indexPrimaryKey = currentRelationOpen.FproSchema.ListIndexPrimaryKey();
                for (int j = 0; j < indexPrimaryKey.Count; j++)
                {
                    FProbTripleBLL triple = new FProbTripleBLL(gridViewRelation.GetRowCellValue(gridViewRelation.FocusedRowHandle, gridViewRelation.Columns[j]).ToString());

                    if (triple.Value.Count != 1)
                    {
                        sErr = "This object is a primary key it only accepts single value ";
                        bVali = false;
                        break;
                    }
                    //ktr xac xuat duy nhat
                    if (triple.MinProb[0] != 1.0 || triple.MaxProb[0] != 1.0)
                    {
                        sErr = "This object is a primary key Its minprob and maxprob must be 1";
                        bVali = false;
                        break;
                    }
                }
                if (!bVali)
                {
                    // coi như valid không qua được. bạn sẽ không làm được gì trừ khi
                    //điền thêm thông tin hoặc bấm nút ESC trên bàn phím
                    XtraMessageBox.Show(sErr, "Error!!!");
                    return bVali;
                }
                else
                    if (gridViewRelation.FocusedRowHandle < 0)
                    {
                        for (int i = 0; i < nRow; i++)
                        {
                            int k = 0;

                            for (k = 0; k < indexPrimaryKey.Count; k++)
                            {

                                FProbTripleBLL tripleOne = new FProbTripleBLL(gridViewRelation.GetRowCellValue(gridViewRelation.FocusedRowHandle, gridViewRelation.Columns[k]).ToString());
                                FProbTripleBLL tripleTwo = new FProbTripleBLL(gridViewRelation.GetRowCellValue(i, gridViewRelation.Columns[k]).ToString());
                                if (tripleOne.GetStrValue() != tripleTwo.GetStrValue())
                                    break;
                            }

                            if (k == indexPrimaryKey.Count)
                            {
                                bVali = false;
                                sErr = "Cannot insert duplicate key in this object ";
                                XtraMessageBox.Show(sErr, "Error!!!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < nRow; i++)
                        {
                            if (i != gridViewRelation.FocusedRowHandle)
                            {
                                int k = 0;

                                for (k = 0; k < indexPrimaryKey.Count; k++)
                                {

                                    FProbTripleBLL tripleOne = new FProbTripleBLL(gridViewRelation.GetRowCellValue(gridViewRelation.FocusedRowHandle, gridViewRelation.Columns[k]).ToString());
                                    FProbTripleBLL tripleTwo = new FProbTripleBLL(gridViewRelation.GetRowCellValue(i, gridViewRelation.Columns[k]).ToString());
                                    if (tripleOne.GetStrValue() != tripleTwo.GetStrValue())
                                        break;
                                }

                                if (k == indexPrimaryKey.Count)
                                {
                                    bVali = false;
                                    sErr = "Cannot insert duplicate key in this object ";
                                    XtraMessageBox.Show(sErr, "Error!!!");
                                    break;
                                }
                            }
                        }
                    }
            } 
            return bVali;
        }
        private void iSaveRelation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (CheckValue())
            {
                gridViewRelation.UpdateCurrentRow();
                SaveRelation();
            }
        }
        private void gridViewRelation_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        private void gridViewRelation_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = null;
            bool bVali = true;
            int nRow = gridViewRelation.DataRowCount;
            int col = gridViewRelation.Columns.Count;
            // kiem tra 6 cell cua mot dong dang Edit xem co rong ko
            for (int i = 0; i < col; i++)
            {
                if (gridViewRelation.GetRowCellValue(e.RowHandle, gridViewRelation.Columns[i]).ToString() == "")
                {
                    string defaultValue = currentRelationOpen.FproSchema.FproAttributes[i].FproDataType.getDefaultValue();
                    gridViewRelation.SetRowCellValue(e.RowHandle, gridViewRelation.Columns[i], defaultValue);
                }
                else
                {

                    if (!new FProbTripleBLL().isProbTripleValue(gridViewRelation.GetRowCellValue(e.RowHandle, gridViewRelation.Columns[i]).ToString()))
                    {
                        sErr = "Syntax Error! Cannot convert this value to a Probabilistic Triple!";
                        bVali = false;
                        break;
                    }

                    if (!currentRelationOpen.FproSchema.FproAttributes[i].FproDataType.CheckDataType(gridViewRelation.GetRowCellValue(e.RowHandle, gridViewRelation.Columns[i]).ToString()))
                    {
                        sErr = "Attribute value does not match the data type !";
                        bVali = false;
                        break;
                    }
                }
            }
            List<int> indexPrimaryKey = currentRelationOpen.FproSchema.ListIndexPrimaryKey();
            for (int j = 0; j < indexPrimaryKey.Count; j++)
            {
                FProbTripleBLL triple = new FProbTripleBLL(gridViewRelation.GetRowCellValue(e.RowHandle, gridViewRelation.Columns[j]).ToString());

                if (triple.Value.Count != 1)
                {
                    sErr = "This object is a primary key it only accepts single value ";
                    bVali = false;
                    break;
                }
                //ktr xac xuat duy nhat
                if (triple.MinProb[0] != 1.0 || triple.MaxProb[0] != 1.0)
                {
                    sErr = "This object is a primary key Its minprob and maxprob must be 1";
                    bVali = false;
                    break;
                }
            }
            if (!bVali)
            {

                e.Valid = false;
                // coi như valid không qua được. bạn sẽ không làm được gì trừ khi
                //điền thêm thông tin hoặc bấm nút ESC trên bàn phím
                XtraMessageBox.Show(sErr, "Error!!!");
                return;
            }
            else
            if (e.RowHandle < 0)
            {
                for (int i = 0; i < nRow; i++)
                {
                    int k = 0;

                    for (k = 0; k < indexPrimaryKey.Count; k++)
                    {

                        FProbTripleBLL tripleOne = new FProbTripleBLL(gridViewRelation.GetRowCellValue(e.RowHandle, gridViewRelation.Columns[k]).ToString());
                        FProbTripleBLL tripleTwo = new FProbTripleBLL(gridViewRelation.GetRowCellValue(i, gridViewRelation.Columns[k]).ToString());
                        if (tripleOne.GetStrValue() != tripleTwo.GetStrValue())
                            break;
                    }

                    if (k == indexPrimaryKey.Count)
                    {
                        sErr = "Cannot insert duplicate key in this object ";
                        e.Valid = false;
                        XtraMessageBox.Show(sErr, "Error!!!");
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < nRow; i++)
                {
                    if (i != e.RowHandle)
                    {
                        int k = 0;

                        for (k = 0; k < indexPrimaryKey.Count; k++)
                        {

                            FProbTripleBLL tripleOne = new FProbTripleBLL(gridViewRelation.GetRowCellValue(e.RowHandle, gridViewRelation.Columns[k]).ToString());
                            FProbTripleBLL tripleTwo = new FProbTripleBLL(gridViewRelation.GetRowCellValue(i, gridViewRelation.Columns[k]).ToString());
                            if (tripleOne.GetStrValue() != tripleTwo.GetStrValue())
                                break;
                        }

                        if (k == indexPrimaryKey.Count)
                        {
                            sErr = "Cannot insert duplicate key in this object ";
                            e.Valid = false;
                            XtraMessageBox.Show(sErr, "Error!!!");
                            return;
                        }
                    }
                }
            }
        }
        #endregion
        private void Checkbox_UUD_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_UUD.Checked) SwitchValueState(true);
        }
        private void Checkbox_UD_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_UD.Checked) SwitchValueState(false);
        }
        private void gridViewRelation_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    FrmFuzzyTriple frmfuzzy;
                    string attributename = e.Column.ToString().ToLower();
                    string datatypename = this.currentRelationOpen.FproSchema.FproAttributes.SingleOrDefault(c => c.AttributeName.ToLower() == attributename).FproDataType.TypeName;
                    if (e.CellValue==null)
                        frmfuzzy = new FrmFuzzyTriple(e.Column.Caption, attributename, datatypename, "");
                    else
                        frmfuzzy = new FrmFuzzyTriple(e.Column.Caption, attributename, datatypename, e.CellValue.ToString());
                    frmfuzzy.ShowDialog();
                    gridViewRelation.SetRowCellValue(e.RowHandle, e.Column.FieldName, frmfuzzy.valuename);
                }
                catch{}
            }
            else
            {
                if (e.RowHandle < 0)
                {
                    gridControlValueRelation.DataSource = null;
                    MemoEditTxtValueRelation.Text = "";
                    txtMaxProb.Text = "";
                    txtMinProb.Text = "";
                }
                else
                {
                    try
                    {
                        gridControlValueRelation.DataSource = null;
                        dtvalrelation = new DataTable();
                        dtvalrelation.Columns.Add("gridColumnValue", typeof(String));
                        dtvalrelation.Columns.Add("gridColumnMinProb", typeof(Double));
                        dtvalrelation.Columns.Add("gridColumnMaxProb", typeof(Double));
                        if (gridViewRelation.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                        {
                            FProbTripleBLL triple = new FProbTripleBLL(gridViewRelation.GetRowCellValue(e.RowHandle, e.Column.FieldName).ToString());
                            if (Checkbox_UUD.Checked)
                            {
                                for (int i = 0; i < triple.Value.Count; i++)
                                {
                                    DataRow row = dtvalrelation.NewRow();
                                    row[0] = triple.Value[i].ToString();
                                    row[1] = triple.MinProb[i];
                                    row[2] = triple.MaxProb[i];
                                    dtvalrelation.Rows.Add(row);
                                }
                                gridControlValueRelation.DataSource = dtvalrelation;
                            }
                            else
                            {
                                MemoEditTxtValueRelation.Text = "";
                                txtMaxProb.Text = "";
                                txtMinProb.Text = "";

                                if (triple.UniformDistribution())
                                {
                                    double minProb = 0.0;
                                    double maxProb = 0.0;

                                    for (int i = 0; i < triple.Value.Count; i++)
                                    {
                                        MemoEditTxtValueRelation.Text += triple.Value[i].ToString() + System.Environment.NewLine;
                                        minProb += triple.MinProb[i];
                                        maxProb += triple.MaxProb[i];

                                    }
                                    txtMinProb.Text = minProb.ToString();
                                    txtMaxProb.Text = maxProb.ToString();

                                }

                            }
                        }
                    }
                    catch { }
                }
            }
        }      
        #endregion     
        #region *Query
        #region *New Query
        private void CreateNewQuery()
        {
            try
            {

                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmNewQuery frm = new FrmNewQuery(this.probDatabase);
                frm.ShowDialog();

                if (frm.queryName != string.Empty)
                {
                    this.probDatabase = frm.probDatabase;
                    LoadQueryNode();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuQuery_NewQuery_Click(object sender, EventArgs e)
        {
            CreateNewQuery();
        }
        private void iNewQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateNewQuery();
        }
        #endregion
        #region *Open Query
        private void OpenQueryByName(string NameQuery)
        {
            currentQuery = this.probDatabase.FproQueries.SingleOrDefault(c => c.QueryName == NameQuery);
            QueryXtraTabPage.Text = "Query " + currentQuery.QueryName;
            xtraTabControlDatabase.SelectedTabPage = xtraTabControlDatabase.TabPages[2];
            ribbonControl.SelectedPage = QueryRibbonPage;

            memoEditTxtQuery.Clear();
            memoEditTxtQuery.Text = currentQuery.QueryString == "Empty" ? "" : currentQuery.QueryString;
            iCloseQuery.Enabled = true;
            iSaveQuery.Enabled = true;

            conjunctionRibbonPageGroup.Visible = true;
            disjunctionRibbonPageGroup.Visible = true;
            differenceRibbonPageGroup.Visible = true;
            equalityRibbonPageGroup.Visible = true;
            operatorRibbonPageGroup.Visible = true;
            excuteQueryribbonPageGroup.Visible = true;
            QueryXtraTabPage.PageEnabled = true;
            xtraTabControlDatabase.SelectedTabPage = QueryXtraTabPage;

            if (memoEditTxtQuery.Text.Trim().Length <= 0 || currentQuery.QueryString == string.Empty)
            {
                iExcuteQuery.Enabled = false;
            }
            else
            {
                iExcuteQuery.Enabled = true;
                memoEditTxtQuery.ForeColor = Color.Black;
            }
            gridControlResultQuery.DataSource = null;
            gridViewResultQuery.Columns.Clear();
        }
        private void iOpenQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.probDatabase == null)
                {
                    XtraMessageBox.Show("Error : Cannot find the Database, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.probDatabase.FproRelations.Count == 0)
                {
                    XtraMessageBox.Show("The first, you must create some query, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmOpenQuery frm = new FrmOpenQuery(this.probDatabase);
                frm.ShowDialog();
                if (frm.QueryName != string.Empty)
                {

                    OpenQueryByName(frm.QueryName);

                }

            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuQueryNode_OpenQuery_Click(object sender, EventArgs e)
        {
            string QueryName = TreeView.SelectedNode.Name;
            OpenQueryByName(QueryName);
        }
        #endregion
        #region *Save Query
        public void SaveQuery()
        {
            currentQuery.QueryString = memoEditTxtQuery.Text.Trim();
            currentQuery.Update();
            MessageBox.Show("Save successfully !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadQueryNode();
        }
        private void iSaveQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (currentQuery != null)
                    SaveQuery();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Close Query
        private void iCloseQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                currentQuery = null;
                xtraTabControlDatabase.TabPages[2].Text = "Query";
                memoEditTxtQuery.Text = "";
                iExcuteQuery.Enabled = false;
                iCloseQuery.Enabled = false;
                iSaveQuery.Enabled = false;

                conjunctionRibbonPageGroup.Visible = false;
                disjunctionRibbonPageGroup.Visible = false;
                differenceRibbonPageGroup.Visible = false;
                equalityRibbonPageGroup.Visible = false;
                operatorRibbonPageGroup.Visible = false;
                excuteQueryribbonPageGroup.Visible = false;

                QueryXtraTabPage.PageEnabled = false;
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Delate Query
        private void CTMenuQuery_DeleteQueries_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.probDatabase.FproQueries.Count == 0)
                {
                    XtraMessageBox.Show("You must create some query first !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = new DialogResult();
                result = XtraMessageBox.Show("Are you sure want to delete all queries ?", "Delete All Queries", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NodeQuery.Nodes.Clear();

                    this.probDatabase.FproQueries.Clear();
                    new FProbQueryBLL().DeleteAllQuery();


                    NodeQuery.ImageIndex = NodeQuery.SelectedImageIndex = Folder_ImgIndex.UnselectedState;
                    currentQuery = null;
                    xtraTabControlDatabase.TabPages[2].Text = "Query";
                    memoEditTxtQuery.Text = "";
                    iExcuteQuery.Enabled = false;
                    iCloseQuery.Enabled = false;
                    iSaveQuery.Enabled = false;

                    conjunctionRibbonPageGroup.Visible = false;
                    disjunctionRibbonPageGroup.Visible = false;
                    differenceRibbonPageGroup.Visible = false;
                    equalityRibbonPageGroup.Visible = false;
                    operatorRibbonPageGroup.Visible = false;
                    excuteQueryribbonPageGroup.Visible = false;
                    QueryXtraTabPage.PageEnabled = false;

                    gridControlResultQuery.DataSource = null;
                    gridViewResultQuery.Columns.Clear();
                    memoEditTxtQuery.Text = "";

                    iExcuteQuery.Enabled = false;
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void CTMenuQuery_DeleteQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.probDatabase.FproQueries.Count == 0)
                {
                    XtraMessageBox.Show("You must create some query first !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string QueryName = TreeView.SelectedNode.Name;

                FrmDelQuery frm = new FrmDelQuery(this.probDatabase, QueryName);
                frm.ShowDialog();

                this.probDatabase = frm.probDatabase;

                if (xtraTabControlDatabase.TabPages[2].Text.Contains(frm.QueryNameRemove))
                {
                    xtraTabControlDatabase.TabPages[2].Text = "Query";
                    memoEditTxtQuery.Text = "";
                    gridControlResultQuery.DataSource = null;
                    gridViewResultQuery.Columns.Clear();
                    iExcuteQuery.Enabled = false;
                    iCloseQuery.Enabled = false;
                    iSaveQuery.Enabled = false;

                    conjunctionRibbonPageGroup.Visible = false;
                    disjunctionRibbonPageGroup.Visible = false;
                    differenceRibbonPageGroup.Visible = false;
                    equalityRibbonPageGroup.Visible = false;
                    operatorRibbonPageGroup.Visible = false;
                    excuteQueryribbonPageGroup.Visible = false;
                }
                LoadQueryNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        private void iDeleteQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.probDatabase.FproQueries.Count == 0)
                {
                    XtraMessageBox.Show("The first, you must create some query, please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmDelQuery frm = new FrmDelQuery(this.probDatabase);
                frm.ShowDialog();

                this.probDatabase = frm.probDatabase;

                if (xtraTabControlDatabase.TabPages[2].Text.Contains(frm.QueryNameRemove.ToString()))
                {
                    xtraTabControlDatabase.TabPages[2].Text = "Query";
                    memoEditTxtQuery.Text = "";
                    gridControlResultQuery.DataSource = null;
                    gridViewResultQuery.Columns.Clear();

                    iExcuteQuery.Enabled = false;
                    iCloseQuery.Enabled = false;
                    iSaveQuery.Enabled = false;

                    conjunctionRibbonPageGroup.Visible = false;
                    disjunctionRibbonPageGroup.Visible = false;
                    differenceRibbonPageGroup.Visible = false;
                    equalityRibbonPageGroup.Visible = false;
                    operatorRibbonPageGroup.Visible = false;
                    excuteQueryribbonPageGroup.Visible = false;
                    QueryXtraTabPage.PageEnabled = false;
                }
                LoadQueryNode();
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion      
        #region *Rename Query
        private void CTMenuQuery_RenameQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string queryName = TreeView.SelectedNode.Name;
                FrmRenameQuery frm = new FrmRenameQuery(this.probDatabase, queryName);
                frm.ShowDialog();


                if (frm.queryName != string.Empty)
                {
                    this.probDatabase = frm.probDatabase;
                    if (xtraTabControlDatabase.TabPages[2].Text.Contains(frm.QueryNameRename))
                    {
                        xtraTabControlDatabase.TabPages[2].Text = "Query" + frm.queryName;
                    }
                    LoadQueryNode();
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        #endregion
        #region *Button Query
        private void memoEditTxtQuery_TextChanged(object sender, EventArgs e)
        {
            #region old

            if (memoEditTxtQuery.Text.Trim().Length <= 0)
            {
                memoEditTxtQuery.SelectionColor = Color.Black;
                iExcuteQuery.Enabled = false;
            }
            else
            {
                iExcuteQuery.Enabled = true;
                int index = memoEditTxtQuery.SelectionStart;
                string tmp = memoEditTxtQuery.Text;
                memoEditTxtQuery.Clear();
                memoEditTxtQuery.Text = tmp;

                memoEditTxtQuery.DeselectAll();
                string tmpString = memoEditTxtQuery.Text.ToLower();

                int indexSelect = tmpString.IndexOf("select ");
                int indexFrom = tmpString.IndexOf("from ");
                int indexWhere = tmpString.IndexOf("where ");

                int indexLastSelect = tmpString.LastIndexOf("select ");
                int indexLastFrom = tmpString.LastIndexOf("from ");
                int indexLastWhere = tmpString.LastIndexOf("where ");

                //string[] array = tmp.Split(new char[] { ' ' });

                //for (int i = 0; i < array.Length; i++)
                //{
                //    if (Operator.ToList().Contains(array[i].ToLower()))
                //    {
                //        int count = 0;
                //        for (int j = 0; j < i; j++)
                //        {
                //            count += array[j].Length + 1;
                //        }

                //        memoEditTxtQuery.Select(count, array[i].Length + 1);
                //        memoEditTxtQuery.SelectionColor = Color.Blue;
                //    }
                //}

                if (indexSelect != -1)
                {
                    memoEditTxtQuery.Select(indexSelect, 6);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if(indexFrom != -1)
                {
                    memoEditTxtQuery.Select(indexFrom, 4);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if(indexWhere != -1)
                {
                    memoEditTxtQuery.Select(indexWhere, 5);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (indexLastSelect != -1)
                {
                    memoEditTxtQuery.Select(indexLastSelect, 6);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (indexLastFrom != -1)
                {
                    memoEditTxtQuery.Select(indexLastFrom, 4);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (indexLastWhere != -1)
                {
                    memoEditTxtQuery.Select(indexLastWhere, 5);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }

                int indexNaturalJoin = tmp.IndexOf(" natural join");
                if (tmp.IndexOf(" natural join ⊗_in") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" natural join ⊗_in");
                    memoEditTxtQuery.Select(indexNaturalJoin, 19);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                else
                    if (tmp.IndexOf(" natural join ⊗_ig") != -1)
                    {

                        indexNaturalJoin = tmp.IndexOf(" natural join ⊗_ig");
                        memoEditTxtQuery.Select(indexNaturalJoin, 19);
                        memoEditTxtQuery.SelectionColor = Color.Blue;

                    }
                // kiem tra tu khoa va to xanh tu khoa do
                if (tmp.IndexOf(" natural join ⊗_me") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" natural join ⊗_me");
                    memoEditTxtQuery.Select(indexNaturalJoin, 19);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if(tmp.IndexOf(" except ⊖_in") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" except ⊖_in");
                    memoEditTxtQuery.Select(indexNaturalJoin, 12);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (tmp.IndexOf(" except ⊖_ig") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" except ⊖_ig");
                    memoEditTxtQuery.Select(indexNaturalJoin, 12);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (tmp.IndexOf(" except ⊖_me") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" except ⊖_me");
                    memoEditTxtQuery.Select(indexNaturalJoin, 12);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (tmp.IndexOf(" intersect ⊗_in") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" intersect ⊗_in");
                    memoEditTxtQuery.Select(indexNaturalJoin, 15);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }

                if (tmp.IndexOf(" intersect ⊗_ig") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" intersect ig");
                    memoEditTxtQuery.Select(indexNaturalJoin, 15);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }

                if (tmp.IndexOf(" intersect ⊗_me") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" intersect ⊗_me");
                    memoEditTxtQuery.Select(indexNaturalJoin, 15);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }

                if (tmp.IndexOf(" union ⊕_in") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" union ⊕_in");
                    memoEditTxtQuery.Select(indexNaturalJoin, 11);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (tmp.IndexOf(" union ⊕_ig") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" union ⊕_ig");
                    memoEditTxtQuery.Select(indexNaturalJoin, 11);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }
                if (tmp.IndexOf(" union ⊕_me") != -1)
                {
                    indexNaturalJoin = tmp.IndexOf(" union ⊕_me");
                    memoEditTxtQuery.Select(indexNaturalJoin, 11);
                    memoEditTxtQuery.SelectionColor = Color.Blue;
                }

                if (indexSelect != -1)
                {
                    if (indexSelect != 0)
                    {
                        string t = memoEditTxtQuery.Text.Substring(indexSelect - 1, 1).Trim();
                        if (t.Length == 0)
                        {
                            memoEditTxtQuery.Select(indexSelect, 6);
                            memoEditTxtQuery.SelectionColor = Color.Blue;
                        }
                    }
                    else
                    {
                        memoEditTxtQuery.Select(indexSelect, 6);
                        memoEditTxtQuery.SelectionColor = Color.Blue;
                    }
                }

                if (indexFrom != -1)
                {

                    if (indexFrom != 0)
                    {
                        string t = memoEditTxtQuery.Text.Substring(indexFrom - 1, 1).Trim();
                        if (t.Length == 0)
                        {
                            memoEditTxtQuery.Select(indexFrom, 5);
                            memoEditTxtQuery.SelectionColor = Color.Blue;
                        }
                    }
                    else
                    {
                        memoEditTxtQuery.Select(indexFrom, 5);
                        memoEditTxtQuery.SelectionColor = Color.Blue;
                    }
                }

                if (indexWhere != -1)
                {
                    if (indexWhere != 0)
                    {
                        string t = memoEditTxtQuery.Text.Substring(indexWhere - 1, 1).Trim();
                        if (t.Length == 0)
                        {
                            memoEditTxtQuery.Select(indexWhere, 6);
                            memoEditTxtQuery.SelectionColor = Color.Blue;
                        }
                    }
                    else
                    {
                        memoEditTxtQuery.Select(indexWhere, 6);
                        memoEditTxtQuery.SelectionColor = Color.Blue;

                    }
                }

                if (tmp.Contains("where "))
                {
                    string tmpWhere = tmp.Substring(tmp.IndexOf("where") + 6);
                    for (int i = 0; i < tmpWhere.Length - 1; )
                    {
                        int j = i + 1;
                        if (tmpWhere[i] == '\'')
                        {

                            for (int k = j; k < tmpWhere.Length; k++)
                            {
                                if (tmpWhere[k] == '\'')
                                {
                                    j = k + 1;
                                    memoEditTxtQuery.Select(i + tmp.IndexOf("where") + 6, j - i);
                                    memoEditTxtQuery.SelectionColor = Color.Red;
                                    break;
                                }
                                else
                                    if (tmpWhere[k] != '\'' && k == tmpWhere.Length - 1)
                                    {
                                        memoEditTxtQuery.Select(i + tmp.IndexOf("where") + 6, k - i + 1);
                                        memoEditTxtQuery.SelectionColor = Color.Red;
                                    }
                            }
                        }
                        i = j;
                    }
                }

                memoEditTxtQuery.Select(index, 1);
                memoEditTxtQuery.SelectionLength = 0;
                memoEditTxtQuery.SelectionStart = index;
            }
            #endregion
        }
        private void iOperator_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @"→";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @"→");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iConjunctionIgnorance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊗_ig ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊗_ig ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }        
        private void iConjunctionIndependence_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊗_in ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊗_in ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iConjunctionMutual_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊗_me ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊗_me ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iDisjunctionIgnorance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊕_ig ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊕_ig ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iDisjunctionIndependence_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊕_in ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊕_in ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iDisjunctionMutual_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊕_me ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊕_me ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iDifferenceIgnorance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊖_ig ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊖_ig ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iDifferenceIndependence_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊖_in ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊖_in ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iDiferenceMutual_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" ⊖_me ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" ⊖_me ");
                memoEditTxtQuery.SelectionStart = index + 6;
            }
        }
        private void iEqualityIg_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" EQUAL_ig ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" EQUAL_ig ");
                memoEditTxtQuery.SelectionStart = index + 10;
            }
        }
        private void iEqualityIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" EQUAL_in ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" EQUAL_in ");
                memoEditTxtQuery.SelectionStart = index + 10;
            }
        }
        private void iEqualityMe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (memoEditTxtQuery.Text == "") memoEditTxtQuery.Text = @" EQUAL_me ";

            else
            {

                int index = memoEditTxtQuery.SelectionStart;
                memoEditTxtQuery.Text = memoEditTxtQuery.Text.Insert(index, @" EQUAL_me ");
                memoEditTxtQuery.SelectionStart = index + 10;
            }
        }
        #endregion
        #region *Excute Query
        private void ClearAll()
        {

            foreach (FProbRelationBLL relation in this.probDatabase.FproRelations)
            {
                relation.ListRenameRelation.Clear();
                relation.RenameRelationName = string.Empty;

                foreach (FProbAttributeBLL attr in relation.FproSchema.FproAttributes)
                {
                    if (attr.AttributeName.Contains("."))
                    {
                        attr.AttributeName = attr.AttributeName.Substring(attr.AttributeName.IndexOf(".") + 1);
                    }
                }
            }
        }
        private void ExecuteQuery()
        {
            try
            {
                gridControlResultQuery.DataSource = null;
                gridViewResultQuery.Columns.Clear();
                //if (txtQuery.Text.Trim().Length <= 0)
                //{
                //    MessageBox.Show("Query does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                /*QueryExecution
                   public string queryString { get; set; }//câu truy vấn
                   public List<ProbRelation> selectedRelations { get; set; }//danh sách relation được chọn trong truy vấn
                   public ProbRelation relationResult { get; set; } // kết quả những relation tìm được sau truy vấn
                   public List<ProbAttribute> selectedAttributes;//danh sách attributes được chọn trong truy vấn
                   public ProbDatabase probDatabase { get; set; }// database hiện hành truy vấn
                   public string conditionString { get; set; }// danh sách điều kiện chọn where trong câu truy vấn
                   public bool flagNaturalJoin { get; set; }//kiểm tra có quan hệ không
                   private string OperationNaturalJoin = string.Empty;//loại quan hệ truy vấn
                   public string MessageError { get; set; }
                   public ProbRelation DescartesAndNaturalJoin { get; set; }
                 */
                //QueryExecution query = new QueryExecution(txtQuery.Text, this.probDatabase);
                //get database
                query = new QueryExecutionBLL(memoEditTxtQuery.Text, this.probDatabase);
                txtMessage.Text = "";

                if (query.ExecuteQuery())
                {
                    txtMessage.Text = string.Empty;
                    if (query.relationResult.FproTuples.Count <= 0)
                    {
                        txtMessage.Text = "No tuple satisfies the condition";
                        xtraTabControlResultQuery.SelectedTabPageIndex = 1;
                    }
                    else
                    {
                        gridControlResultQuery.DataSource = null;
                        gridViewResultQuery.Columns.Clear();
                        DataTable dtquery = new DataTable();
                        dtquery.Columns.Add("NoNumber", typeof(int));
                        GridColumn col = new GridColumn();
                        col.Caption = "Number";
                        col.Name = "NoNumber";
                        col.FieldName = "NoNumber";
                        col.OptionsColumn.ReadOnly = true;
                        col.OptionsColumn.AllowEdit = false;
                        col.Visible = true;
                        col.VisibleIndex = 0;
                        gridViewResultQuery.Columns.Add(col);
                        int i = 1;
                        foreach (FProbAttributeBLL att in query.selectedAttributes)
                        {
                            dtquery.Columns.Add("Col" + i, typeof(String));
                            GridColumn columnDiff = new GridColumn();
                            columnDiff.Caption = att.AttributeName;
                            columnDiff.Name = "Col" + i;
                            columnDiff.FieldName = "Col" + i;
                            columnDiff.OptionsColumn.ReadOnly = true;
                            columnDiff.OptionsColumn.AllowEdit = false;
                            if (att.FproDataType.TypeName == "DiscreteFuzzySet" || att.FproDataType.TypeName == "ContinuousFuzzySet")
                            {
                                columnDiff.OptionsColumn.ReadOnly = true;
                                columnDiff.AppearanceCell.Options.UseBackColor = true;
                                columnDiff.AppearanceCell.BackColor = Color.DeepSkyBlue;
                                columnDiff.AppearanceCell.BackColor2 = Color.LightCyan;
                            }
                            columnDiff.Visible = true;
                            columnDiff.VisibleIndex = i;
                            gridViewResultQuery.Columns.Add(columnDiff);

                            i++;
                        }

                        int j, k = -1;
                        foreach (FProbTupleBLL tuple in query.relationResult.FproTuples)
                        {
                            DataRow row = dtquery.NewRow();
                            k++; j = 1;
                            row[0] = k + 1;
                            foreach (FProbTripleBLL triple in tuple.FproTriples)
                            {
                                row[j] = triple.GetStrValue();
                                j++;
                            }
                            dtquery.Rows.Add(row);
                        }
                        gridControlResultQuery.DataSource = dtquery;
                        xtraTabControlResultQuery.SelectedTabPageIndex = 0;

                    }
                }
                else
                {
                    txtMessage.Text = query.MessageError;
                    xtraTabControlResultQuery.SelectedTabPageIndex = 1;
                }
            }
            catch
            {
                XtraMessageBox.Show("The value of column exists is null");

            }
            finally
            {
                ClearAll(); // đưa csdl về trạng thái ban đầu
            }
        }
        private void iExcuteQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExecuteQuery();
        }
        #endregion
        #endregion
        #region Help
        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            Help frm = new Help();
            frm.ShowDialog();
        }
        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmAbout frm=new FrmAbout();
            frm.ShowDialog();
        }
        #endregion
        #region Fuzzy
        private void gridViewResultQuery_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                string name = e.Column.Caption;
                if(e.Button==MouseButtons.Right)
                {
                    string type = query.selectedAttributes.SingleOrDefault(c => c.AttributeName == name).FproDataType.TypeName;
                    if (type == "DiscreteFuzzySet")
                    {
                        List<DiscreteFuzzySetBLL> listPoint = new List<DiscreteFuzzySetBLL>();
                        string listStr = gridViewResultQuery.GetRowCellValue(e.RowHandle, e.Column.FieldName).ToString();
                        listPoint = DiscreteFuzzySetBLL.DSDisFS(listStr);
                        if (listPoint != null)
                        {
                            DrawChart(listPoint);
                        }
                    }
                    else
                        if (type == "ContinuousFuzzySet")
                        {
                            List<ContinuousFuzzySetBLL> listPoint = new List<ContinuousFuzzySetBLL>();
                            string listStr = gridViewResultQuery.GetRowCellValue(e.RowHandle, e.Column.FieldName).ToString();
                            listPoint = ContinuousFuzzySetBLL.DSContFS(listStr);
                            if (listPoint != null)
                            {
                                DrawChart(listPoint);
                            }
                        }
                }  
            }
            catch
            {}
            
        }
        private void iLibraryDiscrete_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLibraryDis frm = new FrmLibraryDis();
            frm.ShowDialog();
            DrawChart(frm.PointList);
        }
        private void iLibraryContinuous_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLibraryCons frm = new FrmLibraryCons();
            frm.ShowDialog();
            DrawChart(frm.PointList);
        }
        private void DrawChart(List<ContinuousFuzzySetBLL> ConFS)
        {
            if (ConFS == null || ConFS.Count == 0) return;
            FuzzysetXtraTabPage.Controls.Clear();
            ResetFuzzyPage(true);
            ChartControl chartFuzzy = new ChartControl();
            for (int i = 0; i < ConFS.Count; i++)
            {
                Series series1 = new Series(ConFS[i].FuzzySetName, ViewType.Line);
                series1.Points.Add(new SeriesPoint(ConFS[i].BottomLeft.ToString(), 0));
                series1.Points.Add(new SeriesPoint(ConFS[i].TopLeft.ToString(), 1));
                series1.Points.Add(new SeriesPoint(ConFS[i].TopRight.ToString(), 1));
                series1.Points.Add(new SeriesPoint(ConFS[i].BottomRight.ToString(), 0));
                chartFuzzy.Series.Add(series1);
                series1.ArgumentScaleType = ScaleType.Numerical;
                ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Circle;
                ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;

            }
            ((XYDiagram)chartFuzzy.Diagram).EnableAxisXScrolling = true;

            // Add the chart to the form.
            chartFuzzy.Dock = DockStyle.Fill;
            FuzzysetXtraTabPage.Controls.Add(chartFuzzy);
        }
        private void DrawChart(List<DiscreteFuzzySetBLL> disFS)
        {
            if (disFS == null || disFS.Count == 0) return;
            FuzzysetXtraTabPage.Controls.Clear();
            ResetFuzzyPage(true);
            ChartControl chartFuzzy = new ChartControl();
            for (int i = 0; i < disFS.Count;i++)
            {
                Series series1 = new Series(disFS[i].FuzzySetName, ViewType.Point);
                series1.ArgumentScaleType = ScaleType.Numerical;
                for (int j = 0; j < disFS[i].ValueSet.Count;j++ )
                {
                    series1.Points.Add(new SeriesPoint(disFS[i].ValueSet[j].ToString(), disFS[i].MembershipSet[j]));
                }
                chartFuzzy.Series.Add(series1);
                PointSeriesView myView1 = (PointSeriesView)series1.View;
                myView1.PointMarkerOptions.Kind = MarkerKind.Circle;
                myView1.PointMarkerOptions.Size = 10;
            }
            ((XYDiagram)chartFuzzy.Diagram).EnableAxisXScrolling = true;

            // Add the chart to the form.
            chartFuzzy.Dock = DockStyle.Fill;
            FuzzysetXtraTabPage.Controls.Add(chartFuzzy);
        }
        private void iAddDiscrete_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmAddDiscreteFuzzySet frm = new FrmAddDiscreteFuzzySet();
            frm.ShowDialog();
        }
        private void iAddContinuous_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmAddContinuousFuzzySet frm = new FrmAddContinuousFuzzySet();
            frm.ShowDialog();
        }
        #endregion     

       

        

        

        
    }
}