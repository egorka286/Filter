using System;
using System.Windows.Forms;

namespace Filter
{
	public partial class AddWagonForm : Form
	{
		public int WagonNumber { get; private set; }
		public DateTime FilterDate { get; private set; }
		public string Surname { get; private set; }
		public string FilterType { get; private set; }
		public string WagonType { get; private set; }

		public AddWagonForm()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			int num;
			if (int.TryParse(wagonNumberTextBox.Text, out num) && num >= 1000 && num <= 99999)
			{
				WagonNumber = num;
				FilterDate = filterDate.Value;
				Surname = surnameTextBox.Text;
				FilterType = filterTypeTextBox.Text;
				WagonType = wagonTypeTextBox.Text;

				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show("Не верный номер вагона");
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
