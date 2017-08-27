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
    public partial class FrmNewRelation : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;

        public FrmNewRelation()
        {
            InitializeComponent();
        }

        public FrmNewRelation(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }

        private void FrmNewRelation_Load(object sender, EventArgs e)
        {
            ComboBox_RelationName.Properties.Items.Clear();
            ComboBox_RelationName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            ComboBox_RelationName.Properties.Items.AddRange(this.probDatabase.ListOfSchemeNameToLower());
            ComboBox_RelationName.SelectedIndex = 0;
        }

        private void btSaveCreateNewRel_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(txtRelationName, null);
                if (txtRelationName.Text.Trim().Length <= 0)
                {
                    errorProvider.SetError(txtRelationName, "You must enter a relation name, please try again !");
                    return;
                }

                if (txtRelationName.Text.ToLower() == "select" || txtRelationName.Text.ToLower() == "from" || txtRelationName.Text.ToLower() == "where")
                {
                    errorProvider.SetError(txtRelationName, "Relation name is not valid ( not match with keyword 'select', 'from', 'where')  ");
                    return;
                }

                foreach (var item in this.probDatabase.ListOfRelationNameToLower())
                {
                    if (item.Equals(txtRelationName.Text.ToLower(), StringComparison.OrdinalIgnoreCase))
                    {
                        errorProvider.SetError(txtRelationName, "This relation name has already existed in the database, please try again !");
                        return;
                    }
                }

                if (XtraMessageBox.Show("Do you want save?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    FProbSchemaBLL scheme = this.probDatabase.FproSchemas.SingleOrDefault(c => c.SchemaName.ToLower() == ComboBox_RelationName.Properties.Items[ComboBox_RelationName.SelectedIndex].ToString());
                    FProbRelationBLL relation = new FProbRelationBLL();
                    relation.RelationName = txtRelationName.Text;
                    relation.FproSchema = scheme;
                    relation.InsertSystemRelation();
                    relation.CreateTableRelation();
                    this.probDatabase.FproRelations.Add(relation);
                    XtraMessageBox.Show("Add successfully");
                    this.Close();
                }
            }
            catch (Exception EX)
            {
                XtraMessageBox.Show(EX.Message);
            }
        }

        private void btCancelCreateNewRel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}