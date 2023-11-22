class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите температуру: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] temperatures = new int[n];

        for (int i = 0; i < n; i++)
        {
            temperatures[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i < n - 1; i++)
        {
            if (temperatures[i] > temperatures[i - 1] && temperatures[i] > temperatures[i + 1])
            {
                Console.WriteLine("day " + (i + 1) + ": " + temperatures[i] + " (max)");
            }
            else if (temperatures[i] < temperatures[i - 1] && temperatures[i] < temperatures[i + 1])
            {
                Console.WriteLine("day " + (i + 1) + ": " + temperatures[i] + " (min)");
            }
        }
    }
}