using System;
using System.Data;
using System.Windows.Forms;

namespace Filter
{
	public partial class MainForm : Form
	{
		Base db;
		public string dbFileName = "base.db";

		public MainForm()
		{
			InitializeComponent();
			db = new Base(dbFileName);
			filterComboBox.SelectedItem = "Требующие замены";
			UpdateWagons();
		}

		public void UpdateWagons()
		{
			DataTable dTable = null;

			switch (filterComboBox.Text)
			{
				case "Все":
					dTable = db.GetAll();
					break;
				case "Требующие замены":
					dTable = db.GetRequiringReplacement(13);
					break;
				case "На дату":
					dTable = db.GetRequiringReplacementDate(13, showDateTimePicker.Value);
					break;
			}

			if (dTable.Rows.Count > 0)
			{
				filterDataGridView.Rows.Clear();
				for (int i = 0; i < dTable.Rows.Count; i++)
					filterDataGridView.Rows.Add(dTable.Rows[i].ItemArray);
			}

			wagonsCountStatusLabel.Text = dTable.Rows.Count.ToString();
			filterDataGridView.Focus();
		}

		private void MainForm_Closing(object sender, FormClosingEventArgs e)
		{
			db.Close();
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void filterShow_Change(object sender, EventArgs e)
		{
			if (filterComboBox.Text == "На дату")
			{
				showDateTimePicker.Value = DateTime.Today.AddDays(1);
				showDateTimePicker.Visible = true;
			}
			else
				showDateTimePicker.Visible = false;

			UpdateWagons();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			new AboutForm().ShowDialog();
		}

		private void editWagonMenuItem_Click(object sender, EventArgs e)
		{
			if (filterDataGridView.CurrentRow == null) return;

			EditWagonForm wagon = new EditWagonForm(filterDataGridView.CurrentRow, sender.ToString() != "Изменить");

			if (wagon.ShowDialog() == DialogResult.OK)
			{
				db.Update(wagon.WagonNumber, wagon.FilterDate, wagon.Surname, wagon.FilterType, wagon.WagonType);
				UpdateWagons();
			}
		}

		private void removeWagonMenuItem_Click(object sender, EventArgs e)
		{
			if (filterDataGridView.CurrentRow == null) return;

			int num = Convert.ToInt32(filterDataGridView.CurrentRow.Cells[0].Value);
			if (MessageBox.Show($"Вы уверены что хотите удалить вагон {num}", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				db.Delete(num);
				UpdateWagons();
			}
		}

		private void showDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			UpdateWagons();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (filterDataGridView.GetCellCount(DataGridViewElementStates.Selected) > 0)
			{
				try
				{
					Clipboard.SetDataObject(filterDataGridView.GetClipboardContent());
				}
				catch (System.Runtime.InteropServices.ExternalException)
				{
				}
			}
		}

		private void addWagonMenuItem_Click(object sender, EventArgs e)
		{
			AddWagonForm wagon = new AddWagonForm();

			if (wagon.ShowDialog() == DialogResult.OK)
			{
				db.Insert(wagon.WagonNumber, wagon.FilterDate, wagon.Surname, wagon.FilterType, wagon.WagonType);
				UpdateWagons();
			}
		}
	}
}
