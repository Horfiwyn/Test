using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System;

namespace WindowsFormsApp1
{
    class Function
    {
        //Functions
        public static void CreateAccount(TextBox Username, TextBox Password, TextBox Email, ComboBox Country)
        {
            Login.Emails.Add(Email.Text);
            Login.Usernames.Add(Username.Text);
            if (!File.Exists(Login.Path_Accounts + Username.Text + ".txt"))
            {
                var temp = File.Create(Login.Path_Accounts + Username.Text + ".txt");
                temp.Close();
                StreamWriter s1 = new StreamWriter(Login.Path_Accounts + Username.Text + ".txt");
                s1.Write(Username.Text + " ");
                s1.Write(Password.Text + " ");
                s1.Write(Email.Text + " ");
                s1.Write(Country.Text);
                s1.Close();
            }
            Directory.CreateDirectory(@"Settings\Accounts_Data\" + Username.Text);
            File.Copy(@"Settings\Accounts_Data\Admin\profile_picture.png",
                @"Settings\Accounts_Data\" + Username.Text + @"\profile_picture.png");
        }
        public static void ReadAccounts()
        {
            string[] Path_Account = Directory.GetFiles(Login.Path_Accounts);
            foreach (string dir in Path_Account)
            {
                StreamReader sr = new StreamReader(dir);
                string[] Identifiers = sr.ReadLine().Split(' ');
                Login.Usernames.Add(Identifiers[0]);
                Login.Emails.Add(Identifiers[2]);
            }
        }
        public static bool CheckPassword(TextBox TextBox, Label Label)
        {
            int cnt1 = 0;
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] >= 'A' && TextBox.Text[i] <= 'Z')
                    cnt1++;
            }
            if (cnt1 == 0)
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Password should contain at least one uppercase.";
                return false;
            }
            int cnt2 = 0;
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] >= '0' && TextBox.Text[i] <= '9')
                    cnt2++;
            }
            if (cnt2 == 0)
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Password should contain at least one number.";
                return false;
            }
            if (TextBox.Text.Contains(" "))
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Please, spaces are not allowed.";
                return false;
            }
            if (TextBox.Text.Length < 8 && TextBox.Text.Length >= 0)
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Password should be bigger than 7 characters.";
                return false;
            }
            if (TextBox.Text.Length > 36)
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Password should be lesser than 36 characters.";
                return false;
            }
            Label.Text = "";
            return true;
        }
        public static bool CheckUsername(TextBox TextBox, Label Label)
        {
            foreach (string FC in Login.ForbiddenCharacters)
                if (TextBox.Text.Contains(FC))
                {
                    Label.ForeColor = Color.Red;
                    Label.Text = "You can only use -, _, numbers and letters.";
                    return false;
                }
            if (TextBox.Text.Length < 5 && TextBox.Text.Length >= 0)
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Username should be bigger than 5 characters.";
                return false;
            }
            if (TextBox.Text.Length > 16)
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Username should be lesser than 16 characters.";
                return false;
            }
            if (Login.Usernames.Contains(TextBox.Text))
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Username already token.";
                return false;
            }
            if (TextBox.Text.Contains(" "))
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Please, spaces are not allowed.";
                return false;
            }
            if (TextBox.Text.Length > 4 && TextBox.Text.Length < 16 && !Login.Usernames.Contains(TextBox.Text))
            {
                Label.Text = "";
                return true;
            }
            Label.Text = "";
            return false;
        }
        public static bool CheckEmail(TextBox TextBox, Label Label)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(TextBox.Text);
                Label.Text = "";
                return addr.Address == TextBox.Text && !Login.Emails.Contains(TextBox.Text);
            }
            catch
            {
                if (Login.Emails.Contains(TextBox.Text))
                {
                    Label.Text = "Email already in use.";
                    Label.ForeColor = Color.Red;
                }
                else
                {
                    Label.Text = "Please enter a valid email.";
                    Label.ForeColor = Color.Red;
                }
                return false;
            }
        }
    } 
}
