using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.Data.SQLite;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace FPRDB.DAL
{
    public class FProbDatabaseDAL
    {
        internal static bool CreateNewDatabase(FProbDatabaseBLL probDatabase)
        {
            try
            {
                SQLiteConnection.CreateFile(probDatabase.DbPath);
                DataBase db = new DataBase(probDatabase.ConnectString);
                string strSQL = "";
                // Record set of schemes to the database system
                strSQL += "CREATE TABLE SystemScheme ( ID INT, SchemeName NVARCHAR(255) );";
                if (!db.CreateTable(strSQL))
                    throw new Exception(db.errorMessage);
                // Record set of relations to the database system
                strSQL = "";
                strSQL += "CREATE TABLE SystemRelation (ID INT,RelationName NVARCHAR(255), SchemeID INT );";
                if (!db.CreateTable(strSQL))
                    throw new Exception(db.errorMessage);
                // Record set of attributes to the database system  
                strSQL = "";
                strSQL += "CREATE TABLE SystemAttribute (ID INT,PrimaryKey NVARCHAR(10),AttributeName NVARCHAR(255),DataType NVARCHAR(255),Domain TEXT,Description TEXT,SchemeID INT ); ";
                if (!db.CreateTable(strSQL))
                    throw new Exception(db.errorMessage);
                // Record set of queries to the database system
                strSQL = "";
                strSQL += "CREATE TABLE SystemQuery (ID INT,QueryName NVARCHAR(255),QueryString TEXT );";
                if (!db.CreateTable(strSQL))
                {
                    XtraMessageBox.Show("Error : " + db.errorMessage + " please try again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
                return false;
            }
            return true;
        }
        internal static FProbDatabaseBLL OpenExistingDatabase(FProbDatabaseBLL probDatabase)
        {
            FProbDatabaseBLL newProbDatabase = new FProbDatabaseBLL(probDatabase);
            try
            {

                List<FProbSchemaBLL> Schemes = new List<FProbSchemaBLL>();
                Schemes = new FProbSchemaBLL().getAllScheme();
                newProbDatabase.FproSchemas = Schemes;

                List<FProbRelationBLL> relations = new List<FProbRelationBLL>();
                relations = new FProbRelationBLL().getAllRelation();
                newProbDatabase.FproRelations = relations;

                List<FProbQueryBLL> querys = new List<FProbQueryBLL>();
                querys = new FProbQueryBLL().getAllQuery();
                newProbDatabase.FproQueries = querys;
            }
            catch (Exception)
            {
                return null;
            }
            return newProbDatabase;
        }
        private static bool DropDatabaseData()
        {
            try
            {
                List<FProbRelationBLL> relations = new List<FProbRelationBLL>();
                relations = new FProbRelationBLL().getAllRelation();

                foreach (FProbRelationBLL item in relations)
                {
                    item.DropTableByTableName();
                }

                FProbSchemaBLL probScheme = new FProbSchemaBLL();
                probScheme.DeleteAllScheme();

                FProbRelationBLL probRelation = new FProbRelationBLL();
                probRelation.DeleteAllRelation();

                FProbAttributeBLL probAttribute = new FProbAttributeBLL();
                probAttribute.DeleteAllAttribute();

                FProbQueryBLL probQuery = new FProbQueryBLL();
                probQuery.DeleteAllQuery();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                return false;
            }
            return true;
        }
        internal static bool SaveDatabase(FProbDatabaseBLL probDatabase)
        {
            try
            {
                //Drop data base
                DropDatabaseData();
                int schemeID = 0;
                int attributeID = 0;

                #region Save Scheme
                foreach (FProbSchemaBLL scheme in probDatabase.FproSchemas)
                {
                    /// Save Schemes 
                    schemeID++;
                    scheme.SchemaName = scheme.SchemaName.ToLower().Trim();
                    scheme.IdSchema = schemeID;
                    scheme.Insert();

                    ///Save attributes of the scheme to the System Attribute Table
                    foreach (FProbAttributeBLL attr in scheme.FproAttributes)
                    {
                        attributeID++;
                        attr.FproSchema = scheme;
                        attr.AttributeName = attr.AttributeName.Trim();
                        attr.IdAttribute = attributeID;
                        attr.Insert();
                    }
                }
                #endregion

                #region Save Relations
                int relationID = 0;
                foreach (FProbRelationBLL relation in probDatabase.FproRelations)
                {
                    relationID++;
                    relation.IdRelation = relationID;
                    relation.RelationName = relation.RelationName.ToLower().Trim();
                    relation.InsertSystemRelation();

                    /// Create Table <Relation> //
                    relation.CreateTableRelation();

                    // Insert tuples into Talbe <Relation> //
                    relation.InsertTupleIntoTableRelation();
                }
                #endregion

                #region Save Query
                int queryID = 0;
                foreach (FProbQueryBLL item in probDatabase.FproQueries)
                {
                    queryID++;
                    item.QueryName = item.QueryName.ToLower().Trim();
                    item.IdQuery = queryID;
                    item.Insert();
                }
                #endregion
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show(Ex.Message);
                return false;
            }
            return true;
        }
    }
}
