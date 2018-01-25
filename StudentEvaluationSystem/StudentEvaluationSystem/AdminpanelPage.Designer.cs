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
            this.Show_Current_Teachers_Btn = new System.Windows.Forms.Button();
            this.Select_Teacher_Photo_Btn = new System.Windows.Forms.Button();
            this.Add_New_Teacher_Btn = new System.Windows.Forms.Button();
            this.Teacher_Phone = new System.Windows.Forms.TextBox();
            this.Teacher_Gender = new System.Windows.Forms.ComboBox();
            this.Teacher_Password_Confirm = new System.Windows.Forms.TextBox();
            this.Teacher_Info = new System.Windows.Forms.TextBox();
            this.Teacher_Password = new System.Windows.Forms.TextBox();
            this.Teacher_Email = new System.Windows.Forms.TextBox();
            this.Teacher_Surname = new System.Windows.Forms.TextBox();
            this.Teacher_Name = new System.Windows.Forms.TextBox();
            this.Mentors_Tab = new System.Windows.Forms.TabPage();
            this.Select_Mentor_Photo_Btn = new System.Windows.Forms.Button();
            this.Add_New_Mentor_Btn = new System.Windows.Forms.Button();
            this.Mentor_Phone = new System.Windows.Forms.TextBox();
            this.Mentor_Gender = new System.Windows.Forms.ComboBox();
            this.Mentor_Password_Confirm = new System.Windows.Forms.TextBox();
            this.Mentor_Info = new System.Windows.Forms.TextBox();
            this.Mentor_Password = new System.Windows.Forms.TextBox();
            this.Mentor_Email = new System.Windows.Forms.TextBox();
            this.Mentor_Surname = new System.Windows.Forms.TextBox();
            this.Mentor_Name = new System.Windows.Forms.TextBox();
            this.Task_Types_Tab = new System.Windows.Forms.TabPage();
            this.Task_Type_Rate = new System.Windows.Forms.TextBox();
            this.Task_Type_Name = new System.Windows.Forms.TextBox();
            this.Group_Schedules_Tab = new System.Windows.Forms.TabPage();
            this.Group_Type_Name = new System.Windows.Forms.TextBox();
            this.Group_Schedule = new System.Windows.Forms.ComboBox();
            this.Group_Types_Tab = new System.Windows.Forms.TabPage();
            this.Groups_Tab = new System.Windows.Forms.TabPage();
            this.Group_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.Group_Mentor = new System.Windows.Forms.ComboBox();
            this.Group_Teacher = new System.Windows.Forms.ComboBox();
            this.Group_Type = new System.Windows.Forms.ComboBox();
            this.Group_Name = new System.Windows.Forms.TextBox();
            this.Students_Tab = new System.Windows.Forms.TabPage();
            this.Student_Github_Account = new System.Windows.Forms.TextBox();
            this.Student_Group = new System.Windows.Forms.ComboBox();
            this.Select_Student_Photo_Btn = new System.Windows.Forms.Button();
            this.Add_New_Student_Btn = new System.Windows.Forms.Button();
            this.Student_Password_Confirm = new System.Windows.Forms.TextBox();
            this.Student_Gender = new System.Windows.Forms.ComboBox();
            this.Student_Password = new System.Windows.Forms.TextBox();
            this.Student_Info = new System.Windows.Forms.TextBox();
            this.Student_Phone = new System.Windows.Forms.TextBox();
            this.Student_Email = new System.Windows.Forms.TextBox();
            this.Student_Surname = new System.Windows.Forms.TextBox();
            this.Student_Name = new System.Windows.Forms.TextBox();
            this.Settings_Tab = new System.Windows.Forms.TabPage();
            this.AP_Exit_Btn = new System.Windows.Forms.Button();
            this.Show_Current_Mentors_Btn = new System.Windows.Forms.Button();
            this.Add_New_Task_Type_Btn = new System.Windows.Forms.Button();
            this.Adminpanel_Gender.SuspendLayout();
            this.Genders_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gender_Table)).BeginInit();
            this.Teachers_Tab.SuspendLayout();
            this.Mentors_Tab.SuspendLayout();
            this.Task_Types_Tab.SuspendLayout();
            this.Group_Schedules_Tab.SuspendLayout();
            this.Groups_Tab.SuspendLayout();
            this.Students_Tab.SuspendLayout();
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
            this.Mentors_Tab.Controls.Add(this.Show_Current_Mentors_Btn);
            this.Mentors_Tab.Controls.Add(this.Select_Mentor_Photo_Btn);
            this.Mentors_Tab.Controls.Add(this.Add_New_Mentor_Btn);
            this.Mentors_Tab.Controls.Add(this.Mentor_Phone);
            this.Mentors_Tab.Controls.Add(this.Mentor_Gender);
            this.Mentors_Tab.Controls.Add(this.Mentor_Password_Confirm);
            this.Mentors_Tab.Controls.Add(this.Mentor_Info);
            this.Mentors_Tab.Controls.Add(this.Mentor_Password);
            this.Mentors_Tab.Controls.Add(this.Mentor_Email);
            this.Mentors_Tab.Controls.Add(this.Mentor_Surname);
            this.Mentors_Tab.Controls.Add(this.Mentor_Name);
            this.Mentors_Tab.Location = new System.Drawing.Point(4, 27);
            this.Mentors_Tab.Name = "Mentors_Tab";
            this.Mentors_Tab.Size = new System.Drawing.Size(768, 505);
            this.Mentors_Tab.TabIndex = 2;
            this.Mentors_Tab.Text = "Mentors";
            this.Mentors_Tab.UseVisualStyleBackColor = true;
            // 
            // Select_Mentor_Photo_Btn
            // 
            this.Select_Mentor_Photo_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.Select_Mentor_Photo_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Select_Mentor_Photo_Btn.FlatAppearance.BorderSize = 0;
            this.Select_Mentor_Photo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Mentor_Photo_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Mentor_Photo_Btn.ForeColor = System.Drawing.Color.White;
            this.Select_Mentor_Photo_Btn.Location = new System.Drawing.Point(6, 371);
            this.Select_Mentor_Photo_Btn.Name = "Select_Mentor_Photo_Btn";
            this.Select_Mentor_Photo_Btn.Size = new System.Drawing.Size(230, 26);
            this.Select_Mentor_Photo_Btn.TabIndex = 29;
            this.Select_Mentor_Photo_Btn.Text = "Select Photo";
            this.Select_Mentor_Photo_Btn.UseVisualStyleBackColor = false;
            // 
            // Add_New_Mentor_Btn
            // 
            this.Add_New_Mentor_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.Add_New_Mentor_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_New_Mentor_Btn.FlatAppearance.BorderSize = 0;
            this.Add_New_Mentor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_New_Mentor_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Mentor_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_New_Mentor_Btn.Location = new System.Drawing.Point(6, 403);
            this.Add_New_Mentor_Btn.Name = "Add_New_Mentor_Btn";
            this.Add_New_Mentor_Btn.Size = new System.Drawing.Size(230, 26);
            this.Add_New_Mentor_Btn.TabIndex = 20;
            this.Add_New_Mentor_Btn.Text = "Add Mentor";
            this.Add_New_Mentor_Btn.UseVisualStyleBackColor = false;
            // 
            // Mentor_Phone
            // 
            this.Mentor_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Phone.Location = new System.Drawing.Point(6, 166);
            this.Mentor_Phone.Multiline = true;
            this.Mentor_Phone.Name = "Mentor_Phone";
            this.Mentor_Phone.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Phone.TabIndex = 28;
            // 
            // Mentor_Gender
            // 
            this.Mentor_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mentor_Gender.FormattingEnabled = true;
            this.Mentor_Gender.Location = new System.Drawing.Point(6, 198);
            this.Mentor_Gender.Name = "Mentor_Gender";
            this.Mentor_Gender.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Gender.TabIndex = 27;
            // 
            // Mentor_Password_Confirm
            // 
            this.Mentor_Password_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Password_Confirm.Location = new System.Drawing.Point(6, 134);
            this.Mentor_Password_Confirm.Multiline = true;
            this.Mentor_Password_Confirm.Name = "Mentor_Password_Confirm";
            this.Mentor_Password_Confirm.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Password_Confirm.TabIndex = 26;
            // 
            // Mentor_Info
            // 
            this.Mentor_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Info.Location = new System.Drawing.Point(6, 230);
            this.Mentor_Info.Multiline = true;
            this.Mentor_Info.Name = "Mentor_Info";
            this.Mentor_Info.Size = new System.Drawing.Size(230, 135);
            this.Mentor_Info.TabIndex = 25;
            // 
            // Mentor_Password
            // 
            this.Mentor_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Password.Location = new System.Drawing.Point(6, 102);
            this.Mentor_Password.Multiline = true;
            this.Mentor_Password.Name = "Mentor_Password";
            this.Mentor_Password.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Password.TabIndex = 24;
            // 
            // Mentor_Email
            // 
            this.Mentor_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Email.Location = new System.Drawing.Point(6, 70);
            this.Mentor_Email.Multiline = true;
            this.Mentor_Email.Name = "Mentor_Email";
            this.Mentor_Email.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Email.TabIndex = 23;
            // 
            // Mentor_Surname
            // 
            this.Mentor_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Surname.Location = new System.Drawing.Point(6, 38);
            this.Mentor_Surname.Multiline = true;
            this.Mentor_Surname.Name = "Mentor_Surname";
            this.Mentor_Surname.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Surname.TabIndex = 22;
            // 
            // Mentor_Name
            // 
            this.Mentor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Name.Location = new System.Drawing.Point(6, 6);
            this.Mentor_Name.Multiline = true;
            this.Mentor_Name.Name = "Mentor_Name";
            this.Mentor_Name.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Name.TabIndex = 21;
            // 
            // Task_Types_Tab
            // 
            this.Task_Types_Tab.Controls.Add(this.Add_New_Task_Type_Btn);
            this.Task_Types_Tab.Controls.Add(this.Task_Type_Rate);
            this.Task_Types_Tab.Controls.Add(this.Task_Type_Name);
            this.Task_Types_Tab.Location = new System.Drawing.Point(4, 27);
            this.Task_Types_Tab.Name = "Task_Types_Tab";
            this.Task_Types_Tab.Size = new System.Drawing.Size(768, 505);
            this.Task_Types_Tab.TabIndex = 3;
            this.Task_Types_Tab.Text = "Task Types";
            this.Task_Types_Tab.UseVisualStyleBackColor = true;
            // 
            // Task_Type_Rate
            // 
            this.Task_Type_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Type_Rate.Location = new System.Drawing.Point(6, 38);
            this.Task_Type_Rate.Multiline = true;
            this.Task_Type_Rate.Name = "Task_Type_Rate";
            this.Task_Type_Rate.Size = new System.Drawing.Size(230, 26);
            this.Task_Type_Rate.TabIndex = 24;
            // 
            // Task_Type_Name
            // 
            this.Task_Type_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Type_Name.Location = new System.Drawing.Point(6, 6);
            this.Task_Type_Name.Multiline = true;
            this.Task_Type_Name.Name = "Task_Type_Name";
            this.Task_Type_Name.Size = new System.Drawing.Size(230, 26);
            this.Task_Type_Name.TabIndex = 23;
            // 
            // Group_Schedules_Tab
            // 
            this.Group_Schedules_Tab.Controls.Add(this.Group_Type_Name);
            this.Group_Schedules_Tab.Controls.Add(this.Group_Schedule);
            this.Group_Schedules_Tab.Location = new System.Drawing.Point(4, 27);
            this.Group_Schedules_Tab.Name = "Group_Schedules_Tab";
            this.Group_Schedules_Tab.Size = new System.Drawing.Size(768, 505);
            this.Group_Schedules_Tab.TabIndex = 4;
            this.Group_Schedules_Tab.Text = "Group Schedules";
            this.Group_Schedules_Tab.UseVisualStyleBackColor = true;
            // 
            // Group_Type_Name
            // 
            this.Group_Type_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Type_Name.Location = new System.Drawing.Point(3, 3);
            this.Group_Type_Name.Multiline = true;
            this.Group_Type_Name.Name = "Group_Type_Name";
            this.Group_Type_Name.Size = new System.Drawing.Size(230, 26);
            this.Group_Type_Name.TabIndex = 30;
            // 
            // Group_Schedule
            // 
            this.Group_Schedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group_Schedule.FormattingEnabled = true;
            this.Group_Schedule.Location = new System.Drawing.Point(3, 35);
            this.Group_Schedule.Name = "Group_Schedule";
            this.Group_Schedule.Size = new System.Drawing.Size(230, 26);
            this.Group_Schedule.TabIndex = 29;
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
            this.Groups_Tab.Controls.Add(this.Group_Start_Date);
            this.Groups_Tab.Controls.Add(this.Group_Mentor);
            this.Groups_Tab.Controls.Add(this.Group_Teacher);
            this.Groups_Tab.Controls.Add(this.Group_Type);
            this.Groups_Tab.Controls.Add(this.Group_Name);
            this.Groups_Tab.Location = new System.Drawing.Point(4, 27);
            this.Groups_Tab.Name = "Groups_Tab";
            this.Groups_Tab.Size = new System.Drawing.Size(768, 505);
            this.Groups_Tab.TabIndex = 6;
            this.Groups_Tab.Text = "Groups";
            this.Groups_Tab.UseVisualStyleBackColor = true;
            // 
            // Group_Start_Date
            // 
            this.Group_Start_Date.Location = new System.Drawing.Point(3, 131);
            this.Group_Start_Date.Name = "Group_Start_Date";
            this.Group_Start_Date.Size = new System.Drawing.Size(230, 22);
            this.Group_Start_Date.TabIndex = 28;
            // 
            // Group_Mentor
            // 
            this.Group_Mentor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group_Mentor.FormattingEnabled = true;
            this.Group_Mentor.Location = new System.Drawing.Point(3, 99);
            this.Group_Mentor.Name = "Group_Mentor";
            this.Group_Mentor.Size = new System.Drawing.Size(230, 26);
            this.Group_Mentor.TabIndex = 27;
            // 
            // Group_Teacher
            // 
            this.Group_Teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group_Teacher.FormattingEnabled = true;
            this.Group_Teacher.Location = new System.Drawing.Point(3, 67);
            this.Group_Teacher.Name = "Group_Teacher";
            this.Group_Teacher.Size = new System.Drawing.Size(230, 26);
            this.Group_Teacher.TabIndex = 26;
            // 
            // Group_Type
            // 
            this.Group_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group_Type.FormattingEnabled = true;
            this.Group_Type.Location = new System.Drawing.Point(3, 35);
            this.Group_Type.Name = "Group_Type";
            this.Group_Type.Size = new System.Drawing.Size(230, 26);
            this.Group_Type.TabIndex = 25;
            // 
            // Group_Name
            // 
            this.Group_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Name.Location = new System.Drawing.Point(3, 3);
            this.Group_Name.Multiline = true;
            this.Group_Name.Name = "Group_Name";
            this.Group_Name.Size = new System.Drawing.Size(230, 26);
            this.Group_Name.TabIndex = 19;
            // 
            // Students_Tab
            // 
            this.Students_Tab.Controls.Add(this.Student_Github_Account);
            this.Students_Tab.Controls.Add(this.Student_Group);
            this.Students_Tab.Controls.Add(this.Select_Student_Photo_Btn);
            this.Students_Tab.Controls.Add(this.Add_New_Student_Btn);
            this.Students_Tab.Controls.Add(this.Student_Password_Confirm);
            this.Students_Tab.Controls.Add(this.Student_Gender);
            this.Students_Tab.Controls.Add(this.Student_Password);
            this.Students_Tab.Controls.Add(this.Student_Info);
            this.Students_Tab.Controls.Add(this.Student_Phone);
            this.Students_Tab.Controls.Add(this.Student_Email);
            this.Students_Tab.Controls.Add(this.Student_Surname);
            this.Students_Tab.Controls.Add(this.Student_Name);
            this.Students_Tab.Location = new System.Drawing.Point(4, 27);
            this.Students_Tab.Name = "Students_Tab";
            this.Students_Tab.Size = new System.Drawing.Size(768, 505);
            this.Students_Tab.TabIndex = 7;
            this.Students_Tab.Text = "Students";
            this.Students_Tab.UseVisualStyleBackColor = true;
            // 
            // Student_Github_Account
            // 
            this.Student_Github_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Github_Account.Location = new System.Drawing.Point(6, 198);
            this.Student_Github_Account.Multiline = true;
            this.Student_Github_Account.Name = "Student_Github_Account";
            this.Student_Github_Account.Size = new System.Drawing.Size(230, 26);
            this.Student_Github_Account.TabIndex = 42;
            // 
            // Student_Group
            // 
            this.Student_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Student_Group.FormattingEnabled = true;
            this.Student_Group.Location = new System.Drawing.Point(6, 262);
            this.Student_Group.Name = "Student_Group";
            this.Student_Group.Size = new System.Drawing.Size(230, 26);
            this.Student_Group.TabIndex = 40;
            // 
            // Select_Student_Photo_Btn
            // 
            this.Select_Student_Photo_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(36)))));
            this.Select_Student_Photo_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Select_Student_Photo_Btn.FlatAppearance.BorderSize = 0;
            this.Select_Student_Photo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Student_Photo_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Student_Photo_Btn.ForeColor = System.Drawing.Color.White;
            this.Select_Student_Photo_Btn.Location = new System.Drawing.Point(6, 435);
            this.Select_Student_Photo_Btn.Name = "Select_Student_Photo_Btn";
            this.Select_Student_Photo_Btn.Size = new System.Drawing.Size(230, 26);
            this.Select_Student_Photo_Btn.TabIndex = 39;
            this.Select_Student_Photo_Btn.Text = "Select Photo";
            this.Select_Student_Photo_Btn.UseVisualStyleBackColor = false;
            // 
            // Add_New_Student_Btn
            // 
            this.Add_New_Student_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(36)))));
            this.Add_New_Student_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_New_Student_Btn.FlatAppearance.BorderSize = 0;
            this.Add_New_Student_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_New_Student_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Student_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_New_Student_Btn.Location = new System.Drawing.Point(6, 467);
            this.Add_New_Student_Btn.Name = "Add_New_Student_Btn";
            this.Add_New_Student_Btn.Size = new System.Drawing.Size(230, 26);
            this.Add_New_Student_Btn.TabIndex = 30;
            this.Add_New_Student_Btn.Text = "Add Student";
            this.Add_New_Student_Btn.UseVisualStyleBackColor = false;
            // 
            // Student_Password_Confirm
            // 
            this.Student_Password_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Password_Confirm.Location = new System.Drawing.Point(6, 134);
            this.Student_Password_Confirm.Multiline = true;
            this.Student_Password_Confirm.Name = "Student_Password_Confirm";
            this.Student_Password_Confirm.Size = new System.Drawing.Size(230, 26);
            this.Student_Password_Confirm.TabIndex = 38;
            // 
            // Student_Gender
            // 
            this.Student_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Student_Gender.FormattingEnabled = true;
            this.Student_Gender.Location = new System.Drawing.Point(6, 230);
            this.Student_Gender.Name = "Student_Gender";
            this.Student_Gender.Size = new System.Drawing.Size(230, 26);
            this.Student_Gender.TabIndex = 37;
            // 
            // Student_Password
            // 
            this.Student_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Password.Location = new System.Drawing.Point(6, 102);
            this.Student_Password.Multiline = true;
            this.Student_Password.Name = "Student_Password";
            this.Student_Password.Size = new System.Drawing.Size(230, 26);
            this.Student_Password.TabIndex = 36;
            // 
            // Student_Info
            // 
            this.Student_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Info.Location = new System.Drawing.Point(6, 294);
            this.Student_Info.Multiline = true;
            this.Student_Info.Name = "Student_Info";
            this.Student_Info.Size = new System.Drawing.Size(230, 135);
            this.Student_Info.TabIndex = 35;
            // 
            // Student_Phone
            // 
            this.Student_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Phone.Location = new System.Drawing.Point(6, 166);
            this.Student_Phone.Multiline = true;
            this.Student_Phone.Name = "Student_Phone";
            this.Student_Phone.Size = new System.Drawing.Size(230, 26);
            this.Student_Phone.TabIndex = 34;
            // 
            // Student_Email
            // 
            this.Student_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Email.Location = new System.Drawing.Point(6, 70);
            this.Student_Email.Multiline = true;
            this.Student_Email.Name = "Student_Email";
            this.Student_Email.Size = new System.Drawing.Size(230, 26);
            this.Student_Email.TabIndex = 33;
            // 
            // Student_Surname
            // 
            this.Student_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Surname.Location = new System.Drawing.Point(6, 38);
            this.Student_Surname.Multiline = true;
            this.Student_Surname.Name = "Student_Surname";
            this.Student_Surname.Size = new System.Drawing.Size(230, 26);
            this.Student_Surname.TabIndex = 32;
            // 
            // Student_Name
            // 
            this.Student_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Name.Location = new System.Drawing.Point(6, 6);
            this.Student_Name.Multiline = true;
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(230, 26);
            this.Student_Name.TabIndex = 31;
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
            // Show_Current_Mentors_Btn
            // 
            this.Show_Current_Mentors_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.Show_Current_Mentors_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Current_Mentors_Btn.FlatAppearance.BorderSize = 0;
            this.Show_Current_Mentors_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Current_Mentors_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Current_Mentors_Btn.ForeColor = System.Drawing.Color.White;
            this.Show_Current_Mentors_Btn.Location = new System.Drawing.Point(6, 473);
            this.Show_Current_Mentors_Btn.Name = "Show_Current_Mentors_Btn";
            this.Show_Current_Mentors_Btn.Size = new System.Drawing.Size(230, 26);
            this.Show_Current_Mentors_Btn.TabIndex = 30;
            this.Show_Current_Mentors_Btn.Text = "Show Mentors";
            this.Show_Current_Mentors_Btn.UseVisualStyleBackColor = false;
            // 
            // Add_New_Task_Type_Btn
            // 
            this.Add_New_Task_Type_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.Add_New_Task_Type_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_New_Task_Type_Btn.FlatAppearance.BorderSize = 0;
            this.Add_New_Task_Type_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_New_Task_Type_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Task_Type_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_New_Task_Type_Btn.Location = new System.Drawing.Point(6, 70);
            this.Add_New_Task_Type_Btn.Name = "Add_New_Task_Type_Btn";
            this.Add_New_Task_Type_Btn.Size = new System.Drawing.Size(230, 26);
            this.Add_New_Task_Type_Btn.TabIndex = 12;
            this.Add_New_Task_Type_Btn.Text = "Add Task Type";
            this.Add_New_Task_Type_Btn.UseVisualStyleBackColor = false;
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
            this.Mentors_Tab.ResumeLayout(false);
            this.Mentors_Tab.PerformLayout();
            this.Task_Types_Tab.ResumeLayout(false);
            this.Task_Types_Tab.PerformLayout();
            this.Group_Schedules_Tab.ResumeLayout(false);
            this.Group_Schedules_Tab.PerformLayout();
            this.Groups_Tab.ResumeLayout(false);
            this.Groups_Tab.PerformLayout();
            this.Students_Tab.ResumeLayout(false);
            this.Students_Tab.PerformLayout();
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
        private System.Windows.Forms.Button Select_Mentor_Photo_Btn;
        private System.Windows.Forms.Button Add_New_Mentor_Btn;
        private System.Windows.Forms.TextBox Mentor_Phone;
        private System.Windows.Forms.ComboBox Mentor_Gender;
        private System.Windows.Forms.TextBox Mentor_Password_Confirm;
        private System.Windows.Forms.TextBox Mentor_Info;
        private System.Windows.Forms.TextBox Mentor_Password;
        private System.Windows.Forms.TextBox Mentor_Email;
        private System.Windows.Forms.TextBox Mentor_Surname;
        private System.Windows.Forms.TextBox Mentor_Name;
        private System.Windows.Forms.Button Select_Student_Photo_Btn;
        private System.Windows.Forms.Button Add_New_Student_Btn;
        private System.Windows.Forms.TextBox Student_Password_Confirm;
        private System.Windows.Forms.ComboBox Student_Gender;
        private System.Windows.Forms.TextBox Student_Password;
        private System.Windows.Forms.TextBox Student_Info;
        private System.Windows.Forms.TextBox Student_Phone;
        private System.Windows.Forms.TextBox Student_Email;
        private System.Windows.Forms.TextBox Student_Surname;
        private System.Windows.Forms.TextBox Student_Name;
        private System.Windows.Forms.TextBox Student_Github_Account;
        private System.Windows.Forms.ComboBox Student_Group;
        private System.Windows.Forms.TextBox Task_Type_Rate;
        private System.Windows.Forms.TextBox Task_Type_Name;
        private System.Windows.Forms.TextBox Group_Type_Name;
        private System.Windows.Forms.ComboBox Group_Schedule;
        private System.Windows.Forms.DateTimePicker Group_Start_Date;
        private System.Windows.Forms.ComboBox Group_Mentor;
        private System.Windows.Forms.ComboBox Group_Teacher;
        private System.Windows.Forms.ComboBox Group_Type;
        private System.Windows.Forms.TextBox Group_Name;
        private System.Windows.Forms.Button Show_Current_Mentors_Btn;
        private System.Windows.Forms.Button Add_New_Task_Type_Btn;
    }
}