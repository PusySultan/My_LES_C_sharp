namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputpath = "..\\..\\..\\Data\\DataInput.txt";
            string outputPath = "..\\..\\..\\Data\\DataOutput.txt";

            Writer(outputPath ,Sort(Reader(inputpath)));


        }

        private static string[] Reader(string path)
        {
            string[] array;

            using (StreamReader sr = new StreamReader(path))
            {
                array = sr.ReadToEnd().Split([',', ' ']);
            }

            return array;
        }

        private static string[] Sort(string[] array)
        {
            return array
                .Where((a) => a.Trim().Length > 5)
                .OrderBy((a) => a)
                .ToArray();
        }

        private static void Writer(string path, string[] sortArray)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string item in sortArray)
                { 
                    sw.WriteLine(item);
                }
            }
        }

    }
}
