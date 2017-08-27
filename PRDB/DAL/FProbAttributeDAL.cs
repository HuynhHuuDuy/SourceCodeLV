using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.Data;

namespace FPRDB.DAL
{
    public static class FProbAttributeDAL
    {
        internal static List<FProbAttributeBLL> getListAttributeByIDScheme(int IDScheme)
        {
            List<FProbAttributeBLL> probAttributes = new List<FProbAttributeBLL>();
            DataBase db = new DataBase();
            DataTable dtb = db.GetDataTable("SELECT * FROM SystemAttribute Where SchemeID=" + IDScheme);

            if (dtb != null)
                foreach (DataRow attrRow in dtb.Rows)
                {
                    FProbAttributeBLL NewAttr = new FProbAttributeBLL();
                    NewAttr.PrimaryKey = Convert.ToBoolean(attrRow[1]);
                    NewAttr.AttributeName = Convert.ToString(attrRow[2]);
                    NewAttr.FproDataType.TypeName = Convert.ToString(attrRow[3]);
                    NewAttr.FproDataType.GetDomain(Convert.ToString(attrRow[4]));
                    NewAttr.FproDataType.GetDataType();
                    NewAttr.Description = Convert.ToString(attrRow[5]);
                    probAttributes.Add(NewAttr);
                }
            return probAttributes;
        }
        internal static void DeleteAllAttribute()
        {
            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemAttribute"))
                throw new Exception(db.errorMessage);
        }
        internal static void Insert(FProbAttributeBLL probAttribute)
        {
            DataBase db = new DataBase();
            string SQL = "";
            SQL += "INSERT INTO SystemAttribute VALUES ( ";
            SQL += probAttribute.IdAttribute + ",";
            SQL += "'" + probAttribute.PrimaryKey + "'" + ",";
            SQL += "'" + probAttribute.AttributeName + "'" + ",";
            SQL += "'" + probAttribute.FproDataType.TypeName + "'" + ",";
            SQL += "'" + probAttribute.FproDataType.DomainString + "'" + ",";
            SQL += "'" + probAttribute.Description + "'" + ",";
            SQL += probAttribute.FproSchema.IdSchema;
            SQL += " );";

            if (!db.Update(SQL))
                throw new Exception(db.errorMessage);
        }
        internal static int getMaxIdinTable()
        {
            return new DataBase().GetMaxIdInTable("SystemAttribute");
        }
        internal static void DeleteAllAttributeByIdScheme(FProbAttributeBLL probAttribute)
        {
            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemAttribute Where SchemeID = " + probAttribute.FproSchema.IdSchema))
                throw new Exception(db.errorMessage);
        }
    }
}
