using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPRDB.BLL
{
    public class QueryExecutionBLL
    {
        public string queryString { get; set; }
        public List<FProbRelationBLL> selectedRelations { get; set; }
        public FProbRelationBLL relationResult { get; set; }
        public List<FProbAttributeBLL> selectedAttributes;
        public FProbDatabaseBLL probDatabase { get; set; }
        public string conditionString { get; set; }
        public bool flagNaturalJoin { get; set; }
        private string OperationNaturalJoin = string.Empty;
        public string MessageError { get; set; }
        public FProbRelationBLL DescartesAndNaturalJoin { get; set; }

        public QueryExecutionBLL(string queryString, FProbDatabaseBLL probDatabase)
        {
            this.selectedRelations = new List<FProbRelationBLL>();
            this.selectedAttributes = new List<FProbAttributeBLL>();
            this.relationResult = new FProbRelationBLL();
            this.probDatabase = probDatabase;
            this.conditionString = string.Empty;
            this.OperationNaturalJoin = string.Empty;
            this.MessageError = string.Empty;
            this.queryString = StandardizeQuery(queryString);
            this.flagNaturalJoin = false;
            this.DescartesAndNaturalJoin = new FProbRelationBLL();
        }
        private static string StandardizeQuery(string queryString)
        {
            try
            {
                string result = "";
                string S = queryString;
                for (int i = 0; i < S.Length; i++)
                    if (S[i] == ' ')
                    {
                        if (S[i - 1] != ' ')
                            result += S[i];
                    }
                    else
                        result += S[i];

                result = result.Replace("\n", " ");
                result = result.Replace("->", "→");
                return result.ToLower();
            }
            catch (Exception)
            {
                return null;
            }
        }
        private bool CheckStringQuery(string stringQuery)
        {
            //Kiểm tra sự hợp lệ của câu lệnh truy vấn
            //////////////////////// Check Syntax ////////////////////////
            int indexSelect = stringQuery.IndexOf("select");
            int indexFrom = stringQuery.IndexOf("from");
            int indexWhere = stringQuery.IndexOf("where");
            int indexStart = stringQuery.IndexOf("*");
            int indexLastSelect = stringQuery.LastIndexOf("select");
            int indexLastFrom = stringQuery.IndexOf("from");
            int indexLastWhere = stringQuery.IndexOf("where");
            int indexLastStart = stringQuery.IndexOf("*");


            if (indexSelect == -1)
            {
                MessageError = "Syntax Error! Not Found keyword 'select' ";//return message = "Query is missing 'select' structure!";
                return false;
            }

            if (indexFrom == -1)
            {
                MessageError = "Syntax Error! Not Found FROM statement";
                return false;
            }

            if (indexWhere != -1)//nếu có từ where trong câu truy vấn
            {

                if (indexSelect < indexFrom && indexFrom < indexWhere)
                {

                }
                else// lỗi thứ tự các từ select from where không đúng cấu trúc
                {
                    MessageError = "Syntax Error! The keyword must theo order 'Select From Where' ";
                    return false;
                }

            }
            else//nếu không có điều kiện chọn where
            {
                if (indexSelect < indexFrom && indexWhere == -1)
                {

                }
                else// lỗi thứ tự các từ select from không đúng cấu trúc
                {
                    MessageError = "Syntax Error! The keyword must theo order 'Select From ' ";
                    return false;
                }


            }

            if (indexSelect != indexLastSelect)// trong câu truy vấn chỉ có duy nhất 1 từ select nếu có hơn sẽ báo lỗi
            {
                MessageError = "Syntax Error! In query statement only have a keyword 'select' ";
                return false;
            }

            if (indexFrom != indexLastFrom)// trong câu truy vấn chỉ có duy nhất 1 từ from nếu có hơn sẽ báo lỗi
            {
                MessageError = "Syntax Error! In query statement only have a keyword 'from' ";
                return false;
            }

            if (indexLastWhere != indexWhere)// trong câu truy vấn chỉ có duy nhất 1 từ where nếu có hơn sẽ báo lỗi
            {
                MessageError = "Syntax Error! In query statement only have a keyword 'where' ";
                return false;
            }

            #region check kí tự đặc biệt

            char[] SpecialCharacter = new char[] { '~', '!', '@', '#', '$', '%', '^', '&', '[', ']', '(', ')', '+', '`', ';', '<', '>', '?', '/', ':', '\"', '\'', '=', '{', '}', '\\', '|', '→' };
            string specialcharacter = string.Empty;
            for (int i = 0; i < SpecialCharacter.Length; i++)
                specialcharacter += SpecialCharacter[i];

            string subString = string.Empty;
            if (stringQuery.Contains("where"))
            {
                int pOne = stringQuery.IndexOf("select") + 6;
                int pTwo = stringQuery.IndexOf("where") - 1;
                subString = stringQuery.Substring(pOne, pTwo);// lấy đoạn sau từ select và trước từ where
                for (int i = 0; i < subString.Length; i++)
                {
                    if (specialcharacter.Contains(subString[i]))
                    {

                        MessageError = String.Format("Error: Do not input the special character '{0}' in query statement", subString[i]);
                        return false;

                    }
                }
            }
            else
            {
                for (int i = 0; i < stringQuery.Length; i++)
                {
                    if (specialcharacter.Contains(stringQuery[i]))
                    {
                        MessageError = String.Format("Error: Do not input the special character '{0}' in query statement", stringQuery[i]);
                        return false;

                    }
                }

            }
            #endregion

            return true;
        }
        private List<FProbRelationBLL> GetAllRelation(string valueString)
        {
            //Khởi tạo
            int posOne;
            int posTwo;
            string relationsString = string.Empty;
            List<string> listOfRelationName = this.probDatabase.ListOfRelationNameToLower();// lấy danh sách các relation có trong database hiện hành
            string[] seperator = { "," };
            string[] relations;
            List<FProbRelationBLL> probRelations = new List<FProbRelationBLL>();


            //////////////////////// Get Relations ///////////////////////

            posOne = valueString.IndexOf("from") + 4;

            if (!valueString.Contains("where"))//nếu không có từ where (không có điều kiện chọn)
                posTwo = valueString.Length - 1;
            else
                posTwo = valueString.IndexOf("where") - 1;
            // Lấy đoạn string sau từ from 
            relationsString = valueString.Substring(posOne, posTwo - posOne + 1);   // Get Relation in the Query Text     
            //
            if (relationsString.Trim().Length <= 0)
            {
                MessageError = "No relation exists in the query !";
                return null;
            }

            if (relationsString.Contains(","))
            {
                relations = relationsString.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            }
            else
                if (relationsString.Contains(" natural join in") || relationsString.Contains(" natural join ig") || relationsString.Contains(" natural join me"))
                {
                    relations = new string[2];

                    if (relationsString.Contains(" natural join in"))
                    {
                        relations[0] = relationsString.Substring(0, relationsString.IndexOf("natural join in")).Trim();
                        relations[1] = relationsString.Substring(relationsString.IndexOf("natural join in") + 15).Trim();
                        OperationNaturalJoin = "in";
                    }
                    else
                        if (relationsString.Contains(" natural join ig"))
                        {
                            relations[0] = relationsString.Substring(0, relationsString.IndexOf("natural join ig")).Trim();
                            relations[1] = relationsString.Substring(relationsString.IndexOf("natural join ig") + 15).Trim();
                            OperationNaturalJoin = "ig";
                        }
                        else
                        {
                            relations[0] = relationsString.Substring(0, relationsString.IndexOf("natural join me")).Trim();
                            relations[1] = relationsString.Substring(relationsString.IndexOf("natural join me") + 15).Trim();
                            OperationNaturalJoin = "me";
                        }

                    foreach (string item in relations)
                    {
                        if (item == "")
                        {
                            MessageError = "Incorrect syntax near 'from'.";
                            return null;
                        }
                        string[] listTmp = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (listTmp.Length != 1)
                        {
                            MessageError = "Incorrect syntax near 'from'.";
                            return null;
                        }

                    }
                    flagNaturalJoin = true;
                }
                else
                {
                    relations = new string[1];
                    relations[0] = relationsString;
                }



            if (relations.Length > 2)
            {
                MessageError = "The query only accept one or two relation.";
                return null;
            }


            if (relations.Length == 1)
            {
                string[] listTmp = relations[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (listTmp.Length > 2)
                {
                    MessageError = "Incorrect syntax near 'from'.";
                    return null;
                }

                if (!listOfRelationName.Contains(listTmp[0].ToLower()))
                {
                    MessageError = String.Format("Invalid relation name '{0}'.", listTmp[0]);
                    return null;
                }


            }
            else
            {

                for (int i = 0; i < relations.Length; i++)
                {
                    string[] listTmp = relations[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (listTmp.Length > 2)
                    {
                        MessageError = "Incorrect syntax near 'from'.";
                        return null;
                    }

                    if (!listOfRelationName.Contains(listTmp[0].ToLower()))
                    {
                        MessageError = String.Format("Invalid relation name '{0}'.", listTmp[0]);
                        return null;
                    }
                }
            }


            for (int i = 0; i < relations.Length; i++)
            {
                string[] listTmp = relations[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                FProbRelationBLL tmp = this.probDatabase.FproRelations.SingleOrDefault(c => c.RelationName.ToLower().Equals(listTmp[0], StringComparison.OrdinalIgnoreCase));


                FProbRelationBLL rela = new FProbRelationBLL();
                if (listTmp.Length == 2)
                {
                    rela.RelationName = listTmp[1];
                }
                else
                    rela.RelationName = tmp.RelationName;

                rela.FproSchema = new FProbSchemaBLL(-1, tmp.FproSchema.SchemaName, tmp.FproSchema.FproAttributes);

                foreach (FProbTupleBLL item in tmp.FproTuples)
                {
                    FProbTupleBLL tuple = new FProbTupleBLL(item);
                    rela.FproTuples.Add(tuple);
                }


                probRelations.Add(rela);
            }


            if (probRelations.Count == 2)
            {

                if (probRelations[0].RelationName == probRelations[1].RelationName)
                {
                    MessageError = String.Format("The correlation name '{0}' is specified multiple times in a FROM clause.", probRelations[0].RenameRelationName);
                    return null;
                }


            }

            foreach (FProbRelationBLL item in probRelations)
            {
                if (item.RelationName != string.Empty)
                {
                    try
                    {
                        int value = Convert.ToInt32(item.RelationName);
                        MessageError = String.Format("Incorrect syntax near '{0}'.", item.RelationName);
                        return null;

                    }
                    catch (Exception)
                    {


                    }


                }
            }

            return probRelations;

        }
        private static bool CheckStringAttribute(string stringAttribute)
        {

            string subString = stringAttribute;

            if (subString.Trim().Length <= 0)
                return false;

            for (int i = 0; i < subString.Length - 1; i++)
            {
                if (subString.ElementAt(i) == subString.ElementAt(i + 1) && subString.ElementAt(i) == ',')
                    return false;
            }

            if (subString.LastIndexOf(",") == subString.Length - 1)
            {
                return false;
            }


            return true;
        }
        private List<FProbAttributeBLL> GetAttribute(string valueString)
        {
            List<FProbAttributeBLL> listProbAttribute = new List<FProbAttributeBLL>();
            int posOne, posTwo;
            if (valueString.Contains("*"))
            {
                posOne = valueString.IndexOf("*");                                                   // start postion of attributes
                posTwo = valueString.IndexOf("from ") - 1;
                #region...
                if (posOne > posTwo)
                {
                    MessageError = "Incorrect syntax near 'from'.";
                    return null;
                }
                if (posOne < valueString.IndexOf("select"))
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }
                if (valueString.Contains("where") && posOne > valueString.IndexOf("where"))
                {
                    MessageError = "Incorrect syntax near 'where'.";
                    return null;
                }

                if (posOne != valueString.LastIndexOf("*"))
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }
                string attributes = valueString.Substring(posOne, posTwo - posOne + 1);
                if (attributes.Trim().Length > 1)
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }
                #endregion
                for (int i = 0; i < this.selectedRelations.Count; i++)
                {
                    foreach (FProbAttributeBLL attr in this.selectedRelations[i].FproSchema.FproAttributes)
                    {
                        attr.AttributeName = String.Format("{0}.{1}", this.selectedRelations[i].RelationName, attr.AttributeName);
                        listProbAttribute.Add(attr);
                    }
                }
                return listProbAttribute;
            }
            else
            {
                posOne = valueString.IndexOf("select") + 6;
                posTwo = valueString.IndexOf("from ") - 1;
                string attributes = valueString.Substring(posOne, posTwo - posOne + 1);
                if (!QueryExecutionBLL.CheckStringAttribute(attributes))
                {
                    MessageError = "Incorrect syntax near 'select'.";
                    return null;
                }
                else
                {
                    string[] seperator = { "," };
                    string[] attribute = attributes.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string str in attribute)
                    {
                        if (!str.Contains("."))
                        {
                            string attributeName = str.Trim();
                            int countOne = 0;
                            int countSameAttribute = 0;
                            foreach (FProbRelationBLL relation in this.selectedRelations)
                            {
                                List<string> listOfAttributeName = relation.FproSchema.ListOfAttributeNameToLower();
                                if (listOfAttributeName.Contains(attributeName.ToLower()))
                                {
                                    FProbAttributeBLL attr = new FProbAttributeBLL(relation.FproSchema.FproAttributes[listOfAttributeName.IndexOf(attributeName)]);
                                    attr.AttributeName = String.Format("{0}.{1}", relation.RelationName, attr.AttributeName);
                                    listProbAttribute.Add(attr);
                                    countSameAttribute++;
                                }
                                else
                                {
                                    countOne++;
                                }
                            }
                            if (countOne == this.selectedRelations.Count)
                            {
                                MessageError = String.Format(" Invalid attribute name '{0}'.", attributeName);
                                return null;
                            }
                            if (countSameAttribute == this.selectedRelations.Count && this.selectedRelations.Count >= 2)
                            {
                                MessageError = String.Format(" Ambiguous attribute name '{0}'.", attributeName);
                                return null;
                            }
                        }
                        else
                        {
                            string[] array = str.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                            if (array.Length != 2)
                            {
                                MessageError = "Incorrect syntax near the keyword 'select'.";
                                return null;
                            }
                            FProbRelationBLL relation = this.selectedRelations.SingleOrDefault(c => c.RelationName.Trim() == array[0].Trim());
                            if (relation == null)
                            {
                                MessageError = String.Format("The multi-part identifier '{0}' could not be bound.", str);
                                return null;
                            }
                            FProbAttributeBLL attr = new FProbAttributeBLL(relation.FproSchema.FproAttributes.SingleOrDefault(c => c.AttributeName.Trim().ToLower() == array[1].Trim()));
                            attr.AttributeName = String.Format("{0}.{1}", relation.RelationName, attr.AttributeName);
                            if (attr == null)
                            {
                                MessageError = "Invalid attribute name '" + array[1] + "'.";
                                return null;
                            }
                            listProbAttribute.Add(attr);
                        }
                    }
                    return listProbAttribute;
                }
            }
        }
        private static string GetCondition(string valueString)
        {

            string conditionString = string.Empty;
            int posOne;

            ///////////////////// Get Select Condition /////////////////
            if (valueString.Contains("where "))
            {
                posOne = valueString.IndexOf("where") + 5;
                conditionString = valueString.Substring(posOne);   // Get Select Condition in the Query Text
            }
            else
                conditionString = string.Empty;

            return conditionString;
        }
        private bool QueryAnalyze()
        {
            try
            {

                string S = this.queryString;
                //Kiểm tra sự hợp lệ của câu lệnh truy vấn
                if (!this.CheckStringQuery(S))//nếu câu truy vấn không hợp lệ (vị trí các từ select from where hay có chưa ký tự đặc biệt)
                {
                    return false;
                }

                //Get All Relation (danh sách các bảng)
                this.selectedRelations = GetAllRelation(S);//lấy ra danh sách relation trong câu truy vấn
                if (this.selectedRelations == null)
                {
                    return false;
                }


                //Get All Attribute (danh sách các cột)
                this.selectedAttributes = GetAttribute(S);//lấy ra danh sách attributes trong câu truy vấn
                if (this.selectedAttributes == null)
                    return false;
                //(điều kiện chọn)
                this.conditionString = GetCondition(S);// điều kiện truy vấn

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        private FProbRelationBLL Descartes()
        {
            FProbRelationBLL relation = new FProbRelationBLL();
            relation.ListRenameRelation.Add(this.selectedRelations[0].RelationName);

            foreach (FProbAttributeBLL attr in this.selectedRelations[0].FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = this.selectedRelations[0].RelationName + "." + attr.AttributeName;
            }

            relation.FproSchema.FproAttributes.AddRange(this.selectedRelations[0].FproSchema.FproAttributes);
            relation.ListRenameRelation.Add(this.selectedRelations[1].RelationName);

            foreach (FProbAttributeBLL attr in this.selectedRelations[1].FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = this.selectedRelations[1].RelationName + "." + attr.AttributeName;
            }
            relation.FproSchema.FproAttributes.AddRange(this.selectedRelations[1].FproSchema.FproAttributes);


            foreach (FProbTupleBLL tupleOne in this.selectedRelations[0].FproTuples)
            {

                foreach (FProbTupleBLL tupleTwo in this.selectedRelations[1].FproTuples)
                {
                    FProbTupleBLL value = new FProbTupleBLL();
                    value.FproTriples.AddRange(tupleOne.FproTriples);
                    value.FproTriples.AddRange(tupleTwo.FproTriples);
                    relation.FproTuples.Add(value);
                }
            }

            return relation;
        }
        private FProbRelationBLL NaturalJoin()
        {
            FProbRelationBLL relation = Descartes();
            List<int> indexsRemove = new List<int>();

            for (int i = 0; i < relation.FproSchema.FproAttributes.Count - this.selectedRelations[1].FproSchema.FproAttributes.Count; i++)
            {

                for (int j = this.selectedRelations[1].FproSchema.FproAttributes.Count; j < relation.FproSchema.FproAttributes.Count; j++)
                {
                    if (i != j && relation.FproSchema.FproAttributes[i].FproDataType.TypeName == relation.FproSchema.FproAttributes[j].FproDataType.TypeName)
                    {
                        string attributeOne = relation.FproSchema.FproAttributes[i].AttributeName.Substring(relation.FproSchema.FproAttributes[i].AttributeName.IndexOf(".") + 1);
                        string attributeTwo = relation.FproSchema.FproAttributes[j].AttributeName.Substring(relation.FproSchema.FproAttributes[j].AttributeName.IndexOf(".") + 1);

                        if (attributeOne.Equals(attributeTwo, StringComparison.CurrentCultureIgnoreCase))
                        {
                            indexsRemove.Add(j);

                            for (int k = relation.FproTuples.Count - 1; k >= 0; k--)
                            {
                                FProbTripleBLL triple = JoinTwoTriple(relation.FproTuples[k].FproTriples[i], relation.FproTuples[k].FproTriples[j], relation.FproSchema.FproAttributes[i], this.OperationNaturalJoin);
                                if (triple != null)
                                {
                                    relation.FproTuples[k].FproTriples[i] = triple;
                                    relation.FproTuples[k].FproTriples[j] = triple;
                                }
                                else
                                {
                                    relation.FproTuples.RemoveAt(k);

                                }
                            }
                        }
                    }
                }
            }

            for (int i = indexsRemove.Count - 1; i >= 0; i--)
            {

                foreach (FProbTupleBLL tuple in relation.FproTuples)
                {
                    tuple.FproTriples.RemoveAt(indexsRemove[i]);
                }
                relation.FproSchema.FproAttributes.RemoveAt(indexsRemove[i]);
                this.selectedAttributes.RemoveAt(indexsRemove[i]);
            }

            OperationNaturalJoin = string.Empty;
            flagNaturalJoin = false;
            return relation;
        }
        private static bool AlreadyList(List<object> list, double value)
        {
            for (int i = 0; i < list.Count; i++)
                if (Convert.ToDouble(list[i]) == value)
                    return false;
            return true;
        }
        private static FProbTripleBLL JoinTwoTriple(FProbTripleBLL tripleOne, FProbTripleBLL tripleTwo, FProbAttributeBLL attribute, string OperationNaturalJoin)
        {
            FProbTripleBLL triple = new FProbTripleBLL();

            for (int i = 0; i < tripleOne.Value.Count; i++)
            {
                for (int j = 0; j < tripleTwo.Value.Count; j++)
                {
                    if (SelectConditionBLL.EQUAL(tripleOne.Value[i].ToString().Trim(), tripleTwo.Value[j].ToString().Trim(), attribute.FproDataType.TypeName))
                    {
                        if (attribute.FproDataType.TypeName == "DiscreteFuzzySet" || attribute.FproDataType.TypeName == "ContinuousFuzzySet")
                        {
                            if (attribute.FproDataType.TypeName == "DiscreteFuzzySet")
                            {
                                DiscreteFuzzySetBLL disfs1 = DiscreteFuzzySetBLL.GetByName(tripleOne.Value[i].ToString().Trim());
                                DiscreteFuzzySetBLL disfs2 = DiscreteFuzzySetBLL.GetByName(tripleTwo.Value[j].ToString().Trim());
                                List<Double> h1 = disfs1.getXsForMembership(1.0);
                                List<Double> h2 = disfs2.getXsForMembership(1.0);
                                for (int l = 0; l < h1.Count; l++)
                                {
                                    for (int m = 0; m < h2.Count; m++)
                                        if (h1[i] == h2[j])
                                        {
                                            if (AlreadyList(triple.Value, h1[i]))
                                                triple.Value.Add(h1[i]);
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                ContinuousFuzzySetBLL contfs1 = new ContinuousFuzzySetBLL().GetContinuousFuzzySetByName(tripleOne.Value[i].ToString().Trim());
                                ContinuousFuzzySetBLL contfs2 = new ContinuousFuzzySetBLL().GetContinuousFuzzySetByName(tripleTwo.Value[j].ToString().Trim());
                                if (contfs1.TopRight < contfs2.TopRight && contfs1.TopRight > contfs2.TopLeft)
                                    triple.Value.Add(tripleOne.Value[i]);
                                else
                                    triple.Value.Add(tripleTwo.Value[j]);
                            }
                            switch (OperationNaturalJoin)
                            {
                                case "in":
                                    triple.MinProb.Add(tripleOne.MinProb[i] * tripleTwo.MinProb[j]);
                                    triple.MaxProb.Add(tripleOne.MaxProb[i] * tripleTwo.MaxProb[j]);

                                    break;

                                case "ig":
                                    triple.MinProb.Add(Math.Max(0, tripleOne.MinProb[i] + tripleTwo.MinProb[j] - 1));
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], tripleTwo.MaxProb[j]));
                                    break;

                                case "me":
                                    triple.MinProb.Add(0);
                                    triple.MaxProb.Add(0);
                                    break;
                                default: break;
                            }
                        }
                        else
                        {
                            switch (OperationNaturalJoin)
                            {
                                case "in":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(tripleOne.MinProb[i] * tripleTwo.MinProb[j]);
                                    triple.MaxProb.Add(tripleOne.MaxProb[i] * tripleTwo.MaxProb[j]);

                                    break;

                                case "ig":

                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(Math.Max(0, tripleOne.MinProb[i] + tripleTwo.MinProb[j] - 1));
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], tripleTwo.MaxProb[j]));
                                    break;

                                case "me":

                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(0);
                                    triple.MaxProb.Add(0);
                                    break;
                                default: break;
                            }
                        }
                    }
                }
            }
            return triple.Value.Count <= 0 ? null : triple;
        }
        private static FProbRelationBLL getRelationBySelectAttribute(FProbRelationBLL probRelation, List<FProbAttributeBLL> attributes)
        {
            FProbRelationBLL relation = new FProbRelationBLL();
            relation.RelationName = probRelation.RelationName;


            List<int> indexs = new List<int>();
            List<int> indexRemove = new List<int>();
            foreach (FProbAttributeBLL attr in attributes)
            {
                for (int i = 0; i < probRelation.FproSchema.FproAttributes.Count; i++)
                {
                    if (probRelation.FproSchema.FproAttributes[i].AttributeName.Trim().ToLower() == attr.AttributeName.Trim().ToLower())
                    {
                        indexs.Add(i);
                        break;
                    }
                }
            }

            foreach (FProbTupleBLL item in probRelation.FproTuples)
            {
                FProbTupleBLL tuple = new FProbTupleBLL();
                for (int i = 0; i < indexs.Count; i++)
                {
                    tuple.FproTriples.Add(item.FproTriples[indexs[i]]);
                }
                relation.FproTuples.Add(tuple);
            }


            relation.FproSchema.FproAttributes = attributes;

            return relation;
        }
        internal bool ExecuteQuery()
        {
            try
            {
                if (!QueryAnalyze()) return false;


                if (this.selectedRelations.Count == 2)
                {
                    if (flagNaturalJoin != true)
                        this.selectedRelations[0] = Descartes();
                    else
                        this.selectedRelations[0] = NaturalJoin();
                }
                else
                {
                    foreach (FProbAttributeBLL attr in this.selectedRelations[0].FproSchema.FproAttributes)
                    {
                        if (!attr.AttributeName.Contains("."))
                            attr.AttributeName = String.Format("{0}.{1}", this.selectedRelations[0].RelationName, attr.AttributeName);
                    }
                }

                if (!this.queryString.Contains("where"))
                {
                    this.relationResult = getRelationBySelectAttribute(this.selectedRelations[0], this.selectedAttributes);
                    return true;
                }
                else
                {
                    SelectConditionBLL Condition = new SelectConditionBLL(this.selectedRelations[0], this.conditionString);
                    if (!Condition.CheckConditionString())
                    {
                        this.MessageError = Condition.MessageError;
                        return false;
                    }

                    foreach (FProbTupleBLL tuple in this.selectedRelations[0].FproTuples)
                        if (Condition.Satisfied(tuple))
                            this.relationResult.FproTuples.Add(tuple);

                    if (Condition.MessageError != string.Empty)
                    {
                        this.MessageError = Condition.MessageError;
                        return false;
                    }

                    if (Condition.conditionString == string.Empty)
                    {
                        this.MessageError = Condition.MessageError;
                        return false;
                    }
                   
                    this.relationResult.FproSchema = this.selectedRelations[0].FproSchema;
                    this.relationResult = getRelationBySelectAttribute(this.relationResult, this.selectedAttributes);
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
