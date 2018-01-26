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
	public partial class CurrentStudentsPage : Form
	{
		CommonMethods CommonMethods = new CommonMethods();
		public CurrentStudentsPage()
		{
			InitializeComponent();
		}

		private void CurrentStudentsPage_Load(object sender, EventArgs e)
		{
			CommonMethods.FillDataGridView(Students_Table, CommonMethods.db.Students);
			CommonMethods.ChangePictureBoxSource(Students_Table, Selected_Student_Picture, "student_photo");
		}

		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.CloseApp();
		}

		private void Students_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Students_Table);
		}

		private void Students_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Students_Table, CommonMethods.db.Students);
		}

		private void Mentor_Pg_Back_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.OpenAnotherForm(this, new AdminpanelPage());
		}

		private void Students_Table_SelectionChanged(object sender, EventArgs e)
		{
			CommonMethods.ChangePictureBoxSource(Students_Table, Selected_Student_Picture, "student_photo");
		}
	}
}
