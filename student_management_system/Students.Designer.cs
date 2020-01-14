namespace WindowsFormsApp1
{
    partial class Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Students_StudentDetails_StudentID_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_FirstName_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_Surname_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_County_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_Country_Label = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            this.Students_StudentDetails_StudentID_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_Course_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_Country_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_County_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_Surname_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_CompleteEdit_Button = new System.Windows.Forms.Button();
            this.Students_StudentDetails_Email_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_AddressLine1_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_AddressLine2_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_City_Label = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.Students_StudentDetails_PhoneNo_Label = new System.Windows.Forms.Label();
            this.Students_StudentDetails_Email_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_AddressLine1_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_AddressLine2_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_City_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_Level_TextBox = new System.Windows.Forms.TextBox();
            this.Students_StudentDetails_PhoneNo_TextBox = new System.Windows.Forms.TextBox();
            this.Students_DataGridView = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSStudentMSDatabaseDataSet = new WindowsFormsApp1.DBSStudentMSDatabaseDataSet();
            this.studentsTableAdapter = new WindowsFormsApp1.DBSStudentMSDatabaseDataSetTableAdapters.StudentsTableAdapter();
            this.Students_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Students_File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_Logout_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_New_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_Delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_ViewDatabaseHistory_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Students_LoginDetails_LoggedInAs_Label = new System.Windows.Forms.Label();
            this.Students_LoginDetails_LoggedInAs_TextBox = new System.Windows.Forms.TextBox();
            this.Students_LoginDetails_UserLevel_Label = new System.Windows.Forms.Label();
            this.Students_LoginDetails_UserLevel_TextBox = new System.Windows.Forms.TextBox();
            this.Students_Title_TextBox = new System.Windows.Forms.TextBox();
            this.Students_Search_GroupBox = new System.Windows.Forms.GroupBox();
            this.Students_Search_Button = new System.Windows.Forms.Button();
            this.Students_Search_TextBox = new System.Windows.Forms.TextBox();
            this.Students_Title_GroupBox = new System.Windows.Forms.GroupBox();
            this.Students_LoginDetails_GroupBox = new System.Windows.Forms.GroupBox();
            this.Students_StudentDetails_GroupBox = new System.Windows.Forms.GroupBox();
            this.Students_StudentDetails_Country_Dropdown = new System.Windows.Forms.ComboBox();
            this.Students_StudentDetails_Level_Dropdown = new System.Windows.Forms.ComboBox();
            this.Students_StudentDetails_County_Dropdown = new System.Windows.Forms.ComboBox();
            this.Students_StudentDetails_ExitEditMode_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Students_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSStudentMSDatabaseDataSet)).BeginInit();
            this.Students_MenuStrip.SuspendLayout();
            this.Students_Search_GroupBox.SuspendLayout();
            this.Students_Title_GroupBox.SuspendLayout();
            this.Students_LoginDetails_GroupBox.SuspendLayout();
            this.Students_StudentDetails_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students_StudentDetails_StudentID_Label
            // 
            this.Students_StudentDetails_StudentID_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_StudentID_Label.AutoSize = true;
            this.Students_StudentDetails_StudentID_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_StudentID_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_StudentID_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_StudentID_Label.Location = new System.Drawing.Point(11, 23);
            this.Students_StudentDetails_StudentID_Label.Name = "Students_StudentDetails_StudentID_Label";
            this.Students_StudentDetails_StudentID_Label.Size = new System.Drawing.Size(61, 15);
            this.Students_StudentDetails_StudentID_Label.TabIndex = 4;
            this.Students_StudentDetails_StudentID_Label.Text = "StudentID";
            // 
            // Students_StudentDetails_FirstName_Label
            // 
            this.Students_StudentDetails_FirstName_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_FirstName_Label.AutoSize = true;
            this.Students_StudentDetails_FirstName_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_FirstName_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_FirstName_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_FirstName_Label.Location = new System.Drawing.Point(300, 23);
            this.Students_StudentDetails_FirstName_Label.Name = "Students_StudentDetails_FirstName_Label";
            this.Students_StudentDetails_FirstName_Label.Size = new System.Drawing.Size(63, 15);
            this.Students_StudentDetails_FirstName_Label.TabIndex = 5;
            this.Students_StudentDetails_FirstName_Label.Text = "FirstName";
            // 
            // Students_StudentDetails_Surname_Label
            // 
            this.Students_StudentDetails_Surname_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Surname_Label.AutoSize = true;
            this.Students_StudentDetails_Surname_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_Surname_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_Surname_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_Surname_Label.Location = new System.Drawing.Point(634, 23);
            this.Students_StudentDetails_Surname_Label.Name = "Students_StudentDetails_Surname_Label";
            this.Students_StudentDetails_Surname_Label.Size = new System.Drawing.Size(54, 15);
            this.Students_StudentDetails_Surname_Label.TabIndex = 6;
            this.Students_StudentDetails_Surname_Label.Text = "Surname";
            // 
            // Students_StudentDetails_County_Label
            // 
            this.Students_StudentDetails_County_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_County_Label.AutoSize = true;
            this.Students_StudentDetails_County_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_County_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_County_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_County_Label.Location = new System.Drawing.Point(11, 116);
            this.Students_StudentDetails_County_Label.Name = "Students_StudentDetails_County_Label";
            this.Students_StudentDetails_County_Label.Size = new System.Drawing.Size(44, 15);
            this.Students_StudentDetails_County_Label.TabIndex = 7;
            this.Students_StudentDetails_County_Label.Text = "County";
            // 
            // Students_StudentDetails_Country_Label
            // 
            this.Students_StudentDetails_Country_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Country_Label.AutoSize = true;
            this.Students_StudentDetails_Country_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_Country_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_Country_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_Country_Label.Location = new System.Drawing.Point(953, 117);
            this.Students_StudentDetails_Country_Label.Name = "Students_StudentDetails_Country_Label";
            this.Students_StudentDetails_Country_Label.Size = new System.Drawing.Size(49, 15);
            this.Students_StudentDetails_Country_Label.TabIndex = 8;
            this.Students_StudentDetails_Country_Label.Text = "Country";
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Course.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.ForeColor = System.Drawing.SystemColors.Window;
            this.Course.Location = new System.Drawing.Point(634, 117);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(42, 15);
            this.Course.TabIndex = 9;
            this.Course.Text = "Course";
            // 
            // Students_StudentDetails_StudentID_TextBox
            // 
            this.Students_StudentDetails_StudentID_TextBox.Location = new System.Drawing.Point(78, 20);
            this.Students_StudentDetails_StudentID_TextBox.Name = "Students_StudentDetails_StudentID_TextBox";
            this.Students_StudentDetails_StudentID_TextBox.ReadOnly = true;
            this.Students_StudentDetails_StudentID_TextBox.Size = new System.Drawing.Size(208, 20);
            this.Students_StudentDetails_StudentID_TextBox.TabIndex = 10;
            // 
            // Students_StudentDetails_Course_TextBox
            // 
            this.Students_StudentDetails_Course_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Course_TextBox.Location = new System.Drawing.Point(682, 115);
            this.Students_StudentDetails_Course_TextBox.Name = "Students_StudentDetails_Course_TextBox";
            this.Students_StudentDetails_Course_TextBox.ReadOnly = true;
            this.Students_StudentDetails_Course_TextBox.Size = new System.Drawing.Size(263, 20);
            this.Students_StudentDetails_Course_TextBox.TabIndex = 11;
            // 
            // Students_StudentDetails_Country_TextBox
            // 
            this.Students_StudentDetails_Country_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Country_TextBox.Location = new System.Drawing.Point(1008, 114);
            this.Students_StudentDetails_Country_TextBox.Name = "Students_StudentDetails_Country_TextBox";
            this.Students_StudentDetails_Country_TextBox.ReadOnly = true;
            this.Students_StudentDetails_Country_TextBox.Size = new System.Drawing.Size(212, 20);
            this.Students_StudentDetails_Country_TextBox.TabIndex = 12;
            // 
            // Students_StudentDetails_County_TextBox
            // 
            this.Students_StudentDetails_County_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_County_TextBox.Location = new System.Drawing.Point(72, 113);
            this.Students_StudentDetails_County_TextBox.Name = "Students_StudentDetails_County_TextBox";
            this.Students_StudentDetails_County_TextBox.ReadOnly = true;
            this.Students_StudentDetails_County_TextBox.Size = new System.Drawing.Size(214, 20);
            this.Students_StudentDetails_County_TextBox.TabIndex = 13;
            // 
            // Students_StudentDetails_Surname_TextBox
            // 
            this.Students_StudentDetails_Surname_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Surname_TextBox.Location = new System.Drawing.Point(694, 20);
            this.Students_StudentDetails_Surname_TextBox.Name = "Students_StudentDetails_Surname_TextBox";
            this.Students_StudentDetails_Surname_TextBox.ReadOnly = true;
            this.Students_StudentDetails_Surname_TextBox.Size = new System.Drawing.Size(251, 20);
            this.Students_StudentDetails_Surname_TextBox.TabIndex = 14;
            // 
            // Students_StudentDetails_FirstName_TextBox
            // 
            this.Students_StudentDetails_FirstName_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_FirstName_TextBox.Location = new System.Drawing.Point(369, 20);
            this.Students_StudentDetails_FirstName_TextBox.Name = "Students_StudentDetails_FirstName_TextBox";
            this.Students_StudentDetails_FirstName_TextBox.ReadOnly = true;
            this.Students_StudentDetails_FirstName_TextBox.Size = new System.Drawing.Size(254, 20);
            this.Students_StudentDetails_FirstName_TextBox.TabIndex = 15;
            // 
            // Students_StudentDetails_CompleteEdit_Button
            // 
            this.Students_StudentDetails_CompleteEdit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_CompleteEdit_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_CompleteEdit_Button.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_CompleteEdit_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_CompleteEdit_Button.Location = new System.Drawing.Point(1109, 532);
            this.Students_StudentDetails_CompleteEdit_Button.Name = "Students_StudentDetails_CompleteEdit_Button";
            this.Students_StudentDetails_CompleteEdit_Button.Size = new System.Drawing.Size(140, 45);
            this.Students_StudentDetails_CompleteEdit_Button.TabIndex = 16;
            this.Students_StudentDetails_CompleteEdit_Button.Text = "Complete Edit";
            this.Students_StudentDetails_CompleteEdit_Button.UseVisualStyleBackColor = false;
            this.Students_StudentDetails_CompleteEdit_Button.Visible = false;
            this.Students_StudentDetails_CompleteEdit_Button.Click += new System.EventHandler(this.Students_StudentDetails_CompleteEdit_Button_Click);
            // 
            // Students_StudentDetails_Email_Label
            // 
            this.Students_StudentDetails_Email_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Email_Label.AutoSize = true;
            this.Students_StudentDetails_Email_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_Email_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_Email_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_Email_Label.Location = new System.Drawing.Point(953, 23);
            this.Students_StudentDetails_Email_Label.Name = "Students_StudentDetails_Email_Label";
            this.Students_StudentDetails_Email_Label.Size = new System.Drawing.Size(44, 15);
            this.Students_StudentDetails_Email_Label.TabIndex = 18;
            this.Students_StudentDetails_Email_Label.Text = "E-mail";
            // 
            // Students_StudentDetails_AddressLine1_Label
            // 
            this.Students_StudentDetails_AddressLine1_Label.AutoSize = true;
            this.Students_StudentDetails_AddressLine1_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_AddressLine1_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_AddressLine1_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_AddressLine1_Label.Location = new System.Drawing.Point(300, 68);
            this.Students_StudentDetails_AddressLine1_Label.Name = "Students_StudentDetails_AddressLine1_Label";
            this.Students_StudentDetails_AddressLine1_Label.Size = new System.Drawing.Size(79, 15);
            this.Students_StudentDetails_AddressLine1_Label.TabIndex = 19;
            this.Students_StudentDetails_AddressLine1_Label.Text = "AddressLine1";
            // 
            // Students_StudentDetails_AddressLine2_Label
            // 
            this.Students_StudentDetails_AddressLine2_Label.AutoSize = true;
            this.Students_StudentDetails_AddressLine2_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_AddressLine2_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_AddressLine2_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_AddressLine2_Label.Location = new System.Drawing.Point(634, 68);
            this.Students_StudentDetails_AddressLine2_Label.Name = "Students_StudentDetails_AddressLine2_Label";
            this.Students_StudentDetails_AddressLine2_Label.Size = new System.Drawing.Size(79, 15);
            this.Students_StudentDetails_AddressLine2_Label.TabIndex = 20;
            this.Students_StudentDetails_AddressLine2_Label.Text = "AddressLine2";
            // 
            // Students_StudentDetails_City_Label
            // 
            this.Students_StudentDetails_City_Label.AutoSize = true;
            this.Students_StudentDetails_City_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_City_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_City_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_City_Label.Location = new System.Drawing.Point(953, 68);
            this.Students_StudentDetails_City_Label.Name = "Students_StudentDetails_City_Label";
            this.Students_StudentDetails_City_Label.Size = new System.Drawing.Size(28, 15);
            this.Students_StudentDetails_City_Label.TabIndex = 21;
            this.Students_StudentDetails_City_Label.Text = "City";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LevelLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.LevelLabel.Location = new System.Drawing.Point(300, 117);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(36, 15);
            this.LevelLabel.TabIndex = 22;
            this.LevelLabel.Text = "Level";
            // 
            // Students_StudentDetails_PhoneNo_Label
            // 
            this.Students_StudentDetails_PhoneNo_Label.AutoSize = true;
            this.Students_StudentDetails_PhoneNo_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_PhoneNo_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_PhoneNo_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_PhoneNo_Label.Location = new System.Drawing.Point(11, 68);
            this.Students_StudentDetails_PhoneNo_Label.Name = "Students_StudentDetails_PhoneNo_Label";
            this.Students_StudentDetails_PhoneNo_Label.Size = new System.Drawing.Size(55, 15);
            this.Students_StudentDetails_PhoneNo_Label.TabIndex = 23;
            this.Students_StudentDetails_PhoneNo_Label.Text = "PhoneNo";
            // 
            // Students_StudentDetails_Email_TextBox
            // 
            this.Students_StudentDetails_Email_TextBox.Location = new System.Drawing.Point(1003, 20);
            this.Students_StudentDetails_Email_TextBox.Name = "Students_StudentDetails_Email_TextBox";
            this.Students_StudentDetails_Email_TextBox.ReadOnly = true;
            this.Students_StudentDetails_Email_TextBox.Size = new System.Drawing.Size(213, 20);
            this.Students_StudentDetails_Email_TextBox.TabIndex = 24;
            // 
            // Students_StudentDetails_AddressLine1_TextBox
            // 
            this.Students_StudentDetails_AddressLine1_TextBox.Location = new System.Drawing.Point(385, 65);
            this.Students_StudentDetails_AddressLine1_TextBox.Name = "Students_StudentDetails_AddressLine1_TextBox";
            this.Students_StudentDetails_AddressLine1_TextBox.ReadOnly = true;
            this.Students_StudentDetails_AddressLine1_TextBox.Size = new System.Drawing.Size(234, 20);
            this.Students_StudentDetails_AddressLine1_TextBox.TabIndex = 25;
            // 
            // Students_StudentDetails_AddressLine2_TextBox
            // 
            this.Students_StudentDetails_AddressLine2_TextBox.Location = new System.Drawing.Point(719, 65);
            this.Students_StudentDetails_AddressLine2_TextBox.Name = "Students_StudentDetails_AddressLine2_TextBox";
            this.Students_StudentDetails_AddressLine2_TextBox.ReadOnly = true;
            this.Students_StudentDetails_AddressLine2_TextBox.Size = new System.Drawing.Size(222, 20);
            this.Students_StudentDetails_AddressLine2_TextBox.TabIndex = 26;
            // 
            // Students_StudentDetails_City_TextBox
            // 
            this.Students_StudentDetails_City_TextBox.Location = new System.Drawing.Point(987, 65);
            this.Students_StudentDetails_City_TextBox.Name = "Students_StudentDetails_City_TextBox";
            this.Students_StudentDetails_City_TextBox.ReadOnly = true;
            this.Students_StudentDetails_City_TextBox.Size = new System.Drawing.Size(229, 20);
            this.Students_StudentDetails_City_TextBox.TabIndex = 27;
            // 
            // Students_StudentDetails_Level_TextBox
            // 
            this.Students_StudentDetails_Level_TextBox.Location = new System.Drawing.Point(342, 114);
            this.Students_StudentDetails_Level_TextBox.Name = "Students_StudentDetails_Level_TextBox";
            this.Students_StudentDetails_Level_TextBox.ReadOnly = true;
            this.Students_StudentDetails_Level_TextBox.Size = new System.Drawing.Size(277, 20);
            this.Students_StudentDetails_Level_TextBox.TabIndex = 28;
            // 
            // Students_StudentDetails_PhoneNo_TextBox
            // 
            this.Students_StudentDetails_PhoneNo_TextBox.Location = new System.Drawing.Point(72, 65);
            this.Students_StudentDetails_PhoneNo_TextBox.Name = "Students_StudentDetails_PhoneNo_TextBox";
            this.Students_StudentDetails_PhoneNo_TextBox.ReadOnly = true;
            this.Students_StudentDetails_PhoneNo_TextBox.Size = new System.Drawing.Size(214, 20);
            this.Students_StudentDetails_PhoneNo_TextBox.TabIndex = 29;
            // 
            // Students_DataGridView
            // 
            this.Students_DataGridView.AllowUserToAddRows = false;
            this.Students_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_DataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Students_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students_DataGridView.Location = new System.Drawing.Point(16, 367);
            this.Students_DataGridView.Name = "Students_DataGridView";
            this.Students_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Students_DataGridView.Size = new System.Drawing.Size(1233, 149);
            this.Students_DataGridView.TabIndex = 30;
            this.Students_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Students_DataGridView_CellClick);
            this.Students_DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Students_DataGridView_RowEnter);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dBSStudentMSDatabaseDataSet;
            // 
            // dBSStudentMSDatabaseDataSet
            // 
            this.dBSStudentMSDatabaseDataSet.DataSetName = "DBSStudentMSDatabaseDataSet";
            this.dBSStudentMSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // Students_MenuStrip
            // 
            this.Students_MenuStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_MenuStrip.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Students_File_ToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.Students_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Students_MenuStrip.Name = "Students_MenuStrip";
            this.Students_MenuStrip.Size = new System.Drawing.Size(1261, 24);
            this.Students_MenuStrip.TabIndex = 32;
            this.Students_MenuStrip.Text = "menuStrip1";
            // 
            // Students_File_ToolStripMenuItem
            // 
            this.Students_File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Students_Logout_ToolStripMenuItem,
            this.Students_Exit_ToolStripMenuItem});
            this.Students_File_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_File_ToolStripMenuItem.Name = "Students_File_ToolStripMenuItem";
            this.Students_File_ToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.Students_File_ToolStripMenuItem.Text = "File";
            // 
            // Students_Logout_ToolStripMenuItem
            // 
            this.Students_Logout_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_Logout_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_Logout_ToolStripMenuItem.Name = "Students_Logout_ToolStripMenuItem";
            this.Students_Logout_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.Students_Logout_ToolStripMenuItem.Text = "Logout";
            this.Students_Logout_ToolStripMenuItem.Click += new System.EventHandler(this.Students_Logout_ToolStripMenuItem_Click);
            // 
            // Students_Exit_ToolStripMenuItem
            // 
            this.Students_Exit_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_Exit_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_Exit_ToolStripMenuItem.Name = "Students_Exit_ToolStripMenuItem";
            this.Students_Exit_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.Students_Exit_ToolStripMenuItem.Text = "Exit";
            this.Students_Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Students_Exit_ToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Students_New_ToolStripMenuItem,
            this.Students_Edit_ToolStripMenuItem,
            this.Students_Delete_ToolStripMenuItem,
            this.Students_ViewDatabaseHistory_ToolStripMenuItem});
            this.studentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // Students_New_ToolStripMenuItem
            // 
            this.Students_New_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_New_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_New_ToolStripMenuItem.Name = "Students_New_ToolStripMenuItem";
            this.Students_New_ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.Students_New_ToolStripMenuItem.Text = "New";
            this.Students_New_ToolStripMenuItem.Click += new System.EventHandler(this.Students_New_ToolStripMenuItem_Click);
            // 
            // Students_Edit_ToolStripMenuItem
            // 
            this.Students_Edit_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_Edit_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_Edit_ToolStripMenuItem.Name = "Students_Edit_ToolStripMenuItem";
            this.Students_Edit_ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.Students_Edit_ToolStripMenuItem.Text = "Edit";
            this.Students_Edit_ToolStripMenuItem.Click += new System.EventHandler(this.Students_Edit_ToolStripMenuItem_Click);
            // 
            // Students_Delete_ToolStripMenuItem
            // 
            this.Students_Delete_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_Delete_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_Delete_ToolStripMenuItem.Name = "Students_Delete_ToolStripMenuItem";
            this.Students_Delete_ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.Students_Delete_ToolStripMenuItem.Text = "Delete ";
            this.Students_Delete_ToolStripMenuItem.Click += new System.EventHandler(this.Students_Delete_ToolStripMenuItem_Click);
            // 
            // Students_ViewDatabaseHistory_ToolStripMenuItem
            // 
            this.Students_ViewDatabaseHistory_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_ViewDatabaseHistory_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_ViewDatabaseHistory_ToolStripMenuItem.Name = "Students_ViewDatabaseHistory_ToolStripMenuItem";
            this.Students_ViewDatabaseHistory_ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.Students_ViewDatabaseHistory_ToolStripMenuItem.Text = "View Database History";
            this.Students_ViewDatabaseHistory_ToolStripMenuItem.Click += new System.EventHandler(this.Students_ViewDatabaseHistory_ToolStripMenuItem_Click);
            // 
            // Students_LoginDetails_LoggedInAs_Label
            // 
            this.Students_LoginDetails_LoggedInAs_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_LoginDetails_LoggedInAs_Label.AutoSize = true;
            this.Students_LoginDetails_LoggedInAs_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_LoginDetails_LoggedInAs_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_LoginDetails_LoggedInAs_Label.Location = new System.Drawing.Point(14, 20);
            this.Students_LoginDetails_LoggedInAs_Label.Name = "Students_LoginDetails_LoggedInAs_Label";
            this.Students_LoginDetails_LoggedInAs_Label.Size = new System.Drawing.Size(79, 15);
            this.Students_LoginDetails_LoggedInAs_Label.TabIndex = 33;
            this.Students_LoginDetails_LoggedInAs_Label.Text = "Logged In As";
            // 
            // Students_LoginDetails_LoggedInAs_TextBox
            // 
            this.Students_LoginDetails_LoggedInAs_TextBox.Location = new System.Drawing.Point(103, 18);
            this.Students_LoginDetails_LoggedInAs_TextBox.Name = "Students_LoginDetails_LoggedInAs_TextBox";
            this.Students_LoginDetails_LoggedInAs_TextBox.ReadOnly = true;
            this.Students_LoginDetails_LoggedInAs_TextBox.Size = new System.Drawing.Size(123, 20);
            this.Students_LoginDetails_LoggedInAs_TextBox.TabIndex = 34;
            // 
            // Students_LoginDetails_UserLevel_Label
            // 
            this.Students_LoginDetails_UserLevel_Label.AutoSize = true;
            this.Students_LoginDetails_UserLevel_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_LoginDetails_UserLevel_Label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_LoginDetails_UserLevel_Label.Location = new System.Drawing.Point(14, 52);
            this.Students_LoginDetails_UserLevel_Label.Name = "Students_LoginDetails_UserLevel_Label";
            this.Students_LoginDetails_UserLevel_Label.Size = new System.Drawing.Size(64, 15);
            this.Students_LoginDetails_UserLevel_Label.TabIndex = 51;
            this.Students_LoginDetails_UserLevel_Label.Text = "User Level";
            // 
            // Students_LoginDetails_UserLevel_TextBox
            // 
            this.Students_LoginDetails_UserLevel_TextBox.Location = new System.Drawing.Point(90, 49);
            this.Students_LoginDetails_UserLevel_TextBox.Name = "Students_LoginDetails_UserLevel_TextBox";
            this.Students_LoginDetails_UserLevel_TextBox.ReadOnly = true;
            this.Students_LoginDetails_UserLevel_TextBox.Size = new System.Drawing.Size(136, 20);
            this.Students_LoginDetails_UserLevel_TextBox.TabIndex = 52;
            // 
            // Students_Title_TextBox
            // 
            this.Students_Title_TextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_Title_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Students_Title_TextBox.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_Title_TextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_Title_TextBox.Location = new System.Drawing.Point(19, 12);
            this.Students_Title_TextBox.Name = "Students_Title_TextBox";
            this.Students_Title_TextBox.Size = new System.Drawing.Size(302, 52);
            this.Students_Title_TextBox.TabIndex = 53;
            this.Students_Title_TextBox.Text = "Students";
            this.Students_Title_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Students_Search_GroupBox
            // 
            this.Students_Search_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_Search_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Students_Search_GroupBox.Controls.Add(this.Students_Search_Button);
            this.Students_Search_GroupBox.Controls.Add(this.Students_Search_TextBox);
            this.Students_Search_GroupBox.Location = new System.Drawing.Point(99, 74);
            this.Students_Search_GroupBox.Name = "Students_Search_GroupBox";
            this.Students_Search_GroupBox.Size = new System.Drawing.Size(267, 61);
            this.Students_Search_GroupBox.TabIndex = 54;
            this.Students_Search_GroupBox.TabStop = false;
            // 
            // Students_Search_Button
            // 
            this.Students_Search_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_Search_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_Search_Button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_Search_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_Search_Button.Location = new System.Drawing.Point(11, 17);
            this.Students_Search_Button.Name = "Students_Search_Button";
            this.Students_Search_Button.Size = new System.Drawing.Size(67, 27);
            this.Students_Search_Button.TabIndex = 5;
            this.Students_Search_Button.Text = "Search";
            this.Students_Search_Button.UseVisualStyleBackColor = false;
            this.Students_Search_Button.Click += new System.EventHandler(this.Students_Search_Button_Click_1);
            // 
            // Students_Search_TextBox
            // 
            this.Students_Search_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_Search_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Students_Search_TextBox.Location = new System.Drawing.Point(95, 23);
            this.Students_Search_TextBox.Name = "Students_Search_TextBox";
            this.Students_Search_TextBox.Size = new System.Drawing.Size(161, 13);
            this.Students_Search_TextBox.TabIndex = 4;
            this.Students_Search_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Students_Search_TextBox_KeyDown);
            // 
            // Students_Title_GroupBox
            // 
            this.Students_Title_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_Title_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Students_Title_GroupBox.Controls.Add(this.Students_Title_TextBox);
            this.Students_Title_GroupBox.Location = new System.Drawing.Point(472, 62);
            this.Students_Title_GroupBox.Name = "Students_Title_GroupBox";
            this.Students_Title_GroupBox.Size = new System.Drawing.Size(338, 80);
            this.Students_Title_GroupBox.TabIndex = 55;
            this.Students_Title_GroupBox.TabStop = false;
            // 
            // Students_LoginDetails_GroupBox
            // 
            this.Students_LoginDetails_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_LoginDetails_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Students_LoginDetails_GroupBox.Controls.Add(this.Students_LoginDetails_UserLevel_TextBox);
            this.Students_LoginDetails_GroupBox.Controls.Add(this.Students_LoginDetails_UserLevel_Label);
            this.Students_LoginDetails_GroupBox.Controls.Add(this.Students_LoginDetails_LoggedInAs_TextBox);
            this.Students_LoginDetails_GroupBox.Controls.Add(this.Students_LoginDetails_LoggedInAs_Label);
            this.Students_LoginDetails_GroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_LoginDetails_GroupBox.Location = new System.Drawing.Point(1006, 36);
            this.Students_LoginDetails_GroupBox.Name = "Students_LoginDetails_GroupBox";
            this.Students_LoginDetails_GroupBox.Size = new System.Drawing.Size(243, 88);
            this.Students_LoginDetails_GroupBox.TabIndex = 56;
            this.Students_LoginDetails_GroupBox.TabStop = false;
            // 
            // Students_StudentDetails_GroupBox
            // 
            this.Students_StudentDetails_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Country_Dropdown);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Level_Dropdown);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_County_Dropdown);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_PhoneNo_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Level_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_City_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_AddressLine2_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_AddressLine1_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Email_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_PhoneNo_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.LevelLabel);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_City_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_AddressLine2_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_AddressLine1_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Email_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_FirstName_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Surname_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_County_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Country_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Course_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_StudentID_TextBox);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Course);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Country_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_County_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_Surname_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_FirstName_Label);
            this.Students_StudentDetails_GroupBox.Controls.Add(this.Students_StudentDetails_StudentID_Label);
            this.Students_StudentDetails_GroupBox.Location = new System.Drawing.Point(12, 185);
            this.Students_StudentDetails_GroupBox.Name = "Students_StudentDetails_GroupBox";
            this.Students_StudentDetails_GroupBox.Size = new System.Drawing.Size(1237, 157);
            this.Students_StudentDetails_GroupBox.TabIndex = 57;
            this.Students_StudentDetails_GroupBox.TabStop = false;
            // 
            // Students_StudentDetails_Country_Dropdown
            // 
            this.Students_StudentDetails_Country_Dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Country_Dropdown.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antigua & Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia & Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "China - Hong Kong / Macau",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo, Democratic Republic of (DRC)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "French Guiana",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Great Britain",
            "Greece",
            "Grenada",
            "Guadeloupe",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel and the Occupied Territories",
            "Italy",
            "Ivory Coast (Cote d\'Ivoire)",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Korea, Democratic Republic of (North Korea)",
            "Korea, Republic of (South Korea)",
            "Kosovo",
            "Kuwait",
            "Kyrgyz Republic (Kyrgyzstan)",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Moldova, Republic of",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar/Burma",
            "Namibia",
            "Nepal",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia, Republic of",
            "Norway",
            "Oman",
            "Pacific Islands",
            "Pakistan",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovak Republic (Slovakia)",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Netherlands",
            "Timor Leste",
            "Togo",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks & Caicos Islands",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United States of America (USA)",
            "Uruguay",
            "Uzbekistan",
            "Venezuela",
            "Vietnam",
            "Virgin Islands (UK)",
            "Virgin Islands (US)",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.Students_StudentDetails_Country_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Students_StudentDetails_Country_Dropdown.FormattingEnabled = true;
            this.Students_StudentDetails_Country_Dropdown.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antigua & Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia & Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "China - Hong Kong / Macau",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo, Democratic Republic of (DRC)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "French Guiana",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Great Britain",
            "Greece",
            "Grenada",
            "Guadeloupe",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel and the Occupied Territories",
            "Italy",
            "Ivory Coast (Cote d\'Ivoire)",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Korea, Democratic Republic of (North Korea)",
            "Korea, Republic of (South Korea)",
            "Kosovo",
            "Kuwait",
            "Kyrgyz Republic (Kyrgyzstan)",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Moldova, Republic of",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar/Burma",
            "Namibia",
            "Nepal",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia, Republic of",
            "Norway",
            "Oman",
            "Pacific Islands",
            "Pakistan",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovak Republic (Slovakia)",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Netherlands",
            "Timor Leste",
            "Togo",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks & Caicos Islands",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United States of America (USA)",
            "Uruguay",
            "Uzbekistan",
            "Venezuela",
            "Vietnam",
            "Virgin Islands (UK)",
            "Virgin Islands (US)",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.Students_StudentDetails_Country_Dropdown.Location = new System.Drawing.Point(1008, 114);
            this.Students_StudentDetails_Country_Dropdown.Name = "Students_StudentDetails_Country_Dropdown";
            this.Students_StudentDetails_Country_Dropdown.Size = new System.Drawing.Size(212, 21);
            this.Students_StudentDetails_Country_Dropdown.TabIndex = 59;
            this.Students_StudentDetails_Country_Dropdown.Visible = false;
            // 
            // Students_StudentDetails_Level_Dropdown
            // 
            this.Students_StudentDetails_Level_Dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_Level_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Students_StudentDetails_Level_Dropdown.FormattingEnabled = true;
            this.Students_StudentDetails_Level_Dropdown.Items.AddRange(new object[] {
            "Undergraduate",
            "Postgraduate"});
            this.Students_StudentDetails_Level_Dropdown.Location = new System.Drawing.Point(342, 115);
            this.Students_StudentDetails_Level_Dropdown.Name = "Students_StudentDetails_Level_Dropdown";
            this.Students_StudentDetails_Level_Dropdown.Size = new System.Drawing.Size(277, 21);
            this.Students_StudentDetails_Level_Dropdown.TabIndex = 58;
            this.Students_StudentDetails_Level_Dropdown.Visible = false;
            // 
            // Students_StudentDetails_County_Dropdown
            // 
            this.Students_StudentDetails_County_Dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_County_Dropdown.BackColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_County_Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Students_StudentDetails_County_Dropdown.FormattingEnabled = true;
            this.Students_StudentDetails_County_Dropdown.Items.AddRange(new object[] {
            "",
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.Students_StudentDetails_County_Dropdown.Location = new System.Drawing.Point(61, 113);
            this.Students_StudentDetails_County_Dropdown.Name = "Students_StudentDetails_County_Dropdown";
            this.Students_StudentDetails_County_Dropdown.Size = new System.Drawing.Size(225, 21);
            this.Students_StudentDetails_County_Dropdown.TabIndex = 57;
            this.Students_StudentDetails_County_Dropdown.Visible = false;
            // 
            // Students_StudentDetails_ExitEditMode_Button
            // 
            this.Students_StudentDetails_ExitEditMode_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Students_StudentDetails_ExitEditMode_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Students_StudentDetails_ExitEditMode_Button.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students_StudentDetails_ExitEditMode_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Students_StudentDetails_ExitEditMode_Button.Location = new System.Drawing.Point(940, 532);
            this.Students_StudentDetails_ExitEditMode_Button.Name = "Students_StudentDetails_ExitEditMode_Button";
            this.Students_StudentDetails_ExitEditMode_Button.Size = new System.Drawing.Size(144, 45);
            this.Students_StudentDetails_ExitEditMode_Button.TabIndex = 58;
            this.Students_StudentDetails_ExitEditMode_Button.Text = "Exit Edit Mode";
            this.Students_StudentDetails_ExitEditMode_Button.UseVisualStyleBackColor = false;
            this.Students_StudentDetails_ExitEditMode_Button.Visible = false;
            this.Students_StudentDetails_ExitEditMode_Button.Click += new System.EventHandler(this.Students_StudentDetails_ExitEditMode_Button_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1261, 589);
            this.Controls.Add(this.Students_StudentDetails_ExitEditMode_Button);
            this.Controls.Add(this.Students_StudentDetails_GroupBox);
            this.Controls.Add(this.Students_LoginDetails_GroupBox);
            this.Controls.Add(this.Students_Title_GroupBox);
            this.Controls.Add(this.Students_Search_GroupBox);
            this.Controls.Add(this.Students_DataGridView);
            this.Controls.Add(this.Students_StudentDetails_CompleteEdit_Button);
            this.Controls.Add(this.Students_MenuStrip);
            this.MainMenuStrip = this.Students_MenuStrip;
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Students_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSStudentMSDatabaseDataSet)).EndInit();
            this.Students_MenuStrip.ResumeLayout(false);
            this.Students_MenuStrip.PerformLayout();
            this.Students_Search_GroupBox.ResumeLayout(false);
            this.Students_Search_GroupBox.PerformLayout();
            this.Students_Title_GroupBox.ResumeLayout(false);
            this.Students_Title_GroupBox.PerformLayout();
            this.Students_LoginDetails_GroupBox.ResumeLayout(false);
            this.Students_LoginDetails_GroupBox.PerformLayout();
            this.Students_StudentDetails_GroupBox.ResumeLayout(false);
            this.Students_StudentDetails_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Students_StudentDetails_StudentID_Label;
        private System.Windows.Forms.Label Students_StudentDetails_FirstName_Label;
        private System.Windows.Forms.Label Students_StudentDetails_Surname_Label;
        private System.Windows.Forms.Label Students_StudentDetails_County_Label;
        private System.Windows.Forms.Label Students_StudentDetails_Country_Label;
        private System.Windows.Forms.Label Course;
        private System.Windows.Forms.Button Students_StudentDetails_CompleteEdit_Button;
        private System.Windows.Forms.Label Students_StudentDetails_Email_Label;
        private System.Windows.Forms.Label Students_StudentDetails_AddressLine1_Label;
        private System.Windows.Forms.Label Students_StudentDetails_AddressLine2_Label;
        private System.Windows.Forms.Label Students_StudentDetails_City_Label;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label Students_StudentDetails_PhoneNo_Label;
        private System.Windows.Forms.DataGridView Students_DataGridView;
        private DBSStudentMSDatabaseDataSet dBSStudentMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DBSStudentMSDatabaseDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        public System.Windows.Forms.TextBox Students_StudentDetails_StudentID_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_Course_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_Country_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_County_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_Surname_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_FirstName_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_Email_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_AddressLine1_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_AddressLine2_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_City_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_Level_TextBox;
        public System.Windows.Forms.TextBox Students_StudentDetails_PhoneNo_TextBox;
        private System.Windows.Forms.MenuStrip Students_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Students_File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Students_Logout_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Students_Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Students_New_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Students_Edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Students_Delete_ToolStripMenuItem;
        private System.Windows.Forms.Label Students_LoginDetails_LoggedInAs_Label;
        public System.Windows.Forms.TextBox Students_LoginDetails_LoggedInAs_TextBox;
        private System.Windows.Forms.ToolStripMenuItem Students_ViewDatabaseHistory_ToolStripMenuItem;
        private System.Windows.Forms.Label Students_LoginDetails_UserLevel_Label;
        private System.Windows.Forms.TextBox Students_LoginDetails_UserLevel_TextBox;
        private System.Windows.Forms.TextBox Students_Title_TextBox;
        private System.Windows.Forms.GroupBox Students_Search_GroupBox;
        private System.Windows.Forms.Button Students_Search_Button;
        private System.Windows.Forms.TextBox Students_Search_TextBox;
        private System.Windows.Forms.GroupBox Students_Title_GroupBox;
        private System.Windows.Forms.GroupBox Students_LoginDetails_GroupBox;
        private System.Windows.Forms.GroupBox Students_StudentDetails_GroupBox;
        private System.Windows.Forms.ComboBox Students_StudentDetails_County_Dropdown;
        private System.Windows.Forms.ComboBox Students_StudentDetails_Country_Dropdown;
        private System.Windows.Forms.Button Students_StudentDetails_ExitEditMode_Button;
        private System.Windows.Forms.ComboBox Students_StudentDetails_Level_Dropdown;
    }
}