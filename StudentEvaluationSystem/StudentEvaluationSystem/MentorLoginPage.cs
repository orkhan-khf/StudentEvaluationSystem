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
    public partial class MentorLoginPage : Form
    {
        CommonMethods CommonMethods = new CommonMethods();
        private string placeHolderString;
        public MentorLoginPage()
        {
            InitializeComponent();
        }

        private void Window_Close_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseApp();
        }

        private void MentorLoginPage_Load(object sender, EventArgs e)
        {
            CommonMethods.PlaceHolderMaker(Mentor_Login_Email, "Enter e-mail");
            CommonMethods.PlaceHolderMaker(Mentor_Login_Password, "Enter password");
        }

        private void TextBoxChanged(object sender, KeyEventArgs e)
        {
            CommonMethods.TextBoxChanged(e, sender, "Mentor_Login_Email", "Enter e-mail", "Mentor_Login_Password", "Enter password");
        }

        private void Mentor_Pg_Back_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.OpenAnotherForm(this, new Form1());
        }

        private void Mentor_Pg_Mentor_Login_Btn_Click(object sender, EventArgs e)
        {
            CommonMethods.Login(this.Mentor_Login_Email, this.Mentor_Login_Password, CommonMethods.db.Mentors);
        }
    }
}
