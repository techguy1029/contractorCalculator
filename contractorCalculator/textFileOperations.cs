using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace contractorCalculator
{
    public class textFileOperations
    {
        public static string createTextFile(string folderPath, string name)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            DirectorySecurity sec = di.GetAccessControl();
            sec.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
            string subDirectoryName = name;
            di.CreateSubdirectory(subDirectoryName);
            string textFileFolder = folderPath + "\\" + name;
            string textFilePath = folderPath + "\\" + name + "\\" + $"{name}.txt";
            var myFile = File.Create(textFilePath);
            myFile.Close();
            return textFilePath;
        }
        public static bool writeToRetainingWallText(string text, string fileName)
        {
            try
            {
                File.WriteAllText(fileName, text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
