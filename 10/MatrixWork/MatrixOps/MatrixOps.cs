using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Operations
    {
        int[,] A;
        int[,] B;
        int[,] C;

        public int[,] getA
        {
            get { return A; }
        }
        public int[,] getB
        {
            get { return B; }
        }
        public int[,] getC
        {
            get { return C; }
        }
        int n;
        public Operations(int n)
        {
            this.n = n;
            A = new int[n, n];
            B = new int[n, n];
            C = new int[n, n];
            Generate();
        }

        private void Generate()
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rand.Next(1,3);
                    B[i, j] = rand.Next(1,3);
                }
            }
        }

        public void Add()
        {
            C = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
        }

        public void AddPar()
        {
            C = new int[n, n];
            Parallel.For(0, n, (i) =>
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            });
        }

        public void Sub()
        {
            C = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
        }

        public void SubPar()
        {
            C = new int[n, n];
            Parallel.For(0, n, (i) =>
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            });
        }

        public void Mult()
        {
            C = new int[n, n];
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp = 0;
                    for (int k = 0; k < n; k++)
                        C[i,j] += A[i,k] * B[k,j];
                }
            }
        }

        public void MultPar()
        {
            C = new int[n, n];
            Parallel.For(0, n, (i) =>
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                        C[i, j] += A[i, k] * B[k, j];
                }
            });
        }
    }
}
