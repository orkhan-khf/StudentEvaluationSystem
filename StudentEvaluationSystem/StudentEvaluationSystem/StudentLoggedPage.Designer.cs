namespace StudentEvaluationSystem
{
    partial class StudentLoggedPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLoggedPage));
            this.AP_Exit_Btn = new System.Windows.Forms.Button();
            this.Window_Close_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Student_Page_Profile_Table = new System.Windows.Forms.DataGridView();
            this.Student_Page_Tasks_Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Page_Profile_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Page_Tasks_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // AP_Exit_Btn
            // 
            this.AP_Exit_Btn.BackColor = System.Drawing.Color.Brown;
            this.AP_Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AP_Exit_Btn.FlatAppearance.BorderSize = 0;
            this.AP_Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AP_Exit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AP_Exit_Btn.ForeColor = System.Drawing.Color.White;
            this.AP_Exit_Btn.Location = new System.Drawing.Point(535, 662);
            this.AP_Exit_Btn.Name = "AP_Exit_Btn";
            this.AP_Exit_Btn.Size = new System.Drawing.Size(230, 26);
            this.AP_Exit_Btn.TabIndex = 14;
            this.AP_Exit_Btn.Text = "Exit";
            this.AP_Exit_Btn.UseVisualStyleBackColor = false;
            this.AP_Exit_Btn.Click += new System.EventHandler(this.AP_Exit_Btn_Click);
            // 
            // Window_Close_Btn
            // 
            this.Window_Close_Btn.BackColor = System.Drawing.Color.LightCoral;
            this.Window_Close_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Window_Close_Btn.BackgroundImage")));
            this.Window_Close_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Window_Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Window_Close_Btn.FlatAppearance.BorderSize = 0;
            this.Window_Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Window_Close_Btn.Location = new System.Drawing.Point(1254, 0);
            this.Window_Close_Btn.Name = "Window_Close_Btn";
            this.Window_Close_Btn.Size = new System.Drawing.Size(46, 25);
            this.Window_Close_Btn.TabIndex = 13;
            this.Window_Close_Btn.UseVisualStyleBackColor = false;
            this.Window_Close_Btn.Click += new System.EventHandler(this.Window_Close_Btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.label10.Location = new System.Drawing.Point(585, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Your Task Results";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.label9.Location = new System.Drawing.Point(592, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 56;
            this.label9.Text = "Your Profile Infos";
            // 
            // Student_Page_Profile_Table
            // 
            this.Student_Page_Profile_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Student_Page_Profile_Table.BackgroundColor = System.Drawing.Color.White;
            this.Student_Page_Profile_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Page_Profile_Table.Location = new System.Drawing.Point(12, 562);
            this.Student_Page_Profile_Table.Name = "Student_Page_Profile_Table";
            this.Student_Page_Profile_Table.Size = new System.Drawing.Size(1276, 80);
            this.Student_Page_Profile_Table.TabIndex = 55;
            // 
            // Student_Page_Tasks_Table
            // 
            this.Student_Page_Tasks_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Student_Page_Tasks_Table.BackgroundColor = System.Drawing.Color.White;
            this.Student_Page_Tasks_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Page_Tasks_Table.Location = new System.Drawing.Point(12, 46);
            this.Student_Page_Tasks_Table.Name = "Student_Page_Tasks_Table";
            this.Student_Page_Tasks_Table.Size = new System.Drawing.Size(1276, 492);
            this.Student_Page_Tasks_Table.TabIndex = 54;
            // 
            // StudentLoggedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Student_Page_Profile_Table);
            this.Controls.Add(this.Student_Page_Tasks_Table);
            this.Controls.Add(this.AP_Exit_Btn);
            this.Controls.Add(this.Window_Close_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLoggedPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentLoggedPage";
            this.Load += new System.EventHandler(this.StudentLoggedPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Page_Profile_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Page_Tasks_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AP_Exit_Btn;
        private System.Windows.Forms.Button Window_Close_Btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Student_Page_Profile_Table;
        private System.Windows.Forms.DataGridView Student_Page_Tasks_Table;
    }
}