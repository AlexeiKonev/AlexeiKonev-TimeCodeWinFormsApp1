using System.Text.RegularExpressions;

namespace TimeCodeWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnBrowseInput_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnBrowseOutput_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnGo_Click(object sender, EventArgs e)
        //{

        //}
        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtInput.Text = dlg.FileName;
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtOutput.Text = dlg.FileName;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(txtInput.Text))
                {
                    MessageBox.Show("Не найден входной файл.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtOutput.Text))
                {
                    MessageBox.Show("Укажи выходной файл.");
                    return;
                }

                var lines = File.ReadAllLines(txtInput.Text);
                var regex = new Regex(@"^\d{2}:\d{2}:\d{2}.+");
                using (var writer = new StreamWriter(txtOutput.Text))
                {
                    foreach (var line in lines)
                        if (regex.IsMatch(line))
                            writer.WriteLine(line);
                }
                MessageBox.Show("Готово! Всё перенесли в файл!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

    }
}
