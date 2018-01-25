namespace StudentEvaluationSystem
{
	partial class AdminpanelPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminpanelPage));
			this.Window_Close_Btn = new System.Windows.Forms.Button();
			this.Adminpanel_Gender = new System.Windows.Forms.TabControl();
			this.Genders_Tab = new System.Windows.Forms.TabPage();
			this.Gender_Table = new System.Windows.Forms.DataGridView();
			this.AP_Gender_Add_Btn = new System.Windows.Forms.Button();
			this.Gender_Name_Textbox = new System.Windows.Forms.TextBox();
			this.Teachers_Tab = new System.Windows.Forms.TabPage();
			this.Teacher_Phone = new System.Windows.Forms.TextBox();
			this.Teacher_Gender = new System.Windows.Forms.ComboBox();
			this.Teacher_Password_Confirm = new System.Windows.Forms.TextBox();
			this.Teacher_Info = new System.Windows.Forms.TextBox();
			this.Teacher_Password = new System.Windows.Forms.TextBox();
			this.Teacher_Email = new System.Windows.Forms.TextBox();
			this.Teacher_Surname = new System.Windows.Forms.TextBox();
			this.Teacher_Name = new System.Windows.Forms.TextBox();
			this.Mentors_Tab = new System.Windows.Forms.TabPage();
			this.Task_Types_Tab = new System.Windows.Forms.TabPage();
			this.Group_Schedules_Tab = new System.Windows.Forms.TabPage();
			this.Group_Types_Tab = new System.Windows.Forms.TabPage();
			this.Groups_Tab = new System.Windows.Forms.TabPage();
			this.Students_Tab = new System.Windows.Forms.TabPage();
			this.Settings_Tab = new System.Windows.Forms.TabPage();
			this.AP_Exit_Btn = new System.Windows.Forms.Button();
			this.Add_New_Teacher_Btn = new System.Windows.Forms.Button();
			this.Select_Teacher_Photo_Btn = new System.Windows.Forms.Button();
			this.Show_Current_Teachers_Btn = new System.Windows.Forms.Button();
			this.Adminpanel_Gender.SuspendLayout();
			this.Genders_Tab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Gender_Table)).BeginInit();
			this.Teachers_Tab.SuspendLayout();
			this.SuspendLayout();
			// 
			// Window_Close_Btn
			// 
			this.Window_Close_Btn.BackColor = System.Drawing.Color.LightCoral;
			this.Window_Close_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Window_Close_Btn.BackgroundImage")));
			this.Window_Close_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Window_Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Window_Close_Btn.FlatAppearance.BorderSize = 0;
			this.Window_Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Window_Close_Btn.Location = new System.Drawing.Point(754, 0);
			this.Window_Close_Btn.Name = "Window_Close_Btn";
			this.Window_Close_Btn.Size = new System.Drawing.Size(46, 25);
			this.Window_Close_Btn.TabIndex = 2;
			this.Window_Close_Btn.UseVisualStyleBackColor = false;
			this.Window_Close_Btn.Click += new System.EventHandler(this.Window_Close_Btn_Click);
			// 
			// Adminpanel_Gender
			// 
			this.Adminpanel_Gender.Controls.Add(this.Genders_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Teachers_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Mentors_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Task_Types_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Group_Schedules_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Group_Types_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Groups_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Students_Tab);
			this.Adminpanel_Gender.Controls.Add(this.Settings_Tab);
			this.Adminpanel_Gender.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Adminpanel_Gender.Location = new System.Drawing.Point(12, 31);
			this.Adminpanel_Gender.Name = "Adminpanel_Gender";
			this.Adminpanel_Gender.SelectedIndex = 0;
			this.Adminpanel_Gender.Size = new System.Drawing.Size(776, 536);
			this.Adminpanel_Gender.TabIndex = 1;
			// 
			// Genders_Tab
			// 
			this.Genders_Tab.BackColor = System.Drawing.Color.White;
			this.Genders_Tab.Controls.Add(this.Gender_Table);
			this.Genders_Tab.Controls.Add(this.AP_Gender_Add_Btn);
			this.Genders_Tab.Controls.Add(this.Gender_Name_Textbox);
			this.Genders_Tab.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Genders_Tab.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Genders_Tab.Location = new System.Drawing.Point(4, 27);
			this.Genders_Tab.Name = "Genders_Tab";
			this.Genders_Tab.Padding = new System.Windows.Forms.Padding(3);
			this.Genders_Tab.Size = new System.Drawing.Size(768, 505);
			this.Genders_Tab.TabIndex = 0;
			this.Genders_Tab.Text = "Genders";
			// 
			// Gender_Table
			// 
			this.Gender_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Gender_Table.BackgroundColor = System.Drawing.Color.White;
			this.Gender_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Gender_Table.GridColor = System.Drawing.Color.Black;
			this.Gender_Table.Location = new System.Drawing.Point(6, 38);
			this.Gender_Table.MultiSelect = false;
			this.Gender_Table.Name = "Gender_Table";
			this.Gender_Table.Size = new System.Drawing.Size(756, 325);
			this.Gender_Table.TabIndex = 9;
			this.Gender_Table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gender_Table_CellEndEdit);
			this.Gender_Table.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gender_Table_KeyDown);
			// 
			// AP_Gender_Add_Btn
			// 
			this.AP_Gender_Add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
			this.AP_Gender_Add_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AP_Gender_Add_Btn.FlatAppearance.BorderSize = 0;
			this.AP_Gender_Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AP_Gender_Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AP_Gender_Add_Btn.ForeColor = System.Drawing.Color.White;
			this.AP_Gender_Add_Btn.Location = new System.Drawing.Point(242, 6);
			this.AP_Gender_Add_Btn.Name = "AP_Gender_Add_Btn";
			this.AP_Gender_Add_Btn.Size = new System.Drawing.Size(107, 26);
			this.AP_Gender_Add_Btn.TabIndex = 8;
			this.AP_Gender_Add_Btn.Text = "Add Gender";
			this.AP_Gender_Add_Btn.UseVisualStyleBackColor = false;
			this.AP_Gender_Add_Btn.Click += new System.EventHandler(this.Teacher_Pg_Gender_Add_Btn_Click);
			// 
			// Gender_Name_Textbox
			// 
			this.Gender_Name_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Gender_Name_Textbox.Location = new System.Drawing.Point(6, 6);
			this.Gender_Name_Textbox.Multiline = true;
			this.Gender_Name_Textbox.Name = "Gender_Name_Textbox";
			this.Gender_Name_Textbox.Size = new System.Drawing.Size(230, 26);
			this.Gender_Name_Textbox.TabIndex = 7;
			this.Gender_Name_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Teachers_Tab
			// 
			this.Teachers_Tab.Controls.Add(this.Show_Current_Teachers_Btn);
			this.Teachers_Tab.Controls.Add(this.Select_Teacher_Photo_Btn);
			this.Teachers_Tab.Controls.Add(this.Add_New_Teacher_Btn);
			this.Teachers_Tab.Controls.Add(this.Teacher_Phone);
			this.Teachers_Tab.Controls.Add(this.Teacher_Gender);
			this.Teachers_Tab.Controls.Add(this.Teacher_Password_Confirm);
			this.Teachers_Tab.Controls.Add(this.Teacher_Info);
			this.Teachers_Tab.Controls.Add(this.Teacher_Password);
			this.Teachers_Tab.Controls.Add(this.Teacher_Email);
			this.Teachers_Tab.Controls.Add(this.Teacher_Surname);
			this.Teachers_Tab.Controls.Add(this.Teacher_Name);
			this.Teachers_Tab.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Teachers_Tab.Location = new System.Drawing.Point(4, 27);
			this.Teachers_Tab.Name = "Teachers_Tab";
			this.Teachers_Tab.Padding = new System.Windows.Forms.Padding(3);
			this.Teachers_Tab.Size = new System.Drawing.Size(768, 505);
			this.Teachers_Tab.TabIndex = 1;
			this.Teachers_Tab.Text = "Teachers";
			this.Teachers_Tab.UseVisualStyleBackColor = true;
			// 
			// Teacher_Phone
			// 
			this.Teacher_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Phone.Location = new System.Drawing.Point(6, 166);
			this.Teacher_Phone.Multiline = true;
			this.Teacher_Phone.Name = "Teacher_Phone";
			this.Teacher_Phone.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Phone.TabIndex = 18;
			this.Teacher_Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Teacher_Gender
			// 
			this.Teacher_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Teacher_Gender.FormattingEnabled = true;
			this.Teacher_Gender.Location = new System.Drawing.Point(6, 198);
			this.Teacher_Gender.Name = "Teacher_Gender";
			this.Teacher_Gender.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Gender.TabIndex = 17;
			// 
			// Teacher_Password_Confirm
			// 
			this.Teacher_Password_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Password_Confirm.Location = new System.Drawing.Point(6, 134);
			this.Teacher_Password_Confirm.Multiline = true;
			this.Teacher_Password_Confirm.Name = "Teacher_Password_Confirm";
			this.Teacher_Password_Confirm.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Password_Confirm.TabIndex = 16;
			this.Teacher_Password_Confirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Teacher_Info
			// 
			this.Teacher_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Info.Location = new System.Drawing.Point(6, 230);
			this.Teacher_Info.Multiline = true;
			this.Teacher_Info.Name = "Teacher_Info";
			this.Teacher_Info.Size = new System.Drawing.Size(230, 135);
			this.Teacher_Info.TabIndex = 15;
			this.Teacher_Info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Teacher_Password
			// 
			this.Teacher_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Password.Location = new System.Drawing.Point(6, 102);
			this.Teacher_Password.Multiline = true;
			this.Teacher_Password.Name = "Teacher_Password";
			this.Teacher_Password.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Password.TabIndex = 14;
			this.Teacher_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Teacher_Email
			// 
			this.Teacher_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Email.Location = new System.Drawing.Point(6, 70);
			this.Teacher_Email.Multiline = true;
			this.Teacher_Email.Name = "Teacher_Email";
			this.Teacher_Email.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Email.TabIndex = 13;
			this.Teacher_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Teacher_Surname
			// 
			this.Teacher_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Surname.Location = new System.Drawing.Point(6, 38);
			this.Teacher_Surname.Multiline = true;
			this.Teacher_Surname.Name = "Teacher_Surname";
			this.Teacher_Surname.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Surname.TabIndex = 12;
			this.Teacher_Surname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Teacher_Name
			// 
			this.Teacher_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Name.Location = new System.Drawing.Point(6, 6);
			this.Teacher_Name.Multiline = true;
			this.Teacher_Name.Name = "Teacher_Name";
			this.Teacher_Name.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Name.TabIndex = 11;
			this.Teacher_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
			// 
			// Mentors_Tab
			// 
			this.Mentors_Tab.Location = new System.Drawing.Point(4, 27);
			this.Mentors_Tab.Name = "Mentors_Tab";
			this.Mentors_Tab.Size = new System.Drawing.Size(768, 505);
			this.Mentors_Tab.TabIndex = 2;
			this.Mentors_Tab.Text = "Mentors";
			this.Mentors_Tab.UseVisualStyleBackColor = true;
			// 
			// Task_Types_Tab
			// 
			this.Task_Types_Tab.Location = new System.Drawing.Point(4, 27);
			this.Task_Types_Tab.Name = "Task_Types_Tab";
			this.Task_Types_Tab.Size = new System.Drawing.Size(768, 505);
			this.Task_Types_Tab.TabIndex = 3;
			this.Task_Types_Tab.Text = "Task Types";
			this.Task_Types_Tab.UseVisualStyleBackColor = true;
			// 
			// Group_Schedules_Tab
			// 
			this.Group_Schedules_Tab.Location = new System.Drawing.Point(4, 27);
			this.Group_Schedules_Tab.Name = "Group_Schedules_Tab";
			this.Group_Schedules_Tab.Size = new System.Drawing.Size(768, 505);
			this.Group_Schedules_Tab.TabIndex = 4;
			this.Group_Schedules_Tab.Text = "Group Schedules";
			this.Group_Schedules_Tab.UseVisualStyleBackColor = true;
			// 
			// Group_Types_Tab
			// 
			this.Group_Types_Tab.Location = new System.Drawing.Point(4, 27);
			this.Group_Types_Tab.Name = "Group_Types_Tab";
			this.Group_Types_Tab.Size = new System.Drawing.Size(768, 505);
			this.Group_Types_Tab.TabIndex = 5;
			this.Group_Types_Tab.Text = "Group Types";
			this.Group_Types_Tab.UseVisualStyleBackColor = true;
			// 
			// Groups_Tab
			// 
			this.Groups_Tab.Location = new System.Drawing.Point(4, 27);
			this.Groups_Tab.Name = "Groups_Tab";
			this.Groups_Tab.Size = new System.Drawing.Size(768, 505);
			this.Groups_Tab.TabIndex = 6;
			this.Groups_Tab.Text = "Groups";
			this.Groups_Tab.UseVisualStyleBackColor = true;
			// 
			// Students_Tab
			// 
			this.Students_Tab.Location = new System.Drawing.Point(4, 27);
			this.Students_Tab.Name = "Students_Tab";
			this.Students_Tab.Size = new System.Drawing.Size(768, 505);
			this.Students_Tab.TabIndex = 7;
			this.Students_Tab.Text = "Students";
			this.Students_Tab.UseVisualStyleBackColor = true;
			// 
			// Settings_Tab
			// 
			this.Settings_Tab.Location = new System.Drawing.Point(4, 27);
			this.Settings_Tab.Name = "Settings_Tab";
			this.Settings_Tab.Size = new System.Drawing.Size(768, 505);
			this.Settings_Tab.TabIndex = 8;
			this.Settings_Tab.Text = "Settings";
			this.Settings_Tab.UseVisualStyleBackColor = true;
			// 
			// AP_Exit_Btn
			// 
			this.AP_Exit_Btn.BackColor = System.Drawing.Color.Brown;
			this.AP_Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AP_Exit_Btn.FlatAppearance.BorderSize = 0;
			this.AP_Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AP_Exit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AP_Exit_Btn.ForeColor = System.Drawing.Color.White;
			this.AP_Exit_Btn.Location = new System.Drawing.Point(285, 569);
			this.AP_Exit_Btn.Name = "AP_Exit_Btn";
			this.AP_Exit_Btn.Size = new System.Drawing.Size(230, 26);
			this.AP_Exit_Btn.TabIndex = 10;
			this.AP_Exit_Btn.Text = "Exit";
			this.AP_Exit_Btn.UseVisualStyleBackColor = false;
			this.AP_Exit_Btn.Click += new System.EventHandler(this.Student_Pg_Back_Btn_Click);
			// 
			// Add_New_Teacher_Btn
			// 
			this.Add_New_Teacher_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
			this.Add_New_Teacher_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Add_New_Teacher_Btn.FlatAppearance.BorderSize = 0;
			this.Add_New_Teacher_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add_New_Teacher_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add_New_Teacher_Btn.ForeColor = System.Drawing.Color.White;
			this.Add_New_Teacher_Btn.Location = new System.Drawing.Point(6, 403);
			this.Add_New_Teacher_Btn.Name = "Add_New_Teacher_Btn";
			this.Add_New_Teacher_Btn.Size = new System.Drawing.Size(230, 26);
			this.Add_New_Teacher_Btn.TabIndex = 11;
			this.Add_New_Teacher_Btn.Text = "Add Teacher";
			this.Add_New_Teacher_Btn.UseVisualStyleBackColor = false;
			this.Add_New_Teacher_Btn.Click += new System.EventHandler(this.button1_Click);
			// 
			// Select_Teacher_Photo_Btn
			// 
			this.Select_Teacher_Photo_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
			this.Select_Teacher_Photo_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Select_Teacher_Photo_Btn.FlatAppearance.BorderSize = 0;
			this.Select_Teacher_Photo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Select_Teacher_Photo_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Select_Teacher_Photo_Btn.ForeColor = System.Drawing.Color.White;
			this.Select_Teacher_Photo_Btn.Location = new System.Drawing.Point(6, 371);
			this.Select_Teacher_Photo_Btn.Name = "Select_Teacher_Photo_Btn";
			this.Select_Teacher_Photo_Btn.Size = new System.Drawing.Size(230, 26);
			this.Select_Teacher_Photo_Btn.TabIndex = 19;
			this.Select_Teacher_Photo_Btn.Text = "Select Photo";
			this.Select_Teacher_Photo_Btn.UseVisualStyleBackColor = false;
			this.Select_Teacher_Photo_Btn.Click += new System.EventHandler(this.Select_Teacher_Photo_Btn_Click);
			// 
			// Show_Current_Teachers_Btn
			// 
			this.Show_Current_Teachers_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
			this.Show_Current_Teachers_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Show_Current_Teachers_Btn.FlatAppearance.BorderSize = 0;
			this.Show_Current_Teachers_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Show_Current_Teachers_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Show_Current_Teachers_Btn.ForeColor = System.Drawing.Color.White;
			this.Show_Current_Teachers_Btn.Location = new System.Drawing.Point(6, 473);
			this.Show_Current_Teachers_Btn.Name = "Show_Current_Teachers_Btn";
			this.Show_Current_Teachers_Btn.Size = new System.Drawing.Size(230, 26);
			this.Show_Current_Teachers_Btn.TabIndex = 20;
			this.Show_Current_Teachers_Btn.Text = "Show Teachers";
			this.Show_Current_Teachers_Btn.UseVisualStyleBackColor = false;
			this.Show_Current_Teachers_Btn.Click += new System.EventHandler(this.Show_Current_Teachers_Btn_Click);
			// 
			// AdminpanelPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.AP_Exit_Btn);
			this.Controls.Add(this.Adminpanel_Gender);
			this.Controls.Add(this.Window_Close_Btn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminpanelPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminpanelPage";
			this.Load += new System.EventHandler(this.AdminpanelPage_Load);
			this.Adminpanel_Gender.ResumeLayout(false);
			this.Genders_Tab.ResumeLayout(false);
			this.Genders_Tab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Gender_Table)).EndInit();
			this.Teachers_Tab.ResumeLayout(false);
			this.Teachers_Tab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Window_Close_Btn;
		private System.Windows.Forms.TabControl Adminpanel_Gender;
		private System.Windows.Forms.TabPage Genders_Tab;
		private System.Windows.Forms.TabPage Teachers_Tab;
		private System.Windows.Forms.TabPage Mentors_Tab;
		private System.Windows.Forms.TabPage Task_Types_Tab;
		private System.Windows.Forms.TabPage Group_Schedules_Tab;
		private System.Windows.Forms.TabPage Group_Types_Tab;
		private System.Windows.Forms.TabPage Groups_Tab;
		private System.Windows.Forms.TabPage Students_Tab;
		private System.Windows.Forms.TabPage Settings_Tab;
		private System.Windows.Forms.TextBox Gender_Name_Textbox;
		private System.Windows.Forms.Button AP_Exit_Btn;
		private System.Windows.Forms.Button AP_Gender_Add_Btn;
		private System.Windows.Forms.TextBox Teacher_Name;
		private System.Windows.Forms.DataGridView Gender_Table;
		private System.Windows.Forms.ComboBox Teacher_Gender;
		private System.Windows.Forms.TextBox Teacher_Password_Confirm;
		private System.Windows.Forms.TextBox Teacher_Info;
		private System.Windows.Forms.TextBox Teacher_Password;
		private System.Windows.Forms.TextBox Teacher_Email;
		private System.Windows.Forms.TextBox Teacher_Surname;
		private System.Windows.Forms.TextBox Teacher_Phone;
		private System.Windows.Forms.Button Add_New_Teacher_Btn;
		private System.Windows.Forms.Button Select_Teacher_Photo_Btn;
		private System.Windows.Forms.Button Show_Current_Teachers_Btn;
	}
}