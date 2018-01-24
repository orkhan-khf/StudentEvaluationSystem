﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Cryptography;

namespace StudentEvaluationSystem
{
	class CommonMethods
	{
        public StudentEvaluationSystemDBEntities db = new StudentEvaluationSystemDBEntities();
		OpenFileDialog file = new OpenFileDialog();
		public static string imgPathAndName = "";
		public static string imgName = "";
		public static bool imgSelected = false;

		//bos textboxlarin icine placeholder elave edib rengini gray edir (sehife load olanda)
		public void PlaceHolderMaker(TextBox _textbox, string _placeholder)
		{
			_textbox.Text = _placeholder;
			_textbox.ForeColor = Color.Gray;
		}





		//icinde placeholder olan textboxlarin icinde keypress olanda bosaldir ve yazi rengini qara edir (password textboslarin Name'sinde mutleq Password sozu kecmelidir ki, * isaresi ile kamuflaj olsun)
		public void PlaceHolderEdit(TextBox _textbox, string _placeholder)
        {
            if (_textbox.Text == _placeholder)
            {
                _textbox.Text = "";
                _textbox.ForeColor = Color.Black;
                if (_textbox.Name.Contains("Password"))
                {
                    _textbox.PasswordChar = Convert.ToChar("*");
                }
            }
		}





		//istifadeci textboxa enterden basqa her hansisa bir duyme ile keydown ederse textbox ici bosalir ve sonra daxil edilen deyer icine yazilir
		public void TextBoxChanged(KeyEventArgs _e, object _sender, string _login_field_name, string _login_field_placeholder, string _password_field_name, string _password_field_placeholder)
        {
            //istifadeci enterlere klik edende hecne etmesin. (bu olmayanda entere klik edende istifadecinin daxil etdiyi texti bosaldirdi)
            if (_e.KeyCode == Keys.Enter)
            {
                _e.SuppressKeyPress = true;
            }
            if (_e.KeyCode != Keys.Enter)
            {
                TextBox currentTextBox = _sender as TextBox;
                var placeHolderString = "";
                //place holderin deyeri tapilir mes. "enter e-mail" ve textbox obyekti ile beraber PlaceHolderEdit methoduna parameter kimi gonderilir
                if (currentTextBox.Name == _login_field_name)
                {
                    placeHolderString = _login_field_placeholder;
                }else if (currentTextBox.Name == _password_field_name)
                {
                    placeHolderString = _password_field_placeholder;
                }
                this.PlaceHolderEdit(currentTextBox, placeHolderString);
            }
        }
		//overload 1 for TextBoxChanged method
		public void TextBoxChanged(KeyEventArgs _e, object _sender, string field_1, string field_1_placeholder, string field_2, string field_2_placeholder, string field_3, string field_3_placeholder, string field_4, string field_4_placeholder, string field_5, string field_5_placeholder, string field_6, string field_6_placeholder, string field_7, string field_7_placeholder, string field_8, string field_8_placeholder)
		{
			//istifadeci enterlere klik edende hecne etmesin. (bu olmayanda entere klik edende istifadecinin daxil etdiyi texti bosaldirdi)
			if (_e.KeyCode == Keys.Enter)
			{
				_e.SuppressKeyPress = true;
			}
			if (_e.KeyCode != Keys.Enter)
			{
				TextBox currentTextBox = _sender as TextBox;
				var placeHolderString = "";
				//place holderin deyeri tapilir mes. "enter e-mail" ve textbox obyekti ile beraber PlaceHolderEdit methoduna parameter kimi gonderilir
				if (currentTextBox.Name == field_1)
				{
					placeHolderString = field_1_placeholder;
				}else if (currentTextBox.Name == field_2)
				{
					placeHolderString = field_2_placeholder;
				}
				else if (currentTextBox.Name == field_3)
				{
					placeHolderString = field_3_placeholder;
				}
				else if (currentTextBox.Name == field_4)
				{
					placeHolderString = field_4_placeholder;
				}
				else if (currentTextBox.Name == field_5)
				{
					placeHolderString = field_5_placeholder;
				}
				else if (currentTextBox.Name == field_6)
				{
					placeHolderString = field_6_placeholder;
				}
				else if (currentTextBox.Name == field_7)
				{
					placeHolderString = field_7_placeholder;
				}
				else if (currentTextBox.Name == field_8)
				{
					placeHolderString = field_8_placeholder;
				}
				this.PlaceHolderEdit(currentTextBox, placeHolderString);
			}
		}

		//Sehifelerde X buttonuna klik edende programdan cixis verir
		public void CloseApp()
        {
            Application.Exit();
		}





		//Bir formdan basqa bir forma getmek ucun istifade edilir
		public void OpenAnotherForm(Form _current_form, Form _target_form)
        {
            _current_form.Visible = false;
            _target_form.Visible = true;
		}





