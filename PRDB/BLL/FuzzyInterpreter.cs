using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class FuzzyInterpreter
    {
        private DiscreteFuzzySetBLL discretize(ContinuousFuzzySetBLL contFS, double beginPoint, double epsilon)
        {
            DiscreteFuzzySetBLL discFS = new DiscreteFuzzySetBLL();
            discFS.FuzzySetName = contFS.FuzzySetName;
            for (double val = beginPoint; val <= contFS.BottomRight; val += epsilon)
            {
                double mbs = contFS.GetMembershipAt(val);
                discFS.AddPoint(val, mbs);
            }
            return discFS;
        }
        private double EqualrelProbOnSets(List<Double> subset1, List<Double> subset2)
        {
            double result = 0;
            double dem = 0;
            int c1 = subset1.Count;
            int c2 = subset2.Count;

            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    if (subset1[i] == subset2[j])
                    {
                        dem = dem + 1;
                    }
                }
            }
            result = (dem / (c1 * c2));
            return result;
        }
        private double BiggerrelProbOnSets(List<Double> subset1, List<Double> subset2)
        {
            double result = 0;
            double dem = 0;
            int c1 = subset1.Count;
            int c2 = subset2.Count;

            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    if (subset1[i] > subset2[j])
                    {
                        dem = dem + 1;
                    }
                }
            }
            result = (dem / (c1 * c2));
            return result;
        }
        private double EqualBiggerrelProbOnSets(List<Double> subset1, List<Double> subset2)
        {
            double result = 0;
            double dem = 0;
            int c1 = subset1.Count;
            int c2 = subset2.Count;

            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    if (subset1[i] >= subset2[j])
                    {
                        dem = dem + 1;
                    }
                }
            }
            result = (dem / (c1 * c2));
            return result;
        }
        private double SmallerrelProbOnSets(List<Double> subset1, List<Double> subset2)
        {
            double result = 0;
            double dem = 0;
            int c1 = subset1.Count;
            int c2 = subset2.Count;

            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    if (subset1[i] < subset2[j])
                    {
                        dem = dem + 1;
                    }
                }
            }
            result = (dem / (c1 * c2));
            return result;
        }
        private double EqualSmallerrelProbOnSets(List<Double> subset1, List<Double> subset2)
        {
            double result = 0;
            double dem = 0;
            int c1 = subset1.Count;
            int c2 = subset2.Count;

            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    if (subset1[i] <= subset2[j])
                    {
                        dem = dem + 1;
                    }
                }
            }
            result = (dem / (c1 * c2));
            return result;
        }
        private double DifrelProbOnSets(List<Double> subset1, List<Double> subset2)
        {
            double result = 0;
            double dem = 0;
            int c1 = subset1.Count;
            int c2 = subset2.Count;

            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    if (subset1[i] != subset2[j])
                    {
                        dem = dem + 1;
                    }
                }
            }
            result = (dem / (c1 * c2));
            return result;
        }
        private double CondrelProbOnSets(List<Double> subset1, List<Double> subset2)
        {
            double result = 0;
            double dem = 0;
            int c1 = subset1.Count;
            int c2 = subset2.Count;

            for (int i = 0; i < c2; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    if (subset2[i] == subset1[j])
                    {
                        dem = dem + 1;
                    }
                }
            }
            result = (dem / c1);
            //return Math.Round(result, 4);
            return result;
        }
        private double relProbOnSets(List<Double> subset1, List<Double> subset2, string rel)
        {
            switch (rel)
            {
                case "_=":
                    return EqualrelProbOnSets(subset1, subset2);
                case "_>":
                    return BiggerrelProbOnSets(subset1, subset2);
                case ">=":
                    return EqualBiggerrelProbOnSets(subset1, subset2);
                case "_<":
                    return SmallerrelProbOnSets(subset1, subset2);
                case "<=":
                    return EqualSmallerrelProbOnSets(subset1, subset2);
                case "!=":
                    return DifrelProbOnSets(subset1, subset2);
                case "→":
                    return CondrelProbOnSets(subset1, subset2);
                default: return 0;
            }

        }

        /// <summary>
        /// Important! Calculate m (mass assignment) (phep gan khoi), calculate prob (A->B)
        /// </summary>
        /// <param name="discFS1">A</param>
        /// <param name="discFS2">B</param>
        /// <param name="rel"></param>
        /// <returns></returns>
        public double interpreteForDiscFS(DiscreteFuzzySetBLL discFS1, DiscreteFuzzySetBLL discFS2, string rel)
        {
            double result = 0;
            //calculate m (Phep gan khoi). 
            MassAssignmentBLL mass1 = new MassAssignmentBLL(discFS1);
            MassAssignmentBLL mass2 = new MassAssignmentBLL(discFS2);
            for (int i = 0; i < mass1.ProSubset.Count; i++)
            {
                for (int j = 0; j < mass2.ProSubset.Count; j++)
                {
                    double add = (relProbOnSets(mass1.ProSubset[i].Subset, mass2.ProSubset[j].Subset, rel)) * (mass1.ProSubset[i].MassSubset) * (mass2.ProSubset[j].MassSubset);
                    result = result + add;
                }
            }
            return Math.Round(result, 4);
        }
        public double interpreteForContFS(ContinuousFuzzySetBLL contFS1, ContinuousFuzzySetBLL contFS2, string rel)
        {
            int everageNumPoint = 20;
            //double epsilon = 0.1;
            double beginPoint1 = contFS1.BottomLeft;
            double beginPoint2 = contFS2.BottomLeft;

            double epsilon = (beginPoint1 + beginPoint2) / everageNumPoint;

            DiscreteFuzzySetBLL discFS1 = discretize(contFS1, beginPoint1, epsilon);

            DiscreteFuzzySetBLL discFS2 = discretize(contFS2, beginPoint2, epsilon);
            return interpreteForDiscFS(discFS1, discFS2, rel);
        }
    }
}
