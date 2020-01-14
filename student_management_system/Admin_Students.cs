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

namespace WindowsFormsApp1
{
    public partial class Admin_Students : Form
    {
        /*Please see the 'Students' class for more detailed commentary on code. The methodologies for this and said Students class are very similar.*/

        //CONNECTION STRING
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSStudentMSDatabase.mdf;Integrated Security=True";

        #region CONSTRUCTOR
        public Admin_Students(string adminNameValue, string userLevelValue)
        {
            InitializeComponent();
            Admin_LoginDetails_LoggedInAs_TextBox.Text = adminNameValue;
            Admin_LoginDetails_UserLevel_TextBox.Text = userLevelValue;
        }
        #endregion

        #region METHODS

        public void Load_Admin_Students_DataGridView(string sqlQuery)
        {
            #region
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Admin_Students_DataGridView.DataSource = dt;
            }
            #endregion
        }

        public void Delete_Admin_Student()
        {
            #region
            try
            {
                string sqlQuery1 = "DELETE FROM dbo.Students WHERE StudentID = @StudentID";

                string sqlQuery2 = "INSERT INTO dbo.DatabaseHistory" +
                              $" VALUES('Student Record with StudentID = {Admin_StudentDetails_StudentID_TextBox.Text} was DELETED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

                //using statement will release conn when it is finished with it
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //Assign the values of the SqlCommand parameters with their associated TextBox values
                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);
                    cmd1.Parameters.AddWithValue("@StudentID", Admin_StudentDetails_StudentID_TextBox.Text);

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@StudentID", int.Parse(Admin_StudentDetails_StudentID_TextBox.Text));
                    cmd2.Parameters.AddWithValue("@Username", Admin_LoginDetails_LoggedInAs_TextBox.Text);

                    //Load a dialog box that confirms with the user that they wish to complete the specified action
                    DialogResult dialog = MessageBox.Show("Are you sure you want to delete this Student record?:" +
                                        $"\n\nStudentID:\t{Admin_StudentDetails_StudentID_TextBox.Text}" +
                                        $"\nFirst Name:\t{Admin_StudentDetails_FirstName_TextBox.Text}" +
                                        $"\nSurname:\t{Admin_StudentDetails_Surname_TextBox.Text}" +
                                        $"\nEmail:\t\t{Admin_StudentDetails_Email_TextBox.Text}" +
                                        $"\nPhoneNo:\t{Admin_StudentDetails_PhoneNo_TextBox.Text}" +
                                        $"\nAddressLine1\t{Admin_StudentDetails_AddressLine1_TextBox.Text}" +
                                        $"\nAddressLine2:\t{Admin_StudentDetails_AddressLine2_TextBox.Text}" +
                                        $"\nCity:\t\t{Admin_StudentDetails_City_TextBox.Text}" +
                                        $"\nCounty:\t\t{Admin_StudentDetails_County_TextBox.Text}" +
                                        $"\nLevel:\t\t{Admin_StudentDetails_Level_TextBox.Text}" +
                                        $"\nCourse:\t\t{Admin_StudentDetails_Course_TextBox.Text}" +
                                        $"\nCountry:\t\t{Admin_StudentDetails_Country_TextBox.Text}",
                                        "Delete Record", MessageBoxButtons.YesNo
                                        );
                    if (dialog == DialogResult.Yes)
                    {
                        //if the user selects 'Yes', sqlQuery1 is executed by cmd1
                        int a = cmd1.ExecuteNonQuery();

                        if (a > 0)
                        {
                            //if cmd1 executes successfully, sqlQuery2 is executed by cmd2
                            MessageBox.Show("Record Deleted Successfully", "Successful Delete", MessageBoxButtons.OK);
                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Record Deletion Failed. Please try again", "Failed Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Admin_Students admp = new Admin_Students(Admin_LoginDetails_LoggedInAs_TextBox.Text, Admin_LoginDetails_UserLevel_TextBox.Text);
                    this.Hide();
                    admp.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        public void Edit_Admin_Student()
        {
            #region
            try
            {
                string sqlQuery1 = $"INSERT INTO dbo.DatabaseHistory" +
                                   $" VALUES ('Student Record with StudentID = {Admin_StudentDetails_StudentID_TextBox.Text} was UPDATED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

                string sqlQuery2 = "UPDATE dbo.Students" +
                                   " SET Email = @Email," +
                                   " PhoneNo = @PhoneNo," +
                                   " AddressLine1 = @AddressLine1," +
                                   " AddressLine2 = @AddressLine2," +
                                   " City = @City," +
                                   " County = @County," +
                                   " Level = @Level," +
                                   " Country = @Country" +
                                   " WHERE StudentID = @StudentID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);
                    cmd1.Parameters.AddWithValue("@StudentID", Admin_StudentDetails_StudentID_TextBox.Text);
                    cmd1.Parameters.AddWithValue("@Username", Admin_LoginDetails_LoggedInAs_TextBox.Text);

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@StudentID", Admin_StudentDetails_StudentID_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@Email", Admin_StudentDetails_Email_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@PhoneNo", Admin_StudentDetails_PhoneNo_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@AddressLine1", Admin_StudentDetails_AddressLine1_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@AddressLine2", Admin_StudentDetails_AddressLine2_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@City", Admin_StudentDetails_City_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@County", Admin_StudentDetails_County_Dropdown.Text);
                    cmd2.Parameters.AddWithValue("@Level", Admin_StudentDetails_Level_Dropdown.Text);
                    cmd2.Parameters.AddWithValue("@Country", Admin_StudentDetails_Country_Dropdown.Text);

                    DialogResult dialog = MessageBox.Show($"Are you sure you want to make the following changes to this Student record with StudentNo = {Admin_StudentDetails_StudentID_TextBox.Text}?:" +
                                        $"\n\nEmail:\n{Admin_StudentDetails_Email_TextBox.Text}\n" +
                                        $"\nPhoneNo:\n{Admin_StudentDetails_PhoneNo_TextBox.Text}\n" +
                                        $"\nAddressLine1:\n{Admin_StudentDetails_AddressLine1_TextBox.Text}\n" +
                                        $"\nAddressLine2:\n{Admin_StudentDetails_AddressLine2_TextBox.Text}\n" +
                                        $"\nCity:\n{Admin_StudentDetails_City_TextBox.Text}\n" +
                                        $"\nCounty:\n{Admin_StudentDetails_County_Dropdown.Text}\n" +
                                        $"\nLevel:\n{Admin_StudentDetails_Level_Dropdown.Text}\n" +
                                        $"\nCountry:\n{Admin_StudentDetails_Country_Dropdown.Text}\n",
                                        "Delete Record", MessageBoxButtons.YesNo
                                        );
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Admin_Students admp = new Admin_Students(Admin_LoginDetails_LoggedInAs_TextBox.Text, Admin_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            admp.ShowDialog();
            #endregion
        }

        public void Admin_Students_EditMode()
        {
            #region            
            this.Admin_StudentDetails_Email_TextBox.ReadOnly = false;
            this.Admin_StudentDetails_PhoneNo_TextBox.ReadOnly = false;
            this.Admin_StudentDetails_AddressLine1_TextBox.ReadOnly = false;
            this.Admin_StudentDetails_AddressLine2_TextBox.ReadOnly = false;
            this.Admin_StudentDetails_City_TextBox.ReadOnly = false;
            this.Admin_StudentDetails_County_Dropdown.Visible = true;
            this.Admin_StudentDetails_County_TextBox.Visible = false;
            this.Admin_StudentDetails_Level_Dropdown.Visible = true;
            this.Admin_StudentDetails_Level_TextBox.Visible = false;
            this.Admin_StudentDetails_Country_Dropdown.Visible = true;
            this.Admin_StudentDetails_Country_TextBox.Visible = false;
            this.Admin_Students_CompleteEdit_Button.Visible = true;
            this.Admin_Students_ExitEditMode_Button.Visible = true;
            #endregion
        }

        public void Admin_Students_ExitEditMode()
        {
            #region 
            this.Admin_StudentDetails_Email_TextBox.ReadOnly = true;
            this.Admin_StudentDetails_PhoneNo_TextBox.ReadOnly = true;
            this.Admin_StudentDetails_AddressLine1_TextBox.ReadOnly = true;
            this.Admin_StudentDetails_AddressLine2_TextBox.ReadOnly = true;
            this.Admin_StudentDetails_City_TextBox.ReadOnly = true;
            this.Admin_StudentDetails_County_Dropdown.Visible = false;
            this.Admin_StudentDetails_County_TextBox.Visible = true;
            this.Admin_StudentDetails_Level_Dropdown.Visible = false;
            this.Admin_StudentDetails_Level_TextBox.Visible = true;
            this.Admin_StudentDetails_Country_Dropdown.Visible = false;
            this.Admin_StudentDetails_Country_TextBox.Visible = true;
            this.Admin_Students_CompleteEdit_Button.Visible = false;
            this.Admin_Students_ExitEditMode_Button.Visible = false;
            #endregion
        }

        public void Search_Admin_Students_DataGridView(string valueToSearch)
        {
            #region
            string sqlQuery = $"SELECT * FROM dbo.Students" +
                              $" WHERE CONCAT(StudentID, FirstName, Surname, Email, PhoneNo, AddressLine1, AddressLine2, City, County, Country, Level, Course)" +
                              $" LIKE '%{valueToSearch}%'";
            Load_Admin_Students_DataGridView(sqlQuery);
            #endregion
        }

        public void Load_Database_History()
        {
            #region
            DatabaseHistory dbhp = new DatabaseHistory(Admin_LoginDetails_LoggedInAs_TextBox.Text, Admin_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            dbhp.ShowDialog();
            #endregion
        }

        public void Load_Admin_ListedUsers()
        {
            #region
            Admin_ListedUsers a_lup = new Admin_ListedUsers(Admin_LoginDetails_LoggedInAs_TextBox.Text, Admin_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            a_lup.ShowDialog();
            #endregion
        }

        public void Load_New_Student()
        {
            #region
            New_Student ns = new New_Student(Admin_LoginDetails_LoggedInAs_TextBox.Text, Admin_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            ns.ShowDialog();
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

        #endregion

        #region EVENTS

        private void Admin_Students_Load(object sender, EventArgs e)
        {
            #region
            string sqlQuery = "SELECT * FROM dbo.Students";
            Load_Admin_Students_DataGridView(sqlQuery);
            Admin_Students_DataGridView.Select();
            #endregion
        }

        #endregion

        #region EVENT HANDLERS

        private void Admin_Students_Delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Delete_Admin_Student();
            #endregion
        }

        private void Admin_Students_Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Application.Exit();
            #endregion
        }

        private void Admin_Students_DatabaseHistory_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_Database_History();
            #endregion
        }

        private void Admin_Students_ListedUsers_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_Admin_ListedUsers();
            #endregion
        }

        private void Admin_Students_New_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_New_Student();
            #endregion
        }

        private void Admin_Students_CompleteEdit_Button_Click(object sender, EventArgs e)
        {
            #region
            Edit_Admin_Student();
            #endregion
        }

        private void Admin_Students_Edit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Admin_Students_EditMode();
            #endregion
        }

        private void Admin_Students_ExitEditMode_Button_Click(object sender, EventArgs e)
        {
            #region
            Admin_Students_ExitEditMode();
            #endregion
        }

        private void Admin_Students_Search_Button_Click_1(object sender, EventArgs e)
        {
            #region
            Search_Admin_Students_DataGridView(Admin_Search_TextBox.Text);
            #endregion
        }

        private void Admin_Students_Logout_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_LoginScreen();
            #endregion
        }


        private void Admin_Search_TextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            #region
            if (e.KeyCode == Keys.Enter)
            {
                Search_Admin_Students_DataGridView(Admin_Search_TextBox.Text);
            }
            #endregion
        }

        private void Admin_Students_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Admin_Students_DataGridView.Rows[e.RowIndex];
                Admin_StudentDetails_StudentID_TextBox.Text = row.Cells[0].Value.ToString();
                Admin_StudentDetails_FirstName_TextBox.Text = row.Cells[1].Value.ToString();
                Admin_StudentDetails_Surname_TextBox.Text = row.Cells[2].Value.ToString();
                Admin_StudentDetails_Email_TextBox.Text = row.Cells[3].Value.ToString();
                Admin_StudentDetails_PhoneNo_TextBox.Text = row.Cells[4].Value.ToString();
                Admin_StudentDetails_AddressLine1_TextBox.Text = row.Cells[5].Value.ToString();
                Admin_StudentDetails_AddressLine2_TextBox.Text = row.Cells[6].Value.ToString();
                Admin_StudentDetails_City_TextBox.Text = row.Cells[7].Value.ToString();
                Admin_StudentDetails_County_TextBox.Text = row.Cells[8].Value.ToString();
                Admin_StudentDetails_Level_TextBox.Text = row.Cells[9].Value.ToString();
                Admin_StudentDetails_Course_TextBox.Text = row.Cells[10].Value.ToString();
                Admin_StudentDetails_Country_TextBox.Text = row.Cells[11].Value.ToString();
            }
            #endregion
        }

        private void Admin_Students_DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            #region
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Admin_Students_DataGridView.Rows[e.RowIndex];
                Admin_StudentDetails_StudentID_TextBox.Text = row.Cells[0].Value.ToString();
                Admin_StudentDetails_FirstName_TextBox.Text = row.Cells[1].Value.ToString();
                Admin_StudentDetails_Surname_TextBox.Text = row.Cells[2].Value.ToString();
                Admin_StudentDetails_Email_TextBox.Text = row.Cells[3].Value.ToString();
                Admin_StudentDetails_PhoneNo_TextBox.Text = row.Cells[4].Value.ToString();
                Admin_StudentDetails_AddressLine1_TextBox.Text = row.Cells[5].Value.ToString();
                Admin_StudentDetails_AddressLine2_TextBox.Text = row.Cells[6].Value.ToString();
                Admin_StudentDetails_City_TextBox.Text = row.Cells[7].Value.ToString();
                Admin_StudentDetails_County_TextBox.Text = row.Cells[8].Value.ToString();
                Admin_StudentDetails_Level_TextBox.Text = row.Cells[9].Value.ToString();
                Admin_StudentDetails_Course_TextBox.Text = row.Cells[10].Value.ToString();
                Admin_StudentDetails_Country_TextBox.Text = row.Cells[11].Value.ToString();
            }
            #endregion
        }
        #endregion
    }
}
