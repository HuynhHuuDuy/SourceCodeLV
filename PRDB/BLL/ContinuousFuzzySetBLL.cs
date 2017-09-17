
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.DAL;

namespace FPRDB.BLL
{
    public class ContinuousFuzzySetBLL: FuzzySetBLL
    {
        private double bottomLeft;
        private double topLeft;
        private double topRight;
        private double bottomRight;
        public double BottomLeft
        {
            get { return bottomLeft; }
            set { bottomLeft = value; }
        }
        public double TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public double TopRight
        {
            get { return topRight; }
            set { topRight = value; }
        }
        public double BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }
        public ContinuousFuzzySetBLL()
            : base()
        {
            this.bottomLeft = 0.0;
            this.topLeft = 0.0;
            this.topRight = 0.0;
            this.bottomRight = 0.0;
        }
        public ContinuousFuzzySetBLL(string name)
            : base(name)
        {
            this.bottomLeft = 0.0;
            this.topLeft = 0.0;
            this.topRight = 0.0;
            this.bottomRight = 0.0;
        }
        public ContinuousFuzzySetBLL(double btleft, double tpleft, double tpright, double btright)
            : base()
        {
            this.FuzzySet.Add("bottomLeft", btleft);
            this.FuzzySet.Add("topLeft", tpleft);
            this.FuzzySet.Add("topRight", tpright);
            this.FuzzySet.Add("bottomRight", btright);
            this.bottomLeft = btleft;
            this.topLeft = tpleft;
            this.topRight = tpright;
            this.bottomRight= btright;
        }
        public ContinuousFuzzySetBLL(Hashtable valfuzzySet, double btleft, double tpleft, double tpright, double btright)
            : base(valfuzzySet)
        {
            this.bottomLeft = btleft;
            this.topLeft = tpleft;
            this.topRight = tpright;
            this.bottomRight = btright;
        }
        public ContinuousFuzzySetBLL(string valfuzzySetName, Hashtable valfuzzySet, double btleft, double tpleft, double tpright, double btright)
            : base(valfuzzySetName, valfuzzySet)
        {
            this.bottomLeft = btleft;
            this.topLeft = tpleft;
            this.topRight = tpright;
            this.bottomRight = btright;
        }
        public ContinuousFuzzySetBLL(string valfuzzySetName, double btleft, double tpleft, double tpright, double btright)
            : base()
        {
            this.FuzzySetName = valfuzzySetName;
            this.FuzzySet.Add("bottomLeft", btleft);
            this.FuzzySet.Add("topLeft", tpleft);
            this.FuzzySet.Add("topRight", tpright);
            this.FuzzySet.Add("bottomRight", btright);
            this.bottomLeft = btleft;
            this.topLeft = tpleft;
            this.topRight = tpright;
            this.bottomRight = btright;
        }
        public ContinuousFuzzySetBLL(ContinuousFuzzySetBLL consFuzzy)
            : base(consFuzzy)
        {
            this.bottomLeft = consFuzzy.bottomLeft;
            this.topLeft = consFuzzy.topLeft;
            this.topRight = consFuzzy.topRight;
            this.bottomRight = consFuzzy.bottomRight;
        }
        internal static List<ContinuousFuzzySetBLL> GenerateAllConFS(string path)
        {
            return ContinuousFuzzySetDAL.GenerateAllConFS(path);
        }
        private bool CheckLegal(Double bl, Double tl, Double tr, Double br)
        {
            if (bl < 0 || bl > br)
                return false;

            if (tl < 0 || tl > tr)
                return false;

            if (tr < 0 || tr < tl)
                return false;

            if (br < 0 || br < bl)
                return false;

            return true;
        }
        public bool SetValue(Double bottom_left, Double top_left, Double top_right, Double bottom_right)
        {
            if (!CheckLegal(bottom_left, top_left, top_right, bottom_right))
            {
                return false;
            }
            else
            {
                this.bottomLeft = bottom_left;
                this.topRight = top_right;
                this.topLeft = top_left;
                this.bottomRight = bottom_right;
                return true;
            }
        }
        internal static int UpdateFS(string path, string contents, string oldName)
        {
            return ContinuousFuzzySetDAL.UpdateFS(path, contents, oldName);
        }
        internal static int DeleteFS(string path)
        {
            return ContinuousFuzzySetDAL.DeleteFS(path);
        }
        public ContinuousFuzzySetBLL GetContinuousFuzzySetByName(string name)
        {
            return ContinuousFuzzySetDAL.GetContinuousFuzzySetByName(name);
        }
        public bool CheckContinuousFuzzySetByName(String name)
        {
            return ContinuousFuzzySetDAL.CheckContinuousFuzzySetByName(name);
        }
        public Double GetMembershipAt(Double value)//value is a point on Ox
        {
            Double result = -1;

            //Validate the value is between two point which limit trapezoidal on Ox.
            if ((value >= this.bottomLeft && value <= this.topLeft) || (value >= this.topLeft && value <= this.bottomLeft) ||
                (value >= this.topRight && value <= this.bottomRight) || (value >= this.bottomRight && value <= this.topRight) ||
                value >= this.topLeft && value <= this.topRight)
            {
                if (value >= this.topLeft && value <= this.topRight)
                {
                    result = 1;
                }
                else if (value == this.bottomLeft || value == this.bottomRight)
                {
                    result = 0;
                }

                else
                {
                    //A (__bottom_left, 0)
                    //B (__top_left, 1)
                    //C (_top_right, 1)
                    //D (_bottom_right, 0)

                    Double OxAB = Math.Abs(this.topLeft - this.bottomLeft);
                    Double OxCD = Math.Abs(this.bottomRight - this.topRight);
                    Double OxValueLeft = Math.Abs(value - this.bottomLeft);
                    Double OxValueRight = Math.Abs(value - this.bottomRight);

                    //The value is on the left side of the trapezoidal between _top_right and _bottom_right
                    if ((value > this.bottomLeft && value < this.topLeft) || (value > this.topRight && value < this.bottomRight))
                    {
                        //Base on congruent triangles
                        result = 1 * OxValueLeft / OxAB;
                    }

                    //The value is on the right side of the trapezoidal between __bottom_left and __top_left
                    if ((value > this.topLeft && value < this.bottomRight) || (value > this.bottomRight && value < this.topRight))
                    {
                        //Base on congruent triangles
                        result = 1 * OxValueRight / OxCD;
                    }
                }
            }

            return Math.Round(result, 4);
        }
        internal static List<ContinuousFuzzySetBLL> DSContFS(string value)
        {
            return ContinuousFuzzySetDAL.DSContFS(value);
        }
    }
}
