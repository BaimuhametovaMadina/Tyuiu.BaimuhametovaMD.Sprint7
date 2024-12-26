using Project.V4.Lib;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.V4
{
    public partial class FormMain_BMD: Form
    {
        public FormMain_BMD()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string openFilePath;
        int cols, rows;
        internal object dataGridViewMain_VMY;

        private void buttonShowBookPanel_BMD_Click(object sender, EventArgs e)
        {
            groupBoxBooks_BMD.BackColor = Color.FromArgb(128, 255, 128);
            groupBoxReaders_BMD.BackColor = Color.FromArgb(192, 255, 192);
            groupBoxBooks_BMD.Enabled = true;
            groupBoxReaders_BMD.Enabled = false;
        }

        private void buttonShowReaderPanel_BMD_Click(object sender, EventArgs e)
        {
            groupBoxBooks_BMD.BackColor = Color.FromArgb(192, 255, 192);
            groupBoxReaders_BMD.BackColor = Color.FromArgb(128, 255, 128);
            groupBoxBooks_BMD.Enabled = false;
            groupBoxReaders_BMD.Enabled = true;
        }

        private void buttonOpenBookData_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogData_BMD.ShowDialog();
                openFilePath = openFileDialogData_BMD.FileName;

                string database = ds.CheckDataBase(openFilePath);
                if (database != "books")
                {
                    MessageBox.Show("Вы пытаетесь загрузить не ту базу данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[,] arrayValues = ds.LoadFromFileData(openFilePath);
                    dataGridViewResult_BMD.ColumnCount = cols = arrayValues.GetLength(1);
                    dataGridViewResult_BMD.RowCount = rows = arrayValues.GetLength(0);

                    dataGridViewResult_BMD.Columns[0].HeaderText = "ISDN";
                    dataGridViewResult_BMD.Columns[1].HeaderText = "Внутренний номер";
                    dataGridViewResult_BMD.Columns[2].HeaderText = "Автор";
                    dataGridViewResult_BMD.Columns[3].HeaderText = "Название";
                    dataGridViewResult_BMD.Columns[4].HeaderText = "Год издания";
                    dataGridViewResult_BMD.Columns[5].HeaderText = "Краткая аннотация";

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dataGridViewResult_BMD.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    buttonSaveBookData_BMD.Enabled = true;
                    buttonAddBook_BMD.Enabled = true;
                    buttonDeleteBook_BMD.Enabled = true;
                    comboBoxBookSearchSort_BMD.Enabled = true;

                    buttonSaveReaderData_BMD.Enabled = false;
                    buttonAddReader_BMD.Enabled = false;
                    buttonDeleteReader_BMD.Enabled = false;
                    comboBoxReaderSearchSort_BMD.Enabled = false;
                    textBoxReaderSearchString_BMD.Enabled = false;
                    buttonReaderSearchDone_BMD.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке базы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveBookData_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogData_BMD.FileName = "OutPutFileBooks.csv";
                saveFileDialogData_BMD.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogData_BMD.ShowDialog();

                string path = saveFileDialogData_BMD.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewResult_BMD.RowCount;
                int columns = dataGridViewResult_BMD.ColumnCount;
                string header = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        header += dataGridViewResult_BMD.Columns[j].HeaderText + ";";
                    }
                    else
                    {
                        header += dataGridViewResult_BMD.Columns[j].HeaderText;
                    }
                }
                File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


                for (int i = 0; i < rows; i++)
                {
                    string str = "";
                    for (int j = 0; j < columns; j++)
                    {

                        if (j != columns - 1)
                        {
                            str += dataGridViewResult_BMD.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewResult_BMD.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);

                }
            }
            catch
            {
                MessageBox.Show("Ошибка при выгрузке базы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddBook_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_BMD.Columns[0].HeaderText = "ISDN";
                dataGridViewResult_BMD.Columns[1].HeaderText = "Внутренний номер";
                dataGridViewResult_BMD.Columns[2].HeaderText = "Автор";
                dataGridViewResult_BMD.Columns[3].HeaderText = "Название";
                dataGridViewResult_BMD.Columns[4].HeaderText = "Год издания";
                dataGridViewResult_BMD.Columns[5].HeaderText = "Краткая аннотация";
                dataGridViewResult_BMD.Rows.Add();
                dataGridViewResult_BMD.Rows[dataGridViewResult_BMD.RowCount - 1].Selected = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении книги", "Ой! Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteBook_BMD_Click(object sender, EventArgs e)
        {
            if (dataGridViewResult_BMD.CurrentRow.Index >= 0)
            {
                int a = dataGridViewResult_BMD.CurrentRow.Index;
                dataGridViewResult_BMD.Rows.Remove(dataGridViewResult_BMD.Rows[a]);
                if (dataGridViewResult_BMD.Rows.Count == 1)
                {
                    dataGridViewResult_BMD.Rows.Clear();
                }
            }
        }

        private void buttonBookSearchDone_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                for (int a = 0; a < dataGridViewResult_BMD.RowCount; a++)
                {

                    dataGridViewResult_BMD.Rows[a].Selected = false;
                }
                for (int i = 0; i < dataGridViewResult_BMD.RowCount; i++)
                {
                    int j = comboBoxBookSearchSort_BMD.SelectedIndex;
                    if (dataGridViewResult_BMD.Rows[i].Cells[j].Value != null)
                        if (dataGridViewResult_BMD.Rows[i].Cells[j].Value.ToString().Contains(textBoxBookSearchString_BMD.Text.ToLower()))
                        {
                            dataGridViewResult_BMD.Rows[i].Selected = true;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenReaderData_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogData_BMD.ShowDialog();
                openFilePath = openFileDialogData_BMD.FileName;

                string database = ds.CheckDataBase(openFilePath);
                if (database != "readers")
                {
                    MessageBox.Show("Вы пытаетесь загрузить не ту базу данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[,] arrayValues = ds.LoadFromFileData(openFilePath);

                    dataGridViewResult_BMD.Columns[0].HeaderText = "Номер читательского билета";
                    dataGridViewResult_BMD.Columns[1].HeaderText = "Фамилия";
                    dataGridViewResult_BMD.Columns[2].HeaderText = "Имя";
                    dataGridViewResult_BMD.Columns[3].HeaderText = "Номер телефона";
                    dataGridViewResult_BMD.Columns[4].HeaderText = "Внутренний номер книги";
                    dataGridViewResult_BMD.Columns[5].HeaderText = "Дата выдачи";

                    dataGridViewResult_BMD.ColumnCount = cols = arrayValues.GetLength(1);
                    dataGridViewResult_BMD.RowCount = rows = arrayValues.GetLength(0);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dataGridViewResult_BMD.Rows[i].Cells[j].Value = arrayValues[i, j];
                        }
                    }
                    buttonSaveReaderData_BMD.Enabled = true;
                    buttonAddReader_BMD.Enabled = true;
                    buttonDeleteReader_BMD.Enabled = true;
                    comboBoxReaderSearchSort_BMD.Enabled = true;

                    buttonSaveBookData_BMD.Enabled = false;
                    buttonAddBook_BMD.Enabled = false;
                    buttonDeleteBook_BMD.Enabled = false;
                    comboBoxBookSearchSort_BMD.Enabled = false;
                    textBoxBookSearchString_BMD.Enabled = false;
                    buttonBookSearchDone_BMD.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке базы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveReaderData_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogData_BMD.FileName = "OutPutFileReaders.csv";
                saveFileDialogData_BMD.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogData_BMD.ShowDialog();

                string path = saveFileDialogData_BMD.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewResult_BMD.RowCount;
                int columns = dataGridViewResult_BMD.ColumnCount;
                string header = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        header += dataGridViewResult_BMD.Columns[j].HeaderText + ";";
                    }
                    else
                    {
                        header += dataGridViewResult_BMD.Columns[j].HeaderText;
                    }
                }
                File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


                for (int i = 0; i < rows; i++)
                {
                    string str = "";
                    for (int j = 0; j < columns; j++)
                    {

                        if (j != columns - 1)
                        {
                            str += dataGridViewResult_BMD.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewResult_BMD.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);

                }
            }
            catch
            {
                MessageBox.Show("Ошибка при выгрузке базы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddReader_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_BMD.Columns[0].HeaderText = "Номер читательского билета";
                dataGridViewResult_BMD.Columns[1].HeaderText = "Фамилия";
                dataGridViewResult_BMD.Columns[2].HeaderText = "Имя";
                dataGridViewResult_BMD.Columns[3].HeaderText = "Номер телефона";
                dataGridViewResult_BMD.Columns[4].HeaderText = "Внутренний номер книги";
                dataGridViewResult_BMD.Columns[5].HeaderText = "Дата выдачи книги";
                dataGridViewResult_BMD.Rows.Add();
                dataGridViewResult_BMD.Rows[dataGridViewResult_BMD.RowCount - 1].Selected = true;
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteReader_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResult_BMD.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewResult_BMD.CurrentRow.Index;
                    dataGridViewResult_BMD.Rows.Remove(dataGridViewResult_BMD.Rows[a]);
                    if (dataGridViewResult_BMD.Rows.Count == 1)
                    {
                        dataGridViewResult_BMD.Rows.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так...", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReaderSearchDone_BMD_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewResult_BMD.RowCount; i++)
                {
                    dataGridViewResult_BMD.Rows[i].Selected = false;
                    for (int j = comboBoxReaderSearchSort_BMD.SelectedIndex; j <= comboBoxReaderSearchSort_BMD.SelectedIndex; j++)
                        if (dataGridViewResult_BMD.Rows[i].Cells[j].Value != null)
                            if (dataGridViewResult_BMD.Rows[i].Cells[j].Value.ToString().Contains(textBoxReaderSearchString_BMD.Text.ToLower()))
                            {
                                dataGridViewResult_BMD.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BMD_Click(object sender, EventArgs e)
        {
            FormHelp formhelp = new FormHelp();
            formhelp.ShowDialog();
        }

        private void comboBoxBookSearchSort_BMD_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxBookSearchString_BMD.Enabled = true;
        }

        private void textBoxBookSearchString_BMD_TextChanged(object sender, EventArgs e)
        {
            buttonBookSearchDone_BMD.Enabled = true;
        }

        private void comboBoxReaderSearchSort_BMD_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxReaderSearchString_BMD.Enabled = true;
        }

        private void textBoxReaderSearchString_BMD_TextChanged(object sender, EventArgs e)
        {
            buttonReaderSearchDone_BMD.Enabled = true;
        }

        private void FormMain_BMD_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
