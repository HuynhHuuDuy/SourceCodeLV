using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class FProbQueryBLL
    {
        private int idQuery;
        private string queryName;
        private string queryString;
        public int IdQuery
        {
          get { return idQuery; }
          set { idQuery = value; }
        }
        public string QueryName
        {
          get { return queryName; }
          set { queryName = value; }
        }
        public string QueryString
        {
          get { return queryString; }
          set { queryString = value; }
        }
        public FProbQueryBLL()
        {
            this.idQuery=-1;
            this.queryName=string.Empty;
            this.queryString=string.Empty;
        }
        public FProbQueryBLL(string name)
        {
            this.idQuery=-1;
            this.queryName=name;
            this.queryString=string.Empty;
        }
        public FProbQueryBLL(string name, int Id, string query)
        {
            this.idQuery=Id;
            this.queryName=name;
            this.queryString=query;
        }
        internal List<FProbQueryBLL> getAllQuery()
        {
            return FProbQueryDAL.getAllQuery();
        }
        internal void DeleteAllQuery()
        {
            FProbQueryDAL.DeleteAllQuery();
        }
        internal void Insert()
        {
            FProbQueryDAL.Insert(this);
        }
        internal FProbQueryBLL getQueryByName()
        {
            return FProbQueryDAL.getQueryByName(this);
        }
        internal void Update()
        {
            FProbQueryDAL.Update(this);
        }
        internal void DeleteById()
        {
            FProbQueryDAL.DeleteById(this);
        }
    }
}
