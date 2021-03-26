using System;
using System.Windows.Forms;

namespace Filter
{
	public partial class EditWagonForm : Form
	{
		public int WagonNumber { get; private set; }
		public DateTime FilterDate { get; private set; }
		public string Surname { get; private set; }
		public string FilterType { get; private set; }
		public string WagonType { get; private set; }

		public EditWagonForm(DataGridViewRow data, bool updateDate)
		{
			InitializeComponent();

			WagonNumber = Convert.ToInt32(data.Cells[0].Value);

			if (!updateDate)
				FilterDate = Convert.ToDateTime(data.Cells[1].Value.ToString());
			else
				FilterDate = DateTime.Now;

			Surname = data.Cells[2].Value.ToString();
			FilterType = data.Cells[3].Value.ToString();
			WagonType = data.Cells[4].Value.ToString();

			wagonNumberTextBox.Text = WagonNumber.ToString();
			filterDate.Value = FilterDate;
			surnameTextBox.Text = Surname;
			filterTypeTextBox.Text = FilterType;
			wagonTypeTextBox.Text = WagonType;

			surnameTextBox.Select();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			WagonNumber = Convert.ToInt32(wagonNumberTextBox.Text);
			FilterDate = filterDate.Value;
			Surname = surnameTextBox.Text;
			FilterType = filterTypeTextBox.Text;
			WagonType = wagonTypeTextBox.Text;

			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
