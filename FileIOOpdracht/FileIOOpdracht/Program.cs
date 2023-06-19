namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] content = File.ReadAllLines("leesdezefile.txt");
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
            File.WriteAllText("mijnnieuwefile.txt", "text");
            File.AppendAllText("mijnnieuwefile.txt", "\r\nasd");
            Directory.CreateDirectory("output");
            File.Move("mijnnieuwefile.txt", "output/mijnnieuwefile.txt", true);
        }
    }
}