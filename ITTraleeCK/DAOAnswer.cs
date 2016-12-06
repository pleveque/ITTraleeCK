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
            
            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM ANSWER";

            cmd.CommandText = cmdText;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    Answer answer = new Answer();
                    Member member = new Member();
                    Question question = new Question();

                    answer.Member = member;
                    answer.Question = question;

                    answer.AnswerID = reader.GetInt32(0);
                    answer.Question.QuestionID = reader.GetInt32(1);
                    answer.Member.MemberID = reader.GetInt32(2);
                    answer.AnswerText = reader.GetString(3);
                    answer.AnswerDate = reader.GetDateTime(4);

                    answers.Add(answer);
                }
            }

            catch
            {
                throw;
            }


            return answers.ToList<Answer>();
        }

    }
}
