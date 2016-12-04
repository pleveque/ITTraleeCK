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
        
        /**
         * Method to display all users present in database (register in application)
         * 
         */
        private void Users_Click(object sender, EventArgs e)
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


        private void ITTraleeCK_VisibleChanged(object sender, EventArgs e)
        {

            Member member = new Member();

            member = DAOMember.SelectMemberConnected();

            textBoxUsername.Text = member.Username;
            textBoxPassword.Text = member.MemberPassword;
            textBoxAge.Text = member.Age.ToString();
            textBoxEmail.Text = member.Email;
            comboBoxGender.Text = member.Gender;
            comboBoxNationality.Text = member.Nationality;
            comboBoxCatKnowledge.Text = member.CategoryOfKnowledge;
            label2TypeOfMember.Text = member.TypeOfMember;

            if (member.Newsletter.ToString().Equals('y')) { 
                checkBoxNewsletter.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxNewsletter.CheckState = CheckState.Unchecked;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            string newsletter;

            if (checkBoxNewsletter.Checked) { newsletter = "y"; }
            else { newsletter = "f"; }

            try
            {
                DAOMember.UpdateMemberConnected(textBoxUsername.Text,
                textBoxPassword.Text,
                int.Parse(textBoxAge.Text),
                textBoxEmail.Text,
                comboBoxGender.Text,
                comboBoxNationality.Text,
                comboBoxCatKnowledge.Text,
                label2TypeOfMember.Text,
                newsletter);

                MessageBox.Show("saved successfully");

            }
            catch
            {
                MessageBox.Show("Impossible to save your update");
            }
        }
    }
}
