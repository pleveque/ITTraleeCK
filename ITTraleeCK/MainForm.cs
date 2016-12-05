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
         * Method to update information of user when the user click on "save" button
         * 
        */
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            string newsletter;

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
            }
            catch
            {
                MessageBox.Show("Impossible to save your changing");
            }
        }


        /*
         * Method to display all member present in the application
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
            }
        }

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
    }
}
