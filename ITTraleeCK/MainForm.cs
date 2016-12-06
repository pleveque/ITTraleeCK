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

        /**
         * Method to initialize all categories in the combobox in the tab Information and the Tab Post a Question
         */ 
        public void InitializeCategory()
        {
            List<Category> categoriesKnowledge = new List<Category>();
            categoriesKnowledge = DAOCategory.SelectAllCategories();
            
            //Clear combobox before add items
            comboBoxCatKnowledge.Items.Clear();
            
            foreach (Category c in categoriesKnowledge)
            {
                //for each category present in database, add items in combobox
                comboBoxCatKnowledge.Items.Add(c.CategoryName);
            }

            List<Category> categories = new List<Category>();
            categories = DAOCategory.SelectAllCategories();

            //Clear combobox before add items
            comboBoxCategory.Items.Clear();

            //Insert nothing at index 0 because the index can't to begin at index 1
            comboBoxCategory.Items.Insert(0, "");

            foreach (Category c in categories)
            {
                //for each category present in database, add the id of category and the name of categories items in combobox
                comboBoxCategory.Items.Insert(c.CategoryID, c.CategoryName);
            }
        }

        /**
         * Method to inialize all questions in combobox in tab Post a Answer when the main form is loaded
         */  
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
         * Method to display all informations of the member who is connected
         * Used in tab Information
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
         * Used in tab Members
         */
        private void DisplayAllMembers()
        {
            List<Member> list = new List<Member>();

            //Clear listView before to add items
            listViewUsers.Items.Clear();

            try
            {
                //Called method to select all members in DAOMember
                list = DAOMember.SelectAllMembers();

                foreach (Member m in list)
                {
                    //Add items in listView for each member presents
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
         * Used in tab Questions
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

        /**
         * Method to display all answers present in database
         * Used in tab Answers
         */ 
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
         * Used in tab Information
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

        /**
         * Method to loaded informations each time tab is clicked by user
         */ 
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                //Call method when tab Information is clicked to display all informations on the user who is connected in 
                case 0:
                    DisplayMemberConnected();
                    break;

                //Call method when tab Members is clicked to display all users present in database (register in application)
                case 1:
                    DisplayAllMembers();
                    break;
                //Call method when tab Questions to display all questions in listView
                case 2:
                    DisplayAllQuestions();
                    break;
                //Call method when tab Post a Question is clicked to initialize all categories in combobox
                case 3:
                    InitializeCategory();
                    break;
                //Call method when tab Post a Answer is clicked to initialize all questions in combobox
                case 4:
                    InitializeQuestions();
                    break;
                //Call method when tab Answers is clicked to display all answers in listView
                case 5:
                    DisplayAllAnswers();
                    break;
                    
            }
        }
        
        /**
         * Method to post a question when the button "Post Question" is clicked in tab post a question
         */ 
        private void PostQuestion_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCategory.Equals("") || textBoxQuestion.Text != null)
            {
                try
                {
                    //Call method to create question with pass in arguments the id of category selected and the content of question written
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

        /**
         * Method to post a answer in tab Post a Answer when the button "Post a answer" is clicked
         */
        private void buttonPostAnswer_Click(object sender, EventArgs e)
        {
            if (comboBoxQuestions.Equals("") || textBoxAnswer.Text != null)
            {
                try
                {
                    //Call method to create a answer with pass in arguments the id of question selected in combobox and the the content of answer written
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

        /**
         * Method to delete a question in listview in tab Questions when the button "delete" is clicked
         */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You will delete a question. Are you sure you want to continue ?", "DELETE A QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    //Call method in DAO Question to delete question with pass in argument the content of question
                    //the content of question is selected in listViewQuestion_MouseClick
                    DAOQuestion.DeleteQuestion(textBoxUsername.Text);
                    DisplayAllQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*
         * Method to selected item by a mouse click in tab Questions
         */ 
        private void listViewQuestion_MouseClick(object sender, MouseEventArgs e)
        {
            //textBox recuperate the value of question text when a click on row in list view
            textBoxUsername.Text = listViewQuestion.SelectedItems[0].SubItems[1].Text;
        }

        /**
         * Method to delete answer in tab Answer when the button "Delete" is clicked
         */ 
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
