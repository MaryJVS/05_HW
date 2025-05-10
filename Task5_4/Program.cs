namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 11);
                Console.Write("{0} ", t[i]);
            }

            Console.WriteLine();

            int k = 0;
            for (int i = 0; i < n; i++)
            {
                k = n - 1 - i;
                Console.Write("{0} ", t[k]);
            }

            Console.ReadKey();

        }
    }
}
