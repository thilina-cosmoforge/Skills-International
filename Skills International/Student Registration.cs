using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Skills_International
{
    public partial class Student_Registration : Form
    {
        SQL_CONNECTION sql = new SQL_CONNECTION();
        SqlConnection connection;
        public Student_Registration()
        {
            InitializeComponent();
            loadStudents();
            register_btn.Enabled = true;
            update_btn.Enabled = false;
        }

        private void loadStudents()
        {
            RegNo_combo.Items.Clear();
            RegNo_combo.ResetText();
            try
            {
                connection = new SqlConnection(sql.ConnectionString.ToString());
                SqlCommand cmd_login = new SqlCommand("select * from registration;", connection);
                SqlDataReader comboReader;

                connection.Open();

                comboReader = cmd_login.ExecuteReader();
                while (comboReader.Read())
                {
                    RegNo_combo.Items.Add(comboReader.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(sql.ERRORconnection, ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private string getGender()
        {
            if (radio_male.Checked)
            {
                return "male";
            }
            else
            {
                return "female";
            }
        }

        private void setGender(String g)
        {
            if (g == "male")
            {
                radio_male.Checked = true;
                radio_female.Checked = false;
            }
            else
            {
                radio_male.Checked = false;
                radio_female.Checked = true;
            }
        }

        private bool exists()
        {
            bool yes = false;
            connection = new SqlConnection(sql.ConnectionString.ToString());
            SqlCommand cmd_login = new SqlCommand("select * from registration where regNo = '" + RegNo_combo.SelectedItem.ToString() + "';", connection);
            SqlDataReader comboReader;
            connection.Open();
            comboReader = cmd_login.ExecuteReader();
            while (comboReader.Read())
            {
                yes = true;
            }
            connection.Close();
            return yes;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if(RegNo_combo.SelectedIndex == -1 || !exists())
            {
                try
                {
                    connection = new SqlConnection(sql.ConnectionString.ToString());
                    SqlCommand cmd_Insert =
                        new SqlCommand("insert into registration " +
                        "(regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                        "values(@reg, @fname, @lname, @dob, @gender, @addr, @email, @mobile, @home, @parent, @nic, @contact);", connection);

                    connection.Open();
                    cmd_Insert.Parameters.AddWithValue("@reg", RegNo_combo.Text);
                    cmd_Insert.Parameters.AddWithValue("@fname", first_name_txt.Text);
                    cmd_Insert.Parameters.AddWithValue("@lname", last_name_txt.Text);
                    cmd_Insert.Parameters.AddWithValue("@dob", dob_picker.Value);
                    cmd_Insert.Parameters.AddWithValue("@gender", getGender());
                    cmd_Insert.Parameters.AddWithValue("@addr", address_text.Text);
                    cmd_Insert.Parameters.AddWithValue("@email", email_txt.Text);
                    cmd_Insert.Parameters.AddWithValue("@mobile", mobile_txt.Text);
                    cmd_Insert.Parameters.AddWithValue("@home", tele_txt.Text);
                    cmd_Insert.Parameters.AddWithValue("@parent", parent_name_txt.Text);
                    cmd_Insert.Parameters.AddWithValue("@nic", nic_txt.Text);
                    cmd_Insert.Parameters.AddWithValue("@contact", contact_no_txt.Text);

                    cmd_Insert.ExecuteNonQuery();

                    MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sql.ERRORconnection, ex.Message);                    
                }
                finally
                {
                    connection.Close();
                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(sql.ConnectionString.ToString());
                SqlCommand cmd_update = new SqlCommand("update registration set " +
                    "firstName=@fname, lastName=@lname, dateOfBirth=@dob, gender=@gender, address=@addr, email=@email, mobilePhone=@mobile, homePhone=@home, parentName=@parent, nic=@nic, contactNo=@contact " +
                    "where regNo = '" + RegNo_combo.SelectedItem.ToString() + "';", connection);
                connection.Open();

                cmd_update.Parameters.AddWithValue("@fname", first_name_txt.Text);
                cmd_update.Parameters.AddWithValue("@lname", last_name_txt.Text);
                cmd_update.Parameters.AddWithValue("@dob", dob_picker.Value);
                cmd_update.Parameters.AddWithValue("@gender", getGender());
                cmd_update.Parameters.AddWithValue("@addr", address_text.Text);
                cmd_update.Parameters.AddWithValue("@email", email_txt.Text);
                cmd_update.Parameters.AddWithValue("@mobile", mobile_txt.Text);
                cmd_update.Parameters.AddWithValue("@home", tele_txt.Text);
                cmd_update.Parameters.AddWithValue("@parent", parent_name_txt.Text);
                cmd_update.Parameters.AddWithValue("@nic", nic_txt.Text);
                cmd_update.Parameters.AddWithValue("@contact", contact_no_txt.Text);

                cmd_update.ExecuteNonQuery();

                MessageBox.Show("Record Updated Succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(sql.ERRORconnection, ex.Message);
            }
            finally
            {
                connection.Close();
                clearFields();
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(sql.ConnectionString.ToString());
                SqlCommand cmd_delete = new SqlCommand("delete from registration where regNo = '" + RegNo_combo.SelectedItem.ToString() + "';", connection);
                connection.Open();
                DialogResult res = MessageBox.Show("Are you sure, Do you realy want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    cmd_delete.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(sql.ERRORconnection, ex.Message);
            }
            finally
            {
                connection.Close();
                loadStudents();
            }
        }

        private void RegNo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            register_btn.Enabled = false;
            update_btn.Enabled = true;
            try
            {
                connection = new SqlConnection(sql.ConnectionString.ToString());
                SqlCommand cmd_login = new SqlCommand("select * from registration where regNo = '" + RegNo_combo.SelectedItem + "';", connection);
                SqlDataReader comboReader;

                connection.Open();

                comboReader = cmd_login.ExecuteReader();
                while (comboReader.Read())
                {
                    first_name_txt.Text = comboReader.GetString(1);
                    last_name_txt.Text = comboReader.GetString(2);
                    dob_picker.Value = comboReader.GetDateTime(3);
                    setGender(comboReader.GetString(4));
                    address_text.Text = comboReader.GetString(5);
                    email_txt.Text = comboReader.GetString(6);
                    mobile_txt.Text = comboReader.GetInt32(7).ToString();
                    tele_txt.Text = comboReader.GetInt32(8).ToString();
                    parent_name_txt.Text = comboReader.GetString(9);
                    nic_txt.Text = comboReader.GetString(10);
                    contact_no_txt.Text = comboReader.GetInt32(11).ToString();

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

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void exit_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure, Do you realy want to Exit...?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void RegNo_combo_KeyDown(object sender, KeyEventArgs e)
        {
            register_btn.Enabled = true;
            update_btn.Enabled = false;
        }

        private void logout_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.ShowWindow();
            this.Close();
        }

        private void clearFields()
        {
            RegNo_combo.SelectedIndex = -1;
            first_name_txt.Clear();
            last_name_txt.Clear();
            dob_picker.Checked = false;
            setGender("male");
            address_text.Clear();
            email_txt.Clear();
            mobile_txt.Clear();
            tele_txt.Clear();
            parent_name_txt.Clear();
            nic_txt.Clear();
            contact_no_txt.Clear();
            RegNo_combo.ResetText();

            register_btn.Enabled = true;
            update_btn.Enabled = false;
        }
    }
}
