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
            this.label2TypeOfMember = new System.Windows.Forms.Label();
            this.label2Username = new System.Windows.Forms.Label();
            this.labelTileInfo = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.comboBoxCatKnowledge = new System.Windows.Forms.ComboBox();
            this.labelTypeOfMember = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.checkBoxNewsletter = new System.Windows.Forms.CheckBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelCatKnowledge = new System.Windows.Forms.Label();
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listViewQuestion = new System.Windows.Forms.ListView();
            this.columnAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTitleForum = new System.Windows.Forms.Label();
            this.tabPagePostAQuestion = new System.Windows.Forms.TabPage();
            this.labelWriteQuestion = new System.Windows.Forms.Label();
            this.PostQuestion = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChooseCategory = new System.Windows.Forms.Label();
            this.labelTitlePostQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.tabPagePostAnswer = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPostAnswer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.comboBoxQuestions = new System.Windows.Forms.ComboBox();
            this.Answers = new System.Windows.Forms.TabPage();
            this.textBoxAnswerDelete = new System.Windows.Forms.TextBox();
            this.DeleteAnswer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewAnswers = new System.Windows.Forms.ListView();
            this.columnAuthorAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestionText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnswerDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControl.SuspendLayout();
            this.tabPageInformation.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageForum.SuspendLayout();
            this.tabPagePostAQuestion.SuspendLayout();
            this.tabPagePostAnswer.SuspendLayout();
            this.Answers.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageInformation);
            this.TabControl.Controls.Add(this.tabPageUsers);
            this.TabControl.Controls.Add(this.tabPageForum);
            this.TabControl.Controls.Add(this.tabPagePostAQuestion);
            this.TabControl.Controls.Add(this.tabPagePostAnswer);
            this.TabControl.Controls.Add(this.Answers);
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
            this.tabPageInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageInformation.Controls.Add(this.label2TypeOfMember);
            this.tabPageInformation.Controls.Add(this.label2Username);
            this.tabPageInformation.Controls.Add(this.labelTileInfo);
            this.tabPageInformation.Controls.Add(this.comboBoxGender);
            this.tabPageInformation.Controls.Add(this.comboBoxNationality);
            this.tabPageInformation.Controls.Add(this.comboBoxCatKnowledge);
            this.tabPageInformation.Controls.Add(this.labelTypeOfMember);
            this.tabPageInformation.Controls.Add(this.buttonUpdate);
            this.tabPageInformation.Controls.Add(this.textBoxAge);
            this.tabPageInformation.Controls.Add(this.checkBoxNewsletter);
            this.tabPageInformation.Controls.Add(this.labelNationality);
            this.tabPageInformation.Controls.Add(this.labelCatKnowledge);
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
            // 
            // label2TypeOfMember
            // 
            this.label2TypeOfMember.AutoSize = true;
            this.label2TypeOfMember.Location = new System.Drawing.Point(167, 271);
            this.label2TypeOfMember.Name = "label2TypeOfMember";
            this.label2TypeOfMember.Size = new System.Drawing.Size(0, 13);
            this.label2TypeOfMember.TabIndex = 54;
            // 
            // label2Username
            // 
            this.label2Username.AutoSize = true;
            this.label2Username.Location = new System.Drawing.Point(167, 69);
            this.label2Username.Name = "label2Username";
            this.label2Username.Size = new System.Drawing.Size(0, 13);
            this.label2Username.TabIndex = 53;
            // 
            // labelTileInfo
            // 
            this.labelTileInfo.AutoSize = true;
            this.labelTileInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTileInfo.Location = new System.Drawing.Point(299, 3);
            this.labelTileInfo.Name = "labelTileInfo";
            this.labelTileInfo.Size = new System.Drawing.Size(180, 26);
            this.labelTileInfo.TabIndex = 52;
            this.labelTileInfo.Text = "User Information";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(422, 123);
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
            this.comboBoxNationality.Location = new System.Drawing.Point(426, 271);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(167, 21);
            this.comboBoxNationality.TabIndex = 50;
            // 
            // comboBoxCatKnowledge
            // 
            this.comboBoxCatKnowledge.FormattingEnabled = true;
            this.comboBoxCatKnowledge.Location = new System.Drawing.Point(422, 197);
            this.comboBoxCatKnowledge.Name = "comboBoxCatKnowledge";
            this.comboBoxCatKnowledge.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCatKnowledge.TabIndex = 49;
            // 
            // labelTypeOfMember
            // 
            this.labelTypeOfMember.AutoSize = true;
            this.labelTypeOfMember.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeOfMember.Location = new System.Drawing.Point(164, 248);
            this.labelTypeOfMember.Name = "labelTypeOfMember";
            this.labelTypeOfMember.Size = new System.Drawing.Size(106, 17);
            this.labelTypeOfMember.TabIndex = 47;
            this.labelTypeOfMember.Text = "Type of member";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Location = new System.Drawing.Point(677, 301);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 47);
            this.buttonUpdate.TabIndex = 43;
            this.buttonUpdate.Text = "Save";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(426, 63);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(163, 20);
            this.textBoxAge.TabIndex = 41;
            // 
            // checkBoxNewsletter
            // 
            this.checkBoxNewsletter.AutoSize = true;
            this.checkBoxNewsletter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNewsletter.Location = new System.Drawing.Point(329, 313);
            this.checkBoxNewsletter.Name = "checkBoxNewsletter";
            this.checkBoxNewsletter.Size = new System.Drawing.Size(86, 19);
            this.checkBoxNewsletter.TabIndex = 40;
            this.checkBoxNewsletter.Text = "Newsletter";
            this.checkBoxNewsletter.UseVisualStyleBackColor = true;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.Location = new System.Drawing.Point(421, 248);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(74, 17);
            this.labelNationality.TabIndex = 38;
            this.labelNationality.Text = "Nationality";
            // 
            // labelCatKnowledge
            // 
            this.labelCatKnowledge.AutoSize = true;
            this.labelCatKnowledge.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatKnowledge.Location = new System.Drawing.Point(423, 179);
            this.labelCatKnowledge.Name = "labelCatKnowledge";
            this.labelCatKnowledge.Size = new System.Drawing.Size(149, 17);
            this.labelCatKnowledge.TabIndex = 36;
            this.labelCatKnowledge.Text = "Category of Knowledge";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(167, 195);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 20);
            this.textBoxEmail.TabIndex = 34;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(167, 124);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(167, 20);
            this.textBoxPassword.TabIndex = 32;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(164, 179);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 17);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Email";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(421, 107);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(53, 17);
            this.labelGender.TabIndex = 29;
            this.labelGender.Text = "Gender";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(423, 45);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(32, 17);
            this.Age.TabIndex = 27;
            this.Age.Text = "Age";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(164, 108);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(66, 17);
            this.LabelPassword.TabIndex = 26;
            this.LabelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(164, 47);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 17);
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
            this.listViewUsers.Size = new System.Drawing.Size(805, 360);
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
            this.tabPageForum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageForum.Controls.Add(this.textBoxUsername);
            this.tabPageForum.Controls.Add(this.buttonDelete);
            this.tabPageForum.Controls.Add(this.listViewQuestion);
            this.tabPageForum.Controls.Add(this.labelTitleForum);
            this.tabPageForum.Location = new System.Drawing.Point(4, 22);
            this.tabPageForum.Name = "tabPageForum";
            this.tabPageForum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForum.Size = new System.Drawing.Size(801, 400);
            this.tabPageForum.TabIndex = 2;
            this.tabPageForum.Text = "Questions";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(41, 21);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(23, 10);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Brown;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(698, 35);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 42);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listViewQuestion
            // 
            this.listViewQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAuthor,
            this.columnQuestion,
            this.columnCategory,
            this.columnDate});
            this.listViewQuestion.FullRowSelect = true;
            this.listViewQuestion.GridLines = true;
            this.listViewQuestion.Location = new System.Drawing.Point(22, 83);
            this.listViewQuestion.Name = "listViewQuestion";
            this.listViewQuestion.Size = new System.Drawing.Size(765, 248);
            this.listViewQuestion.TabIndex = 4;
            this.listViewQuestion.UseCompatibleStateImageBehavior = false;
            this.listViewQuestion.View = System.Windows.Forms.View.Details;
            this.listViewQuestion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewQuestion_MouseClick);
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
            // labelTitleForum
            // 
            this.labelTitleForum.AutoSize = true;
            this.labelTitleForum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleForum.Location = new System.Drawing.Point(252, 21);
            this.labelTitleForum.Name = "labelTitleForum";
            this.labelTitleForum.Size = new System.Drawing.Size(310, 26);
            this.labelTitleForum.TabIndex = 0;
            this.labelTitleForum.Text = "Welcome to ITTraleeCK Forum";
            // 
            // tabPagePostAQuestion
            // 
            this.tabPagePostAQuestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagePostAQuestion.Controls.Add(this.labelWriteQuestion);
            this.tabPagePostAQuestion.Controls.Add(this.PostQuestion);
            this.tabPagePostAQuestion.Controls.Add(this.comboBoxCategory);
            this.tabPagePostAQuestion.Controls.Add(this.label1);
            this.tabPagePostAQuestion.Controls.Add(this.labelChooseCategory);
            this.tabPagePostAQuestion.Controls.Add(this.labelTitlePostQuestion);
            this.tabPagePostAQuestion.Controls.Add(this.textBoxQuestion);
            this.tabPagePostAQuestion.Location = new System.Drawing.Point(4, 22);
            this.tabPagePostAQuestion.Name = "tabPagePostAQuestion";
            this.tabPagePostAQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePostAQuestion.Size = new System.Drawing.Size(801, 400);
            this.tabPagePostAQuestion.TabIndex = 3;
            this.tabPagePostAQuestion.Text = "Post a question";
            // 
            // labelWriteQuestion
            // 
            this.labelWriteQuestion.AutoSize = true;
            this.labelWriteQuestion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWriteQuestion.Location = new System.Drawing.Point(20, 128);
            this.labelWriteQuestion.Name = "labelWriteQuestion";
            this.labelWriteQuestion.Size = new System.Drawing.Size(137, 17);
            this.labelWriteQuestion.TabIndex = 22;
            this.labelWriteQuestion.Text = "Write your question : ";
            // 
            // PostQuestion
            // 
            this.PostQuestion.BackColor = System.Drawing.Color.SteelBlue;
            this.PostQuestion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostQuestion.Location = new System.Drawing.Point(668, 308);
            this.PostQuestion.Name = "PostQuestion";
            this.PostQuestion.Size = new System.Drawing.Size(105, 43);
            this.PostQuestion.TabIndex = 21;
            this.PostQuestion.Text = "Post question";
            this.PostQuestion.UseVisualStyleBackColor = false;
            this.PostQuestion.Click += new System.EventHandler(this.PostQuestion_Click_1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label1.Location = new System.Drawing.Point(163, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Note : You might write a question with at least 3 characters and maximum 1000 ch" +
    "aracters";
            // 
            // labelChooseCategory
            // 
            this.labelChooseCategory.AutoSize = true;
            this.labelChooseCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseCategory.Location = new System.Drawing.Point(20, 80);
            this.labelChooseCategory.Name = "labelChooseCategory";
            this.labelChooseCategory.Size = new System.Drawing.Size(129, 17);
            this.labelChooseCategory.TabIndex = 3;
            this.labelChooseCategory.Text = "Choose a category : ";
            // 
            // labelTitlePostQuestion
            // 
            this.labelTitlePostQuestion.AutoSize = true;
            this.labelTitlePostQuestion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePostQuestion.Location = new System.Drawing.Point(306, 15);
            this.labelTitlePostQuestion.Name = "labelTitlePostQuestion";
            this.labelTitlePostQuestion.Size = new System.Drawing.Size(165, 26);
            this.labelTitlePostQuestion.TabIndex = 1;
            this.labelTitlePostQuestion.Text = "Post a question";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(165, 127);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(553, 134);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // tabPagePostAnswer
            // 
            this.tabPagePostAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagePostAnswer.Controls.Add(this.label5);
            this.tabPagePostAnswer.Controls.Add(this.buttonPostAnswer);
            this.tabPagePostAnswer.Controls.Add(this.label4);
            this.tabPagePostAnswer.Controls.Add(this.label3);
            this.tabPagePostAnswer.Controls.Add(this.label2);
            this.tabPagePostAnswer.Controls.Add(this.textBoxAnswer);
            this.tabPagePostAnswer.Controls.Add(this.comboBoxQuestions);
            this.tabPagePostAnswer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePostAnswer.Name = "tabPagePostAnswer";
            this.tabPagePostAnswer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePostAnswer.Size = new System.Drawing.Size(801, 400);
            this.tabPagePostAnswer.TabIndex = 4;
            this.tabPagePostAnswer.Text = "Post an Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label5.Location = new System.Drawing.Point(163, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "*Note : You might write an answer with at least 3 characters and maximum 1000 cha" +
    "racters";
            // 
            // buttonPostAnswer
            // 
            this.buttonPostAnswer.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPostAnswer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPostAnswer.Location = new System.Drawing.Point(669, 308);
            this.buttonPostAnswer.Name = "buttonPostAnswer";
            this.buttonPostAnswer.Size = new System.Drawing.Size(105, 43);
            this.buttonPostAnswer.TabIndex = 22;
            this.buttonPostAnswer.Text = "Post answer";
            this.buttonPostAnswer.UseVisualStyleBackColor = false;
            this.buttonPostAnswer.Click += new System.EventHandler(this.buttonPostAnswer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Post an answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Write your answer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose a question :";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(165, 127);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(553, 134);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // comboBoxQuestions
            // 
            this.comboBoxQuestions.FormattingEnabled = true;
            this.comboBoxQuestions.Location = new System.Drawing.Point(165, 80);
            this.comboBoxQuestions.Name = "comboBoxQuestions";
            this.comboBoxQuestions.Size = new System.Drawing.Size(289, 21);
            this.comboBoxQuestions.TabIndex = 0;
            // 
            // Answers
            // 
            this.Answers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Answers.Controls.Add(this.textBoxAnswerDelete);
            this.Answers.Controls.Add(this.DeleteAnswer);
            this.Answers.Controls.Add(this.label6);
            this.Answers.Controls.Add(this.listViewAnswers);
            this.Answers.Location = new System.Drawing.Point(4, 22);
            this.Answers.Name = "Answers";
            this.Answers.Padding = new System.Windows.Forms.Padding(3);
            this.Answers.Size = new System.Drawing.Size(801, 400);
            this.Answers.TabIndex = 5;
            this.Answers.Text = "Answers";
            // 
            // textBoxAnswerDelete
            // 
            this.textBoxAnswerDelete.Location = new System.Drawing.Point(44, 31);
            this.textBoxAnswerDelete.Name = "textBoxAnswerDelete";
            this.textBoxAnswerDelete.Size = new System.Drawing.Size(116, 20);
            this.textBoxAnswerDelete.TabIndex = 8;
            this.textBoxAnswerDelete.Visible = false;
            // 
            // DeleteAnswer
            // 
            this.DeleteAnswer.BackColor = System.Drawing.Color.Brown;
            this.DeleteAnswer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteAnswer.Location = new System.Drawing.Point(679, 31);
            this.DeleteAnswer.Name = "DeleteAnswer";
            this.DeleteAnswer.Size = new System.Drawing.Size(89, 42);
            this.DeleteAnswer.TabIndex = 7;
            this.DeleteAnswer.Text = "Delete";
            this.DeleteAnswer.UseVisualStyleBackColor = false;
            this.DeleteAnswer.Click += new System.EventHandler(this.DeleteAnswer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Answers for each question";
            // 
            // listViewAnswers
            // 
            this.listViewAnswers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAuthorAnswer,
            this.columnAnswer,
            this.columnQuestionText,
            this.columnAnswerDate});
            this.listViewAnswers.FullRowSelect = true;
            this.listViewAnswers.GridLines = true;
            this.listViewAnswers.Location = new System.Drawing.Point(9, 79);
            this.listViewAnswers.Name = "listViewAnswers";
            this.listViewAnswers.Size = new System.Drawing.Size(759, 250);
            this.listViewAnswers.TabIndex = 5;
            this.listViewAnswers.UseCompatibleStateImageBehavior = false;
            this.listViewAnswers.View = System.Windows.Forms.View.Details;
            this.listViewAnswers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewAnswers_MouseClick);
            // 
            // columnAuthorAnswer
            // 
            this.columnAuthorAnswer.Text = "Author";
            this.columnAuthorAnswer.Width = 105;
            // 
            // columnAnswer
            // 
            this.columnAnswer.Text = "Answer";
            this.columnAnswer.Width = 88;
            // 
            // columnQuestionText
            // 
            this.columnQuestionText.Text = "Question";
            this.columnQuestionText.Width = 95;
            // 
            // columnAnswerDate
            // 
            this.columnAnswerDate.Text = "Date Answer";
            this.columnAnswerDate.Width = 109;
            // 
            // ITTraleeCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(802, 384);
            this.Controls.Add(this.TabControl);
            this.Name = "ITTraleeCK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITTraleeCK Admin";
            this.VisibleChanged += new System.EventHandler(this.ITTraleeCK_VisibleChanged);
            this.TabControl.ResumeLayout(false);
            this.tabPageInformation.ResumeLayout(false);
            this.tabPageInformation.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageForum.ResumeLayout(false);
            this.tabPageForum.PerformLayout();
            this.tabPagePostAQuestion.ResumeLayout(false);
            this.tabPagePostAQuestion.PerformLayout();
            this.tabPagePostAnswer.ResumeLayout(false);
            this.tabPagePostAnswer.PerformLayout();
            this.Answers.ResumeLayout(false);
            this.Answers.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.ComboBox comboBoxCatKnowledge;
        private System.Windows.Forms.Label labelTitleForum;
        private System.Windows.Forms.ListView listViewQuestion;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnQuestion;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.TabPage tabPagePostAQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChooseCategory;
        private System.Windows.Forms.Label labelTitlePostQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button PostQuestion;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelWriteQuestion;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelTileInfo;
        private System.Windows.Forms.Label label2Username;
        private System.Windows.Forms.Label label2TypeOfMember;
        private System.Windows.Forms.TabPage tabPagePostAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.ComboBox comboBoxQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPostAnswer;
        private System.Windows.Forms.TabPage Answers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewAnswers;
        private System.Windows.Forms.ColumnHeader columnAuthorAnswer;
        private System.Windows.Forms.ColumnHeader columnAnswer;
        private System.Windows.Forms.ColumnHeader columnQuestionText;
        private System.Windows.Forms.ColumnHeader columnAnswerDate;
        private System.Windows.Forms.Button DeleteAnswer;
        private System.Windows.Forms.TextBox textBoxAnswerDelete;
    }
}