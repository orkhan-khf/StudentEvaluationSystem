namespace StudentEvaluationSystem
{
    partial class MentorLoggedPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MentorLoggedPage));
            this.label10 = new System.Windows.Forms.Label();
            this.Mentor_Page_Tasks_Table = new System.Windows.Forms.DataGridView();
            this.AP_Exit_Btn = new System.Windows.Forms.Button();
            this.Window_Close_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Mentor_Page_Students_Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Mentor_Page_Tasks_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mentor_Page_Students_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.label10.Location = new System.Drawing.Point(602, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Group Tasks";
            // 
            // Mentor_Page_Tasks_Table
            // 
            this.Mentor_Page_Tasks_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mentor_Page_Tasks_Table.BackgroundColor = System.Drawing.Color.White;
            this.Mentor_Page_Tasks_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mentor_Page_Tasks_Table.Location = new System.Drawing.Point(12, 49);
            this.Mentor_Page_Tasks_Table.Name = "Mentor_Page_Tasks_Table";
            this.Mentor_Page_Tasks_Table.Size = new System.Drawing.Size(1276, 288);
            this.Mentor_Page_Tasks_Table.TabIndex = 56;
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
            this.AP_Exit_Btn.TabIndex = 55;
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
            this.Window_Close_Btn.TabIndex = 54;
            this.Window_Close_Btn.UseVisualStyleBackColor = false;
            this.Window_Close_Btn.Click += new System.EventHandler(this.Window_Close_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(602, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Group Students";
            // 
            // Mentor_Page_Students_Table
            // 
            this.Mentor_Page_Students_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mentor_Page_Students_Table.BackgroundColor = System.Drawing.Color.White;
            this.Mentor_Page_Students_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mentor_Page_Students_Table.Location = new System.Drawing.Point(12, 368);
            this.Mentor_Page_Students_Table.Name = "Mentor_Page_Students_Table";
            this.Mentor_Page_Students_Table.Size = new System.Drawing.Size(1276, 288);
            this.Mentor_Page_Students_Table.TabIndex = 58;
            // 
            // MentorLoggedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mentor_Page_Students_Table);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Mentor_Page_Tasks_Table);
            this.Controls.Add(this.AP_Exit_Btn);
            this.Controls.Add(this.Window_Close_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MentorLoggedPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MentorLoggedPage";
            this.Load += new System.EventHandler(this.MentorLoggedPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mentor_Page_Tasks_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mentor_Page_Students_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Mentor_Page_Tasks_Table;
        private System.Windows.Forms.Button AP_Exit_Btn;
        private System.Windows.Forms.Button Window_Close_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Mentor_Page_Students_Table;
    }
}