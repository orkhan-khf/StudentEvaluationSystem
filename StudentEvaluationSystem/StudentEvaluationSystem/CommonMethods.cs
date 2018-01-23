using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StudentEvaluationSystem
{
	class CommonMethods
	{
		//bos textboxlarin icine placeholder elave edir
		public void PlaceHolderMaker(TextBox _textbox, string _placeholder)
		{

			if (_textbox.Text == "")
			{
				_textbox.Text = _placeholder;
				_textbox.ForeColor = Color.Gray;
			}//textboxa hecne yazmadan textboxu tek edende placeholderi berpa edir
			else if(_textbox.Text == _placeholder)
			{
				_textbox.Text = "";
				_textbox.ForeColor = Color.Black;
			}
		}
	}
}
