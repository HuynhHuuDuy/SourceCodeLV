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
    public partial class FrmInputType : DevExpress.XtraEditors.XtraForm
    {
        #region Properties

        private char[] SpecialCharacter = new char[] { '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '`', ';', ',', '<', '>', '?', '/', ':', '\"', '\'', '=', '{', '}', '[', ']', '\\', '|' };
        public string specialcharacter { get; set; }
        public FProDataTypeBLL dataType = new FProDataTypeBLL();
        public string valueType = "";

        #endregion
        public FrmInputType()
        {
            InitializeComponent();
        }
        private string SetDomain(string S) //Gán trường giá trị cho các kiểu
        {
            switch (S)
            {
                case "Int16": return "[-32768  ...  32767]";
                case "Int32": return "[-2147483648  ...  2147483647]";
                case "Int64": return " [-9223372036854775808  ...  9223372036854775807]";
                case "Byte": return "[0  ...  255]";
                case "String": return "[0  ...  32767] characters";
                case "Single": return "[1.5 x 10^-45  ...  3.4 x 10^38]";
                case "Double": return "[5.0 x 10^-324  ...  1.7 x 10^308]";
                case "Boolean": return "true  /  false";
                case "Decimal": return "[1.0 x 10^-28  ...  7.9 x 10^28]";
                case "DateTime": return "[01/01/0001 C.E  ...  31/12/9999 A.D]";
                case "Binary": return "[1  ...  8000] bytes";
                case "Currency": return "[-2^-63  ...  2^63 - 1]";
                case "DiscreteFuzzySet": return "[0  ...  32767] characters";
                case "ContinuousFuzzySet": return "[0  ...  32767] characters";
            }
            return "";
        }
        public FrmInputType(string dataType, string domainString)
        {
            // TODO: Complete member initialization
            InitializeComponent();

            if (SetDomain(dataType) == "")
            {
                this.dataType.DomainString = domainString;
                this.dataType.TypeName = "UserDefined";
                this.dataType.DataType = dataType;
                this.dataType.GetDomain(domainString);
                this.valueType = dataType;
            }
            else
                this.valueType = dataType;
        }

        private void FrmInputType_Load(object sender, EventArgs e)
        {
            ComboBox_DataType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            if (valueType == "")
            {
                ComboBox_DataType.SelectedIndex = ComboBox_DataType.Properties.Items.IndexOf("Int16");
            }
            else
            {
                if (ComboBox_DataType.Properties.Items.Contains(valueType))
                {
                    ComboBox_DataType.SelectedIndex = ComboBox_DataType.Properties.Items.IndexOf(valueType);
                }
                else
                {
                    ComboBox_DataType.SelectedIndex = ComboBox_DataType.Properties.Items.IndexOf("UserDefined");
                    memoEditListValue.Lines = this.dataType.DomainValues.ToArray();
                    txtTypeName.Text = this.dataType.DataType;
                }
            }
            specialcharacter = "";
            for (int i = 0; i < SpecialCharacter.Length; i++)
                specialcharacter += SpecialCharacter[i];
        }

        private void ComboBox_DataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_DataType.SelectedIndex == ComboBox_DataType.Properties.Items.Count - 1)
            {
                memoEditListValue.Enabled = true;
                memoEditListValue.ReadOnly = false;
                lblTypeName.Enabled = true;
                txtTypeName.ReadOnly = false;
                txtTypeName.Enabled = true;
                lblListValueType.Enabled = true;
                txtTypeName.Focus();
            }
            else
            {
                memoEditListValue.Enabled = false;
                memoEditListValue.ReadOnly = true;
                lblTypeName.Enabled = false;
                txtTypeName.ReadOnly = true;
                txtTypeName.Enabled = false;
                lblListValueType.Enabled = false;
            }
        }

        private void memoEditListValue_Leave(object sender, EventArgs e)
        {
            memoEditListValue.Lines = (from c in memoEditListValue.Lines
                                  select c.ToUpper()).ToArray();
            memoEditListValue.Lines = memoEditListValue.Lines.Distinct().ToArray(); 
        }

        private void btCancelSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void memoEditListValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int start = memoEditListValue.SelectionStart;
                string CharInput = memoEditListValue.Text[start - 1].ToString();

                if (specialcharacter.Contains(CharInput))
                {
                    dxErrorProvidertxtList.SetError(memoEditListValue, String.Format("Do not input the special character '{0}'", CharInput));
                    memoEditListValue.Text = memoEditListValue.Text.Remove(start - 1, 1);
                    memoEditListValue.SelectionStart = start;
                }
                else
                    dxErrorProvidertxtList.SetError(memoEditListValue, null);

            }
            catch
            {

            }
        }
        private string Stdize(string S) //Standardize String
        {
            // Chuẩn hóa chuỗi cắt bỏ các dấu , dư thừa
            string R = "";
            int i = 0;
            while (S[i] == ',') i++;
            int k = S.Length - 1;
            while (S[k] == ',') k--;
            for (int j = i; j <= k; j++)
                if (S[j] != ',') R += S[j];
                else if (S[j - 1] != ',') R += S[j] + " ";
            return R;
        }
        private void btOkSelect_Click(object sender, EventArgs e)
        {
            if (ComboBox_DataType.SelectedIndex != -1)
            {
                if (txtTypeName.Enabled == true)
                {
                    if (txtTypeName.Text.Trim() == "")
                    {
                        dxErrorProvidertxtList.SetError(txtTypeName, "You have not entered type name and value type");
                        return;
                    }
                    dxErrorProvidertxtList.SetError(txtTypeName, null);
                    if (memoEditListValue.Text.Trim() == "")
                    {
                        dxErrorProvidertxtList.SetError(memoEditListValue, "You have not entered a value type");
                        return;
                    }
                    dxErrorProvidertxtList.SetError(memoEditListValue, null);
                    dataType.TypeName = txtTypeName.Text;
                    dataType.DataType = ComboBox_DataType.Properties.Items[ComboBox_DataType.SelectedIndex].ToString();
                    dataType.DomainString = String.Format("{{{0}}}", Stdize(memoEditListValue.Text.Replace(Environment.NewLine, ",")));
                }
                else
                {
                    dataType.TypeName = "";
                    dataType.DataType = ComboBox_DataType.Properties.Items[ComboBox_DataType.SelectedIndex].ToString();
                    dataType.DomainString = SetDomain(dataType.DataType);
                }
                this.Close();
            }
        }
    }
}