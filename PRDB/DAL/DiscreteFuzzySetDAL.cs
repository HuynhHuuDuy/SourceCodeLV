using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.IO;

namespace FPRDB.DAL
{
    public class DiscreteFuzzySetDAL
    {
        private static String FuzzySetName(string path)
        {
            String result = "";
            if (path.Contains("\\") && path.Contains("."))
            {
                int flash = path.LastIndexOf("\\") + 1;
                int point = path.LastIndexOf(".");
                result = path.Substring(flash, point - flash);
            }
            return result;
        }
        private static List<Double> SplitString(String str)
        {
            List<Double> result = new List<double>();

            ///Remove "{", "}" and ","
            //String tmp = str.Replace("{", "");
            //tmp = tmp.Replace("}", "");
            Char[] seperator = { ',' };
            String[] values = str.Split(seperator);

            ///Add value to list after remove unesessary
            foreach (var value in values)
            {
                result.Add(Convert.ToDouble(value));
            }

            return result;
        }
        private static DiscreteFuzzySetBLL ReadEachDisFS(string path)
        {
            DiscreteFuzzySetBLL result = new DiscreteFuzzySetBLL();
            try
            {
                List<String> list = new List<string>();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)//Only have two lines
                    {
                        list.Add(line); // Add to list.
                    }
                }

                result.FuzzySetName = FuzzySetName(path);
                result.ValueSet = SplitString(list[0]);
                result.MembershipSet = SplitString(list[1]);
                return result;
            }
            catch
            {
                return null;
            }
        }
        internal static List<DiscreteFuzzySetBLL> GenerateAllDisFS(string path)//just file path, not contains filename
        {

            List<DiscreteFuzzySetBLL> result = new List<DiscreteFuzzySetBLL>();
            try
            {
                string[] filePaths = Directory.GetFiles(path, "*.disFS");
                foreach (var item in filePaths)
                {
                    result.Add(ReadEachDisFS(item));
                }

                return result;
            }
            catch
            {
                return result;
            }
        }
        internal static int DeleteFS(string path)//path here mean also content name
        {
            try
            {
                int result = -1;

                if (File.Exists(path))
                {
                    //Add access control for directorymmkk
                    //AddDirectorySecurity(path, "Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                    //AddFileSecurity(path, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() 
                    //    , FileSystemRights.FullControl, AccessControlType.Allow);
                    File.Delete(path);
                    result = 1;
                }

                return result;
            }
            catch
            {
                return -1;
            }
        }
        internal static int UpdateFS(string path, List<String> contents, string oldName)
        {
            try
            {
                int result = -1;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                {
                    //Add access control for directory
                    //AddDirectorySecurity(path, (System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())
                    //    , FileSystemRights.FullControl, AccessControlType.Allow);

                    //Delete File
                    result = DeleteFS(path + oldName);
                    //Create file with the same name;
                    ////using (StreamWriter writer = new StreamWriter(path + oldName))//oldName means newName :)
                    ////{
                    ////    foreach (var item in contents)
                    ////    {
                    ////        writer.WriteLine(item);
                    ////    }

                    ////    writer.Close();
                    ////    result = 1;
                    ////}
                    using (FileStream fs = new FileStream(path + oldName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {
                        StreamWriter tw = new StreamWriter(fs);
                        foreach (var item in contents)
                        {
                            tw.WriteLine(item);
                        }
                        tw.Flush();
                        result = 1;
                    }
                    //Add access control for file
                    //AddFileSecurity(path + oldName, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                    //    , FileSystemRights.FullControl, AccessControlType.Allow);
                }

                return result;
            }
            catch
            {
                return -1;
            }
        }
        internal static DiscreteFuzzySetBLL GetDiscreteFuzzySetByName(String name)
        {
            DiscreteFuzzySetBLL result = new DiscreteFuzzySetBLL(name);
            try
            {
                //get library from 
                string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\lib\", "*.disFS");
                foreach (var item in filePaths)
                {
                    if (FuzzySetName(item) == name)
                    {
                        result = ReadEachDisFS(item);
                        break;
                    }
                }

                return result;
            }
            catch
            {
                return result;
            }
        }
        internal static bool CheckDiscFuzzySetByName(String name)
        {
            try
            {
                string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\lib\", "*.disFS");
                foreach (var item in filePaths)
                {
                    if (FuzzySetName(item) == name)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        internal static List<DiscreteFuzzySetBLL> DSDisFS(string value)
        {
            List<DiscreteFuzzySetBLL> listfs = new List<DiscreteFuzzySetBLL>();
            try
            {
                string[] seperator = { "||" };
                string[] temp = value.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                int j1, j2;

                for (int i = 0; i < temp.Length; i++)
                {
                    j1 = temp[i].IndexOf('{');
                    j2 = temp[i].IndexOf('}');
                    string name = temp[i].Substring(j1 + 1, j2 - j1 - 1).Trim();
                    DiscreteFuzzySetBLL result = GetDiscreteFuzzySetByName(name);
                    if(result.ValueSet.Count==0)
                    {
                        result.AddPoint(0, 0);
                    }
                    listfs.Add(result);
                }
                return listfs;
            }
            catch
            {
                return listfs;
            }
        }
    }
}
