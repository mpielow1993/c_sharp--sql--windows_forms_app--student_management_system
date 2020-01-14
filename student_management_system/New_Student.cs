using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class New_Student : Form
    {
        //CONNECTION STRING
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSStudentMSDatabase.mdf;Integrated Security=True";

        #region CONSTRUCTOR

        public New_Student(string userNameValue, string userLevelValue)
        {
            #region
            InitializeComponent();
            NewStudent_LoginDetails_LoggedInAs_TextBox.Text = userNameValue;
            NewStudent_LoginDetails_UserLevel_TextBox.Text = userLevelValue;
            #endregion
        }

        #endregion

        #region METHODS

        public string Get_Student_Level()
        {
            #region
            //Returns the Text value of the radio button checked by the user.
            if (this.NewStudent_RegistrationDetails_Undergraduate_RadioButton.Checked == true)
            {
                return NewStudent_RegistrationDetails_Undergraduate_RadioButton.Text;
            }
            else
            {
                return NewStudent_RegistrationDetails_Postgraduate_RadioButton.Text;
            }
            #endregion
        }

        public void Add_New_Student()
        {
            #region
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery1 = $"INSERT INTO dbo.DatabaseHistory" +
                                       $" VALUES ('Student Record with StudentID = {NewStudent_RegistrationDetails_StudentID_TextBox.Text} was INSERTED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

                    string sqlQuery2 = "INSERT INTO dbo.Students VALUES (@StudentID, @FirstName, @Surname, @Email, @PhoneNo, @AddressLine1, @AddressLine2, @City, @County, @Level, @Course, @Country)";

                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);
                    cmd1.Parameters.AddWithValue("@StudentID", NewStudent_RegistrationDetails_StudentID_TextBox.Text);
                    cmd1.Parameters.AddWithValue("@Username", NewStudent_LoginDetails_LoggedInAs_TextBox.Text);

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);

                    cmd2.Parameters.AddWithValue("@StudentID", int.Parse(NewStudent_RegistrationDetails_StudentID_TextBox.Text));
                    cmd2.Parameters.AddWithValue("@FirstName", NewStudent_RegistrationDetails_FirstName_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@Surname", NewStudent_RegistrationDetails_Surname_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@Email", NewStudent_RegistrationDetails_Email_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@PhoneNo", NewStudent_RegistrationDetails_PhoneNo_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@AddressLine1", NewStudent_RegistrationDetails_AddressLine1_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@AddressLine2", NewStudent_RegistrationDetails_AddressLine2_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@City", NewStudent_RegistrationDetails_City_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@County", NewStudent_RegistrationDetails_County_Dropdown.Text);
                    cmd2.Parameters.AddWithValue("@Level", this.Get_Student_Level());
                    cmd2.Parameters.AddWithValue("@Course", NewStudent_RegistrationDetails_Course_Dropdown.Text);
                    cmd2.Parameters.AddWithValue("@Country", NewStudent_RegistrationDetails_Country_Dropdown.Text);

                    DialogResult dialog = MessageBox.Show("Are you sure you want to add this Student record?:" +
                                        $"\n\nStudentID: {NewStudent_RegistrationDetails_StudentID_TextBox.Text}\n" +
                                        $"\nFirst Name: {NewStudent_RegistrationDetails_FirstName_TextBox.Text}\n" +
                                        $"\nSurname: {NewStudent_RegistrationDetails_Surname_TextBox.Text}\n" +
                                        $"\nEmail: {NewStudent_RegistrationDetails_Email_TextBox.Text}\n" +
                                        $"\nPhoneNo: {NewStudent_RegistrationDetails_PhoneNo_TextBox.Text}\n" +
                                        $"\nAddressLine1: {NewStudent_RegistrationDetails_AddressLine1_TextBox.Text}\n" +
                                        $"\nAddressLine2: {NewStudent_RegistrationDetails_AddressLine2_TextBox.Text}\n" +
                                        $"\nCity: {NewStudent_RegistrationDetails_City_TextBox.Text}\n" +
                                        $"\nCounty:\n{NewStudent_RegistrationDetails_County_Dropdown.Text}\n" +
                                        $"\nLevel:\n{Get_Student_Level()}\n" +
                                        $"\nCourse:\n{NewStudent_RegistrationDetails_Course_Dropdown.Text}\n" +
                                        $"\nCountry:\n{NewStudent_RegistrationDetails_Country_Dropdown.Text}\n",
                                        "Add Record", MessageBoxButtons.YesNo
                                        );
                    if (dialog == DialogResult.Yes)
                    {
                        int a = cmd1.ExecuteNonQuery();

                        if (a > 0)
                        {
                            MessageBox.Show("Record Added Successfully", "Add Successful", MessageBoxButtons.OK);
                            cmd2.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Record Addition Failed", "Failed Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                Decide_HomePage_By_UserLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        public void Decide_HomePage_By_UserLevel()
        {
            #region
            //Decides which type of interface to redirect to after registration is complete based on the value of the UserLevel TextBox in the 
            //top right-hand corner of the form (both). This is one of the main reasons why I chose to include these two attributes as intial values 
            //for the creation of all Form instances in my project.
            Admin_Students admp = new Admin_Students(NewStudent_LoginDetails_LoggedInAs_TextBox.Text, NewStudent_LoginDetails_UserLevel_TextBox.Text);
            Students mp = new Students(NewStudent_LoginDetails_LoggedInAs_TextBox.Text, NewStudent_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();

            if (NewStudent_LoginDetails_UserLevel_TextBox.Text == "Admin")
            {
                admp.ShowDialog();
            }
            else
            {
                mp.ShowDialog();
            }
            #endregion
        }

        #endregion

        #region EVENT HANDLERS

        private void NewStudent_RegistrationDetails_CreateNewStudent_Button_Click(object sender, EventArgs e)
        {
            #region
            Add_New_Student();
            #endregion
        }

        private void NewStudent_RegistrationDetails_CancelStudent_Button_Click(object sender, EventArgs e)
        {
            #region
            Decide_HomePage_By_UserLevel();
            #endregion
        }

        private void NewStudent_RegistrationDetails_StudentID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region

            //Checks for valid user input for the StudentID (i.e that each character entered is an integer and that the total character length = 8).
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            #endregion
        }

        private void NewStudent_RegistrationDetails_Undergraduate_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            #region
            //Logic below ensures that one and only one of the radio buttons (i.e Postgraduate and Undergraduate) are checked at any one time.
            if (NewStudent_RegistrationDetails_Undergraduate_RadioButton.Checked == true)
            {
                NewStudent_RegistrationDetails_Postgraduate_RadioButton.Checked = false;
            }
            else
            {
                NewStudent_RegistrationDetails_Postgraduate_RadioButton.Checked = true;
            }
            #endregion
        }

        #endregion
    }
}
