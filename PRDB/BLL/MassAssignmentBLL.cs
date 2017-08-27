using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPRDB.BLL
{
    public class MassAssignmentBLL
    {
        private DiscreteFuzzySetBLL disFuzzy;
        private List<ProbSubSetBLL> proSubset;
        public DiscreteFuzzySetBLL DisFuzzy
        {
            get { return disFuzzy; }
            set { disFuzzy = value; }
        }
        public List<ProbSubSetBLL> ProSubset
        {
            get { return proSubset; }
            set { proSubset = value; }
        }
        public MassAssignmentBLL()
        {
            this.disFuzzy = new DiscreteFuzzySetBLL();
            this.proSubset = new List<ProbSubSetBLL>();
        }
        private void QuickSort(List<Double> value, List<Double> mbs, int left, int right)
        {
            int i, j;
            Double x;
            x = mbs[(left + right) / 2];        // chọn phần tử giữa làm gốc
            i = left;
            j = right;
            do
            {
                while (mbs[i] > x) i++;    // lặp đến khi a[i] >= x
                while (mbs[j] < x) j--;    // lặp đến khi a[i] <= x
                if (i <= j)        // nếu có 2 phần tử a[i] và a[j] ko theo thứ tự
                {
                    double v = value[i];
                    double m = mbs[i];
                    value[i] = value[j];
                    mbs[i] = mbs[j];
                    value[j] = v;
                    mbs[j] = m;
                    i++;        // qua phần tử kế tiếp
                    j--;        // qua phần tử đứng trước
                }
            } while (i < j);
            if (left < j)    // phân hoạch đoạn bên trái
                QuickSort(value, mbs, left, j);
            if (right > i)    // phân hoạch đoạn bên phải
                QuickSort(value, mbs, i, right);
        }
        private void setMassAssignment()
        {
            QuickSort(this.disFuzzy.ValueSet, this.disFuzzy.MembershipSet, 0, this.disFuzzy.ValueSet.Count - 1);
            int n = this.disFuzzy.ValueSet.Count;
            List<Double> SortedSet;
            double m;
            int k;
            for (int i = 0; i < n; i++)
            {
                m = 0;
                k = 0;
                SortedSet = new List<Double>();
                for (int j = 1; j <= i + 1; j++)
                {
                    SortedSet.Add(this.disFuzzy.ValueSet[j - 1]);
                    k++;
                }
                if (n == 1)
                {
                    m = this.disFuzzy.MembershipSet[n - 1];
                }
                else
                {
                    if (k == n)
                    {
                        m = this.disFuzzy.MembershipSet[n - 1];
                    }
                    else
                        if (k == 1)
                        {
                            m = Math.Round((1 - this.disFuzzy.MembershipSet[i + 1]), 4);
                        }
                        else m = Math.Round((this.disFuzzy.MembershipSet[i] - this.disFuzzy.MembershipSet[i + 1]), 4);
                }
                if (m != 0.0)
                {
                    ProbSubSetBLL pro = new ProbSubSetBLL(SortedSet, m);
                    this.proSubset.Add(pro);
                }
            }
        }
        public MassAssignmentBLL(DiscreteFuzzySetBLL dis)
        {
            this.disFuzzy = dis;
            this.proSubset = new List<ProbSubSetBLL>();
            setMassAssignment();
        }
        public MassAssignmentBLL(DiscreteFuzzySetBLL dis, List<ProbSubSetBLL> pro)
        {
            this.disFuzzy = dis;
            this.proSubset = pro;
        }

        public MassAssignmentBLL(MassAssignmentBLL massAssign)
        {
            this.disFuzzy = massAssign.disFuzzy;
            this.proSubset = massAssign.proSubset;
        }
    }
}
