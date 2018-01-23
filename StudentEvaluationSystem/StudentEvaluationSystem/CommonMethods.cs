using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Entity;

namespace StudentEvaluationSystem
{
	class CommonMethods
	{
        public StudentEvaluationSystemDBEntities db = new StudentEvaluationSystemDBEntities();
        

		//bos textboxlarin icine placeholder elave edib rengini gray edir (sehife load olanda)
		public void PlaceHolderMaker(TextBox _textbox, string _placeholder)
		{
			if (_textbox.Text == "")
			{
				_textbox.Text = _placeholder;
				_textbox.ForeColor = Color.Gray;
            }
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

        public static void Login(TextBox _email,TextBox _password,DbSet<Teacher> _table)
        {
            var query = _table.Where(p => p.teacher_email == _email.Text && p.teacher_password == _password.Text);
            if(query.Count() > 0)
            {
                MessageBox.Show("logged in");
            }
            else
            {
                MessageBox.Show("Wrong Email or Password!");
            }
        }
        public static void Login(TextBox _email, TextBox _password, DbSet<Student> _table)
        {
            MessageBox.Show("Student login");
        }
        public static void Login(TextBox _email, TextBox _password, DbSet<Mentor> _table)
        {
            MessageBox.Show("Mentor login");
        }
    }
}
