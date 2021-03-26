﻿namespace Filter
{
	partial class AddWagonForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.wagonNumberTextBox = new System.Windows.Forms.TextBox();
			this.filterDate = new System.Windows.Forms.DateTimePicker();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.filterTypeTextBox = new System.Windows.Forms.TextBox();
			this.wagonTypeTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Номер вагона";
			// 
			// wagonNumberTextBox
			// 
			this.wagonNumberTextBox.Location = new System.Drawing.Point(156, 6);
			this.wagonNumberTextBox.Name = "wagonNumberTextBox";
			this.wagonNumberTextBox.Size = new System.Drawing.Size(127, 20);
			this.wagonNumberTextBox.TabIndex = 1;
			// 
			// filterDate
			// 
			this.filterDate.Location = new System.Drawing.Point(156, 40);
			this.filterDate.Name = "filterDate";
			this.filterDate.Size = new System.Drawing.Size(127, 20);
			this.filterDate.TabIndex = 2;
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(41, 200);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(172, 200);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "Добавить";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Дата замены фильтров";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 26);
			this.label3.TabIndex = 6;
			this.label3.Text = "Фамилия работника\r\nзаменившего фильтра";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.Location = new System.Drawing.Point(156, 73);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(127, 20);
			this.surnameTextBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Тип фильтров";
			// 
			// filterTypeTextBox
			// 
			this.filterTypeTextBox.Location = new System.Drawing.Point(156, 111);
			this.filterTypeTextBox.Name = "filterTypeTextBox";
			this.filterTypeTextBox.Size = new System.Drawing.Size(127, 20);
			this.filterTypeTextBox.TabIndex = 9;
			// 
			// wagonTypeTextBox
			// 
			this.wagonTypeTextBox.Location = new System.Drawing.Point(156, 148);
			this.wagonTypeTextBox.Name = "wagonTypeTextBox";
			this.wagonTypeTextBox.Size = new System.Drawing.Size(127, 20);
			this.wagonTypeTextBox.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Тип вагона";
			// 
			// AddwWagonForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(298, 251);
			this.Controls.Add(this.wagonTypeTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.filterTypeTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.filterDate);
			this.Controls.Add(this.wagonNumberTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddWagonForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавить вагон";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox wagonNumberTextBox;
		private System.Windows.Forms.DateTimePicker filterDate;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox filterTypeTextBox;
		private System.Windows.Forms.TextBox wagonTypeTextBox;
		private System.Windows.Forms.Label label5;
	}
}