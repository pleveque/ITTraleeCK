using Oracle.ManagedDataAccess.Client;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //DAOMember.CreateMember(textBoxUsername.Text, textBoxPassword.Text, textBoxConfirmPassword.Text, textBoxAge.Text, textBoxEmail.Text, Check)
        }

        private void comboBoxCatKnowledge_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM CATEGORY";
            Console.WriteLine(cmdText);
            //comboBoxCatKnowledge.Items.Add("category", );
            cmd.CommandText = cmdText;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error Category");
            }
        }
    }
}
