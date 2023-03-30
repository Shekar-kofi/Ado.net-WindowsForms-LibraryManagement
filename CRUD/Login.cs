using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySqlConnector;

namespace CRUD
{
    public partial class Login : Form
    { 
        private readonly string _connectionString =
            "server=localhost;user=root;database=lms;port=3306;password=Shekar@2901";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbLoginpass.Visible = false;
            lbInvalid.Visible = false;
            lbNotRegistered.Visible = false;
            btPassHide.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var registration = new Registration();
            registration.ShowDialog();
        }

        private string UserCheck()
        {
            var connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();
                string userCheck = $"select exists(select * from lmsusers where usermail='{tbMailLogin.Text}')";
                var cmd = new MySqlCommand(userCheck, connection);
                object userExist = cmd.ExecuteScalar();
                var userPresent = Convert.ToInt32(userExist);
                if (userPresent==1)
                {
                    return "passed";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return null;

        }
        
        private string EmailMatch()
        {
            var emailPattern = @"^([a-zA-Z\d\.-]+)@([a-zA-Z]+)\.([a-zA-Z]{2,5})(\.[a-zA-Z]{2,5})?$";
            var emailMatch = Regex.Match(tbMailLogin.Text, emailPattern);
            if (emailMatch.Success)
            {
                return "Passed";
            }

            return null;

        }

        private string UserPasswordVerify()
        {
            var connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();
                string passwordverify =
                    $"select count(*) from lmsusers where Usermail='{tbMailLogin.Text}' and binary Password='{tbPassLogin.Text}'";
                var cmd = new MySqlCommand(passwordverify, connection);
                object passwordcheck = cmd.ExecuteScalar();
                var confirmuser = Convert.ToInt32(passwordcheck);
                if (confirmuser==1)
                {
                    return "passed";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return null;

        }


        private void tbMailLogin_TextChanged(object sender, EventArgs e)
        { 
            
            if (!string.IsNullOrEmpty(UserCheck()) && !string.IsNullOrEmpty(EmailMatch())) 
            {
                    errorProvider1.SetError(tbMailLogin,"");
                    errorProvider2.SetError(tbMailLogin,"Email Registered successfully");
                    lbInvalid.Visible = false;
                    lbNotRegistered.Visible = false;
            }else if (string.IsNullOrEmpty(UserCheck()) && !string.IsNullOrEmpty(EmailMatch()))
            {
                lbNotRegistered.Visible = true;
                lbInvalid.Visible = false;
                lbNotRegistered.ForeColor = Color.Red;
            }
            else 
            {
                    lbInvalid.Visible = true;
                    lbNotRegistered.Visible = false;
                    lbInvalid.ForeColor = Color.Red;
                    errorProvider1.SetError(tbMailLogin,"Email does not registered");
                    errorProvider2.SetError(tbMailLogin,""); 
            } 
            
            
        }

        private void tbPassLogin_TextChanged(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(UserPasswordVerify())) 
            {
                    errorProvider1.SetError(tbPassLogin,"");
                    errorProvider2.SetError(tbPassLogin,"Password matched");
                    lbLoginpass.Visible = false; 
            }
            else 
            {
                    lbLoginpass.Visible = true;
                    lbLoginpass.ForeColor = Color.Red;
                    errorProvider1.SetError(tbPassLogin,"password does not match");
                    errorProvider2.SetError(tbPassLogin,""); 
            } 
        }


        private void btLogin_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(UserPasswordVerify()))
            {
                this.Hide();
                MessageBox.Show(@"Login Success");
                var library = new Form1();
                library.Show();
            }
            else
            {
                tbMailLogin_TextChanged(sender, e);
                tbPassLogin_TextChanged(sender, e);
                MessageBox.Show(@"Invalid Email address or Password.Please try again");

            } 
        }

        private void btShowPass_Click(object sender, EventArgs e)
        {
            tbPassLogin.UseSystemPasswordChar = false;
            btShowPass.Hide();
            btPassHide.Show();
        }


        private void btPassHide_Click(object sender, EventArgs e)
        {
            tbPassLogin.UseSystemPasswordChar = true;
            btPassHide.Hide();
            btShowPass.Show();
            
        }


        

        
    }
}