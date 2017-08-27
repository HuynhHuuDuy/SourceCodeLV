using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class FProbAttributeBLL
    {
        private bool primaryKey;
        private int idAttribute;
        private string attributeName;
        private FProDataTypeBLL fproDataType;
        private string description;
        private FProbSchemaBLL fproSchema;
        public bool PrimaryKey
        {
          get { return primaryKey; }
          set { primaryKey = value; }
        }
        public int IdAttribute
        {
          get { return idAttribute; }
          set { idAttribute = value; }
        }
        public string AttributeName
        {
          get { return attributeName; }
          set { attributeName = value; }
        }
        public FProDataTypeBLL FproDataType
        {
          get { return fproDataType; }
          set { fproDataType = value; }
        }
        public string Description
        {
          get { return description; }
          set { description = value; }
        }
        public FProbSchemaBLL FproSchema
        {
          get { return fproSchema; }
          set { fproSchema = value; }
        }
        public FProbAttributeBLL()
        {
            this.primaryKey=false;
            this.idAttribute=-1;
            this.attributeName=string.Empty;
            this.fproDataType=new FProDataTypeBLL();
            this.description=string.Empty;
            this.fproSchema=new FProbSchemaBLL();
        }
        public FProbAttributeBLL(FProbAttributeBLL attr)
        {
            this.primaryKey=attr.primaryKey;
            this.idAttribute=attr.idAttribute;
            this.attributeName=attr.attributeName;
            this.fproDataType=attr.fproDataType;
            this.description=attr.description;
            this.fproSchema=attr.fproSchema;
        }
        internal List<FProbAttributeBLL> getListAttributeByIDScheme(int IDScheme)
        {
            return FProbAttributeDAL.getListAttributeByIDScheme(IDScheme);
        }
        internal void DeleteAllAttribute()
        {
            FProbAttributeDAL.DeleteAllAttribute();
        }
        internal void Insert()
        {
            FProbAttributeDAL.Insert(this);
        }
        internal int getMaxIdinTable()
        {
            return FProbAttributeDAL.getMaxIdinTable();
        }
        internal void DeleteAllAttributeByIdScheme()
        {
            FProbAttributeDAL.DeleteAllAttributeByIdScheme(this);
        }
    }
}
