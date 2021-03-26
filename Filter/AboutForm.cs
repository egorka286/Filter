using System;
using System.Windows.Forms;

namespace Filter
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}
		private void okButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
