using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class DAOQuestion
    {

        public static List<Question> SelectAllQuestions()
        {
            List<Question> questions = new List<Question>();
            Question question = new Question();


            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM ""QUESTION""";

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

          /*  while (reader != null && reader.Read())
            {
                question.QuestionID = reader.GetInt32(0);
                question.MemberID = Convert.ToInt32(reader.GetValue(1));
                question.CategoryID = Convert.ToInt32(reader.GetValue(2));
                question.QuestionText = reader.GetString(3);
                question.QuestionDate = Convert.ToString(reader.GetValue(4));

                questions.Add(question);

                foreach (Question q in questions)
                {
                    Console.WriteLine("liste DAO : " + q.ToString());
                }

            }*/

            return questions.ToList<Question>();
        }

        public static void CreateQuestion(/*?????????????*/)
        {

        }
    }
}
