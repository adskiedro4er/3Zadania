using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] numbersStr = input.Split(' ');
        int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[i] == -numbers[j])
                {
                    Console.WriteLine(i + " " + j);
                    return;
                }
            }
        }
        Console.WriteLine("Противоположные числа не найдены");
    }
}