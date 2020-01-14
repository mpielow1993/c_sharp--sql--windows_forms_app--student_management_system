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
    public partial class LoginScreen : Form
    {
        //CONNECTION STRING
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSStudentMSDatabase.mdf;Integrated Security=True";

        /*N.B. PLEASE READ TO BE ABLE TO LOG IN*/
        #region PLAIN TEXT PASSWORD VALUES
        /// <summary>
        /// 
        /// List of all DBSStudentMSDatabase passwords in plain text. Their SHA2_256 Hashed equivalents can be found 
        /// in the 'Passwords' column of the 'LoginDetails' table. I decided to exclude the plain-text passwords in the actual
        /// database for security reasons
        /// 
        /// Username:       Plain-Text Password:
        /// 
        /// david.icke      N3wW0rld0rd3r
        /// kim.jong.un     D34rL34d3r
        /// donald.trump    M4k34m3r1c4Gr34t4g41n
        /// joe.rogan       M4r1ju4n4
        /// elon.musk       T35l4
        /// 
        /// </summary>
        #endregion

        #region CONSTRUCTOR

        public LoginScreen()
        {
            #region
            InitializeComponent();
            #endregion
        }

        #endregion

        #region EVENT HANDLERS

        private void LoginScreen_LoginDetails_Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            #region
            //Hide the user's Password input.
            LoginScreen_LoginDetails_Password_TextBox.PasswordChar = '*';
            #endregion
        }

        private void LoginScreen_LoginDetails_Login_Button_Click(object sender, EventArgs e)
        {
            #region
            Login();
            #endregion
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            #region
            //Session terminates.
            Application.Exit();
            #endregion
        }

        #endregion

        #region METHODS

        static string SHA_256(string randomString)
        {
            #region
            //Method SHA_256(randomString) performs SHA_256 encyption on a string parameter selected by the user (in this case, the user's input in the 
            //Password TextBox), which will be compared against values in the the 'Password' column (containing the SHA_256 hashes of the Plain Text 
            //passwords) in the 'LoginDetails' table.
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

        private void Login()
        {
            #region
            //Enclose in a try/catch to handle any exceptions encountered upon execution.
            try
            {
                //Enclose in using braces to automatically close the connection to the database when data retrieval is finished, thus helping to 
                //sanitize our code.
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //construct a SQL Query that will query the LoginDetails table of our localDB based on the values of the Username TextBox, 
                    //PasswordTextBox and UserLevel Dropdown.
                    string sqlQuery = "SELECT Username, UserLevel, Password FROM dbo.LoginDetails WHERE Username = @Username AND UserLevel = @UserLevel AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    //Assign the values of the query parameters to the values of the Username TextBox, Password TextBox and UserLevel Dropdown input
                    //by the user.
                    cmd.Parameters.AddWithValue("@Username", LoginScreen_LoginDetails_Username_TextBox.Text);
                    cmd.Parameters.AddWithValue("@UserLevel", LoginScreen_LoginDetails_UserLevel_Dropdown.Text);
                    cmd.Parameters.AddWithValue("@Password", SHA_256(LoginScreen_LoginDetails_Password_TextBox.Text));

                    //method ExecuteReader() is called on our defined SqlCommand cmd, which sends the command text from sqlQuery to the SqlConnection 
                    //coon and builds a SqlDataReader object, defined here as sdr.
                    SqlDataReader sdr = cmd.ExecuteReader();

                    //If sdr executes successfully against the database, this means that a record is returned from the LoginDetails table that 
                    //is a result of sqlQuery with its user-defined values (i.e a matching record).  
                    if (sdr.Read() == true)
                    {
                        //If a matching record is found, then the value in the UserLevel column (i.e either Admin or StaffMember) of the LoginDetails 
                        //table will dictate whether the user is redirected to either the Admin Home Page (i.e Admin_Students) or the regular Home 
                        //Page (i.e Students).
                        MessageBox.Show($"Welcome {LoginScreen_LoginDetails_Username_TextBox.Text}!");
                        this.Hide();

                        if (LoginScreen_LoginDetails_UserLevel_Dropdown.Text == "Admin")
                        {
                            this.Hide();
                            Admin_Students admp = new Admin_Students(LoginScreen_LoginDetails_Username_TextBox.Text, LoginScreen_LoginDetails_UserLevel_Dropdown.Text);
                            admp.ShowDialog();
                        }
                        else
                        {
                            Students mp = new Students(LoginScreen_LoginDetails_Username_TextBox.Text, LoginScreen_LoginDetails_UserLevel_Dropdown.Text);
                            mp.ShowDialog();
                        }
                    }
                    //If a matching record in the LoginDetails table is not found, an error message is shown, the user stays on the LoginScreen, the
                    //user input values are cleared and the cursor is focused back to the Username TextBox.
                    else
                    {
                        MessageBox.Show("Login failed. Please try again", "Login denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoginScreen_LoginDetails_Username_TextBox.Clear();
                        LoginScreen_LoginDetails_Password_TextBox.Clear();
                        LoginScreen_LoginDetails_Username_TextBox.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
        #endregion
    }
}
