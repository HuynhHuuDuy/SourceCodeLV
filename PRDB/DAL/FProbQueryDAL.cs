using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.Data;

namespace FPRDB.DAL
{
    public static class FProbQueryDAL
    {
        internal static List<FProbQueryBLL> getAllQuery()
        {
            List<FProbQueryBLL> probQuerys = new List<FProbQueryBLL>();
            DataBase db = new DataBase();
            DataSet dts = dts = new DataSet();
            dts.Tables.Add(db.GetDataTable("SELECT * FROM SystemQuery", "system_query"));

            foreach (DataRow queryRow in dts.Tables["system_query"].Rows)
            {
                FProbQueryBLL NewQuery = new FProbQueryBLL();
                NewQuery.IdQuery = Convert.ToInt16(queryRow[0].ToString());
                NewQuery.QueryName = queryRow[1].ToString();
                if (queryRow[2].ToString() != "Empty")
                    NewQuery.QueryString = queryRow[2].ToString();
                else
                    NewQuery.QueryString = "";
                probQuerys.Add(NewQuery);
            }
            return probQuerys;
        }
        internal static void DeleteAllQuery()
        {
            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemQuery"))
                throw new Exception(db.errorMessage);
        }
        internal static void Insert(FProbQueryBLL probQuery)
        {
            if (probQuery.IdQuery == -1)
            {
                probQuery.IdQuery = new DataBase().GetMaxIdInTable("SystemQuery");
            }

            DataBase db = new DataBase();
            string SQL = "";

            if (probQuery.QueryString == "")
                probQuery.QueryString = "Empty";

            SQL += "INSERT INTO SystemQuery VALUES (";
            SQL += probQuery.IdQuery + ",";
            SQL += "'" + probQuery.QueryName + "'" + ",";
            SQL += "'" + probQuery.QueryString + "'";
            SQL += " );";

            if (!db.Update(SQL))
                throw new Exception(db.errorMessage);
        }
        internal static FProbQueryBLL getQueryByName(FProbQueryBLL probQuery)
        {

            DataBase db = new DataBase();
            DataSet dts = dts = new DataSet();
            dts.Tables.Add(db.GetDataTable("SELECT * FROM SystemQuery where QueryName = '" + probQuery.QueryName + "'", "system_query"));

            FProbQueryBLL NewQuery = new FProbQueryBLL();
            foreach (DataRow queryRow in dts.Tables["system_query"].Rows)
            {
                NewQuery = new FProbQueryBLL();
                NewQuery.IdQuery = Convert.ToInt16(queryRow[0].ToString());
                NewQuery.QueryName = queryRow[1].ToString();
                NewQuery.QueryString = queryRow[2].ToString();
            }

            return NewQuery;
        }
        internal static void Update(FProbQueryBLL probQuery)
        {
            string SQL = "";
            SQL += "Update SystemQuery  SET ";
            SQL += " QueryName  = '" + probQuery.QueryName + "'";
            SQL += " , QueryString = '" + probQuery.QueryString.Replace("'", "''") + "'";
            SQL += " Where  ID = " + probQuery.IdQuery;
            new DataBase().Update(SQL);
        }
        internal static void DeleteById(FProbQueryBLL probQuery)
        {
            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemQuery where ID = " + probQuery.IdQuery))
                throw new Exception(db.errorMessage);
        }
    }
}
