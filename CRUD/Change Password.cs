using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class ChangePassword : Form
    {
        
        private readonly string _connectionString =
            "server=localhost;user=root;database=lms;port=3306;password=Shekar@2901";
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            tbForgotMail.ReadOnly = true; 
            tbForgotMail.Text = Login.LoginMail;
            lbPass.Visible = false;

        }

        private void UpdatePassword()
        {
            var connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();
                var sql = $"UPDATE `lms`.`lmsusers` SET `Password` = '{tbPassLogin.Text}' WHERE (`Usermail` = '{tbForgotMail.Text}')";
                var cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        private void tbChangePassword_Click(object sender, EventArgs e)
        {
            var registerForm = new Registration();
            if (!string.IsNullOrEmpty(registerForm.PasswordValidate(tbPassLogin.Text)))
            {
                UpdatePassword();
                MessageBox.Show(@"Password Updated successfully");
                this.Hide();
                var login = new Login();
                login.Show();
            }else if (string.IsNullOrEmpty(tbPassLogin.Text))
            {
                MessageBox.Show(@"Password field cannot be empty");
            }
            else
            {
                lbPass.Visible = true;
                lbPass.ForeColor = Color.Red;
                errorProvider1.SetError(tbPassLogin, "valid password is required");
                errorProvider2.SetError(tbPassLogin, "");
                
            }
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }

        private void tbPassLogin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassLogin.Text))
            {
                lbPass.Visible = false;
                errorProvider1.SetError(tbPassLogin,"");
            }
        }
    }
}