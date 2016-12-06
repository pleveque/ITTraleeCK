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

        /*
         * Method to select all answer present in database
         * return a list of answer
         * 
         */ 
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

            //Query to select username of member, question text the answer text and the date of answer with the sames ID
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

                    //Get member in class answer takes the value of member
                    //Is the same for question
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
         * pass in arguments the id of question and the answer text
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

            //Indicate that is a procedure stored
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //Indicate the name of procedure
            string strSQL = "CREATEANSWER";
            
            //Pass attributes required to run the procedure
            cmd.Parameters.Add("question_id", OracleDbType.Int32).Value = questionID;
            cmd.Parameters.Add("member_id", OracleDbType.Int32).Value = SessionUser.WhoIsLoggedIn().MemberID;
            cmd.Parameters.Add("question_text", OracleDbType.Varchar2).Value = answerText;

            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();

            DBConnection.Close();
        }

        /**
         * Method to delete an answer
         * pass in argument the text of answer
         * 
         */ 
        public static void DeleteAnswer(string answerText)
        {
            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string strSQL = @"DELETE FROM ANSWER WHERE ANSWER_TEXT='" + answerText + "'";

            cmd.CommandText = strSQL;

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Answer deleted !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DBConnection.Close();
        }

    }
}
