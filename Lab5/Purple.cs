using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Purple
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[] negative = new int[m];
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        negative[j]++;
                    }
                }
            }
            answer = negative;
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[] min = new int[n], index = new int[n];
            for (int i = 0; i < n; i++)
            {
                min[i] = matrix[i, 0];
                index[i] = 0;
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < min[i])
                    {
                        index[i] = j;
                        min[i] = matrix[i, j];
                    }
                }
            }
            int penis;
            for (int i = 0; i < n; i++)
            {
                penis = index[i];
                while (penis > 0)
                {
                    matrix[i, penis] = matrix[i, penis - 1];
                    penis--;
                }
                matrix[i, 0] = min[i];
            }

            // end

        }
        public int[,] Task3(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[] k = new int[n];
            int[] max = new int[n];
            for (int i = 0; i < n; i++)
            {
                max[i] = int.MinValue;
            }
            answer = new int[n, m + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; (j < m); j++)
                {
                    if (matrix [i, j] > max[i])
                    {
                        max [i] = matrix [i, j];
                        k[i] = j;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; (j < m + 1); j++)
                {
                    if (j < k[i])
                    {
                        answer[i, j] = matrix [i, j];
                    }
                    else if (j == k[i])
                    {
                        answer[i, j] = max[i];
                    }
                    else
                    {
                        answer[i, j] = matrix [i, j - 1];
                    }
                }
            }
            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {

            // code here
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[] k = new int[n];
            int[] max = new int[n];
            int[] sum = new int[n];
            int[] count = new int[n];
            for (int i = 0; i < n; i++)
            {
                max[i] = int.MinValue;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; (j < m); j++)
                {
                    if (matrix[i, j] > max[i])
                    {
                        max[i] = matrix[i, j];
                        k[i] = j;
                        sum[i] = 0;
                        count[i] = 0;
                    }
                    else if (matrix[i, j] > 0)
                    {
                        count[i]++;
                        sum[i] += matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; (j < m + 1); j++)
                {
                    if (!(sum[i] == 0))
                    {
                        if (j < k[i])
                        {
                            if (matrix[i, j] < 0)
                            {
                                matrix[i, j] = (sum[i] / count[i]);
                            }
                        }
                    }
                }
            }
            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[] max = new int[n];
            for (int i = 0; i < n; i++)
            {
                max[i] = int.MinValue;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; (j < m); j++)
                {
                    if (matrix[i, j] > max[i])
                    {
                        max[i] = matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; (j < m); j++)
                {
                    if (j == k)
                    {
                        matrix[i, j] = max[n - i - 1];
                    }
                }
            }
            // end

        }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[] max = new int[m], max_index = new int[m];
            if (m == array.Length)
            {
                for (int i = 0; i < m; i++)
                {
                    max[i] = int.MinValue;
                }
                for (int j = 0; j < m; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (matrix[i, j] > max[j])
                        {
                            max[j] = matrix[i, j];
                            max_index[j] = i;
                        }
                    }
                    if (array[j] > max[j])
                    {
                        matrix[max_index[j], j] = array[j];
                    }
                }
            }
            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here
            int n = matrix.GetLength(0), m = matrix.GetLength(1);
            int[] min = new int[n];
            if (n > 1)
            {
                for (int i = 0; i < n; i++)
                {
                    min[i] = int.MaxValue;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i, j] < min[i])
                        {
                            min[i] = matrix[i, j];
                        }
                    }
                }
                int c = 0;
                while (c < n)
                {
                    if ((c == 0) || (min[c] <= min[c - 1]))
                    {
                        c++;
                    }
                    else
                    {
                        (min[c], min[c - 1]) = (min[c - 1], min[c]);
                        for (int i = 0; i < m; i++)
                        {
                            (matrix[c, i], matrix[c - 1, i]) = (matrix[c - 1, i], matrix[c, i]);
                        }
                        c--;
                    }
                }
            }
            // end

        }
        public int[] Task8(int[,] matrix)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task9(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public int[,] Task10(int[,] A, int[,] B)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[][] Task11(int[,] matrix)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
        public int[,] Task12(int[][] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
    }
}