namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                string[] input = sr.ReadLine().Split();
                long A = long.Parse(input[0]);
                long B = long.Parse(input[1]);
                sw.WriteLine(LCM(A, B));
            }
        }

        static long GCD(long a, long b) // 최대공약수
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static long LCM(long a, long b) // 최소공배수
        {
            return a * (b / GCD(a, b));
        }
    }
}