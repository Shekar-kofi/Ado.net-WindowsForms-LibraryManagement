using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString =
            "server=localhost;user=root;database=lms;port=3306;password=Shekar@2901";

        private MySqlDataAdapter _daLms;
        private DataSet _dsLms;

        public Form1()
        {
            InitializeComponent();
        }


        private void ShowData()
        {
            try
            {
                var myconnection = new MySqlConnection(_connectionString);
                var sql = "SELECT * FROM lms.book";
                _daLms = new MySqlDataAdapter(sql, myconnection);
                _dsLms = new DataSet();
                _daLms.Fill(_dsLms, "book");
                dataGridView1.DataSource = _dsLms;
                dataGridView1.DataMember = "book";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
        }

        private void ClearForm()
        {
            tbAuthor.Text = "";
            tbId.Text = "";
            tbTitle.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            cbType.SelectedItem = null;
        }


        private void AddBook()
        {
            try
            {
                var mySqlConnection = new MySqlConnection(_connectionString);
                mySqlConnection.Open();
                var sql =
                    "INSERT INTO `lms`.`book` (`Id`, `Name`, `Author`, `DateRented`, `DateReturn`, `BookType`) " +
                    $"VALUES ('{tbId.Text}', '{tbTitle.Text}', '{tbAuthor.Text}', '{dateTimePicker1.Value:yyyy-MM-dd HH:mm:ss}'," +
                    $" '{dateTimePicker2.Value:yyyy-MM-dd HH:mm:ss}', '{cbType.Text}')";

                var cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrEmpty(tbId.Text) && !string.IsNullOrEmpty(tbAuthor.Text) && 
                    !string.IsNullOrEmpty(tbTitle.Text) && (dateTimePicker1.Value<dateTimePicker2.Value))
                {
                 AddBook();
                 ShowData();
                 ClearForm();
                }
                else if (string.IsNullOrEmpty(tbId.Text) || string.IsNullOrEmpty(tbTitle.Text) || 
                          string.IsNullOrEmpty(tbAuthor.Text) || (dateTimePicker1.Value>dateTimePicker2.Value))
                {
                    if (string.IsNullOrEmpty(tbId.Text))
                    {
                        MessageBox.Show(@"Book Id cannot be empty");
                    }else if (string.IsNullOrEmpty(tbTitle.Text))
                    {
                        MessageBox.Show(@"Book Title cannot be empty");
                    }else if (string.IsNullOrEmpty(tbAuthor.Text))
                    {
                        MessageBox.Show(@"Book Author cannot be empty");
                    }else if ((dateTimePicker1.Value>dateTimePicker2.Value))
                    {
                        MessageBox.Show(@"Invalid date selection");
                    }
                    
                }
                


                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
            tbId.ReadOnly = false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbTitle.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbAuthor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[3].Value;
                dateTimePicker2.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[4].Value;
                cbType.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tbId.ReadOnly = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var myconnection = new MySqlConnection(_connectionString);
                myconnection.Open();
                var sql = "UPDATE `lms`.`book` SET `Id` = @bookId, `Name` = @bookName, `Author` = @bookAuthor," +
                          " `DateRented` = @dateRent, " +
                          "`DateReturn` = @dateReturn, " +
                          "`BookType` = @bookType WHERE (`Id` = @bookId)";

                var cmd = new MySqlCommand(sql, myconnection);
                cmd.Parameters.AddWithValue("@bookId", tbId.Text);
                cmd.Parameters.AddWithValue("@bookName", tbTitle.Text);
                cmd.Parameters.AddWithValue("@bookAuthor", tbAuthor.Text);
                cmd.Parameters.AddWithValue("@dateRent", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@dateReturn", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@bookType", cbType.Text);
                cmd.ExecuteNonQuery();
                myconnection.Close();
                ShowData();
                ClearForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var myconnection = new MySqlConnection(_connectionString);
                myconnection.Open();
                var sql = "DELETE FROM `lms`.`book` WHERE (`Id` = @bookId)";

                var cmd = new MySqlCommand(sql, myconnection);
                cmd.Parameters.AddWithValue("@bookId", tbId.Text);
                cmd.ExecuteNonQuery();
                myconnection.Close();
                ShowData();
                ClearForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult userExit;
            userExit = MessageBox.Show(@"Are you sure want to exit", @"Library Management system",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (userExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            // else
            // {
            //     Hide();
            //     var login = new Login();
            //     login.ShowDialog();
            // }
        }
    }
}