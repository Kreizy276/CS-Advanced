﻿namespace MergeFiles;

using System;
using System.IO;
public class MergeFiles
{
    static void Main()
    {
        var firstInputFilePath = @"..\..\..\Files\input1.txt";
        var secondInputFilePath = @"..\..\..\Files\input2.txt";
        var outputFilePath = @"..\..\..\Files\output.txt";

        MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
    }

    public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
    {
        using (StreamReader inputReader = new StreamReader(firstInputFilePath))
        {
            using (StreamReader secondReader = new StreamReader(secondInputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while(!inputReader.EndOfStream || !secondReader.EndOfStream)
                    {
                        if(!inputReader.EndOfStream) writer.WriteLine(inputReader.ReadLine());

                        if(!secondReader.EndOfStream) writer.WriteLine(secondReader.ReadLine());
                    } 
                }
            }
        }
    }
}
