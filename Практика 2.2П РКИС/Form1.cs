using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleDictionaryApp
{
    public partial class Form1 : Form
    {
        private DictionaryProcessor processor = new DictionaryProcessor();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                List<string> keys = processor.ParseInput(txtKeys.Text);
                List<string> values = processor.ParseInput(txtValues.Text);

                processor.FillDictionary(keys, values);
                UpdateDisplay();
            }
            catch (ArgumentException ex)
            {
                if (ex.Message.Contains("Ключ"))
                    errorProvider.SetError(txtKeys, ex.Message);
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDisplay()
        {
            lstDictionary.Items.Clear();
            foreach (KeyValuePair<string, string> pair in processor.Dictionary)
            {
                lstDictionary.Items.Add($"{pair.Key} -> {pair.Value}");
            }

            lstDuplicates.Items.Clear();
            Dictionary<string, int> duplicates = processor.FindDuplicates();
            if (duplicates.Count > 0)
            {
                foreach (KeyValuePair<string, int> pair in duplicates)
                {
                    lstDuplicates.Items.Add($"{pair.Key} (встречается {pair.Value} раз)");
                }
            }
            else
            {
                lstDuplicates.Items.Add("Повторяющихся значений нет");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}