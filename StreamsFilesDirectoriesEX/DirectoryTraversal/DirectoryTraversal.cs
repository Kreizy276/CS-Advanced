namespace DirectoryTraversal;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class DirectoryTraversal
{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = @"report.txt";

        string reportContent = TraverseDirectory(path);
        Console.WriteLine(reportContent);

        WriteReportToDesktop(reportContent, reportFileName);
    }

    public static string TraverseDirectory(string inputFolderPath)
    {
        // dictionary to sort by extensions and a list of files
        Dictionary<string, List<FileInfo>> filesByExtension = new();

        StringBuilder result = new();

        // going through every file from the input folder and adding it to the dictionary
        foreach(string file in Directory.GetFiles(inputFolderPath))
        {
            FileInfo info = new FileInfo(file);

            if (!filesByExtension.ContainsKey(info.Extension)) 
                filesByExtension[info.Extension] = new List<FileInfo>();

            filesByExtension[info.Extension].Add(info);
        }

        // sorting the dictionary by how many files it has and then by the extensions
        foreach (var (extension, file) in filesByExtension.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            result.AppendLine(extension);

            foreach(FileInfo info in filesByExtension[extension].OrderBy(f => f.Length)) 
            {
                result.AppendLine($"-- {info.Name} {info.Length / 1024m} kb");
            }
        }

        return result.ToString();
    }

    public static void WriteReportToDesktop(string textContent, string reportFileName)
    {
        string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string outputPath = Path.Combine(pathToDesktop, reportFileName);

        try
        {
            File.WriteAllText(outputPath, textContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
