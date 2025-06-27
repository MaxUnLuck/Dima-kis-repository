using System;
using System.Windows.Forms;

namespace MatrixNegativeElements
{
    public partial class Form1 : Form
    {
        private Matrix<int> matrix;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                int rows = int.Parse(txtRows.Text);
                int cols = int.Parse(txtCols.Text);
                int min = int.Parse(txtMin.Text);
                int max = int.Parse(txtMax.Text);
                if (min >= max)
                {
                    throw new ArgumentException("Минимальное значение должно быть меньше максимального");
                }
                matrix = new Matrix<int>(rows, cols);
                matrix.FillRandom(min, max);
                txtMatrix.Text = matrix.ToString();
                lblResult.Text = "Матрица сгенерирована";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrix == null)
                    throw new Exception("Сначала сгенерируйте матрицу");

                int count = matrix.CountEvenNegativeElements();
                lblResult.Text = $"Чётных отрицательных элементов: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtCols_TextChanged(object sender, EventArgs e)
        {

        }
    }
}