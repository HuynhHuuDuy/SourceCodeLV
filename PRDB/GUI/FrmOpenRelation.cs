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
    public partial class FrmOpenRelation : DevExpress.XtraEditors.XtraForm
    {
        private List<string> list;
        public string relationName = string.Empty;
        public FrmOpenRelation()
        {
            InitializeComponent();
        }

        public FrmOpenRelation(List<string> list)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.list = list;
        }

        private void btCancelOpenRelation_Click(object sender, EventArgs e)
        {
            this.relationName = string.Empty;
            this.Close();
        }

        private void FrmOpenRelation_Load(object sender, EventArgs e)
        {
            comboBoxOpenRelation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxOpenRelation.Properties.Items.AddRange(this.list);
            comboBoxOpenRelation.SelectedIndex = 0;
        }

        private void btOkOpenRelation_Click(object sender, EventArgs e)
        {
            this.relationName = comboBoxOpenRelation.Properties.Items[comboBoxOpenRelation.SelectedIndex].ToString();
            this.Close();
        }
    }
}