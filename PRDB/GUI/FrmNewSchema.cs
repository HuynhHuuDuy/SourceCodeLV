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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace FPRDB.GUI
{
    public partial class FrmNewSchema : DevExpress.XtraEditors.XtraForm
    {
        internal FProbDatabaseBLL probDatabase;
        internal FProbSchemaBLL ProbScheme = new FProbSchemaBLL();
        public List<FProbSchemaBLL> listProbScheme = new List<FProbSchemaBLL>();
        private DataTable dt = new DataTable();
        public FrmNewSchema()
        {
            InitializeComponent();
        }

        public FrmNewSchema(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }
        public List<FProbAttributeBLL> getAllAttributeFromDataGridView(DevExpress.XtraGrid.Views.Grid.GridView gridViewNewSchema)
        {
            List<FProbAttributeBLL> probAttributes = new List<FProbAttributeBLL>();

            int nRow = gridViewNewSchema.DataRowCount - 1;

            for (int i = 0; i <= nRow; i++)
            {
                FProbAttributeBLL attribute = new FProbAttributeBLL();
                if (gridViewNewSchema.GetRowCellValue(i, "gridColPrimaryKey").ToString()=="")
                {
                    gridViewNewSchema.SetRowCellValue(i, "gridColPrimaryKey", false);
                }
                attribute.PrimaryKey = Convert.ToBoolean(gridViewNewSchema.GetRowCellValue(i, "gridColPrimaryKey"));
                attribute.AttributeName = gridViewNewSchema.GetRowCellValue(i, "gridColAttributeName").ToString();
                attribute.FproDataType.TypeName = gridViewNewSchema.GetRowCellValue(i, "gridColDataType").ToString();
                attribute.FproDataType.GetDomain(gridViewNewSchema.GetRowCellValue(i, "gridColDomain").ToString());
                attribute.Description = (gridViewNewSchema.GetRowCellValue(i, "gridColDescription") == null ? "" : gridViewNewSchema.GetRowCellValue(i, "gridColDescription").ToString());
                attribute.FproDataType.GetDataType();
                probAttributes.Add(attribute);
            }
            return probAttributes;
        }
        private void btSaveNewSchema_Click(object sender, EventArgs e)
        {
            dxErrorProviderNewSchema.SetError(txtSchemeName, null);

            if (txtSchemeName.Text.Trim().Length <= 0)
            {
                dxErrorProviderNewSchema.SetError(txtSchemeName, "You must enter a schema name, please try again!");
                return;
            }

            dxErrorProviderNewSchema.SetError(txtSchemeName, null);

            if (txtSchemeName.Text.ToLower() == "select" || txtSchemeName.Text.ToLower() == "from" || txtSchemeName.Text.ToLower() == "where")
            {
                dxErrorProviderNewSchema.SetError(txtSchemeName, "Schema name is not valid ( not match with keyword 'select', 'from', 'where')  ");
                return;
            }

            foreach (var item in this.probDatabase.ListOfSchemeNameToLower())
            {
                if (item.Equals(txtSchemeName.Text.ToLower()))
                {
                    dxErrorProviderNewSchema.SetError(txtSchemeName, "This schema name has already existed in the database, please try again !");
                    return;
                }
            }

            dxErrorProviderNewSchema.SetError(txtSchemeName, null);
            if(gridViewNewSchema.DataRowCount<1)
            {
                XtraMessageBox.Show("Error: Unable to create Schema. Schema attribute is required !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //insert scheme
            FProbSchemaBLL scheme = new FProbSchemaBLL(txtSchemeName.Text);
            scheme.IdSchema = scheme.getMaxIdinTable();
            scheme.Insert();
            scheme.FproAttributes = getAllAttributeFromDataGridView(gridViewNewSchema);

            //insert attribute
            int attributeID = new FProbAttributeBLL().getMaxIdinTable();
            foreach (FProbAttributeBLL attr in scheme.FproAttributes)
            {
                attr.FproSchema = scheme;
                attr.IdAttribute = attributeID;
                attr.Insert();
                attributeID++;
            }
            /// add scheme 
            this.listProbScheme.Add(scheme);
            FProbRelationBLL relation = new FProbRelationBLL();
            relation.RelationName = txtSchemeName.Text;
            relation.FproSchema = scheme;
            relation.InsertSystemRelation();
            relation.CreateTableRelation();
            this.probDatabase.FproRelations.Add(relation);
            XtraMessageBox.Show("Add successfully");
            this.Close();
        }
        private void ResetGridView()
        {
            gridViewNewSchema.CloseEditor();
            gridViewNewSchema.CancelUpdateCurrentRow();
            gridControlNewSchema.DataSource = null;
            dt.Columns.Add("gridColPrimaryKey", typeof(Boolean));
            dt.Columns.Add("gridColAttributeName", typeof(String));
            dt.Columns.Add("gridColDataType", typeof(String));
            dt.Columns.Add("gridColDomain", typeof(String));
            dt.Columns.Add("gridColDescription", typeof(String));
            if (ProbScheme.FproAttributes.Count > 0)
            {
                foreach (FProbAttributeBLL att in ProbScheme.FproAttributes)
                {
                    DataRow row = dt.NewRow();
                    row[0] = att.PrimaryKey;
                    row[1] = att.AttributeName;
                    row[2] = att.FproDataType.TypeName;
                    row[3] = att.FproDataType.DomainString;
                    row[4] = att.Description;
                    dt.Rows.Add(row);
                }
            }
            gridControlNewSchema.DataSource = dt;
            gridViewNewSchema.AddNewRow();
        }
        private void FrmNewSchema_Load(object sender, EventArgs e)
        {
            ResetGridView();
        }
        private void gridViewNewSchema_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        private void gridViewNewSchema_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            // kiem tra 6 cell cua mot dong dang Edit xem co rong ko?
            if(gridViewNewSchema.GetRowCellValue(e.RowHandle, "gridColAttributeName").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Enter Name Attribute!";
            }
            if (gridViewNewSchema.GetRowCellValue(e.RowHandle, "gridColDataType").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Select DataType!";
            }
            if(!bVali)
            {
 
                e.Valid = false;
                // coi như valid không qua được. bạn sẽ không làm được gì trừ khi
                //điền thêm thông tin hoặc bấm nút ESC trên bàn phím
                XtraMessageBox.Show(sErr ,"Error!!!");
            }
            else
            {
                string name = gridViewNewSchema.GetRowCellValue(e.RowHandle, "gridColAttributeName").ToString().ToLower();
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
                        for (int i = 0; i <= gridViewNewSchema.DataRowCount - 1; i++)
                        {
                            if (gridViewNewSchema.GetRowCellValue(i, "gridColAttributeName").ToString().ToLower() == name)
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
                        for (int i = 0; i <= gridViewNewSchema.DataRowCount - 1; i++)
                        {
                            if ((i != e.RowHandle) && (gridViewNewSchema.GetRowCellValue(i, "gridColAttributeName").ToString().ToLower() == name))
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
        private void gridControlNewSchema_ProcessGridKey(object sender, KeyEventArgs e)
        {
            // kiểm tra xem có phải người dùng bấm nút xóa trên bàn phím
            // Và trạng thái của Gridcontrol có không phải là đang edit không (tránh
            // tình trạng người dùng đang focus để sửa 1 cell nào trong Grid view )
            if (e.KeyCode==Keys.Delete &&  gridViewNewSchema.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing )
            {
                if (XtraMessageBox.Show("Are you sure?", "Quest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XtraMessageBox.Show(gridViewNewSchema.GetRowCellValue(gridViewNewSchema.FocusedRowHandle, "gridColPrimaryKey").ToString(), "");
                    XtraMessageBox.Show(gridViewNewSchema.GetRowCellValue(gridViewNewSchema.FocusedRowHandle, "gridColAttributeName").ToString(), "");
                    XtraMessageBox.Show(gridViewNewSchema.GetRowCellValue(gridViewNewSchema.FocusedRowHandle, "gridColDataType").ToString(), "");
                    XtraMessageBox.Show(gridViewNewSchema.GetRowCellValue(gridViewNewSchema.FocusedRowHandle, "gridColDomain").ToString(), "");
                    XtraMessageBox.Show(gridViewNewSchema.GetRowCellValue(gridViewNewSchema.FocusedRowHandle, "gridColDescription").ToString(), "");
                    dt.Rows.RemoveAt(gridViewNewSchema.FocusedRowHandle);
                }
            }
        }
        private void gridViewNewSchema_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "gridColDataType" && e.Button == MouseButtons.Right)
                {
                    FrmInputType frm;
                    if (gridViewNewSchema.GetRowCellValue(e.RowHandle, "gridColDataType") != null)
                    {
                        frm = new FrmInputType(gridViewNewSchema.GetRowCellValue(e.RowHandle, "gridColDataType").ToString(), gridViewNewSchema.GetRowCellValue(e.RowHandle, "gridColDomain").ToString());
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
                            gridViewNewSchema.SetRowCellValue(e.RowHandle, "gridColDataType", frm.dataType.DataType);
                        }
                        else
                            gridViewNewSchema.SetRowCellValue(e.RowHandle, "gridColDataType", frm.dataType.TypeName);
                        gridViewNewSchema.SetRowCellValue(e.RowHandle, "gridColDomain", frm.dataType.DomainString);
                    }
                }
            }
            catch
            {

            }
        }

        private void biCancelNewSchema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}