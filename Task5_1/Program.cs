namespace Task5_1
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
                t[i] = rnd.Next(0, 101);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            int s1 = 0;
            int s2 = 0;
            foreach (int a in t)
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

            if (s1 != s2)
            {
                if (s1 > s2)
                {
                    Console.WriteLine("Четных чисел больше");
                }
                else
                {
                    Console.WriteLine("Нечетных чисел больше");
                }
            }
            else
            {
            Console.WriteLine("Четных и нечетных чисел одинаковое количество, или все элементы массива равны 0");
            }

            Console.ReadKey();
        }
    }
}
