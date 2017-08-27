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
    public partial class FrmRenameQuery : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;
        public string queryName = string.Empty;
        public List<string> listNameQuery = new List<string>();
        public string QueryNameRename = string.Empty;
        public FrmRenameQuery()
        {
            InitializeComponent();
        }

        public FrmRenameQuery(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }
        public FrmRenameQuery(FProbDatabaseBLL probDatabase, string queryName)
        {
            // TODO: Complete member initialization
            this.probDatabase = probDatabase;
            listNameQuery.AddRange(this.probDatabase.ListOfQueryNameToLower());
            InitializeComponent();
            this.queryName = queryName;
        }

        private void FrmRenameQuery_Load(object sender, EventArgs e)
        {
            ComboBox_RenameQuery.Properties.Items.Clear();
            ComboBox_RenameQuery.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            ComboBox_RenameQuery.Properties.Items.AddRange(this.listNameQuery);
            ComboBox_RenameQuery.SelectedIndex = this.listNameQuery.IndexOf(this.queryName);
            txtRenameQuery.Text = queryName;
        }

        private void ComboBox_RenameQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRenameQuery.Text = ComboBox_RenameQuery.Properties.Items[ComboBox_RenameQuery.SelectedIndex].ToString();
        }

        private void btSaveRenameQuery_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtRenameQuery, null);
            if (txtRenameQuery.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(txtRenameQuery, "You did not enter a query name");
                return;
            }

            foreach (string item in this.listNameQuery)
            {
                if (item == txtRenameQuery.Text.Trim().ToLower() && txtRenameQuery.Text.Trim() != this.listNameQuery[ComboBox_RenameQuery.SelectedIndex])
                {
                    errorProvider.SetError(txtRenameQuery, "This query name has already existed in the database");
                    return;
                }
            }


            FProbQueryBLL query = this.probDatabase.FproQueries.SingleOrDefault(c => c.QueryName == this.listNameQuery[ComboBox_RenameQuery.SelectedIndex]);
            QueryNameRename = query.QueryName;
            query.QueryName = txtRenameQuery.Text.Trim().ToLower();

            query.Update();

            queryName = query.QueryName;
            XtraMessageBox.Show("Rename query successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btCancelRenameQuery_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}