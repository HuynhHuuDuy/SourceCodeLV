namespace FPRDB.GUI
{
    partial class FrmListValueFuzzy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListValueFuzzy));
            this.panelControlButtonFuzzyValue = new DevExpress.XtraEditors.PanelControl();
            this.btCancelFuzzyValue = new DevExpress.XtraEditors.SimpleButton();
            this.btOkFuzzyValue = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlFuzzyValue = new DevExpress.XtraEditors.PanelControl();
            this.gridCtlFuzzyValue = new DevExpress.XtraGrid.GridControl();
            this.gridViewFuzzyValue = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonFuzzyValue)).BeginInit();
            this.panelControlButtonFuzzyValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFuzzyValue)).BeginInit();
            this.panelControlFuzzyValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlFuzzyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuzzyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlButtonFuzzyValue
            // 
            this.panelControlButtonFuzzyValue.Controls.Add(this.btCancelFuzzyValue);
            this.panelControlButtonFuzzyValue.Controls.Add(this.btOkFuzzyValue);
            this.panelControlButtonFuzzyValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButtonFuzzyValue.Location = new System.Drawing.Point(0, 235);
            this.panelControlButtonFuzzyValue.Name = "panelControlButtonFuzzyValue";
            this.panelControlButtonFuzzyValue.Size = new System.Drawing.Size(367, 47);
            this.panelControlButtonFuzzyValue.TabIndex = 1;
            // 
            // btCancelFuzzyValue
            // 
            this.btCancelFuzzyValue.Location = new System.Drawing.Point(280, 11);
            this.btCancelFuzzyValue.Name = "btCancelFuzzyValue";
            this.btCancelFuzzyValue.Size = new System.Drawing.Size(75, 23);
            this.btCancelFuzzyValue.TabIndex = 1;
            this.btCancelFuzzyValue.Text = "&Cancel";
            this.btCancelFuzzyValue.Click += new System.EventHandler(this.btCancelFuzzyValue_Click);
            // 
            // btOkFuzzyValue
            // 
            this.btOkFuzzyValue.Location = new System.Drawing.Point(188, 11);
            this.btOkFuzzyValue.Name = "btOkFuzzyValue";
            this.btOkFuzzyValue.Size = new System.Drawing.Size(75, 23);
            this.btOkFuzzyValue.TabIndex = 0;
            this.btOkFuzzyValue.Text = "&OK";
            this.btOkFuzzyValue.Click += new System.EventHandler(this.btOkFuzzyValue_Click);
            // 
            // panelControlFuzzyValue
            // 
            this.panelControlFuzzyValue.Controls.Add(this.gridCtlFuzzyValue);
            this.panelControlFuzzyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlFuzzyValue.Location = new System.Drawing.Point(0, 0);
            this.panelControlFuzzyValue.Name = "panelControlFuzzyValue";
            this.panelControlFuzzyValue.Size = new System.Drawing.Size(367, 235);
            this.panelControlFuzzyValue.TabIndex = 3;
            // 
            // gridCtlFuzzyValue
            // 
            this.gridCtlFuzzyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtlFuzzyValue.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridCtlFuzzyValue.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridCtlFuzzyValue.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridCtlFuzzyValue.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridCtlFuzzyValue.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridCtlFuzzyValue_EmbeddedNavigator_ButtonClick);
            this.gridCtlFuzzyValue.Location = new System.Drawing.Point(2, 2);
            this.gridCtlFuzzyValue.MainView = this.gridViewFuzzyValue;
            this.gridCtlFuzzyValue.Name = "gridCtlFuzzyValue";
            this.gridCtlFuzzyValue.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridCtlFuzzyValue.Size = new System.Drawing.Size(363, 231);
            this.gridCtlFuzzyValue.TabIndex = 1;
            this.gridCtlFuzzyValue.UseEmbeddedNavigator = true;
            this.gridCtlFuzzyValue.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFuzzyValue});
            // 
            // gridViewFuzzyValue
            // 
            this.gridViewFuzzyValue.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColValue});
            this.gridViewFuzzyValue.GridControl = this.gridCtlFuzzyValue;
            this.gridViewFuzzyValue.Name = "gridViewFuzzyValue";
            this.gridViewFuzzyValue.OptionsBehavior.ReadOnly = true;
            this.gridViewFuzzyValue.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewFuzzyValue.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewFuzzyValue.OptionsSelection.MultiSelect = true;
            this.gridViewFuzzyValue.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewFuzzyValue.OptionsView.ShowColumnHeaders = false;
            this.gridViewFuzzyValue.OptionsView.ShowGroupPanel = false;
            // 
            // gridColValue
            // 
            this.gridColValue.FieldName = "gridColValue";
            this.gridColValue.Name = "gridColValue";
            this.gridColValue.OptionsColumn.AllowEdit = false;
            this.gridColValue.OptionsColumn.ReadOnly = true;
            this.gridColValue.Visible = true;
            this.gridColValue.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FrmListValueFuzzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 282);
            this.Controls.Add(this.panelControlFuzzyValue);
            this.Controls.Add(this.panelControlButtonFuzzyValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListValueFuzzy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fuzzy Value";
            this.Load += new System.EventHandler(this.FrmListValueFuzzy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlButtonFuzzyValue)).EndInit();
            this.panelControlButtonFuzzyValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFuzzyValue)).EndInit();
            this.panelControlFuzzyValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtlFuzzyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuzzyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlButtonFuzzyValue;
        private DevExpress.XtraEditors.SimpleButton btCancelFuzzyValue;
        private DevExpress.XtraEditors.SimpleButton btOkFuzzyValue;
        private DevExpress.XtraEditors.PanelControl panelControlFuzzyValue;
        private DevExpress.XtraGrid.GridControl gridCtlFuzzyValue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFuzzyValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}