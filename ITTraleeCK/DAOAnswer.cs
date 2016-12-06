using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string cmdText = @"SELECT m.USERNAME, q.QUESTION_TEXT, a.ANSWER_TEXT, a.ANSWER_DATE FROM ANSWER a JOIN Question q on q.QUESTION_ID = a.QUESTION_ID JOIN MEMBER m on m.MEMBER_ID = a.MEMBER_ID ORDER BY a.ANSWER_DATE DESC";

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

                    answer.Member.Username = reader.GetString(0);
                    answer.Question.QuestionText = reader.GetString(1);
                    answer.AnswerText = reader.GetString(2);
                    answer.AnswerDate = reader.GetDateTime(3);

                    answers.Add(answer);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return answers;
        }


        /*
         * Method to create answer by calling procedure
         * 
         */
        public static void CreateAnswer(int questionID, string answerText)
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

            string strSQL = "CREATEANSWER";

            cmd.Parameters.Add("question_id", OracleDbType.Int32).Value = questionID;
            cmd.Parameters.Add("member_id", OracleDbType.Int32).Value = SessionUser.WhoIsLoggedIn().MemberID;
            cmd.Parameters.Add("question_text", OracleDbType.Varchar2).Value = answerText;

            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();

            DBConnection.Close();
        }

    

    }
}
