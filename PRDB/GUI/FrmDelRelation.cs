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
    public partial class FrmDelRelation : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;
        public string relationName = string.Empty;
        public string relationNameRemove = string.Empty;
        public FrmDelRelation()
        {
            InitializeComponent();
        }

        public FrmDelRelation(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
        }
        public FrmDelRelation(FProbDatabaseBLL probDatabase, string relationName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
            this.relationName = relationName.ToLower();
        }

        private void FrmDelRelation_Load(object sender, EventArgs e)
        {
            comboBoxDelRelation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxDelRelation.Properties.Items.AddRange(this.probDatabase.ListOfRelationNameToLower());
            comboBoxDelRelation.SelectedIndex = relationName == string.Empty ? 0 : comboBoxDelRelation.Properties.Items.IndexOf(relationName);
        }

        private void btCancelDelRelation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOkDelRelation_Click(object sender, EventArgs e)
        {
            if (comboBoxDelRelation.SelectedIndex != -1)
            {
                FProbRelationBLL relation = this.probDatabase.FproRelations.SingleOrDefault(c => c.RelationName.ToLower() == comboBoxDelRelation.Properties.Items[comboBoxDelRelation.SelectedIndex].ToString());

                if (XtraMessageBox.Show("Are you sure delete this relation?", "Delete Relation" + relation.RelationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.probDatabase.FproRelations.Remove(relation);
                    relation.DropTableByTableName();
                    relation.DeleteRelationById();
                    relationNameRemove = relation.RelationName;
                    XtraMessageBox.Show(" Delete successfully!", "Infomation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                this.Close();
        }
    }
}