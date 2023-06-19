namespace FileDirOpdracht
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DirectoryInfo dir = new DirectoryInfo("C:/MediaCollege/Periode.4/M4PROG/2023P4ProgCs2");


            DirectoryInfo[] directories = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();



            for (int i = 0; i < directories.Length; i++)
            {

                Console.WriteLine(directories[i].FullName);
            }
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine();

                Console.WriteLine(files[i].FullName);
            }
        }
    }
}