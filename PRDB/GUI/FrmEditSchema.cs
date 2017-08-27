using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FPRDB.BLL;

namespace FPRDB.GUI
{
    public partial class FrmEditSchema : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;
        public string currentSchemeName;
        public FProbSchemaBLL currentScheme;
        public string scheme = string.Empty;
        private DataTable dt = new DataTable();
        public FrmEditSchema()
        {
            InitializeComponent();
        }

        public FrmEditSchema(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }
        public FrmEditSchema(FProbDatabaseBLL probDatabase, string scheme)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
            this.scheme = scheme;
        }

        private void FrmEditSchema_Load(object sender, EventArgs e)
        {
            comboBoxListSchema.Properties.Items.Clear();
            comboBoxListSchema.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxListSchema.Properties.Items.AddRange(this.probDatabase.ListOfSchemeNameToLower());
            comboBoxListSchema.SelectedIndex = scheme == string.Empty ? 0 : comboBoxListSchema.Properties.Items.IndexOf(scheme);
        }
        private void ResetGridView(List<FProbAttributeBLL>list)
        {
            gridControlEditSchema.DataSource = null;
            dt = new DataTable();
            dt.Columns.Add("gridColPrimaryKey", typeof(Boolean));
            dt.Columns.Add("gridColAttributeName", typeof(String));
            dt.Columns.Add("gridColDataType", typeof(String));
            dt.Columns.Add("gridColDomain", typeof(String));
            dt.Columns.Add("gridColDescription", typeof(String));
            if (list.Count > 0)
            {
                foreach (FProbAttributeBLL attr in list)
                {
                    DataRow row = dt.NewRow();
                    row[0] = attr.PrimaryKey;
                    row[1] = attr.AttributeName;
                    row[2] = attr.FproDataType.TypeName;
                    row[3] = attr.FproDataType.DomainString;
                    row[4] = attr.Description;
                    dt.Rows.Add(row);
                }
            }
            gridControlEditSchema.DataSource = dt;
        }
        private void comboBoxListSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridViewEditSchema.CloseEditor();
            currentSchemeName = comboBoxListSchema.Properties.Items[comboBoxListSchema.SelectedIndex].ToString();
            txtSchemeName.Text = currentSchemeName;
            currentScheme = this.probDatabase.FproSchemas.SingleOrDefault(c => c.SchemaName.ToLower() == currentSchemeName);
            // check inherited
            if (new FProbSchemaBLL(currentSchemeName).isInherited(this.probDatabase.FproRelations) == true)
            {
                lblInfomation.Visible = true;
                lblCurrentName.Enabled = false;
                btSaveEditSchema.Enabled = false;
                txtSchemeName.Enabled = false;
                gridControlEditSchema.Enabled = false;
                gridViewEditSchema.OptionsBehavior.ReadOnly = true;
            }
            else
            {
                
                lblInfomation.Visible = false;
                lblCurrentName.Enabled = true;            
                btSaveEditSchema.Enabled = true;
                txtSchemeName.Enabled = true;
                gridControlEditSchema.Enabled = true;
                gridViewEditSchema.OptionsBehavior.ReadOnly = false;
            }
            ResetGridView(currentScheme.FproAttributes);
        }

        private void btSaveEditSchema_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSchemeName, null);
            if (txtSchemeName.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(txtSchemeName, "You must enter a schema name, please try again!");
                return;
            }
            errorProvider.SetError(txtSchemeName, null);

            if (txtSchemeName.Text.ToLower() == "select" || txtSchemeName.Text.ToLower() == "from" || txtSchemeName.Text.ToLower() == "where")
            {
                errorProvider.SetError(txtSchemeName, "Schema name is not valid (not match with keyword 'select', 'from', 'where')  ");
                return;

            }

            if (this.currentSchemeName != txtSchemeName.Text.Trim().ToLower())
            {
                foreach (var item in this.probDatabase.ListOfSchemeNameToLower())
                {
                    if (item.Equals(txtSchemeName.Text.ToLower()))
                    {
                        errorProvider.SetError(txtSchemeName, "This schema name has already existed in the database, please try again !");
                        return;
                    }
                }
            }

            errorProvider.SetError(txtSchemeName, null);
            if (gridViewEditSchema.DataRowCount < 1)
            {
                XtraMessageBox.Show("Error: Unable to update Schema. Schema attribute is required !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentScheme.SchemaName = txtSchemeName.Text;
            currentScheme.Update();

            foreach (FProbAttributeBLL attr in currentScheme.FproAttributes)
            {
                attr.FproSchema = currentScheme;
                attr.DeleteAllAttributeByIdScheme();
            }

            currentScheme.FproAttributes.Clear();

            currentScheme.FproAttributes = new FrmNewSchema().getAllAttributeFromDataGridView(this.gridViewEditSchema);

            int ID = new FProbAttributeBLL().getMaxIdinTable();

            foreach (FProbAttributeBLL attr in currentScheme.FproAttributes)
            {
                attr.IdAttribute = ID;
                attr.FproSchema = currentScheme;
                attr.Insert();
                ID++;
            }
            XtraMessageBox.Show("Edit successfully");
            this.Close();
        }

        private void gridViewEditSchema_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridViewEditSchema_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            // kiem tra 6 cell cua mot dong dang Edit xem co rong ko?
            if (gridViewEditSchema.GetRowCellValue(e.RowHandle, "gridColAttributeName").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Enter Name Attribute!";
            }
            if (gridViewEditSchema.GetRowCellValue(e.RowHandle, "gridColDataType").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Select DataType!";
            }
            if (!bVali)
            {

                e.Valid = false;
                // coi như valid không qua được. bạn sẽ không làm được gì trừ khi
                //điền thêm thông tin hoặc bấm nút ESC trên bàn phím
                XtraMessageBox.Show(sErr, "Error!!!");
            }
            else
            {
                string name = gridViewEditSchema.GetRowCellValue(e.RowHandle, "gridColAttributeName").ToString().ToLower();
                if (name.Trim() == "select" || name.Trim() == "from" || name.Trim() == "where")
                {
                    e.Valid = false;
                    sErr = sErr + "Attribute name is not valid ( not match with keyword 'select', 'from', 'where')";
                    XtraMessageBox.Show(sErr, "Error!!!");
                }
                else
                {
                    if (e.RowHandle < 0)
                    {
                        for (int i = 0; i <= gridViewEditSchema.DataRowCount - 1; i++)
                        {
                            if (gridViewEditSchema.GetRowCellValue(i, "gridColAttributeName").ToString().ToLower() == name)
                            {
                                e.Valid = false;
                                sErr = sErr + "There is already an attribute with the same name!";
                                XtraMessageBox.Show(sErr, "Error!!!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= gridViewEditSchema.DataRowCount - 1; i++)
                        {
                            if ((i != e.RowHandle) && (gridViewEditSchema.GetRowCellValue(i, "gridColAttributeName").ToString().ToLower() == name))
                            {
                                e.Valid = false;
                                sErr = sErr + "There is already an attribute with the same name!";
                                XtraMessageBox.Show(sErr, "Error!!!");
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void gridControlEditSchema_ProcessGridKey(object sender, KeyEventArgs e)
        {
            // kiểm tra xem có phải người dùng bấm nút xóa trên bàn phím
            // Và trạng thái của Gridcontrol có không phải là đang edit không (tránh
            // tình trạng người dùng đang focus để sửa 1 cell nào trong Grid view )
            if (e.KeyCode == Keys.Delete && gridViewEditSchema.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                if (XtraMessageBox.Show("Are you sure?", "Quest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XtraMessageBox.Show(gridViewEditSchema.GetRowCellValue(gridViewEditSchema.FocusedRowHandle, "gridColPrimaryKey").ToString(), "");
                    XtraMessageBox.Show(gridViewEditSchema.GetRowCellValue(gridViewEditSchema.FocusedRowHandle, "gridColAttributeName").ToString(), "");
                    XtraMessageBox.Show(gridViewEditSchema.GetRowCellValue(gridViewEditSchema.FocusedRowHandle, "gridColDataType").ToString(), "");
                    XtraMessageBox.Show(gridViewEditSchema.GetRowCellValue(gridViewEditSchema.FocusedRowHandle, "gridColDomain").ToString(), "");
                    XtraMessageBox.Show(gridViewEditSchema.GetRowCellValue(gridViewEditSchema.FocusedRowHandle, "gridColDescription").ToString(), "");
                    dt.Rows.RemoveAt(gridViewEditSchema.FocusedRowHandle);
                }
            }
        }
        private void gridViewEditSchema_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "gridColDataType" && e.Button == MouseButtons.Right)
                {
                    FrmInputType frm;
                    if (gridViewEditSchema.GetRowCellValue(e.RowHandle, "gridColDataType") != null)
                    {
                        frm = new FrmInputType(gridViewEditSchema.GetRowCellValue(e.RowHandle, "gridColDataType").ToString(), gridViewEditSchema.GetRowCellValue(e.RowHandle, "gridColDomain").ToString());
                    }
                    else
                    {
                        frm = new FrmInputType();
                    }

                    frm.ShowDialog();
                    if (frm.dataType.DataType != new FProDataTypeBLL().DataType)
                    {
                        if (frm.dataType.TypeName == "")
                        {
                            gridViewEditSchema.SetRowCellValue(e.RowHandle, "gridColDataType", frm.dataType.DataType);
                        }
                        else
                            gridViewEditSchema.SetRowCellValue(e.RowHandle, "gridColDataType", frm.dataType.TypeName);
                        gridViewEditSchema.SetRowCellValue(e.RowHandle, "gridColDomain", frm.dataType.DomainString);
                    }
                }
            }
            catch
            {
            }
        }

        private void biCancelEditSchema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            gridViewEditSchema.CloseEditor();
            gridViewEditSchema.CancelUpdateCurrentRow();
        }
    }
}