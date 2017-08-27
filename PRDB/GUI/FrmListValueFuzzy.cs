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
    public partial class FrmListValueFuzzy : DevExpress.XtraEditors.XtraForm
    {
        private string datatypename;
        private List<DiscreteFuzzySetBLL> list;
        private List<ContinuousFuzzySetBLL> listCons;
        DataTable dt = new DataTable();
        public string valuename;
        public FrmListValueFuzzy()
        {
            InitializeComponent();
            this.valuename = string.Empty;
        }
        public FrmListValueFuzzy(string datatypename)
        {
            InitializeComponent();
            this.datatypename = datatypename;
            this.valuename = string.Empty;
        }
        private void LoadDSF()
        {
            list = new List<DiscreteFuzzySetBLL>();
            string path = Directory.GetCurrentDirectory() + @"\lib\";
            list =  DiscreteFuzzySetBLL.GenerateAllDisFS(path);
        }
        private void LoadCSF()
        {
            listCons = new List<ContinuousFuzzySetBLL>();
            string path = Directory.GetCurrentDirectory() + @"\lib\";
            listCons = ContinuousFuzzySetBLL.GenerateAllConFS(path);
        }
        private void ResetGridView(string datatypename)
        {
            gridCtlFuzzyValue.DataSource = null;
            dt = new DataTable();
            dt.Columns.Add("gridColValue", typeof(String));
            if(datatypename=="DiscreteFuzzySet")
            {
                LoadDSF();
                for(int i=0; i<list.Count;i++)
                {
                    DataRow row = dt.NewRow();
                    row[0] = list[i].FuzzySetName;
                    dt.Rows.Add(row);
                }
            }
            else
            {
                LoadCSF();
                for (int i = 0; i < listCons.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row[0] = listCons[i].FuzzySetName;
                    dt.Rows.Add(row);
                }
            }
            gridCtlFuzzyValue.DataSource = dt;
        }
        private void FrmListValueFuzzy_Load(object sender, EventArgs e)
        {
            ResetGridView(datatypename);
        }

        private void btCancelFuzzyValue_Click(object sender, EventArgs e)
        {
            this.valuename = string.Empty;
            this.Close();
        }

        private void btOkFuzzyValue_Click(object sender, EventArgs e)
        {
            try
            {
                this.valuename = gridViewFuzzyValue.GetRowCellValue(gridViewFuzzyValue.FocusedRowHandle, "gridColValue").ToString();
            }
            catch
            {
                this.valuename = string.Empty;
            }
            this.Close();
        }

        private void gridCtlFuzzyValue_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if(e.Button.ButtonType==NavigatorButtonType.Append)
            {
                if(datatypename=="DiscreteFuzzySet")
                {
                    FrmAddDiscreteFuzzySet frm = new FrmAddDiscreteFuzzySet();
                    frm.ShowDialog();
                    ResetGridView(datatypename);
                }
                else {
                    FrmAddContinuousFuzzySet frm = new FrmAddContinuousFuzzySet();
                    frm.ShowDialog();
                    ResetGridView(datatypename);
                }
                e.Handled = true;
            }
        }
    }
}