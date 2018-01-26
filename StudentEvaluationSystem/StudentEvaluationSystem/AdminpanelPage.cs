using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEvaluationSystem
{
	public partial class AdminpanelPage : Form
	{
		CommonMethods CommonMethods = new CommonMethods();
		public AdminpanelPage()
		{
			InitializeComponent();
		}

		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.CloseApp();
		}

		private void AdminpanelPage_Load(object sender, EventArgs e)
		{
			CommonMethods.PlaceHolderMaker(Gender_Name_Textbox, "Enter new gender");
			CommonMethods.PlaceHolderMaker(Teacher_Name, "Enter name");
			CommonMethods.PlaceHolderMaker(Teacher_Surname, "Enter surname");
			CommonMethods.PlaceHolderMaker(Teacher_Phone, "Enter phone");
			CommonMethods.PlaceHolderMaker(Teacher_Info, "Enter teacher info");
			CommonMethods.PlaceHolderMaker(Teacher_Password, "Enter new password");
			CommonMethods.PlaceHolderMaker(Teacher_Password_Confirm, "Confirm password");
			CommonMethods.PlaceHolderMaker(Teacher_Email, "Enter e-mail");
			CommonMethods.PlaceHolderMaker(Mentor_Name, "Enter name");
			CommonMethods.PlaceHolderMaker(Mentor_Surname, "Enter surname");
			CommonMethods.PlaceHolderMaker(Mentor_Email, "Enter e-mail");
			CommonMethods.PlaceHolderMaker(Mentor_Password, "Enter new password");
			CommonMethods.PlaceHolderMaker(Mentor_Password_Confirm, "Confirm password");
			CommonMethods.PlaceHolderMaker(Mentor_Phone, "Enter phone");
			CommonMethods.PlaceHolderMaker(Mentor_Info, "Enter mentor info");
			CommonMethods.PlaceHolderMaker(Task_Type_Name, "Enter task type name");
			CommonMethods.PlaceHolderMaker(Task_Type_Rate, "Enter task type rate");
			CommonMethods.PlaceHolderMaker(Group_Schedule_Name, "Enter group schedule name");
			CommonMethods.PlaceHolderMaker(Group_Type_Name, "Enter group type name");
			CommonMethods.PlaceHolderMaker(Group_Name, "Enter group name");
			CommonMethods.PlaceHolderMaker(Student_Name, "Enter name");
			CommonMethods.PlaceHolderMaker(Student_Surname, "Enter surname");
			CommonMethods.PlaceHolderMaker(Student_Phone, "Enter phone");
			CommonMethods.PlaceHolderMaker(Student_Info, "Enter student info");
			CommonMethods.PlaceHolderMaker(Student_Password, "Enter new password");
			CommonMethods.PlaceHolderMaker(Student_Password_Confirm, "Confirm password");
			CommonMethods.PlaceHolderMaker(Student_Email, "Enter e-mail");
			CommonMethods.PlaceHolderMaker(Student_Github_Account, "Enter github URL");
			CommonMethods.FillDataGridView(Gender_Table, CommonMethods.db.Genders);
			CommonMethods.FillCombobox(Teacher_Gender, CommonMethods.db.Genders);
			CommonMethods.FillCombobox(Mentor_Gender, CommonMethods.db.Genders);
			CommonMethods.FillCombobox(Mentor_Gender, CommonMethods.db.Genders);
			CommonMethods.FillCombobox(Group_Schedule_Id, CommonMethods.db.Group_Schedule);
			CommonMethods.FillCombobox(Group_Type_Id, CommonMethods.db.Group_Types);
			CommonMethods.FillCombobox(Group_Teacher_Id, CommonMethods.db.Teachers);
			CommonMethods.FillCombobox(Student_Gender, CommonMethods.db.Genders);
			CommonMethods.FillCombobox(Student_Group, CommonMethods.db.Groups);
		}

		private void TextBoxChanged(object sender, KeyEventArgs e)
		{
			CommonMethods.TextBoxChanged(e, sender, "Gender_Name_Textbox", "Enter new gender", "Teacher_Name", "Enter name", "Teacher_Surname", "Enter surname", "Teacher_Phone", "Enter phone", "Teacher_Info", "Enter teacher info", "Teacher_Password", "Enter new password", "Teacher_Password_Confirm", "Confirm password", "Teacher_Email", "Enter e-mail", "Mentor_Name", "Enter name", "Mentor_Surname", "Enter surname", "Mentor_Email", "Enter e-mail", "Mentor_Password", "Enter new password", "Mentor_Password_Confirm", "Confirm password", "Mentor_Phone", "Enter phone", "Mentor_Info", "Enter mentor info", "Task_Type_Name", "Enter task type name", "Task_Type_Rate", "Enter task type rate", "Group_Schedule_Name", "Enter group schedule name", "Group_Type_Name", "Enter group type name", "Group_Name", "Enter group name", "Student_Name", "Enter name", "Student_Surname", "Enter surname", "Student_Phone", "Enter phone", "Student_Info", "Enter student info", "Student_Password", "Enter new password", "Student_Password_Confirm", "Confirm password", "Student_Email", "Enter e-mail", "Student_Github_Account", "Enter github URL");
		}

		private void Adminpanel_Gender_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Adminpanel_Gender.SelectedIndex == 3)
			{
				CommonMethods.FillDataGridView(Task_Types_Table, CommonMethods.db.Task_Types);
			}
			else if (Adminpanel_Gender.SelectedIndex == 4)
			{
				CommonMethods.FillDataGridView(Group_Schedules_Table, CommonMethods.db.Group_Schedule);
			}
			else if (Adminpanel_Gender.SelectedIndex == 5)
			{
				CommonMethods.FillDataGridView(Group_Schedules_Table, CommonMethods.db.Group_Schedule);
				CommonMethods.FillDataGridView(Group_Types_Table, CommonMethods.db.Group_Types);
			}
			else if (Adminpanel_Gender.SelectedIndex == 6)
			{
				CommonMethods.FillDataGridView(Groups_Table, CommonMethods.db.Groups);
				CommonMethods.FillCombobox(Group_Mentor_Id, CommonMethods.db.Mentors);
			}
		}
		private void Student_Pg_Back_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.OpenAnotherForm(this, new TeacherLoginPage());
		}

		private void Teacher_Pg_Gender_Add_Btn_Click(object sender, EventArgs e)
		{
			try{
				if(Gender_Name_Textbox.Text != "" && Gender_Name_Textbox.Text != "Enter new gender")
				{
					Gender New_Gender = new Gender()
					{
						gender_name = Gender_Name_Textbox.Text
					};
					CommonMethods.db.Genders.Add(New_Gender);
					CommonMethods.db.SaveChanges();
					CommonMethods.PlaceHolderMaker(Gender_Name_Textbox, "Enter new gender");
					CommonMethods.SuccessMsg("Operation success");
					CommonMethods.FillDataGridView(Gender_Table, CommonMethods.db.Genders);
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

		private void Gender_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Gender_Table, CommonMethods.db.Genders);
		}
		
		private void Gender_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Gender_Table);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (Teacher_Name.Text != "" && Teacher_Name.Text != "Enter name" && Teacher_Surname.Text != "" && Teacher_Surname.Text != "Enter surname" && Teacher_Email.Text != "" && Teacher_Email.Text != "Enter e-mail" && Teacher_Password.Text != "" && Teacher_Password.Text != "Enter new password" && Teacher_Password_Confirm.Text != "" && Teacher_Password_Confirm.Text != "Confirm password" && Teacher_Phone.Text != "" && Teacher_Phone.Text != "Enter phone" && Teacher_Info.Text != "" && Teacher_Info.Text != "Enter teacher info")
				{
					if (Teacher_Password.Text == Teacher_Password_Confirm.Text)
					{
						if (CommonMethods.imgSelected)
						{
							File.Copy(CommonMethods.imgPathAndName, @"../../images/" + CommonMethods.imgName);
							Teacher New_Teacher = new Teacher()
							{
								teacher_name = Teacher_Name.Text,
								teacher_surname = Teacher_Surname.Text,
								teacher_email = Teacher_Email.Text,
								teacher_phone = Convert.ToInt32(Teacher_Phone.Text),
								teacher_info = Teacher_Info.Text,
								teacher_password = CommonMethods.MD5Hash(Teacher_Password.Text),
								teacher_gender_id = CommonMethods.GetComboBoxId(Teacher_Gender),
								teacher_photo = CommonMethods.imgName
							};
							CommonMethods.db.Teachers.Add(New_Teacher);
							CommonMethods.db.SaveChanges();
							CommonMethods.PlaceHolderMaker(Teacher_Name, "Enter name");
							CommonMethods.PlaceHolderMaker(Teacher_Surname, "Enter surname");
							CommonMethods.PlaceHolderMaker(Teacher_Phone, "Enter phone");
							CommonMethods.PlaceHolderMaker(Teacher_Info, "Enter teacher info");
							CommonMethods.PlaceHolderMaker(Teacher_Password, "Enter new password");
							CommonMethods.PlaceHolderMaker(Teacher_Password_Confirm, "Confirm password");
							CommonMethods.PlaceHolderMaker(Teacher_Email, "Enter e-mail");
							CommonMethods.ResetPasswordTextboxes(Teacher_Password, Teacher_Password_Confirm);
							CommonMethods.SuccessMsg("Operation success");
						}
						else
						{
							CommonMethods.ErrMsg("Image is not selected!");
						}
					}
					else
					{
						CommonMethods.ErrMsg("Passwords is not same!");
					}
				}
				else
				{
					CommonMethods.ErrMsg("Please enter valid informations!");
				}
			}
			catch
			{
				CommonMethods.ErrMsg("Operation failed. Please try again!");
			}
		}

		private void Select_Teacher_Photo_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.SelectPhoto("Select Teacher Photo", "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png");
		}

		private void Show_Current_Teachers_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.OpenAnotherForm(this, new CurrentTeachersPage());
		}

		private void Select_Mentor_Photo_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.SelectPhoto("Select Mentor Photo", "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png");
		}

		private void Add_New_Mentor_Btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (Mentor_Name.Text != "" && Mentor_Name.Text != "Enter name" && Mentor_Surname.Text != "" && Mentor_Surname.Text != "Enter surname" && Mentor_Email.Text != "" && Mentor_Email.Text != "Enter e-mail" && Mentor_Password.Text != "" && Mentor_Password.Text != "Enter new password" && Mentor_Password_Confirm.Text != "" && Mentor_Password_Confirm.Text != "Confirm password" && Mentor_Phone.Text != "" && Mentor_Phone.Text != "Enter phone" && Mentor_Info.Text != "" && Mentor_Info.Text != "Enter mentor info")
				{
					if (Mentor_Password.Text == Mentor_Password_Confirm.Text)
					{
						if (CommonMethods.imgSelected)
						{
							File.Copy(CommonMethods.imgPathAndName, @"../../images/" + CommonMethods.imgName);
							Mentor New_Mentor = new Mentor()
							{
								mentor_name = Mentor_Name.Text,
								mentor_surname = Mentor_Surname.Text,
								mentor_email = Mentor_Email.Text,
								mentor_phone = Convert.ToInt32(Mentor_Phone.Text),
								mentor_info = Mentor_Info.Text,
								mentor_password = CommonMethods.MD5Hash(Mentor_Password.Text),
								mentor_gender_id = CommonMethods.GetComboBoxId(Mentor_Gender),
								mentor_photo = CommonMethods.imgName
							};
							CommonMethods.db.Mentors.Add(New_Mentor);
							CommonMethods.db.SaveChanges();
							CommonMethods.PlaceHolderMaker(Mentor_Name, "Enter name");
							CommonMethods.PlaceHolderMaker(Mentor_Surname, "Enter surname");
							CommonMethods.PlaceHolderMaker(Mentor_Email, "Enter e-mail");
							CommonMethods.PlaceHolderMaker(Mentor_Password, "Enter new password");
							CommonMethods.PlaceHolderMaker(Mentor_Password_Confirm, "Confirm password");
							CommonMethods.PlaceHolderMaker(Mentor_Phone, "Enter phone");
							CommonMethods.PlaceHolderMaker(Mentor_Info, "Enter mentor info");
							CommonMethods.ResetPasswordTextboxes(Mentor_Password, Mentor_Password_Confirm);
							CommonMethods.SuccessMsg("Operation success");
						}
						else
						{
							CommonMethods.ErrMsg("Image is not selected!");
						}
					}
					else
					{
						CommonMethods.ErrMsg("Passwords is not same!");
					}
				}
				else
				{
					CommonMethods.ErrMsg("Please enter valid informations!");
				}
			}
			catch
			{
				CommonMethods.ErrMsg("Operation failed. Please try again!");
			}
		}

		private void Show_Current_Mentors_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.OpenAnotherForm(this, new CurrentMentorsPage());
		}

		private void Add_New_Task_Type_Btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (Task_Type_Name.Text != "" && Task_Type_Name.Text != "Enter task type name" && Task_Type_Rate.Text != "" && Task_Type_Rate.Text != "Enter task type rate")
				{
					Task_Types New_Task_Type = new Task_Types()
					{
						task_type_name = Task_Type_Name.Text,
						task_type_rate = Convert.ToDouble(Task_Type_Rate.Text)
					};
					CommonMethods.db.Task_Types.Add(New_Task_Type);
					CommonMethods.db.SaveChanges();
					CommonMethods.SuccessMsg("Operation success");
					CommonMethods.PlaceHolderMaker(Task_Type_Name, "Enter task type name");
					CommonMethods.PlaceHolderMaker(Task_Type_Rate, "Enter task type rate");
					CommonMethods.FillDataGridView(Task_Types_Table, CommonMethods.db.Task_Types);
				}
				else
				{
					CommonMethods.ErrMsg("Please enter valid informations!");
				}
			}
			catch
			{
				CommonMethods.ErrMsg("Operation failed. Please try again!");
			}
		}
		private void Task_Types_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Task_Types_Table);
		}

		private void Task_Types_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Task_Types_Table, CommonMethods.db.Task_Types);
		}

		private void Add_New_Group_Schedule_Btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (Group_Schedule_Name.Text != "" && Group_Schedule_Name.Text != "Enter group schedule name")
				{
					TimeSpan get_timespan = Group_Schedule_Begin_Time.Value.TimeOfDay;
					TimeSpan begin_time = new TimeSpan(get_timespan.Hours, get_timespan.Minutes, 0);
					TimeSpan get_timespan2 = Group_Schedule_End_Time.Value.TimeOfDay;
					TimeSpan end_time = new TimeSpan(get_timespan2.Hours, get_timespan2.Minutes, 0);
					Group_Schedule New_Group_Schedule = new Group_Schedule()
					{
						group_schedule_name = Group_Schedule_Name.Text,
						group_begin_time = begin_time,
						group_end_time = end_time
					};
					CommonMethods.db.Group_Schedule.Add(New_Group_Schedule);
					CommonMethods.db.SaveChanges();
					CommonMethods.SuccessMsg("Operation success");
					CommonMethods.PlaceHolderMaker(Group_Schedule_Name, "Enter group schedule name");
					CommonMethods.FillDataGridView(Group_Schedules_Table, CommonMethods.db.Group_Schedule);
				}
				else
				{
					CommonMethods.ErrMsg("Please enter valid informations!");
				}
			}
			catch
			{
				CommonMethods.ErrMsg("Operation failed. Please try again!");
			}
		}


		private void Group_Schedules_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Group_Schedules_Table);
		}

		private void Group_Schedules_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Group_Schedules_Table, CommonMethods.db.Group_Schedule);
		}

		private void Add_New_Group_Type_Btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (Group_Type_Name.Text != "" && Group_Type_Name.Text != "Enter group type name")
				{
					Group_Types New_Group_Type = new Group_Types()
					{
						group_type_name = Group_Type_Name.Text,
						group_schedule_id = Convert.ToInt32(Group_Schedule_Id.SelectedValue)
					};
					CommonMethods.db.Group_Types.Add(New_Group_Type);
					CommonMethods.db.SaveChanges();
					CommonMethods.SuccessMsg("Operation success");
					CommonMethods.PlaceHolderMaker(Group_Type_Name, "Enter group type name");
					CommonMethods.FillDataGridView(Group_Types_Table, CommonMethods.db.Group_Types);
				}
				else
				{
					CommonMethods.ErrMsg("Please enter valid informations!");
				}
			}
			catch
			{
				CommonMethods.ErrMsg("Operation failed. Please try again!");
			}
		}

		private void Group_Types_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Group_Types_Table, CommonMethods.db.Group_Types);
		}

		private void Group_Types_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Group_Types_Table);
		}

		private void Add_New_Group_Btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (Group_Name.Text != "" && Group_Name.Text != "Enter group name")
				{
					DateTime group_start_date = Group_Start_Date.Value;
					Group New_Group = new Group()
					{
						group_name = Group_Name.Text,
						group_type_id = Convert.ToInt32(Group_Type_Id.SelectedValue),
						group_teacher_id = Convert.ToInt32(Group_Teacher_Id.SelectedValue),
						group_mentor_id = Convert.ToInt32(Group_Mentor_Id.SelectedValue),
						group_start_date = group_start_date
					};
					CommonMethods.db.Groups.Add(New_Group);
					CommonMethods.db.SaveChanges();
					CommonMethods.SuccessMsg("Operation success");
					CommonMethods.PlaceHolderMaker(Group_Name, "Enter group name");
					CommonMethods.FillDataGridView(Groups_Table, CommonMethods.db.Groups);
				}
				else
				{
					CommonMethods.ErrMsg("Please enter valid informations!");
				}
			}
			catch
			{
				CommonMethods.ErrMsg("Operation failed. Please try again!");
			}
		}

		private void Groups_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Groups_Table);
		}

		private void Groups_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Groups_Table, CommonMethods.db.Groups);
		}

		private void Select_Student_Photo_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.SelectPhoto("Select Student Photo", "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png");
		}

		private void Add_New_Student_Btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (Student_Name.Text != "" && Student_Name.Text != "Enter name" && Student_Surname.Text != "" && Student_Surname.Text != "Enter surname" && Student_Phone.Text != "" && Student_Phone.Text != "Enter phone" && Student_Info.Text != "" && Student_Info.Text != "Enter student info" && Student_Password.Text != "" && Student_Password.Text != "Enter new password" && Student_Password_Confirm.Text != "" && Student_Password_Confirm.Text != "Confirm password" && Student_Email.Text != "" && Student_Email.Text != "Enter e-mail" && Student_Github_Account.Text != "" && Student_Github_Account.Text != "Enter github URL")
				{
					if (Student_Password.Text == Student_Password_Confirm.Text)
					{
						if (CommonMethods.imgSelected)
						{
							File.Copy(CommonMethods.imgPathAndName, @"../../images/" + CommonMethods.imgName);
							Student New_Student = new Student()
							{
								student_name = Student_Name.Text,
								student_surname = Student_Surname.Text,
								student_email = Student_Email.Text,
								student_phone = Convert.ToInt32(Student_Phone.Text),
								student_github_account = Student_Github_Account.Text,
								student_info = Student_Info.Text,
								student_photo = CommonMethods.imgName,
								student_cap_point = 0,
								student_group_id = CommonMethods.GetComboBoxId(Student_Group),
								student_gender_id = CommonMethods.GetComboBoxId(Student_Gender),
								student_password = CommonMethods.MD5Hash(Student_Password.Text)
							};
							CommonMethods.db.Students.Add(New_Student);
							CommonMethods.db.SaveChanges();
							CommonMethods.PlaceHolderMaker(Student_Name, "Enter name");
							CommonMethods.PlaceHolderMaker(Student_Surname, "Enter surname");
							CommonMethods.PlaceHolderMaker(Student_Phone, "Enter phone");
							CommonMethods.PlaceHolderMaker(Student_Info, "Enter student info");
							CommonMethods.PlaceHolderMaker(Student_Password, "Enter new password");
							CommonMethods.PlaceHolderMaker(Student_Password_Confirm, "Confirm password");
							CommonMethods.PlaceHolderMaker(Student_Email, "Enter e-mail");
							CommonMethods.PlaceHolderMaker(Student_Github_Account, "Enter github URL");
							CommonMethods.ResetPasswordTextboxes(Student_Password, Student_Password_Confirm);
							CommonMethods.SuccessMsg("Operation success");
						}
						else
						{
							CommonMethods.ErrMsg("Image is not selected!");
						}
					}
					else
					{
						CommonMethods.ErrMsg("Passwords is not same!");
					}
				}
				else
				{
					CommonMethods.ErrMsg("Please enter valid informations!");
				}
			}
			catch
			{
				CommonMethods.ErrMsg("Operation failed. Please try again!");
			}
		}

		private void Show_Current_Students_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.OpenAnotherForm(this, new CurrentStudentsPage());
		}
	}
}
