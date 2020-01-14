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
    public partial class DatabaseHistory : Form
    {
        //CONNECTION STRING
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DBSStudentMSDatabase.mdf;Integrated Security=True";

        #region CONSTRUCTOR

        public DatabaseHistory(string userNameValue, string userLevelValue)
        {
            #region
            InitializeComponent();
            DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Text = userNameValue;
            DatabaseHistory_LoginDetails_UserLevel_TextBox.Text = userLevelValue;
            #endregion
        }

        #endregion

        #region METHODS

        public void Load_DatabaseHistory_DataGridView(string sqlQuery)
        {
            #region
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseHistory_DataGridView.DataSource = dt;
            }
            #endregion
        }

        public void Search_DatabaseHistory_DataGridView(string valueToSearch)
        {
            #region
            string sqlQuery = $"SELECT * FROM dbo.DatabaseHistory" +
                              $" WHERE CONCAT(ActionID, ActionDescription, PerformedByUsername)" +
                              $" LIKE '%{valueToSearch}%'";
            Load_DatabaseHistory_DataGridView(sqlQuery);
            #endregion
        }

        public void Delete_DatabaseHistory()
        {
            #region
            try
            {
                string sqlQuery1 = $"DELETE FROM dbo.DatabaseHistory WHERE ActionID = {DatabaseHistory_ActionDetails_ActionID_TextBox.Text}";

                //DBCC CHECKIDENT() will automically numerically seed each record. This seed will be each record's Primary Key
                string sqlQuery2 = $"DBCC CHECKIDENT('dbo.DatabaseHistory')";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd1 = new SqlCommand(sqlQuery1, conn);

                    DialogResult dialog = MessageBox.Show("Are you sure you want to delete this DatabaseHistory record?:" +
                                        $"\n\nActionID:\n{DatabaseHistory_ActionDetails_ActionID_TextBox.Text}\n" +
                                        $"\nActionDescription:\n{DatabaseHistory_ActionDetails_ActionDescription_TextBox.Text}\n" +
                                        $"\nPerformedByUsername:\n{DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.Text}",
                                        "Delete Record", MessageBoxButtons.YesNo
                                        );
                    if (dialog == DialogResult.Yes)
                    {
                        int a = cmd1.ExecuteNonQuery();

                        if (a > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully", "Successful Delete", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Record Deletion Failed. Please try again", "Failed Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                DatabaseHistory dbhp = new DatabaseHistory(DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Text, DatabaseHistory_LoginDetails_UserLevel_TextBox.Text);
                this.Hide();
                dbhp.ShowDialog();
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
            //Conditional statement determines which UI Home Page to redirect to (necessary as the DatabaseHistory page is accesscible to both
            //StaffMembers and Admins)
            if (DatabaseHistory_LoginDetails_UserLevel_TextBox.Text == "Admin")
            {
                this.Hide();
                Admin_Students admp = new Admin_Students(DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Text, DatabaseHistory_LoginDetails_UserLevel_TextBox.Text);
                admp.ShowDialog();
            }
            else
            {
                this.Hide();
                Students mp = new Students(DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Text, DatabaseHistory_LoginDetails_UserLevel_TextBox.Text);
                mp.ShowDialog();
            }
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

        private void DatabaseHistory_Load(object sender, EventArgs e)
        {
            #region
            string sqlQuery = "SELECT * FROM dbo.DatabaseHistory";
            Load_DatabaseHistory_DataGridView(sqlQuery);
            DatabaseHistory_DataGridView.Select();
            #endregion
        }

        #endregion

        #region EVENT HANDLERS

        private void DatabaseHistory_MainMenu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Decide_HomePage_By_UserLevel();
            #endregion
        }

        private void DatabaseHistory_DeleteRecord_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Delete_DatabaseHistory();
            #endregion
        }

        private void DatabaseHistory_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DatabaseHistory_DataGridView.Rows[e.RowIndex];
                DatabaseHistory_ActionDetails_ActionID_TextBox.Text = row.Cells[0].Value.ToString();
                DatabaseHistory_ActionDetails_ActionDescription_TextBox.Text = row.Cells[1].Value.ToString();
                DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.Text = row.Cells[2].Value.ToString();
            }
            #endregion
        }

        private void DatabaseHistory_Logout_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Load_LoginScreen();
            #endregion
        }

        private void DatabaseHistory_Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region
            Application.Exit();
            #endregion
        }

        private void DatabaseHistory_Search_Button_Click(object sender, EventArgs e)
        {
            #region
            Search_DatabaseHistory_DataGridView(DatabaseHistory_Search_TextBox.Text);
            #endregion
        }

        private void DatabaseHistory_DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            #region
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DatabaseHistory_DataGridView.Rows[e.RowIndex];
                DatabaseHistory_ActionDetails_ActionID_TextBox.Text = row.Cells[0].Value.ToString();
                DatabaseHistory_ActionDetails_ActionDescription_TextBox.Text = row.Cells[1].Value.ToString();
                DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.Text = row.Cells[2].Value.ToString();
            }
            #endregion
        }

        private void DatabaseHistory_SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            #region
            if (e.KeyCode == Keys.Enter)
            {
                Search_DatabaseHistory_DataGridView(DatabaseHistory_Search_TextBox.Text);
            }
            #endregion
        }
        #endregion
    }
}
