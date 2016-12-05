using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITTraleeCK
{
    class DAOMember
    {

        public static bool Login(string username, string password)
        {
            Member member = new Member();

            bool foundMember = false;

            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM MEMBER WHERE USERNAME ='" + username + "'AND MEMBERPASSWORD ='" + password + "'";
            cmd.CommandText = cmdText;
            
            OracleDataReader reader = null;
            
            try
            {
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    foundMember = true;

                    while (reader != null && reader.Read())
                    {
                        member.MemberID = reader.GetInt32(0);
                        member.Username = reader.GetString(1);
                        member.MemberPassword = reader.GetString(2);
                        member.Age = reader.GetInt32(3);
                        member.Email = reader.GetString(4);
                        member.Gender = reader.GetString(5);
                        member.Nationality = reader.GetString(6);
                        member.CategoryOfKnowledge = reader.GetString(7);
                        member.Newsletter = reader.GetString(8);
                        member.TypeOfMember = reader.GetString(9);
                    }

                    SessionUser.LogOn(member);

                }
                else
                {
                    MessageBox.Show("Your username or your password is not correct");
                }
            }

            catch
            {
                throw;
            }

           return foundMember;

        }

        /*
         * Method to create member by calling procedure
         * 
         */
        public static void CreateMember(string username, string password, int age, string email, string gender, string nationality, string categoryOfKnowledge, string newsletter, string typeOfMember)
        {
            // checks to see if the database connection is not open
            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = DBConnection.Connection;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                string strSQL = "CREATEMEMBER";

                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                cmd.Parameters.Add("age", OracleDbType.Int32).Value = age;
                cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
                cmd.Parameters.Add("gender", OracleDbType.Varchar2).Value = gender;
                cmd.Parameters.Add("nationality", OracleDbType.Varchar2).Value = nationality;
                cmd.Parameters.Add("categoryOfKnowledge", OracleDbType.Varchar2).Value = categoryOfKnowledge;
                cmd.Parameters.Add("newsletter", OracleDbType.Varchar2).Value = newsletter;
                cmd.Parameters.Add("typeOfMember", OracleDbType.Varchar2).Value = typeOfMember;

                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                DBConnection.Close();
        }


        public static List<Member> SelectAllMembers()
        {
            List<Member> members = new List<Member>();

            Member member;
         
            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM MEMBER";
            
            cmd.CommandText = cmdText;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    member = new Member();

                    member.MemberID = reader.GetInt32(0);
                    member.Username = reader.GetString(1);
                    member.MemberPassword = reader.GetString(2);
                    member.Age = reader.GetInt32(3);
                    member.Email = reader.GetString(4);
                    member.Gender = reader.GetString(5);
                    member.Nationality = reader.GetString(6);
                    member.CategoryOfKnowledge = reader.GetString(7);
                    member.Newsletter = reader.GetString(8);
                    member.TypeOfMember = reader.GetString(9);

                    members.Add(member);
                 }
            }

            catch
            {
                MessageBox.Show("There is any users present in database");
            }

            return members; 
        }

        public static Member SelectMemberConnected()
        {
            Member member = new Member();

            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM MEMBER WHERE USERNAME ='" + SessionUser.WhoIsLoggedIn().Username + "'";
            cmd.CommandText = cmdText;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
                
                    while (reader != null && reader.Read())
                    {
                        member.MemberID = reader.GetInt32(0);
                        member.Username = reader.GetString(1);
                        member.MemberPassword = reader.GetString(2);
                        member.Age = reader.GetInt32(3);
                        member.Email = reader.GetString(4);
                        member.Gender = reader.GetString(5);
                        member.Nationality = reader.GetString(6);
                        member.CategoryOfKnowledge = reader.GetString(7);
                        member.Newsletter = reader.GetString(8);
                        member.TypeOfMember = reader.GetString(9);
                    }
            }

            catch
            {
                throw;
            }

            return member;
        }

        public static void UpdateMemberConnected(string username, string password, int age, string email, string gender, string nationality, string categoryOfKnowledge, string typeOfMember, string newsletter)
        {
            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string strSQL = @"UPDATE MEMBER SET USERNAME='" + username + 
                "',MEMBERPASSWORD='" + password +
                "',AGE ='" + age +
                "',EMAIL ='" + email +
                "',GENDER ='" + gender +
                "',NATIONALITY='" + nationality +
                "',CATEGORY_OF_KNOWLEDGE='" + categoryOfKnowledge + 
                "',TYPE_OF_MEMBER='" + typeOfMember +
                "',NEWSLETTER='" + newsletter + 
                "'WHERE MEMBER_ID='" + SessionUser.WhoIsLoggedIn().MemberID + "'";
            
            cmd.CommandText = strSQL;
           
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DBConnection.Close();
        }
    }
}
 