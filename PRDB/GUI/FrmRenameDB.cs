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
    public partial class FrmRenameDB : DevExpress.XtraEditors.XtraForm
    {
        internal FProbDatabaseBLL probDatabase;
        public FrmRenameDB()
        {
            InitializeComponent();
        }

        public FrmRenameDB(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }
        private void FrmRenameDB_Load(object sender, EventArgs e)
        {
            this.txtNewNameDB.Text = this.probDatabase.DbName;
        }

        private void btSaveRenameDB_Click(object sender, EventArgs e)
        {
            dxErrorProviderRenameDB.SetError(txtNewNameDB, null);
            if (txtNewNameDB.Text.Trim().Length <= 0)
            {
                dxErrorProviderRenameDB.SetError(txtNewNameDB, "You did not enter a database name");
                return;
            }

            if (XtraMessageBox.Show(" Do you want save this database name ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string oldPath = this.probDatabase.DbPath;
                    string oldName = this.probDatabase.DbName;
                    this.probDatabase.DbName = txtNewNameDB.Text.Trim();
                    File.Move(this.probDatabase.DbPath, this.probDatabase.DbPath.Replace(oldName, this.probDatabase.DbName)); // Try to move
                    this.Close();
                }
                catch (IOException ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btCancelRenameDB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}