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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageInformation = new System.Windows.Forms.TabPage();
            this.label2Username = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.comboBoxCatKnowledge = new System.Windows.Forms.ComboBox();
            this.label2TypeOfMember = new System.Windows.Forms.Label();
            this.labelTypeOfMember = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.checkBoxNewsletter = new System.Windows.Forms.CheckBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelCatKnowledge = new System.Windows.Forms.Label();
            this.labelInformationUser = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
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
            this.listViewQuestion = new System.Windows.Forms.ListView();
            this.columnAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSortedBy = new System.Windows.Forms.Label();
            this.labelTitleForum = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTitlePostQuestion = new System.Windows.Forms.Label();
            this.labelChooseCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabPageInformation.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageForum.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageInformation);
            this.TabControl.Controls.Add(this.tabPageUsers);
            this.TabControl.Controls.Add(this.tabPageForum);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Location = new System.Drawing.Point(-1, -1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(809, 426);
            this.TabControl.TabIndex = 1;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            this.TabControl.Click += new System.EventHandler(this.ITTraleeCK_VisibleChanged);
            // 
            // tabPageInformation
            // 
            this.tabPageInformation.Controls.Add(this.label2Username);
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
            // label2Username
            // 
            this.label2Username.AutoSize = true;
            this.label2Username.Location = new System.Drawing.Point(109, 68);
            this.label2Username.Name = "label2Username";
            this.label2Username.Size = new System.Drawing.Size(0, 13);
            this.label2Username.TabIndex = 52;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(364, 139);
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
            // label2TypeOfMember
            // 
            this.label2TypeOfMember.AutoSize = true;
            this.label2TypeOfMember.Location = new System.Drawing.Point(104, 270);
            this.label2TypeOfMember.Name = "label2TypeOfMember";
            this.label2TypeOfMember.Size = new System.Drawing.Size(0, 13);
            this.label2TypeOfMember.TabIndex = 48;
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
            this.textBoxEmail.Location = new System.Drawing.Point(109, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 20);
            this.textBoxEmail.TabIndex = 34;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(109, 140);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(167, 20);
            this.textBoxPassword.TabIndex = 32;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(106, 178);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Email";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(363, 123);
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
            this.tabPageUsers.Text = "Members";
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
            this.listViewUsers.FullRowSelect = true;
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
            this.tabPageForum.Controls.Add(this.listViewQuestion);
            this.tabPageForum.Controls.Add(this.comboBox1);
            this.tabPageForum.Controls.Add(this.labelSortedBy);
            this.tabPageForum.Controls.Add(this.labelTitleForum);
            this.tabPageForum.Location = new System.Drawing.Point(4, 22);
            this.tabPageForum.Name = "tabPageForum";
            this.tabPageForum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForum.Size = new System.Drawing.Size(801, 400);
            this.tabPageForum.TabIndex = 2;
            this.tabPageForum.Text = "Forum";
            this.tabPageForum.UseVisualStyleBackColor = true;
            // 
            // listViewQuestion
            // 
            this.listViewQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAuthor,
            this.columnQuestion,
            this.columnCategory,
            this.columnDate,
            this.columnAnswer});
            this.listViewQuestion.FullRowSelect = true;
            this.listViewQuestion.GridLines = true;
            this.listViewQuestion.Location = new System.Drawing.Point(36, 105);
            this.listViewQuestion.Name = "listViewQuestion";
            this.listViewQuestion.Size = new System.Drawing.Size(576, 230);
            this.listViewQuestion.TabIndex = 4;
            this.listViewQuestion.UseCompatibleStateImageBehavior = false;
            this.listViewQuestion.View = System.Windows.Forms.View.Details;
            // 
            // columnAuthor
            // 
            this.columnAuthor.Text = "Author";
            this.columnAuthor.Width = 105;
            // 
            // columnQuestion
            // 
            this.columnQuestion.Text = "Question";
            this.columnQuestion.Width = 91;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 80;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 102;
            // 
            // columnAnswer
            // 
            this.columnAnswer.Text = "Answer";
            this.columnAnswer.Width = 95;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelSortedBy
            // 
            this.labelSortedBy.AutoSize = true;
            this.labelSortedBy.Location = new System.Drawing.Point(33, 63);
            this.labelSortedBy.Name = "labelSortedBy";
            this.labelSortedBy.Size = new System.Drawing.Size(59, 13);
            this.labelSortedBy.TabIndex = 1;
            this.labelSortedBy.Text = "Sorted By :";
            // 
            // labelTitleForum
            // 
            this.labelTitleForum.AutoSize = true;
            this.labelTitleForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelTitleForum.Location = new System.Drawing.Point(221, 3);
            this.labelTitleForum.Name = "labelTitleForum";
            this.labelTitleForum.Size = new System.Drawing.Size(312, 26);
            this.labelTitleForum.TabIndex = 0;
            this.labelTitleForum.Text = "Welcome to ITTraleeCK Forum";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBoxCategory);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelChooseCategory);
            this.tabPage1.Controls.Add(this.labelTitlePostQuestion);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 400);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 134);
            this.textBox1.TabIndex = 0;
            // 
            // labelTitlePostQuestion
            // 
            this.labelTitlePostQuestion.AutoSize = true;
            this.labelTitlePostQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTitlePostQuestion.Location = new System.Drawing.Point(256, 3);
            this.labelTitlePostQuestion.Name = "labelTitlePostQuestion";
            this.labelTitlePostQuestion.Size = new System.Drawing.Size(201, 31);
            this.labelTitlePostQuestion.TabIndex = 1;
            this.labelTitlePostQuestion.Text = "Post a question";
            // 
            // labelChooseCategory
            // 
            this.labelChooseCategory.AutoSize = true;
            this.labelChooseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelChooseCategory.Location = new System.Drawing.Point(20, 80);
            this.labelChooseCategory.Name = "labelChooseCategory";
            this.labelChooseCategory.Size = new System.Drawing.Size(139, 17);
            this.labelChooseCategory.TabIndex = 3;
            this.labelChooseCategory.Text = "Choose a category : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.Location = new System.Drawing.Point(163, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Note : You might write a question with at least 3 characters and maximum 1000 ch" +
    "aracters";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
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
            this.comboBoxCategory.Location = new System.Drawing.Point(165, 80);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(217, 21);
            this.comboBoxCategory.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Post question";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ITTraleeCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 384);
            this.Controls.Add(this.TabControl);
            this.Name = "ITTraleeCK";
            this.Text = "ITTraleeCK ";
            this.VisibleChanged += new System.EventHandler(this.ITTraleeCK_VisibleChanged);
            this.TabControl.ResumeLayout(false);
            this.tabPageInformation.ResumeLayout(false);
            this.tabPageInformation.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageForum.ResumeLayout(false);
            this.tabPageForum.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
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
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TabPage tabPageForum;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelSortedBy;
        private System.Windows.Forms.Label labelTitleForum;
        private System.Windows.Forms.Label label2Username;
        private System.Windows.Forms.ListView listViewQuestion;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnQuestion;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnAnswer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChooseCategory;
        private System.Windows.Forms.Label labelTitlePostQuestion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}