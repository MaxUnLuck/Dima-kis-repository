using System;

namespace MatrixNegativeElements
{
    public class Matrix<T>
    {
        private T[,] data;
        private int rows;
        private int cols;
        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Размеры матрицы должны быть положительными");

            this.rows = rows;
            this.cols = cols;
            this.data = new T[rows, cols];
        }
        public int Rows { get { return rows; } }
        public int Cols { get { return cols; } }
        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= rows || col < 0 || col >= cols)
                    throw new IndexOutOfRangeException("Индекс вне границ матрицы");
                return data[row, col];
            }
            set
            {
                if (row < 0 || row >= rows || col < 0 || col >= cols)
                    throw new IndexOutOfRangeException("Индекс вне границ матрицы");
                data[row, col] = value;
            }
        }
        public void FillRandom(int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (typeof(T) == typeof(int))
                        data[i, j] = (T)(object)rand.Next(min, max);
                    else if (typeof(T) == typeof(double))
                        data[i, j] = (T)(object)(min + (max - min) * rand.NextDouble());
                }
            }
        }
        public int CountEvenNegativeElements()
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (typeof(T) == typeof(int))
                    {
                        int value = (int)(object)data[i, j];
                        if (value < 0 && value % 2 == 0)
                            count++;
                    }
                    else if (typeof(T) == typeof(double))
                    {
                        double value = (double)(object)data[i, j];
                        if (value < 0 && value % 2 == 0)
                            count++;
                    }
                }
            }
            return count;
        }
        public string String()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += data[i, j].ToString() + "\t";
                }
                result += Environment.NewLine;
            }
            return result;
        }
    }
}