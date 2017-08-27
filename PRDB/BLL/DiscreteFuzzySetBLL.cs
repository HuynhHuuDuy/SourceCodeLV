using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class DiscreteFuzzySetBLL : FuzzySetBLL
    {
        private List<double> valueSet;
        private List<double> membershipSet;
        public List<double> ValueSet
        {
          get { return valueSet; }
          set { valueSet = value; }
        }
        public List<double> MembershipSet
        {
          get { return membershipSet; }
          set { membershipSet = value; }
        }
        public DiscreteFuzzySetBLL(string name) :
            base(name)
        {
            this.valueSet = new List<double>();
            this.membershipSet = new List<double>();
        }
        public DiscreteFuzzySetBLL(): 
            base()
        {
            this.valueSet = new List<double>();
            this.membershipSet = new List<double>();
        }
        public DiscreteFuzzySetBLL(List<double> valSet, List<double> mbsSet)
            : base()
        {
            this.valueSet = valSet;
            this.membershipSet = mbsSet;
            for (int i = 0; i < valSet.Count; i++)
            {
                this.FuzzySet.Add(valSet[i], mbsSet[i]);
            }
        }
        public DiscreteFuzzySetBLL(Hashtable valfuzzySet, List<double> valSet, List<double> mbsSet)
            : base(valfuzzySet)
        {
            this.valueSet = valSet;
            this.membershipSet = mbsSet;
        }
        
        public DiscreteFuzzySetBLL(string valfuzzySetName, Hashtable valfuzzySet, List<double> valSet, List<double> mbsSet)
            : base(valfuzzySetName, valfuzzySet)
        {
            this.valueSet = valSet;
            this.membershipSet = mbsSet;
        }
        public DiscreteFuzzySetBLL(string valfuzzySetName, List<double> valSet, List<double> mbsSet)
            :base()
        {
            this.FuzzySetName = valfuzzySetName;
            this.valueSet = valSet;
            this.membershipSet = mbsSet;
            for(int i = 0; i < valSet.Count; i++)
            {
                this.FuzzySet.Add(valSet[i], mbsSet[i]);
            }
        }
        public DiscreteFuzzySetBLL(DiscreteFuzzySetBLL disFuzzy)
            : base(disFuzzy)
        {
            this.valueSet = disFuzzy.valueSet;
            this.membershipSet = disFuzzy.membershipSet;
        }
        internal static List<DiscreteFuzzySetBLL> GenerateAllDisFS(string path)
        {
            return DiscreteFuzzySetDAL.GenerateAllDisFS(path);
        }
        internal static int UpdateFS(string path, List<String> contents, string oldName)
        {
            return DiscreteFuzzySetDAL.UpdateFS(path, contents, oldName);
        }
        internal static DiscreteFuzzySetBLL GetByName(String name)
        {
            return DiscreteFuzzySetDAL.GetDiscreteFuzzySetByName(name);
        }
        public List<Double> getXsForMembership(Double membership)
        {
            List<Double> ReturnValue = new List<Double>();
            int i = 0;
            foreach (var item in this.membershipSet)
            {
                if (item == membership)
                {
                    ReturnValue.Add(valueSet[i]);
                }
                i++;
            }
            return ReturnValue;
        }
        private Boolean IsMember(Double value)
        {
            foreach (Double item in this.valueSet)
            {
                if (value == item)
                {
                    return true;
                }
            }

            return false;
        }
        public override void AddPoint(Double value, Double membership)
        {
            if (!IsMember(value))
            {
                base.AddPoint(value, membership);
                this.valueSet.Add(value);//Add each value to the set of value
                this.membershipSet.Add(membership);//add each membership of value to the set of membership
            }
            else
            {
                throw new Exception("ERROR:\n Value already exists");
                //return;
            }
        }
        public bool CheckDiscFuzzySetByName(String name)
        {
            return DiscreteFuzzySetDAL.CheckDiscFuzzySetByName(name);
        }
        internal static List<DiscreteFuzzySetBLL> DSDisFS(string value)
        {
            return DiscreteFuzzySetDAL.DSDisFS(value);
        }
        /*public override void AddPoint(double value, double membership)
        {
            if(this.checkLegal(value))
            {
                base.AddPoint(value, membership);
                this.valueSet.Add(value);
                this.membershipSet.Add(membership);
            }
            else
            {
                throw new Exception("ERROR:\n The value already exist");
            }
            
        }
        private Boolean checkLegal(double value)
        {
            if (this.FuzzySet.ContainsKey(value))
                return false;
            return true;
        }
        private double getMembershipAt(double value)
        {
            double result = -1;
            if (this.valueSet.Count == 0)
                return result;
            for (int i = 0; i < this.valueSet.Count; i++)
                if (this.valueSet[i] == value)
                {
                    result = this.membershipSet[i];
                    break;
                }
            return result;
        }
        private List<double>getValueAt(double membership)
        {
            List<double> result = new List<double>();
            if (this.valueSet.Count == 0)
                return result;
            for (int i = 0; i < this.membershipSet.Count; i++)
                if (this.membershipSet[i] == membership)
                    result.Add(this.valueSet[i]);
            return result;
        }*/
    }
}
