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

            try
            {
                list = DAOMember.SelectAllMembers();

                foreach (Member m in list)
                {

                    ListViewItem item = new ListViewItem(m.MemberID.ToString());
                    
                    item.SubItems.Add(m.Username);
                    item.SubItems.Add(m.MemberPassword);
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

        private void tabPageInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cc");
        }
    }
}
