namespace FolderSize;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
public class FolderSize
{
    static void Main(string[] args)
    {
        string folderPath = @"..\..\..\Files\TestFolder";
        string outputPath = @"..\..\..\Files\output.txt";

        GetFolderSize(folderPath, outputPath);
    }

    public static void GetFolderSize(string folderPath, string outputFilePath)
    {
        Queue<string> queue = new();
        queue.Enqueue(folderPath);

        long totalSize = 0;
        while (queue.Count > 0)
        {
            string currentFolder = queue.Dequeue();

            foreach(string file in Directory.GetFiles(currentFolder))
            {
                FileInfo info = new FileInfo(file);
                totalSize += info.Length;
            }

            foreach(string subFolder in Directory.GetDirectories(currentFolder))
            {
                queue.Enqueue(subFolder);
            }
        }

        File.WriteAllText(outputFilePath, $"{totalSize / 1024m} KB");
    }
}
