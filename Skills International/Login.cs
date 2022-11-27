
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Skills_International
{
    public partial class Login : Form
    {
        SQL_CONNECTION sql = new SQL_CONNECTION();
        SqlConnection connection;

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
                connection = new SqlConnection(sql.ConnectionString.ToString());
                connection.Open();
                SqlCommand cmd_login = new SqlCommand("select * from logins;", connection);
                SqlDataReader comboReader = cmd_login.ExecuteReader(); ;

                while (comboReader.Read())
                {
                    if (txt_username.Text == comboReader.GetString(0) && txt_password.Text == comboReader.GetString(1))
                    {
                        is_Correct = true;
                    }
                    
                }

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
