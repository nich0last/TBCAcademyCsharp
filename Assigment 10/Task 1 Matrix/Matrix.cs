namespace Matrix
{
    public class Matrix
    {
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new ArgumentException("Matrix dimensions must be the same.");
            }

            Matrix result = new Matrix(matrix1.rows, matrix1.columns);

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
    }
}