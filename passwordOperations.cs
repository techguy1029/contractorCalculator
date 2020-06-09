using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public class passwordOperations
    {
        public static string setPassword(string firstTxtBoxPs, string secondTxtBoxPs)
        {
            //https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp
            if (firstTxtBoxPs.Equals(secondTxtBoxPs))
            {
                byte[] hash = encryptString.GetHash(firstTxtBoxPs);
                string hashString = System.Text.Encoding.UTF8.GetString(hash);
                return hashString;
            }
            return null;
        }

        public static bool correctPasswordInput(string textBoxTxt)
        {
            string hashFromFile = encryptString.getHash();
            byte[] hashTextBoxInput = encryptString.GetHash(textBoxTxt);
            string hashTextBoxInputString = System.Text.Encoding.UTF8.GetString(hashTextBoxInput);
            bool result = hashFromFile.Equals(hashTextBoxInputString);
            return result;
        }

        public static bool setUpPasswordStorage()
        {
            String str;
            SqlConnection myConn = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Integrated security=SSPI;database=master");
            str = "CREATE DATABASE settingsData ON PRIMARY" +
                 "(NAME = estimatorProject_Data, " +
                  "FILENAME = 'C:\\ProgramData\\contractorCalc\\Settings\\settingsData.mdf', " +
                  "SIZE = 2MB, MAXSIZE = 20MB, FILEGROWTH = 10%) " +
                  "LOG ON (NAME = MyDatabase_Log, " +
                  "FILENAME = 'C:\\ProgramData\\contractorCalc\\Settings\\settingsData.ldf', " +
                  "SIZE = 1MB, " +
                  "MAXSIZE = 10MB, " +
                  "FILEGROWTH = 10%)";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DB IS SUCCESS");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            return true;
        }
        public static void setUpLocalDb()
        {
            SqlConnection connection = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB");
            using (connection)
            {
                connection.Open();

                string sql = string.Format(@"
                    CREATE DATABASE
                        [Test]
                    ON PRIMARY (
                       NAME=Test_data,
                       FILENAME = '{0}\settingsData-2.mdf'
                    )
                    LOG ON (
                        NAME=Test_log,
                        FILENAME = '{0}\settingsData-2.ldf'
                    )",
                                @"C:\ProgramData\contractorCalc\Settings"
                );

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }
        public static void setUpPasswordDbStructure()
        {
            SqlConnection myConn = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Integrated security=SSPI;database=Test");
            String createTable = "CREATE TABLE HashedPasswords(ID int IDENTITY, Password varchar(50))";
            SqlCommand createTableSQL = new SqlCommand(createTable, myConn);
            try
            {
                myConn.Open();
                createTableSQL.ExecuteNonQuery();
                MessageBox.Show("Table success");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        public static bool setUpPassword(string pass)
        {
            /*
            try
            {
                SqlConnection sc = new SqlConnection();
                SqlCommand com = new SqlCommand();
                sc.ConnectionString = ("Server=(LocalDB)\\MSSQLLocalDB;Database=Test;Trusted_Connection=Yes");
                sc.Open();

                SqlCommand cmd = new SqlCommand("insert into HashedPasswords values('" + pass + "')", sc);

                int successOfSQL = cmd.ExecuteNonQuery();
                if (successOfSQL != 0)
                {
                    MessageBox.Show("Gucci Boii");
                }
                sc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error bruv:" + ex);
                return false;
            }
            */
            try
            {
                SqlConnection sc = new SqlConnection();
                SqlCommand com = new SqlCommand();
                sc.ConnectionString = ("Server=(LocalDB)\\MSSQLLocalDB;Database=Test;Trusted_Connection=Yes");
                sc.Open();

                SqlCommand emptyTable = new SqlCommand("DELETE FROM HashedPasswords", sc);
                SqlCommand cmd = new SqlCommand("insert into HashedPasswords values('" + pass + "')", sc);

                int deletionSuccess = emptyTable.ExecuteNonQuery();
                int successOfSQL = cmd.ExecuteNonQuery();
                if (successOfSQL != 0 || deletionSuccess != 0)
                {
                    MessageBox.Show("Gucci Boii");
                }
                sc.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error bruv:" + ex);
                return false;
            }
        }

        public static string readInPassword()
        {
            string queryString = "SELECT Password  FROM  [dbo].[HashedPasswords]";
            string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Test;Trusted_Connection=Yes";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                using (SqlCommand myCommand = new SqlCommand(queryString, myConnection))
                {
                    string Result = (string)myCommand.ExecuteScalar(); // returns the first column of the first row
                    return Result;
                }
            }
        }
    }
}
