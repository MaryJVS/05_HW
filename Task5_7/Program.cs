namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] t = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = random.Next(0, 11);
                    Console.Write("{0,3} ", t[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Максимальное значение в каждой строке:");
            for (int i = 0; i < n; i++)
            {
                int max = t[i, 0];
                for (int j = 1; j < m; j++)
                {
                    if (t[i, j] > max)
                    {
                        max = t[i, j];
                    }
                }
                Console.WriteLine(max);
            }
            Console.ReadKey();

        }
    }
}
