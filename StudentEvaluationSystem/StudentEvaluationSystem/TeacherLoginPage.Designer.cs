namespace StudentEvaluationSystem
{
	partial class TeacherLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLoginPage));
            this.Window_Close_Btn = new System.Windows.Forms.Button();
            this.Main_Logo = new System.Windows.Forms.PictureBox();
            this.Teacher_Login_Email = new System.Windows.Forms.TextBox();
            this.Teacher_Login_Password = new System.Windows.Forms.TextBox();
            this.Teacher_Pg_Teacher_Login_Btn = new System.Windows.Forms.Button();
            this.Teacher_Pg_Back_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Logo)).BeginInit();
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
            this.Window_Close_Btn.TabIndex = 0;
            this.Window_Close_Btn.TabStop = false;
            this.Window_Close_Btn.UseVisualStyleBackColor = false;
            this.Window_Close_Btn.Click += new System.EventHandler(this.Window_Close_Btn_Click);
            // 
            // Main_Logo
            // 
            this.Main_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Main_Logo.BackgroundImage")));
            this.Main_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Logo.ImageLocation = "";
            this.Main_Logo.Location = new System.Drawing.Point(117, 40);
            this.Main_Logo.Name = "Main_Logo";
            this.Main_Logo.Size = new System.Drawing.Size(566, 138);
            this.Main_Logo.TabIndex = 2;
            this.Main_Logo.TabStop = false;
            // 
            // Teacher_Login_Email
            // 
            this.Teacher_Login_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Login_Email.Location = new System.Drawing.Point(285, 228);
            this.Teacher_Login_Email.Multiline = true;
            this.Teacher_Login_Email.Name = "Teacher_Login_Email";
            this.Teacher_Login_Email.Size = new System.Drawing.Size(230, 26);
            this.Teacher_Login_Email.TabIndex = 1;
            this.Teacher_Login_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
            // 
            // Teacher_Login_Password
            // 
            this.Teacher_Login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Login_Password.Location = new System.Drawing.Point(285, 287);
            this.Teacher_Login_Password.Multiline = true;
            this.Teacher_Login_Password.Name = "Teacher_Login_Password";
            this.Teacher_Login_Password.Size = new System.Drawing.Size(230, 26);
            this.Teacher_Login_Password.TabIndex = 2;
            this.Teacher_Login_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxChanged);
            // 
            // Teacher_Pg_Teacher_Login_Btn
            // 
            this.Teacher_Pg_Teacher_Login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.Teacher_Pg_Teacher_Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Teacher_Pg_Teacher_Login_Btn.FlatAppearance.BorderSize = 0;
            this.Teacher_Pg_Teacher_Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacher_Pg_Teacher_Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Pg_Teacher_Login_Btn.ForeColor = System.Drawing.Color.White;
            this.Teacher_Pg_Teacher_Login_Btn.Location = new System.Drawing.Point(285, 346);
            this.Teacher_Pg_Teacher_Login_Btn.Name = "Teacher_Pg_Teacher_Login_Btn";
            this.Teacher_Pg_Teacher_Login_Btn.Size = new System.Drawing.Size(230, 26);
            this.Teacher_Pg_Teacher_Login_Btn.TabIndex = 3;
            this.Teacher_Pg_Teacher_Login_Btn.Text = "Login";
            this.Teacher_Pg_Teacher_Login_Btn.UseVisualStyleBackColor = false;
            this.Teacher_Pg_Teacher_Login_Btn.Click += new System.EventHandler(this.Teacher_Pg_Teacher_Login_Btn_Click);
            // 
            // Teacher_Pg_Back_Btn
            // 
            this.Teacher_Pg_Back_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(43)))));
            this.Teacher_Pg_Back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Teacher_Pg_Back_Btn.FlatAppearance.BorderSize = 0;
            this.Teacher_Pg_Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacher_Pg_Back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Pg_Back_Btn.ForeColor = System.Drawing.Color.White;
            this.Teacher_Pg_Back_Btn.Location = new System.Drawing.Point(285, 378);
            this.Teacher_Pg_Back_Btn.Name = "Teacher_Pg_Back_Btn";
            this.Teacher_Pg_Back_Btn.Size = new System.Drawing.Size(230, 26);
            this.Teacher_Pg_Back_Btn.TabIndex = 4;
            this.Teacher_Pg_Back_Btn.Text = "Back";
            this.Teacher_Pg_Back_Btn.UseVisualStyleBackColor = false;
            this.Teacher_Pg_Back_Btn.Click += new System.EventHandler(this.Teacher_Pg_Back_Btn_Click);
            // 
            // TeacherLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Teacher_Pg_Back_Btn);
            this.Controls.Add(this.Teacher_Pg_Teacher_Login_Btn);
            this.Controls.Add(this.Teacher_Login_Password);
            this.Controls.Add(this.Teacher_Login_Email);
            this.Controls.Add(this.Main_Logo);
            this.Controls.Add(this.Window_Close_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherLoginPage";
            this.Load += new System.EventHandler(this.TeacherLoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Window_Close_Btn;
		private System.Windows.Forms.PictureBox Main_Logo;
		private System.Windows.Forms.TextBox Teacher_Login_Email;
		private System.Windows.Forms.TextBox Teacher_Login_Password;
        private System.Windows.Forms.Button Teacher_Pg_Teacher_Login_Btn;
        private System.Windows.Forms.Button Teacher_Pg_Back_Btn;
    }
}