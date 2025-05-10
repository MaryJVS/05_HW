namespace Task5_2
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
                t[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            foreach (int a in t)
            {
                if (a == 0)
                {
                    s3++;
                }
                else
                {
                    if (a % 2 == 0)
                    {
                        s1++;
                    }
                    else
                    {
                        s2++;
                    }
                }
            }

            Console.WriteLine("Количество четных элементов в массиве = {0}", s1);
            Console.WriteLine("Количество нечетных элементов в массиве = {0}", s2);
            Console.WriteLine("Количество равных 0 элементов в массиве  = {0}", s3);

            Console.ReadKey();
        }
    }
}
