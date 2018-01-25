namespace StudentEvaluationSystem
{
    partial class TeacherpanelPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherpanelPage));
            this.Window_Close_Btn = new System.Windows.Forms.Button();
            this.Teacherpanel = new System.Windows.Forms.TabControl();
            this.Add_New_Task_Tab = new System.Windows.Forms.TabPage();
            this.Task_Note = new System.Windows.Forms.TextBox();
            this.Task_Student = new System.Windows.Forms.ComboBox();
            this.Task_Group = new System.Windows.Forms.ComboBox();
            this.Task_Type = new System.Windows.Forms.ComboBox();
            this.Task_End_Date = new System.Windows.Forms.DateTimePicker();
            this.Task_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.Add_New_Task_Type_Btn = new System.Windows.Forms.Button();
            this.Task_Point = new System.Windows.Forms.TextBox();
            this.Task_Source = new System.Windows.Forms.TextBox();
            this.Edit_Student_Points_Tab = new System.Windows.Forms.TabPage();
            this.Edit_Student_Points_Table = new System.Windows.Forms.DataGridView();
            this.Mentor_Pg_Back_Btn = new System.Windows.Forms.Button();
            this.Teacherpanel.SuspendLayout();
            this.Add_New_Task_Tab.SuspendLayout();
            this.Edit_Student_Points_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Student_Points_Table)).BeginInit();
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
            this.Window_Close_Btn.Location = new System.Drawing.Point(954, 0);
            this.Window_Close_Btn.Name = "Window_Close_Btn";
            this.Window_Close_Btn.Size = new System.Drawing.Size(46, 25);
            this.Window_Close_Btn.TabIndex = 3;
            this.Window_Close_Btn.UseVisualStyleBackColor = false;
            // 
            // Teacherpanel
            // 
            this.Teacherpanel.Controls.Add(this.Add_New_Task_Tab);
            this.Teacherpanel.Controls.Add(this.Edit_Student_Points_Tab);
            this.Teacherpanel.Location = new System.Drawing.Point(12, 31);
            this.Teacherpanel.Name = "Teacherpanel";
            this.Teacherpanel.SelectedIndex = 0;
            this.Teacherpanel.Size = new System.Drawing.Size(976, 575);
            this.Teacherpanel.TabIndex = 4;
            // 
            // Add_New_Task_Tab
            // 
            this.Add_New_Task_Tab.Controls.Add(this.Task_Note);
            this.Add_New_Task_Tab.Controls.Add(this.Task_Student);
            this.Add_New_Task_Tab.Controls.Add(this.Task_Group);
            this.Add_New_Task_Tab.Controls.Add(this.Task_Type);
            this.Add_New_Task_Tab.Controls.Add(this.Task_End_Date);
            this.Add_New_Task_Tab.Controls.Add(this.Task_Start_Date);
            this.Add_New_Task_Tab.Controls.Add(this.Add_New_Task_Type_Btn);
            this.Add_New_Task_Tab.Controls.Add(this.Task_Point);
            this.Add_New_Task_Tab.Controls.Add(this.Task_Source);
            this.Add_New_Task_Tab.Location = new System.Drawing.Point(4, 22);
            this.Add_New_Task_Tab.Name = "Add_New_Task_Tab";
            this.Add_New_Task_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Add_New_Task_Tab.Size = new System.Drawing.Size(968, 549);
            this.Add_New_Task_Tab.TabIndex = 0;
            this.Add_New_Task_Tab.Text = "Add New Task";
            this.Add_New_Task_Tab.UseVisualStyleBackColor = true;
            // 
            // Task_Note
            // 
            this.Task_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Note.Location = new System.Drawing.Point(6, 149);
            this.Task_Note.Multiline = true;
            this.Task_Note.Name = "Task_Note";
            this.Task_Note.Size = new System.Drawing.Size(230, 135);
            this.Task_Note.TabIndex = 41;
            // 
            // Task_Student
            // 
            this.Task_Student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Task_Student.FormattingEnabled = true;
            this.Task_Student.Location = new System.Drawing.Point(6, 317);
            this.Task_Student.Name = "Task_Student";
            this.Task_Student.Size = new System.Drawing.Size(230, 21);
            this.Task_Student.TabIndex = 40;
            // 
            // Task_Group
            // 
            this.Task_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Task_Group.FormattingEnabled = true;
            this.Task_Group.Location = new System.Drawing.Point(6, 290);
            this.Task_Group.Name = "Task_Group";
            this.Task_Group.Size = new System.Drawing.Size(230, 21);
            this.Task_Group.TabIndex = 39;
            // 
            // Task_Type
            // 
            this.Task_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Task_Type.FormattingEnabled = true;
            this.Task_Type.Location = new System.Drawing.Point(6, 6);
            this.Task_Type.Name = "Task_Type";
            this.Task_Type.Size = new System.Drawing.Size(230, 21);
            this.Task_Type.TabIndex = 38;
            // 
            // Task_End_Date
            // 
            this.Task_End_Date.Location = new System.Drawing.Point(6, 59);
            this.Task_End_Date.Name = "Task_End_Date";
            this.Task_End_Date.Size = new System.Drawing.Size(230, 20);
            this.Task_End_Date.TabIndex = 37;
            // 
            // Task_Start_Date
            // 
            this.Task_Start_Date.Location = new System.Drawing.Point(6, 33);
            this.Task_Start_Date.Name = "Task_Start_Date";
            this.Task_Start_Date.Size = new System.Drawing.Size(230, 20);
            this.Task_Start_Date.TabIndex = 36;
            // 
            // Add_New_Task_Type_Btn
            // 
            this.Add_New_Task_Type_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
            this.Add_New_Task_Type_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_New_Task_Type_Btn.FlatAppearance.BorderSize = 0;
            this.Add_New_Task_Type_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_New_Task_Type_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Task_Type_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_New_Task_Type_Btn.Location = new System.Drawing.Point(6, 344);
            this.Add_New_Task_Type_Btn.Name = "Add_New_Task_Type_Btn";
            this.Add_New_Task_Type_Btn.Size = new System.Drawing.Size(230, 26);
            this.Add_New_Task_Type_Btn.TabIndex = 28;
            this.Add_New_Task_Type_Btn.Text = "Add Task Type";
            this.Add_New_Task_Type_Btn.UseVisualStyleBackColor = false;
            // 
            // Task_Point
            // 
            this.Task_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Point.Location = new System.Drawing.Point(6, 85);
            this.Task_Point.Multiline = true;
            this.Task_Point.Name = "Task_Point";
            this.Task_Point.Size = new System.Drawing.Size(230, 26);
            this.Task_Point.TabIndex = 29;
            // 
            // Task_Source
            // 
            this.Task_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Source.Location = new System.Drawing.Point(6, 117);
            this.Task_Source.Multiline = true;
            this.Task_Source.Name = "Task_Source";
            this.Task_Source.Size = new System.Drawing.Size(230, 26);
            this.Task_Source.TabIndex = 30;
            // 
            // Edit_Student_Points_Tab
            // 
            this.Edit_Student_Points_Tab.Controls.Add(this.Edit_Student_Points_Table);
            this.Edit_Student_Points_Tab.Location = new System.Drawing.Point(4, 22);
            this.Edit_Student_Points_Tab.Name = "Edit_Student_Points_Tab";
            this.Edit_Student_Points_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Edit_Student_Points_Tab.Size = new System.Drawing.Size(968, 549);
            this.Edit_Student_Points_Tab.TabIndex = 1;
            this.Edit_Student_Points_Tab.Text = "Edit Student Points";
            this.Edit_Student_Points_Tab.UseVisualStyleBackColor = true;
            // 
            // Edit_Student_Points_Table
            // 
            this.Edit_Student_Points_Table.BackgroundColor = System.Drawing.Color.White;
            this.Edit_Student_Points_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Edit_Student_Points_Table.GridColor = System.Drawing.Color.Black;
            this.Edit_Student_Points_Table.Location = new System.Drawing.Point(6, 6);
            this.Edit_Student_Points_Table.Name = "Edit_Student_Points_Table";
            this.Edit_Student_Points_Table.Size = new System.Drawing.Size(956, 251);
            this.Edit_Student_Points_Table.TabIndex = 0;
            // 
            // Mentor_Pg_Back_Btn
            // 
            this.Mentor_Pg_Back_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(43)))));
            this.Mentor_Pg_Back_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mentor_Pg_Back_Btn.FlatAppearance.BorderSize = 0;
            this.Mentor_Pg_Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mentor_Pg_Back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_Pg_Back_Btn.ForeColor = System.Drawing.Color.White;
            this.Mentor_Pg_Back_Btn.Location = new System.Drawing.Point(385, 662);
            this.Mentor_Pg_Back_Btn.Name = "Mentor_Pg_Back_Btn";
            this.Mentor_Pg_Back_Btn.Size = new System.Drawing.Size(230, 26);
            this.Mentor_Pg_Back_Btn.TabIndex = 15;
            this.Mentor_Pg_Back_Btn.Text = "Back";
            this.Mentor_Pg_Back_Btn.UseVisualStyleBackColor = false;
            // 
            // TeacherpanelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.Mentor_Pg_Back_Btn);
            this.Controls.Add(this.Teacherpanel);
            this.Controls.Add(this.Window_Close_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherpanelPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherpanelPage";
            this.Teacherpanel.ResumeLayout(false);
            this.Add_New_Task_Tab.ResumeLayout(false);
            this.Add_New_Task_Tab.PerformLayout();
            this.Edit_Student_Points_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Student_Points_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Window_Close_Btn;
        private System.Windows.Forms.TabPage Add_New_Task_Tab;
        private System.Windows.Forms.TabPage Edit_Student_Points_Tab;
        private System.Windows.Forms.Button Mentor_Pg_Back_Btn;
        private System.Windows.Forms.TabControl Teacherpanel;
        private System.Windows.Forms.Button Add_New_Task_Type_Btn;
        private System.Windows.Forms.TextBox Task_Point;
        private System.Windows.Forms.TextBox Task_Source;
        private System.Windows.Forms.DateTimePicker Task_End_Date;
        private System.Windows.Forms.DateTimePicker Task_Start_Date;
        private System.Windows.Forms.TextBox Task_Note;
        private System.Windows.Forms.ComboBox Task_Student;
        private System.Windows.Forms.ComboBox Task_Group;
        private System.Windows.Forms.ComboBox Task_Type;
        private System.Windows.Forms.DataGridView Edit_Student_Points_Table;
    }
}