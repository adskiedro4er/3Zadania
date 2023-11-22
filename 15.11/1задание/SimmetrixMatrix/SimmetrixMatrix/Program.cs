using System;

class Program
{
    static string IsMatrixSymmetric(int[][] matrix, int n)
    {
        bool gig;
        gig = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (matrix[i][j] != matrix[j][i])
                {
                    return "NO";
                }
            }
        }
        return "YES";
    }

    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.Write("Введите размерность массива (для выхода введите 'exit'): ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            int n = Convert.ToInt32(input);

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {n} элементов для строки {i}: ");
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            string result = IsMatrixSymmetric(matrix, n);
            Console.WriteLine("Матрица симметрична? Ответ: " + result);
        } while (true);
    }
}
