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
	public partial class CurrentMentorsPage : Form
	{
		CommonMethods CommonMethods = new CommonMethods();
		public CurrentMentorsPage()
		{
			InitializeComponent();
		}

		private void Window_Close_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.CloseApp();
		}

		private void CurrentMentorsPage_Load(object sender, EventArgs e)
		{
			CommonMethods.FillDataGridView(Mentors_Table, CommonMethods.db.Mentors);
			CommonMethods.ChangePictureBoxSource(Mentors_Table, Selected_Mentor_Picture, "mentor_photo");
		}

		private void Mentors_Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CommonMethods.UpdateDataGridTable(e, Mentors_Table);
		}

		private void Mentors_Table_KeyDown(object sender, KeyEventArgs e)
		{
			CommonMethods.DataGridViewDeleteSelectedRows(e, Mentors_Table, CommonMethods.db.Mentors);
		}

		private void Mentor_Pg_Back_Btn_Click(object sender, EventArgs e)
		{
			CommonMethods.OpenAnotherForm(this, new AdminpanelPage());
		}

		private void Mentors_Table_SelectionChanged(object sender, EventArgs e)
		{
			CommonMethods.ChangePictureBoxSource(Mentors_Table, Selected_Mentor_Picture, "mentor_photo");
		}
	}
}
