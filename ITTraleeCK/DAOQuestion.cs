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

            string sqlQuery = @"SELECT m.USERNAME, c.CATEGORY_NAME, q.QUESTION_TEXT, q.QUESTION_DATE FROM QUESTION q JOIN MEMBER m on q.MEMBER_ID = m.MEMBER_ID JOIN CATEGORY c on c.CATEGORY_id = q.CATEGORY_ID ORDER BY q.QUESTION_DATE DESC";
            
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

        public static void CreateQuestion(/*?????????????*/)
        {

        }
    }
}
