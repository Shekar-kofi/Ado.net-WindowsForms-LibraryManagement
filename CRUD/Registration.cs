using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Registration : Form
    {
        private readonly string _connectionString =
            "server=localhost;user=root;database=lms;port=3306;password=Shekar@2901";

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            lbMail.Visible = false;
            lbPass.Visible = false;
            lbPasswordMatch.Visible = false;
            lbUserCheck.Visible = false;
            
        }

        private string UserCheck()
        {
            try
            {
                var connection = new MySqlConnection(_connectionString);
                connection.Open();
                string userCheck = $"select exists(select * from lmsusers where usermail='{tbMail.Text}')";
                var cmd1 = new MySqlCommand(userCheck, connection);
                object userResult = cmd1.ExecuteScalar();
                var myresult = Convert.ToInt32(userResult);
                if (myresult==0)
                {
                    return "success";
                }
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return null;
        }


        private string EmailMatch()
        {
            var emailPattern = @"^([a-zA-Z\d\.-]+)@([a-zA-Z]+)\.([a-zA-Z]{2,5})(\.[a-zA-Z]{2,5})?$";
            var emailMatch = Regex.Match(tbMail.Text, emailPattern);
            if (emailMatch.Success)
            {
                return "Passed";
            }

            return null;

        }

        public string PasswordValidate(string userPassword )
        {
            var passwordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@!$-&_])[a-zA-Z0-9@!$-&_]{8,15}$";
            var passwordMatch = Regex.Match(userPassword, passwordPattern);
            if (passwordMatch.Success)
            {
                return "passed";
            }

            return null;
        }


        private void tbMail_TextChanged(object sender, EventArgs e)
        { 
            try
            {
                if ( !string.IsNullOrEmpty(EmailMatch()) && !string.IsNullOrEmpty(UserCheck()))
                {
                    errorProvider2.SetError(tbMail, "correct");
                    errorProvider1.SetError(tbMail, "");
                    lbMail.Visible = false;
                    lbUserCheck.Visible = false;

                }else if (!string.IsNullOrEmpty(EmailMatch()) && string.IsNullOrEmpty(UserCheck()))
                {
                    lbUserCheck.ForeColor = Color.Red;
                    lbUserCheck.Visible = true;
                    errorProvider1.SetError(tbMail, "Email already registered");
                    errorProvider2.SetError(tbMail, "");
                }
                else
                {
                    lbMail.Visible = true;
                    lbMail.ForeColor = Color.Red;
                    errorProvider1.SetError(tbMail, "valid email is required");
                    errorProvider2.SetError(tbMail, "");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordValidate(tbPassword.Text)))
            {
                errorProvider1.SetError(tbPassword, "");
                errorProvider2.SetError(tbPassword, "correct");
                lbPass.Visible = false; 
            }
            else
            {
                lbPass.Visible = true;
                lbPass.ForeColor = Color.Red;
                errorProvider1.SetError(tbPassword, "valid password is required");
                errorProvider2.SetError(tbPassword, "");
            }
        }


        private void tbconfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbconfirmPass.Text && 
                !string.IsNullOrEmpty(tbPassword.Text) && 
                !string.IsNullOrEmpty(tbconfirmPass.Text))
            {
                lbPasswordMatch.Visible = false;
                errorProvider1.SetError(tbconfirmPass, "");
                errorProvider2.SetError(tbconfirmPass, "correct");
                
            }
            else
            {
                lbPasswordMatch.Visible = true;
                lbPasswordMatch.ForeColor = Color.Red;
                errorProvider1.SetError(tbconfirmPass, "password match is required");
                errorProvider2.SetError(tbconfirmPass, "");
                
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var connection = new MySqlConnection(_connectionString);
            try
            { 
                if (!string.IsNullOrEmpty(EmailMatch()) 
                  && !string.IsNullOrEmpty(PasswordValidate(tbPassword.Text))
                  && (tbPassword.Text == tbconfirmPass.Text))
                {
                    connection.Open();
                    
                    if (!string.IsNullOrEmpty(UserCheck()))
                    {
                        var sql =
                            $"INSERT INTO `lms`.`lmsusers` (`Usermail`, `Password`) VALUES ('{tbMail.Text}', '{tbPassword.Text}')";
                        var cmd = new MySqlCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(@"User Registered successfully");
                        this.Hide();
                        var login = new Login();
                        login.Show();
                    }
                    else
                    {
                        lbUserCheck.Visible = true;
                        lbMail.Visible = false;
                        lbUserCheck.ForeColor=Color.Red;
                        // tbMail.Text = "";
                        tbPassword.Text = "";
                        tbconfirmPass.Text = "";
                    }
                    
                    connection.Close();
                }
                else
                {
                    tbMail_TextChanged(sender, e);
                    tbPassword_TextChanged(sender, e);
                    tbMail.Text = "";
                    // tbconfirmPass_TextChanged(sender, e);
                }
                
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }


}