namespace FPRDB.GUI
{
    partial class FrmLibraryDis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibraryDis));
            this.panelControlLibraryDisButton = new DevExpress.XtraEditors.PanelControl();
            this.btChartDis = new DevExpress.XtraEditors.SimpleButton();
            this.btCloseDis = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlDisLibrary = new DevExpress.XtraEditors.GroupControl();
            this.gridCtrLibraryDis = new DevExpress.XtraGrid.GridControl();
            this.gridViewLibraryDis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditLibraryDis = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColMembership = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLibraryDisButton)).BeginInit();
            this.panelControlLibraryDisButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDisLibrary)).BeginInit();
            this.groupControlDisLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrLibraryDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLibraryDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditLibraryDis)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlLibraryDisButton
            // 
            this.panelControlLibraryDisButton.Controls.Add(this.btChartDis);
            this.panelControlLibraryDisButton.Controls.Add(this.btCloseDis);
            this.panelControlLibraryDisButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlLibraryDisButton.Location = new System.Drawing.Point(0, 368);
            this.panelControlLibraryDisButton.Name = "panelControlLibraryDisButton";
            this.panelControlLibraryDisButton.Size = new System.Drawing.Size(769, 49);
            this.panelControlLibraryDisButton.TabIndex = 0;
            // 
            // btChartDis
            // 
            this.btChartDis.AutoSize = true;
            this.btChartDis.Image = ((System.Drawing.Image)(resources.GetObject("btChartDis.Image")));
            this.btChartDis.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btChartDis.Location = new System.Drawing.Point(12, 6);
            this.btChartDis.Name = "btChartDis";
            this.btChartDis.Size = new System.Drawing.Size(42, 38);
            this.btChartDis.TabIndex = 1;
            this.btChartDis.ToolTip = "Xem biểu đồ";
            this.btChartDis.Click += new System.EventHandler(this.btChartDis_Click);
            // 
            // btCloseDis
            // 
            this.btCloseDis.Location = new System.Drawing.Point(682, 13);
            this.btCloseDis.Name = "btCloseDis";
            this.btCloseDis.Size = new System.Drawing.Size(75, 23);
            this.btCloseDis.TabIndex = 0;
            this.btCloseDis.Text = "&Close";
            this.btCloseDis.Click += new System.EventHandler(this.btCloseDis_Click);
            // 
            // groupControlDisLibrary
            // 
            this.groupControlDisLibrary.Controls.Add(this.gridCtrLibraryDis);
            this.groupControlDisLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDisLibrary.Location = new System.Drawing.Point(0, 0);
            this.groupControlDisLibrary.Name = "groupControlDisLibrary";
            this.groupControlDisLibrary.Size = new System.Drawing.Size(769, 368);
            this.groupControlDisLibrary.TabIndex = 6;
            this.groupControlDisLibrary.Text = "Discrete Fuzzy Set Library";
            // 
            // gridCtrLibraryDis
            // 
            this.gridCtrLibraryDis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrLibraryDis.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridCtrLibraryDis.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridCtrLibraryDis.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridCtrLibraryDis.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridCtrLibraryDis.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridCtrLibraryDis_EmbeddedNavigator_ButtonClick);
            this.gridCtrLibraryDis.Location = new System.Drawing.Point(2, 20);
            this.gridCtrLibraryDis.MainView = this.gridViewLibraryDis;
            this.gridCtrLibraryDis.Name = "gridCtrLibraryDis";
            this.gridCtrLibraryDis.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditLibraryDis});
            this.gridCtrLibraryDis.Size = new System.Drawing.Size(765, 346);
            this.gridCtrLibraryDis.TabIndex = 1;
            this.gridCtrLibraryDis.UseEmbeddedNavigator = true;
            this.gridCtrLibraryDis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLibraryDis});
            // 
            // gridViewLibraryDis
            // 
            this.gridViewLibraryDis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColCheck,
            this.gridColName,
            this.gridColValue,
            this.gridColMembership});
            this.gridViewLibraryDis.GridControl = this.gridCtrLibraryDis;
            this.gridViewLibraryDis.Name = "gridViewLibraryDis";
            this.gridViewLibraryDis.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewLibraryDis.OptionsView.ShowGroupedColumns = true;
            this.gridViewLibraryDis.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewLibraryDis.OptionsView.ShowGroupPanel = false;
            this.gridViewLibraryDis.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewLibraryDis_RowCellClick);
            // 
            // gridColCheck
            // 
            this.gridColCheck.Caption = "Select";
            this.gridColCheck.ColumnEdit = this.repositoryItemCheckEditLibraryDis;
            this.gridColCheck.FieldName = "gridColCheck";
            this.gridColCheck.Name = "gridColCheck";
            this.gridColCheck.Visible = true;
            this.gridColCheck.VisibleIndex = 0;
            this.gridColCheck.Width = 105;
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
            this.gridColName.Width = 213;
            // 
            // gridColValue
            // 
            this.gridColValue.Caption = "Value";
            this.gridColValue.FieldName = "gridColValue";
            this.gridColValue.Name = "gridColValue";
            this.gridColValue.OptionsColumn.AllowEdit = false;
            this.gridColValue.OptionsColumn.ReadOnly = true;
            this.gridColValue.Visible = true;
            this.gridColValue.VisibleIndex = 2;
            this.gridColValue.Width = 213;
            // 
            // gridColMembership
            // 
            this.gridColMembership.Caption = "Membership";
            this.gridColMembership.FieldName = "gridColMembership";
            this.gridColMembership.Name = "gridColMembership";
            this.gridColMembership.OptionsColumn.AllowEdit = false;
            this.gridColMembership.OptionsColumn.ReadOnly = true;
            this.gridColMembership.Visible = true;
            this.gridColMembership.VisibleIndex = 3;
            this.gridColMembership.Width = 218;
            // 
            // FrmLibraryDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 417);
            this.Controls.Add(this.groupControlDisLibrary);
            this.Controls.Add(this.panelControlLibraryDisButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLibraryDis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Discrete Fuzzy Set Library";
            this.Load += new System.EventHandler(this.FrmLibraryDis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLibraryDisButton)).EndInit();
            this.panelControlLibraryDisButton.ResumeLayout(false);
            this.panelControlLibraryDisButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDisLibrary)).EndInit();
            this.groupControlDisLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrLibraryDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLibraryDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditLibraryDis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlLibraryDisButton;
        private DevExpress.XtraEditors.GroupControl groupControlDisLibrary;
        private DevExpress.XtraGrid.GridControl gridCtrLibraryDis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLibraryDis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditLibraryDis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMembership;
        private DevExpress.XtraEditors.SimpleButton btChartDis;
        private DevExpress.XtraEditors.SimpleButton btCloseDis;
    }
}