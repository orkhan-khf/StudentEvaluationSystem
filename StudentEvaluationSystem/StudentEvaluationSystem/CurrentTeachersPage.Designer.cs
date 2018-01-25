namespace StudentEvaluationSystem
{
	partial class CurrentTeachersPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentTeachersPage));
			this.Window_Close_Btn = new System.Windows.Forms.Button();
			this.Teachers_Table = new System.Windows.Forms.DataGridView();
			this.Teacher_Pg_Back_Btn = new System.Windows.Forms.Button();
			this.Selected_Teacher_Picture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Teachers_Table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Selected_Teacher_Picture)).BeginInit();
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
			this.Window_Close_Btn.Location = new System.Drawing.Point(954, -1);
			this.Window_Close_Btn.Name = "Window_Close_Btn";
			this.Window_Close_Btn.Size = new System.Drawing.Size(46, 25);
			this.Window_Close_Btn.TabIndex = 3;
			this.Window_Close_Btn.UseVisualStyleBackColor = false;
			this.Window_Close_Btn.Click += new System.EventHandler(this.Window_Close_Btn_Click);
			// 
			// Teachers_Table
			// 
			this.Teachers_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Teachers_Table.BackgroundColor = System.Drawing.Color.White;
			this.Teachers_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Teachers_Table.GridColor = System.Drawing.Color.Black;
			this.Teachers_Table.Location = new System.Drawing.Point(12, 31);
			this.Teachers_Table.MultiSelect = false;
			this.Teachers_Table.Name = "Teachers_Table";
			this.Teachers_Table.Size = new System.Drawing.Size(976, 345);
			this.Teachers_Table.TabIndex = 10;
			this.Teachers_Table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Teachers_Table_CellEndEdit);
			this.Teachers_Table.SelectionChanged += new System.EventHandler(this.Teachers_Table_SelectionChanged);
			this.Teachers_Table.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Teachers_Table_KeyDown);
			// 
			// Teacher_Pg_Back_Btn
			// 
			this.Teacher_Pg_Back_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(43)))));
			this.Teacher_Pg_Back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Teacher_Pg_Back_Btn.FlatAppearance.BorderSize = 0;
			this.Teacher_Pg_Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Teacher_Pg_Back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Pg_Back_Btn.ForeColor = System.Drawing.Color.White;
			this.Teacher_Pg_Back_Btn.Location = new System.Drawing.Point(385, 662);
			this.Teacher_Pg_Back_Btn.Name = "Teacher_Pg_Back_Btn";
			this.Teacher_Pg_Back_Btn.Size = new System.Drawing.Size(230, 26);
			this.Teacher_Pg_Back_Btn.TabIndex = 11;
			this.Teacher_Pg_Back_Btn.Text = "Back";
			this.Teacher_Pg_Back_Btn.UseVisualStyleBackColor = false;
			this.Teacher_Pg_Back_Btn.Click += new System.EventHandler(this.Teacher_Pg_Back_Btn_Click);
			// 
			// Selected_Teacher_Picture
			// 
			this.Selected_Teacher_Picture.Location = new System.Drawing.Point(12, 382);
			this.Selected_Teacher_Picture.Name = "Selected_Teacher_Picture";
			this.Selected_Teacher_Picture.Size = new System.Drawing.Size(212, 264);
			this.Selected_Teacher_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Selected_Teacher_Picture.TabIndex = 12;
			this.Selected_Teacher_Picture.TabStop = false;
			// 
			// CurrentTeachersPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.Selected_Teacher_Picture);
			this.Controls.Add(this.Teacher_Pg_Back_Btn);
			this.Controls.Add(this.Teachers_Table);
			this.Controls.Add(this.Window_Close_Btn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CurrentTeachersPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CurrentTeachersPage";
			this.Load += new System.EventHandler(this.CurrentTeachersPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.Teachers_Table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Selected_Teacher_Picture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Window_Close_Btn;
		private System.Windows.Forms.DataGridView Teachers_Table;
		private System.Windows.Forms.Button Teacher_Pg_Back_Btn;
		private System.Windows.Forms.PictureBox Selected_Teacher_Picture;
	}
}