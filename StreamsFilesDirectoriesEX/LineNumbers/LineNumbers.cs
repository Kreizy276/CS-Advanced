namespace LineNumbers;

using System;
using System.IO;
using System.Linq;

public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        string outputFilePath = @"..\..\..\output.txt";

        ProcessLines(inputFilePath, outputFilePath);
    }

    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        string[] lines = File.ReadAllLines(inputFilePath);
        for(int i = 0; i < lines.Length; i++)
        {
            lines[i] = ProcessLine(i + 1, lines[i]);
        }

        File.WriteAllLines(outputFilePath, lines);

        /*using (StreamReader inputReader = new StreamReader(inputFilePath))
        {
            using(StreamWriter outputWriter = new StreamWriter(outputFilePath))
            {
                int row = 0;
                while (!inputReader.EndOfStream)
                {
                    string line = inputReader.ReadLine();
                    outputWriter.WriteLine(ProcessLine(++row, line));
                }
            }
        }*/
    }

    static string ProcessLine(int row, string line)
    {
        int letterCount = 0, punctuationCount = 0;

        foreach(char symbol in line)
        {
            if(char.IsLetter(symbol)) letterCount++;
            else if(char.IsPunctuation(symbol)) punctuationCount++;
        }

        return $"Line {row}: {line} ({letterCount})({punctuationCount})";
    }
}
