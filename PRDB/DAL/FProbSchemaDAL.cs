using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.Data;

namespace FPRDB.DAL
{
    public static class FProbSchemaDAL
    {
        internal static List<FProbSchemaBLL> getAllScheme()
        {
            List<FProbSchemaBLL> newSchemes = new List<FProbSchemaBLL>();
            DataBase db = new DataBase();
            DataSet dts = new DataSet();
            dts.Tables.Add(db.GetDataTable("SELECT * FROM SystemScheme", "system_scheme"));
            foreach (DataRow row in dts.Tables["system_scheme"].Rows)
            {
                List<FProbAttributeBLL> attributes = new FProbAttributeBLL().getListAttributeByIDScheme(Convert.ToInt16(row[0]));
                newSchemes.Add(new FProbSchemaBLL(Convert.ToInt16(row[0]), row[1].ToString(), attributes));
            }
            return newSchemes;
        }
        internal static FProbSchemaBLL getSchemeById(FProbSchemaBLL probScheme)
        {
            FProbSchemaBLL newSchemes = new FProbSchemaBLL();
            DataBase db = new DataBase();
            DataSet dts = new DataSet();
            dts.Tables.Add(db.GetDataTable("SELECT * FROM SystemScheme where ID = " + probScheme.IdSchema, "system_scheme"));

            foreach (DataRow row in dts.Tables["system_scheme"].Rows)
            {
                List<FProbAttributeBLL> attributes = new FProbAttributeBLL().getListAttributeByIDScheme(Convert.ToInt16(row[0]));
                newSchemes = new FProbSchemaBLL(Convert.ToInt16(row[0]), row[1].ToString(), attributes);
            }
            return newSchemes;
        }
        internal static void DeleteAllScheme()
        {
            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemScheme "))
                throw new Exception(db.errorMessage);
        }
        internal static void Insert(FProbSchemaBLL probScheme)
        {
            DataBase db = new DataBase();
            string SQL = "";
            SQL += "INSERT INTO SystemScheme VALUES (";
            SQL += probScheme.IdSchema + ",";
            SQL += "'" + probScheme.SchemaName + "'";
            SQL += " );";
            if (!db.Update(SQL))
                throw new Exception(db.errorMessage);
        }
        internal static int getMaxIdinTable()
        {
            return new DataBase().GetMaxIdInTable("SystemScheme");
        }
        internal static void Update(FProbSchemaBLL probScheme)
        {
            string SQL = "";
            SQL += "Update SystemScheme  SET ";
            SQL += " SchemeName  = " + probScheme.SchemaName;
            SQL += " Where  ID = " + probScheme.IdSchema;
            new DataBase().Update(SQL);
        }
        internal static void DeleteSchemeById(FProbSchemaBLL probScheme)
        {
            foreach (FProbAttributeBLL attr in probScheme.FproAttributes)
            {
                attr.FproSchema = probScheme;
                attr.DeleteAllAttributeByIdScheme();
            }
            DataBase db = new DataBase();
            if (!db.Update("DELETE FROM SystemScheme Where ID = " + probScheme.IdSchema))
                throw new Exception(db.errorMessage);
        }
    }
}
