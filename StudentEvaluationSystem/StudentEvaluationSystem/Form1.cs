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
	public partial class Form1 : Form
	{
        CommonMethods CommonMethods = new CommonMethods();
		public Form1()
		{
			InitializeComponent();
		}
		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
            CommonMethods.CloseApp();
		}

		private void Teacher_Login_Btn_Click(object sender, EventArgs e)
		{
            CommonMethods.OpenAnotherForm(this, new TeacherLoginPage());
		}

        private void Mentor_Login_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new MentorLoginPage());
        }

        private void Main_Pg_Student_Login_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new StudentLoginPage());
        }
    }
}
