namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Array.Sort(input);

                sw.WriteLine(input[1] + input[2]);

            } // using
        } // Main
    } // class
} // namespace