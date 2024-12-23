namespace Project.V4
{
    partial class FormMain_BMD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxBooks_BMD = new GroupBox();
            buttonBookSearchDone_BMD = new Button();
            textBoxBookSearchString_BMD = new TextBox();
            labelBookSearchString_BMD = new Label();
            comboBoxBookSearchSort_BMD = new ComboBox();
            labelBookSearchSort_BMD = new Label();
            buttonDeleteBook_BMD = new Button();
            buttonSaveBookData_BMD = new Button();
            buttonAddBook_BMD = new Button();
            buttonOpenBookData_BMD = new Button();
            groupBoxReaders_BMD = new GroupBox();
            buttonReaderSearchDone_BMD = new Button();
            textBoxReaderSearchString_BMD = new TextBox();
            labelReaderSearchString_BMD = new Label();
            comboBoxReaderSearchSort_BMD = new ComboBox();
            labelReaderSearchSort_BMD = new Label();
            buttonDeleteReader_BMD = new Button();
            buttonSaveReaderData_BMD = new Button();
            buttonAddReader_BMD = new Button();
            buttonOpenReaderData_BMD = new Button();
            buttonShowBookPanel_BMD = new Button();
            buttonShowReaderPanel_BMD = new Button();
            dataGridViewResult_BMD = new DataGridView();
            buttonHelp_BMD = new Button();
            openFileDialogData_BMD = new OpenFileDialog();
            saveFileDialogData_BMD = new SaveFileDialog();
            groupBoxBooks_BMD.SuspendLayout();
            groupBoxReaders_BMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BMD).BeginInit();
            SuspendLayout();
            // 
            // groupBoxBooks_BMD
            // 
            groupBoxBooks_BMD.BackColor = Color.FromArgb(192, 255, 192);
            groupBoxBooks_BMD.Controls.Add(buttonBookSearchDone_BMD);
            groupBoxBooks_BMD.Controls.Add(textBoxBookSearchString_BMD);
            groupBoxBooks_BMD.Controls.Add(labelBookSearchString_BMD);
            groupBoxBooks_BMD.Controls.Add(comboBoxBookSearchSort_BMD);
            groupBoxBooks_BMD.Controls.Add(labelBookSearchSort_BMD);
            groupBoxBooks_BMD.Controls.Add(buttonDeleteBook_BMD);
            groupBoxBooks_BMD.Controls.Add(buttonSaveBookData_BMD);
            groupBoxBooks_BMD.Controls.Add(buttonAddBook_BMD);
            groupBoxBooks_BMD.Controls.Add(buttonOpenBookData_BMD);
            groupBoxBooks_BMD.Enabled = false;
            groupBoxBooks_BMD.FlatStyle = FlatStyle.Flat;
            groupBoxBooks_BMD.ForeColor = SystemColors.Desktop;
            groupBoxBooks_BMD.Location = new Point(12, 12);
            groupBoxBooks_BMD.Name = "groupBoxBooks_BMD";
            groupBoxBooks_BMD.Size = new Size(179, 296);
            groupBoxBooks_BMD.TabIndex = 0;
            groupBoxBooks_BMD.TabStop = false;
            groupBoxBooks_BMD.Text = "Управление книгами";
            // 
            // buttonBookSearchDone_BMD
            // 
            buttonBookSearchDone_BMD.BackColor = SystemColors.Control;
            buttonBookSearchDone_BMD.Enabled = false;
            buttonBookSearchDone_BMD.FlatStyle = FlatStyle.Flat;
            buttonBookSearchDone_BMD.Location = new Point(46, 259);
            buttonBookSearchDone_BMD.Name = "buttonBookSearchDone_BMD";
            buttonBookSearchDone_BMD.Size = new Size(75, 23);
            buttonBookSearchDone_BMD.TabIndex = 8;
            buttonBookSearchDone_BMD.Text = "Найти";
            buttonBookSearchDone_BMD.UseVisualStyleBackColor = false;
            buttonBookSearchDone_BMD.Click += buttonBookSearchDone_BMD_Click;
            // 
            // textBoxBookSearchString_BMD
            // 
            textBoxBookSearchString_BMD.BorderStyle = BorderStyle.FixedSingle;
            textBoxBookSearchString_BMD.Enabled = false;
            textBoxBookSearchString_BMD.Location = new Point(6, 230);
            textBoxBookSearchString_BMD.Name = "textBoxBookSearchString_BMD";
            textBoxBookSearchString_BMD.Size = new Size(167, 21);
            textBoxBookSearchString_BMD.TabIndex = 7;
            textBoxBookSearchString_BMD.TextChanged += textBoxBookSearchString_BMD_TextChanged;
            // 
            // labelBookSearchString_BMD
            // 
            labelBookSearchString_BMD.AutoSize = true;
            labelBookSearchString_BMD.Location = new Point(8, 212);
            labelBookSearchString_BMD.Name = "labelBookSearchString_BMD";
            labelBookSearchString_BMD.Size = new Size(45, 15);
            labelBookSearchString_BMD.TabIndex = 6;
            labelBookSearchString_BMD.Text = "Найти:";
            // 
            // comboBoxBookSearchSort_BMD
            // 
            comboBoxBookSearchSort_BMD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxBookSearchSort_BMD.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxBookSearchSort_BMD.Enabled = false;
            comboBoxBookSearchSort_BMD.FlatStyle = FlatStyle.Flat;
            comboBoxBookSearchSort_BMD.FormattingEnabled = true;
            comboBoxBookSearchSort_BMD.Items.AddRange(new object[] { "ISDN", "Внутреннему номеру", "Автору", "Названию", "Году издания" });
            comboBoxBookSearchSort_BMD.Location = new Point(6, 177);
            comboBoxBookSearchSort_BMD.Name = "comboBoxBookSearchSort_BMD";
            comboBoxBookSearchSort_BMD.Size = new Size(167, 23);
            comboBoxBookSearchSort_BMD.TabIndex = 5;
            comboBoxBookSearchSort_BMD.SelectedIndexChanged += comboBoxBookSearchSort_BMD_SelectedIndexChanged;
            // 
            // labelBookSearchSort_BMD
            // 
            labelBookSearchSort_BMD.AutoSize = true;
            labelBookSearchSort_BMD.Location = new Point(6, 159);
            labelBookSearchSort_BMD.Name = "labelBookSearchSort_BMD";
            labelBookSearchSort_BMD.Size = new Size(67, 15);
            labelBookSearchSort_BMD.TabIndex = 4;
            labelBookSearchSort_BMD.Text = "Искать по:";
            // 
            // buttonDeleteBook_BMD
            // 
            buttonDeleteBook_BMD.BackColor = SystemColors.Control;
            buttonDeleteBook_BMD.Enabled = false;
            buttonDeleteBook_BMD.FlatStyle = FlatStyle.Flat;
            buttonDeleteBook_BMD.Location = new Point(102, 82);
            buttonDeleteBook_BMD.Name = "buttonDeleteBook_BMD";
            buttonDeleteBook_BMD.Size = new Size(71, 58);
            buttonDeleteBook_BMD.TabIndex = 3;
            buttonDeleteBook_BMD.Text = "Удалить запись";
            buttonDeleteBook_BMD.UseVisualStyleBackColor = false;
            buttonDeleteBook_BMD.Click += buttonDeleteBook_BMD_Click;
            // 
            // buttonSaveBookData_BMD
            // 
            buttonSaveBookData_BMD.BackColor = SystemColors.Control;
            buttonSaveBookData_BMD.Enabled = false;
            buttonSaveBookData_BMD.FlatStyle = FlatStyle.Flat;
            buttonSaveBookData_BMD.Location = new Point(6, 52);
            buttonSaveBookData_BMD.Name = "buttonSaveBookData_BMD";
            buttonSaveBookData_BMD.Size = new Size(167, 24);
            buttonSaveBookData_BMD.TabIndex = 2;
            buttonSaveBookData_BMD.Text = "Выгрузить базу книг";
            buttonSaveBookData_BMD.UseVisualStyleBackColor = false;
            buttonSaveBookData_BMD.Click += buttonSaveBookData_BMD_Click;
            // 
            // buttonAddBook_BMD
            // 
            buttonAddBook_BMD.BackColor = SystemColors.Control;
            buttonAddBook_BMD.Enabled = false;
            buttonAddBook_BMD.FlatStyle = FlatStyle.Flat;
            buttonAddBook_BMD.Location = new Point(6, 82);
            buttonAddBook_BMD.Name = "buttonAddBook_BMD";
            buttonAddBook_BMD.Size = new Size(71, 58);
            buttonAddBook_BMD.TabIndex = 1;
            buttonAddBook_BMD.Text = "Добавить запись";
            buttonAddBook_BMD.UseVisualStyleBackColor = false;
            buttonAddBook_BMD.Click += buttonAddBook_BMD_Click;
            // 
            // buttonOpenBookData_BMD
            // 
            buttonOpenBookData_BMD.BackColor = SystemColors.Control;
            buttonOpenBookData_BMD.FlatStyle = FlatStyle.Flat;
            buttonOpenBookData_BMD.Location = new Point(6, 22);
            buttonOpenBookData_BMD.Name = "buttonOpenBookData_BMD";
            buttonOpenBookData_BMD.Size = new Size(167, 24);
            buttonOpenBookData_BMD.TabIndex = 0;
            buttonOpenBookData_BMD.Text = "Загрузить базу книг";
            buttonOpenBookData_BMD.UseVisualStyleBackColor = false;
            buttonOpenBookData_BMD.Click += buttonOpenBookData_BMD_Click;
            // 
            // groupBoxReaders_BMD
            // 
            groupBoxReaders_BMD.BackColor = Color.FromArgb(192, 255, 192);
            groupBoxReaders_BMD.Controls.Add(buttonReaderSearchDone_BMD);
            groupBoxReaders_BMD.Controls.Add(textBoxReaderSearchString_BMD);
            groupBoxReaders_BMD.Controls.Add(labelReaderSearchString_BMD);
            groupBoxReaders_BMD.Controls.Add(comboBoxReaderSearchSort_BMD);
            groupBoxReaders_BMD.Controls.Add(labelReaderSearchSort_BMD);
            groupBoxReaders_BMD.Controls.Add(buttonDeleteReader_BMD);
            groupBoxReaders_BMD.Controls.Add(buttonSaveReaderData_BMD);
            groupBoxReaders_BMD.Controls.Add(buttonAddReader_BMD);
            groupBoxReaders_BMD.Controls.Add(buttonOpenReaderData_BMD);
            groupBoxReaders_BMD.Enabled = false;
            groupBoxReaders_BMD.FlatStyle = FlatStyle.Flat;
            groupBoxReaders_BMD.ForeColor = SystemColors.Desktop;
            groupBoxReaders_BMD.Location = new Point(12, 335);
            groupBoxReaders_BMD.Name = "groupBoxReaders_BMD";
            groupBoxReaders_BMD.Size = new Size(179, 296);
            groupBoxReaders_BMD.TabIndex = 9;
            groupBoxReaders_BMD.TabStop = false;
            groupBoxReaders_BMD.Text = "Управление читателями";
            groupBoxReaders_BMD.UseCompatibleTextRendering = true;
            // 
            // buttonReaderSearchDone_BMD
            // 
            buttonReaderSearchDone_BMD.BackColor = SystemColors.Control;
            buttonReaderSearchDone_BMD.Enabled = false;
            buttonReaderSearchDone_BMD.FlatStyle = FlatStyle.Flat;
            buttonReaderSearchDone_BMD.Location = new Point(46, 259);
            buttonReaderSearchDone_BMD.Name = "buttonReaderSearchDone_BMD";
            buttonReaderSearchDone_BMD.Size = new Size(75, 23);
            buttonReaderSearchDone_BMD.TabIndex = 8;
            buttonReaderSearchDone_BMD.Text = "Найти";
            buttonReaderSearchDone_BMD.UseVisualStyleBackColor = false;
            buttonReaderSearchDone_BMD.Click += buttonReaderSearchDone_BMD_Click;
            // 
            // textBoxReaderSearchString_BMD
            // 
            textBoxReaderSearchString_BMD.BorderStyle = BorderStyle.FixedSingle;
            textBoxReaderSearchString_BMD.Enabled = false;
            textBoxReaderSearchString_BMD.Location = new Point(6, 230);
            textBoxReaderSearchString_BMD.Name = "textBoxReaderSearchString_BMD";
            textBoxReaderSearchString_BMD.Size = new Size(167, 21);
            textBoxReaderSearchString_BMD.TabIndex = 7;
            textBoxReaderSearchString_BMD.TextChanged += textBoxReaderSearchString_BMD_TextChanged;
            // 
            // labelReaderSearchString_BMD
            // 
            labelReaderSearchString_BMD.AutoSize = true;
            labelReaderSearchString_BMD.Location = new Point(8, 212);
            labelReaderSearchString_BMD.Name = "labelReaderSearchString_BMD";
            labelReaderSearchString_BMD.Size = new Size(45, 15);
            labelReaderSearchString_BMD.TabIndex = 6;
            labelReaderSearchString_BMD.Text = "Найти:";
            // 
            // comboBoxReaderSearchSort_BMD
            // 
            comboBoxReaderSearchSort_BMD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxReaderSearchSort_BMD.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxReaderSearchSort_BMD.Enabled = false;
            comboBoxReaderSearchSort_BMD.FlatStyle = FlatStyle.Flat;
            comboBoxReaderSearchSort_BMD.FormattingEnabled = true;
            comboBoxReaderSearchSort_BMD.Items.AddRange(new object[] { "Фамилии", "Имени", "Номеру билета" });
            comboBoxReaderSearchSort_BMD.Location = new Point(6, 177);
            comboBoxReaderSearchSort_BMD.Name = "comboBoxReaderSearchSort_BMD";
            comboBoxReaderSearchSort_BMD.Size = new Size(167, 23);
            comboBoxReaderSearchSort_BMD.TabIndex = 5;
            comboBoxReaderSearchSort_BMD.SelectedIndexChanged += comboBoxReaderSearchSort_BMD_SelectedIndexChanged;
            // 
            // labelReaderSearchSort_BMD
            // 
            labelReaderSearchSort_BMD.AutoSize = true;
            labelReaderSearchSort_BMD.Location = new Point(6, 159);
            labelReaderSearchSort_BMD.Name = "labelReaderSearchSort_BMD";
            labelReaderSearchSort_BMD.Size = new Size(67, 15);
            labelReaderSearchSort_BMD.TabIndex = 4;
            labelReaderSearchSort_BMD.Text = "Искать по:";
            // 
            // buttonDeleteReader_BMD
            // 
            buttonDeleteReader_BMD.BackColor = SystemColors.Control;
            buttonDeleteReader_BMD.Enabled = false;
            buttonDeleteReader_BMD.FlatStyle = FlatStyle.Flat;
            buttonDeleteReader_BMD.Location = new Point(102, 82);
            buttonDeleteReader_BMD.Name = "buttonDeleteReader_BMD";
            buttonDeleteReader_BMD.Size = new Size(71, 58);
            buttonDeleteReader_BMD.TabIndex = 3;
            buttonDeleteReader_BMD.Text = "Удалить запись";
            buttonDeleteReader_BMD.UseVisualStyleBackColor = false;
            buttonDeleteReader_BMD.Click += buttonDeleteReader_BMD_Click;
            // 
            // buttonSaveReaderData_BMD
            // 
            buttonSaveReaderData_BMD.BackColor = SystemColors.Control;
            buttonSaveReaderData_BMD.Enabled = false;
            buttonSaveReaderData_BMD.FlatStyle = FlatStyle.Flat;
            buttonSaveReaderData_BMD.Location = new Point(6, 52);
            buttonSaveReaderData_BMD.Name = "buttonSaveReaderData_BMD";
            buttonSaveReaderData_BMD.Size = new Size(167, 24);
            buttonSaveReaderData_BMD.TabIndex = 2;
            buttonSaveReaderData_BMD.Text = "Выгрузить базу читателей";
            buttonSaveReaderData_BMD.UseVisualStyleBackColor = false;
            buttonSaveReaderData_BMD.Click += buttonSaveReaderData_BMD_Click;
            // 
            // buttonAddReader_BMD
            // 
            buttonAddReader_BMD.BackColor = SystemColors.Control;
            buttonAddReader_BMD.Enabled = false;
            buttonAddReader_BMD.FlatStyle = FlatStyle.Flat;
            buttonAddReader_BMD.Location = new Point(6, 82);
            buttonAddReader_BMD.Name = "buttonAddReader_BMD";
            buttonAddReader_BMD.Size = new Size(71, 58);
            buttonAddReader_BMD.TabIndex = 1;
            buttonAddReader_BMD.Text = "Добавить запись";
            buttonAddReader_BMD.UseVisualStyleBackColor = false;
            buttonAddReader_BMD.Click += buttonAddReader_BMD_Click;
            // 
            // buttonOpenReaderData_BMD
            // 
            buttonOpenReaderData_BMD.BackColor = SystemColors.Control;
            buttonOpenReaderData_BMD.FlatStyle = FlatStyle.Flat;
            buttonOpenReaderData_BMD.Location = new Point(6, 22);
            buttonOpenReaderData_BMD.Name = "buttonOpenReaderData_BMD";
            buttonOpenReaderData_BMD.Size = new Size(167, 24);
            buttonOpenReaderData_BMD.TabIndex = 0;
            buttonOpenReaderData_BMD.Text = "Загрузить базу читателей";
            buttonOpenReaderData_BMD.UseVisualStyleBackColor = false;
            buttonOpenReaderData_BMD.Click += buttonOpenReaderData_BMD_Click;
            // 
            // buttonShowBookPanel_BMD
            // 
            buttonShowBookPanel_BMD.BackColor = SystemColors.Control;
            buttonShowBookPanel_BMD.FlatStyle = FlatStyle.Flat;
            buttonShowBookPanel_BMD.Location = new Point(219, 9);
            buttonShowBookPanel_BMD.Name = "buttonShowBookPanel_BMD";
            buttonShowBookPanel_BMD.Size = new Size(159, 31);
            buttonShowBookPanel_BMD.TabIndex = 10;
            buttonShowBookPanel_BMD.Text = "Работа с книгами";
            buttonShowBookPanel_BMD.UseVisualStyleBackColor = false;
            buttonShowBookPanel_BMD.Click += buttonShowBookPanel_BMD_Click;
            // 
            // buttonShowReaderPanel_BMD
            // 
            buttonShowReaderPanel_BMD.BackColor = SystemColors.Control;
            buttonShowReaderPanel_BMD.FlatStyle = FlatStyle.Flat;
            buttonShowReaderPanel_BMD.Location = new Point(219, 46);
            buttonShowReaderPanel_BMD.Name = "buttonShowReaderPanel_BMD";
            buttonShowReaderPanel_BMD.Size = new Size(159, 31);
            buttonShowReaderPanel_BMD.TabIndex = 11;
            buttonShowReaderPanel_BMD.Text = "Работа с читателями";
            buttonShowReaderPanel_BMD.UseVisualStyleBackColor = false;
            buttonShowReaderPanel_BMD.Click += buttonShowReaderPanel_BMD_Click;
            // 
            // dataGridViewResult_BMD
            // 
            dataGridViewResult_BMD.AllowUserToAddRows = false;
            dataGridViewResult_BMD.AllowUserToDeleteRows = false;
            dataGridViewResult_BMD.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridViewResult_BMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BMD.Location = new Point(219, 83);
            dataGridViewResult_BMD.Name = "dataGridViewResult_BMD";
            dataGridViewResult_BMD.RowHeadersVisible = false;
            dataGridViewResult_BMD.Size = new Size(863, 548);
            dataGridViewResult_BMD.TabIndex = 12;
            // 
            // buttonHelp_BMD
            // 
            buttonHelp_BMD.BackColor = SystemColors.Control;
            buttonHelp_BMD.FlatStyle = FlatStyle.Flat;
            buttonHelp_BMD.Location = new Point(994, 12);
            buttonHelp_BMD.Name = "buttonHelp_BMD";
            buttonHelp_BMD.Size = new Size(88, 50);
            buttonHelp_BMD.TabIndex = 13;
            buttonHelp_BMD.Text = "Справка";
            buttonHelp_BMD.UseVisualStyleBackColor = false;
            buttonHelp_BMD.Click += buttonHelp_BMD_Click;
            // 
            // openFileDialogData_BMD
            // 
            openFileDialogData_BMD.FileName = "openFileDialog1";
            // 
            // FormMain_BMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1094, 645);
            Controls.Add(buttonHelp_BMD);
            Controls.Add(dataGridViewResult_BMD);
            Controls.Add(buttonShowReaderPanel_BMD);
            Controls.Add(buttonShowBookPanel_BMD);
            Controls.Add(groupBoxReaders_BMD);
            Controls.Add(groupBoxBooks_BMD);
            Font = new Font("Arial", 9F);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_BMD";
            Text = "Управление библиотекой";
            groupBoxBooks_BMD.ResumeLayout(false);
            groupBoxBooks_BMD.PerformLayout();
            groupBoxReaders_BMD.ResumeLayout(false);
            groupBoxReaders_BMD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BMD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxBooks_BMD;
        private Button buttonAddBook_BMD;
        private Button buttonOpenBookData_BMD;
        private Button buttonSaveBookData_BMD;
        private Button buttonDeleteBook_BMD;
        private ComboBox comboBoxBookSearchSort_BMD;
        private Label labelBookSearchSort_BMD;
        private Button buttonBookSearchDone_BMD;
        private TextBox textBoxBookSearchString_BMD;
        private Label labelBookSearchString_BMD;
        private GroupBox groupBoxReaders_BMD;
        private Button buttonReaderSearchDone_BMD;
        private TextBox textBoxReaderSearchString_BMD;
        private Label labelReaderSearchString_BMD;
        private ComboBox comboBoxReaderSearchSort_BMD;
        private Label labelReaderSearchSort_BMD;
        private Button buttonDeleteReader_BMD;
        private Button buttonSaveReaderData_BMD;
        private Button buttonAddReader_BMD;
        private Button buttonOpenReaderData_BMD;
        private Button buttonShowBookPanel_BMD;
        private Button buttonShowReaderPanel_BMD;
        private DataGridView dataGridViewResult_BMD;
        private Button buttonHelp_BMD;
        private OpenFileDialog openFileDialogData_BMD;
        private SaveFileDialog saveFileDialogData_BMD;
    }
}
