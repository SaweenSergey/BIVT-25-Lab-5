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
 
            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here

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