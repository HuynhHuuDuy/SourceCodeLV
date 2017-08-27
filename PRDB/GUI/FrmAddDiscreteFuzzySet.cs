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
using System.IO;

namespace FPRDB.GUI
{
    public partial class FrmAddDiscreteFuzzySet : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt = new DataTable();
        private string name;
        private DiscreteFuzzySetBLL dis = new DiscreteFuzzySetBLL();
        public FrmAddDiscreteFuzzySet()
        {
            InitializeComponent();
            this.name = "";
            dis = null;
        }

        public FrmAddDiscreteFuzzySet(string name)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.name = name;
            dis = DiscreteFuzzySetBLL.GetByName(name);
        }
        private void ResetGridView()
        {
            gridControlDisCreteFuzzy.DataSource = null;
            dt = new DataTable();
            dt.Columns.Add("gridColumnValueDis", typeof(Double));
            dt.Columns.Add("gridColumnMembershipDis", typeof(Double));
            if(name!="")
            {
                txtNewNameDis.Text = dis.FuzzySetName;
                for(int i=0; i<dis.ValueSet.Count;i++)
                {
                    DataRow row = dt.NewRow();
                    row[0] = dis.ValueSet[i];
                    row[1] = dis.MembershipSet[i];
                    dt.Rows.Add(row);
                }
                gridControlDisCreteFuzzy.DataSource = dt;
            }
            else
            {
                gridControlDisCreteFuzzy.DataSource = dt;
                gridViewDisCreteFuzzy.AddNewRow();
            }
        }
        private void FrmAddDiscreteFuzzySet_Load(object sender, EventArgs e)
        {
            ResetGridView();
        }
        private void gridViewDisCreteFuzzy_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        private bool NullValue()
        {
            string sErr = "";
            bool bVali = true;
            // kiem tra 6 cell cua mot dong dang Edit xem co rong ko?
            if (gridViewDisCreteFuzzy.GetRowCellValue(gridViewDisCreteFuzzy.FocusedRowHandle, "gridColumnValueDis")==null||gridViewDisCreteFuzzy.GetRowCellValue(gridViewDisCreteFuzzy.FocusedRowHandle, "gridColumnValueDis").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Missing value on row! ";
            }
            if (gridViewDisCreteFuzzy.GetRowCellValue(gridViewDisCreteFuzzy.FocusedRowHandle, "gridColumnMembershipDis")==null||gridViewDisCreteFuzzy.GetRowCellValue(gridViewDisCreteFuzzy.FocusedRowHandle, "gridColumnMembershipDis").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Missing membership on row! ";
            }
            if (!bVali)
            {
                XtraMessageBox.Show(sErr, "Error!!!");
                return false;
            }
            else
            {
                double value = Convert.ToDouble(gridViewDisCreteFuzzy.GetRowCellValue(gridViewDisCreteFuzzy.FocusedRowHandle, "gridColumnValueDis"));
                if (gridViewDisCreteFuzzy.FocusedRowHandle < 0)
                {
                    for (int i = 0; i < gridViewDisCreteFuzzy.DataRowCount; i++)
                    {
                        if (Convert.ToDouble(gridViewDisCreteFuzzy.GetRowCellValue(i, "gridColumnValueDis")) == value)
                        {
                            bVali = false;
                            sErr = sErr + "Value \"" + value.ToString() + "\" is a key in \"values column\", it doesn't equal to others key!";
                            XtraMessageBox.Show(sErr, "Error!!!");
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < gridViewDisCreteFuzzy.DataRowCount; i++)
                    {
                        if ((i != gridViewDisCreteFuzzy.FocusedRowHandle) && Convert.ToDouble(gridViewDisCreteFuzzy.GetRowCellValue(i, "gridColumnValueDis")) == value)
                        {
                            bVali = false;
                            sErr = sErr + "Value \"" + value.ToString() + "\" is a key in \"values column\", it doesn't equal to others key!";
                            XtraMessageBox.Show(sErr, "Error!!!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void gridViewDisCreteFuzzy_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            // kiem tra 6 cell cua mot dong dang Edit xem co rong ko?
            if (gridViewDisCreteFuzzy.GetRowCellValue(e.RowHandle, "gridColumnValueDis").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Missing value on row! ";
            }
            if (gridViewDisCreteFuzzy.GetRowCellValue(e.RowHandle, "gridColumnMembershipDis").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Missing membership on row! ";
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
                double value = Convert.ToDouble(gridViewDisCreteFuzzy.GetRowCellValue(e.RowHandle, "gridColumnValueDis"));
                if(e.RowHandle<0)
                {
                    for(int i=0;i<gridViewDisCreteFuzzy.DataRowCount;i++)
                    {
                        if(Convert.ToDouble(gridViewDisCreteFuzzy.GetRowCellValue(i, "gridColumnValueDis")) == value)
                        {
                            bVali = false;
                            sErr = sErr + "Value \"" + value.ToString() + "\" is a key in \"values column\", it doesn't equal to others key!";
                            e.Valid = false;
                            XtraMessageBox.Show(sErr, "Error!!!");
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < gridViewDisCreteFuzzy.DataRowCount; i++)
                    {
                        if ((i!=e.RowHandle) && Convert.ToDouble(gridViewDisCreteFuzzy.GetRowCellValue(i, "gridColumnValueDis")) == value)
                        {
                            bVali = false;
                            sErr = sErr + "Value \"" + value.ToString() + "\" is a key in \"values column\", it doesn't equal to others key!";
                            e.Valid = false;
                            XtraMessageBox.Show(sErr, "Error!!!");
                            break;
                        }
                    }
                }
            }
        }

        private void gridControlDisCreteFuzzy_ProcessGridKey(object sender, KeyEventArgs e)
        {
            // kiểm tra xem có phải người dùng bấm nút xóa trên bàn phím
            // Và trạng thái của Gridcontrol có không phải là đang edit không (tránh
            // tình trạng người dùng đang focus để sửa 1 cell nào trong Grid view )
            if (e.KeyCode == Keys.Delete && gridViewDisCreteFuzzy.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                if (XtraMessageBox.Show("Are you sure?", "Quest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XtraMessageBox.Show(gridViewDisCreteFuzzy.GetRowCellValue(gridViewDisCreteFuzzy.FocusedRowHandle, "gridColumnValueDis").ToString(), "");
                    XtraMessageBox.Show(gridViewDisCreteFuzzy.GetRowCellValue(gridViewDisCreteFuzzy.FocusedRowHandle, "gridColumnMembershipDis").ToString(), "");
                    dt.Rows.RemoveAt(gridViewDisCreteFuzzy.FocusedRowHandle);
                }
            }
        }
        private List<string> GetDataRows(DevExpress.XtraGrid.Views.Grid.GridView gridViewDisCreteFuzzy)
        {
            List<String> result = new List<String>();
            result.Add(this.txtNewNameDis.Text.Trim());//First element is Name
            String values = "";
            String memberships = "";

            for (int i = 0; i < gridViewDisCreteFuzzy.DataRowCount; i++)
            {
                values += gridViewDisCreteFuzzy.GetRowCellValue(i, "gridColumnValueDis").ToString().Trim() + ",";
                memberships += gridViewDisCreteFuzzy.GetRowCellValue(i, "gridColumnMembershipDis").ToString().Trim() + ",";
            }

            values = values.Remove(values.LastIndexOf(","));
            memberships = memberships.Remove(memberships.LastIndexOf(","));
            result.Add(values);
            result.Add(memberships);

            return result;
        }
        private void btSaveDis_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewNameDis.Text=="")
                {
                    XtraMessageBox.Show("Missing Linguistic Lable!!!", "Error!!!");
                    return;
                }
                double x;
                if (Double.TryParse(txtNewNameDis.Text.Trim(), out x) && gridViewDisCreteFuzzy.DataRowCount==0)
                {
                    String path = Directory.GetCurrentDirectory() + @"\lib\";
                    //DiscreteFuzzySetBLL newDisFs = GetDataRows();
                    List<String> list= new List<String>();
                    list.Add(txtNewNameDis.Text.Trim());
                    list.Add(txtNewNameDis.Text.Trim());
                    list.Add("1");
                    //if (newDisFs.Update() == 1)
                    if (DiscreteFuzzySetBLL.UpdateFS(path, list.GetRange(1, 2), list[0] + ".disFS") == 1)
                    {
                        XtraMessageBox.Show("Save DONE!");
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Save FAILED!");
                    }
                }
                else
                if (gridViewDisCreteFuzzy.RowCount != 0)
                {
                    String path = Directory.GetCurrentDirectory() + @"\lib\";
                    //DiscreteFuzzySetBLL newDisFs = GetDataRows();
                    List<String> list = GetDataRows(gridViewDisCreteFuzzy);
                    //if (newDisFs.Update() == 1)
                    if (DiscreteFuzzySetBLL.UpdateFS(path, list.GetRange(1, 2), list[0] + ".disFS") == 1)
                    {
                        XtraMessageBox.Show("Save DONE!");
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Save FAILED!");
                    }
                }
                else
                    XtraMessageBox.Show("Value and Membership are missing!");
            }
            catch
            {

            }
        }

        private void btCancelDis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewDisCreteFuzzy_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }    
    }
}