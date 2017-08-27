using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class FProbDatabaseBLL
    {
        private string dbName;
        private string connectString;
        private string dbPath;
        private List<FProbSchemaBLL> fproSchemas;
        private List<FProbRelationBLL> fproRelations;
        private List<FProbQueryBLL> fproQueries;
        private DataSet dataSet;
        public string DbName
        {
          get { return dbName; }
          set { dbName = value; }
        }
        public string ConnectString
        {
          get { return connectString; }
          set { connectString = value; }
        }
        public string DbPath
        {
          get { return dbPath; }
          set { dbPath = value; }
        }
        public List<FProbSchemaBLL> FproSchemas
        {
          get { return fproSchemas; }
          set { fproSchemas = value; }
        }
        public List<FProbRelationBLL> FproRelations
        {
          get { return fproRelations; }
          set { fproRelations = value; }
        }
        public List<FProbQueryBLL> FproQueries
        {
          get { return fproQueries; }
          set { fproQueries = value; }
        }
        public DataSet DataSet
        {
          get { return dataSet; }
          set { dataSet = value; }
        }
        public FProbDatabaseBLL(FProbDatabaseBLL probDatabase)
        {
            this.dbPath = probDatabase.dbPath;
            this.dbName = probDatabase.dbName;
            this.connectString = probDatabase.connectString;
            this.dataSet = probDatabase.dataSet;
            this.fproRelations = probDatabase.fproRelations;
            this.fproQueries = probDatabase.fproQueries;
            this.fproSchemas = probDatabase.fproSchemas;    
        }
        public FProbDatabaseBLL(){}
        public FProbDatabaseBLL(string path)
        {
            // Lấy đường dẫn cho CSDL 
            this.dbPath = path;
            this.dbName = "";

            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] == '\\') break;
                else this.dbName = path[i] + dbName;
            }
            // Đặt chuỗi kết nối
            this.ConnectString = "Data Source=" + dbPath + ";Version=3;";

            this.dbName = CutExtension(dbName);
            this.fproRelations = new List<FProbRelationBLL>();
            this.fproQueries = new List<FProbQueryBLL>();
            this.fproSchemas = new List<FProbSchemaBLL>();
        }
        public FProbDatabaseBLL(string path, FProbDatabaseBLL probDatabase)
        {
            // Lấy đường dẫn cho CSDL 
            this.dbPath = path;
            this.dbName = "";

            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] == '\\') break;
                else this.dbName = path[i] + dbName;
            }
            // Đặt chuỗi kết nối
            this.ConnectString = "Data Source=" + dbPath + ";Version=3;";

            this.dbName = CutExtension(dbName);
            this.dataSet = probDatabase.dataSet;
            this.fproRelations = probDatabase.fproRelations;
            this.fproQueries = probDatabase.fproQueries;
            this.fproSchemas = probDatabase.fproSchemas;    
        }
        private string CutExtension(string name)
        {
            for (int i = name.Length - 1; i >= 0; i--)
                if (name[i] == '.')
                {
                    name = name.Remove(i);
                    break;
                }
            return name;
        }
        internal bool CreateNewDatabase()
        {
            return FProbDatabaseDAL.CreateNewDatabase(this);
        }
        internal FProbDatabaseBLL OpenExistingDatabase()
        {
            return FProbDatabaseDAL.OpenExistingDatabase(this);
        }
        internal bool SaveDatabase()
        {
            return FProbDatabaseDAL.SaveDatabase(this);
        }
        internal List<string> ListOfSchemeNameToLower()
        {
            List<string> List = new List<string>();
            foreach (FProbSchemaBLL schema in this.fproSchemas)
                List.Add(schema.SchemaName.ToLower().Trim());
            return List;
        }
        internal List<string> ListOfRelationNameToLower()
        {
            List<string> List = new List<string>();
            foreach (FProbRelationBLL relation in this.fproRelations)
                List.Add(relation.RelationName.ToLower().Trim());
            return List;
        }
        internal List<string> ListOfQueryNameToLower()
        {
            List<string> List = new List<string>();
            foreach (FProbQueryBLL query in this.fproQueries)
                List.Add(query.QueryName.ToLower().Trim());
            return List;
        }
    }
}
