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

namespace FPRDB.GUI
{
    public partial class FrmOpenSchema : DevExpress.XtraEditors.XtraForm
    {
        private List<string> list;
        public string selected;

        public FrmOpenSchema()
        {
            InitializeComponent();
        }

        public FrmOpenSchema(List<string> list)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.list = list;
        }

        private void FrmOpenSchema_Load(object sender, EventArgs e)
        {
            comboBoxOpenSchema.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxOpenSchema.Properties.Items.AddRange(this.list);
            comboBoxOpenSchema.SelectedIndex = this.list.Count > 0 ? 0 : -1;
        }

        private void btCancelOpenSchema_Click(object sender, EventArgs e)
        {
            selected = string.Empty;
            this.Close();
        }

        private void btOkOpenSchema_Click(object sender, EventArgs e)
        {
            selected = comboBoxOpenSchema.SelectedIndex != -1 ? comboBoxOpenSchema.Properties.Items[comboBoxOpenSchema.SelectedIndex].ToString() : string.Empty;
            this.Close();
        }
    }
}