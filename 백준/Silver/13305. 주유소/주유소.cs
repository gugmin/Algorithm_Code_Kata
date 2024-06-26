namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long answer = 0;
            int N = int.Parse(Console.ReadLine());
            long[] Price = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] City = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long LowCity = City[0];

            answer += City[0] * Price[0];

            for (int i = 1; i < N - 1; ++i)
            {
                if (LowCity < City[i])
                {
                    answer += LowCity * Price[i];
                }
                else
                {
                    LowCity = City[i];
                    answer += City[i] * Price[i];
                }
            }

            Console.WriteLine(answer);
        }
    }
}
