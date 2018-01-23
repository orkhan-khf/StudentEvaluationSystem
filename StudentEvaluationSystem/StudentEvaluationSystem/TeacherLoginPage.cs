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
		public TeacherLoginPage()
		{
			InitializeComponent();
		}

		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
            CommonMethods.CloseApp();
		}

		private void TeacherLoginPage_Load(object sender, EventArgs e)
		{
            CommonMethods.PlaceHolderMaker(Teacher_Login_Email, "Enter e-mail");
			CommonMethods.PlaceHolderMaker(Teacher_Login_Password, "Enter password");
		}

		private void TextBoxChanged(object sender, KeyEventArgs e)
		{
            CommonMethods.TextBoxChanged(e, sender, "Teacher_Login_Email", "Enter e-mail", "Teacher_Login_Password", "Enter password");
        }

        private void Teacher_Pg_Back_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new Form1());
        }

        private void Teacher_Pg_Teacher_Login_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.Login(this.Teacher_Login_Email, this.Teacher_Login_Password, CommonMethods.db.Teachers);
        }
    }
}
