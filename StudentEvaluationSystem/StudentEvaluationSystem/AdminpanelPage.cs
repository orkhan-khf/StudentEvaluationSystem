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
			CommonMethods.FillDataGridView(Gender_Table, CommonMethods.db.Genders);
			CommonMethods.FillCombobox(Teacher_Gender, CommonMethods.db.Genders);
		}

		private void TextBoxChanged(object sender, KeyEventArgs e)
		{
			CommonMethods.TextBoxChanged(e, sender,
				"Gender_Name_Textbox", "Enter new gender", "Teacher_Name", "Enter name", "Teacher_Surname", "Enter surname", "Teacher_Phone", "Enter phone", "Teacher_Info", "Enter teacher info", "Teacher_Password", "Enter new password", "Teacher_Password_Confirm", "Confirm password", "Teacher_Email", "Enter e-mail"
				);
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
							CommonMethods.SuccessMsg("Operation success");
						}
						else
						{
							CommonMethods.ErrMsg("Image is not selected!");
						}

						//CommonMethods.FillDataGridView(Gender_Table, CommonMethods.db.Genders);
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
	}
}
