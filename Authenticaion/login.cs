using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using Clinic_Managment_System;

namespace Authenticaion
{
    public class login
    {
        private static int userID, roleID;

        private static string name, role;
        public static string NAME
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public static string ROLE
        {
            get
            {
                return role;
            }
            private set
            {
                role = value;
            }
        }
        public static int USERID 
        {
            get
            {
                return userID;
            }
            private set
            {
                userID = value;
            }
        }
        public static int ROLEID
        {
            get
            {
                return roleID;
            }
            private set
            {
                roleID = value;
            }
        }
        public static bool getLoginDetails(string proc, Hashtable ht)
        {
            bool Check = false;
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Check = true;

                    while (dr.Read())
                    {
                        USERID = Convert.ToInt32(dr[0].ToString());
                        NAME = dr[1].ToString();

                        ROLEID = Convert.ToInt32(dr[2].ToString());
                        ROLE = dr[3].ToString();
                    }
                }
                else
                {
                    Check = false;
                    MainClass.showMessage("Invalid username or password.", "error");
                }
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMessage(ex.Message, "error");
            }
            return Check;
        }
    }
}
