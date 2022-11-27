using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International
{
    public partial class Login : Form
    {
        SQL_CONNECTION mysql = new SQL_CONNECTION();
        MySqlConnection connection;

        public Login()
        {
            InitializeComponent();
            txt_username.Focus();
        }

        public void ShowWindow()
        {
            this.Show();
        }
        
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            bool is_Correct = false;
            try
            {
                connection = new MySqlConnection(mysql.ConnectionString.ToString());
                MySqlCommand cmd_login = new MySqlCommand("select * from student.logins;", connection);
                MySqlDataReader comboReader;

                connection.Open();

                comboReader = cmd_login.ExecuteReader();
                while (comboReader.Read())
                {
                    if (txt_username.Text == comboReader.GetString("username") && txt_password.Text == comboReader.GetString("password"))
                    {
                        is_Correct = true;
                    }
                    
                }
                connection.Close();

                if (is_Correct)
                {
                    Student_Registration bf = new Student_Registration();
                    bf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials, please check Username and Password", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show(mysql.ERRORconnection);
            }
            finally
            {
                connection.Close();
            }

        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure, Do you realy want to Exit...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
