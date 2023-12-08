using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Copy Files");
            Console.WriteLine("2. List files and direstories");
            Console.WriteLine("3. Delete files and directories");
            Console.WriteLine("4. Search files by name");
            Console.WriteLine("5. Create files and directories");
            Console.Write("What do you do: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "2":
                    ListFiles();
                    break;
            }
            switch (option)
            {
                case "0":
                    Environment.Exit(0);
                    break;
            }
        }
    }

    static void CopyFile()
    {

    }

    static void ListFiles()
    {
        Console.Write("Inset path to directory: ");
        string directoryPath = Console.ReadLine();

        string[] files = Directory.GetFiles(directoryPath);
        string[] directories = Directory.GetDirectories(directoryPath);

        Console.WriteLine("\nFiles: ");
        foreach (var file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        Console.WriteLine("\nDirectories: ");
        foreach (var directory in directories)
        {
            Console.WriteLine(Path.GetFileName(directory));
        }
    }

    static void DeleteFile()
    {

    }

    static void SearchFile()
    {

    }

    static void CreateFile()
    {

    }
}
