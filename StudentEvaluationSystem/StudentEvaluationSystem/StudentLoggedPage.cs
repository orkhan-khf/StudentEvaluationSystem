using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEvaluationSystem
{
    public partial class StudentLoggedPage : Form
    {
        CommonMethods CommonMethods = new CommonMethods();
        public static int logged_student_id;
        public StudentLoggedPage()
        {
            InitializeComponent();
        }

        private void AP_Exit_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new Form1());
        }

        private void Window_Close_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseApp();
        }

        private void StudentLoggedPage_Load(object sender, EventArgs e)
        {
            CommonMethods.FillDataGridView(Student_Page_Tasks_Table, CommonMethods.db.Students, CommonMethods.db.Task_Types, CommonMethods.db.Tasks, CommonMethods.db.Teachers, logged_student_id);
            CommonMethods.FillDataGridView(Student_Page_Profile_Table, CommonMethods.db.Students, CommonMethods.db.Genders, CommonMethods.db.Groups, logged_student_id);
        }
    }
}
