namespace ITTraleeCK
{
    partial class ITTraleeCK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Users = new System.Windows.Forms.TabControl();
            this.tabPageInformation = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.checkBoxNewsletter = new System.Windows.Forms.CheckBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelCatKnowledge = new System.Windows.Forms.Label();
            this.labelInformationUser = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.ColumnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnNationality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCatKnow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnNewsletter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTypeUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageForum = new System.Windows.Forms.TabPage();
            this.labelTypeOfMember = new System.Windows.Forms.Label();
            this.label2TypeOfMember = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.comboBoxCatKnowledge = new System.Windows.Forms.ComboBox();
            this.Users.SuspendLayout();
            this.tabPageInformation.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.Controls.Add(this.tabPageInformation);
            this.Users.Controls.Add(this.tabPageUsers);
            this.Users.Controls.Add(this.tabPageForum);
            this.Users.Location = new System.Drawing.Point(-1, -1);
            this.Users.Name = "Users";
            this.Users.SelectedIndex = 0;
            this.Users.Size = new System.Drawing.Size(809, 426);
            this.Users.TabIndex = 1;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // tabPageInformation
            // 
            this.tabPageInformation.Controls.Add(this.comboBoxGender);
            this.tabPageInformation.Controls.Add(this.comboBoxNationality);
            this.tabPageInformation.Controls.Add(this.comboBoxCatKnowledge);
            this.tabPageInformation.Controls.Add(this.label2TypeOfMember);
            this.tabPageInformation.Controls.Add(this.labelTypeOfMember);
            this.tabPageInformation.Controls.Add(this.buttonUpdate);
            this.tabPageInformation.Controls.Add(this.textBoxAge);
            this.tabPageInformation.Controls.Add(this.checkBoxNewsletter);
            this.tabPageInformation.Controls.Add(this.labelNationality);
            this.tabPageInformation.Controls.Add(this.labelCatKnowledge);
            this.tabPageInformation.Controls.Add(this.labelInformationUser);
            this.tabPageInformation.Controls.Add(this.textBoxEmail);
            this.tabPageInformation.Controls.Add(this.textBoxPassword);
            this.tabPageInformation.Controls.Add(this.textBoxUsername);
            this.tabPageInformation.Controls.Add(this.labelEmail);
            this.tabPageInformation.Controls.Add(this.labelGender);
            this.tabPageInformation.Controls.Add(this.Age);
            this.tabPageInformation.Controls.Add(this.LabelPassword);
            this.tabPageInformation.Controls.Add(this.labelUsername);
            this.tabPageInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformation.Name = "tabPageInformation";
            this.tabPageInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformation.Size = new System.Drawing.Size(801, 400);
            this.tabPageInformation.TabIndex = 0;
            this.tabPageInformation.Text = "Information";
            this.tabPageInformation.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(543, 309);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 34);
            this.buttonUpdate.TabIndex = 43;
            this.buttonUpdate.Text = "Save";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(368, 62);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(163, 20);
            this.textBoxAge.TabIndex = 41;
            // 
            // checkBoxNewsletter
            // 
            this.checkBoxNewsletter.AutoSize = true;
            this.checkBoxNewsletter.Location = new System.Drawing.Point(279, 319);
            this.checkBoxNewsletter.Name = "checkBoxNewsletter";
            this.checkBoxNewsletter.Size = new System.Drawing.Size(76, 17);
            this.checkBoxNewsletter.TabIndex = 40;
            this.checkBoxNewsletter.Text = "Newsletter";
            this.checkBoxNewsletter.UseVisualStyleBackColor = true;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(363, 247);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(56, 13);
            this.labelNationality.TabIndex = 38;
            this.labelNationality.Text = "Nationality";
            // 
            // labelCatKnowledge
            // 
            this.labelCatKnowledge.AutoSize = true;
            this.labelCatKnowledge.Location = new System.Drawing.Point(365, 178);
            this.labelCatKnowledge.Name = "labelCatKnowledge";
            this.labelCatKnowledge.Size = new System.Drawing.Size(117, 13);
            this.labelCatKnowledge.TabIndex = 36;
            this.labelCatKnowledge.Text = "Category of Knowledge";
            // 
            // labelInformationUser
            // 
            this.labelInformationUser.AutoSize = true;
            this.labelInformationUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelInformationUser.Location = new System.Drawing.Point(250, 13);
            this.labelInformationUser.MinimumSize = new System.Drawing.Size(12, 12);
            this.labelInformationUser.Name = "labelInformationUser";
            this.labelInformationUser.Size = new System.Drawing.Size(141, 22);
            this.labelInformationUser.TabIndex = 35;
            this.labelInformationUser.Text = "User information";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(107, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 20);
            this.textBoxEmail.TabIndex = 34;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 140);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(167, 20);
            this.textBoxPassword.TabIndex = 32;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(107, 62);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(167, 20);
            this.textBoxUsername.TabIndex = 31;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(104, 178);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Email";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(363, 115);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 29;
            this.labelGender.Text = "Gender";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(365, 44);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(26, 13);
            this.Age.TabIndex = 27;
            this.Age.Text = "Age";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(106, 124);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 26;
            this.LabelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(106, 46);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 25;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.listViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(801, 400);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnID,
            this.ColumnUsername,
            this.ColumnAge,
            this.ColumnEmail,
            this.ColumnGender,
            this.ColumnNationality,
            this.ColumnCatKnow,
            this.ColumnNewsletter,
            this.ColumnTypeUser});
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(-4, 3);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(805, 312);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // ColumnID
            // 
            this.ColumnID.Text = "ID";
            this.ColumnID.Width = 61;
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.Text = "Username";
            this.ColumnUsername.Width = 84;
            // 
            // ColumnAge
            // 
            this.ColumnAge.Text = "Age";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.Text = "Email";
            this.ColumnEmail.Width = 109;
            // 
            // ColumnGender
            // 
            this.ColumnGender.Text = "Gender";
            this.ColumnGender.Width = 67;
            // 
            // ColumnNationality
            // 
            this.ColumnNationality.Text = "Nationality";
            this.ColumnNationality.Width = 72;
            // 
            // ColumnCatKnow
            // 
            this.ColumnCatKnow.Text = "Category Of  Knowledge";
            this.ColumnCatKnow.Width = 144;
            // 
            // ColumnNewsletter
            // 
            this.ColumnNewsletter.Text = "Newsletter";
            this.ColumnNewsletter.Width = 76;
            // 
            // ColumnTypeUser
            // 
            this.ColumnTypeUser.Text = "Type of user";
            this.ColumnTypeUser.Width = 94;
            // 
            // tabPageForum
            // 
            this.tabPageForum.Location = new System.Drawing.Point(4, 22);
            this.tabPageForum.Name = "tabPageForum";
            this.tabPageForum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForum.Size = new System.Drawing.Size(801, 400);
            this.tabPageForum.TabIndex = 2;
            this.tabPageForum.Text = "Forum";
            this.tabPageForum.UseVisualStyleBackColor = true;
            // 
            // labelTypeOfMember
            // 
            this.labelTypeOfMember.AutoSize = true;
            this.labelTypeOfMember.Location = new System.Drawing.Point(100, 247);
            this.labelTypeOfMember.Name = "labelTypeOfMember";
            this.labelTypeOfMember.Size = new System.Drawing.Size(83, 13);
            this.labelTypeOfMember.TabIndex = 47;
            this.labelTypeOfMember.Text = "Type of member";
            // 
            // label2TypeOfMember
            // 
            this.label2TypeOfMember.AutoSize = true;
            this.label2TypeOfMember.Location = new System.Drawing.Point(104, 270);
            this.label2TypeOfMember.Name = "label2TypeOfMember";
            this.label2TypeOfMember.Size = new System.Drawing.Size(0, 13);
            this.label2TypeOfMember.TabIndex = 48;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(366, 140);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(165, 21);
            this.comboBoxGender.TabIndex = 51;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Items.AddRange(new object[] {
            "AFGHANISTAN ",
            "Afrique_Centrale  ",
            "Afrique_du_Sud  ",
            "Albanie  ",
            "Algerie  ",
            "Allemagne  ",
            "Andorre  ",
            "Angola  ",
            "Anguilla  ",
            "Arabie_Saoudite  ",
            "Argentine  ",
            "Armenie  ",
            "Australie  ",
            "Autriche  ",
            "Azerbaidjan  ",
            "Bahamas  ",
            "Bangladesh  ",
            "Barbade  ",
            "Bahrein  ",
            "Belgique  ",
            "Belize  ",
            "Benin  ",
            "Bermudes  ",
            "Bielorussie  ",
            "Bolivie  ",
            "Botswana  ",
            "Bhoutan  ",
            "Boznie_Herzegovine  ",
            "Bresil  ",
            "Brunei  ",
            "Bulgarie  ",
            "Burkina_Faso  ",
            "Burundi  ",
            "Caiman  ",
            "Cambodge  ",
            "Cameroun  ",
            "Canada  ",
            "Canaries  ",
            "Cap_Vert  ",
            "Chili  ",
            "Chine  ",
            "Chypre  ",
            "Colombie  ",
            "Congo  ",
            "Congo_democratique  ",
            "Coree_du_Nord  ",
            "Coree_du_Sud  ",
            "Costa_Rica  ",
            "Côte_d_Ivoire  ",
            "Croatie  ",
            "Cuba  ",
            "Danemark  ",
            "Djibouti  ",
            "Dominique  ",
            "Egypte  ",
            "Emirats_Arabes_Unis  ",
            "Equateur  ",
            "Erythree  ",
            "Espagne  ",
            "Estonie  ",
            "Etats_Unis  ",
            "Ethiopie  ",
            "Falkland  ",
            "Feroe  ",
            "Fidji  ",
            "Finlande  ",
            "France  ",
            "Gabon  ",
            "Gambie  ",
            "Georgie  ",
            "Ghana  ",
            "Gibraltar  ",
            "Grece  ",
            "Grenade  ",
            "Groenland  ",
            "Guadeloupe  ",
            "Guatemala ",
            "Guernesey  ",
            "Guinee  ",
            "Guinee_Bissau  ",
            "Guinee_Equatoriale  ",
            "Guyana  ",
            "Guyane_Francaise  ",
            "Haiti  ",
            "Hawaii  ",
            "Honduras  ",
            "Hong_Kong  ",
            "Hongrie  ",
            "Indonesie  ",
            "Iran  ",
            "Iraq  ",
            "Irlande  ",
            "Islande  ",
            "Israel  ",
            "Italie  ",
            "Jamaique  ",
            "Jan_Mayen  ",
            "Japon  ",
            "Jersey  ",
            "Jordanie  ",
            "Kazakhstan  ",
            "Kenya  ",
            "Kirghizistan  ",
            "Kiribati  ",
            "Koweit  ",
            "Laos  ",
            "Lesotho  ",
            "Lettonie  ",
            "Liban  ",
            "Liberia  ",
            "Liechtenstein  ",
            "Lituanie  ",
            "Luxembourg  ",
            "Lybie  ",
            "Macao  ",
            "Macedoine  ",
            "Madagascar  ",
            "Madère  ",
            "Malaisie  ",
            "Malawi  ",
            "Maldives  ",
            "Mali  ",
            "Malte  ",
            "Mariannes_du_Nord  ",
            "Maroc  ",
            "Marshall  ",
            "Martinique  ",
            "Maurice  ",
            "Mauritanie  ",
            "Mayotte  ",
            "Mexique  ",
            "Micronesie  ",
            "Midway  ",
            "Moldavie  ",
            "Monaco  ",
            "Mongolie  ",
            "Montserrat  ",
            "Mozambique  ",
            "Namibie  ",
            "Nauru  ",
            "Nepal  ",
            "Nicaragua  ",
            "Niger  ",
            "Nigeria  ",
            "Norfolk  ",
            "Norvege  ",
            "Nouvelle_Caledonie  ",
            "Nouvelle_Zelande  ",
            "Ouganda  ",
            "Ouzbekistan  ",
            "Pakistan  ",
            "Palau  ",
            "Palestine  ",
            "Panama  ",
            "Papouasie_Nouvelle_Guinee  ",
            "Paraguay  ",
            "Pays_Bas  ",
            "Perou  ",
            "Philippines  ",
            "Pologne  ",
            "Polynesie  ",
            "Porto_Rico  ",
            "Portugal  ",
            "Qatar  ",
            "Republique_Dominicaine  ",
            "Republique_Tcheque  ",
            "Reunion  ",
            "Roumanie  ",
            "Royaume_Uni  ",
            "Russie  ",
            "Rwanda  ",
            "Sahara_Occidental  ",
            "Sainte_Lucie  ",
            "Saint_Marin  ",
            "Salomon  ",
            "Salvador  ",
            "Samoa_Occidentales ",
            "Samoa_Americaine  ",
            "Sao_Tome_et_Principe  ",
            "Senegal  ",
            "Seychelles  ",
            "Sierra_Leone  ",
            "Singapour  ",
            "Slovaquie  ",
            "Slovenie ",
            "Somalie  ",
            "Soudan  ",
            "Sri_Lanka  ",
            "S1uede  ",
            "Suisse  ",
            "Surinam  ",
            "Swaziland  ",
            "Syrie  ",
            "Tadjikistan  ",
            "Taiwan  ",
            "Tonga  ",
            "Tanzanie  ",
            "Tchad  ",
            "Thailande  ",
            "Tibet  ",
            "Timor_Oriental  ",
            "Togo ",
            "Tunisie  ",
            "Turmenistan  ",
            "Turquie  ",
            "Ukraine  ",
            "Uruguay  ",
            "Vanuatu  ",
            "Vatican  ",
            "Venezuela  ",
            "Vierges_Americaines  ",
            "Vierges_Britanniques  ",
            "Vietnam  ",
            "Yemen  ",
            "Yougoslavie  ",
            "Zambie  ",
            "Zimbabwe"});
            this.comboBoxNationality.Location = new System.Drawing.Point(368, 270);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(167, 21);
            this.comboBoxNationality.TabIndex = 50;
            // 
            // comboBoxCatKnowledge
            // 
            this.comboBoxCatKnowledge.FormattingEnabled = true;
            this.comboBoxCatKnowledge.Items.AddRange(new object[] {
            "Creative Media",
            "Computing",
            "Business",
            "Tourism",
            "Agricultural Engineering",
            "Civil Engineering",
            "Construction Studies",
            "Biological Studies",
            "Pharmaceutical Studies",
            "Nursing",
            "Social Sciences",
            "Health and Leisure Studies"});
            this.comboBoxCatKnowledge.Location = new System.Drawing.Point(364, 196);
            this.comboBoxCatKnowledge.Name = "comboBoxCatKnowledge";
            this.comboBoxCatKnowledge.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCatKnowledge.TabIndex = 49;
            // 
            // ITTraleeCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 384);
            this.Controls.Add(this.Users);
            this.Name = "ITTraleeCK";
            this.Text = "ITTraleeCK ";
            this.VisibleChanged += new System.EventHandler(this.ITTraleeCK_VisibleChanged);
            this.Users.ResumeLayout(false);
            this.tabPageInformation.ResumeLayout(false);
            this.tabPageInformation.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Users;
        private System.Windows.Forms.TabPage tabPageInformation;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.CheckBox checkBoxNewsletter;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelCatKnowledge;
        private System.Windows.Forms.Label labelInformationUser;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TabPage tabPageForum;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader ColumnID;
        private System.Windows.Forms.ColumnHeader ColumnUsername;
        private System.Windows.Forms.ColumnHeader ColumnAge;
        private System.Windows.Forms.ColumnHeader ColumnEmail;
        private System.Windows.Forms.ColumnHeader ColumnGender;
        private System.Windows.Forms.ColumnHeader ColumnNationality;
        private System.Windows.Forms.ColumnHeader ColumnCatKnow;
        private System.Windows.Forms.ColumnHeader ColumnNewsletter;
        private System.Windows.Forms.ColumnHeader ColumnTypeUser;
        private System.Windows.Forms.Label labelTypeOfMember;
        private System.Windows.Forms.Label label2TypeOfMember;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.ComboBox comboBoxCatKnowledge;
    }
}