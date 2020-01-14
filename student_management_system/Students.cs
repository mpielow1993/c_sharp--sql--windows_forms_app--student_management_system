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
    public partial class Students : Form
    {
        /* Most explanation of code that is similar across all classes is provided in this class declaration */ 

        //CONNECTION STRING
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSStudentMSDatabase.mdf;Integrated Security=True";

        #region CONSTRUCTOR
        
        //initial values: 
        //1) The client's Username 
        //2). Their User Level
        public Students(string userNameValue, string userLevelValue)
        {
            #region
            InitializeComponent();
            Students_LoginDetails_LoggedInAs_TextBox.Text = userNameValue;
            Students_LoginDetails_UserLevel_TextBox.Text = userLevelValue;
            #endregion
        }
        #endregion

        #region METHODS

        //Method Search_Students_Data() contains a SQL wildcard that will query the database based on the input in the Search Bar.
        public void Search_Students_DataGridView(string valueToSearch)
        {
            #region
            string sqlQuery = $"SELECT * FROM dbo.Students" +
                              $" WHERE CONCAT(StudentID, FirstName, Surname, Email, PhoneNo, AddressLine1, AddressLine2, City, County, Country, Level, Course)" +
                              $" LIKE '%{valueToSearch}%'";
            Load_Students_DataGridView(sqlQuery);
            #endregion
        }

        //LoadTable creates new instances of classes SQLConnection, SqlDataAdapter and DataTable to collect the results of the query from 
        //the database and construct the view of it.
        public void Load_Students_DataGridView(string sqlQuery)
        {
            #region
            //using statement ensures that our SqlConnection instance will disconnect once it has served its purpose, helping to sanitize the code.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Students_DataGridView.DataSource = dt;
            }
            #endregion
        }


        public void Delete_Student()
        {
            #region
            //Delete_Student() creates two new SQL Queries.
            //Enclose in a try/catch block to handle any exceptions out queries may throw
            try
            {
                //sqlQuery1 first makes a record of the action about to be executed (in this case, a DELETE action), by inserting a record of the 
                //StudentID, the action undertaken and the Date and Time of the action into the DatabaseHistory table. 
                string sqlQuery1 = $"INSERT INTO dbo.DatabaseHistory" +
                   $" VALUES('Student Record with StudentID = @StudentID was DELETED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

                //sqlQuery2 then executes this action.
                string sqlQuery2 = $"DELETE FROM dbo.Students WHERE StudentID = @StudentID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //The parameters of both queries are assigned with the values of the corresponding input from the Students TextBoxes.
                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);
                    cmd1.Parameters.AddWithValue("@StudentID", int.Parse(Students_StudentDetails_StudentID_TextBox.Text));
                    cmd1.Parameters.AddWithValue("@Username", Students_LoginDetails_LoggedInAs_TextBox.Text);

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@StudentID", int.Parse(Students_StudentDetails_StudentID_TextBox.Text));

                    //A Dialog Box is presented to the user as confirmation that they wish to proceed with the above action.
                    DialogResult dialog = MessageBox.Show("Are you sure you want to delete this Student record?:" +
                                        $"\n\nStudentID:\t{Students_StudentDetails_StudentID_TextBox.Text}" +
                                        $"\nFirst Name:\t{Students_StudentDetails_FirstName_TextBox.Text}" +
                                        $"\nSurname:\t{Students_StudentDetails_Surname_TextBox.Text}" +
                                        $"\nEmail:\t\t{Students_StudentDetails_Email_TextBox.Text}" +
                                        $"\nPhoneNo:\t{Students_StudentDetails_PhoneNo_TextBox.Text}" +
                                        $"\nAddressLine1\t{Students_StudentDetails_AddressLine1_TextBox.Text}" +
                                        $"\nAddressLine2:\t{Students_StudentDetails_AddressLine2_TextBox.Text}" +
                                        $"\nCity:\t\t{Students_StudentDetails_City_TextBox.Text}" +
                                        $"\nCounty:\t\t{Students_StudentDetails_County_TextBox.Text}" +
                                        $"\nLevel:\t\t{Students_StudentDetails_Level_TextBox.Text}" +
                                        $"\nCourse:\t\t{Students_StudentDetails_Course_TextBox.Text}" +
                                        $"\nCountry:\t\t{Students_StudentDetails_Country_TextBox.Text}",
                                        "Delete Record", MessageBoxButtons.YesNo
                                        );
                    if (dialog == DialogResult.Yes)
                    {
                        //SqlCommand method ExecuteNonQuery() will return an integer result > 1 if a row in the database has been affected by the above
                        //actions. Since we are deleting according to the PrimaryKey StudentID, there can only be a maximum of one row affected, and so 
                        //if ExecuteNonQuery() for our defined command cmd1 returns a value > 0, we know that the query has executed successfully.

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
                        this.Hide();
                        Students s = new Students(Students_LoginDetails_LoggedInAs_TextBox.Text, Students_LoginDetails_LoggedInAs_TextBox.Text);
                        s.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        //Edit_Student() is essentially the same methodology as Delete_Student(), with with DELETE action replaced with an UPDATE action.
        public void Edit_Student()
        {
            #region
            try
            {
                string sqlQuery1 = $"INSERT INTO dbo.DatabaseHistory" +
                                   $" VALUES ('Student Record with StudentID = {Students_StudentDetails_StudentID_TextBox.Text} was UPDATED at {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}', @Username)";

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
                    cmd1.Parameters.AddWithValue("@StudentID", Students_StudentDetails_StudentID_TextBox.Text);
                    cmd1.Parameters.AddWithValue("@Username", Students_LoginDetails_LoggedInAs_TextBox.Text);

                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, conn);
                    cmd2.Parameters.AddWithValue("@StudentID", Students_StudentDetails_StudentID_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@Email", Students_StudentDetails_Email_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@PhoneNo", Students_StudentDetails_PhoneNo_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@AddressLine1", Students_StudentDetails_AddressLine1_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@AddressLine2", Students_StudentDetails_AddressLine2_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@City", Students_StudentDetails_City_TextBox.Text);
                    cmd2.Parameters.AddWithValue("@County", Students_StudentDetails_County_Dropdown.Text);
                    cmd2.Parameters.AddWithValue("@Level", Students_StudentDetails_Level_Dropdown.Text);
                    cmd2.Parameters.AddWithValue("@Country", Students_StudentDetails_Country_Dropdown.Text);

                    DialogResult dialog = MessageBox.Show($"Are you sure you want to make the following changes to this Student record with StudentNo = {Students_StudentDetails_StudentID_TextBox.Text}?:" +
                                        $"\n\nEmail:\n{Students_StudentDetails_Email_TextBox.Text}\n" +
                                        $"\nPhoneNo:\n{Students_StudentDetails_PhoneNo_TextBox.Text}\n" +
                                        $"\nAddressLine1\n{Students_StudentDetails_AddressLine1_TextBox.Text}\n" +
                                        $"\nAddressLine2:\n{Students_StudentDetails_AddressLine2_TextBox.Text}\n" +
                                        $"\nCity:\n{Students_StudentDetails_City_TextBox.Text}\n" +
                                        $"\nCounty:\n{Students_StudentDetails_County_Dropdown.Text}\n" +
                                        $"\nLevel:\n{Students_StudentDetails_Level_Dropdown.Text}\n" +
                                        $"\nCountry:\n{Students_StudentDetails_Country_Dropdown.Text}",
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
                        this.Hide();
                        Students s = new Students(Students_LoginDetails_LoggedInAs_TextBox.Text, Students_LoginDetails_LoggedInAs_TextBox.Text);
                        s.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        //All TextBox values in the Students view are defaulted to read-only. 
        //Method EditMode() allows those that are permitted be altered to do so.
        //In this method, two button controls called 'Exit Edit Mode' & 'Complete Edit' are made visible. Rescpectively, they allow the user to 
        //change back to normal mode or commit the changes they have made.
        public void Students_EditMode()
        {
            #region
            
            //Enable the text inputs to be written to upon user authentication
            this.Students_StudentDetails_Email_TextBox.ReadOnly = false;
            this.Students_StudentDetails_PhoneNo_TextBox.ReadOnly = false;
            this.Students_StudentDetails_AddressLine1_TextBox.ReadOnly = false;
            this.Students_StudentDetails_AddressLine2_TextBox.ReadOnly = false;
            this.Students_StudentDetails_City_TextBox.ReadOnly = false;
            this.Students_StudentDetails_County_Dropdown.Visible = true;
            this.Students_StudentDetails_County_TextBox.Visible = false;
            this.Students_StudentDetails_Level_Dropdown.Visible = true;
            this.Students_StudentDetails_Level_TextBox.Visible = false;
            this.Students_StudentDetails_Country_Dropdown.Visible = true;
            this.Students_StudentDetails_Country_TextBox.Visible = false;
            this.Students_StudentDetails_CompleteEdit_Button.Visible = true;
            this.Students_StudentDetails_ExitEditMode_Button.Visible = true;

            #endregion
        }

        //Students_ExitEditMode() essentially reverses the changes made to the form controls by method EditMode() to their default read-only values.
        //The 'Exit Edit Mode' and 'Complete Edit' buttons are also made invisible again.
        public void Students_ExitEditMode()
        {
            #region
            
            //Enable the text inputs to be written to upon user authentication
            this.Students_StudentDetails_Email_TextBox.ReadOnly = true;
            this.Students_StudentDetails_PhoneNo_TextBox.ReadOnly = true;
            this.Students_StudentDetails_AddressLine1_TextBox.ReadOnly = true;
            this.Students_StudentDetails_AddressLine2_TextBox.ReadOnly = true;
            this.Students_StudentDetails_City_TextBox.ReadOnly = true;
            this.Students_StudentDetails_County_Dropdown.Visible = false;
            this.Students_StudentDetails_County_TextBox.Visible = true;
            this.Students_StudentDetails_Country_Dropdown.Visible = false;
            this.Students_StudentDetails_Country_TextBox.Visible = true;
            this.Students_StudentDetails_CompleteEdit_Button.Visible = false;
            this.Students_StudentDetails_ExitEditMode_Button.Visible = false;

            #endregion
        }

        public void Load_New_Student()
        {
            #region
            New_Student ns = new New_Student(Students_LoginDetails_LoggedInAs_TextBox.Text, Students_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            ns.ShowDialog();
            #endregion
        }

        public void Load_Database_History()
        {
            #region
            DatabaseHistory dbhp = new DatabaseHistory(Students_LoginDetails_LoggedInAs_TextBox.Text, Students_LoginDetails_UserLevel_TextBox.Text);
            this.Hide();
            dbhp.ShowDialog();
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

        //Upon loading, each Students page (i.e Home Page) in the StaffMember UI shows all records from the Students Table.
        private void Students_Load(object sender, EventArgs e)
        {
            #region
            string sqlQuery = "SELECT * FROM dbo.Students";
            Load_Students_DataGridView(sqlQuery);

            //Select ensures that a full row in Students_DataGridView is always highlighted at any one time
            Students_DataGridView.Select();
            #endregion
        }

        #endregion

        #region EVENT HANDLERS

        //Upon clicking the 'Search' Button, this method is called and the results of the search are displayed to the client.
        private void Students_Search_Button_Click_1(object sender, EventArgs e)
        {
            #region
            string valueToSearch = Students_Search_TextBox.Text.ToString();
            Search_Students_DataGridView(valueToSearch);
            #endregion
        }

        //Upon clicking on a specific row in the view, the corresponding field values are separated into their associated TextBoxes to allow for 
        //easy viewing and editing.
        private void Students_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Students_DataGridView.Rows[e.RowIndex];
                Students_StudentDetails_StudentID_TextBox.Text = row.Cells[0].Value.ToString();
                Students_StudentDetails_FirstName_TextBox.Text = row.Cells[1].Value.ToString();
                Students_StudentDetails_Surname_TextBox.Text = row.Cells[2].Value.ToString();
                Students_StudentDetails_Email_TextBox.Text = row.Cells[3].Value.ToString();
                Students_StudentDetails_PhoneNo_TextBox.Text = row.Cells[4].Value.ToString();
                Students_StudentDetails_AddressLine1_TextBox.Text = row.Cells[5].Value.ToString();
                Students_StudentDetails_AddressLine2_TextBox.Text = row.Cells[6].Value.ToString();
                Students_StudentDetails_City_TextBox.Text = row.Cells[7].Value.ToString();
                Students_StudentDetails_County_TextBox.Text = row.Cells[8].Value.ToString();
                Students_StudentDetails_Level_TextBox.Text = row.Cells[9].Value.ToString();
                Students_StudentDetails_Course_TextBox.Text = row.Cells[10].Value.ToString();
                Students_StudentDetails_Country_TextBox.Text = row.Cells[11].Value.ToString();
            }
            #endregion
        }

        //Upon clicking 'New', a new instance of class New_Student is created. This instance has intial values equal to the Username and UserLevel of 
        //the user in the current session. The user is then redirected to the registration form for new Students.
        private void Students_New_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_New_Student();
            #endregion
        }

        //Upon clicking 'Delete', the method Delete_Student_Record() will execute, with parameters equal to the associated fields of the 
        //highlighted record in the Students_DataGridView (i.e the values of the text fields).
        //After this query has executed, a new instance of Students will be created with the updated view and presented to the user.
        private void Students_Delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Delete_Student();
            #endregion
        }

        //Upon clicking Edit, method Edit_Mode() will execute and allow the permitted fields of the highlighted row to be edited.
        private void Students_Edit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Students_EditMode();
            #endregion
        }


        private void Students_StudentDetails_ExitEditMode_Button_Click(object sender, EventArgs e)
        {
            #region
            //Upon clicking the 'Exit Edit Mode' Button in Edit mode, all changes made 
            Students_ExitEditMode();
            #endregion
        }

        //Upon clicking the 'Complete Edit' Button in Edit mode, method Edit_Student_Record() will be called and a new instance of Students with an 
        //updated Students_DataGridView will be presented to the user.
        private void Students_StudentDetails_CompleteEdit_Button_Click(object sender, EventArgs e)
        {
            #region
            Edit_Student();
            #endregion
        }

        //Upon clicking 'View Database History', a new instance of class DatabaseHistory is created, with intial values equal to the Username and 
        //UserLevel of the user in the current session. The user is then redirected to the system's Database History.
        private void Students_ViewDatabaseHistory_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_Database_History();
            #endregion
        }

        //Upon clicking 'Logout', a new instance of class DatabaseHistory is created, with intial values equal to the Username and UserLevel of the 
        //user in the current session. The user is then redirected to the LoginScreen
        private void Students_Logout_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_LoginScreen();
            #endregion
        }

        //Upon clicking 'Exit', the session terminates.
        private void Students_Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Application.Exit();
            #endregion
        }

        //Upon pressing the 'Enter' key, whatever text value is contained within the Search Bar will be used as a SQL wildcard and executed 
        //against the database.
        private void Students_Search_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            #region
            if (e.KeyCode == Keys.Enter)
            {
                Search_Students_DataGridView(Students_Search_TextBox.Text);
            }
            #endregion
        }

        //Upon entering a specific row in the view, the corresponding field values are separated into their associated TextBoxes to allow for 
        //easy viewing/ editing.
        private void Students_DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            #region 
            //Set all text boxes from ListedUsersPage to the appropriate value, according to the row the user clicks on 
            DataGridViewRow row = this.Students_DataGridView.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                Students_StudentDetails_StudentID_TextBox.Text = row.Cells[0].Value.ToString();
                Students_StudentDetails_FirstName_TextBox.Text = row.Cells[1].Value.ToString();
                Students_StudentDetails_Surname_TextBox.Text = row.Cells[2].Value.ToString();
                Students_StudentDetails_Email_TextBox.Text = row.Cells[3].Value.ToString();
                Students_StudentDetails_PhoneNo_TextBox.Text = row.Cells[4].Value.ToString();
                Students_StudentDetails_AddressLine1_TextBox.Text = row.Cells[5].Value.ToString();
                Students_StudentDetails_AddressLine2_TextBox.Text = row.Cells[6].Value.ToString();
                Students_StudentDetails_City_TextBox.Text = row.Cells[7].Value.ToString();
                Students_StudentDetails_County_TextBox.Text = row.Cells[8].Value.ToString();
                Students_StudentDetails_County_Dropdown.Text = row.Cells[8].Value.ToString();
                Students_StudentDetails_Level_TextBox.Text = row.Cells[9].Value.ToString();
                Students_StudentDetails_Level_Dropdown.Text = row.Cells[9].Value.ToString();
                Students_StudentDetails_Course_TextBox.Text = row.Cells[10].Value.ToString();
                Students_StudentDetails_Country_TextBox.Text = row.Cells[11].Value.ToString();
                Students_StudentDetails_Country_Dropdown.Text = row.Cells[11].Value.ToString();
            }
            #endregion
        }
        #endregion
    }
}
