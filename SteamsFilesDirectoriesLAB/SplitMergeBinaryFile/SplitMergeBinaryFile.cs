namespace SplitMergeBinaryFile;

using System;
using System.IO;
using System.Linq;

public class SplitMergeBinaryFile
{
    static void Main()
    {
        string sourceFilePath = @"..\..\..\Files\example.png";
        string joinedFilePath = @"..\..\..\Files\example-joined.png";
        string partOnePath = @"..\..\..\Files\part-1.bin";
        string partTwoPath = @"..\..\..\Files\part-2.bin";

        SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
        MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
    }

    public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
    {
        using (FileStream inputFile = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        {
            long fileSize = inputFile.Length;
            long part1Size = (fileSize + 1) + 2;
            long part2Size = fileSize - part1Size;

            byte[] buffer = new byte[1024];
            int bytesRead;

            using (FileStream writer1 = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
            {
                using (FileStream writer2 = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    long bytesWritten = 0;
                    while (bytesWritten < part1Size && (bytesRead = inputFile.Read(buffer, 0, (int)Math.Min(buffer.Length, part1Size - bytesWritten))) > 0)
                    {
                        writer1.Write(buffer, 0, bytesRead);
                        bytesWritten += bytesRead;
                    }

                    bytesWritten = 0;
                    while (bytesWritten < part2Size && (bytesRead = inputFile.Read(buffer, 0, (int)Math.Min(buffer.Length, part2Size - bytesWritten))) > 0)
                    {
                        writer2.Write(buffer, 0, bytesRead);
                        bytesWritten += bytesRead;
                    }
                }
            }
        }
    }

    public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
    {
        using (FileStream outputFile = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
        {
            using (FileStream part1 = new(partOneFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream part2 = new(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = part1.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        outputFile.Write(buffer, 0, bytesRead);
                    }

                    while ((bytesRead = part2.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        outputFile.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}