using System;

namespace MatrixCalculator.Models
{
    internal class Matrix
    {
        private int _rows;
        private int _cols;
        private double[][] _arr;

        public Matrix(int rows, int cols, double[][] arr)
        {
            _rows = rows;
            _cols = cols;
            _arr = arr;
        }

        public void Display()
        {
            Console.WriteLine($"\nMatrix size: {_rows} x {_cols}");
            foreach (var row in _arr)
            {
                Console.Write("[");
                for (int i = 0; i < row.Length; i++)
                {
                    Console.Write(row[i]);
                    if (i != row.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
            Console.WriteLine();
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            double[][] result = new double[m1._rows][];

            for (int i = 0; i < m1._rows; i++)
            {
                result[i] = new double[m1._cols];

                for (int j = 0; j < m1._cols; j++)
                {
                    result[i][j] = m1._arr[i][j] + m2._arr[i][j];
                }
            }

            return new Matrix(m1._rows, m1._cols, result);
        }
        
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            double[][] result = new double[m1._rows][];

            for (int i = 0; i < m1._rows; i++)
            {
                result[i] = new double[m1._cols];

                for (int j = 0; j < m1._cols; j++)
                {
                    result[i][j] = m1._arr[i][j] - m2._arr[i][j];
                }
            }

            return new Matrix(m1._rows, m1._cols, result);
        }
        
        public static Matrix operator *(Matrix m1, double num)
        {
            double[][] result = new double[m1._rows][];

            for (int i = 0; i < m1._rows; i++)
            {
                result[i] = new double[m1._cols];

                for (int j = 0; j < m1._cols; j++)
                {
                    result[i][j] = num * m1._arr[i][j];
                }
            }

            return new Matrix(m1._rows, m1._cols, result);
        }
    }
}