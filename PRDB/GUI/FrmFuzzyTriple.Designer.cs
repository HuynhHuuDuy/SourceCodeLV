namespace FPRDB.GUI
{
    partial class FrmFuzzyTriple
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuzzyTriple));
            this.panelControlButtonFuzzyTrip = new DevExpress.XtraEditors.PanelControl();
            this.btCancelFuzzyProb = new DevExpress.XtraEditors.SimpleButton();
            this.btOKFuzzyProb = new DevExpress.XtraEditors.SimpleButton();
            this.panelCtrlListFuzzyTriple = new DevExpress.XtraEditors.PanelControl();
            this.gridControlFuzzyTriple = new DevExpress.XtraGrid.GridControl();
            this.gridViewFuzzyTriple = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColMinProb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColMaxProb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonFuzzyTrip)).BeginInit();
            this.panelControlButtonFuzzyTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlListFuzzyTriple)).BeginInit();
            this.panelCtrlListFuzzyTriple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuzzyTriple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuzzyTriple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlButtonFuzzyTrip
            // 
            this.panelControlButtonFuzzyTrip.Controls.Add(this.btCancelFuzzyProb);
            this.panelControlButtonFuzzyTrip.Controls.Add(this.btOKFuzzyProb);
            this.panelControlButtonFuzzyTrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButtonFuzzyTrip.Location = new System.Drawing.Point(0, 301);
            this.panelControlButtonFuzzyTrip.Name = "panelControlButtonFuzzyTrip";
            this.panelControlButtonFuzzyTrip.Size = new System.Drawing.Size(649, 52);
            this.panelControlButtonFuzzyTrip.TabIndex = 3;
            // 
            // btCancelFuzzyProb
            // 
            this.btCancelFuzzyProb.Location = new System.Drawing.Point(551, 13);
            this.btCancelFuzzyProb.Name = "btCancelFuzzyProb";
            this.btCancelFuzzyProb.Size = new System.Drawing.Size(75, 23);
            this.btCancelFuzzyProb.TabIndex = 1;
            this.btCancelFuzzyProb.Text = "&Cancel";
            this.btCancelFuzzyProb.Click += new System.EventHandler(this.btCancelFuzzyProb_Click);
            // 
            // btOKFuzzyProb
            // 
            this.btOKFuzzyProb.Location = new System.Drawing.Point(446, 13);
            this.btOKFuzzyProb.Name = "btOKFuzzyProb";
            this.btOKFuzzyProb.Size = new System.Drawing.Size(75, 23);
            this.btOKFuzzyProb.TabIndex = 0;
            this.btOKFuzzyProb.Text = "&OK";
            this.btOKFuzzyProb.Click += new System.EventHandler(this.btOKFuzzyProb_Click);
            // 
            // panelCtrlListFuzzyTriple
            // 
            this.panelCtrlListFuzzyTriple.Controls.Add(this.gridControlFuzzyTriple);
            this.panelCtrlListFuzzyTriple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrlListFuzzyTriple.Location = new System.Drawing.Point(0, 0);
            this.panelCtrlListFuzzyTriple.Name = "panelCtrlListFuzzyTriple";
            this.panelCtrlListFuzzyTriple.Size = new System.Drawing.Size(649, 301);
            this.panelCtrlListFuzzyTriple.TabIndex = 4;
            // 
            // gridControlFuzzyTriple
            // 
            this.gridControlFuzzyTriple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFuzzyTriple.EmbeddedNavigator.Buttons.Edit.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlFuzzyTriple.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlFuzzyTriple.Location = new System.Drawing.Point(2, 2);
            this.gridControlFuzzyTriple.MainView = this.gridViewFuzzyTriple;
            this.gridControlFuzzyTriple.Name = "gridControlFuzzyTriple";
            this.gridControlFuzzyTriple.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.gridControlFuzzyTriple.Size = new System.Drawing.Size(645, 297);
            this.gridControlFuzzyTriple.TabIndex = 1;
            this.gridControlFuzzyTriple.UseEmbeddedNavigator = true;
            this.gridControlFuzzyTriple.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFuzzyTriple});
            // 
            // gridViewFuzzyTriple
            // 
            this.gridViewFuzzyTriple.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColValue,
            this.gridColMinProb,
            this.gridColMaxProb});
            this.gridViewFuzzyTriple.GridControl = this.gridControlFuzzyTriple;
            this.gridViewFuzzyTriple.Name = "gridViewFuzzyTriple";
            this.gridViewFuzzyTriple.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewFuzzyTriple.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewFuzzyTriple.OptionsView.ShowFooter = true;
            this.gridViewFuzzyTriple.OptionsView.ShowGroupPanel = false;
            this.gridViewFuzzyTriple.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewFuzzyTriple_RowCellClick);
            this.gridViewFuzzyTriple.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewFuzzyTriple_InvalidRowException);
            this.gridViewFuzzyTriple.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewFuzzyTriple_ValidateRow);
            // 
            // gridColValue
            // 
            this.gridColValue.Caption = "Value";
            this.gridColValue.FieldName = "gridColValue";
            this.gridColValue.Name = "gridColValue";
            this.gridColValue.Visible = true;
            this.gridColValue.VisibleIndex = 0;
            // 
            // gridColMinProb
            // 
            this.gridColMinProb.Caption = "MinProb";
            this.gridColMinProb.ColumnEdit = this.repositoryItemTextEdit2;
            this.gridColMinProb.FieldName = "gridColMinProb";
            this.gridColMinProb.Name = "gridColMinProb";
            this.gridColMinProb.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColMinProb", "Sum MinProb={0:0.##}")});
            this.gridColMinProb.Visible = true;
            this.gridColMinProb.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.BeepOnError = true;
            this.repositoryItemTextEdit2.Mask.EditMask = "(0(\\R.)(\\d+)?)|(1(\\R.)0)";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit2.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gridColMaxProb
            // 
            this.gridColMaxProb.Caption = "MaxProb";
            this.gridColMaxProb.ColumnEdit = this.repositoryItemTextEdit3;
            this.gridColMaxProb.FieldName = "gridColMaxProb";
            this.gridColMaxProb.Name = "gridColMaxProb";
            this.gridColMaxProb.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColMaxProb", "Sum MaxProb={0:0.##}")});
            this.gridColMaxProb.Visible = true;
            this.gridColMaxProb.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Mask.BeepOnError = true;
            this.repositoryItemTextEdit3.Mask.EditMask = "(0(\\R.)(\\d+)?)|(1(\\R.)0)";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit3.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // FrmFuzzyTriple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 353);
            this.Controls.Add(this.panelCtrlListFuzzyTriple);
            this.Controls.Add(this.panelControlButtonFuzzyTrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmFuzzyTriple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fuzzy Probabilistic Triple";
            this.Load += new System.EventHandler(this.FrmFuzzyTriple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonFuzzyTrip)).EndInit();
            this.panelControlButtonFuzzyTrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlListFuzzyTriple)).EndInit();
            this.panelCtrlListFuzzyTriple.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuzzyTriple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuzzyTriple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlButtonFuzzyTrip;
        private DevExpress.XtraEditors.PanelControl panelCtrlListFuzzyTriple;
        private DevExpress.XtraGrid.GridControl gridControlFuzzyTriple;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFuzzyTriple;
        private DevExpress.XtraGrid.Columns.GridColumn gridColValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMinProb;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMaxProb;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btCancelFuzzyProb;
        private DevExpress.XtraEditors.SimpleButton btOKFuzzyProb;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
    }
}