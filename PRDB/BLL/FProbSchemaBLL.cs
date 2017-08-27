using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class FProbSchemaBLL
    {
        private int idSchema;
        private string schemaName;
        private List<FProbAttributeBLL> fproAttributes;
        public int IdSchema
        {
          get { return idSchema; }
          set { idSchema = value; }
        }
        public string SchemaName
        {
          get { return schemaName; }
          set { schemaName = value; }
        }
        public List<FProbAttributeBLL> FproAttributes
        {
          get { return fproAttributes; }
          set { fproAttributes = value; }
        }
        public FProbSchemaBLL()
        {
            this.idSchema=-1;
            this.schemaName = "No Name";
            this.fproAttributes=new List<FProbAttributeBLL>();
        }
        public FProbSchemaBLL(int id)
        {
            this.idSchema=id;
            this.schemaName = "No Name";
            this.fproAttributes=new List<FProbAttributeBLL>();
        }
        public FProbSchemaBLL(string schemaname)
        {
            this.idSchema=-1;
            this.schemaName=schemaname;
            this.fproAttributes=new List<FProbAttributeBLL>();
        }
        public FProbSchemaBLL(int ID, string name, List<FProbAttributeBLL> Attributes)
        {
            this.idSchema=ID;
            this.schemaName=name;
            this.fproAttributes = new List<FProbAttributeBLL>();

            foreach (FProbAttributeBLL item in Attributes)
             {
                 FProbAttributeBLL attr = new FProbAttributeBLL();
                 attr.AttributeName=item.AttributeName;
                 attr.Description=item.Description;
                 attr.IdAttribute=item.IdAttribute;
                 attr.PrimaryKey=item.PrimaryKey;
                 attr.FproDataType = new FProDataTypeBLL(item.FproDataType);
                 this.fproAttributes.Add(attr);
            }
        }
        internal List<FProbSchemaBLL> getAllScheme()
        {
            return FProbSchemaDAL.getAllScheme();
        }
        internal FProbSchemaBLL getSchemeById()
        {
            return FProbSchemaDAL.getSchemeById(this);
        }
        internal void DeleteAllScheme()
        {
            FProbSchemaDAL.DeleteAllScheme();
        }
        internal void Insert()
        {
            FProbSchemaDAL.Insert(this);
        }
        internal int getMaxIdinTable()
        {
            return FProbSchemaDAL.getMaxIdinTable();
        }
        internal bool isInherited(List<FProbRelationBLL> Relations)
        {
            try
            {
                foreach (FProbRelationBLL relation in Relations)
                    if (this.SchemaName.Equals(relation.FproSchema.SchemaName, StringComparison.OrdinalIgnoreCase))
                        return true;
            }
            catch { }
            return false;
        }
        internal void Update()
        {
            FProbSchemaDAL.Update(this);
        }
        internal void DeleteSchemeById()
        {
            FProbSchemaDAL.DeleteSchemeById(this);
        }
        internal List<int> ListIndexPrimaryKey()
        {
            List<int> indexs = new List<int>();

            for (int i = 0; i < this.fproAttributes.Count; i++)
            {
                if (this.fproAttributes[i].PrimaryKey)
                    indexs.Add(i);
            }
            return indexs;
        }
        internal List<string> ListOfAttributeNameToLower()
        {
            List<string> list = new List<string>();

            foreach (FProbAttributeBLL item in this.fproAttributes)
            {
                list.Add(item.AttributeName.ToLower());

            }

            return list;
        }
    }
}
