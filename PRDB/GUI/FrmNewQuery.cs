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
    public partial class FrmNewQuery : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;
        public string queryName = string.Empty;
        public FrmNewQuery()
        {
            InitializeComponent();
        }

        public FrmNewQuery(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }

        private void btCancelNewQuery_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOkNewQuery_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtQueryName, null);
            if (txtQueryName.Text.Trim().Length < 0)
            {
                errorProvider.SetError(txtQueryName, "You must enter a query name, please try again !");
                return;
            }

            foreach (string item in this.probDatabase.ListOfQueryNameToLower())
            {
                if (item == txtQueryName.Text.ToLower())
                {
                    errorProvider.SetError(txtQueryName, "The query name has already existed in the database, please try again !");
                    return;
                }
            }

            this.queryName = txtQueryName.Text.Trim().ToLower();

            FProbQueryBLL query = new FProbQueryBLL(this.queryName);
            query.Insert();
            query = query.getQueryByName();

            this.probDatabase.FproQueries.Add(query);

            if (XtraMessageBox.Show("Add successfully. Do you want add a new query name ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                txtQueryName.Text = "";
                txtQueryName.Focus();
            }
            else
                this.Close();
        }
    }
}