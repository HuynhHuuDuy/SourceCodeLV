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
    public partial class FrmAddContinuousFuzzySet : DevExpress.XtraEditors.XtraForm
    {
        private ContinuousFuzzySetBLL cons = new ContinuousFuzzySetBLL();
        public FrmAddContinuousFuzzySet()
        {
            InitializeComponent();
            this.cons = null;
        }
        public FrmAddContinuousFuzzySet(ContinuousFuzzySetBLL cons)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.cons = cons;
        }
        private void ResetGridView()
        {
            if(cons!=null)
            {
                txtNameConsFuzzy.Text = cons.FuzzySetName;
                txtBotLeft.Text = cons.BottomLeft.ToString();
                txtTopLeft.Text = cons.TopLeft.ToString();
                txtTopRight.Text = cons.TopRight.ToString();
                txtBotRight.Text = cons.BottomRight.ToString();
            }
        }
        private void btCancelConFuzzy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckNull()
        {
            if (txtNameConsFuzzy.Text.Trim() == "")
            {
                MessageBox.Show("The linguistic does not empty!");
                return false;
            }

            if (txtBotLeft.Text.Trim() == "" || txtBotLeft.Text.Trim() == null)
            {
                MessageBox.Show("Bottom-Left is empty!");
                return false;
            }

            if ((txtTopLeft.Text.Trim() == "" && txtTopRight.Text == ""))
            {
                MessageBox.Show("It' just allow one of Top-Left and Top-Right null!");
                return false;
            }

            if (txtBotRight.Text.Trim() == "" || txtBotRight.Text.Trim() == null)
            {
                MessageBox.Show("Bottom-Right is empty!");
                return false;
            }

            return true;
        }
        private Boolean CheckLogicValue(ContinuousFuzzySetBLL contfs)
        {
            Double bl = 0; if (txtBotLeft.Text != "") bl = Double.Parse(txtBotLeft.Text);
            Double tl = 0; if (txtTopLeft.Text != "") tl = Double.Parse(txtTopLeft.Text);
            Double tr = 0; if (txtTopRight.Text != "") tr = Double.Parse(txtTopRight.Text);
            Double br = 0; if (txtBotRight.Text != "") br = Double.Parse(txtBotRight.Text);
            if (!contfs.SetValue(bl, tl, tr, br))
            {
                XtraMessageBox.Show("Values of fuzzy set must be continous!");
                return false;
            }
            return true;
        }
        private void btSaveConFuzzy_Click(object sender, EventArgs e)
        {
            double x;
            if (txtNameConsFuzzy.Text.Trim()!="" && Double.TryParse(txtNameConsFuzzy.Text.Trim(), out x)==true)
            {
                if(txtBotLeft.Text.Trim() == "" && txtTopLeft.Text.Trim() == "" && txtTopRight.Text.Trim() == "" && txtBotRight.Text.Trim() == "")
                {
                    String name = txtNameConsFuzzy.Text.Trim() + ".conFS";
                    string path = Directory.GetCurrentDirectory() + @"\lib\";
                    String contentx = txtNameConsFuzzy.Text.Trim() + "," + txtNameConsFuzzy.Text.Trim() + "," + txtNameConsFuzzy.Text.Trim() + "," + txtNameConsFuzzy.Text.Trim();
                    if (ContinuousFuzzySetBLL.UpdateFS(path, contentx, name) == 1)
                    {
                           XtraMessageBox.Show("Save DONE!");
                           this.Close();
                    }
                       else
                        {
                            XtraMessageBox.Show("Save FAILED");
                        }
                }
            }
            else
            {
                if (!CheckNull()) return;
                ContinuousFuzzySetBLL newFS = new ContinuousFuzzySetBLL();
                if (!CheckLogicValue(newFS)) return;
                String name = txtNameConsFuzzy.Text.Trim() + ".conFS";

                String content = txtBotLeft.Text.Trim();

                string path = Directory.GetCurrentDirectory() + @"\lib\";

                if (txtTopLeft.Text.Trim() == "" && txtTopRight.Text.Trim() != "")
                {
                    content += "," + txtTopRight.Text.Trim() + "," + txtTopRight.Text.Trim() + "," + txtTopRight.Text.Trim();
                    if (ContinuousFuzzySetBLL.UpdateFS(path, content, name) == 1)
                    {
                        XtraMessageBox.Show("Save DONE!");
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Save FAILED");
                    }
                }
                else if (txtTopLeft.Text.Trim() != "" && txtTopRight.Text.Trim() == "")
                {
                    content += "," + txtTopLeft.Text.Trim() + "," + txtTopLeft.Text.Trim() + "," + txtTopRight.Text.Trim();
                    //if (newFS.Update() == 1)
                    if (ContinuousFuzzySetBLL.UpdateFS(path, content, name) == 1)
                    {
                        XtraMessageBox.Show("Save DONE!");
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Save FAILED");
                    }
                }
                else
                {

                    content += "," + txtTopLeft.Text.Trim() + "," + txtTopRight.Text.Trim() + "," + txtBotRight.Text.Trim();
                    //if (newFS.Update() == 1)
                    if (ContinuousFuzzySetBLL.UpdateFS(path, content, name) == 1)
                    {
                        XtraMessageBox.Show("Save DONE!");
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Save FAILED");
                    }
                }
            }
            
        }

        private void FrmAddContinuousFuzzySet_Load(object sender, EventArgs e)
        {
            ResetGridView();
        }
    }
}