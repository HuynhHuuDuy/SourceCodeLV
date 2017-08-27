namespace FPRDB.GUI
{
    partial class FrmLibraryCons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibraryCons));
            this.panelControlLibraryConsButton = new DevExpress.XtraEditors.PanelControl();
            this.btCharCons = new DevExpress.XtraEditors.SimpleButton();
            this.btCloseCons = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlConsLibrary = new DevExpress.XtraEditors.GroupControl();
            this.gridCtrLibraryCons = new DevExpress.XtraGrid.GridControl();
            this.gridViewLibraryCons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditLibraryDis = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColBtLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTopLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTopRight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColBtRight = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLibraryConsButton)).BeginInit();
            this.panelControlLibraryConsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlConsLibrary)).BeginInit();
            this.groupControlConsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrLibraryCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLibraryCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditLibraryDis)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlLibraryConsButton
            // 
            this.panelControlLibraryConsButton.Controls.Add(this.btCharCons);
            this.panelControlLibraryConsButton.Controls.Add(this.btCloseCons);
            this.panelControlLibraryConsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlLibraryConsButton.Location = new System.Drawing.Point(0, 368);
            this.panelControlLibraryConsButton.Name = "panelControlLibraryConsButton";
            this.panelControlLibraryConsButton.Size = new System.Drawing.Size(769, 49);
            this.panelControlLibraryConsButton.TabIndex = 0;
            // 
            // btCharCons
            // 
            this.btCharCons.AutoSize = true;
            this.btCharCons.Image = ((System.Drawing.Image)(resources.GetObject("btCharCons.Image")));
            this.btCharCons.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btCharCons.Location = new System.Drawing.Point(12, 6);
            this.btCharCons.Name = "btCharCons";
            this.btCharCons.Size = new System.Drawing.Size(42, 38);
            this.btCharCons.TabIndex = 1;
            this.btCharCons.ToolTip = "Xem biểu đồ";
            this.btCharCons.Click += new System.EventHandler(this.btCharCons_Click);
            // 
            // btCloseCons
            // 
            this.btCloseCons.Location = new System.Drawing.Point(682, 13);
            this.btCloseCons.Name = "btCloseCons";
            this.btCloseCons.Size = new System.Drawing.Size(75, 23);
            this.btCloseCons.TabIndex = 0;
            this.btCloseCons.Text = "&Close";
            this.btCloseCons.Click += new System.EventHandler(this.btCloseCons_Click);
            // 
            // groupControlConsLibrary
            // 
            this.groupControlConsLibrary.Controls.Add(this.gridCtrLibraryCons);
            this.groupControlConsLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlConsLibrary.Location = new System.Drawing.Point(0, 0);
            this.groupControlConsLibrary.Name = "groupControlConsLibrary";
            this.groupControlConsLibrary.Size = new System.Drawing.Size(769, 368);
            this.groupControlConsLibrary.TabIndex = 6;
            this.groupControlConsLibrary.Text = "Continuous Fuzzy Set Library";
            // 
            // gridCtrLibraryCons
            // 
            this.gridCtrLibraryCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrLibraryCons.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridCtrLibraryCons.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridCtrLibraryCons.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridCtrLibraryCons.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridCtrLibraryCons.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridCtrLibraryCons_EmbeddedNavigator_ButtonClick);
            this.gridCtrLibraryCons.Location = new System.Drawing.Point(2, 20);
            this.gridCtrLibraryCons.MainView = this.gridViewLibraryCons;
            this.gridCtrLibraryCons.Name = "gridCtrLibraryCons";
            this.gridCtrLibraryCons.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditLibraryDis});
            this.gridCtrLibraryCons.Size = new System.Drawing.Size(765, 346);
            this.gridCtrLibraryCons.TabIndex = 1;
            this.gridCtrLibraryCons.UseEmbeddedNavigator = true;
            this.gridCtrLibraryCons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLibraryCons});
            // 
            // gridViewLibraryCons
            // 
            this.gridViewLibraryCons.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColCheck,
            this.gridColName,
            this.gridColBtLeft,
            this.gridColTopLeft,
            this.gridColTopRight,
            this.gridColBtRight});
            this.gridViewLibraryCons.GridControl = this.gridCtrLibraryCons;
            this.gridViewLibraryCons.Name = "gridViewLibraryCons";
            this.gridViewLibraryCons.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewLibraryCons.OptionsView.ShowGroupPanel = false;
            this.gridViewLibraryCons.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewLibraryCons_RowCellClick);
            // 
            // gridColCheck
            // 
            this.gridColCheck.Caption = "Select";
            this.gridColCheck.ColumnEdit = this.repositoryItemCheckEditLibraryDis;
            this.gridColCheck.FieldName = "gridColCheck";
            this.gridColCheck.Name = "gridColCheck";
            this.gridColCheck.Visible = true;
            this.gridColCheck.VisibleIndex = 0;
            this.gridColCheck.Width = 87;
            // 
            // repositoryItemCheckEditLibraryDis
            // 
            this.repositoryItemCheckEditLibraryDis.AutoHeight = false;
            this.repositoryItemCheckEditLibraryDis.Name = "repositoryItemCheckEditLibraryDis";
            // 
            // gridColName
            // 
            this.gridColName.Caption = "Name";
            this.gridColName.FieldName = "gridColName";
            this.gridColName.Name = "gridColName";
            this.gridColName.OptionsColumn.AllowEdit = false;
            this.gridColName.OptionsColumn.ReadOnly = true;
            this.gridColName.Visible = true;
            this.gridColName.VisibleIndex = 1;
            this.gridColName.Width = 115;
            // 
            // gridColBtLeft
            // 
            this.gridColBtLeft.Caption = "Bottom-Left";
            this.gridColBtLeft.FieldName = "gridColBtLeft";
            this.gridColBtLeft.Name = "gridColBtLeft";
            this.gridColBtLeft.OptionsColumn.AllowEdit = false;
            this.gridColBtLeft.OptionsColumn.ReadOnly = true;
            this.gridColBtLeft.Visible = true;
            this.gridColBtLeft.VisibleIndex = 2;
            this.gridColBtLeft.Width = 136;
            // 
            // gridColTopLeft
            // 
            this.gridColTopLeft.Caption = "Top-Left";
            this.gridColTopLeft.FieldName = "gridColTopLeft";
            this.gridColTopLeft.Name = "gridColTopLeft";
            this.gridColTopLeft.OptionsColumn.AllowEdit = false;
            this.gridColTopLeft.OptionsColumn.ReadOnly = true;
            this.gridColTopLeft.Visible = true;
            this.gridColTopLeft.VisibleIndex = 3;
            this.gridColTopLeft.Width = 125;
            // 
            // gridColTopRight
            // 
            this.gridColTopRight.Caption = "Top-Right";
            this.gridColTopRight.FieldName = "gridColTopRight";
            this.gridColTopRight.Name = "gridColTopRight";
            this.gridColTopRight.OptionsColumn.AllowEdit = false;
            this.gridColTopRight.OptionsColumn.ReadOnly = true;
            this.gridColTopRight.Visible = true;
            this.gridColTopRight.VisibleIndex = 4;
            this.gridColTopRight.Width = 135;
            // 
            // gridColBtRight
            // 
            this.gridColBtRight.Caption = "Bottom-Right";
            this.gridColBtRight.FieldName = "gridColBtRight";
            this.gridColBtRight.Name = "gridColBtRight";
            this.gridColBtRight.OptionsColumn.AllowEdit = false;
            this.gridColBtRight.OptionsColumn.ReadOnly = true;
            this.gridColBtRight.Visible = true;
            this.gridColBtRight.VisibleIndex = 5;
            this.gridColBtRight.Width = 151;
            // 
            // FrmLibraryCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 417);
            this.Controls.Add(this.groupControlConsLibrary);
            this.Controls.Add(this.panelControlLibraryConsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLibraryCons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Continuous Fuzzy Set Library";
            this.Load += new System.EventHandler(this.FrmLibraryCons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLibraryConsButton)).EndInit();
            this.panelControlLibraryConsButton.ResumeLayout(false);
            this.panelControlLibraryConsButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlConsLibrary)).EndInit();
            this.groupControlConsLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrLibraryCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLibraryCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditLibraryDis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlLibraryConsButton;
        private DevExpress.XtraEditors.GroupControl groupControlConsLibrary;
        private DevExpress.XtraGrid.GridControl gridCtrLibraryCons;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLibraryCons;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditLibraryDis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColBtLeft;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTopLeft;
        private DevExpress.XtraEditors.SimpleButton btCharCons;
        private DevExpress.XtraEditors.SimpleButton btCloseCons;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTopRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColBtRight;
    }
}