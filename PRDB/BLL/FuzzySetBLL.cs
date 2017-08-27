using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPRDB.BLL
{
    public class FuzzySetBLL
    {
        private string fuzzySetName;
        private Hashtable fuzzySet;

        public string FuzzySetName 
        {
            get { return fuzzySetName; }
            set { fuzzySetName = value; }
        }
        public Hashtable FuzzySet 
        {
            get { return fuzzySet; }
            set { fuzzySet = value; }
        }

        public FuzzySetBLL() 
        {
            this.fuzzySetName = string.Empty;
            this.fuzzySet = new Hashtable();
        }
        public FuzzySetBLL(Hashtable valfuzzySet) 
        {
            this.fuzzySetName = string.Empty;
            this.fuzzySet = valfuzzySet;
        }
        public FuzzySetBLL(string name)
        {
            this.fuzzySetName = name;
            this.fuzzySet = new Hashtable();
        }
        public FuzzySetBLL(string valfuzzySetName, Hashtable valfuzzySet): this(valfuzzySet) 
        {
            this.fuzzySetName = valfuzzySetName;
        }
        public FuzzySetBLL(FuzzySetBLL valfuzzySetBLL) 
        {
            this.fuzzySetName = valfuzzySetBLL.fuzzySetName;
            this.fuzzySet = valfuzzySetBLL.fuzzySet;
        }

        public virtual void AddPoint(double value, double membership)
        {
            if (membership >= 0 && membership <= 1)
            {
                this.FuzzySet.Add(value, membership);
            }
            else
            {
                throw new Exception("ERROR:\n The memberships must be in [0, 1]");
            }
        }
    }
}
