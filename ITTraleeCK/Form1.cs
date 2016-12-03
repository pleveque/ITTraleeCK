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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if(DAOMember.Login(textBoxUsername.Text, textBoxPassword.Text))
            {
                this.Hide();
                ITTraleeCK mainForm = new ITTraleeCK();
                mainForm.Show();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }
    }
}
