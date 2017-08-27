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
    public partial class FrmDelQuery : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;
        private string QueryName = string.Empty;
        public string QueryNameRemove { get; set; }
        public FrmDelQuery()
        {
            InitializeComponent();
            QueryName = "";
        }
        public FrmDelQuery(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
            QueryName = "";
            QueryNameRemove = "";
        }
        public FrmDelQuery(FProbDatabaseBLL probDatabase, string QueryName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
            this.QueryName = QueryName;
            QueryNameRemove = "";
        }

        private void FrmDelQuery_Load(object sender, EventArgs e)
        {
            comboBoxDelQuery.Properties.Items.Clear();
            comboBoxDelQuery.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxDelQuery.Properties.Items.AddRange(this.probDatabase.ListOfQueryNameToLower());

            if (QueryName != string.Empty)
            {
                comboBoxDelQuery.SelectedIndex = this.probDatabase.ListOfQueryNameToLower().IndexOf(QueryName);

            }
            else
            {
                comboBoxDelQuery.SelectedIndex = 0;
            }
        }

        private void btOkDelQuery_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = XtraMessageBox.Show("Are you sure want to delete this query?", "Delete  Queries", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                string selectName = comboBoxDelQuery.Properties.Items[comboBoxDelQuery.SelectedIndex].ToString();
                FProbQueryBLL query = this.probDatabase.FproQueries.SingleOrDefault(c => c.QueryName.ToLower() == selectName);
                query.DeleteById();
                QueryNameRemove = query.QueryName;
                this.probDatabase.FproQueries.Remove(query);
                XtraMessageBox.Show(" Delete successfully!", "Infomation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btCancelDelQuery_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}