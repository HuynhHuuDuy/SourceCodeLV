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
    public partial class FrmLibraryCons : DevExpress.XtraEditors.XtraForm
    {
        public List<ContinuousFuzzySetBLL> PointList { get; set; }
        private DataTable dt = new DataTable();
        private List<ContinuousFuzzySetBLL> list;
        public FrmLibraryCons()
        {
            InitializeComponent();
            PointList = null;
        }
        private void RefreshData()
        {

            gridCtrLibraryCons.DataSource = null;
            dt = new DataTable();
            dt.Columns.Add("gridColCheck", typeof(bool));
            dt.Columns.Add("gridColName", typeof(String));
            dt.Columns.Add("gridColBtLeft", typeof(Double));
            dt.Columns.Add("gridColTopLeft", typeof(Double));
            dt.Columns.Add("gridColTopRight", typeof(Double));
            dt.Columns.Add("gridColBtRight", typeof(Double));
            string path = Directory.GetCurrentDirectory() + @"\lib\";
            this.list = ContinuousFuzzySetBLL.GenerateAllConFS(path);
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = false;
                row[1] = list[i].FuzzySetName;
                row[2] = list[i].BottomLeft;
                row[3] = list[i].TopLeft;
                row[4] = list[i].TopRight;
                row[5] = list[i].BottomRight;
                dt.Rows.Add(row);
            }
            gridCtrLibraryCons.DataSource = dt;
        }
        private void FrmLibraryCons_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btCloseCons_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridCtrLibraryCons_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                FrmAddContinuousFuzzySet frm = new FrmAddContinuousFuzzySet();
                frm.ShowDialog();
                RefreshData();
                e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (XtraMessageBox.Show("Are you sure delete this row?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string path = Directory.GetCurrentDirectory() + @"\lib\";
                    if (gridViewLibraryCons.GetSelectedRows()[0] >= 0)
                    {
                        var datarow = gridViewLibraryCons.GetDataRow(gridViewLibraryCons.GetSelectedRows()[0]);
                        var name = datarow["gridColName"];
                        path = path + name + ".conFS";
                        ContinuousFuzzySetBLL.DeleteFS(path);
                    }
                }
            }
        }

        private void gridViewLibraryCons_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName != "gridColCheck" && e.Button == MouseButtons.Right)
            {
                ContinuousFuzzySetBLL cons=new ContinuousFuzzySetBLL(gridViewLibraryCons.GetRowCellValue(e.RowHandle, "gridColName").ToString(),Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(e.RowHandle, "gridColBtLeft")),Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(e.RowHandle, "gridColTopLeft")), Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(e.RowHandle, "gridColTopRight")),Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(e.RowHandle, "gridColBtRight")));
                FrmAddContinuousFuzzySet frm = new FrmAddContinuousFuzzySet(cons);
                frm.ShowDialog();
                RefreshData();
            }
        }
        private List<ContinuousFuzzySetBLL> GetSelectedRows()
        {
            List<ContinuousFuzzySetBLL> result = new List<ContinuousFuzzySetBLL>();

            for (int i = 0; i < gridViewLibraryCons.DataRowCount; i++)
            {
                if (gridViewLibraryCons.GetRowCellValue(i, "gridColCheck").ToString() == "True")
                {
                    ContinuousFuzzySetBLL cons = new ContinuousFuzzySetBLL(gridViewLibraryCons.GetRowCellValue(i, "gridColName").ToString(), Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(i, "gridColBtLeft")), Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(i, "gridColTopLeft")), Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(i, "gridColTopRight")), Convert.ToDouble(gridViewLibraryCons.GetRowCellValue(i, "gridColBtRight")));
                    result.Add(cons);
                }
            }
            return result;
        }
        private void btCharCons_Click(object sender, EventArgs e)
        {
            this.PointList = GetSelectedRows();
            if (PointList.Count == 0)
            {
                XtraMessageBox.Show("Please select a fuzzy set to view the chart!\n You can choose more than one");
                return;
            }
            this.Close();
        }
    }
}