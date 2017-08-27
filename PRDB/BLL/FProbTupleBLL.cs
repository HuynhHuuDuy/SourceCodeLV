using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class FProbTupleBLL
    {
        private List<FProbTripleBLL> fproTriples;

        public List<FProbTripleBLL> FproTriples
        {
          get { return fproTriples; }
          set { fproTriples = value; }
        }
        public FProbTupleBLL()
        {
            this.fproTriples=new List<FProbTripleBLL>();
        }
        public FProbTupleBLL(FProbTupleBLL fproTuple)
        {
            this.fproTriples = new List<FProbTripleBLL>();
            foreach (FProbTripleBLL item in fproTuple.fproTriples)
            {
                FProbTripleBLL triple = new FProbTripleBLL(item);
                this.fproTriples.Add(triple);
            }
        }
        internal List<FProbTupleBLL> getAllTypleByRelationName(string relationname, int nTriples)
        {
            return FProbTupleDAL.getAllTypleByRelationName(relationname, nTriples);
        }
    }
}
