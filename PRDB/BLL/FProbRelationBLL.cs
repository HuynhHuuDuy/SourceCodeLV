using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class FProbRelationBLL
    {
        private int idRelation;
        private FProbSchemaBLL fproSchema;
        private string relationName;
        private string renameRelationName;
        private List<string> listRenameRelation;
        private List<FProbTupleBLL> fproTuples;
        public int IdRelation
        {
          get { return idRelation; }
          set { idRelation = value; }
        }
        public FProbSchemaBLL FproSchema
        {
          get { return fproSchema; }
          set { fproSchema = value; }
        }
        public string RelationName
        {
          get { return relationName; }
          set { relationName = value; }
        }
        public string RenameRelationName
        {
          get { return renameRelationName; }
          set { renameRelationName = value; }
        }
        public List<string> ListRenameRelation
        {
          get { return listRenameRelation; }
          set { listRenameRelation = value; }
        }
        public List<FProbTupleBLL> FproTuples
        {
          get { return fproTuples; }
          set { fproTuples = value; }
        }
        public FProbRelationBLL()
        {
            this.idRelation=-1;
            this.fproSchema=new FProbSchemaBLL();
            this.fproTuples=new List<FProbTupleBLL>();
            this.relationName=string.Empty;
            this.renameRelationName=string.Empty;
            this.listRenameRelation=new List<string>();
        }
        public FProbRelationBLL(string relationName)
        {
            this.idRelation=-1;
            this.fproSchema=new FProbSchemaBLL();
            this.fproTuples=new List<FProbTupleBLL>();
            this.relationName=relationName;
            this.renameRelationName=string.Empty;
            this.listRenameRelation=new List<string>();
        }
        public FProbRelationBLL(int IDRelation, string relationName, List<FProbTupleBLL> tuples, FProbSchemaBLL schema)
        {
            this.idRelation=IDRelation;
            this.fproSchema=schema;
            this.fproTuples=tuples;
            this.relationName=relationName;
            this.renameRelationName=string.Empty;
            this.listRenameRelation=new List<string>();
        }
        internal List<FProbRelationBLL> getAllRelation()
        {
            return FProbRelationDAL.getAllRelation();
        }
        internal void DropTableByTableName()
        {
            FProbRelationDAL.DropTableByTableName(this);
        }
        internal void DeleteAllRelation()
        {
            FProbRelationDAL.DeleteAllRelation();
        }
        internal void InsertSystemRelation()
        {
            FProbRelationDAL.InsertSystemRelation(this);
        }
        internal void CreateTableRelation()
        {
            FProbRelationDAL.CreateTableRelation(this);
        }
        internal void InsertTupleIntoTableRelation()
        {
            FProbRelationDAL.InsertTupleIntoTableRelation(this);
        }
        internal void DeleteRelationById()
        {
            FProbRelationDAL.DeleteRelationById(this);
        }
    }
}
