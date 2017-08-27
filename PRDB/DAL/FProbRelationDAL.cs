using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.Data;

namespace FPRDB.DAL
{
    public static class FProbRelationDAL
    {
        internal static List<FProbRelationBLL> getAllRelation()
        {
            //"SELECT * FROM SystemRelation", "system_relation")

            List<FProbRelationBLL> relations = new List<FProbRelationBLL>();
            DataBase db = new DataBase();
            DataSet dts = new DataSet();
            dts.Tables.Add(db.GetDataTable("SELECT * FROM SystemRelation", "system_relation"));
            try
            {
                foreach (DataRow row in dts.Tables["system_relation"].Rows)
                {
                    string relationname = row[1].ToString();
                    int schemeID = Convert.ToInt16(row[2]);
                    FProbSchemaBLL schemeName = new FProbSchemaBLL(schemeID).getSchemeById();
                    List<FProbTupleBLL> probTuples = new List<FProbTupleBLL>();
                    int nTriples = schemeName.FproAttributes.Count;
                    probTuples = new FProbTupleBLL().getAllTypleByRelationName(relationname, nTriples);
                    FProbRelationBLL relation = new FProbRelationBLL(Convert.ToInt16(row[0]), relationname, probTuples, schemeName);
                    relations.Add(relation);
                }
                return relations;
            }
            catch
            {
                return null;
            }
        }
        internal static void DropTableByTableName(FProbRelationBLL probRelation)
        {
            DataBase db = new DataBase();
            if (!db.DropTable(probRelation.RelationName))
                throw new Exception(db.errorMessage);
        }
        internal static void DeleteAllRelation()
        {
            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemRelation"))
                throw new Exception(db.errorMessage);
        }
        internal static void InsertSystemRelation(FProbRelationBLL probRelation)
        {
            if (probRelation.IdRelation == -1)
            {
                probRelation.IdRelation = new DataBase().GetMaxIdInTable("SystemRelation");
            }

            DataBase db = new DataBase();
            string SQL = "";
            SQL = "";
            SQL += "INSERT INTO SystemRelation VALUES ( ";
            SQL += probRelation.IdRelation + ",";
            SQL += "'" + probRelation.RelationName + "'" + ",";
            SQL += probRelation.FproSchema.IdSchema;
            SQL += " );";
            if (!db.Update(SQL))
            {
                throw new Exception(db.errorMessage);
            }
        }
        internal static void CreateTableRelation(FProbRelationBLL probRelation)
        {
            if (probRelation.FproSchema.FproAttributes.Count > 0)
            {
                DataBase db = new DataBase();
                string SQL = "";
                SQL += "CREATE TABLE " + probRelation.RelationName + " ( ";
                foreach (FProbAttributeBLL attribute in probRelation.FproSchema.FproAttributes)
                {
                    SQL += attribute.AttributeName + " " + "TEXT" + ", ";
                }
                SQL = SQL.Remove(SQL.LastIndexOf(','), 1);
                SQL += " ); ";

                if (!db.CreateTable(SQL))
                    throw new Exception(db.errorMessage);
            }
        }
        internal static void InsertTupleIntoTableRelation(FProbRelationBLL probRelation)
        {
            DataBase db = new DataBase();
            if (probRelation.FproTuples.Count > 0)
            {
                foreach (FProbTupleBLL tuple in probRelation.FproTuples)
                {
                    string SQL = "";
                    SQL += "INSERT INTO " + probRelation.RelationName + " VALUES (";
                    foreach (FProbTripleBLL triple in tuple.FproTriples)
                    {
                        SQL += "'" + triple.GetStrValue() + "'" + ",";
                    }
                    SQL = SQL.Remove(SQL.LastIndexOf(','), 1);
                    SQL += " );  ";

                    if (!db.Update(SQL))
                        throw new Exception(db.errorMessage);
                }
            }
        }
        internal static void DeleteRelationById(FProbRelationBLL probRelation)
        {

            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemRelation where ID = " + probRelation.IdRelation))
                throw new Exception(db.errorMessage);
        }
    }
}
