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
    public partial class TeacherLoggedPage : Form
    {
        CommonMethods CommonMethods = new CommonMethods();
        public static int _logged_teacher_id;
        public TeacherLoggedPage()
        {
            InitializeComponent();
        }

        private void Window_Close_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseApp();
        }

        private void AP_Exit_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new Form1());
        }

        private void TeacherLoggedPage_Load(object sender, EventArgs e)
        {
            CommonMethods.FillCombobox(Add_Task_Task_Type_Id, CommonMethods.db.Task_Types);
            CommonMethods.FillCombobox(Add_Task_Group, CommonMethods.db.Groups,19);
            CommonMethods.FillCombobox(Add_Task_Student, CommonMethods.db.Students, CommonMethods.db.Groups, CommonMethods.db.Teachers, _logged_teacher_id);
            CommonMethods.FillDataGridView(Add_Task_Student_Table, CommonMethods.db.Tasks);
        }

        private void Add_Task_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Add_Task_Point.Text != "" && Add_Task_Source.Text != "" && Add_Task_Note.Text != "")
                {
                    DateTime task_start_date = Add_Task_Start_Date.Value;
                    DateTime task_end_date = Add_Task_End_Date.Value;
                    Task New_Task = new Task()
                    {
                        task_type_id = Convert.ToInt32(Add_Task_Task_Type_Id.SelectedValue),
                        task_start_date = task_start_date,
                        task_end_date = task_end_date,
                        task_point = Convert.ToInt32(Add_Task_Point.Text),
                        task_source = Add_Task_Source.Text,
                        task_note = Add_Task_Note.Text,
                        task_group_id = Convert.ToInt32(Add_Task_Group.SelectedValue),
                        task_student_id = Convert.ToInt32(Add_Task_Student.SelectedValue)
                    };
                    CommonMethods.db.Tasks.Add(New_Task);
                    CommonMethods.db.SaveChanges();
                    CommonMethods.SuccessMsg("Operation success");
                    CommonMethods.FillDataGridView(Add_Task_Student_Table, CommonMethods.db.Tasks);
                }
                else
                {
                    CommonMethods.ErrMsg("Please enter valid gender name!");
                }
            }
            catch
            {
                CommonMethods.ErrMsg("Operation failed. Please try again!");
            }
        }

        private void Add_Task_Student_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CommonMethods.UpdateDataGridTable(e, Add_Task_Student_Table);
        }

        private void Add_Task_Student_Table_KeyDown(object sender, KeyEventArgs e)
        {
            CommonMethods.DataGridViewDeleteSelectedRows(e, Add_Task_Student_Table, CommonMethods.db.Tasks);
        }
    }
}
