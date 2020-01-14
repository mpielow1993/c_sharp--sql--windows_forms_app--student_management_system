namespace WindowsFormsApp1
{
    partial class DatabaseHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatabaseHistory_DataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DatabaseHistory_FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseHistory_MainMenu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseHistory_Logout_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseHistory_Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label = new System.Windows.Forms.Label();
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox = new System.Windows.Forms.TextBox();
            this.DatabaseHistory_LoginDetails_UserLevel_Label = new System.Windows.Forms.Label();
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox = new System.Windows.Forms.TextBox();
            this.DatabaseHistory_LoginDetails_GroupBox = new System.Windows.Forms.GroupBox();
            this.DatabaseHistory_Search_TextBox = new System.Windows.Forms.TextBox();
            this.DatabaseHistory_ActionDetails_ActionID_Label = new System.Windows.Forms.Label();
            this.DatabaseHistory_ActionDetails_ActionDescription_Label = new System.Windows.Forms.Label();
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label = new System.Windows.Forms.Label();
            this.DatabaseHistory_ActionDetails_ActionID_TextBox = new System.Windows.Forms.TextBox();
            this.DatabaseHistory_ActionDetails_ActionDescription_TextBox = new System.Windows.Forms.TextBox();
            this.DatabaseHistory_ActionDetails_PerformedByUsername_TextBox = new System.Windows.Forms.TextBox();
            this.DatabaseHistory_Search_Button = new System.Windows.Forms.Button();
            this.DatabaseHistory_ActionDetails_GroupBox = new System.Windows.Forms.GroupBox();
            this.DatabaseHistory_Title_GroupBox = new System.Windows.Forms.GroupBox();
            this.DatabaseHistory_Title_TextBox = new System.Windows.Forms.TextBox();
            this.DatavaseHistory_Search_GroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseHistory_DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.DatabaseHistory_LoginDetails_GroupBox.SuspendLayout();
            this.DatabaseHistory_ActionDetails_GroupBox.SuspendLayout();
            this.DatabaseHistory_Title_GroupBox.SuspendLayout();
            this.DatavaseHistory_Search_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseHistory_DataGridView
            // 
            this.DatabaseHistory_DataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatabaseHistory_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DatabaseHistory_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseHistory_DataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DatabaseHistory_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseHistory_DataGridView.Location = new System.Drawing.Point(23, 233);
            this.DatabaseHistory_DataGridView.Name = "DatabaseHistory_DataGridView";
            this.DatabaseHistory_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatabaseHistory_DataGridView.Size = new System.Drawing.Size(874, 276);
            this.DatabaseHistory_DataGridView.TabIndex = 9;
            this.DatabaseHistory_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatabaseHistory_DataGridView_CellClick);
            this.DatabaseHistory_DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatabaseHistory_DataGridView_RowEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatabaseHistory_FileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DatabaseHistory_FileToolStripMenuItem
            // 
            this.DatabaseHistory_FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatabaseHistory_MainMenu_ToolStripMenuItem,
            this.DatabaseHistory_Logout_ToolStripMenuItem,
            this.DatabaseHistory_Exit_ToolStripMenuItem});
            this.DatabaseHistory_FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_FileToolStripMenuItem.Name = "DatabaseHistory_FileToolStripMenuItem";
            this.DatabaseHistory_FileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.DatabaseHistory_FileToolStripMenuItem.Text = "File";
            // 
            // DatabaseHistory_MainMenu_ToolStripMenuItem
            // 
            this.DatabaseHistory_MainMenu_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_MainMenu_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_MainMenu_ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.DatabaseHistory_MainMenu_ToolStripMenuItem.Name = "DatabaseHistory_MainMenu_ToolStripMenuItem";
            this.DatabaseHistory_MainMenu_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DatabaseHistory_MainMenu_ToolStripMenuItem.Text = "Main Menu";
            this.DatabaseHistory_MainMenu_ToolStripMenuItem.Click += new System.EventHandler(this.DatabaseHistory_MainMenu_ToolStripMenuItem_Click);
            // 
            // DatabaseHistory_Logout_ToolStripMenuItem
            // 
            this.DatabaseHistory_Logout_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_Logout_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_Logout_ToolStripMenuItem.Name = "DatabaseHistory_Logout_ToolStripMenuItem";
            this.DatabaseHistory_Logout_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DatabaseHistory_Logout_ToolStripMenuItem.Text = "Logout";
            this.DatabaseHistory_Logout_ToolStripMenuItem.Click += new System.EventHandler(this.DatabaseHistory_Logout_ToolStripMenuItem_Click);
            // 
            // DatabaseHistory_Exit_ToolStripMenuItem
            // 
            this.DatabaseHistory_Exit_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_Exit_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_Exit_ToolStripMenuItem.Name = "DatabaseHistory_Exit_ToolStripMenuItem";
            this.DatabaseHistory_Exit_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DatabaseHistory_Exit_ToolStripMenuItem.Text = "Exit";
            this.DatabaseHistory_Exit_ToolStripMenuItem.Click += new System.EventHandler(this.DatabaseHistory_Exit_ToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // DatabaseHistory_DeleteRecord_ToolStripMenuItem
            // 
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem.Name = "DatabaseHistory_DeleteRecord_ToolStripMenuItem";
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem.Text = "Delete Record";
            this.DatabaseHistory_DeleteRecord_ToolStripMenuItem.Click += new System.EventHandler(this.DatabaseHistory_DeleteRecord_ToolStripMenuItem_Click);
            // 
            // DatabaseHistory_LoginDetails_LoggedInAs_Label
            // 
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.AutoSize = true;
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.ForeColor = System.Drawing.Color.White;
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.Location = new System.Drawing.Point(16, 15);
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.Name = "DatabaseHistory_LoginDetails_LoggedInAs_Label";
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.Size = new System.Drawing.Size(69, 14);
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.TabIndex = 11;
            this.DatabaseHistory_LoginDetails_LoggedInAs_Label.Text = "Logged In As";
            // 
            // DatabaseHistory_LoginDetails_LoggedInAs_TextBox
            // 
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Location = new System.Drawing.Point(91, 15);
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Name = "DatabaseHistory_LoginDetails_LoggedInAs_TextBox";
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox.Size = new System.Drawing.Size(100, 14);
            this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox.TabIndex = 12;
            // 
            // DatabaseHistory_LoginDetails_UserLevel_Label
            // 
            this.DatabaseHistory_LoginDetails_UserLevel_Label.AutoSize = true;
            this.DatabaseHistory_LoginDetails_UserLevel_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_LoginDetails_UserLevel_Label.ForeColor = System.Drawing.Color.White;
            this.DatabaseHistory_LoginDetails_UserLevel_Label.Location = new System.Drawing.Point(18, 39);
            this.DatabaseHistory_LoginDetails_UserLevel_Label.Name = "DatabaseHistory_LoginDetails_UserLevel_Label";
            this.DatabaseHistory_LoginDetails_UserLevel_Label.Size = new System.Drawing.Size(57, 14);
            this.DatabaseHistory_LoginDetails_UserLevel_Label.TabIndex = 51;
            this.DatabaseHistory_LoginDetails_UserLevel_Label.Text = "User Level";
            // 
            // DatabaseHistory_LoginDetails_UserLevel_TextBox
            // 
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox.Location = new System.Drawing.Point(81, 39);
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox.Name = "DatabaseHistory_LoginDetails_UserLevel_TextBox";
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox.Size = new System.Drawing.Size(110, 14);
            this.DatabaseHistory_LoginDetails_UserLevel_TextBox.TabIndex = 52;
            // 
            // DatabaseHistory_LoginDetails_GroupBox
            // 
            this.DatabaseHistory_LoginDetails_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseHistory_LoginDetails_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DatabaseHistory_LoginDetails_GroupBox.Controls.Add(this.DatabaseHistory_LoginDetails_UserLevel_TextBox);
            this.DatabaseHistory_LoginDetails_GroupBox.Controls.Add(this.DatabaseHistory_LoginDetails_UserLevel_Label);
            this.DatabaseHistory_LoginDetails_GroupBox.Controls.Add(this.DatabaseHistory_LoginDetails_LoggedInAs_TextBox);
            this.DatabaseHistory_LoginDetails_GroupBox.Controls.Add(this.DatabaseHistory_LoginDetails_LoggedInAs_Label);
            this.DatabaseHistory_LoginDetails_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseHistory_LoginDetails_GroupBox.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_LoginDetails_GroupBox.ForeColor = System.Drawing.Color.Black;
            this.DatabaseHistory_LoginDetails_GroupBox.Location = new System.Drawing.Point(693, 42);
            this.DatabaseHistory_LoginDetails_GroupBox.Name = "DatabaseHistory_LoginDetails_GroupBox";
            this.DatabaseHistory_LoginDetails_GroupBox.Size = new System.Drawing.Size(204, 67);
            this.DatabaseHistory_LoginDetails_GroupBox.TabIndex = 53;
            this.DatabaseHistory_LoginDetails_GroupBox.TabStop = false;
            // 
            // DatabaseHistory_Search_TextBox
            // 
            this.DatabaseHistory_Search_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseHistory_Search_TextBox.Location = new System.Drawing.Point(96, 24);
            this.DatabaseHistory_Search_TextBox.Name = "DatabaseHistory_Search_TextBox";
            this.DatabaseHistory_Search_TextBox.Size = new System.Drawing.Size(150, 13);
            this.DatabaseHistory_Search_TextBox.TabIndex = 2;
            this.DatabaseHistory_Search_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatabaseHistory_SearchTextBox_KeyDown);
            // 
            // DatabaseHistory_ActionDetails_ActionID_Label
            // 
            this.DatabaseHistory_ActionDetails_ActionID_Label.AutoSize = true;
            this.DatabaseHistory_ActionDetails_ActionID_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_ActionDetails_ActionID_Label.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_ActionDetails_ActionID_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_ActionDetails_ActionID_Label.Location = new System.Drawing.Point(14, 19);
            this.DatabaseHistory_ActionDetails_ActionID_Label.Name = "DatabaseHistory_ActionDetails_ActionID_Label";
            this.DatabaseHistory_ActionDetails_ActionID_Label.Size = new System.Drawing.Size(51, 14);
            this.DatabaseHistory_ActionDetails_ActionID_Label.TabIndex = 3;
            this.DatabaseHistory_ActionDetails_ActionID_Label.Text = "ActionID";
            // 
            // DatabaseHistory_ActionDetails_ActionDescription_Label
            // 
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.AutoSize = true;
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.Location = new System.Drawing.Point(14, 57);
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.Name = "DatabaseHistory_ActionDetails_ActionDescription_Label";
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.Size = new System.Drawing.Size(92, 14);
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.TabIndex = 4;
            this.DatabaseHistory_ActionDetails_ActionDescription_Label.Text = "ActionDescription";
            // 
            // DatabaseHistory_ActionDetails_PerformedByUsername_Label
            // 
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.AutoSize = true;
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.Location = new System.Drawing.Point(560, 19);
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.Name = "DatabaseHistory_ActionDetails_PerformedByUsername_Label";
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.Size = new System.Drawing.Size(114, 14);
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.TabIndex = 5;
            this.DatabaseHistory_ActionDetails_PerformedByUsername_Label.Text = "PeformedByUsername";
            // 
            // DatabaseHistory_ActionDetails_ActionID_TextBox
            // 
            this.DatabaseHistory_ActionDetails_ActionID_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseHistory_ActionDetails_ActionID_TextBox.Location = new System.Drawing.Point(71, 19);
            this.DatabaseHistory_ActionDetails_ActionID_TextBox.Name = "DatabaseHistory_ActionDetails_ActionID_TextBox";
            this.DatabaseHistory_ActionDetails_ActionID_TextBox.Size = new System.Drawing.Size(129, 13);
            this.DatabaseHistory_ActionDetails_ActionID_TextBox.TabIndex = 6;
            // 
            // DatabaseHistory_ActionDetails_ActionDescription_TextBox
            // 
            this.DatabaseHistory_ActionDetails_ActionDescription_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseHistory_ActionDetails_ActionDescription_TextBox.Location = new System.Drawing.Point(116, 54);
            this.DatabaseHistory_ActionDetails_ActionDescription_TextBox.Name = "DatabaseHistory_ActionDetails_ActionDescription_TextBox";
            this.DatabaseHistory_ActionDetails_ActionDescription_TextBox.Size = new System.Drawing.Size(745, 13);
            this.DatabaseHistory_ActionDetails_ActionDescription_TextBox.TabIndex = 7;
            // 
            // DatabaseHistory_ActionDetails_PerformedByUsername_TextBox
            // 
            this.DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.Location = new System.Drawing.Point(680, 19);
            this.DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.Name = "DatabaseHistory_ActionDetails_PerformedByUsername_TextBox";
            this.DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.Size = new System.Drawing.Size(181, 13);
            this.DatabaseHistory_ActionDetails_PerformedByUsername_TextBox.TabIndex = 8;
            // 
            // DatabaseHistory_Search_Button
            // 
            this.DatabaseHistory_Search_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_Search_Button.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_Search_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_Search_Button.Location = new System.Drawing.Point(11, 18);
            this.DatabaseHistory_Search_Button.Name = "DatabaseHistory_Search_Button";
            this.DatabaseHistory_Search_Button.Size = new System.Drawing.Size(79, 27);
            this.DatabaseHistory_Search_Button.TabIndex = 13;
            this.DatabaseHistory_Search_Button.Text = "Search";
            this.DatabaseHistory_Search_Button.UseVisualStyleBackColor = false;
            this.DatabaseHistory_Search_Button.Click += new System.EventHandler(this.DatabaseHistory_Search_Button_Click);
            // 
            // DatabaseHistory_ActionDetails_GroupBox
            // 
            this.DatabaseHistory_ActionDetails_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseHistory_ActionDetails_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DatabaseHistory_ActionDetails_GroupBox.Controls.Add(this.DatabaseHistory_ActionDetails_PerformedByUsername_TextBox);
            this.DatabaseHistory_ActionDetails_GroupBox.Controls.Add(this.DatabaseHistory_ActionDetails_ActionDescription_TextBox);
            this.DatabaseHistory_ActionDetails_GroupBox.Controls.Add(this.DatabaseHistory_ActionDetails_ActionID_TextBox);
            this.DatabaseHistory_ActionDetails_GroupBox.Controls.Add(this.DatabaseHistory_ActionDetails_PerformedByUsername_Label);
            this.DatabaseHistory_ActionDetails_GroupBox.Controls.Add(this.DatabaseHistory_ActionDetails_ActionDescription_Label);
            this.DatabaseHistory_ActionDetails_GroupBox.Controls.Add(this.DatabaseHistory_ActionDetails_ActionID_Label);
            this.DatabaseHistory_ActionDetails_GroupBox.Location = new System.Drawing.Point(23, 126);
            this.DatabaseHistory_ActionDetails_GroupBox.Name = "DatabaseHistory_ActionDetails_GroupBox";
            this.DatabaseHistory_ActionDetails_GroupBox.Size = new System.Drawing.Size(874, 84);
            this.DatabaseHistory_ActionDetails_GroupBox.TabIndex = 54;
            this.DatabaseHistory_ActionDetails_GroupBox.TabStop = false;
            // 
            // DatabaseHistory_Title_GroupBox
            // 
            this.DatabaseHistory_Title_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseHistory_Title_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DatabaseHistory_Title_GroupBox.Controls.Add(this.DatabaseHistory_Title_TextBox);
            this.DatabaseHistory_Title_GroupBox.Location = new System.Drawing.Point(342, 44);
            this.DatabaseHistory_Title_GroupBox.Name = "DatabaseHistory_Title_GroupBox";
            this.DatabaseHistory_Title_GroupBox.Size = new System.Drawing.Size(280, 53);
            this.DatabaseHistory_Title_GroupBox.TabIndex = 56;
            this.DatabaseHistory_Title_GroupBox.TabStop = false;
            // 
            // DatabaseHistory_Title_TextBox
            // 
            this.DatabaseHistory_Title_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseHistory_Title_TextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatabaseHistory_Title_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseHistory_Title_TextBox.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseHistory_Title_TextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.DatabaseHistory_Title_TextBox.Location = new System.Drawing.Point(6, 7);
            this.DatabaseHistory_Title_TextBox.Name = "DatabaseHistory_Title_TextBox";
            this.DatabaseHistory_Title_TextBox.Size = new System.Drawing.Size(268, 38);
            this.DatabaseHistory_Title_TextBox.TabIndex = 55;
            this.DatabaseHistory_Title_TextBox.Text = "Database History";
            this.DatabaseHistory_Title_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatavaseHistory_Search_GroupBox
            // 
            this.DatavaseHistory_Search_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatavaseHistory_Search_GroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DatavaseHistory_Search_GroupBox.Controls.Add(this.DatabaseHistory_Search_Button);
            this.DatavaseHistory_Search_GroupBox.Controls.Add(this.DatabaseHistory_Search_TextBox);
            this.DatavaseHistory_Search_GroupBox.Location = new System.Drawing.Point(23, 44);
            this.DatavaseHistory_Search_GroupBox.Name = "DatavaseHistory_Search_GroupBox";
            this.DatavaseHistory_Search_GroupBox.Size = new System.Drawing.Size(262, 59);
            this.DatavaseHistory_Search_GroupBox.TabIndex = 57;
            this.DatavaseHistory_Search_GroupBox.TabStop = false;
            // 
            // DatabaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(921, 531);
            this.Controls.Add(this.DatavaseHistory_Search_GroupBox);
            this.Controls.Add(this.DatabaseHistory_Title_GroupBox);
            this.Controls.Add(this.DatabaseHistory_ActionDetails_GroupBox);
            this.Controls.Add(this.DatabaseHistory_LoginDetails_GroupBox);
            this.Controls.Add(this.DatabaseHistory_DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DatabaseHistory";
            this.Text = "Database History";
            this.Load += new System.EventHandler(this.DatabaseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseHistory_DataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DatabaseHistory_LoginDetails_GroupBox.ResumeLayout(false);
            this.DatabaseHistory_LoginDetails_GroupBox.PerformLayout();
            this.DatabaseHistory_ActionDetails_GroupBox.ResumeLayout(false);
            this.DatabaseHistory_ActionDetails_GroupBox.PerformLayout();
            this.DatabaseHistory_Title_GroupBox.ResumeLayout(false);
            this.DatabaseHistory_Title_GroupBox.PerformLayout();
            this.DatavaseHistory_Search_GroupBox.ResumeLayout(false);
            this.DatavaseHistory_Search_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DatabaseHistory_DataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DatabaseHistory_FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseHistory_MainMenu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseHistory_Logout_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseHistory_Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseHistory_DeleteRecord_ToolStripMenuItem;
        private System.Windows.Forms.Label DatabaseHistory_LoginDetails_LoggedInAs_Label;
        private System.Windows.Forms.TextBox DatabaseHistory_LoginDetails_LoggedInAs_TextBox;
        private System.Windows.Forms.Label DatabaseHistory_LoginDetails_UserLevel_Label;
        private System.Windows.Forms.TextBox DatabaseHistory_LoginDetails_UserLevel_TextBox;
        private System.Windows.Forms.GroupBox DatabaseHistory_LoginDetails_GroupBox;
        private System.Windows.Forms.TextBox DatabaseHistory_Search_TextBox;
        private System.Windows.Forms.Label DatabaseHistory_ActionDetails_ActionID_Label;
        private System.Windows.Forms.Label DatabaseHistory_ActionDetails_ActionDescription_Label;
        private System.Windows.Forms.Label DatabaseHistory_ActionDetails_PerformedByUsername_Label;
        private System.Windows.Forms.TextBox DatabaseHistory_ActionDetails_ActionID_TextBox;
        private System.Windows.Forms.TextBox DatabaseHistory_ActionDetails_ActionDescription_TextBox;
        private System.Windows.Forms.TextBox DatabaseHistory_ActionDetails_PerformedByUsername_TextBox;
        private System.Windows.Forms.Button DatabaseHistory_Search_Button;
        private System.Windows.Forms.GroupBox DatabaseHistory_ActionDetails_GroupBox;
        private System.Windows.Forms.GroupBox DatabaseHistory_Title_GroupBox;
        private System.Windows.Forms.TextBox DatabaseHistory_Title_TextBox;
        private System.Windows.Forms.GroupBox DatavaseHistory_Search_GroupBox;
    }
}