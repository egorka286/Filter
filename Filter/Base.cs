using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Filter
{
	class Base
	{
		private string dbFileName;
		private SQLiteConnection m_dbConn;
		private SQLiteCommand m_sqlCmd;

		public Base(string fileName)
		{
			dbFileName = fileName;
			m_sqlCmd = new SQLiteCommand();
			try
			{
				m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
				m_dbConn.Open();
				m_sqlCmd.Connection = m_dbConn;
			}
			catch (SQLiteException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		public void Insert(int wagonNumber, DateTime filterDate, string surname, string filterType, string wagonType)
		{
			Run($"INSERT INTO Wagons ('Number', 'Date', 'Surname', 'Type', 'WagonType') values ('{wagonNumber.ToString()}', '{filterDate.ToString("yyyy-MM-dd")}', '{surname}', '{filterType}', '{wagonType}')");
		}

		public void Update(int wagonNumber, DateTime filterDate, string surname, string filterType, string wagonType)
		{
			Run($"UPDATE Wagons SET Date = '{filterDate.ToString("yyyy-MM-dd")}', Surname = '{surname}', Type = '{filterType}', WagonType = '{wagonType}' WHERE Number = {wagonNumber.ToString()};");
		}

		public void Delete(int wagonNumber)
		{
			Run($"DELETE FROM Wagons WHERE Number = {wagonNumber}");
		}

		public DataTable GetAll()
		{
			return Select("SELECT Number, strftime('%d.%m.%Y', Date), Surname, Type, WagonType FROM Wagons");
		}

		public DataTable GetRequiringReplacement(int days)
		{
			return Select($"SELECT Number, strftime('%d.%m.%Y', Date), Surname, Type, WagonType FROM Wagons WHERE strftime('%J', 'now') - strftime('%J', Date) > {days};");
		}

		public DataTable GetRequiringReplacementDate(int days, DateTime date)
		{
			return Select($"SELECT Number, strftime('%d.%m.%Y', Date), Surname, Type, WagonType FROM Wagons WHERE (strftime('%J', '{date.ToString("yyyy-MM-dd")}') - strftime('%J', Date)) % {days} = 0;");
		}

		public void Close()
		{
			m_dbConn.Close();
		}

		private DataTable Select(string sqlQuery)
		{
			if (m_dbConn.State != ConnectionState.Open)
			{
				MessageBox.Show("Open connection with database");
				return null;
			}
			try
			{
				DataTable dTable = new DataTable();
				SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
				adapter.Fill(dTable);
				return dTable;
			}
			catch (SQLiteException ex)
			{
				MessageBox.Show("Error: " + ex.Message + "\ncode: " + ex.ErrorCode);
				return null;
			}
		}

		private void Run(string cmd)
		{
			if (m_dbConn.State != ConnectionState.Open)
			{
				MessageBox.Show("Open connection with database");
				return;
			}
			try
			{
				m_sqlCmd.CommandText = cmd;
				m_sqlCmd.ExecuteNonQuery();
			}
			catch (SQLiteException ex)
			{
				if (ex.ErrorCode == 19)
					MessageBox.Show("Вагон с таким номером существует");
				else
					MessageBox.Show("Error: " + ex.Message + "\ncode: " + ex.ErrorCode);
			}
		}
	}
}
