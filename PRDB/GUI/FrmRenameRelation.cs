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
    public partial class FrmRenameRelation : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;
        public string CurrentNameRelation = string.Empty;
        public string relationName = string.Empty;
        public FrmRenameRelation()
        {
            InitializeComponent();
        }

        public FrmRenameRelation(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }
        public FrmRenameRelation(FProbDatabaseBLL probDatabase, string relationName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.relationName = relationName;
            this.probDatabase = probDatabase;
        }

        private void btCancelRenameRelation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRenameRelation_Load(object sender, EventArgs e)
        {
            ComboBox_RenameRelation.Properties.Items.Clear();
            ComboBox_RenameRelation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            ComboBox_RenameRelation.Properties.Items.AddRange(this.probDatabase.ListOfRelationNameToLower());
            ComboBox_RenameRelation.SelectedIndex = this.probDatabase.ListOfRelationNameToLower().IndexOf(this.relationName);
            this.CurrentNameRelation = this.relationName;
        }

        private void btSaveRenameRelation_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtRenameRelation, null);
            if (txtRenameRelation.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(txtRenameRelation, "You did not enter a relation name");
                return;
            }

            if (txtRenameRelation.Text.ToLower() == "select" || txtRenameRelation.Text.ToLower() == "from" || txtRenameRelation.Text.ToLower() == "where")
            {
                errorProvider.SetError(txtRenameRelation, "Relation name is not valid ( not match with keyword 'select', 'from', 'where')  ");
                return;

            }


            if (this.CurrentNameRelation == txtRenameRelation.Text.Trim().ToLower())
            {
                return;
            }


            if (this.CurrentNameRelation != txtRenameRelation.Text.Trim().ToLower())
            {
                foreach (var item in this.probDatabase.ListOfRelationNameToLower())
                {
                    if (item.Equals(txtRenameRelation.Text.ToLower()))
                    {
                        errorProvider.SetError(txtRenameRelation, "This relation name has already existed in the database ");
                        return;
                    }
                }
            }

            FProbRelationBLL relation = this.probDatabase.FproRelations.SingleOrDefault(c => c.RelationName.ToLower() == CurrentNameRelation.ToLower());
            this.probDatabase.FproRelations.Remove(relation);
            relation.DropTableByTableName();
            relation.DeleteRelationById();
            relation.RelationName = txtRenameRelation.Text.Trim();
            relation.InsertSystemRelation();
            relation.CreateTableRelation();
            relation.InsertTupleIntoTableRelation();
            this.probDatabase.FproRelations.Add(relation);
            XtraMessageBox.Show("Rename relation successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ComboBox_RenameRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CurrentNameRelation = ComboBox_RenameRelation.Properties.Items[ComboBox_RenameRelation.SelectedIndex].ToString();
        }
    }
}