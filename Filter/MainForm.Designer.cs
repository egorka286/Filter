
namespace Filter
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.filterDataGridView = new System.Windows.Forms.DataGridView();
			this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filterDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filterSurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filterTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wagonTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wagonsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addWagonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editWagonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeWagonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filterPanel = new System.Windows.Forms.Panel();
			this.showDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.filterComboBox = new System.Windows.Forms.ComboBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.wagonsCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).BeginInit();
			this.contextMenu.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.filterPanel.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// filterDataGridView
			// 
			this.filterDataGridView.AllowUserToAddRows = false;
			this.filterDataGridView.AllowUserToDeleteRows = false;
			this.filterDataGridView.AllowUserToResizeRows = false;
			this.filterDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.filterDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.filterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.filterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numColumn,
            this.filterDateColumn,
            this.filterSurnameColumn,
            this.filterTypeColumn,
            this.wagonTypeColumn});
			this.filterDataGridView.ContextMenuStrip = this.contextMenu;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Format = "D5";
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.filterDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
			this.filterDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.filterDataGridView.Location = new System.Drawing.Point(0, 33);
			this.filterDataGridView.Name = "filterDataGridView";
			this.filterDataGridView.ReadOnly = true;
			this.filterDataGridView.RowHeadersVisible = false;
			this.filterDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.filterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.filterDataGridView.Size = new System.Drawing.Size(532, 204);
			this.filterDataGridView.TabIndex = 0;
			this.filterDataGridView.DoubleClick += new System.EventHandler(this.editWagonMenuItem_Click);
			// 
			// numColumn
			// 
			this.numColumn.HeaderText = "Номер вагона";
			this.numColumn.Name = "numColumn";
			this.numColumn.ReadOnly = true;
			// 
			// filterDateColumn
			// 
			this.filterDateColumn.HeaderText = "Дата замены фильтров";
			this.filterDateColumn.Name = "filterDateColumn";
			this.filterDateColumn.ReadOnly = true;
			// 
			// filterSurnameColumn
			// 
			this.filterSurnameColumn.HeaderText = "Фамилия";
			this.filterSurnameColumn.Name = "filterSurnameColumn";
			this.filterSurnameColumn.ReadOnly = true;
			// 
			// filterTypeColumn
			// 
			this.filterTypeColumn.HeaderText = "Тип фильтров";
			this.filterTypeColumn.Name = "filterTypeColumn";
			this.filterTypeColumn.ReadOnly = true;
			// 
			// wagonTypeColumn
			// 
			this.wagonTypeColumn.HeaderText = "Тип вагона";
			this.wagonTypeColumn.Name = "wagonTypeColumn";
			this.wagonTypeColumn.ReadOnly = true;
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this.contextMenu.Name = "contextMenuStrip1";
			this.contextMenu.Size = new System.Drawing.Size(136, 26);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.copyToolStripMenuItem.Text = "Копировать";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.wagonsMenuItem,
            this.aboutMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(532, 24);
			this.mainMenu.TabIndex = 6;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(45, 20);
			this.fileMenuItem.Text = "Файл";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(107, 22);
			this.exitMenuItem.Text = "Выход";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// wagonsMenuItem
			// 
			this.wagonsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWagonMenuItem,
            this.editWagonMenuItem,
            this.removeWagonMenuItem});
			this.wagonsMenuItem.Name = "wagonsMenuItem";
			this.wagonsMenuItem.Size = new System.Drawing.Size(56, 20);
			this.wagonsMenuItem.Text = "Вагоны";
			// 
			// addWagonMenuItem
			// 
			this.addWagonMenuItem.Name = "addWagonMenuItem";
			this.addWagonMenuItem.Size = new System.Drawing.Size(124, 22);
			this.addWagonMenuItem.Text = "Добавить";
			this.addWagonMenuItem.Click += new System.EventHandler(this.addWagonMenuItem_Click);
			// 
			// editWagonMenuItem
			// 
			this.editWagonMenuItem.Name = "editWagonMenuItem";
			this.editWagonMenuItem.Size = new System.Drawing.Size(124, 22);
			this.editWagonMenuItem.Text = "Изменить";
			this.editWagonMenuItem.Click += new System.EventHandler(this.editWagonMenuItem_Click);
			// 
			// removeWagonMenuItem
			// 
			this.removeWagonMenuItem.Name = "removeWagonMenuItem";
			this.removeWagonMenuItem.Size = new System.Drawing.Size(124, 22);
			this.removeWagonMenuItem.Text = "Удалить";
			this.removeWagonMenuItem.Click += new System.EventHandler(this.removeWagonMenuItem_Click);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(92, 20);
			this.aboutMenuItem.Text = "О приложении";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// filterPanel
			// 
			this.filterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filterPanel.Controls.Add(this.statusStrip1);
			this.filterPanel.Controls.Add(this.showDateTimePicker);
			this.filterPanel.Controls.Add(this.filterDataGridView);
			this.filterPanel.Controls.Add(this.filterComboBox);
			this.filterPanel.Location = new System.Drawing.Point(0, 30);
			this.filterPanel.Margin = new System.Windows.Forms.Padding(0);
			this.filterPanel.Name = "filterPanel";
			this.filterPanel.Size = new System.Drawing.Size(532, 262);
			this.filterPanel.TabIndex = 7;
			// 
			// showDateTimePicker
			// 
			this.showDateTimePicker.Location = new System.Drawing.Point(160, 7);
			this.showDateTimePicker.Name = "showDateTimePicker";
			this.showDateTimePicker.Size = new System.Drawing.Size(120, 20);
			this.showDateTimePicker.TabIndex = 6;
			this.showDateTimePicker.Visible = false;
			this.showDateTimePicker.ValueChanged += new System.EventHandler(this.showDateTimePicker_ValueChanged);
			// 
			// filterComboBox
			// 
			this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filterComboBox.FormattingEnabled = true;
			this.filterComboBox.Items.AddRange(new object[] {
            "Все",
            "Требующие замены",
            "На дату"});
			this.filterComboBox.Location = new System.Drawing.Point(3, 6);
			this.filterComboBox.Name = "filterComboBox";
			this.filterComboBox.Size = new System.Drawing.Size(151, 21);
			this.filterComboBox.TabIndex = 5;
			this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterShow_Change);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.wagonsCountStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 240);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(532, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
			this.toolStripStatusLabel1.Text = "Вагонов:";
			// 
			// wagonsCountStatusLabel
			// 
			this.wagonsCountStatusLabel.Name = "wagonsCountStatusLabel";
			this.wagonsCountStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 293);
			this.Controls.Add(this.filterPanel);
			this.Controls.Add(this.mainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вагоны";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
			((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).EndInit();
			this.contextMenu.ResumeLayout(false);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.filterPanel.ResumeLayout(false);
			this.filterPanel.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView filterDataGridView;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wagonsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addWagonMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.Panel filterPanel;
		private System.Windows.Forms.ComboBox filterComboBox;
		private System.Windows.Forms.ToolStripMenuItem editWagonMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeWagonMenuItem;
		private System.Windows.Forms.DateTimePicker showDateTimePicker;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn filterDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn filterSurnameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn filterTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn wagonTypeColumn;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel wagonsCountStatusLabel;
	}
}

