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
            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("password", password);
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

                    

                }
                else
                {
                    foundMember = false;
                    MessageBox.Show("Error");
                }
            }

            catch
            {
                throw new Exception("Error" + MessageBox.Show("Member unrecognised"));
            }

           return foundMember;

        }


        public static bool CreateMember(string username, string password, string confirmPassword, int age, string email, string gender, string categoryOfKnowledge, string newsletter, string typeOfMember)
        {

            bool memberCreated = false;

            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            if (password.Equals(confirmPassword))
            {

                string cmdText = @"INSERT INTO MEMBER VALUES('" + username + "','" + password + "','" + age + "','" + email + "','" + gender + "','" + categoryOfKnowledge + "','" + newsletter + "','" + typeOfMember + "'";
                /*cmd.Parameters.Add("username", member.Username);
                cmd.Parameters.Add("password", member.MemberPassword);
                cmd.Parameters.Add("password", member.MemberPassword);*/
                cmd.CommandText = cmdText;

            }

            try
            {
                cmd.ExecuteNonQuery();
                memberCreated = true;

            }
            catch
            {
                memberCreated = false;
            }

            return memberCreated;

        }

      /*public static List<Member> SelectAllMembers()
        {
            List<Member> members = new List<Member>();
            Member member = new Member();
            member.MemberID = 1;
            int id1 = member.MemberID;
            

            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM ""MEMBER""" ;
            
            cmd.CommandText = cmdText;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
            }

            catch
            {
                throw;
            }

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

                members.Add(member);

                foreach (Member m in members)
                {
                    Console.WriteLine("liste DAO : " + m.ToString());
                }

            }
            
            return members.ToList<Member>();

        }*/
    }
}
 