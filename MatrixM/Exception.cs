using System;

namespace MatrixM
{
    public class InvalidMatrixSizeException : Exception
    {
        public InvalidMatrixSizeException(int size) : base($"Не правильный размер матрицы: {size}")
        {
        }
    }

    public class MatrixNotInvertibleException : Exception
    {
        public MatrixNotInvertibleException() : base("Матрица не может Инверс.")
        {
        }
    }
}