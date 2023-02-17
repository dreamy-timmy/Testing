namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            for(int i=1;i< 100 ;i++)
            {
                if (F(i) != 0 && i>index) index = i;
            }
            Console.WriteLine(index);
        }
        public static int F(int n)
        {
            if (n <= 5) return n;
            if (n % 8 == 0)
            {
                if ((n / 2 - 3) % 4 == 0 || (n / 2 - 3) <= 5)
                {
                    return n + F(n / 2 - 3);
                }
                else return 0;
            }
            else if (n % 4 == 0 && F(n+4) !=0) return n + F(n + 4);
            else return 0;
        }
    }
}