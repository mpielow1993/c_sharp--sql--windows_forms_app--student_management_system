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
    public partial class New_ListedUser : Form
    {
        //CONNECTION STRING
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSStudentMSDatabase.mdf;Integrated Security=True";

        #region CONSTRUCTOR

        public New_ListedUser(string userNameValue, string userLevelValue)
        {
            #region
            InitializeComponent();
            NewUser_LoginDetails_LoggedInAs_TextBox.Text = userNameValue;
            NewUser_LoginDetails_UserLevel_TextBox.Text = userLevelValue;
            #endregion
        }

        #endregion

        #region METHODS

        static string ComputeSHA_256(string randomString)
        {
            #region
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
            #endregion
        }

        private void Load_Admin_ListedUsers()
        {
            #region
            Admin_ListedUsers lup = new Admin_ListedUsers(NewUser_LoginDetails_LoggedInAs_TextBox.Text, NewUser_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            lup.ShowDialog();
            #endregion
        }

        private void Add_New_ListedUser()
        {
            #region
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery1 = "INSERT INTO dbo.LoginDetails VALUES (@Username, @UserLevel, @Password)";

                    string sqlQuery2 = $"INSERT INTO dbo.DatabaseHistory" +
                                       $" VALUES ('ListedUser Record with EmployeeID = {NewUser_RegistrationDetails_EmployeeID_TextBox.Text} was INSERTED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

                    string sqlQuery3 = "INSERT INTO dbo.ListedUsers VALUES (@EmployeeID, @Username, @FirstName, @Surname, @Email, @PhoneNo, @Department)";

                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);
                    cmd1.Parameters.AddWithValue("@Username", NewUser_RegistrationDetails_Username_TextBox.Text);
                    cmd1.Parameters.AddWithValue("@UserLevel", NewUser_RegistrationDetails_UserLevel_Dropdown.Text);
                    cmd1.Parameters.AddWithValue("@Password", ComputeSHA_256(NewUser_RegistrationDetails_Password_TextBox.Text));

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@EmployeeID", NewUser_RegistrationDetails_EmployeeID_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@Username", NewUser_LoginDetails_LoggedInAs_TextBox.Text);

                    SqlCommand cmd3 = new SqlCommand(sqlQuery3, conn);
                    #region add parameters
                    cmd3.Parameters.AddWithValue("@EmployeeID", NewUser_RegistrationDetails_EmployeeID_TextBox.Text);
                    cmd3.Parameters.AddWithValue("@Username", NewUser_RegistrationDetails_Username_TextBox.Text);
                    cmd3.Parameters.AddWithValue("@FirstName", NewUser_RegistrationDetails_FirstName_TextBox.Text);
                    cmd3.Parameters.AddWithValue("@Surname", NewUser_RegistrationDetails_Surname_TextBox.Text);
                    cmd3.Parameters.AddWithValue("@Email", NewUser_RegistrationDetails_Email_TextBox.Text);
                    cmd3.Parameters.AddWithValue("@PhoneNo", NewUser_RegistrationDetails_PhoneNo_TextBox.Text);
                    cmd3.Parameters.AddWithValue("@Department", NewUser_RegistrationDetails_Department_DropDown.Text);
                    #endregion

                    DialogResult dialog = MessageBox.Show("Are you sure you want to add this ListedUser record?:" +
                                        $"\n\nEmployeeID:\t{NewUser_RegistrationDetails_EmployeeID_TextBox.Text}" +
                                        $"\nUsername:\t{NewUser_RegistrationDetails_Username_TextBox.Text}" +
                                        $"\nFirstName:\t{NewUser_RegistrationDetails_FirstName_TextBox.Text}" +
                                        $"\nSurname:\t{NewUser_RegistrationDetails_Surname_TextBox.Text}" +
                                        $"\nEmail:\t\t{NewUser_RegistrationDetails_Email_TextBox.Text}" +
                                        $"\nPhoneNo:\t{NewUser_RegistrationDetails_PhoneNo_TextBox.Text}" +
                                        $"\nDepartment:\t{NewUser_RegistrationDetails_Department_DropDown.Text}" +
                                        $"\nUserLevel:\t{NewUser_RegistrationDetails_UserLevel_Dropdown.Text}",
                                        "Delete Record", MessageBoxButtons.YesNo
                                        );
                    if (dialog == DialogResult.Yes)
                    {
                        if (NewUser_RegistrationDetails_Password_TextBox.Text == NewUser_RegistrationDetails_ConfirmPassword_TextBox.Text)
                        {
                            int a = cmd1.ExecuteNonQuery();

                            if (a > 0)
                            {
                                MessageBox.Show("New LoginDetails Record Added Successfully", "LoginDetails Add Successful", MessageBoxButtons.OK);

                                int b = cmd2.ExecuteNonQuery();

                                if (b > 0)
                                {
                                    MessageBox.Show("New ListedUser Record Added Successfully", "ListedUsers Add Successful", MessageBoxButtons.OK);
                                    cmd3.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("New ListedUser Record Addition failed", "ListedUsers Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("LoginDetails Record Addition failed", "LoginDetails Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                Load_Admin_ListedUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
        #endregion

        #region EVENT HANDLERS

        private void NewUser_RegistrationDetails_Cancel_Button_Click(object sender, EventArgs e)
        {
            #region
            Load_Admin_ListedUsers();
            #endregion
        }

        private void NewUser_RegistrationDetails_CreateNewUser_Button_Click(object sender, EventArgs e)
        {
            #region
            Add_New_ListedUser();
            #endregion
        }
        #endregion
    }
}
