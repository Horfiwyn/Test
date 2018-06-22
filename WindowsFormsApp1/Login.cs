using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SortedSet<string> Usernames;
            SortedSet<string> Emails;
            SortedSet<Account> Accounts;
            string[] ForbiddenCharacters;
            string UsernameLogged;
            int AntiBruteForce;
            int Tick;
            Function.ReadAccounts();
            signup_label_email.Text = "";
            signup_label_password.Text = "";
            signup_label_username.Text = "";
            login_result.Text = "";
            selected_country.Text = "";
        }

        //General Static Variables
        public static SortedSet<string> Usernames = new SortedSet<string>();
        public static SortedSet<string> Emails = new SortedSet<string>();
        public static string[] ForbiddenCharacters = { "`", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "=", "+", "{", "[","}", "]", "|", @"\", ":", ";", "'", "<", ">", ".", "?", "/" };
        public static string UsernameLogged = "";
        public static string Path_Accounts = @"Settings\Accounts\";
        public static string Path_Settings = @"Settings\Accounts_Data\";

        //General non-Static Variables
        int AntiBruteForce = 0;
        int Tick = 180;

        //WindowsFormState
        private void minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Login
        private void timer1_Tick(object sender, EventArgs e)
        {
            login_result.Text = "Please try again in " + (Tick > 60 ? Tick / 60 + " minutes and " + (Tick > 120 ? (Tick - 120) + " seconds.":
                (Tick-60) + " seconds."): Tick + " seconds.");
            Tick -= 1;
            if (Tick == 0)
            {
                timer1.Stop();
                AntiBruteForce = 0;
                Tick = 0;
                login_result.Text = "";
                login_button.Enabled = true;
            }
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            AntiBruteForce++;
            if(AntiBruteForce>5)
            {
                timer1.Interval = 1000;
                timer1.Start();
                login_button.Enabled = false;
                login_result.Text = "You've attemped to Login more than 5 times.";
                login_result.ForeColor = Color.Red;
            }
            else if (Usernames.Contains(login_username.Text))
            {
                StreamReader sr = new StreamReader(Path_Accounts + login_username.Text + ".txt");
                string[] Identifiers = sr.ReadLine().Split(' ');
                if (login_password.Text == Identifiers[1])
                {
                    UsernameLogged = login_username.Text;
                    login_username.Text = "";
                    login_password.Text = "";
                    login_checkbox.Checked = false;
                    login_password.UseSystemPasswordChar = true;
                    login_checkbox.Text = "Show";
                    Home Home = new Home();
                    Hide();
                    Home.Show();
                }                
                else
                {
                    login_result.Text = "Password incorrect.";
                    login_result.ForeColor = Color.Red;
                }
            }
            else
            {
                login_result.Text = "Username or password incorrect.";
                login_result.ForeColor = Color.Red;
            }
        }
        private void login_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (login_checkbox.Checked == true)
            {
                login_password.UseSystemPasswordChar = false;
                login_checkbox.Text = "Hide";
            }
            else
            {
                login_password.UseSystemPasswordChar = true;
                login_checkbox.Text = "Show";
            }
        }
        
        //SignUp
        private void signup_password_TextChanged(object sender, EventArgs e)
        {
            Function.CheckPassword(signup_password, signup_label_password);
        }
        private void signup_username_TextChanged(object sender, EventArgs e)
        {
            Function.CheckUsername(signup_username, signup_label_username);
        }
        private void signup_email_TextChanged(object sender, EventArgs e)
        {
            Function.CheckEmail(signup_email,signup_label_email);
        }
        private void signup_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_checkbox.Checked == true)
            {
                signup_password.UseSystemPasswordChar = false;
                signup_checkbox.Text = "Hide";
            }
            else
            {
                signup_password.UseSystemPasswordChar = true;
                signup_checkbox.Text = "Show";
            }
        }
        private void signup_button_Click(object sender, EventArgs e)
        {
            if ((Function.CheckUsername(signup_username, signup_label_username)
                && Function.CheckEmail(signup_email, signup_label_email))
                && Function.CheckPassword(signup_password, signup_label_password) && !(country_list.SelectedItem == null))
            {
                Function.CreateAccount(signup_username,signup_password,signup_email,country_list);
                MessageBox.Show("Your account has successfully been created!","Congratulations!");
                signup_username.Text = "";
                signup_password.Text = "";
                signup_email.Text = "";
                signup_label_username.Text = "";
                signup_label_password.Text = "";
                signup_label_email.Text = "";
                country_list.Text = "";
                signup_checkbox.Checked = false;
                signup_checkbox.Text = "Show";
                signup_password.UseSystemPasswordChar = true;
            }
            else
            {
                if(country_list.SelectedItem == null)
                {
                    selected_country.Text = "Please select a country.";
                    selected_country.ForeColor = Color.Red;
                }
                if(Function.CheckUsername(signup_username, signup_label_username) == false)
                {
                    signup_label_username.Text = "Please enter a valid username.";
                    signup_label_username.ForeColor = Color.Red;
                }
                if (Function.CheckEmail(signup_email, signup_label_email) == false)
                {
                    signup_label_email.Text = "Please enter a valid email.";
                    signup_label_email.ForeColor = Color.Red;
                }
                if (Function.CheckPassword(signup_password, signup_label_password) == false)
                {
                    signup_label_password.Text = "Please enter a valid password.";
                    signup_label_password.ForeColor = Color.Red;
                }
            }
        }
        private void country_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (country_list.SelectedItem != null)
                selected_country.Text = "";
        }
    }
}
