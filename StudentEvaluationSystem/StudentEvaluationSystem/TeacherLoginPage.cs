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
	public partial class TeacherLoginPage : Form
	{
		CommonMethods CommonMethods = new CommonMethods();
		string placeHolderString;
		public TeacherLoginPage()
		{
			InitializeComponent();
		}

		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void TeacherLoginPage_Load(object sender, EventArgs e)
		{
			CommonMethods.PlaceHolderMaker(Teacher_Login_Email, "Enter e-mail");
			CommonMethods.PlaceHolderMaker(Teacher_Login_Password, "Enter password");
		}

		private void TextBoxChanged(object sender, KeyPressEventArgs e)
		{
			TextBox currentTextBox = sender as TextBox;
            switch(currentTextBox.Name)
			{
				case "Teacher_Login_Email" :
					placeHolderString = "Enter e-mail";
					break;
				case "Teacher_Login_Password":
					placeHolderString = "Enter password";
					break;
			}
			CommonMethods.PlaceHolderEdit(currentTextBox, placeHolderString);
		}
    }
}
