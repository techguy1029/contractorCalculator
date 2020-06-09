using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace contractorCalculator
{
    public static class encryptString
    {
        public static byte[] GetHash(string inputString)
        {
            using(HashAlgorithm algorithm = SHA256.Create())
            {
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            }
        }

        public static void hashStringToFile(string inputString)
        {
            string hashFolder = "C:\\ProgramData\\contractorCalc\\Security";
            System.IO.Directory.CreateDirectory(hashFolder);

            string hashTxtFile = hashFolder + "\\hash.txt";
            if (!File.Exists(hashTxtFile))
            {
                File.Create(hashTxtFile).Dispose();
            }
            File.WriteAllText(hashTxtFile, inputString);

        }

        public static string getHash()
        {
            string hashFolder = "C:\\ProgramData\\contractorCalc\\Security\\hash.txt";
            string readHash = File.ReadAllText(hashFolder);
            return readHash;
        }
    }
}
