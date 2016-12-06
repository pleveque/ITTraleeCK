using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITTraleeCK
{
    class DAOQuestion
    {

        public static List<Question> SelectAllQuestions()
        {
            List<Question> questions = new List<Question>();
            
            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string sqlQuery = @"SELECT m.USERNAME, c.CATEGORY_NAME, q.QUESTION_TEXT, q.QUESTION_DATE FROM QUESTION q JOIN MEMBER m on q.MEMBER_ID = m.MEMBER_ID JOIN CATEGORY c on c.CATEGORY_ID = q.CATEGORY_ID ORDER BY q.QUESTION_DATE DESC";
            
            cmd.CommandText = sqlQuery;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    Question question = new Question();
                    Member member = new Member();
                    Category category = new Category();
                    Answer answer = new Answer();
                    question.Member = member;
                    question.Category = category;

                    question.Member.Username = reader.GetString(0);
                    question.Category.CategoryName = reader.GetString(1);
                    question.QuestionText = reader.GetString(2);
                    question.QuestionDate = reader.GetDateTime(3);

                    questions.Add(question);

                }
             }

           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return questions;
        }


        /*
         * Method to create question by calling procedure
         * 
         */
        public static void CreateQuestion(int categoryID, string questionText)
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

            string strSQL = "CREATEQUESTION";

            cmd.Parameters.Add("member_id", OracleDbType.Int32).Value = SessionUser.WhoIsLoggedIn().MemberID;
            cmd.Parameters.Add("category_id", OracleDbType.Int32).Value = categoryID;
            cmd.Parameters.Add("question_text", OracleDbType.Varchar2).Value = questionText;
            
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();

            DBConnection.Close();

        }

        /**
         * Method to delete a question
         * 
         */
       public static void DeleteQuestion(string questionText)
        {
            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string strSQL = @"DELETE FROM QUESTION WHERE QUESTION_TEXT='" + questionText + "'";
               
            cmd.CommandText = strSQL;

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Question deleted !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DBConnection.Close();
        }

    }
}
