namespace FPRDB.GUI
{
    partial class FrmInputType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInputType));
            this.panelControlInputType = new DevExpress.XtraEditors.PanelControl();
            this.btCancelSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btOkSelect = new DevExpress.XtraEditors.SimpleButton();
            this.memoEditListValue = new DevExpress.XtraEditors.MemoEdit();
            this.txtTypeName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBox_DataType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblListValueType = new DevExpress.XtraEditors.LabelControl();
            this.lblTypeName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelFrmInputType = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvidertxtList = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlInputType)).BeginInit();
            this.panelControlInputType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditListValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_DataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvidertxtList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlInputType
            // 
            this.panelControlInputType.Controls.Add(this.btCancelSelect);
            this.panelControlInputType.Controls.Add(this.btOkSelect);
            this.panelControlInputType.Controls.Add(this.memoEditListValue);
            this.panelControlInputType.Controls.Add(this.txtTypeName);
            this.panelControlInputType.Controls.Add(this.ComboBox_DataType);
            this.panelControlInputType.Controls.Add(this.lblListValueType);
            this.panelControlInputType.Controls.Add(this.lblTypeName);
            this.panelControlInputType.Controls.Add(this.labelControl1);
            this.panelControlInputType.Controls.Add(this.labelFrmInputType);
            this.panelControlInputType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlInputType.Location = new System.Drawing.Point(0, 0);
            this.panelControlInputType.Name = "panelControlInputType";
            this.panelControlInputType.Size = new System.Drawing.Size(423, 371);
            this.panelControlInputType.TabIndex = 0;
            // 
            // btCancelSelect
            // 
            this.btCancelSelect.Location = new System.Drawing.Point(318, 322);
            this.btCancelSelect.Name = "btCancelSelect";
            this.btCancelSelect.Size = new System.Drawing.Size(75, 23);
            this.btCancelSelect.TabIndex = 5;
            this.btCancelSelect.Text = "&Cancel";
            this.btCancelSelect.Click += new System.EventHandler(this.btCancelSelect_Click);
            // 
            // btOkSelect
            // 
            this.btOkSelect.Location = new System.Drawing.Point(216, 322);
            this.btOkSelect.Name = "btOkSelect";
            this.btOkSelect.Size = new System.Drawing.Size(75, 23);
            this.btOkSelect.TabIndex = 4;
            this.btOkSelect.Text = "&OK";
            this.btOkSelect.Click += new System.EventHandler(this.btOkSelect_Click);
            // 
            // memoEditListValue
            // 
            this.memoEditListValue.Location = new System.Drawing.Point(30, 208);
            this.memoEditListValue.Name = "memoEditListValue";
            this.memoEditListValue.Properties.ReadOnly = true;
            this.memoEditListValue.Size = new System.Drawing.Size(363, 94);
            this.memoEditListValue.TabIndex = 3;
            this.memoEditListValue.TextChanged += new System.EventHandler(this.memoEditListValue_TextChanged);
            this.memoEditListValue.Leave += new System.EventHandler(this.memoEditListValue_Leave);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(111, 123);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Properties.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(282, 20);
            this.txtTypeName.TabIndex = 2;
            // 
            // ComboBox_DataType
            // 
            this.ComboBox_DataType.Location = new System.Drawing.Point(111, 70);
            this.ComboBox_DataType.Name = "ComboBox_DataType";
            this.ComboBox_DataType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBox_DataType.Properties.Items.AddRange(new object[] {
            "Int16",
            "Int32",
            "Int64",
            "Byte",
            "String",
            "Single",
            "DiscreteFuzzySet",
            "ContinuousFuzzySet",
            "Double",
            "Boolean",
            "Decimal",
            "DateTime",
            "Binary",
            "Currency",
            "UserDefined"});
            this.ComboBox_DataType.Size = new System.Drawing.Size(282, 20);
            this.ComboBox_DataType.TabIndex = 1;
            this.ComboBox_DataType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_DataType_SelectedIndexChanged);
            // 
            // lblListValueType
            // 
            this.lblListValueType.Location = new System.Drawing.Point(30, 180);
            this.lblListValueType.Name = "lblListValueType";
            this.lblListValueType.Size = new System.Drawing.Size(87, 13);
            this.lblListValueType.TabIndex = 0;
            this.lblListValueType.Text = "List of value type:";
            // 
            // lblTypeName
            // 
            this.lblTypeName.Location = new System.Drawing.Point(30, 130);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(58, 13);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "Type Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data Type:";
            // 
            // labelFrmInputType
            // 
            this.labelFrmInputType.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelFrmInputType.Location = new System.Drawing.Point(111, 12);
            this.labelFrmInputType.Name = "labelFrmInputType";
            this.labelFrmInputType.Size = new System.Drawing.Size(199, 33);
            this.labelFrmInputType.TabIndex = 0;
            this.labelFrmInputType.Text = "Select Data Type";
            // 
            // dxErrorProvidertxtList
            // 
            this.dxErrorProvidertxtList.ContainerControl = this;
            // 
            // FrmInputType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 371);
            this.Controls.Add(this.panelControlInputType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 410);
            this.Name = "FrmInputType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select data type";
            this.Load += new System.EventHandler(this.FrmInputType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlInputType)).EndInit();
            this.panelControlInputType.ResumeLayout(false);
            this.panelControlInputType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditListValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBox_DataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvidertxtList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlInputType;
        private DevExpress.XtraEditors.LabelControl labelFrmInputType;
        private DevExpress.XtraEditors.LabelControl lblListValueType;
        private DevExpress.XtraEditors.LabelControl lblTypeName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btCancelSelect;
        private DevExpress.XtraEditors.SimpleButton btOkSelect;
        private DevExpress.XtraEditors.MemoEdit memoEditListValue;
        private DevExpress.XtraEditors.TextEdit txtTypeName;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBox_DataType;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvidertxtList;


    }
}