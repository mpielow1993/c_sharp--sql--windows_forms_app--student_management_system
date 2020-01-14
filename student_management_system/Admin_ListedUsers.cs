using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin_ListedUsers : Form
    {
        /*Please see the 'Students' class for more detailed commentary on code. The methodologies for this and said Students class are very similar.*/

        //CONNECTION STRING
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSStudentMSDatabase.mdf;Integrated Security=True";

        #region CONSTRUCTOR

        public Admin_ListedUsers(string adminNameValue, string userNameValue)
        {
            #region
            InitializeComponent();
            Admin_ListedUsers_LoginDetails_LoggedInAs_TextBox.Text = adminNameValue;
            Admin_ListedUsers_LoginDetails_UserLevel_TextBox.Text = userNameValue;
            #endregion
        }

        #endregion

        #region METHODS

        public void Delete_Admin_ListedUser()
        {
            #region
            try
            {
                string sqlQuery1 = $"INSERT INTO dbo.DatabaseHistory" +
                                   $" VALUES('ListedUser Record with EmployeeID = {Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text} was DELETED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

                string sqlQuery2 = $"DELETE FROM dbo.LoginDetails WHERE Username = @Username;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);
                    cmd1.Parameters.AddWithValue("@EmployeeID", Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text);
                    cmd1.Parameters.AddWithValue("@Username", Admin_ListedUsers_LoginDetails_LoggedInAs_TextBox.Text);

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@Username", Admin_ListedUsers_ListedUsersDetails_Username_TextBox.Text);


                    DialogResult dialog = MessageBox.Show("Are you sure you want to delete this Listed User?:" +
                                        $"\n\nStudentID:\t{Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text}" +
                                        $"\nUsername:\t{Admin_ListedUsers_ListedUsersDetails_Username_TextBox.Text}" +
                                        $"\nFirst Name:\t{Admin_ListedUsers_ListedUsersDetails_Surname_TextBox.Text}" +
                                        $"\nSurname:\t{Admin_ListedUsers_ListedUsersDetails_FirstName_TextBox.Text}" +
                                        $"\nEmail:\t\t{Admin_ListedUsers_ListedUsersDetails_Email_TextBox.Text}" +
                                        $"\nPhoneNo:\t{Admin_ListedUsers_ListedUsersDetails_PhoneNo_TextBox.Text}",
                                        "Delete Record", MessageBoxButtons.YesNo
                                        );
                    if (dialog == DialogResult.Yes)
                    {
                        int a = cmd1.ExecuteNonQuery();

                        if (a > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully", "Successful Delete", MessageBoxButtons.OK);

                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Record Deletion Failed. Please try again", "Failed Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Admin_ListedUsers lup = new Admin_ListedUsers(Admin_ListedUsers_LoginDetails_LoggedInAs_TextBox.Text, Admin_ListedUsers_LoginDetails_UserLevel_TextBox.Text);
                        this.Hide();
                        lup.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        public void Edit_Admin_ListedUser()
        {
            #region
            try
            {
                string sqlQuery1 = $"INSERT INTO dbo.DatabaseHistory" +
                                   $" VALUES ('Listed User Record with EmployeeID = {Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text} was UPDATED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

                string sqlQuery2 = "UPDATE dbo.ListedUsers" +
                                   " SET Email = @Email," +
                                   " PhoneNo = @PhoneNo," +
                                   " Department = @Department" +
                                   " WHERE EmployeeID = @EmployeeID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);
                    cmd1.Parameters.AddWithValue("@EmployeeID", Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text);
                    cmd1.Parameters.AddWithValue("@Username", Admin_ListedUsers_LoginDetails_LoggedInAs_TextBox.Text);

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@EmployeeID", Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@Email", Admin_ListedUsers_ListedUsersDetails_Email_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@PhoneNo", Admin_ListedUsers_ListedUsersDetails_PhoneNo_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@Department", Admin_ListedUsers_ListedUsersDetails_Department_Dropdown.Text);


                    DialogResult dialog = MessageBox.Show($"Are you sure you want to make the following changes to this Employee record with EmployeeID = {Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text}?:" +
                                        $"\n\nEmail:\t\t{Admin_ListedUsers_ListedUsersDetails_Email_TextBox.Text}" +
                                        $"\nPhoneNo:\t{Admin_ListedUsers_ListedUsersDetails_PhoneNo_TextBox.Text}" +
                                        $"\nDepartment\t{Admin_ListedUsers_ListedUsersDetails_Department_Dropdown.Text}",
                                        "Update Record", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        int a = cmd1.ExecuteNonQuery();

                        if (a > 0)
                        {
                            MessageBox.Show("Record Updated Successfully", "Successful Update", MessageBoxButtons.OK);
                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Record Update Failed", "Failed Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Admin_ListedUsers a_lu = new Admin_ListedUsers(Admin_ListedUsers_LoginDetails_LoggedInAs_TextBox.Text, Admin_ListedUsers_LoginDetails_UserLevel_TextBox.Text);
                        this.Hide();
                        a_lu.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        public void Admin_ListedUsers_EditMode()
        {
            #region
            this.Admin_ListedUsers_ListedUsersDetails_Email_TextBox.ReadOnly = false;
            this.Admin_ListedUsers_ListedUsersDetails_PhoneNo_TextBox.ReadOnly = false;
            this.Admin_ListedUsers_ListedUsersDetails_Department_TextBox.Visible = false;
            this.Admin_ListedUsers_ListedUsersDetails_Department_Dropdown.Visible = true;
            this.Admin_ListedUsers_ListedUsersDetails_CompleteEdit_Button.Visible = true;
            this.Admin_ListedUsers_ListedUsersDetails_ExitEditMode_Button.Visible = true;
            #endregion
        }

        public void Admin_ListedUsers_ExitEditMode()
        {
            #region
            this.Admin_ListedUsers_ListedUsersDetails_Email_TextBox.ReadOnly = true;
            this.Admin_ListedUsers_ListedUsersDetails_PhoneNo_TextBox.ReadOnly = true;
            this.Admin_ListedUsers_ListedUsersDetails_Department_TextBox.Visible = true;
            this.Admin_ListedUsers_ListedUsersDetails_Department_Dropdown.Visible = false;
            this.Admin_ListedUsers_ListedUsersDetails_CompleteEdit_Button.Visible = false;
            this.Admin_ListedUsers_ListedUsersDetails_ExitEditMode_Button.Visible = false;
            #endregion
        }

        public void Load_Admin_ListedUsers_DataGridView(string sqlQuery)
        {
            #region
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Admin_ListedUsers_DataGridView.DataSource = dt;
            }
            #endregion
        }

        public void Search_Admin_ListedUsers_DataGridView(string valueToSearch)
        {
            #region
            string sqlQuery = $"SELECT * FROM dbo.ListedUsers" +
                              $" WHERE CONCAT(EmployeeID, Username, FirstName, Surname, Email, PhoneNo, Department)" +
                              $" LIKE '%{valueToSearch}%'";
            Load_Admin_ListedUsers_DataGridView(sqlQuery);
            #endregion
        }

        public void Load_LoginScreen()
        {
            #region
            LoginScreen ls = new LoginScreen();
            this.Hide();
            ls.ShowDialog();
            #endregion
        }

        public void Load_New_ListedUser()
        {
            #region
            New_ListedUser n_ls = new New_ListedUser(Admin_ListedUsers_LoginDetails_LoggedInAs_TextBox.Text, Admin_ListedUsers_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            n_ls.ShowDialog();
            #endregion
        }

        public void Load_Admin_Students()
        {
            #region
            Admin_Students a_s = new Admin_Students(Admin_ListedUsers_LoginDetails_LoggedInAs_TextBox.Text, Admin_ListedUsers_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            a_s.ShowDialog();
            #endregion
        }
        #endregion

        #region EVENTS

        private void Admin_ListedUsers_Load(object sender, EventArgs e)
        {
            #region
            string sqlQuery = "SELECT * FROM dbo.ListedUsers";
            Load_Admin_ListedUsers_DataGridView(sqlQuery);
            Admin_ListedUsers_DataGridView.Select();
            #endregion
        }

        #endregion

        #region EVENT HANDLERS

        private void Admin_ListedUsers_Logout_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_LoginScreen();
            #endregion
        }

        private void Admin_ListedUsers_Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Application.Exit();
            #endregion
        }

        private void Admin_ListedUsers_New_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_New_ListedUser();
            #endregion
        }

        private void Admin_ListedUsers_Edit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Admin_ListedUsers_EditMode();
            #endregion
        }

        private void Admin_ListedUsers_ListedUsersDetails_CompleteEdit_Button_Click(object sender, EventArgs e)
        {
            #region
            Edit_Admin_ListedUser();
            #endregion
        }

        private void Admin_ListedUsers_Delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Delete_Admin_ListedUser();
            #endregion
        }

        private void Admin_ListedUsers_ExitEditMode_Button_Click_1(object sender, EventArgs e)
        {
            #region
            Admin_ListedUsers_ExitEditMode();
            #endregion
        }

        private void Admin_ListedUsers_MainMenu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_Admin_Students();
            #endregion
        }

        private void Admin_ListedUsers_Search_Button_Click(object sender, EventArgs e)
        {
            #region
            Search_Admin_ListedUsers_DataGridView(Admin_ListedUsers_Search_TextBox.Text);
            #endregion
        }

        private void Admin_ListedUsers_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Admin_ListedUsers_DataGridView.Rows[e.RowIndex];

                //Set all text boxes from ListedUsersPage to the appropriate value, according to the row the user clicks on 

                Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text = row.Cells[0].Value.ToString();
                Admin_ListedUsers_ListedUsersDetails_Username_TextBox.Text = row.Cells[1].Value.ToString();
                Admin_ListedUsers_ListedUsersDetails_Surname_TextBox.Text = row.Cells[2].Value.ToString();
                Admin_ListedUsers_ListedUsersDetails_FirstName_TextBox.Text = row.Cells[3].Value.ToString();
                Admin_ListedUsers_ListedUsersDetails_Email_TextBox.Text = row.Cells[4].Value.ToString();
                Admin_ListedUsers_ListedUsersDetails_PhoneNo_TextBox.Text = row.Cells[5].Value.ToString();
                Admin_ListedUsers_ListedUsersDetails_Department_TextBox.Text = row.Cells[6].Value.ToString();

            }
            #endregion
        }

        private void Admin_ListedUsers_DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            #region
            DataGridViewRow row = this.Admin_ListedUsers_DataGridView.Rows[e.RowIndex];

            //Set all text boxes from ListedUsersPage to the appropriate value, according to the row the user clicks on 

            Admin_ListedUsers_ListedUsersDetails_EmployeeID_TextBox.Text = row.Cells[0].Value.ToString();
            Admin_ListedUsers_ListedUsersDetails_Username_TextBox.Text = row.Cells[1].Value.ToString();
            Admin_ListedUsers_ListedUsersDetails_Surname_TextBox.Text = row.Cells[2].Value.ToString();
            Admin_ListedUsers_ListedUsersDetails_FirstName_TextBox.Text = row.Cells[3].Value.ToString();
            Admin_ListedUsers_ListedUsersDetails_Email_TextBox.Text = row.Cells[4].Value.ToString();
            Admin_ListedUsers_ListedUsersDetails_PhoneNo_TextBox.Text = row.Cells[5].Value.ToString();
            Admin_ListedUsers_ListedUsersDetails_Department_TextBox.Text = row.Cells[6].Value.ToString();
            Admin_ListedUsers_ListedUsersDetails_Department_Dropdown.Text = row.Cells[6].Value.ToString();

            #endregion
        }

        private void Admin_ListedUsers_Search_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            #region
            if (e.KeyCode == Keys.Enter)
            {
                Search_Admin_ListedUsers_DataGridView(Admin_ListedUsers_Search_TextBox.Text);
            }
            #endregion
        }

        #endregion
    }
}
