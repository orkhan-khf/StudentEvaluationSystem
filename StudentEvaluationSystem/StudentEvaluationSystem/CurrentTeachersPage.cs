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
	public partial class CurrentTeachersPage : Form
	{
		CommonMethods CommonMethods = new CommonMethods();
		public CurrentTeachersPage()
		{
			InitializeComponent();
		}

		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.CloseApp();
		}

		private void CurrentTeachersPage_Load(object sender, EventArgs e)
		{
			CommonMethods.FillDataGridView(Teachers_Table, CommonMethods.db.Teachers);
			CommonMethods.ChangePictureBoxSource(Teachers_Table, Selected_Teacher_Picture, "teacher_photo");
		}

		private void Teachers_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Teachers_Table);
		}

		private void Teachers_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Teachers_Table, CommonMethods.db.Teachers);
		}

		private void Teacher_Pg_Back_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.OpenAnotherForm(this, new AdminpanelPage());
		}

		private void Teachers_Table_SelectionChanged(object sender, EventArgs e)
		{
			CommonMethods.ChangePictureBoxSource(Teachers_Table, Selected_Teacher_Picture, "teacher_photo");
		}
	}
}
