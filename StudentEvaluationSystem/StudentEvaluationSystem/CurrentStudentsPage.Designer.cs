namespace StudentEvaluationSystem
{
	partial class CurrentStudentsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentStudentsPage));
            this.Selected_Student_Picture = new System.Windows.Forms.PictureBox();
            this.Mentor_Pg_Back_Btn = new System.Windows.Forms.Button();
            this.Students_Table = new System.Windows.Forms.DataGridView();
            this.Window_Close_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_Student_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Students_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Selected_Student_Picture
            // 
            this.Selected_Student_Picture.Location = new System.Drawing.Point(12, 382);
            this.Selected_Student_Picture.Name = "Selected_Student_Picture";
            this.Selected_Student_Picture.Size = new System.Drawing.Size(212, 264);
            this.Selected_Student_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Selected_Student_Picture.TabIndex = 20;
            this.Selected_Student_Picture.TabStop = false;
            // 
            // Mentor_Pg_Back_Btn
            // 
            this.Mentor_Pg_Back_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(43)))));
            this.Mentor_Pg_Back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mentor_Pg_Back_Btn.FlatAppearance.BorderSize = 0;
            this.Mentor_Pg_Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mentor_Pg_Back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Pg_Back_Btn.ForeColor = System.Drawing.Color.White;
            this.Mentor_Pg_Back_Btn.Location = new System.Drawing.Point(485, 662);
            this.Mentor_Pg_Back_Btn.Name = "Mentor_Pg_Back_Btn";
            this.Mentor_Pg_Back_Btn.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Pg_Back_Btn.TabIndex = 1;
            this.Mentor_Pg_Back_Btn.Text = "Back";
            this.Mentor_Pg_Back_Btn.UseVisualStyleBackColor = false;
            this.Mentor_Pg_Back_Btn.Click += new System.EventHandler(this.Mentor_Pg_Back_Btn_Click);
            // 
            // Students_Table
            // 
            this.Students_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Students_Table.BackgroundColor = System.Drawing.Color.White;
            this.Students_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students_Table.GridColor = System.Drawing.Color.Black;
            this.Students_Table.Location = new System.Drawing.Point(12, 31);
            this.Students_Table.MultiSelect = false;
            this.Students_Table.Name = "Students_Table";
            this.Students_Table.Size = new System.Drawing.Size(1176, 345);
            this.Students_Table.TabIndex = 18;
            this.Students_Table.TabStop = false;
            this.Students_Table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Students_Table_CellEndEdit);
            this.Students_Table.SelectionChanged += new System.EventHandler(this.Students_Table_SelectionChanged);
            this.Students_Table.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Students_Table_KeyDown);
            // 
            // Window_Close_Btn
            // 
            this.Window_Close_Btn.BackColor = System.Drawing.Color.LightCoral;
            this.Window_Close_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Window_Close_Btn.BackgroundImage")));
            this.Window_Close_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Window_Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Window_Close_Btn.FlatAppearance.BorderSize = 0;
            this.Window_Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Window_Close_Btn.Location = new System.Drawing.Point(1154, 0);
            this.Window_Close_Btn.Name = "Window_Close_Btn";
            this.Window_Close_Btn.Size = new System.Drawing.Size(46, 25);
            this.Window_Close_Btn.TabIndex = 17;
            this.Window_Close_Btn.TabStop = false;
            this.Window_Close_Btn.UseVisualStyleBackColor = false;
            this.Window_Close_Btn.Click += new System.EventHandler(this.Window_Close_Btn_Click);
            // 
            // CurrentStudentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.Selected_Student_Picture);
            this.Controls.Add(this.Mentor_Pg_Back_Btn);
            this.Controls.Add(this.Students_Table);
            this.Controls.Add(this.Window_Close_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrentStudentsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrentStudentsPage";
            this.Load += new System.EventHandler(this.CurrentStudentsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Selected_Student_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Students_Table)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Selected_Student_Picture;
		private System.Windows.Forms.Button Mentor_Pg_Back_Btn;
		private System.Windows.Forms.DataGridView Students_Table;
		private System.Windows.Forms.Button Window_Close_Btn;
	}
}