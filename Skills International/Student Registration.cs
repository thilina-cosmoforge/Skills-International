using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Skills_International
{
    public partial class Student_Registration : Form
    {
        SQL_CONNECTION mysql = new SQL_CONNECTION();
        MySqlConnection connection;
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
                connection = new MySqlConnection(mysql.ConnectionString.ToString());
                MySqlCommand cmd_login = new MySqlCommand("select * from student.registration;", connection);
                MySqlDataReader comboReader;

                connection.Open();

                comboReader = cmd_login.ExecuteReader();
                while (comboReader.Read())
                {
                    RegNo_combo.Items.Add(comboReader.GetString("regNo"));
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
            connection = new MySqlConnection(mysql.ConnectionString.ToString());
            MySqlCommand cmd_login = new MySqlCommand("select * from student.registration where regNo = '" + RegNo_combo.SelectedItem.ToString() + "';", connection);
            MySqlDataReader comboReader;
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
                    connection = new MySqlConnection(mysql.ConnectionString.ToString());
                    MySqlCommand cmd_Insert =
                        new MySqlCommand("insert into student.registration " +
                        "(regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                        "values(@reg, @fname, @lname, @dob, @gender, @addr, @email, @mobile, @home, @parent, @nic, @contact);", connection);

                    connection.Open();
                    cmd_Insert.Parameters.Add("@reg", MySqlDbType.Int64).Value = RegNo_combo.Text;
                    cmd_Insert.Parameters.Add("@fname", MySqlDbType.VarChar).Value = first_name_txt.Text;
                    cmd_Insert.Parameters.Add("@lname", MySqlDbType.VarChar).Value = last_name_txt.Text;
                    cmd_Insert.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dob_picker.Value;
                    cmd_Insert.Parameters.Add("@gender", MySqlDbType.String).Value = getGender();
                    cmd_Insert.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address_text.Text;
                    cmd_Insert.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_txt.Text;
                    cmd_Insert.Parameters.Add("@mobile", MySqlDbType.Int64).Value = mobile_txt.Text;
                    cmd_Insert.Parameters.Add("@home", MySqlDbType.Int64).Value = tele_txt.Text;
                    cmd_Insert.Parameters.Add("@parent", MySqlDbType.VarChar).Value = parent_name_txt.Text;
                    cmd_Insert.Parameters.Add("@nic", MySqlDbType.VarChar).Value = nic_txt.Text;
                    cmd_Insert.Parameters.Add("@contact", MySqlDbType.Int64).Value = contact_no_txt.Text;

                    cmd_Insert.ExecuteNonQuery();

                    MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(mysql.ERRORconnection, ex.Source);                    
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
                connection = new MySqlConnection(mysql.ConnectionString.ToString());
                MySqlCommand cmd_update = new MySqlCommand("update student.registration set " +
                    "firstName=@fname, lastName=@lname, dateOfBirth=@dob, gender=@gender, address=@addr, email=@email, mobilePhone=@mobile, homePhone=@home, parentName=@parent, nic=@nic, contactNo=@contact " +
                    "where regNo = '" + RegNo_combo.SelectedItem.ToString() + "';", connection);
                connection.Open();

                cmd_update.Parameters.Add("@fname", MySqlDbType.VarChar).Value = first_name_txt.Text;
                cmd_update.Parameters.Add("@lname", MySqlDbType.VarChar).Value = last_name_txt.Text;
                cmd_update.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dob_picker.Value;
                cmd_update.Parameters.Add("@gender", MySqlDbType.String).Value = getGender();
                cmd_update.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address_text.Text;
                cmd_update.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_txt.Text;
                cmd_update.Parameters.Add("@mobile", MySqlDbType.Int64).Value = mobile_txt.Text;
                cmd_update.Parameters.Add("@home", MySqlDbType.Int64).Value = tele_txt.Text;
                cmd_update.Parameters.Add("@parent", MySqlDbType.VarChar).Value = parent_name_txt.Text;
                cmd_update.Parameters.Add("@nic", MySqlDbType.VarChar).Value = nic_txt.Text;
                cmd_update.Parameters.Add("@contact", MySqlDbType.Int64).Value = contact_no_txt.Text;

                cmd_update.ExecuteNonQuery();

                MessageBox.Show("Record Updated Succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(mysql.ERRORconnection, ex.Message);
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
                connection = new MySqlConnection(mysql.ConnectionString.ToString());
                MySqlCommand cmd_delete = new MySqlCommand("delete from student.registration where regNo = '" + RegNo_combo.SelectedItem.ToString() + "';", connection);
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
                MessageBox.Show(mysql.ERRORconnection, ex.Message);
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
                connection = new MySqlConnection(mysql.ConnectionString.ToString());
                MySqlCommand cmd_login = new MySqlCommand("select * from student.registration where regNo = '" + RegNo_combo.SelectedItem + "';", connection);
                MySqlDataReader comboReader;

                connection.Open();

                comboReader = cmd_login.ExecuteReader();
                while (comboReader.Read())
                {
                    first_name_txt.Text = comboReader.GetString("firstName");
                    last_name_txt.Text = comboReader.GetString("lastName");
                    dob_picker.Value = comboReader.GetDateTime("dateOfBirth");
                    setGender(comboReader.GetString("gender"));
                    address_text.Text = comboReader.GetString("address");
                    email_txt.Text = comboReader.GetString("email");
                    mobile_txt.Text = comboReader.GetString("mobilePhone");
                    tele_txt.Text = comboReader.GetString("homePhone");
                    parent_name_txt.Text = comboReader.GetString("parentName");
                    nic_txt.Text = comboReader.GetString("nic");
                    contact_no_txt.Text = comboReader.GetString("contactNo");

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
