namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int N = int.Parse(sr.ReadLine());

                for (int i = 0; i < N; i++)
                {
                    sw.Write(new string(' ', i));
                    sw.WriteLine(new string('*', 2 * (N - i) - 1));
                }

                for (int i = 1; i < N; i++)
                {
                    sw.Write(new string(' ', (N - i) - 1));
                    sw.WriteLine(new string('*', (2 * i) + 1));
                }

            } // using
        } // Main
    } // class
} // namespace