using System.Collections.Generic;

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
                int N  = int.Parse(input[0]);
                int K = int.Parse(input[1]);
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                int sum = 0;
                for (int i = 0; i < K; ++i)
                {
                    sum += nums[i];
                }

                int max = sum;
                for (int i = K; i < N; ++i)
                {
                    sum = sum - nums[i - K] + nums[i];
                    max = Math.Max(max, sum);
                }

                sw.WriteLine(max);
            }
        }
    }
}