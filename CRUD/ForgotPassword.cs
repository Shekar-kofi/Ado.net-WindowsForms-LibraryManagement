using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class ForgotPassword : Form
    {
        
        private readonly string _connectionString =
            "server=localhost;user=root;database=lms;port=3306;password=Shekar@2901";
        public ForgotPassword()
        {
            InitializeComponent();
            
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            tbForgotMail.ReadOnly = true;
            tbForgotMail.Text = Login.LoginMail;
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }
        
       


        
    }
}