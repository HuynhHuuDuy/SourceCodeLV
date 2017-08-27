using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.Data;

namespace FPRDB.DAL
{
    public static class FProbTupleDAL
    {
        internal static List<FProbTupleBLL> getAllTypleByRelationName(string relationname, int nTriples)
        {
            List<FProbTupleBLL> probTuple = new List<FProbTupleBLL>();
            DataBase db = new DataBase();
            DataTable dtb = db.GetDataTable("Select * From " + relationname);

            foreach (DataRow tuplerow in dtb.Rows)
            {
                FProbTupleBLL NewTuple = new FProbTupleBLL();

                for (int i = 0; i < nTriples; i++)
                {
                    FProbTripleBLL NewTriple = new FProbTripleBLL(tuplerow[i].ToString());
                    NewTuple.FproTriples.Add(NewTriple);
                }

                probTuple.Add(NewTuple);
            }
            return probTuple;
        }
    }
}
