using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGameSchool
{
    internal class UserDataManager
    {
        public const string CsvFileName = "user_data.csv";
        public string Username { get; set; }
        public string Password { get; set; }
        public UserDataManager(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string CsvFormat()
        {
            return Username + "," + Password;
        }
        public static void SaveUserData(UserDataManager userData)
        {
            using (StreamWriter writer = File.AppendText(CsvFileName))
            {
                writer.WriteLine(userData.CsvFormat());
            }
        }
        public static List<UserDataManager> LoadAllUserData()
        {
            List<UserDataManager> userDataList = new List<UserDataManager>();
            if (File.Exists(CsvFileName))
            {
                IEnumerable<string> lines = File.ReadLines(CsvFileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        string username = parts[0];
                        string password = parts[1];
                        userDataList.Add(new UserDataManager(username, password));
                    }
                }
            }
            return userDataList;
        }
    }
}
