﻿using System;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using MySqlConnector;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace CRUD
{
    public partial class Login : Form
    { 
        private readonly string _connectionString =
            "server=localhost;user=root;database=lms;port=3306;password=Shekar@2901";

        private static int _loginCount = 0;
        
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
            linkForgot.Visible = false;
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


        private void PasswordRecover()
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Recover password test","shekarchepala119@gmail.com"));
            message.To.Add(MailboxAddress.Parse("shekar.chepala@amzur.com"));
            
            message.Subject = "Password Recover Test";
            message.Body = new TextPart("Plain")
            {
                Text = "hello this is test"
            };

            SmtpClient client = new SmtpClient();
            try
            { 
                client.Connect("smtp.gmail.com",465,true);
                client.Authenticate("shekarchepala119@gmail.com","irtbkizwkcvwisrv");
                client.Send(message); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            client.Disconnect(true);
            client.Dispose();
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
            if (string.IsNullOrEmpty(tbPassLogin.Text))
            {
                lbLoginpass.Visible = false;
                errorProvider1.SetError(tbPassLogin,"");
            }
            
            // if (!string.IsNullOrEmpty(UserPasswordVerify())) 
            // {
            //         errorProvider1.SetError(tbPassLogin,"");
            //         errorProvider2.SetError(tbPassLogin,"Password matched");
            //         lbLoginpass.Visible = false; 
            // }
            // else 
            // {
            //         lbLoginpass.Visible = true;
            //         lbLoginpass.ForeColor = Color.Red;
            //         errorProvider1.SetError(tbPassLogin,"password does not match");
            //         errorProvider2.SetError(tbPassLogin,""); 
            // } 
        }

        
        


            private void btLogin_Click(object sender, EventArgs e) 
            {
                if (!string.IsNullOrEmpty(UserPasswordVerify()))
            {
                this.Hide();
                MessageBox.Show(@"Login Success");
                var library = new Form1();
                library.Show();
            }else if (string.IsNullOrEmpty(tbMailLogin.Text) )
            {
                MessageBox.Show(@"Please enter the email address");
            }else if (string.IsNullOrEmpty(tbPassLogin.Text))
            {
                MessageBox.Show(@"Please enter the Password");
            }
            else
            {
                _loginCount++;
                if (_loginCount>2)
                {
                    linkForgot.Visible = true;
                }
                tbMailLogin_TextChanged(sender, e);
                lbLoginpass.Visible = true;
                lbLoginpass.ForeColor = Color.Red;
                errorProvider1.SetError(tbPassLogin,"password does not match");
                errorProvider2.SetError(tbPassLogin,""); 
                // tbPassLogin_TextChanged(sender, e);
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


        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            
        }
    }
}