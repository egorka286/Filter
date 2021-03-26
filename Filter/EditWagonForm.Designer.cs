namespace Filter
{
	partial class EditWagonForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.filterTypeTextBox = new System.Windows.Forms.TextBox();
			this.filterTypeLabel = new System.Windows.Forms.Label();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.filterDateLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.filterDate = new System.Windows.Forms.DateTimePicker();
			this.wagonNumberTextBox = new System.Windows.Forms.TextBox();
			this.wagonNumberLabel = new System.Windows.Forms.Label();
			this.wagonTypeTextBox = new System.Windows.Forms.TextBox();
			this.wagonTypeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// filterTypeTextBox
			// 
			this.filterTypeTextBox.Location = new System.Drawing.Point(162, 114);
			this.filterTypeTextBox.Name = "filterTypeTextBox";
			this.filterTypeTextBox.Size = new System.Drawing.Size(127, 20);
			this.filterTypeTextBox.TabIndex = 19;
			// 
			// filterTypeLabel
			// 
			this.filterTypeLabel.AutoSize = true;
			this.filterTypeLabel.Location = new System.Drawing.Point(12, 114);
			this.filterTypeLabel.Name = "filterTypeLabel";
			this.filterTypeLabel.Size = new System.Drawing.Size(78, 13);
			this.filterTypeLabel.TabIndex = 18;
			this.filterTypeLabel.Text = "Тип фильтров";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Location = new System.Drawing.Point(162, 76);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(127, 20);
			this.surnameTextBox.TabIndex = 17;
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(12, 70);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(122, 26);
			this.surnameLabel.TabIndex = 16;
			this.surnameLabel.Text = "Фамилия работника\r\nзаменившего фильтра";
			// 
			// filterDateLabel
			// 
			this.filterDateLabel.AutoSize = true;
			this.filterDateLabel.Location = new System.Drawing.Point(12, 43);
			this.filterDateLabel.Name = "filterDateLabel";
			this.filterDateLabel.Size = new System.Drawing.Size(128, 13);
			this.filterDateLabel.TabIndex = 15;
			this.filterDateLabel.Text = "Дата замены фильтров";
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(183, 192);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 14;
			this.okButton.Text = "Изменить";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(41, 192);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 13;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// filterDate
			// 
			this.filterDate.Location = new System.Drawing.Point(162, 43);
			this.filterDate.Name = "filterDate";
			this.filterDate.Size = new System.Drawing.Size(127, 20);
			this.filterDate.TabIndex = 12;
			// 
			// wagonNumberTextBox
			// 
			this.wagonNumberTextBox.Location = new System.Drawing.Point(162, 9);
			this.wagonNumberTextBox.Name = "wagonNumberTextBox";
			this.wagonNumberTextBox.ReadOnly = true;
			this.wagonNumberTextBox.Size = new System.Drawing.Size(127, 20);
			this.wagonNumberTextBox.TabIndex = 11;
			// 
			// wagonNumberLabel
			// 
			this.wagonNumberLabel.AutoSize = true;
			this.wagonNumberLabel.Location = new System.Drawing.Point(12, 9);
			this.wagonNumberLabel.Name = "wagonNumberLabel";
			this.wagonNumberLabel.Size = new System.Drawing.Size(79, 13);
			this.wagonNumberLabel.TabIndex = 10;
			this.wagonNumberLabel.Text = "Номер вагона";
			// 
			// wagonTypeTextBox
			// 
			this.wagonTypeTextBox.Location = new System.Drawing.Point(162, 151);
			this.wagonTypeTextBox.Name = "wagonTypeTextBox";
			this.wagonTypeTextBox.Size = new System.Drawing.Size(127, 20);
			this.wagonTypeTextBox.TabIndex = 21;
			// 
			// wagonTypeLabel
			// 
			this.wagonTypeLabel.AutoSize = true;
			this.wagonTypeLabel.Location = new System.Drawing.Point(12, 151);
			this.wagonTypeLabel.Name = "wagonTypeLabel";
			this.wagonTypeLabel.Size = new System.Drawing.Size(64, 13);
			this.wagonTypeLabel.TabIndex = 20;
			this.wagonTypeLabel.Text = "Тип вагона";
			// 
			// EditWagonForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 237);
			this.Controls.Add(this.wagonTypeTextBox);
			this.Controls.Add(this.wagonTypeLabel);
			this.Controls.Add(this.filterTypeTextBox);
			this.Controls.Add(this.filterTypeLabel);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.filterDateLabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.filterDate);
			this.Controls.Add(this.wagonNumberTextBox);
			this.Controls.Add(this.wagonNumberLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "EditWagonForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EdirWagonForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox filterTypeTextBox;
		private System.Windows.Forms.Label filterTypeLabel;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label filterDateLabel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.DateTimePicker filterDate;
		private System.Windows.Forms.TextBox wagonNumberTextBox;
		private System.Windows.Forms.Label wagonNumberLabel;
		private System.Windows.Forms.TextBox wagonTypeTextBox;
		private System.Windows.Forms.Label wagonTypeLabel;
	}
}
