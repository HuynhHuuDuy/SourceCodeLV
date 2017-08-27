using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPRDB.BLL;
using System.IO;

namespace FPRDB.DAL
{
    public class ContinuousFuzzySetDAL
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
        private static ContinuousFuzzySetBLL ReadEachConFS(string path)//Also content the path and name
        {
            ContinuousFuzzySetBLL result = new ContinuousFuzzySetBLL();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    String str = reader.ReadLine();
                    String[] list = str.Split(',');

                    //Only 4 members
                    if (list.Length == 4)
                    {
                        result.FuzzySetName = FuzzySetName(path);
                        result.BottomLeft = Double.Parse(list[0]);
                        result.TopLeft = Double.Parse(list[1]);
                        result.TopRight = Double.Parse(list[2]);
                        result.BottomRight = Double.Parse(list[3]);
                    }
                }

                return result;
            }
            catch
            {
                return null;
            }
        }
        internal static List<ContinuousFuzzySetBLL> GenerateAllConFS(string path)
        {
            List<ContinuousFuzzySetBLL> result = new List<ContinuousFuzzySetBLL>();
            try
            {
                string[] filePaths = Directory.GetFiles(path, "*.conFS");
                foreach (var item in filePaths)
                {
                    result.Add(ReadEachConFS(item));
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
        internal static int UpdateFS(string path, string content, string oldName)//path here not contains file name
        {
            try
            {
                int result = -1;
                if (!Directory.Exists(path))

                    Directory.CreateDirectory(path);
                {
                    //Add access control for directory
                    //AddDirectorySecurity(path, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                    //    , FileSystemRights.FullControl, AccessControlType.Allow);
                    //Delete File
                    result = DeleteFS(path + oldName);
                    //Create file with the same name;
                    //using (StreamWriter writer = new StreamWriter(path + oldName))//oldName means newName :)
                    //{
                    //    writer.WriteLine(content);
                    //    writer.Close();
                    //    result = 1;
                    //}
                    using (FileStream fs = new FileStream(path + oldName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {
                        StreamWriter tw = new StreamWriter(fs);
                        tw.WriteLine(content);
                        tw.Flush();
                        result = 1;
                    }

                    //Add access control for file
                    //AddFileSecurity(path + oldName, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                    //    , FileSystemRights.FullControl, AccessControlType.Allow);
                }

                //DirectoryInfo di = new DirectoryInfo(path);

                //DirectorySecurity ds = di.GetAccessControl();

                //foreach (AccessRule rule in ds.GetAccessRules(true, true, typeof(NTAccount)))
                //{
                //    System.Windows.Forms.MessageBox.Show(
                //                  rule.IdentityReference.Value.ToString());
                //    System.Windows.Forms.MessageBox.Show(
                //                rule.AccessControlType.ToString());
                //}

                return result;
            }
            catch
            {
                return -1;
            }
        }//Delete and Re Add file 
        internal static ContinuousFuzzySetBLL GetContinuousFuzzySetByName(string name)
        {
            ContinuousFuzzySetBLL result = new ContinuousFuzzySetBLL(name);
            try
            {
                string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\lib\", "*.conFS");
                foreach (var item in filePaths)
                {
                    if (FuzzySetName(item) == name)
                    {
                        result = ReadEachConFS(item);
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
        internal static bool CheckContinuousFuzzySetByName(string name)
        {
            try
            {
                string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\lib\", "*.conFS");
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
        internal static List<ContinuousFuzzySetBLL> DSContFS(string value)
        {
            List<ContinuousFuzzySetBLL> list = new List<ContinuousFuzzySetBLL>();
            try
            {
                //value = value.Replace("<", "");
                //value = value.Replace(">", "");
                string[] seperator = { "||" };
                string[] temp = value.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                int j1, j2;

                for (int i = 0; i < temp.Length; i++)
                {
                    j1 = temp[i].IndexOf('{');
                    j2 = temp[i].IndexOf('}');
                    string name = temp[i].Substring(j1 + 1, j2 - j1 - 1).Trim();
                    list.Add(GetContinuousFuzzySetByName(name));
                }
                return list;
            }
            catch
            {
                return list;
            }
        }
    }
}
