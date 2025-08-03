using Clinic_Managment_System;
using System;
using System.IO;

namespace Settings
{
    public class Setting
    {
        public static void createFile(string file, int status, string DS, string DB, string username = null, string password = null)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), file);
            string connectionString = BuildConnectionString(status, DS, DB, username, password);

            try
            {
                File.WriteAllText(path, connectionString);
                MainClass.showMessage("Settings Saved Successfully.", "Success");
            }
            catch (Exception ex)
            {
                MainClass.showMessage("Error saving settings: " + ex.Message, "Error");
            }
        }

        private static string BuildConnectionString(int status, string DS, string DB, string username, string password)
        {
            if (status == 1)
            {
                return $"Data Source={DS};Initial Catalog={DB};Integrated Security=true;MultipleActiveResultSets=true;";
            }
            else if (status == 0)
            {
                return $"Data Source={DS};Initial Catalog={DB};User  ID={username};Password={password};MultipleActiveResultSets=true;";
            }
            else
            {
                throw new ArgumentException("Invalid status value. Must be 0 or 1.");
            }
        }
    }
}