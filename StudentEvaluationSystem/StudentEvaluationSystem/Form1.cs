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
		public Form1()
		{
			InitializeComponent();
		}
		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Teacher_Login_Btn_Click(object sender, EventArgs e)
		{
			TeacherLoginPage teacherLoginPage = new TeacherLoginPage();
			teacherLoginPage.Visible = true;
			this.Visible = false;
		}
	}
}