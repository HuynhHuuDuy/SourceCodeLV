using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPRDB.BLL
{
    public class FProbTripleBLL
    {
        private List<object> value;
        private List<double> minProb;
        private List<double> maxProb;
        public List<object> Value
        {
          get { return this.value; }
          set { this.value = value; }
        }
        public List<double> MinProb
        {
          get { return minProb; }
          set { minProb = value; }
        }
        public List<double> MaxProb
        {
          get { return maxProb; }
          set { maxProb = value; }
        }
       public FProbTripleBLL()
       {
           this.value=new List<object>();
           this.minProb=new List<double>();
           this.maxProb=new List<double>();
       }
       public FProbTripleBLL(FProbTripleBLL triple)
       {
           this.value=new List<object>();
           this.minProb=new List<double>();
           this.maxProb=new List<double>();
           foreach (var item in triple.value)
            {
                this.value.Add(item);
            }

            foreach (double item in triple.minProb)
            {
                this.minProb.Add(item);
            }

            foreach (double item in triple.maxProb)
            {
                this.maxProb.Add(item);
            }
       }
        // Tạo bộ ba xác suất từ chuỗi text
       public FProbTripleBLL(string V)
       {
           try
           {
               this.value = new List<object>();
               this.minProb = new List<double>();
               this.maxProb = new List<double>();

               if (!V.Contains("||") && !V.Contains("{") && !V.Contains("}") && !V.Contains("[") && !V.Contains("]") )
               {
                   V = String.Format("{{{0}}}[ 1, 1]", V);
               }
                
               string[] seperator = { "||" };
               string[] val = V.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

               int j1, j2, j3, j4, j5;
               for (int i = 0; i < val.Length; i++)
               {
                   j1 = val[i].IndexOf('{');
                   j2 = val[i].IndexOf('}');
                   j3 = val[i].IndexOf('[');
                   j4 = val[i].IndexOf(',');
                   j5 = val[i].IndexOf(']');
                   value.Add(val[i].Substring(j1 + 1, j2 - j1 - 1));
                   minProb.Add(Convert.ToDouble(val[i].Substring(j3 + 1, j4 - j3 - 1)));
                   maxProb.Add(Convert.ToDouble(val[i].Substring(j4 + 1, j5 - j4 - 1)));
               }
          }
           catch
           {}
        }
       // Xuất bộ ba xác suất ra chuỗi giá trị
       public string GetStrValue()
       {
           string strValue = "";
           int n = Value.Count;

           for (int i = 0; i < Value.Count; i++)
           {
               strValue += "{ ";
               strValue += Value[i].ToString().Trim();
               strValue += " }";
               strValue += "[ ";
               strValue += MinProb[i];
               strValue += ", ";
               strValue += MaxProb[i];
               strValue += " ]";
               strValue += "  ||  ";
           }
           if (strValue != "")
               strValue = strValue.Remove(strValue.Length - 6); // loại bỏ kí tự '||' thừa

           return strValue;
       }
       internal bool isProbTripleValue(string Value)
       {
           //  Value = Value.Replace(" ", "");
           if (!Value.Contains("||") && !Value.Contains("{") && !Value.Contains("}") && !Value.Contains("[") && !Value.Contains("]"))
           {
               Value = String.Format("{{{0}}}[ 1, 1]", Value);
           }


           string[] seperator = { "||" };
           string[] value = Value.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

           int j1, j2, j3, j4, j5;
           double sumMinProb = 0.0;

           for (int i = 0; i < value.Length; i++)
           {
               j1 = value[i].IndexOf('{');
               j2 = value[i].IndexOf('}');
               j3 = value[i].IndexOf('[');
               j4 = value[i].IndexOf(',');
               j5 = value[i].IndexOf(']');
               if (j1 < 0 || j2 < 0 || j3 < 0 || j4 < 0 || j5 < 0) return false;
               if (j1 >= j2 - 1) return false;
               if (j2 >= j3) return false;
               if (j3 >= j4 - 1) return false;
               if (j4 >= j5 - 1) return false;


               try
               {
                   double minProb = Double.Parse((value[i].Substring(j3 + 1, j4 - j3 - 1)));
                   double maxProb = Double.Parse((value[i].Substring(j4 + 1, j5 - j4 - 1)));

                   if (maxProb > 1)
                       return false;

                   if (minProb > maxProb)
                       return false;
                   sumMinProb += minProb;

               }
               catch (Exception)
               {
                   return false;
               }

           }

           if (sumMinProb > 1.0)
               return false;

           return true;
       }
       internal bool isProbTriple(string min, string max)
       {
           try
           {
               double minProb = Double.Parse(min);
               double maxProb = Double.Parse(max);

               if (maxProb > 1)
                   return false;

               if (minProb > maxProb)
                   return false;

           }
           catch (Exception)
           {
               return false;
           }


           return true;
       }
       internal bool UniformDistribution()
       {

           for (int i = 0; i < this.minProb.Count - 1; i++)
           {
               if (this.minProb[i] != this.minProb[i + 1])
                   return false;
               if (this.maxProb[i] != this.maxProb[i + 1])
                   return false;
           }

           return true;
       }
    }
}
