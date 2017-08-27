using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPRDB.BLL
{
    public class ProbSubSetBLL
    {
        private List<double> subset;
        private double massSubset;
        public List<double> Subset
        {
          get { return subset; }
          set { subset = value; }
        }
        public double MassSubset
        {
          get { return massSubset; }
          set { massSubset = value; }
        }
        public ProbSubSetBLL()
        {
            this.subset = new List<double>();
            this.massSubset = 0.0;
        }
        public ProbSubSetBLL(ProbSubSetBLL pro)
        {
            this.subset = pro.subset;
            this.massSubset = pro.massSubset;
        }
        public ProbSubSetBLL(List<double> sub, double mass)
        {
            this.subset = sub;
            this.massSubset = mass;
        }
    }
}
