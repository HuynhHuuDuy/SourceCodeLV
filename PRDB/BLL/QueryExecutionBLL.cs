using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace FPRDB.BLL
{
    public class QueryExecutionBLL
    {
        public string queryString { get; set; }
        public string query_1 { get; set; }
        public string query_2 { get; set; }

        public List<FProbRelationBLL> selectedRelations { get; set; }
        public List<FProbRelationBLL> selectedRelation1 { get; set; }
        public List<FProbRelationBLL> selectedRelation2 { get; set; }

        public FProbRelationBLL relationResult { get; set; }
        public FProbRelationBLL relationResult1 { get; set; }
        public FProbRelationBLL relationResult2 { get; set; }

        public List<FProbAttributeBLL> selectedAttributes;
        public List<FProbAttributeBLL> selectedAttribute1;
        public List<FProbAttributeBLL> selectedAttribute2;

        public FProbDatabaseBLL probDatabase { get; set; }
        public string conditionString { get; set; }
        public string conditionString1 { get; set; }
        public string conditionString2 { get; set; }
        /// <summary>
        /// biến nhận biết lưu trữ có xảy ra phép kết tự nhiên hay không
        /// </summary>
        public bool flagNaturalJoin { get; set; }
        private string OperationNaturalJoin = string.Empty;


        /// <summary>
        /// biến lưu trữ nhận biết có xảy ra phép trừ hay không
        /// </summary>
        private bool flagDifference { get; set; }
        private string OperationDifference = string.Empty;
        //biến lưu trữ nhận biết có xảy ra phép trừ hay không
        /// <summary>
        /// biến nhận biết có xảy ra phép hợp hay không
        /// </summary>
        private bool flagUnion { get; set; }
        private string OperationUnion = string.Empty;

        /// <summary>
        /// biến nhận biết có xảy ra phép giao hay không
        /// </summary>
        private bool flagIntersect { get; set; }
        private string OperationIntersect = string.Empty;

        public string MessageError { get; set; }
        public FProbRelationBLL DescartesAndNaturalJoin { get; set; }
        public QueryExecutionBLL(string queryString, FProbDatabaseBLL probDatabase)
        {
            this.selectedRelations = new List<FProbRelationBLL>();
            this.selectedRelation1 = new List<FProbRelationBLL>();
            this.selectedRelation2 = new List<FProbRelationBLL>();
            this.selectedAttributes = new List<FProbAttributeBLL>();
            this.selectedAttribute1 = new List<FProbAttributeBLL>();
            this.selectedAttribute2 = new List<FProbAttributeBLL>();
            this.relationResult = new FProbRelationBLL();
            this.relationResult1 = new FProbRelationBLL();
            this.relationResult2 = new FProbRelationBLL();
            this.probDatabase = probDatabase;
            this.conditionString = string.Empty;
            this.OperationNaturalJoin = string.Empty;
            this.OperationDifference = string.Empty;
            this.OperationIntersect = string.Empty;
            this.OperationUnion = string.Empty;
            this.MessageError = string.Empty;
            this.queryString = StandardizeQuery(queryString);
            this.flagNaturalJoin = false;
            this.flagDifference = false;
            this.flagIntersect = false;
            this.flagUnion = false;
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

            //fix now
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
                if (indexSelect > indexFrom && indexWhere != -1)
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

            Regex regex = new Regex(@"[^a-zA-Z0-9*,\s⊗⊕⊖→_]");

            string subString = string.Empty;
            if (stringQuery.Contains("where"))
            {
                int pOne = stringQuery.IndexOf("select") + 6;
                int pTwo = stringQuery.IndexOf("where") - 1;
                subString = stringQuery.Substring(pOne, pTwo);// lấy đoạn sau từ select và trước từ where

                Match match = regex.Match(subString);
                if (match.Success)
                {
                    MessageError = String.Format("Error: Do not input the special character in query statement !");
                    return false;
                }
            }
            else
            {
                Match match = regex.Match(stringQuery);
                if (match.Success)
                {
                    MessageError = String.Format("Error: Do not input the special character in query statement !");
                    return false;
                }
            }
            #endregion

            return true;
        }

        /// <summary>
        /// Important! Function get all relation(table name)
        /// </summary>
        /// <param name="valueString"></param>
        /// <returns></returns>
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

            //will fix, nen de tren cung, kiem tra dieu kien, if cau query sai k can chay tiep nua
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
        private List<FProbAttributeBLL> GetAttribute(string valueString, List<FProbRelationBLL> selectedRelations)
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
                for (int i = 0; i < selectedRelations.Count; i++)
                {
                    foreach (FProbAttributeBLL attr in selectedRelations[i].FproSchema.FproAttributes)
                    {
                        attr.AttributeName = String.Format("{0}.{1}", selectedRelations[i].RelationName, attr.AttributeName);
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
                            foreach (FProbRelationBLL relation in selectedRelations)
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
                            if (countOne == selectedRelations.Count)
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
                            FProbRelationBLL relation = selectedRelations.SingleOrDefault(c => c.RelationName.Trim() == array[0].Trim());
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
                //kiểm tra có tồn tại phép trừ, hợp, giao trong câu truy vấn hay không
                if (S.Contains("union") || S.Contains("except") || S.Contains("intersect"))
                {
                    if (S.Contains("union"))
                    {
                        if (S.Contains("union in"))
                        {
                            int index_Union = S.IndexOf("union in");
                            query_1 = S.Substring(0, index_Union).Trim();
                            query_2 = S.Substring(index_Union + 8).Trim();
                            OperationUnion = "in";
                        }
                        if (S.Contains("union ig"))
                        {
                            int index_Union = S.IndexOf("union ig");
                            query_1 = S.Substring(0, index_Union).Trim();
                            query_2 = S.Substring(index_Union + 8).Trim();
                            OperationUnion = "ig";
                        }
                        if (S.Contains("union me"))
                        {
                            int index_Union = S.IndexOf("union me");
                            query_1 = S.Substring(0, index_Union).Trim();
                            query_2 = S.Substring(index_Union + 8).Trim();
                            OperationUnion = "me";
                        }
                        flagUnion = true;
                    }
                    if (S.Contains("except"))
                    {
                        if (S.Contains("except in"))
                        {
                            int index_Except = S.IndexOf("except in");
                            query_1 = S.Substring(0, index_Except).Trim();
                            query_2 = S.Substring(index_Except + 9).Trim();
                            OperationDifference = "in";
                        }
                        if (S.Contains("except ig"))
                        {
                            int index_Except = S.IndexOf("except ig");
                            query_1 = S.Substring(0, index_Except).Trim();
                            query_2 = S.Substring(index_Except + 9).Trim();
                            OperationDifference = "ig";
                        }
                        if (S.Contains("except me"))
                        {
                            int index_Except = S.IndexOf("except ig");
                            query_1 = S.Substring(0, index_Except).Trim();
                            query_2 = S.Substring(index_Except + 9).Trim();
                            OperationDifference = "me";
                        }
                        flagDifference = true;
                    }
                    if (S.Contains("intersect"))
                    {
                        if (S.Contains("intersect in"))
                        {
                            int index_intersect = S.IndexOf("intersect in");
                            query_1 = S.Substring(0, index_intersect).Trim();
                            query_2 = S.Substring(index_intersect + 12).Trim();
                            OperationIntersect = "in";
                        }
                        if (S.Contains("intersect ig"))
                        {
                            int index_intersect = S.IndexOf("intersect ig");
                            query_1 = S.Substring(0, index_intersect);
                            query_2 = S.Substring(index_intersect + 12).Trim();
                            OperationIntersect = "ig";
                        }
                        if (S.Contains("intersect me"))
                        {
                            int index_intersect = S.IndexOf("intersect me");
                            query_1 = S.Substring(0, index_intersect).Trim();
                            query_2 = S.Substring(index_intersect + 12).Trim();
                            OperationIntersect = "me";
                        }
                        flagIntersect = true;
                    }
                    if (!this.CheckStringQuery(query_1))//nếu câu truy vấn không hợp lệ (vị trí các từ select from where hay có chưa ký tự đặc biệt)
                    {
                        return false;
                    }
                    if (!this.CheckStringQuery(query_2))//nếu câu truy vấn không hợp lệ (vị trí các từ select from where hay có chưa ký tự đặc biệt)
                    {
                        return false;
                    }
                    //Get All Relation (danh sách các bảng)
                    this.selectedRelation1 = GetAllRelation(query_1);//lấy ra danh sách relation trong câu truy vấn
                    this.selectedRelation2 = GetAllRelation(query_2);
                    if (this.selectedRelation1 == null || this.selectedRelation2 == null)
                    {
                        return false;
                    }

                    //Get All Attribute (danh sách các cột)
                    this.selectedAttribute1 = GetAttribute(query_1, this.selectedRelation1);//lấy ra danh sách attributes trong câu truy vấn
                    this.selectedAttribute2 = GetAttribute(query_2, this.selectedRelation2);
                    if (this.selectedAttribute1 == null || this.selectedAttribute2 == null)
                        return false;
                    if (flagUnion || flagIntersect)
                    {
                        this.selectedAttributes = this.selectedAttribute2;
                    }
                    if (flagDifference)
                    {
                        this.selectedAttributes = this.selectedAttribute1;
                    }

                    //(điều kiện chọn)
                    this.conditionString1 = GetCondition(query_1);// điều kiện truy vấn
                    this.conditionString2 = GetCondition(query_2);

                }
                else
                {
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
                    this.selectedAttributes = GetAttribute(S, this.selectedRelations);//lấy ra danh sách attributes trong câu truy vấn
                    if (this.selectedAttributes == null)
                        return false;
                    //(điều kiện chọn)
                    this.conditionString = GetCondition(S);// điều kiện truy vấn
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        private FProbRelationBLL Descartes(FProbRelationBLL selectedRelation1, FProbRelationBLL selectedRelation2)
        {
            FProbRelationBLL relation = new FProbRelationBLL();
            relation.ListRenameRelation.Add(selectedRelation1.RelationName);

            foreach (FProbAttributeBLL attr in selectedRelation1.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation1.RelationName + "." + attr.AttributeName;
            }

            relation.FproSchema.FproAttributes.AddRange(selectedRelation1.FproSchema.FproAttributes);
            relation.ListRenameRelation.Add(selectedRelation2.RelationName);

            foreach (FProbAttributeBLL attr in selectedRelation2.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation2.RelationName + "." + attr.AttributeName;
            }
            relation.FproSchema.FproAttributes.AddRange(selectedRelation2.FproSchema.FproAttributes);


            foreach (FProbTupleBLL tupleOne in selectedRelation1.FproTuples)
            {

                foreach (FProbTupleBLL tupleTwo in selectedRelation2.FproTuples)
                {
                    FProbTupleBLL value = new FProbTupleBLL();
                    value.FproTriples.AddRange(tupleOne.FproTriples);
                    value.FproTriples.AddRange(tupleTwo.FproTriples);
                    relation.FproTuples.Add(value);
                }
            }

            return relation;
        }
        private FProbRelationBLL NaturalJoin(FProbRelationBLL selectedRelation1, FProbRelationBLL selectedRelation2)
        {
            FProbRelationBLL relation = Descartes(selectedRelation1, selectedRelation2);
            List<int> indexsRemove = new List<int>();

            for (int i = 0; i < relation.FproSchema.FproAttributes.Count - selectedRelation2.FproSchema.FproAttributes.Count; i++)
            {
                for (int j = selectedRelation2.FproSchema.FproAttributes.Count; j < relation.FproSchema.FproAttributes.Count; j++)
                {
                    //cho nay ne. no' so sanh cho nay ne.
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
        /// <summary>
        /// thực thi phép trừ trong câu truy vấn
        /// </summary>
        /// <param name="selectedRelation1"></param>
        /// <param name="selectedRelation2"></param>
        /// <returns></returns>
        private FProbRelationBLL Difference(FProbRelationBLL selectedRelation1, FProbRelationBLL selectedRelation2)
        {

            FProbRelationBLL relationResult = new FProbRelationBLL();
            List<int> indexsRemove = new List<int>();
            foreach (FProbAttributeBLL attr in selectedRelation1.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation1.RelationName + "." + attr.AttributeName;
            }

            relationResult.FproSchema.FproAttributes.AddRange(selectedRelation1.FproSchema.FproAttributes);
            relationResult.ListRenameRelation.Add(selectedRelation1.RelationName);

            foreach (FProbAttributeBLL attr in selectedRelation2.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation2.RelationName + "." + attr.AttributeName;
            }
            relationResult.FproSchema.FproAttributes.AddRange(selectedRelation2.FproSchema.FproAttributes);
            relationResult.ListRenameRelation.Add(selectedRelation2.RelationName);
            // relation 0
            List<string> atrriButeRelation0 = new List<string>();
            List<FProbAttributeBLL> listAtrribute0 = new List<FProbAttributeBLL>();
            listAtrribute0 = selectedRelation1.FproSchema.FproAttributes;
            for (var i = 0; i < listAtrribute0.Count; i++)
            {
                if (((listAtrribute0[i].FproDataType.TypeName == "String") && (listAtrribute0[i].PrimaryKey == true)) || ((listAtrribute0[i].FproDataType.TypeName == "Int32") && (listAtrribute0[i].PrimaryKey == true)))
                {
                    for (int k = 0; k < selectedRelation1.FproTuples.Count; k++)
                    {
                        if (selectedRelation1.FproTuples[k].FproTriples[i].MinProb[0] == 1 && selectedRelation1.FproTuples[k].FproTriples[i].MaxProb[0] == 1)
                        {
                            atrriButeRelation0.Add(selectedRelation1.FproTuples[k].FproTriples[i].Value[0].ToString());
                        }

                    }

                }
            }
            // relation 1
            List<string> atrributeRelation1 = new List<string>();
            List<FProbAttributeBLL> listAtrribute1 = new List<FProbAttributeBLL>();
            listAtrribute1 = selectedRelation2.FproSchema.FproAttributes;
            for (int j = 0; j < listAtrribute1.Count; j++)
            {
                if (((listAtrribute1[j].FproDataType.TypeName == "String") && (listAtrribute1[j].PrimaryKey == true)) || ((listAtrribute1[j].FproDataType.TypeName == "Int32") && (listAtrribute1[j].PrimaryKey == true)))
                {
                    for (int k = 0; k < selectedRelation2.FproTuples.Count; k++)
                    {
                        if (selectedRelation2.FproTuples[k].FproTriples[j].MinProb[0] == 1 && selectedRelation2.FproTuples[k].FproTriples[j].MaxProb[0] == 1)
                        {
                            atrributeRelation1.Add(selectedRelation2.FproTuples[k].FproTriples[j].Value[0].ToString());
                        }
                    }
                }
            }
            // so sánh từng triple trong relation 0 với danh sách triple trong relation 1
            // nếu triple i không có trong relation 1 thì add tương ứng tuple vào relation kết quả
            for (int i = 0; i < atrriButeRelation0.Count; i++)
            {
                if (AlreadyList(atrributeRelation1, atrriButeRelation0[i]) == false)
                {
                    relationResult.FproTuples.Add(selectedRelation1.FproTuples[i]);
                }
            }
            // nếu hai tuple có khóa trùng 
            // biến lưu trữ các tuple có khóa trùng
            var abc1 = new List<FProbTupleBLL>();
            var abc2 = new List<FProbTupleBLL>();
            //result select 1 is selectedRelation1
            //result select 2 is selectedRelation2
            var list_duplicate = new List<string>();

            for (int i = 0; i < atrriButeRelation0.Count; i++)
            {
                if (AlreadyList(atrributeRelation1, atrriButeRelation0[i]))
                {
                    list_duplicate.Add(atrriButeRelation0[i]);
                }
            }
            // tìm những tuple ở selectRelation1 có khóa trùng với khóa ở list_duplicate
            for (int i = 0; i < list_duplicate.Count; i++)
            {
                for (int j = 0; j < selectedRelation1.FproTuples.Count; j++)
                {
                    if (selectedRelation1.FproTuples[j].FproTriples[0].Value[0].ToString() == list_duplicate[i])
                    {
                        abc1.Add(selectedRelation1.FproTuples[j]);
                    }
                }
            }
            // tìm những tuple ở selectRelation2 có khóa trùng với khóa ở list_duplicate
            for (int i = 0; i < list_duplicate.Count; i++)
            {
                for (int j = 0; j < selectedRelation2.FproTuples.Count; j++)
                {
                    if (selectedRelation2.FproTuples[j].FproTriples[0].Value[0].ToString() == list_duplicate[i])
                    {
                        abc2.Add(selectedRelation2.FproTuples[j]);
                    }
                }
            }
            for (int i = 0; i < abc1.Count; i++)
            {
                for (int j = 0; j < abc2.Count; j++)
                {
                    var tamp_result = joinTwoTupleExcept(abc1[i], abc2[j], selectedRelation1);
                    relationResult.FproTuples.Add(tamp_result);
                }
            }

            OperationDifference = string.Empty;
            flagDifference = false;
            return relationResult;
        }
        private static bool AlreadyList(List<String> list, string value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// hàm join hai triple trong phép trừ
        /// </summary>
        /// <param name="tripleOne"></param>
        /// <param name="tripleTwo"></param>
        /// <param name="attribute"></param>
        /// <param name="OperationDifference"></param>
        /// <returns></returns>
        private static FProbTripleBLL JoinTwoTripleDiffe(FProbTripleBLL tripleOne, FProbTripleBLL tripleTwo, FProbAttributeBLL attribute, string OperationDifference)
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
                                //for (int l = 0; l < h1.Count; l++)
                                //{
                                //    for (int m = 0; m < h2.Count; m++)
                                //        if (h1[i] == h2[j])
                                //        {
                                //            if (AlreadyList(triple.Value, h1[i]))
                                //                triple.Value.Add(h1[i]);
                                //            break;
                                //        }
                                //}
                                if (disfs1.FuzzySetName == disfs2.FuzzySetName)
                                {
                                    triple.Value.Add(disfs1.FuzzySetName);
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
                            switch (OperationDifference)
                            {
                                case "in":
                                    triple.MinProb.Add(tripleOne.MinProb[i] * (1 - tripleTwo.MaxProb[j]));
                                    triple.MaxProb.Add(tripleOne.MaxProb[i] * (1 - tripleTwo.MinProb[j]));

                                    break;

                                case "ig":
                                    triple.MinProb.Add(Math.Max(0, tripleOne.MinProb[i] - tripleTwo.MaxProb[j]));
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], 1 - tripleTwo.MinProb[j]));
                                    break;

                                case "me":
                                    triple.MinProb.Add(tripleOne.MinProb[i]);
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], (1 - tripleTwo.MinProb[i])));
                                    break;
                                default: break;
                            }

                        }
                        else
                        {
                            switch (OperationDifference)
                            {
                                case "in":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(tripleOne.MinProb[i] * (1 - tripleTwo.MaxProb[j]));
                                    triple.MaxProb.Add(tripleOne.MaxProb[i] * (1 - tripleTwo.MinProb[j]));

                                    break;

                                case "ig":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(Math.Max(0, tripleOne.MinProb[i] - tripleTwo.MaxProb[j]));
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], 1 - tripleTwo.MinProb[j]));
                                    break;

                                case "me":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(tripleOne.MinProb[i]);
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], (1 - tripleTwo.MinProb[i])));
                                    break;
                            }

                        }
                    }
                }
            }
            return triple.Value.Count <= 0 ? null : triple;
        }
        /// <summary>
        /// hàm join hai triple của phép hợp
        /// </summary>
        /// <param name="tripleOne"></param>
        /// <param name="tripleTwo"></param>
        /// <param name="attribute"></param>
        /// <param name="OperationUnion"></param>
        /// <returns></returns>
        private static FProbTripleBLL JoinTwoTripleUnion(FProbTripleBLL tripleOne, FProbTripleBLL tripleTwo, FProbAttributeBLL attribute, string OperationUnion)
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
                                //List<Double> h1 = disfs1.getXsForMembership(1.0);
                                //List<Double> h2 = disfs2.getXsForMembership(1.0);
                                //for (int l = 0; l < h1.Count; l++)
                                //{
                                //    for (int m = 0; m < h2.Count; m++)
                                //        if (h1[i] == h2[j])
                                //        {
                                //            if (AlreadyList(triple.Value, h1[i]))
                                //                triple.Value.Add(h1[i]);
                                //            break;
                                //        }
                                //}
                                if (disfs1.FuzzySetName == disfs2.FuzzySetName)
                                {
                                    triple.Value.Add(disfs1.FuzzySetName);
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
                            switch (OperationUnion)
                            {
                                case "in":
                                    triple.MinProb.Add(tripleOne.MinProb[i] + tripleTwo.MinProb[j] - (tripleOne.MinProb[i] * tripleTwo.MinProb[j]));
                                    triple.MaxProb.Add(tripleOne.MaxProb[i] + tripleTwo.MaxProb[j] - (tripleOne.MaxProb[i] * tripleTwo.MaxProb[j]));

                                    break;

                                case "ig":
                                    triple.MinProb.Add(Math.Max(tripleOne.MinProb[i], tripleTwo.MinProb[j]));
                                    triple.MaxProb.Add(Math.Min(1, tripleOne.MinProb[i] + tripleTwo.MinProb[j]));
                                    break;

                                case "me":
                                    triple.MinProb.Add(Math.Min(1, tripleOne.MinProb[i] + tripleTwo.MinProb[j]));
                                    triple.MaxProb.Add(Math.Min(1, tripleOne.MaxProb[i] + tripleTwo.MaxProb[j]));
                                    break;
                                default: break;
                            }

                        }
                        else
                        {
                            switch (OperationUnion)
                            {
                                case "in":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(tripleOne.MinProb[i] + tripleTwo.MinProb[j] - (tripleOne.MinProb[i] * tripleTwo.MinProb[j]));
                                    triple.MaxProb.Add(tripleOne.MaxProb[i] + tripleTwo.MaxProb[j] - (tripleOne.MaxProb[i] * tripleTwo.MaxProb[j]));

                                    break;

                                case "ig":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(Math.Max(0, tripleOne.MinProb[i] - tripleTwo.MaxProb[j]));
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], 1 - tripleTwo.MinProb[j]));
                                    break;

                                case "me":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(Math.Min(1, tripleOne.MinProb[i] + tripleTwo.MinProb[j]));
                                    triple.MaxProb.Add(Math.Min(1, tripleOne.MaxProb[i] + tripleTwo.MaxProb[j]));
                                    break;
                            }

                        }
                    }
                }
            }
            return triple.Value.Count <= 0 ? null : triple;
        }
        /// <summary>
        /// hàm join hai triple của phéo giao
        /// </summary>
        /// <param name="tripleOne"></param>
        /// <param name="tripleTwo"></param>
        /// <param name="attribute"></param>
        /// <param name="OperationIntersect"></param>
        /// <returns></returns>
        private static FProbTripleBLL JoinTwoTripleIntersect(FProbTripleBLL tripleOne, FProbTripleBLL tripleTwo, FProbAttributeBLL attribute, string OperationIntersect)
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
                                if(disfs1.FuzzySetName == disfs2.FuzzySetName)
                                {
                                    triple.Value.Add(disfs1.FuzzySetName);
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
                            switch (OperationIntersect)
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
                            switch (OperationIntersect)
                            {
                                case "in":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(tripleOne.MinProb[i] * (1 - tripleTwo.MaxProb[j]));
                                    triple.MaxProb.Add(tripleOne.MaxProb[i] * (1 - tripleTwo.MinProb[j]));
                                    break;

                                case "ig":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(Math.Max(0, tripleOne.MinProb[i] - tripleTwo.MaxProb[j]));
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], 1 - tripleTwo.MinProb[j]));
                                    break;

                                case "me":
                                    triple.Value.Add(tripleOne.Value[i]);
                                    triple.MinProb.Add(tripleOne.MinProb[i]);
                                    triple.MaxProb.Add(Math.Min(tripleOne.MaxProb[i], (1 - tripleTwo.MinProb[i])));
                                    break;
                            }

                        }
                    }
                }
            }
            return triple.Value.Count <= 0 ? null : triple;
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
        /// <summary>
        /// hàm thực thi phép hợp giữa hai câu truy vấn
        /// </summary>
        /// <param name="selectedRelation1"></param>
        /// <param name="selectedRelation2"></param>
        /// <returns></returns>
        /// 
        private FProbTupleBLL joinTwoTupleIntersect(FProbTupleBLL tuple1, FProbTupleBLL tuple2, FProbRelationBLL relation)
        {
            FProbTupleBLL result = new FProbTupleBLL();
            for(int i = 0; i < tuple1.FproTriples.Count; i++)
            {
                for(int j = 0; j < tuple2.FproTriples.Count; j++)
                {
                    if (i == j)
                    {
                        var tampResult = JoinTwoTripleIntersect(tuple1.FproTriples[i], tuple2.FproTriples[j], relation.FproSchema.FproAttributes[i], this.OperationIntersect);
                        result.FproTriples.Add(tampResult);
                    }
                }
            }
            return result;
        }
        private FProbTupleBLL joinTwoTupleUnion(FProbTupleBLL tuple1, FProbTupleBLL tuple2, FProbRelationBLL relation)
        {
            FProbTupleBLL result = new FProbTupleBLL();
            for (int i = 0; i < tuple1.FproTriples.Count; i++)
            {
                for (int j = 0; j < tuple2.FproTriples.Count; j++)
                {
                    if (i == j)
                    {
                        var tampResult = JoinTwoTripleUnion(tuple1.FproTriples[i], tuple2.FproTriples[j], relation.FproSchema.FproAttributes[i], this.OperationIntersect);
                        result.FproTriples.Add(tampResult);
                    }
                }
            }
            return result;
        }
        private FProbTupleBLL joinTwoTupleExcept(FProbTupleBLL tuple1, FProbTupleBLL tuple2, FProbRelationBLL relation)
        {
            FProbTupleBLL result = new FProbTupleBLL();
            for (int i = 0; i < tuple1.FproTriples.Count; i++)
            {
                for (int j = 0; j < tuple2.FproTriples.Count; j++)
                {
                    if (i == j)
                    {
                        var tampResult = JoinTwoTripleDiffe(tuple1.FproTriples[i], tuple2.FproTriples[j], relation.FproSchema.FproAttributes[i], this.OperationIntersect);
                        result.FproTriples.Add(tampResult);
                    }
                }
            }
            return result;
        }
        private FProbRelationBLL Union1(FProbRelationBLL selectedRelation1, FProbRelationBLL selectedRelation2)
        {
            FProbRelationBLL relationResult = new FProbRelationBLL();
            List<int> indexsRemove = new List<int>();
            foreach (FProbAttributeBLL attr in selectedRelation1.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation1.RelationName + "." + attr.AttributeName;
            }
            relationResult.FproSchema.FproAttributes.AddRange(selectedRelation1.FproSchema.FproAttributes);
            relationResult.ListRenameRelation.Add(selectedRelation2.RelationName);

            foreach (FProbAttributeBLL attr in selectedRelation2.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation2.RelationName + "." + attr.AttributeName;
            }
            relationResult.FproSchema.FproAttributes.AddRange(selectedRelation2.FproSchema.FproAttributes);
            relationResult.ListRenameRelation.Add(selectedRelation1.RelationName);

            // relation 0
            List<string> atrriButeRelation0 = new List<string>();
            List<FProbAttributeBLL> listAtrribute0 = new List<FProbAttributeBLL>();
            listAtrribute0 = selectedRelation1.FproSchema.FproAttributes;
            for (var i = 0; i < listAtrribute0.Count; i++)
            {
                if (((listAtrribute0[i].FproDataType.TypeName == "String") && (listAtrribute0[i].PrimaryKey == true)) || ((listAtrribute0[i].FproDataType.TypeName == "Int32") && (listAtrribute0[i].PrimaryKey == true)))
                {
                    for (int k = 0; k < selectedRelation1.FproTuples.Count; k++)
                    {
                        if (selectedRelation1.FproTuples[k].FproTriples[i].MinProb[0] == 1 && selectedRelation1.FproTuples[k].FproTriples[i].MaxProb[0] == 1)
                        {
                            atrriButeRelation0.Add(selectedRelation1.FproTuples[k].FproTriples[i].Value[0].ToString());
                        }

                    }
                }
            }
            // relation 1
            List<string> atrributeRelation1 = new List<string>();
            List<FProbAttributeBLL> listAtrribute1 = new List<FProbAttributeBLL>();
            listAtrribute1 = selectedRelation2.FproSchema.FproAttributes;
            for (var i = 0; i < listAtrribute1.Count; i++)
            {
                if (((listAtrribute1[i].FproDataType.TypeName == "String") && (listAtrribute1[i].PrimaryKey == true)) || ((listAtrribute1[i].FproDataType.TypeName == "Int32") && (listAtrribute1[i].PrimaryKey == true)))
                {
                    for (int k = 0; k < selectedRelation2.FproTuples.Count; k++)
                    {
                        if (selectedRelation2.FproTuples[k].FproTriples[i].MinProb[0] == 1 && selectedRelation2.FproTuples[k].FproTriples[i].MaxProb[0] == 1)
                        {
                            atrributeRelation1.Add(selectedRelation2.FproTuples[k].FproTriples[i].Value[0].ToString());
                        }

                    }
                }
            }
            // so sánh từng triple trong relation 0 với danh sách triple trong relation 1
            // nếu triple i không có trong relation 1 thì add tương ứng tuple vào relation kết quả
            for (int i = 0; i < atrriButeRelation0.Count; i++)
            {
                if (AlreadyList(atrributeRelation1, atrriButeRelation0[i]) == false)
                {
                    relationResult.FproTuples.Add(selectedRelation1.FproTuples[i]);
                }
            }
            // so sánh từng triple trong relation 1 với danh sách riple trong relation 0
            // nếu triple i không có trong relation 0 thì add tương ứng tuple vào relation kết quả
            for (int i = 0; i < atrributeRelation1.Count; i++)
            {
                if (AlreadyList(atrriButeRelation0, atrributeRelation1[i]) == false)
                {
                    relationResult.FproTuples.Add(selectedRelation2.FproTuples[i]);
                }
            }
            // nếu có chung khóa thì thực hiện phép hợp dựa vào biểu thức truyền vào.
            // biến lưu trữ các tuple có khóa trùng
            var abc1 = new List<FProbTupleBLL>();
            var abc2 = new List<FProbTupleBLL>();
            //result select 1 is selectedRelation1
            //result select 2 is selectedRelation2
            var list_duplicate = new List<string>();

            for (int i = 0; i < atrriButeRelation0.Count; i++)
            {
                if (AlreadyList(atrributeRelation1, atrriButeRelation0[i]))
                {
                    list_duplicate.Add(atrriButeRelation0[i]);
                }
            }
            // tìm những tuple ở selectRelation1 có khóa trùng với khóa ở list_duplicate
            for (int i = 0; i < list_duplicate.Count; i++)
            {
                for (int j = 0; j < selectedRelation1.FproTuples.Count; j++)
                {
                    if (selectedRelation1.FproTuples[j].FproTriples[0].Value[0].ToString() == list_duplicate[i])
                    {
                        abc1.Add(selectedRelation1.FproTuples[j]);
                    }
                }
            }
            // tìm những tuple ở selectRelation2 có khóa trùng với khóa ở list_duplicate
            for (int i = 0; i < list_duplicate.Count; i++)
            {
                for (int j = 0; j < selectedRelation2.FproTuples.Count; j++)
                {
                    if (selectedRelation2.FproTuples[j].FproTriples[0].Value[0].ToString() == list_duplicate[i])
                    {
                        abc2.Add(selectedRelation2.FproTuples[j]);
                    }
                }
            }
            for (int i = 0; i < abc1.Count; i++)
            {
                for (int j = 0; j < abc2.Count; j++)
                {
                    var tamp_result = joinTwoTupleUnion(abc1[i], abc2[j], selectedRelation1);
                    relationResult.FproTuples.Add(tamp_result);
                }
            }


            OperationUnion = string.Empty;
            flagUnion = false;
            return relationResult;
        }
        /// <summary>
        /// hàm thực thi phép giao giữa hai truy vấn
        /// </summary>
        /// <param name="selectedRelation1"></param>
        /// <param name="selectedRelation2"></param>
        /// <returns></returns>
        private FProbRelationBLL Intersect(FProbRelationBLL selectedRelation1, FProbRelationBLL selectedRelation2)
        {
            FProbRelationBLL relationResult = new FProbRelationBLL();
            List<int> indexsRemove = new List<int>();
            foreach (FProbAttributeBLL attr in selectedRelation1.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation1.RelationName + "." + attr.AttributeName;
            }

            relationResult.FproSchema.FproAttributes.AddRange(selectedRelation1.FproSchema.FproAttributes);
            relationResult.ListRenameRelation.Add(selectedRelation2.RelationName);

            foreach (FProbAttributeBLL attr in selectedRelation2.FproSchema.FproAttributes)
            {
                if (attr.AttributeName.IndexOf(".") == -1)
                    attr.AttributeName = selectedRelation2.RelationName + "." + attr.AttributeName;
            }
            relationResult.FproSchema.FproAttributes.AddRange(selectedRelation2.FproSchema.FproAttributes);


            // relation 0
            List<string> atrriButeRelation0 = new List<string>();
            List<FProbAttributeBLL> listAtrribute = new List<FProbAttributeBLL>();
            listAtrribute = selectedRelation1.FproSchema.FproAttributes;
            for (int i = 0; i < listAtrribute.Count; i++)
            {
                if ((listAtrribute[i].FproDataType.TypeName == "String") && (listAtrribute[i].PrimaryKey == true) || (listAtrribute[i].FproDataType.TypeName == "Int32") && (listAtrribute[i].FproDataType.TypeName == "Int32"))
                {
                    for (int k = 0; k < selectedRelation1.FproTuples.Count; k++)
                    {
                        if (selectedRelation1.FproTuples[k].FproTriples[i].MinProb[0] == 1 && selectedRelation1.FproTuples[k].FproTriples[i].MaxProb[0] == 1)
                        {
                            atrriButeRelation0.Add(selectedRelation1.FproTuples[k].FproTriples[i].Value[0].ToString());
                        }

                    }
                }
            }
            // relation 1
            List<string> atrributeRelation1 = new List<string>();
            List<FProbAttributeBLL> listAtrribute1 = new List<FProbAttributeBLL>();
            listAtrribute1 = selectedRelation2.FproSchema.FproAttributes;
            for (int i = 0; i < listAtrribute1.Count; i++)
            {
                if ((listAtrribute1[i].FproDataType.TypeName == "String") && (listAtrribute1[i].PrimaryKey == true) || (listAtrribute1[i].FproDataType.TypeName == "Int32") && (listAtrribute1[i].PrimaryKey == true))
                {
                    for (int k = 0; k < selectedRelation2.FproTuples.Count; k++)
                    {
                        if (selectedRelation2.FproTuples[k].FproTriples[i].MinProb[0] == 1 && selectedRelation2.FproTuples[k].FproTriples[i].MaxProb[0] == 1)
                        {
                            atrributeRelation1.Add(selectedRelation2.FproTuples[k].FproTriples[i].Value[0].ToString());
                        }

                    }
                }
            }
            // biến lưu trữ các tuple có khóa trùng
            var abc1 = new List<FProbTupleBLL>();
            var abc2 = new List<FProbTupleBLL>();
            //result select 1 is selectedRelation1
            //result select 2 is selectedRelation2
            var list_duplicate = new List<string>();
            
            for (int i = 0; i < atrriButeRelation0.Count; i++)
            {
                if (AlreadyList(atrributeRelation1, atrriButeRelation0[i]))
                {
                    list_duplicate.Add(atrriButeRelation0[i]);
                }
            }
            // tìm những tuple ở selectRelation1 có khóa trùng với khóa ở list_duplicate
            for (int i = 0; i < list_duplicate.Count; i++)
            {
                for (int j = 0; j < selectedRelation1.FproTuples.Count;j++)
                {
                    if(selectedRelation1.FproTuples[j].FproTriples[0].Value[0].ToString() == list_duplicate[i])
                    {
                        abc1.Add(selectedRelation1.FproTuples[j]);
                    }
                }
            }
            // tìm những tuple ở selectRelation2 có khóa trùng với khóa ở list_duplicate
            for (int i = 0; i < list_duplicate.Count; i++)
            {
                for (int j = 0; j < selectedRelation2.FproTuples.Count; j++)
                {
                    if (selectedRelation2.FproTuples[j].FproTriples[0].Value[0].ToString() == list_duplicate[i])
                    {
                        abc2.Add(selectedRelation2.FproTuples[j]);
                    }
                }
            }
            for(int i = 0; i < abc1.Count; i++)
            {
                for(int j = 0; j < abc2.Count; j++)
                {
                    var tamp_result = joinTwoTupleIntersect(abc1[i], abc2[j], selectedRelation1);
                    relationResult.FproTuples.Add(tamp_result);
                }
            }
       
            OperationIntersect = string.Empty;
            flagIntersect = false;
            return relationResult;
        }
        /// <summary>
        /// Important! Execute query
        /// </summary>
        /// <returns></returns>
        internal bool ExecuteQuery()
        {
            try
            {
                string S = this.queryString;
               if (!QueryAnalyze()) return false;
                // kiểm tra câu truy vấn có thực thi phép trừ, giao, hợp  hay không
                if (S.Contains("except") || S.Contains("union") || S.Contains("intersect"))
                {
                    if (S.Contains("except"))
                    {
                        // thực thi câu truy vấn ở vế đầu 
                        if (this.selectedRelation1.Count == 2)
                        {
                            if (flagNaturalJoin != true)
                                this.selectedRelation1[0] = Descartes(this.selectedRelation1[0], this.selectedRelation1[1]);
                            else
                                this.selectedRelation1[0] = NaturalJoin(this.selectedRelation1[0], this.selectedRelation1[1]);
                        }
                        else
                        {
                            foreach (FProbAttributeBLL attr in this.selectedRelation1[0].FproSchema.FproAttributes)
                            {
                                if (!attr.AttributeName.Contains("."))
                                    attr.AttributeName = String.Format("{0}.{1}", this.selectedRelation1[0].RelationName, attr.AttributeName);
                            }
                        }
                        if (!this.query_1.Contains("where"))
                        {
                            this.relationResult1 = getRelationBySelectAttribute(this.selectedRelation1[0], this.selectedAttribute1);

                        }
                        else
                        {
                            SelectConditionBLL Condition = new SelectConditionBLL(this.selectedRelation1[0], this.conditionString1);
                            if (!Condition.CheckConditionString())
                            {
                                this.MessageError = Condition.MessageError;
                                return false;
                            }

                            foreach (FProbTupleBLL tuple in this.selectedRelation1[0].FproTuples)
                                if (Condition.Satisfied(tuple))
                                    this.relationResult1.FproTuples.Add(tuple);

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

                            this.relationResult1.FproSchema = this.selectedRelation1[0].FproSchema;
                            this.relationResult1 = getRelationBySelectAttribute(this.relationResult1, this.selectedAttribute1);
                        }
                        // thực thi câu truy vấn ở vế đầu 


                        // thực thi câu truy vấn ở vế 2
                        if (this.selectedRelation2.Count == 2)
                        {
                            if (flagNaturalJoin != true)
                                this.selectedRelation2[0] = Descartes(this.selectedRelation2[0], this.selectedRelation2[1]);
                            else
                                this.selectedRelation2[0] = NaturalJoin(this.selectedRelation2[0], this.selectedRelation2[1]);
                        }
                        else
                        {
                            foreach (FProbAttributeBLL attr in this.selectedRelation2[0].FproSchema.FproAttributes)
                            {
                                if (!attr.AttributeName.Contains("."))
                                    attr.AttributeName = String.Format("{0}.{1}", this.selectedRelation1[0].RelationName, attr.AttributeName);
                            }
                        }
                        if (!this.query_2.Contains("where"))
                        {
                            this.relationResult2 = getRelationBySelectAttribute(this.selectedRelation2[0], this.selectedAttribute2);
                        }
                        else
                        {
                            SelectConditionBLL Condition = new SelectConditionBLL(this.selectedRelation2[0], this.conditionString2);
                            if (!Condition.CheckConditionString())
                            {
                                this.MessageError = Condition.MessageError;
                                return false;
                            }

                            foreach (FProbTupleBLL tuple in this.selectedRelation2[0].FproTuples)
                                if (Condition.Satisfied(tuple))
                                    this.relationResult2.FproTuples.Add(tuple);

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

                            this.relationResult2.FproSchema = this.selectedRelation2[0].FproSchema;
                            this.relationResult2 = getRelationBySelectAttribute(this.relationResult2, this.selectedAttribute2);
                        }
                        this.relationResult = Difference(this.relationResult1, this.relationResult2);
                    }
                    if (S.Contains("union"))
                    {
                        // thực thi câu truy vấn ở vế đầu 
                        if (this.selectedRelation1.Count == 2)
                        {
                            if (flagNaturalJoin != true)
                                this.selectedRelation1[0] = Descartes(this.selectedRelation1[0], this.selectedRelation1[1]);
                            else
                                this.selectedRelation1[0] = NaturalJoin(this.selectedRelation1[0], this.selectedRelation1[1]);
                        }
                        else
                        {
                            foreach (FProbAttributeBLL attr in this.selectedRelation1[0].FproSchema.FproAttributes)
                            {
                                if (!attr.AttributeName.Contains("."))
                                    attr.AttributeName = String.Format("{0}.{1}", this.selectedRelation1[0].RelationName, attr.AttributeName);
                            }
                        }
                        if (!this.query_1.Contains("where"))
                        {
                            this.relationResult1 = getRelationBySelectAttribute(this.selectedRelation1[0], this.selectedAttribute1);
                        }
                        else
                        {
                            SelectConditionBLL Condition = new SelectConditionBLL(this.selectedRelation1[0], this.conditionString1);
                            if (!Condition.CheckConditionString())
                            {
                                this.MessageError = Condition.MessageError;
                                return false;
                            }

                            foreach (FProbTupleBLL tuple in this.selectedRelation1[0].FproTuples)
                                if (Condition.Satisfied(tuple))
                                    this.relationResult1.FproTuples.Add(tuple);

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

                            this.relationResult1.FproSchema = this.selectedRelation1[0].FproSchema;
                            this.relationResult1 = getRelationBySelectAttribute(this.relationResult1, this.selectedAttribute1);
                        }
                        // thực thi câu truy vấn ở vế đầu 


                        // thực thi câu truy vấn ở vế 2
                        if (this.selectedRelation2.Count == 2)
                        {
                            if (flagNaturalJoin != true)
                                this.selectedRelation2[0] = Descartes(this.selectedRelation2[0], this.selectedRelation2[1]);
                            else
                                this.selectedRelation2[0] = NaturalJoin(this.selectedRelation2[0], this.selectedRelation2[1]);
                        }
                        else
                        {
                            foreach (FProbAttributeBLL attr in this.selectedRelation2[0].FproSchema.FproAttributes)
                            {
                                if (!attr.AttributeName.Contains("."))
                                    attr.AttributeName = String.Format("{0}.{1}", this.selectedRelation1[0].RelationName, attr.AttributeName);
                            }
                        }
                        if (!this.query_2.Contains("where"))
                        {
                            this.relationResult2 = getRelationBySelectAttribute(this.selectedRelation2[0], this.selectedAttribute2);
                        }
                        else
                        {
                            SelectConditionBLL Condition = new SelectConditionBLL(this.selectedRelation2[0], this.conditionString2);
                            if (!Condition.CheckConditionString())
                            {
                                this.MessageError = Condition.MessageError;
                                return false;
                            }

                            foreach (FProbTupleBLL tuple in this.selectedRelation2[0].FproTuples)
                                if (Condition.Satisfied(tuple))
                                    this.relationResult2.FproTuples.Add(tuple);

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

                            this.relationResult2.FproSchema = this.selectedRelation2[0].FproSchema;
                            this.relationResult2 = getRelationBySelectAttribute(this.relationResult2, this.selectedAttribute2);
                        }
                        this.relationResult.FproSchema = this.selectedRelation2[0].FproSchema;
                        this.relationResult = Union1(this.relationResult1, this.relationResult2);
                        return true;
                    }
                    if (S.Contains("intersect"))
                    {
                        // thực thi câu truy vấn ở vế đầu 
                        if (this.selectedRelation1.Count == 2)
                        {
                            if (flagNaturalJoin != true)
                                this.selectedRelation1[0] = Descartes(this.selectedRelation1[0], this.selectedRelation1[1]);
                            else
                                this.selectedRelation1[0] = NaturalJoin(this.selectedRelation1[0], this.selectedRelation1[1]);
                        }
                        else
                        {
                            foreach (FProbAttributeBLL attr in this.selectedRelation1[0].FproSchema.FproAttributes)
                            {
                                if (!attr.AttributeName.Contains("."))
                                    attr.AttributeName = String.Format("{0}.{1}", this.selectedRelation1[0].RelationName, attr.AttributeName);
                            }
                        }
                        if (!this.query_1.Contains("where"))
                        {
                            this.relationResult1 = getRelationBySelectAttribute(this.selectedRelation1[0], this.selectedAttribute1);
                        }
                        else
                        {
                            SelectConditionBLL Condition = new SelectConditionBLL(this.selectedRelation1[0], this.conditionString1);
                            if (!Condition.CheckConditionString())
                            {
                                this.MessageError = Condition.MessageError;
                                return false;
                            }

                            foreach (FProbTupleBLL tuple in this.selectedRelation1[0].FproTuples)
                                if (Condition.Satisfied(tuple))
                                    this.relationResult1.FproTuples.Add(tuple);

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

                            this.relationResult1.FproSchema = this.selectedRelation1[0].FproSchema;
                            this.relationResult1 = getRelationBySelectAttribute(this.relationResult1, this.selectedAttribute1);
                        }
                        // thực thi câu truy vấn ở vế đầu 


                        // thực thi câu truy vấn ở vế 2
                        if (this.selectedRelation2.Count == 2)
                        {
                            if (flagNaturalJoin != true)
                                this.selectedRelation2[0] = Descartes(this.selectedRelation2[0], this.selectedRelation2[1]);
                            else
                                this.selectedRelation2[0] = NaturalJoin(this.selectedRelation2[0], this.selectedRelation2[1]);
                        }
                        else
                        {
                            foreach (FProbAttributeBLL attr in this.selectedRelation2[0].FproSchema.FproAttributes)
                            {
                                if (!attr.AttributeName.Contains("."))
                                    attr.AttributeName = String.Format("{0}.{1}", this.selectedRelation1[0].RelationName, attr.AttributeName);
                            }
                        }
                        if (!this.query_2.Contains("where"))
                        {
                            this.relationResult2 = getRelationBySelectAttribute(this.selectedRelation2[0], this.selectedAttribute2);
                        }
                        else
                        {
                            SelectConditionBLL Condition = new SelectConditionBLL(this.selectedRelation2[0], this.conditionString2);
                            if (!Condition.CheckConditionString())
                            {
                                this.MessageError = Condition.MessageError;
                                return false;
                            }

                            foreach (FProbTupleBLL tuple in this.selectedRelation2[0].FproTuples)
                                if (Condition.Satisfied(tuple))
                                    this.relationResult2.FproTuples.Add(tuple);

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

                            this.relationResult2.FproSchema = this.selectedRelation2[0].FproSchema;
                            this.relationResult2 = getRelationBySelectAttribute(this.relationResult2, this.selectedAttribute2);
                        }
                        this.relationResult = Intersect(this.relationResult1, this.relationResult2);
                    }
                }
                else
                {
                    if (this.selectedRelations.Count == 2)
                    {
                        if (flagNaturalJoin != true)
                            this.selectedRelations[0] = Descartes(this.selectedRelations[0], this.selectedRelations[1]);
                        else
                            this.selectedRelations[0] = NaturalJoin(this.selectedRelations[0], this.selectedRelations[1]);
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
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
