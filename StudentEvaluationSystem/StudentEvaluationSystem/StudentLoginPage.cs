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
    public partial class StudentLoginPage : Form
    {
        CommonMethods CommonMethods = new CommonMethods();
        private string placeHolderString;
        public StudentLoginPage()
        {
            InitializeComponent();
        }

        private void Window_Close_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseApp();
        }

        private void StudentLoginPage_Load(object sender, EventArgs e)
        {
            CommonMethods.PlaceHolderMaker(Student_Login_Email , "Enter e-mail");
            CommonMethods.PlaceHolderMaker(Student_Login_Password, "Enter password");
        }

        private void TextBoxChanged(object sender, KeyEventArgs e)
        {
            CommonMethods.TextBoxChanged(e, sender, "Student_Login_Email", "Enter e-mail", "Student_Login_Password", "Enter password");
        }

        private void Student_Pg_Back_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new Form1());
        }

        private void Student_Pg_Student_Login_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.Login(Student_Login_Email, Student_Login_Password, CommonMethods.db.Students, this);
        }
    }
}