		//Teacher / Student / Mentor / Admin login method'lari
		public void Login(TextBox _email,TextBox _password,DbSet<Teacher> _table, Form _current_login_page)
        {
			if (_email.Text == "a" && _password.Text == "a")
			{
				OpenAnotherForm(_current_login_page, new AdminpanelPage());
			}
			else
			{
				string md5Pass = MD5Hash(_password.Text);
				var query = _table.Where(p => p.teacher_email == _email.Text && p.teacher_password == md5Pass);
				if (query.Count() > 0)
				{
					MessageBox.Show("simple teacher");
				}
				else
				{
					MessageBox.Show("Wrong Email or Password!");
				}
			}
        }
        public void Login(TextBox _email, TextBox _password, DbSet<Student> _table)
        {
            MessageBox.Show("Student login");
        }
        public void Login(TextBox _email, TextBox _password, DbSet<Mentor> _table)
        {
            MessageBox.Show("Mentor login");
		}





		//Error mesaji
		public void ErrMsg(string _err)
		{
			MessageBox.Show(_err);
		}




		
		//Success mesaji
		public void SuccessMsg(string _msg)
		{
			MessageBox.Show(_msg);
		}





		//datagridview melumatlari cekmek ucun
		public void FillDataGridView(DataGridView _grid_table, DbSet<Gender> _table)
		{
			_grid_table.DataSource = _table.ToList();
			_grid_table.Columns.Remove("Mentors");
			_grid_table.Columns.Remove("Students");
			_grid_table.Columns.Remove("Teachers");
		}
		//overload 1
		public void FillDataGridView(DataGridView _grid_table, DbSet<Teacher> _table)
		{
			_grid_table.DataSource = _table.ToList();
			_grid_table.Columns.Remove("teacher_password");
			_grid_table.Columns.Remove("Gender");
			_grid_table.Columns.Remove("Groups");
		}





		//datagridview delete basanda silsin
		public void DataGridViewDeleteSelectedRows(KeyEventArgs _e, DataGridView _grid_table, DbSet<Gender> _table)
		{
			if (_e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Are you sure you want to delete this data?", "Warning", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
				{
					try
					{
						int selected_row_id = Convert.ToInt32(_grid_table.SelectedCells[0].Value);
						var element = _table.SingleOrDefault(r => r.id == selected_row_id);
						if (element != null)
						{
							_table.Remove(element);
							db.SaveChanges();
							SuccessMsg("Row deleted!");
							_grid_table.DataSource = null;
							FillDataGridView(_grid_table, _table);
						}
						else
						{
							ErrMsg("Row not found! Please close and open window than try again.");
						}
					}
					catch
					{
						ErrMsg("Operation failed. Please try again!");
					}
				}
			}
		}
		//overload1
		public void DataGridViewDeleteSelectedRows(KeyEventArgs _e, DataGridView _grid_table, DbSet<Teacher> _table)
		{
			if (_e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Are you sure you want to delete this data?", "Warning", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
				{
					try
					{
						int selected_row_id = Convert.ToInt32(_grid_table.SelectedCells[0].Value);
						var element = _table.SingleOrDefault(r => r.id == selected_row_id);
						if (element != null)
						{
							_table.Remove(element);
							db.SaveChanges();
							SuccessMsg("Row deleted!");
							_grid_table.DataSource = null;
							FillDataGridView(_grid_table, _table);
						}
						else
						{
							ErrMsg("Row not found! Please close and open window than try again.");
						}
					}
					catch
					{
						ErrMsg("Operation failed. Please try again!");
					}
				}
			}
		}





		//datagridviewde deyisiklik olunub bitdikden sonra update edir
		public void UpdateDataGridTable(DataGridViewCellEventArgs _e, DataGridView _grid_table)
		{
			try
			{
				_grid_table.EndEdit();
				db.SaveChanges();
				SuccessMsg("Changes has been saved!");
			}
			catch
			{
				ErrMsg("Operation failed. Please try again!");
			}
		}





		//comboboxlari doldurur
		public void FillCombobox(ComboBox _comboBox, DbSet<Gender> _table)
		{
			_comboBox.DataSource = _table.ToList();
			_comboBox.DisplayMember = "gender_name";
			_comboBox.ValueMember = "id";
		}





		//comboboxun select olunan item'inin id adresini al
		public int GetComboBoxId(ComboBox _comboBox)
		{
			int id = Convert.ToInt32(_comboBox.SelectedValue);
			return id;
		}





		//md5 sifreleme
		public static string MD5Hash(string text)
		{
			MD5 md5 = new MD5CryptoServiceProvider();
			md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
			byte[] result = md5.Hash;
			StringBuilder strBuilder = new StringBuilder();
			for (int i = 0; i < result.Length; i++)
			{
				strBuilder.Append(result[i].ToString("x2"));
			}
			return strBuilder.ToString();
		}





		//sekil secmek ucun
		public void SelectPhoto(string _title, string _filter)
		{
			file.Title = _title;
			file.Filter = _filter;
			if (file.ShowDialog() == DialogResult.OK)
			{
				imgSelected = true;
				imgPathAndName = file.FileName;
				imgName = file.SafeFileName;
			}
		}




		//gridview'da secilen rowun phoo column'unun deyerini goturur ve picturebox'un source'na beraber edir
		public void ChangePictureBoxSource(DataGridView _grid_table, PictureBox _pictureBox, string _cell_name)
		{
			if (_grid_table.SelectedCells.Count > 0)
			{
				int selectedrowindex = _grid_table.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = _grid_table.Rows[selectedrowindex];
				string a = Convert.ToString(selectedRow.Cells[_cell_name].Value);
				_pictureBox.ImageLocation = @"../../images/" + a;
			}
		}
}
}
