using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class DAOAnswer
    {

        public static List<Answer> SelectAllAnswers()
        {
            List<Answer> answers = new List<Answer>();
            Answer answer = new Answer();


            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM ""ANSWER""";

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
                answer.AnswerID = reader.GetInt32(0);
                answer.QuestionID = Convert.ToInt32(reader.GetValue(1));
                answer.MemberID = Convert.ToInt32(reader.GetValue(2));
                answer.AnswerText = reader.GetString(3);
                answer.AnswerDate = Convert.ToString(reader.GetValue(4));

                

                answers.Add(answer);

                foreach (Answer c in answers)
                {
                    Console.WriteLine("liste DAO : " + c.ToString());
                }

            }

            return answers.ToList<Answer>();
        }

    }
}
