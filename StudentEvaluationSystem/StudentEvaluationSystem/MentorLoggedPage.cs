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
    public partial class MentorLoggedPage : Form
    {
        CommonMethods CommonMethods = new CommonMethods();
        public static int logged_mentor_id;
        public MentorLoggedPage()
        {
            InitializeComponent();
        }

        private void MentorLoggedPage_Load(object sender, EventArgs e)
        {
            CommonMethods.FillDataGridView(Mentor_Page_Tasks_Table, CommonMethods.db.Students, CommonMethods.db.Task_Types, CommonMethods.db.Groups, CommonMethods.db.Teachers, CommonMethods.db.Mentors, CommonMethods.db.Tasks, logged_mentor_id);
            CommonMethods.FillDataGridView(Mentor_Page_Students_Table, CommonMethods.db.Genders, CommonMethods.db.Groups, CommonMethods.db.Mentors, CommonMethods.db.Teachers, CommonMethods.db.Students, logged_mentor_id);
        }

        private void AP_Exit_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new Form1());
        }

        private void Window_Close_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseApp();
        }
    }
}
