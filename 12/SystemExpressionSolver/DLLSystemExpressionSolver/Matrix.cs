using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLSystemExpressionSolver
{
    /// <summary>
    /// Находит детерминант матрицы.
    /// Находит обратную матрицу.
    /// Решает СЛАУ последовательным и параллельным алгоритмами.
    /// </summary>
    public class SolverMatrix
    {
        private static float[,] matrix;
        private static int n;
        private static int m;
        private static float det;
        private static float[] rightPart;
        private static Random rnd;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public SolverMatrix(int i, int j)
        {
            n = i;
            m = j;
            matrix = new float[i,j];
            rightPart = new float[n];

            rnd = new Random();
            RandomGenerate();
            //LinearSolver(matrix, rightPart);
            //LinearSolver(n,matrix);
            //ReverseMatrix(matrix);
        }

        /// <summary>
        /// Случайно объявляет значения матрицы
        /// </summary>
        private static void RandomGenerate()
        {
           for (int i = 0;i<n;i++)
               for (int j = 0;j<m;j++)
                   matrix[i, j] = rnd.Next(-n * n, n * n);

            for (int i = 0; i < n; i++)
                rightPart[i] = rnd.Next(-n,n);
        }

        /// <summary>
        /// Вычислить определитель матрицы
        /// </summary>
        public static float DeterminantGauss()
        {
            int i, j, k;
            det = 1;

            //прямой ход
            for (i = 0; i<n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (matrix[i,i] == 0) return 0;

                    float b = matrix[j,i] / matrix[i,i];

                    for (k = i; k < n; k++)
                    {
                        matrix[j,k] = matrix[j,k] - matrix[i,k] * b;
                    }
                }
                det *= matrix[i,i]; //вычисление определителя
            }
            return det;
        }

        /// <summary>
        /// Найти обратную матрицу/
        /// Оболочка
        /// </summary>
        /// <returns></returns>
        public static bool ReverseMatrixSheel()
        {
            ReverseMatrix(matrix);
            return true;
        }
    
        /// <summary>
        /// Найти обратную матрицу
        /// </summary>
        /// <param name="A"></param>
        private static void ReverseMatrix(float[,] A)
        {
            //обратная матрица СмОбратная
            float[,] AObrat = new float[n, n];
            float[,] ACopy = new float[n, n];

            //задаем обратную матрицу как единичную           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) { AObrat[i, j] = 1; }
                    else { AObrat[i, j] = 0; }
                    ACopy[i, j] = A[i,j];    //создаем копию матрицы См
                }
            }

            //прямой ход
            for (int k = 0; k < n; ++k)
            {
                float div = ACopy[k, k];
                for (int m = 0; m < n; ++m)
                {// делим строку на выбранный элемент === 1  ф  ф
                    ACopy[k, m] /= div;
                    AObrat[k, m] /= div;
                }
                for (int i = k + 1; i < n; ++i) //идем по столбц ниже полученой единицы
                {
                    float multi = ACopy[i, k]; //элемент, который хотим занулить
                    for (int j = 0; j < n; ++j)// элемент по счету в строке i
                    {
                        ACopy[i, j] -= multi * ACopy[k, j];
                        AObrat[i, j] -= multi * AObrat[k, j];
                    }
                }

            }

            //обратный ход            
            for (int kk = n - 1; kk > 0; kk--)
            {
                for (int i = kk - 1; i + 1 > 0; i--)
                {
                    float multi2 = ACopy[i, kk];
                    for (int j = 0; j < n; j++)
                    {
                        ACopy[i, j] -= multi2 * ACopy[kk, j];
                        AObrat[i, j] -= multi2 * AObrat[kk, j];
                    }
                }
            }

            float[,] Ee = new float[n, n];
            int flagA = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) Ee[i, j] = 1; 
                    else Ee[i, j] = 0; 
                    if (Ee[i, j] == ACopy[i, j]) flagA = 1;
                }
            }

            //проверка СмОбратной
            //CmObrat*Cm
            float[,] ProverkaA = new float[n, n];
            for (int i = 0; i < n; i++)//строки
                for (int j = 0; j < n; j++)//столбцы
                    for (int k = 0; k < n; k++)
                        ProverkaA[i, j] += AObrat[i, k] * A[k,j];

            int flag11 = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (!(Math.Abs(Ee[i, j] - ProverkaA[i, j]) > 0.002)) flag11 = 1;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    AObrat[i, j] = (float)Math.Round(AObrat[i, j], 3);
        }

        /// <summary>
        /// Решение системы линейных уравнений. Оболочка
        /// </summary>
        /// <returns></returns>
        public static string[] LinearSolverSheel(TextBox seq, TextBox par)
        {
            DateTime startTimeSeq = DateTime.Now;
            float[] sheel = LinearSolver(matrix, rightPart,false);
            DateTime endSeq = DateTime.Now;
            string[] stringSheel = new string[sheel.Length];
            for (int i = 0; i < sheel.Length; i++)
                stringSheel[i] = "x" + i + " = " + sheel[i];

            DateTime startTimePar = DateTime.Now;
            sheel = LinearSolver(matrix, rightPart,true);
            DateTime endPar = DateTime.Now;

            TimeIsEnded(seq, par, (endSeq -startTimeSeq).Ticks,(endPar-startTimePar).Ticks);

            return stringSheel;
        }

        /// <summary>
        /// Решение системы линейных уравнений
        /// </summary>
        /// <param name="B"></param>
        /// <param name="RightPart"></param>
        /// <returns></returns>
        private static float[] LinearSolver(float[,] B, float[] RightPart,bool isParallel)
        {
            float[] x = new float[n];
            float R;

            try
            {
                // Прямой ход
                if (isParallel)
                {
                    for (int q = 0; q < n; q++)
                    {
                        R = 1 / B[q, q];
                        B[q, q] = 1;
                        for (int j = q + 1; j < n; j++)
                            B[q, j] *= R;
                        RightPart[q] *= R;
                        Parallel.For(q + 1, n, (k) =>
                        {
                            R = B[k, q];
                            B[k, q] = 0;
                            for (int j = q + 1; j < n; j++)
                                B[k, j] = B[k, j] - B[q, j] * R;
                            RightPart[k] = RightPart[k] - RightPart[q] * R;
                        });
                    }
                }
                else
                {
                    for (int q = 0; q < n; q++)
                    {
                        R = 1 / B[q, q];
                        B[q, q] = 1;
                        for (int j = q + 1; j < n; j++)
                            B[q, j] *= R;
                        RightPart[q] *= R;
                        for(int k = q + 1; k<n; k++)
                        {
                            R = B[k, q];
                            B[k, q] = 0;
                            for (int j = q + 1; j < n; j++)
                                B[k, j] = B[k, j] - B[q, j] * R;
                            RightPart[k] = RightPart[k] - RightPart[q] * R;
                        }
                    }
                }
            }
            catch (DivideByZeroException)
            {
                return x;
            }
            // Обратный ход
            for (int q = n - 1; q >= 0; q--)
            {
                R = RightPart[q];
                for (int j = q + 1; j < n; j++)
                    R -= B[q, j] * x[j];
                x[q] = R;
            }
            return x;
        }

        /// <summary>
        /// Выводим время, затраченное на решение 
        /// последовательной и параллельной версий СЛАУ в тиках
        /// </summary>
        /// <param name="seq"></param>
        /// <param name="par"></param>
        /// <param name="seqTime"></param>
        /// <param name="parTime"></param>
        private static void TimeIsEnded(TextBox seq, TextBox par,long seqTime, long parTime)
        {
            seq.Text = FitTicksValue(seqTime);
            par.Text = FitTicksValue(parTime);
        }

        /// <summary>
        /// Количество тиков в удобной форме
        /// </summary>
        /// <param name="ticks"></param>
        /// <returns></returns>
        public static string FitTicksValue(long ticks)
        {
            char[] result = ticks.ToString().ToCharArray();
            Array.Reverse(result);
            string sRes = "";
            for (int i = 1; i < result.Length + 1; i++)
            {
                sRes += result[i - 1];
                if (i % 3 == 0 && i + 1 < result.Length + 1) sRes += ".";
            }
            result = sRes.ToCharArray();
            Array.Reverse(result);
            sRes = "";
            foreach (char c in result)
                sRes += c;

            return sRes;
        }

        /// <summary>
        /// Проверяет корректность введенной размерности матрицы
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool CheckSizes(int x, int y)
        {
            return x != y ? false : true;
        }
    }
}
