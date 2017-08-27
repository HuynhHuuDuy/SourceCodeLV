using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class SelectConditionBLL
    {
        public FProbRelationBLL relations { get; set; }
        public FProbTupleBLL tuple { get; set; }
        public string conditionString { get; set; }
        static public string[] Operator = new string[19] { "_<", "_>", "<=", ">=", "_=", "!=", "→", "⊗_in", "⊗_ig", "⊗_me", "⊕_in", "⊕_ig", "⊕_me", "⊖_in", "⊖_ig", "⊖_me", "equal_in", "equal_ig", "equal_me" };
        private readonly List<FProbAttributeBLL> Attributes = new List<FProbAttributeBLL>();
        public SelectConditionBLL(FProbRelationBLL probRelation, string conditionString)
        {
            // TODO: Complete member initialization
            relations = probRelation;


            int i = 0;
            while (i < conditionString.Length - 1)
            {
                if (conditionString[i] == '<' && conditionString[i + 1] != '=')
                    conditionString = conditionString.Insert(i++, "_");
                if (conditionString[i] == '>' && conditionString[i + 1] != '=')
                    conditionString = conditionString.Insert(i++, "_");
                if (conditionString[i] == '=' && conditionString[i - 1] != '!' && conditionString[i - 1] != '<' && conditionString[i - 1] != '>')
                    conditionString = conditionString.Insert(i++, "_");
                i++;
            }
            this.conditionString = conditionString.Trim();
            this.Attributes = probRelation.FproSchema.FproAttributes;
            this.MessageError = string.Empty;
        }
        public string MessageError { get; set; }
        private static bool EqualDisFS(object one, object two)
        {
            if (one.ToString().Trim() == two.ToString().Trim())
            {
                return true;
            }
            else
            {
                DiscreteFuzzySetBLL disfs1 = DiscreteFuzzySetBLL.GetByName(one.ToString().Trim());
                DiscreteFuzzySetBLL disfs2 = DiscreteFuzzySetBLL.GetByName(two.ToString().Trim());
                if (disfs1 == null || disfs2 == null)
                {
                    return false;
                }
                else
                {
                    List<Double> h1 = disfs1.getXsForMembership(1.0);
                    List<Double> h2 = disfs2.getXsForMembership(1.0);
                    for (int i = 0; i < h1.Count; i++)
                    {
                        for (int j = 0; j < h2.Count; j++)
                            if (h1[i] == h2[j])
                                return true;
                    }
                    return false;
                }
            }
        }
        private static bool EqualContFS(object one, object two)
        {
            if (one.ToString().Trim() == two.ToString().Trim())
            {
                return true;
            }
            else
            {
                ContinuousFuzzySetBLL contfs1 = new ContinuousFuzzySetBLL().GetContinuousFuzzySetByName(one.ToString().Trim());
                ContinuousFuzzySetBLL contfs2 = new ContinuousFuzzySetBLL().GetContinuousFuzzySetByName(two.ToString().Trim());
                if (contfs1 == null || contfs2 == null)
                {
                    return false;
                }
                else
                {
                    if (contfs1.TopRight <= contfs2.TopRight && contfs1.TopRight >= contfs2.TopLeft)
                        return true;
                    else
                    {
                        if (contfs2.TopRight >= contfs1.TopLeft && contfs2.TopRight <= contfs1.TopRight)
                            return true;
                        return false;
                    }
                }
            }
        }
        public static bool EQUAL(object a, object b, string type)
        {
            switch (type)
            {
                case "Int16":
                case "Int64":
                case "Int32":
                case "Byte":
                case "Currency": return int.Parse(a.ToString()) == int.Parse(b.ToString());
                case "String": return (a.ToString().CompareTo(b.ToString()) == 0);
                case "DiscreteFuzzySet": return EqualDisFS(a, b);
                case "ContinuousFuzzySet": return EqualContFS(a, b);
                case "DateTime":
                case "UserDefined":
                case "Binary": return (a.ToString().CompareTo(b.ToString()) == 0);
                case "Decimal":
                case "Single":
                case "Double": return (Math.Abs((double)a - (double)b) < 0.001);
                case "Boolean": return Boolean.Parse(a.ToString()) == Boolean.Parse(b.ToString());
                default: return false;
            }
        }
        public bool CheckConditionString()
        {
            string str = this.conditionString.ToLower();
            int indexI = 0;

            str = str.Trim();

            if (!str.Contains('(') || !str.Contains(')') || !str.Contains('[') || !str.Contains(']'))
            {
                MessageError = "Incorrect syntax near the keyword 'where'.";
                return false;
            }

            if (str[0] != '(')
            {
                MessageError = "Incorrect syntax near the keyword 'where'.";
                return false;
            }

            if (str[str.Length - 1] != ']')
            {
                MessageError = "Incorrect syntax near the keyword 'where'.";
                return false;
            }

            while (indexI < str.Length - 1)
            {
                if (str[indexI] == '(')
                {
                    int indexJ = indexI + 1;
                    while (indexJ < str.Length)
                    {
                        if (str[indexJ] == '(' || str[indexJ] == '[' || str[indexJ] == ']')
                        {
                            MessageError = "Incorrect syntax near the keyword 'where'.";
                            return false;
                        }
                        if (str[indexJ] == ')')
                            break;
                        indexJ++;
                    }
                    if (indexJ == str.Length)
                    {
                        MessageError = "Incorrect syntax near the keyword 'where'.";
                        return false;
                    }
                }

                if (str[indexI] == '[')
                {
                    int indexJ = indexI + 1;

                    while (indexJ < str.Length)
                    {
                        if (str[indexJ] == '(' || str[indexJ] == '[' || str[indexJ] == ')')
                        {
                            MessageError = "Incorrect syntax near the keyword 'where'.";
                            return false;
                        }
                        if (str[indexJ] == ']')
                            break;
                        indexJ++;
                    }

                    if (indexJ == str.Length)
                    {
                        MessageError = "Incorrect syntax near the keyword 'where'.";
                        return false;
                    }
                }

                if (str[indexI] == '(' && str[indexI + 1] == '(')
                {
                    MessageError = "Incorrect syntax near the keyword 'where'.";
                    return false;
                }
                if (str[indexI] == ')' && str[indexI + 1] == ')')
                {
                    MessageError = "Incorrect syntax near the keyword 'where'.";
                    return false;
                }
                if (str[indexI] == '[' && str[indexI + 1] == '[')
                {
                    MessageError = "Incorrect syntax near the keyword 'where'.";
                    return false;
                }
                if (str[indexI] == ']' && str[indexI + 1] == ']')
                {
                    MessageError = "Incorrect syntax near the keyword 'where'.";
                    return false;
                }

                indexI++;
            }
            return true;
        }
        private static List<double> convertConditionStringToProbInterVal(string S)
        {
            List<double> interval = new List<double>();
            try
            {
                // Get Probabilistic Interval
                int j1 = S.IndexOf('[') + 1, j2 = S.IndexOf(']') - 1;
                string StrInterval = S.Substring(j1, j2 - j1 + 1);// lấy khoảng xác suất
                S = S.Replace(String.Format("[{0}]", StrInterval), "");
                StrInterval = StrInterval.Replace(" ", "");
                string[] StrProb = StrInterval.Split(',');
                double _MinProb = Convert.ToDouble(StrProb[0]);
                double _MaxProb = Convert.ToDouble(StrProb[1]);
                interval.Add(Convert.ToDouble(_MinProb));
                interval.Add(Convert.ToDouble(_MaxProb));
                return interval;

            }
            catch
            {
                return null;
            }
        }
        public static bool isCompareOperator(string S)
        {
            for (int i = 0; i < 7; i++)
                if (Operator[i].CompareTo(S) == 0)
                    return true;
            return false;
        }
        private bool IsSelectionExpression(string conditionString)
        {

            if (conditionString.Contains(" and ") || conditionString.Contains(" or ") || conditionString.Contains(" not "))
                return false;

            string str = conditionString.Substring(conditionString.IndexOf("(") + 1, conditionString.IndexOf(")") - 1);
            if (str == string.Empty || str.Contains("(") || str.Contains(")"))
                return false;

            if (convertConditionStringToProbInterVal(conditionString) == null)
                return false;

            List<string> arrayStr = new List<string>();

            if (str.Contains("'"))
            {
                int index = -1;
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == ' ' && str[i + 1] == '\'')
                    {
                        index = i + 1;
                        break;
                    }
                }

                if (index != -1)
                {
                    string tmp = str.Substring(index, str.Length - index);
                    str = str.Substring(0, index - 1);
                    arrayStr.AddRange(str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    arrayStr.Add(tmp);
                }
                else
                {
                    arrayStr.AddRange(str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    int k = 0;
                    for (int i = 0; i < arrayStr.Count; i++)
                    {
                        if (isCompareOperator(arrayStr[i]))
                        {
                            k = i + 1;
                            break;
                        }
                    }

                    string valueError = "";
                    for (int i = k; i < arrayStr.Count; i++)
                    {
                        valueError += arrayStr[i] + " ";
                    }

                    MessageError = "Unclosed quotation mark before the character string " + valueError;
                    return false;
                }
            }
            else
            {
                arrayStr.AddRange(str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }

            for (int i = 1; i < arrayStr.Count - 1; i++)
            {
                if (Operator.Contains(arrayStr[i]) && (Operator.Contains(arrayStr[i - 1]) || Operator.Contains(arrayStr[i + 1])))
                {
                    MessageError = "Incorrect syntax near the keyword 'where'.";
                    return false;
                }

                if (!Operator.Contains(arrayStr[i]) && (!Operator.Contains(arrayStr[i - 1]) || !Operator.Contains(arrayStr[i + 1])))
                {
                    MessageError = "Incorrect syntax near the keyword 'where'.";
                    return false;
                }
            }
            return true;
        }
        private static string converConditionStringToExpression(string conditionString)
        {
            try
            {
                return conditionString.Substring(conditionString.IndexOf("("), conditionString.IndexOf(")") - conditionString.IndexOf("(") + 1);
            }
            catch
            {
                return string.Empty;
            }
        }
        private static string AddSeperateCharacter(string Str)
        {
            // Thêm vào các kí tự phân cách
            Str = Str.Replace("(", "|(|");
            Str = Str.Replace(")", "|)|");
            Str = Str.Replace("_<", "|_<|");
            Str = Str.Replace("_>", "|_>|");
            Str = Str.Replace("<=", "|<=|");
            Str = Str.Replace(">=", "|>=|");
            Str = Str.Replace("_=", "|_=|");
            Str = Str.Replace("!=", "|!=|");
            Str = Str.Replace("⊗_in", "|⊗_in|");
            Str = Str.Replace("⊗_ig", "|⊗_ig|");
            Str = Str.Replace("⊗_me", "|⊗_me|");
            Str = Str.Replace("⊕_in", "|⊕_in|");
            Str = Str.Replace("⊕_ig", "|⊕_ig|");
            Str = Str.Replace("⊕_me", "|⊕_me|");
            Str = Str.Replace("⊖_in", "|⊖_in|");
            Str = Str.Replace("⊖_ig", "|⊖_ig|");
            Str = Str.Replace("⊖_me", "|⊖_me|");
            Str = Str.Replace("equal_in", "|equal_in|");
            Str = Str.Replace("equal_ig", "|equal_ig|");
            Str = Str.Replace("equal_me", "|equal_me|");
            Str = Str.Replace("→", "|→|");

            while (Str[0] == '|') Str = Str.Remove(0, 1);

            int i;
            for (i = Str.Length; i >= 0; i--)
                if (Str[i - 1] != '|')
                    break;


            if (i < Str.Length)
                Str = Str.Remove(i);

            i = 0;
            while (i < Str.Length - 1)
            {
                if (Str[i] == ' ' && (Str[i + 1] == '|' || Str[i - 1] == '|'))
                    Str = Str.Remove(i, 1);
                i++;
            }
            return Str;
        }
        private static int Priority(string Str)
        {
            switch (Str)
            {
                case "_<":
                case "_>":
                case "<=":
                case ">=":
                case "_=":
                case "!=":
                case "→":
                case "equal_ig":
                case "equal_in":
                case "equal_me": return 3;
                case "⊖_ig":
                case "⊖_in":
                case "⊖_me":
                case "⊗_ig":
                case "⊗_in":
                case "⊗_me":
                case "⊕_in":
                case "⊕_ig":
                case "⊕_me": return 2;
                case "|":
                case "&": return 2;
                case "!": return 3;
                default: return 0;
            }
        }
        private static List<string> SE_PostfixNotation(string Str)
        {
            List<string> O = new List<string>();  // Stack
            List<string> V = new List<string>();
            string[] array = AddSeperateCharacter(Str).Split('|');

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo("(") == 0)
                    O.Add(array[i]);
                else
                    if (array[i].CompareTo(")") == 0)
                    {
                        while (O.Count > 0 && O[O.Count - 1].CompareTo("(") != 0)
                        {
                            V.Add(O[O.Count - 1]);     // V.Add(" " + O[O.Count - 1] + " ");
                            O.RemoveAt(O.Count - 1);
                        }
                        O.RemoveAt(O.Count - 1);      // remove '('
                    }
                    else
                        if (Operator.Contains(array[i]))        // nếu là operator
                        {
                            while (O.Count > 0 && Priority(O[O.Count - 1]) >= Priority(array[i]))
                            {
                                V.Add(O[O.Count - 1]);        // V.Add(" " + O[O.Count - 1] + " ");
                                O.RemoveAt(O.Count - 1);
                            }
                            O.Add(array[i]);
                        }
                        else
                            V.Add(array[i]);           // nếu là value
            }

            while (O.Count > 0)      // Sau khi kết thúc, lấy toàn bộ giá trị trong stack đưa vào V
            {
                V.Add(O[O.Count - 1]);
                O.RemoveAt(O.Count - 1);
            }
            return V;
        }
        public int IndexOf(string S)
        {
            string value = S.Trim().ToLower();
            int indexAttributeS = -1;
            if (value.IndexOf(".") != -1)
            {
                string[] arr = value.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                foreach (string item in this.relations.ListRenameRelation)
                {
                    if (item != arr[0])
                        count++;
                }
                if (count == 2)
                {
                    MessageError = String.Format("The multi-part identifier {0} could not be bound.", value);
                    return -1;
                }


                for (int i = 0; i < Attributes.Count; i++)
                {
                    if (value == Attributes[i].AttributeName.ToLower())
                    {
                        return i;
                    }
                }

                MessageError = String.Format("Invalid attribute name '{0}'.", arr[1]);
                return -1;

            }
            else
            {
                int count = 0;
                for (int i = 0; i < Attributes.Count; i++)
                {
                    string[] arr = Attributes[i].AttributeName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    if (value == arr[1].ToLower().Trim())
                    {
                        count++;
                        indexAttributeS = i;
                    }
                }

                if (count >= 2)
                {
                    MessageError = String.Format("Ambiguous attribute name '{0}'.", value);
                    return -1;
                }
                if (count == 0)
                {
                    MessageError = String.Format("Invalid attribute name '{0}'.", value);
                    return -1;
                }

                return indexAttributeS;
            }

        }
        public static bool IntCompare(Int16 valueOne, Int16 valueTwo, string OpratorStr)
        {
            switch (OpratorStr)
            {
                case "_<": return (valueOne < valueTwo);
                case "_>": return (valueOne > valueTwo);
                case "<=": return (valueOne <= valueTwo);
                case ">=": return (valueOne >= valueTwo);
                case "_=": return (valueOne == valueTwo);
                case "!=": return (valueOne != valueTwo);
                default: return false;
            }
        }
        public static bool StrCompare(string valueOne, string valueTwo, string OpratorStr)
        {

            switch (OpratorStr)
            {
                case "_=": return (valueOne.ToLower().CompareTo(valueTwo.ToLower()) == 0);
                case "!=": return (valueOne.ToLower().CompareTo(valueTwo) != 0);
                default: return false;
            }

        }
        public static bool DoubleCompare(double valueOne, double valueTwo, string OpratorStr)
        {
            switch (OpratorStr)
            {
                case "_<": return (valueOne < valueTwo);
                case "_>": return (valueOne > valueTwo);
                case "<=": return (valueOne <= valueTwo);
                case ">=": return (valueOne >= valueTwo);
                case "_=": return (Math.Abs(valueOne - valueTwo) < 0.001);
                case "!=": return (Math.Abs(valueOne - valueTwo) > 0.001);
                default: return false;
            }

        }
        public static bool BoolCompare(bool valueOne, bool valueTwo, string OpratorStr)
        {
            switch (OpratorStr)
            {
                case "_=": return (valueOne == valueTwo);
                case "!=": return (valueOne != valueTwo);
                default: return false;
            }

        }
        private static double CompareDisFS(object one, object two, string rel)
        {
            DiscreteFuzzySetBLL disfs1 = DiscreteFuzzySetBLL.GetByName(one.ToString().Trim());
            DiscreteFuzzySetBLL disfs2 = new DiscreteFuzzySetBLL(two.ToString().Trim());
            if (disfs2.CheckDiscFuzzySetByName(two.ToString().Trim()))
            {
                disfs2 = DiscreteFuzzySetBLL.GetByName(two.ToString().Trim());
            }
            else
            {
                if (!new FProDataTypeBLL().IsDataType(two.ToString().Trim(), "Double"))
                {
                    disfs2.FuzzySetName = two.ToString().Trim();
                    disfs2.ValueSet.Add(0);
                    disfs2.MembershipSet.Add(0);
                }
                else
                {
                    disfs2.FuzzySetName = two.ToString().Trim();
                    disfs2.ValueSet.Add(Double.Parse(two.ToString()));
                    disfs2.MembershipSet.Add(1);
                }
            }
            if (disfs1 == null || disfs2 == null)
            {
                return -1.0;
            }
            else
            {
                FuzzyInterpreter fuzzinter = new FuzzyInterpreter();
                double pro = fuzzinter.interpreteForDiscFS(disfs1, disfs2, rel);
                return pro;
            }
        }
        private static double CompareContFS(object one, object two, string rel)
        {
            ContinuousFuzzySetBLL contfs1 = new ContinuousFuzzySetBLL().GetContinuousFuzzySetByName(one.ToString().Trim());
            ContinuousFuzzySetBLL contfs2 = new ContinuousFuzzySetBLL(two.ToString());
            if (contfs2.CheckContinuousFuzzySetByName(two.ToString().Trim()))
            {
                contfs2 = new ContinuousFuzzySetBLL().GetContinuousFuzzySetByName(two.ToString().Trim());
            }
            else
            {
                if (!new FProDataTypeBLL().IsDataType(two.ToString().Trim(), "Double"))
                {
                    contfs2.FuzzySetName = two.ToString().Trim();
                    contfs2.SetValue(0, 0, 0, 0);
                }
                else
                {
                    contfs2.FuzzySetName = two.ToString().Trim();
                    double val = Convert.ToDouble(two.ToString());
                    contfs2.SetValue(val, val, val, val);
                }
            }
            if (contfs1 == null || contfs2 == null)
            {
                return -1.0;
            }
            else
            {
                FuzzyInterpreter fuzzinter = new FuzzyInterpreter();
                double pro = fuzzinter.interpreteForContFS(contfs1, contfs2, rel);
                return pro;
            }
        }
        public double CompareTriple(object valueOne, string valueTwo, string opratorStr, string typename)
        {
            switch (typename)
            {
                case "Int16":
                case "Int64":
                case "Int32":
                case "Byte":
                case "Currency":
                    return (IntCompare(Convert.ToInt16(valueOne), Convert.ToInt16(valueTwo), opratorStr) ? 1.0 : 0.0);
                case "String":
                case "DateTime":
                case "UserDefined":
                case "Binary":
                    return (StrCompare(valueOne.ToString(), valueTwo, opratorStr) ? 1.0 : 0.0);
                case "Decimal":
                case "Single":
                case "Double":
                    return (DoubleCompare((double)valueOne, Convert.ToDouble(valueTwo), opratorStr) ? 1.0 : 0.0);
                case "Boolean":
                    return (BoolCompare((bool)valueOne, Convert.ToBoolean(valueTwo), opratorStr) ? 1.0 : 0.0);
                case "DiscreteFuzzySet": return CompareDisFS(valueOne, valueTwo, opratorStr);
                case "ContinuousFuzzySet": return CompareContFS(valueOne, valueTwo, opratorStr);

                default: return 0.0;
            }

        }

        /// <summary>
        /// Important! Calculate prob query expression, prob data from database
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <param name="operaterStr"></param>
        /// <returns></returns>
        private string GetProbInterval(string valueOne, string valueTwo, string operaterStr)
        {
            double minProb = 0, maxProb = 0;
            int indexOne, indexTwo, countTripleOne, countTripleTwo;
            FProbTupleBLL tuple = this.tuple;
            string typenameOne;
            string typenameTwo;

            try
            {
                if (operaterStr.Contains("equal_ig") || operaterStr.Contains("equal_in") || operaterStr.Contains("equal_me"))         // Biểu thức so sánh bằng giữa hai thuộc tính trên cùng một bộ
                {


                    indexOne = IndexOf(valueOne);
                    indexTwo = IndexOf(valueTwo);
                    if (indexOne == -1 || indexTwo == -1)
                        return string.Empty;

                    countTripleOne = tuple.FproTriples[indexOne].Value.Count;
                    countTripleTwo = tuple.FproTriples[indexTwo].Value.Count;
                    typenameOne = Attributes[indexOne].FproDataType.TypeName;
                    typenameTwo = Attributes[indexTwo].FproDataType.TypeName;

                    if (typenameOne != typenameTwo)
                    {
                        //Attribute value does not match the data type !
                        MessageError = String.Format("Error :{0} and {1} must  the same data type", valueOne, valueTwo);
                        return string.Empty;
                    }

                    for (int i = 0; i < countTripleOne; i++)
                        for (int j = 0; j < countTripleTwo; j++)
                        {
                            double pro = 0.0;
                            pro = this.CompareTriple(tuple.FproTriples[indexOne].Value[i].ToString().Trim(), tuple.FproTriples[indexTwo].Value[j].ToString().Trim(), "_=", typenameOne);
                            //pro = EQUALTRIPPLE(tuple.Triples[indexOne].Value[i].ToString().Trim(), tuple.Triples[indexTwo].Value[j].ToString().Trim(), typenameOne);
                            if (((typenameOne == "ContinuousFuzzySet" || typenameOne == "DiscreteFuzzySet") && pro != -1) || ((typenameOne != "ContinuousFuzzySet" || typenameOne != "DiscreteFuzzySet") && pro != 0))
                                switch (operaterStr)
                                {
                                    case "equal_in":
                                        minProb += pro * tuple.FproTriples[indexOne].MinProb[i] * tuple.FproTriples[indexTwo].MinProb[j];
                                        maxProb = Math.Min(1, maxProb + (tuple.FproTriples[indexOne].MaxProb[i] * tuple.FproTriples[indexTwo].MaxProb[j] * pro));
                                        break;

                                    case "equal_ig":
                                        minProb += Math.Max(0, tuple.FproTriples[indexOne].MinProb[i] + tuple.FproTriples[indexTwo].MinProb[j] - 1) * pro;
                                        maxProb = Math.Min(1, maxProb + (Math.Min(tuple.FproTriples[indexOne].MaxProb[i], tuple.FproTriples[indexTwo].MaxProb[j])) * pro);
                                        break;
                                    case "equal_me":
                                        minProb = 0;
                                        maxProb = Math.Min(1, maxProb + 0);
                                        break;
                                    default: break;
                                }
                        }
                }
                else
                    if (SelectConditionBLL.isCompareOperator(operaterStr))     // Biểu thức so sánh giữa một thuộc tính với một giá trị
                    {
                        indexOne = this.IndexOf(valueOne); // vị trí của thuộc tính trong ds các thuộc tính
                        if (indexOne == -1)
                            return string.Empty;

                        if (valueTwo.Contains("'"))
                        {
                            int count = valueTwo.Split(new char[] { '\'' }).Length - 1;

                            if (valueTwo.Substring(0, 1) != "'")
                            {
                                MessageError = "Unclosed quotation mark before the character string " + valueTwo;
                                return string.Empty;
                            }

                            if (valueTwo.Substring(valueTwo.Length - 1, 1) != "'")
                            {
                                MessageError = "Unclosed quotation mark after the character string " + valueTwo;
                                return string.Empty;
                            }

                            if (count != 2)
                            {
                                MessageError = "Unclosed quotation mark at the character string " + valueTwo;
                                return string.Empty;
                            }

                            valueTwo = valueTwo.Remove(0, 1);
                            valueTwo = valueTwo.Remove(valueTwo.Length - 1, 1);

                        }

                        countTripleOne = tuple.FproTriples[indexOne].Value.Count; // số lượng các cặp xác xuất trong thuộc tính
                        typenameOne = Attributes[indexOne].FproDataType.TypeName;

                        FProDataTypeBLL dataType = new FProDataTypeBLL();
                        dataType.TypeName = Attributes[indexOne].FproDataType.TypeName;
                        dataType.DataType = Attributes[indexOne].FproDataType.DataType;
                        dataType.DomainValues = Attributes[indexOne].FproDataType.DomainValues;
                        dataType.DomainString = Attributes[indexOne].FproDataType.DomainString;

                        if (!dataType.CheckDataTypeOfVariables(valueTwo))
                        {
                            MessageError = String.Format("Conversion failed when converting the varchar value {0} to data type {1}.", valueTwo, typenameOne);
                            return string.Empty;
                        }
                        else
                        {
                            if (dataType.TypeName == "ContinuousFuzzySet" || dataType.TypeName == "DiscreteFuzzySet")
                            {
                                for (int i = 0; i < countTripleOne; i++)
                                {
                                    double pro = this.CompareTriple(tuple.FproTriples[indexOne].Value[i].ToString().Trim(), valueTwo.Trim(), operaterStr, dataType.TypeName);
                                    if (pro != -1.0) // duyệt từng cặp xác xuất và so sánh
                                    {

                                        minProb += pro * tuple.FproTriples[indexOne].MinProb[i];
                                        maxProb += pro * tuple.FproTriples[indexOne].MaxProb[i];
                                    }
                                }

                            }
                            else
                            {
                                for (int i = 0; i < countTripleOne; i++)
                                {
                                    double pro = this.CompareTriple(tuple.FproTriples[indexOne].Value[i].ToString().Trim(), valueTwo.Trim(), operaterStr, dataType.TypeName);
                                    if (pro == 1.0) // duyệt từng cặp xác xuất và so sánh
                                    {

                                        minProb += tuple.FproTriples[indexOne].MinProb[i];
                                        maxProb += tuple.FproTriples[indexOne].MaxProb[i];
                                    }
                                }
                            }
                        }

                    }
                    else                     // Biểu thức kết hợp giữa hai khoảng xác suất
                    {
                        double minProbOne, minProbTwo, maxProbOne, maxProbTwo;
                        string[] StrProb;

                        valueOne = valueOne.Replace("[", "");  // [L,U]
                        valueOne = valueOne.Replace("]", "");

                        StrProb = valueOne.Split(',');
                        minProbOne = Convert.ToDouble(StrProb[0]);
                        maxProbOne = Convert.ToDouble(StrProb[1]);

                        valueTwo = valueTwo.Replace("[", "");  // [L,U]
                        valueTwo = valueTwo.Replace("]", "");

                        StrProb = valueTwo.Split(',');
                        minProbTwo = Convert.ToDouble(StrProb[0]);
                        maxProbTwo = Convert.ToDouble(StrProb[1]);

                        switch (operaterStr)
                        {
                            case "⊗_ig": minProb = Math.Max(0, minProbOne + minProbTwo - 1); maxProb = Math.Min(maxProbOne, maxProbTwo); break;
                            case "⊗_in": minProb = minProbOne * minProbTwo; maxProb = maxProbOne * maxProbTwo; break;
                            case "⊗_me": minProb = 0; maxProb = 0; break;
                            case "⊕_ig": minProb = Math.Max(minProbOne, minProbTwo); maxProb = Math.Min(1, maxProbOne + maxProbTwo); break;
                            case "⊕_in": minProb = minProbOne + minProbTwo - (minProbOne * minProbTwo); maxProb = maxProbOne + maxProbTwo - (maxProbOne * maxProbTwo); break;
                            case "⊕_me": minProb = Math.Min(1, minProbOne + minProbTwo); maxProb = Math.Min(1, maxProbOne + maxProbTwo); break;
                            case "⊖_ig": minProb = Math.Max(0, minProbOne - maxProbTwo); maxProb = Math.Min(maxProbOne, 1 - minProbTwo); break;
                            case "⊖_in": minProb = minProbOne * (1 - maxProbTwo); maxProb = maxProbOne * (1 - minProbTwo); break;
                            case "⊖_me": minProb = minProbOne; maxProb = Math.Min(maxProbOne, 1 - minProbTwo); break;
                            default: MessageError = "Incorrect syntax near 'where'.";
                                break;

                        }
                    }
            }
            catch
            {
                MessageError = "Incorrect syntax near 'where'.";
                return string.Empty;
            }

            maxProb = 1 > maxProb ? maxProb : 1; // check maxProb
            return (String.Format("[{0},{1}]", minProb, maxProb));
        }
        /// <summary>
        /// Important!, get data following prob interval
        /// </summary>
        /// <param name="array"></param>
        /// <param name="L"></param>
        /// <param name="U"></param>
        /// <returns></returns>
        private bool CalculateExpression(List<string> array, double L, double U)
        {
            List<string> stack = new List<string>();

            for (int i = 0; i < array.Count; i++)
                if (!Operator.Contains(array[i]))
                {
                    stack.Add(array[i]);
                }
                else         // Lấy hai giá trị ra khỏi stack và tính toán
                {
                    string valueTwo = stack[stack.Count - 1].Trim(); // get value
                    string valueOne = stack[stack.Count - 2].Trim();
                    stack.RemoveAt(stack.Count - 1); // xóa valueTwo
                    stack.RemoveAt(stack.Count - 1); // xóa valueOne

                    string value = GetProbInterval(valueOne, valueTwo, array[i].Trim());
                    if (value == string.Empty)
                    {
                        this.conditionString = string.Empty;
                        return false;
                    }
                    stack.Add(value);
                }


            string strInterval = stack[0];

            // Lấy khoảng xác suất của biểu thức chọn sau khi tính toán
            int posOne = 1, posTwo = strInterval.Length - 2;
            strInterval = strInterval.Substring(posOne, posTwo - posOne + 1);
            strInterval = strInterval.Replace(" ", "");
            string[] StrProb = strInterval.Split(',');

            double minProb = Convert.ToDouble(StrProb[0]);
            double maxProb = Convert.ToDouble(StrProb[1]);



            return (L <= minProb && maxProb <= U); // trả về true nếu khoảng xác biểu thức chọn thỏa mãn xác xuất câu truy vấn
        }
        private bool ExpressionValue(string Str)
        {
            // Get Probabilistic Interval
            List<double> probInterval = convertConditionStringToProbInterVal(Str);
            // Get Selection Expression
            Str = converConditionStringToExpression(Str);
            List<string> array = new List<string>();
            // reverse to postfix notation 
            array = SE_PostfixNotation(Str);

            return CalculateExpression(array, probInterval[0], probInterval[1]);

        }
        private static string CutSpareSpace(string S)
        {
            string result = "";
            for (int i = 0; i < S.Length; i++)
                if (S[i] == ' ')
                {
                    if (S[i - 1] != ' ') result += S[i];
                }
                else result += S[i];
            return result;

        }
        private List<string> SC_PostfixNotation(string S)
        {
            List<string> O = new List<string>();  // Stack
            List<string> V = new List<string>();

            S = S.Replace("(", " ( ");
            S = S.Replace(")", " ) ");
            S = S.Replace("&", " & ");
            S = S.Replace("|", " | ");
            S = S.Replace("!", " ! ");
            S = CutSpareSpace(S.Trim());

            string[] A = S.Split(' ');

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].CompareTo("(") == 0)
                    O.Add(A[i]);
                else
                    if (A[i].CompareTo(")") == 0)
                    {
                        while (O.Count > 0 && O[O.Count - 1].CompareTo("(") != 0)
                        {
                            V.Add(O[O.Count - 1]);     // V.Add(" " + O[O.Count - 1] + " ");
                            O.RemoveAt(O.Count - 1);
                        }
                        O.RemoveAt(O.Count - 1);      // remove '('
                    }
                    else
                        if (A[i].CompareTo("&") == 0 || A[i].CompareTo("|") == 0 || A[i].CompareTo("!") == 0)        // operator
                        {
                            while (O.Count > 0 && Priority(O[O.Count - 1]) >= Priority(A[i]))
                            {
                                V.Add(O[O.Count - 1]);        // V.Add(" " + O[O.Count - 1] + " ");
                                O.RemoveAt(O.Count - 1);
                            }
                            O.Add(A[i]);
                        }
                        else
                            V.Add(A[i]);           // value
            }


            while (O.Count > 0)      // Sau khi kết thúc, lấy toàn bộ giá trị trong stack đưa vào V
            {
                V.Add(O[O.Count - 1]);
                O.RemoveAt(O.Count - 1);
            }
            return V;
        }
        private static bool CalculateCondition(List<string> Str)
        {
            List<string> stack = new List<string>();
            string valueOne, valueTwo;

            for (int i = 0; i < Str.Count; i++)
                if (Str[i].CompareTo("!") == 0)
                {
                    valueOne = stack[stack.Count - 1].Trim();
                    stack.RemoveAt(stack.Count - 1);
                    stack.Add((valueOne.CompareTo("1") == 0) ? "0" : "1");
                }
                else
                    if (Str[i].CompareTo("&") == 0 || Str[i].CompareTo("|") == 0)         // Lấy hai giá trị ra khỏi stack và tính toán
                    {
                        valueTwo = stack[stack.Count - 1].Trim();
                        valueOne = stack[stack.Count - 2].Trim();
                        stack.RemoveAt(stack.Count - 1);
                        stack.RemoveAt(stack.Count - 1);
                        bool v1 = (valueOne.CompareTo("1") == 0) ? true : false;
                        bool v2 = (valueTwo.CompareTo("1") == 0) ? true : false;
                        switch (Str[i])
                        {
                            case "&": stack.Add(v1 && v2 ? "1" : "0"); break;
                            case "|": stack.Add(v1 || v2 ? "1" : "0"); break;
                            default: break;
                        }
                    }
                    else
                        stack.Add(Str[i]);          // Nếu là giá trị thì add vào stack

            return (stack[0].CompareTo("1") == 0);
        }

        /// <summary>
        /// Function return true satisfy
        /// </summary>
        /// <param name="tuple"></param>
        /// <returns></returns>
        public bool Satisfied(FProbTupleBLL tuple)
        {

            this.tuple = tuple;
            string conditionStr = this.conditionString;

            #region
            int i = 0;
            int j = 0;
            while (i < conditionStr.Length - 1)
            {
                if (conditionStr[i] == '(')
                {
                    j = i + 1;
                    while (j < conditionStr.Length)
                    {
                        if (conditionStr[j] == ']')
                        {
                            if (IsSelectionExpression(conditionStr.Substring(i, j - i + 1)))
                            {
                                string expValue = ExpressionValue(conditionStr.Substring(i, j - i + 1)) ? "1" : "0";
                                conditionStr = conditionStr.Insert(i, expValue);
                                conditionStr = conditionStr.Remove(i + 1, j - i + 1);
                                break;
                            }

                            if (MessageError != string.Empty)
                            {
                                return false;
                            }
                        }
                        j++;
                    }
                }
                i++;
            }

            #endregion

            conditionStr = conditionStr.Replace(" ", "").ToLower();
            conditionStr = conditionStr.Replace("and", "&");
            conditionStr = conditionStr.Replace("or", "|");
            conditionStr = conditionStr.Replace("not", "!");
            List<string> rpn = SC_PostfixNotation(conditionStr);            // reverse to postfix notation 
            return CalculateCondition(rpn);
        }
    }
}
