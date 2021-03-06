﻿using Oracle.ManagedDataAccess.Client;
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
            InitializeCategory();
        }

        /*
         * Method is called when the application is loaded
         */ 
        public void InitializeCategory()
        {
            List<Category> categories = new List<Category>();
            categories = DAOCategory.SelectAllCategories();

            foreach (Category c in categories)
            {
                //Fill the combobox with the name of category
                comboBoxCatKnowledge.Items.Add(c.CategoryName);
            }
        }
        
        /**
         * Return in the login form
         */ 
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }

        /**
         * Method to register a new member in database
         * 
         */ 
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //The type of member is per default "user"
            string typeOfMember = "user";
            string newsletter;

            if (checkBoxNewsletter.Checked){ newsletter = "y"; }
            else { newsletter = "f"; }

            if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                try
                {
                    DAOMember.CreateMember(textBoxUsername.Text, textBoxPassword.Text, int.Parse(textBoxAge.Text), textBoxEmail.Text, comboBoxGender.Text, comboBoxNationality.Text, comboBoxCatKnowledge.Text, newsletter, typeOfMember);

                    MessageBox.Show("Welcome " + textBoxUsername.Text);

                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                    textBoxAge.Text = "";
                    textBoxEmail.Text = "";
                    comboBoxGender.Text = "";
                    comboBoxNationality.Text = "";
                    comboBoxCatKnowledge.Text = "";
                    newsletter = "";
                    typeOfMember = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Your password isn't the same");
            }
        }
    }
}
