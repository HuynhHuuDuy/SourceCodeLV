using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace FPRDB.BLL
{
    public class FProDataTypeBLL
    {
        private string typeName;
        private string dataType;
        private string domainString;
        private List<string> domainValues;
        public string TypeName
        {
          get { return typeName; }
          set { typeName = value; }
        }
        public string DataType
        {
          get { return dataType; }
          set { dataType = value; }
        }
        public string DomainString
        {
          get { return domainString; }
          set { domainString = value; }
        }
        public List<string> DomainValues
        {
          get { return domainValues; }
          set { domainValues = value; }
        }
        public FProDataTypeBLL()
        {
            this.typeName = "No Name";
            this.dataType = "No Type";
            this.domainString = "No Domain String";
            this.domainValues = new List<string>();
         }
        public FProDataTypeBLL(FProDataTypeBLL fproDataType)
        {
            this.typeName = fproDataType.typeName;
            this.dataType = fproDataType.dataType;
            this.domainString = fproDataType.domainString;
            this.domainValues = new List<string>();

            foreach (string item in fproDataType.domainValues)
            {
                this.domainValues.Add(item);
            }
        }
        public void GetDomain(string str)
        {
            try
            {
                this.DomainString = str;
                if (this.typeName == "UserDefined")
                {
                    str = str.Replace("{", "");
                    str = str.Replace("}", "");
                    char[] seperator = { ',' };
                    string[] temp = str.Split(seperator);
                    this.domainValues = new List<string>();
                    foreach (string value in temp)
                        this.domainValues.Add(value.Trim());
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        // Lấy DataType từ TypeName
        public void GetDataType()
        {
            try
            {
                this.dataType = "UserDefined";

                switch (this.typeName)
                {
                    case "Int16": this.dataType = "Int16"; break;
                    case "Int64": this.dataType = "Int64"; break;
                    case "Int32": this.dataType = "Int32"; break;
                    case "Byte": this.dataType = "Byte"; break;
                    case "Decimal": this.dataType = "Decimal"; break;
                    case "Currency": this.dataType = "Currency"; break;
                    case "String": this.dataType = "String"; break;
                    case "DateTime": this.dataType = "DateTime"; break;
                    case "Binary": this.dataType = "Binary"; break;
                    case "Single": this.dataType = "Single"; break;
                    case "Double": this.dataType = "Double"; break;
                    case "Boolean": this.dataType = "Boolean"; break;
                    case "DiscreteFuzzySet": this.dataType = "String"; break;
                    case "ContinuousFuzzySet": this.dataType = "String"; break;
                    default: break;
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
            }
        }
        internal string getDefaultValue()
        {
            this.GetDataType();

            switch (this.dataType)
            {
                case "Int16":
                case "Int32":
                case "Int64":
                case "Byte": return "{ 0 }[ 0,0]";
                case "String": return "{ Empty }[ 0,0]";
                case "DateTime": return String.Format("{{ {0} }}[ 0,0]", DateTime.MinValue);
                case "Decimal": return "{ 0.0 }[ 0,0]";
                case "Single": return "{ 0 }[ 0,0]";
                case "Double": return "{ 0.0 }[ 0,0]";
                case "Boolean": return "{ false }[ 0,1]";
                case "Binary": return "{ 0 }[ 0,0]";
                case "Currency": return "{ 0.0 }[ 0,0]";
                case "DiscreteFuzzySet": return "{ Empty }[ 0,0]";
                case "ContinuousFuzzySet": return "{ Empty }[ 0,0]";
                case "UserDefined":
                    this.TypeName = "UserDefined";
                    GetDomain(DomainString);
                    return String.Format("{{ {0} }}[ 0, 0]", this.domainValues[0]);
                default: return "{ 0 }[ 0,0]";

            }
        }
        private static bool isBinaryType(object V)
        {
            try
            {
                foreach (char i in V.ToString())
                    if (i != '0' && i != '1')
                        return false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return true;
        }

        private static bool isCurrencyType(object V)
        {
            try
            {
                const double MINCURRENCY = 1.0842021724855044340074528008699e-19;
                const double MAXCURRENCY = 9223372036854775807.0;
                double temp = Convert.ToDouble(V);
                if (temp - MINCURRENCY >= 0)
                    if (temp - MAXCURRENCY <= 0)
                        return true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return false;
        }
        public bool CheckDomain(string value)
        {
            string tmp = this.domainString;

            tmp = tmp.Replace("{", "");
            tmp = tmp.Replace("}", "");
            char[] seperator = { ',' };
            string[] temp = tmp.Split(seperator);
            this.domainValues = new List<string>();
            foreach (string v in temp)
                this.domainValues.Add(v.Trim().ToLower());
            return this.domainValues.Contains(value.ToLower());

        }
        public bool CheckDataType(string V)
        {
            try
            {

                List<object> values = new List<object>();
                this.GetDataType();

                if (this.DataType != "String")
                {
                    V = V.Replace(" ", "");
                }
                int j1, j2;
                j1 = V.IndexOf('{');
                j2 = V.IndexOf('}');
                V = V.Substring(j1 + 1, j2 - j1 - 1).Trim();
                string[] seperator = { "," };
                string[] temp = V.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < temp.Length; i++)
                {
                    values.Add(temp[i].Trim());
                }

                foreach (object value in values)
                {
                    switch (this.DataType)
                    {
                        case "Int16": Convert.ToInt16(value); break;
                        case "Int32": Convert.ToInt32(value); break;
                        case "Int64": Convert.ToInt64(value); break;
                        case "Byte": Convert.ToByte(value); break;
                        case "String": Convert.ToString(value); break;
                        case "DateTime": Convert.ToDateTime(value); break;
                        case "Decimal": Convert.ToDecimal(value); break;
                        case "Single": Convert.ToSingle(value); break;
                        case "Double": Convert.ToDouble(value); break;
                        case "Boolean": Convert.ToBoolean(value); break;
                        case "DiscreteFuzzySet": Convert.ToString(value); break;
                        case "ContinuousFuzzySet": Convert.ToString(value); break;
                        case "Binary": return (isBinaryType(value));
                        case "Currency": return (isCurrencyType(value));
                        case "UserDefined":
                            return CheckDomain(value.ToString().Trim());
                        default: break;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool IsDataType(string value, string datatype)
        {
            try
            {
                switch (datatype)
                {
                    case "Int16": Convert.ToInt16(value); break;
                    case "Int32": Convert.ToInt32(value); break;
                    case "Int64": Convert.ToInt64(value); break;
                    case "Byte": Convert.ToByte(value); break;
                    case "String": Convert.ToString(value); break;
                    case "DateTime": Convert.ToDateTime(value); break;
                    case "Decimal": Convert.ToDecimal(value); break;
                    case "Single": Convert.ToSingle(value); break;
                    case "Double": Convert.ToDouble(value); break;
                    case "Boolean": Convert.ToBoolean(value); break;
                    case "DiscreteFuzzySet": Convert.ToString(value); break;
                    case "ContinuousFuzzySet": Convert.ToString(value); break;
                    case "Binary": return (isBinaryType(value));
                    case "Currency": return (isCurrencyType(value));
                    case "UserDefined":

                        return CheckDomain(value.ToString().Trim());
                    default: break;

                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool CheckDataTypeOfVariables(string value)
        {
            try
            {
                this.GetDataType();
                switch (this.DataType)
                {
                    case "Int16": Convert.ToInt16(value); break;
                    case "Int32": Convert.ToInt32(value); break;
                    case "Int64": Convert.ToInt64(value); break;
                    case "Byte": Convert.ToByte(value); break;
                    case "String": Convert.ToString(value); break;
                    case "DateTime": Convert.ToDateTime(value); break;
                    case "Decimal": Convert.ToDecimal(value); break;
                    case "Single": Convert.ToSingle(value); break;
                    case "Double": Convert.ToDouble(value); break;
                    case "Boolean": Convert.ToBoolean(value); break;
                    case "DiscreteFuzzySet": Convert.ToString(value); break;
                    case "ContinuousFuzzySet": Convert.ToString(value); break;
                    case "Binary": return (isBinaryType(value));
                    case "Currency": return (isCurrencyType(value));
                    case "UserDefined":
                        return CheckDomain(value.ToString().Trim());
                    default: break;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
