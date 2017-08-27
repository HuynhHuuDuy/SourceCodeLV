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
    public partial class FrmLibraryDis : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt = new DataTable();
        private List<DiscreteFuzzySetBLL> list;
        public List<DiscreteFuzzySetBLL> PointList { get; set; }
        public FrmLibraryDis()
        {
            InitializeComponent();
            PointList = null;
        }
        private String StringList(List<Double>list)
        {
            String str = "{";

            ///Add value to list after remove unesessary
            foreach (var value in list)
            {
                str = str + " "+value + ",";
            }
            if (str.Length > 2)
                str = str.Substring(0, str.Length - 1);
            str = str + " }";
            return str;
        }
        private void RefreshData()
        {

            gridCtrLibraryDis.DataSource = null;
            dt = new DataTable();
            dt.Columns.Add("gridColCheck", typeof(bool));
            dt.Columns.Add("gridColName", typeof(String));
            dt.Columns.Add("gridColValue", typeof(String));
            dt.Columns.Add("gridColMembership", typeof(String));
            string path = Directory.GetCurrentDirectory() + @"\lib\";
            this.list = DiscreteFuzzySetBLL.GenerateAllDisFS(path);
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = false;
                row[1] = list[i].FuzzySetName;
                row[2] = StringList(list[i].ValueSet);
                row[3] = StringList(list[i].MembershipSet);
                dt.Rows.Add(row);
            }
            gridCtrLibraryDis.DataSource = dt;
        }

        private void FrmLibraryDis_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void gridCtrLibraryDis_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if(e.Button.ButtonType==NavigatorButtonType.Append)
            {
                FrmAddDiscreteFuzzySet frm = new FrmAddDiscreteFuzzySet();
                frm.ShowDialog();
                RefreshData();
                e.Handled = true;
            }
        }

        private void gridViewLibraryDis_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(e.Column.FieldName!="gridColCheck" && e.Button==MouseButtons.Right)
            {
                FrmAddDiscreteFuzzySet frm = new FrmAddDiscreteFuzzySet(gridViewLibraryDis.GetRowCellValue(e.RowHandle, "gridColName").ToString());
                frm.ShowDialog();
                RefreshData();
            }
        }

        private void btCloseDis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<DiscreteFuzzySetBLL> GetSelectedRows()
        {
            List<DiscreteFuzzySetBLL> result = new List<DiscreteFuzzySetBLL>();

            for (int i = 0; i < gridViewLibraryDis.DataRowCount; i++)
            {
                if (gridViewLibraryDis.GetRowCellValue(i, "gridColCheck").ToString() == "True")
                {
                    DiscreteFuzzySetBLL set = new DiscreteFuzzySetBLL();
                    set = DiscreteFuzzySetBLL.GetByName(gridViewLibraryDis.GetRowCellValue(i, "gridColName").ToString().Trim());
                    result.Add(set);
                }
            }
            return result;
        }
        private void btChartDis_Click(object sender, EventArgs e)
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