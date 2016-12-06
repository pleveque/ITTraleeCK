using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITTraleeCK
{
    public partial class ITTraleeCK : Form
    {
        public ITTraleeCK()
        {
            InitializeComponent();
            InitializeCategory();
            InitializeQuestions();
        }

        public void InitializeCategory()
        {
            List<Category> categoriesKnowledge = new List<Category>();
            categoriesKnowledge = DAOCategory.SelectAllCategories();

            comboBoxCatKnowledge.Items.Clear();
            
            foreach (Category c in categoriesKnowledge)
            {
                comboBoxCatKnowledge.Items.Add(c.CategoryName);
            }

            List<Category> categories = new List<Category>();
            categories = DAOCategory.SelectAllCategories();

            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Insert(0, "");

            foreach (Category c in categories)
            {
                comboBoxCategory.Items.Insert(c.CategoryID, c.CategoryName);
            }
        }

        public void InitializeQuestions()
        {
            List<Question> questions = new List<Question>();
            questions = DAOQuestion.SelectAllQuestions();

            comboBoxQuestions.Items.Clear();
            comboBoxQuestions.Items.Insert(0, "");

            foreach (Question q in questions)
            {
                comboBoxQuestions.Items.Insert(q.QuestionID, q.QuestionText);
            }

        }

        /*
         * Method to display all information of the member who is connected
         *
         */
        private void DisplayMemberConnected()
        {
            Member member = new Member();

            member = DAOMember.SelectMemberConnected();

            label2Username.Text = member.Username;
            textBoxPassword.Text = member.MemberPassword;
            textBoxAge.Text = member.Age.ToString();
            textBoxEmail.Text = member.Email;
            comboBoxGender.Text = member.Gender;
            comboBoxNationality.Text = member.Nationality;
            comboBoxCatKnowledge.Text = member.CategoryOfKnowledge;
            label2TypeOfMember.Text = member.TypeOfMember;

            if (member.Newsletter.ToString().Equals('y'))
            {
                checkBoxNewsletter.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxNewsletter.CheckState = CheckState.Unchecked;
            }
        }
        
        /*
         * Method to display all members present in the application
         * 
        */
        private void DisplayAllMembers()
        {
            List<Member> list = new List<Member>();

            listViewUsers.Items.Clear();

            try
            {
                list = DAOMember.SelectAllMembers();

                foreach (Member m in list)
                {
                    ListViewItem item = new ListViewItem(m.MemberID.ToString());
                    item.SubItems.Add(m.Username);
                    item.SubItems.Add(m.Age.ToString());
                    item.SubItems.Add(m.Email);
                    item.SubItems.Add(m.Gender);
                    item.SubItems.Add(m.Nationality);
                    item.SubItems.Add(m.CategoryOfKnowledge);
                    item.SubItems.Add(m.Newsletter);
                    item.SubItems.Add(m.TypeOfMember);

                    listViewUsers.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("There is not any users register in the application");
            }
        }

        /**
         * Method to display all questions present in database
         * 
         */
        private void DisplayAllQuestions()
        {
            List<Question> list = new List<Question>();

            listViewQuestion.Items.Clear();

            list = DAOQuestion.SelectAllQuestions();

            foreach (Question q in list)
            {
                ListViewItem item = new ListViewItem(q.Member.Username);
                item.SubItems.Add(q.QuestionText);
                item.SubItems.Add(q.Category.CategoryName);
                item.SubItems.Add(q.QuestionDate.ToString());

                listViewQuestion.Items.Add(item);
            }
        }

        public void DisplayAllAnswers()
        {
            List<Answer> answers = new List<Answer>();
            listViewAnswers.Items.Clear();

            answers = DAOAnswer.SelectAllAnswers();

            foreach(Answer a in answers)
            {
                ListViewItem item = new ListViewItem(a.Member.Username);
                item.SubItems.Add(a.AnswerText);
                item.SubItems.Add(a.Question.QuestionText);
                item.SubItems.Add(a.AnswerDate.ToString());

                listViewAnswers.Items.Add(item);
            }
        }

        /*
         * Method to update information of user when the user click on "save" button
         * 
        */
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            string newsletter;

            List<Category> categories = new List<Category>();

            foreach (Category c in categories)
            {
                comboBoxCategory.Items.Add(c.CategoryName);
            }

            if (checkBoxNewsletter.Checked) { newsletter = "y"; }
            else { newsletter = "f"; }

            try
            {
                DAOMember.UpdateMemberConnected(label2Username.Text,
                                                textBoxPassword.Text,
                                                int.Parse(textBoxAge.Text),
                                                textBoxEmail.Text,
                                                comboBoxGender.Text,
                                                comboBoxNationality.Text,
                                                comboBoxCatKnowledge.Text,
                                                label2TypeOfMember.Text,
                                                newsletter);

                MessageBox.Show("Saved successfully");

            }
            catch
            {
                MessageBox.Show("Impossible to save your changing");
            }
        }
        

        /*
         * When the load of the main form (after login)
         * Load all informations of user connected and display on the form
         */
       private void ITTraleeCK_VisibleChanged(object sender, EventArgs e)
        {
            DisplayMemberConnected();
        }


        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                //Case to display all information on the user who is connected
                case 0:
                    DisplayMemberConnected();
                    break;

                //Method to display all users present in database (register in application)
                case 1:
                    DisplayAllMembers();
                    break;
                case 2:
                    DisplayAllQuestions();
                    break;
                case 3:
                    InitializeCategory();
                    break;
                case 4:
                    InitializeQuestions();
                    break;
                case 5:
                    DisplayAllAnswers();
                    break;
                    
            }
        }
        
        
        private void PostQuestion_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCategory.Equals("") || textBoxQuestion.Text != null)
            {
                try
                {
                    DAOQuestion.CreateQuestion(comboBoxCategory.SelectedIndex, textBoxQuestion.Text);

                    MessageBox.Show("Question posted");

                    comboBoxCategory.Text = "";
                    textBoxQuestion.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Your can't post empty question");
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You will delete a question. Are you sure you want to continue ?", "DELETE A QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DAOQuestion.DeleteQuestion(textBoxUsername.Text);
                    DisplayAllQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listViewQuestion_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxUsername.Text = listViewQuestion.SelectedItems[0].SubItems[1].Text;
        }

        private void buttonPostAnswer_Click(object sender, EventArgs e)
        {
            if (comboBoxQuestions.Equals("") || textBoxAnswer.Text != null)
            {
                try
                {
                    DAOAnswer.CreateAnswer(comboBoxQuestions.SelectedIndex, textBoxAnswer.Text);

                    MessageBox.Show("Answer posted");

                    comboBoxQuestions.Text = "";
                    textBoxAnswer.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Your can't post empty Answer");
            }
        }

        private void DeleteAnswer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You will delete an answer. Are you sure you want to continue ?", "DELETE A ANSWER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DAOAnswer.DeleteAnswer(textBoxAnswerDelete.Text);
                    DisplayAllAnswers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void listViewAnswers_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAnswerDelete.Text = listViewAnswers.SelectedItems[0].SubItems[1].Text;
        }
    }
}
