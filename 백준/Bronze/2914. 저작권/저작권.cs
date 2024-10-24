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
                int A = int.Parse(input[0]);
                int I = int.Parse(input[1]);
                int song = song = (A * I) - A + 1;
                sw.WriteLine(song);
            }
        }


    }
}