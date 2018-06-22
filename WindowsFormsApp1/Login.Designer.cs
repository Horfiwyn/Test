namespace WindowsFormsApp1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_checkbox = new System.Windows.Forms.CheckBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.signup_label_email = new System.Windows.Forms.Label();
            this.signup_label_password = new System.Windows.Forms.Label();
            this.signup_label_username = new System.Windows.Forms.Label();
            this.signup_checkbox = new System.Windows.Forms.CheckBox();
            this.signup_button = new System.Windows.Forms.Button();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.login_result = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selected_country = new System.Windows.Forms.Label();
            this.country_list = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_checkbox
            // 
            this.login_checkbox.AutoSize = true;
            this.login_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.login_checkbox.FlatAppearance.BorderSize = 0;
            this.login_checkbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_checkbox.Location = new System.Drawing.Point(136, 84);
            this.login_checkbox.Name = "login_checkbox";
            this.login_checkbox.Size = new System.Drawing.Size(57, 20);
            this.login_checkbox.TabIndex = 15;
            this.login_checkbox.Text = "Show";
            this.login_checkbox.UseVisualStyleBackColor = false;
            this.login_checkbox.CheckedChanged += new System.EventHandler(this.login_checkbox_CheckedChanged);
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.Color.White;
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_username.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(27, 60);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(100, 21);
            this.login_username.TabIndex = 9;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(243, 57);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 27);
            this.login_button.TabIndex = 14;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.Color.White;
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_password.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(136, 60);
            this.login_password.Margin = new System.Windows.Forms.Padding(0);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(100, 21);
            this.login_password.TabIndex = 11;
            this.login_password.UseSystemPasswordChar = true;
            // 
            // signup_label_email
            // 
            this.signup_label_email.AutoSize = true;
            this.signup_label_email.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label_email.Location = new System.Drawing.Point(28, 216);
            this.signup_label_email.Name = "signup_label_email";
            this.signup_label_email.Size = new System.Drawing.Size(39, 16);
            this.signup_label_email.TabIndex = 10;
            this.signup_label_email.Text = "Result";
            // 
            // signup_label_password
            // 
            this.signup_label_password.AutoSize = true;
            this.signup_label_password.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label_password.Location = new System.Drawing.Point(28, 152);
            this.signup_label_password.Name = "signup_label_password";
            this.signup_label_password.Size = new System.Drawing.Size(39, 16);
            this.signup_label_password.TabIndex = 9;
            this.signup_label_password.Text = "Result";
            // 
            // signup_label_username
            // 
            this.signup_label_username.AutoSize = true;
            this.signup_label_username.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_label_username.Location = new System.Drawing.Point(28, 88);
            this.signup_label_username.Name = "signup_label_username";
            this.signup_label_username.Size = new System.Drawing.Size(39, 16);
            this.signup_label_username.TabIndex = 8;
            this.signup_label_username.Text = "Result";
            // 
            // signup_checkbox
            // 
            this.signup_checkbox.AutoSize = true;
            this.signup_checkbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_checkbox.Location = new System.Drawing.Point(182, 127);
            this.signup_checkbox.Name = "signup_checkbox";
            this.signup_checkbox.Size = new System.Drawing.Size(57, 20);
            this.signup_checkbox.TabIndex = 7;
            this.signup_checkbox.Text = "Show";
            this.signup_checkbox.UseVisualStyleBackColor = true;
            this.signup_checkbox.CheckedChanged += new System.EventHandler(this.signup_checkbox_CheckedChanged);
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.signup_button.FlatAppearance.BorderSize = 0;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.ForeColor = System.Drawing.Color.White;
            this.signup_button.Location = new System.Drawing.Point(27, 289);
            this.signup_button.Margin = new System.Windows.Forms.Padding(0);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(150, 27);
            this.signup_button.TabIndex = 6;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // signup_email
            // 
            this.signup_email.BackColor = System.Drawing.Color.White;
            this.signup_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_email.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.Location = new System.Drawing.Point(27, 192);
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(150, 21);
            this.signup_email.TabIndex = 5;
            this.signup_email.TextChanged += new System.EventHandler(this.signup_email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // signup_password
            // 
            this.signup_password.BackColor = System.Drawing.Color.White;
            this.signup_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_password.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(27, 128);
            this.signup_password.Name = "signup_password";
            this.signup_password.Size = new System.Drawing.Size(150, 21);
            this.signup_password.TabIndex = 3;
            this.signup_password.UseSystemPasswordChar = true;
            this.signup_password.TextChanged += new System.EventHandler(this.signup_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // signup_username
            // 
            this.signup_username.BackColor = System.Drawing.Color.White;
            this.signup_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_username.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(27, 64);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(150, 21);
            this.signup_username.TabIndex = 1;
            this.signup_username.TextChanged += new System.EventHandler(this.signup_username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // copyright
            // 
            this.copyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.Location = new System.Drawing.Point(473, 616);
            this.copyright.Margin = new System.Windows.Forms.Padding(0);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(70, 16);
            this.copyright.TabIndex = 8;
            this.copyright.Text = "© Horfiwyn";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(348, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "© HORFIWYN 2018";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.login_result);
            this.panel1.Controls.Add(this.login_password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.login_checkbox);
            this.panel1.Location = new System.Drawing.Point(49, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 135);
            this.panel1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(159, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Login";
            // 
            // login_result
            // 
            this.login_result.AutoSize = true;
            this.login_result.BackColor = System.Drawing.Color.Transparent;
            this.login_result.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_result.ForeColor = System.Drawing.Color.Black;
            this.login_result.Location = new System.Drawing.Point(28, 107);
            this.login_result.Name = "login_result";
            this.login_result.Size = new System.Drawing.Size(39, 16);
            this.login_result.TabIndex = 16;
            this.login_result.Text = "Result";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.selected_country);
            this.panel2.Controls.Add(this.country_list);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.signup_label_email);
            this.panel2.Controls.Add(this.signup_username);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.signup_label_password);
            this.panel2.Controls.Add(this.signup_password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.signup_label_username);
            this.panel2.Controls.Add(this.signup_email);
            this.panel2.Controls.Add(this.signup_button);
            this.panel2.Controls.Add(this.signup_checkbox);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(49, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 329);
            this.panel2.TabIndex = 18;
            // 
            // selected_country
            // 
            this.selected_country.AutoSize = true;
            this.selected_country.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_country.Location = new System.Drawing.Point(28, 268);
            this.selected_country.Name = "selected_country";
            this.selected_country.Size = new System.Drawing.Size(39, 16);
            this.selected_country.TabIndex = 23;
            this.selected_country.Text = "Result";
            // 
            // country_list
            // 
            this.country_list.BackColor = System.Drawing.Color.White;
            this.country_list.FormattingEnabled = true;
            this.country_list.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cabo Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (see Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland (See Eswatini)",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.country_list.Location = new System.Drawing.Point(27, 241);
            this.country_list.Name = "country_list";
            this.country_list.Size = new System.Drawing.Size(150, 24);
            this.country_list.TabIndex = 22;
            this.country_list.Text = "Select your country..";
            this.country_list.SelectedIndexChanged += new System.EventHandler(this.country_list_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sign Up, It\'s Free!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 627);
            this.panel4.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(119, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 78);
            this.label13.TabIndex = 24;
            this.label13.Text = "Horfiwyn";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(44, 484);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(155, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(327, 56);
            this.label12.TabIndex = 2;
            this.label12.Text = "Join our community now \r\n             to start negotiating!\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(154, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(328, 56);
            this.label11.TabIndex = 1;
            this.label11.Text = "Post as many ads as \r\n               you would like to! ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(167, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 56);
            this.label7.TabIndex = 0;
            this.label7.Text = "Buy, sell or exchange \r\n               console games.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(535, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 602);
            this.panel3.TabIndex = 21;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.copyright);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 641);
            this.MinimumSize = new System.Drawing.Size(1016, 641);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horfiwyn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox login_checkbox;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label signup_label_email;
        private System.Windows.Forms.Label signup_label_password;
        private System.Windows.Forms.Label signup_label_username;
        private System.Windows.Forms.CheckBox signup_checkbox;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox country_list;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label selected_country;
        private System.Windows.Forms.Label login_result;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
    }
}

