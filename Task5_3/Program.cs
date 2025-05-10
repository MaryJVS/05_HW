namespace Task5_3
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
                t[i] = rnd.Next(0, 51);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            int max = t[0];
            int maxIndex = 0;

            for (int i = 0; i < n; ++i)
            {
                if (t[i] > max)
                {
                    max = t[i];
                    maxIndex = i;
                }
            }

            int min = t[0];
            int minIndex = 0;

            for (int i = 0; i < n; ++i)
            {
                if (t[i] < min)
                {
                    min = t[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Наибольший элемент массива равен {0} и имеет индекс {1}",max, maxIndex);
            Console.WriteLine("Наименьший элемент массива равен {0} и имеет индекс {1}",min, minIndex);
            Console.ReadKey();
        }
    }
}
