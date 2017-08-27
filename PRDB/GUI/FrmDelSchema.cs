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
    public partial class FrmDelSchema : DevExpress.XtraEditors.XtraForm
    {
        public FProbDatabaseBLL probDatabase;
        private List<string> list;
        private string SchemeName = string.Empty;
        public FrmDelSchema()
        {
            InitializeComponent();
        }

        public FrmDelSchema(FProbDatabaseBLL probDatabase)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
            this.list = this.probDatabase.ListOfSchemeNameToLower();
        }
        public FrmDelSchema(FProbDatabaseBLL probDatabase, string SchemeName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.probDatabase = probDatabase;
            this.SchemeName = SchemeName.ToLower();
            this.list = this.probDatabase.ListOfSchemeNameToLower();
        }

        private void FrmDelSchema_Load(object sender, EventArgs e)
        {
            comboBoxDelSchema.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxDelSchema.Properties.Items.AddRange(this.list);
            if (SchemeName == string.Empty)
                comboBoxDelSchema.SelectedIndex = this.list.Count > 0 ? 0 : -1;
            else
                comboBoxDelSchema.SelectedIndex = this.list.IndexOf(SchemeName);
        }

        private void btCancelDelSchema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOkDelSchema_Click(object sender, EventArgs e)
        {
            if (comboBoxDelSchema.SelectedIndex != -1)
            {
                FProbSchemaBLL currentScheme = this.probDatabase.FproSchemas.SingleOrDefault(c => c.SchemaName.ToLower() == comboBoxDelSchema.Properties.Items[comboBoxDelSchema.SelectedIndex].ToString());
                
                 if (currentScheme.isInherited(this.probDatabase.FproRelations))
                    {
                        XtraMessageBox.Show("Cannot delete this schema because it is inherited by some relations, please try again !", "Infomation ", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                    }
                 else 
                     if (XtraMessageBox.Show("Are you sure delete this schema?", "Delete Schema " + currentScheme.SchemaName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                     {
                         this.probDatabase.FproSchemas.Remove(currentScheme);
                         currentScheme.DeleteSchemeById();
                         XtraMessageBox.Show("Delete successfully!", "Infomation ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         this.Close();
                     }             
            }
            else
                this.Close();
        }

        private void panelControlDelSchema_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}