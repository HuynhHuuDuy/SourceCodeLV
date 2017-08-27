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
    public partial class FrmOpenQuery : DevExpress.XtraEditors.XtraForm
    {
        private FProbDatabaseBLL probDatabase;
        public string QueryName = string.Empty;
        public FrmOpenQuery()
        {
            InitializeComponent();
        }

        public FrmOpenQuery(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }

        private void FrmOpenQuery_Load(object sender, EventArgs e)
        {
            comboBoxOpenQuery.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxOpenQuery.Properties.Items.AddRange(this.probDatabase.ListOfQueryNameToLower());
            comboBoxOpenQuery.SelectedIndex = 0;
        }

        private void btOkOpenQuery_Click(object sender, EventArgs e)
        {
            QueryName = comboBoxOpenQuery.Properties.Items[comboBoxOpenQuery.SelectedIndex].ToString();
            this.Close();
        }

        private void btCancelOpenQuery_Click(object sender, EventArgs e)
        {
            this.QueryName = string.Empty;
            this.Close();
        }
    }
}