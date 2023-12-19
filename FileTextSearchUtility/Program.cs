using System;

namespace FileTextSearchUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Используйте : utility.exe <directory> <extension> <text>");
                return;
            }

            var files = Task2.FileSearchUtility.SearchFiles(args[0], args[1]);

            foreach (var file in files)
            {
                Console.WriteLine($"Searching in file: {file}");
                Task3.TextSearchUtility.SearchAndPrint(file, args[2]);
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadLine();
        }
    }
}
