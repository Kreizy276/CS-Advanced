namespace EvenLines;

using System;
using System.IO;
using System.Linq;

public class EvenLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";

        Console.WriteLine(ProcessLines(inputFilePath));
    }

    public static string ProcessLines(string inputFilePath)
    {
        using (StreamReader inputReader = new StreamReader(inputFilePath))
        {
            int count = 0;

            while (!inputReader.EndOfStream)
            {
                string line = inputReader.ReadLine();
                if (count % 2 == 0)
                {
                    string[] words = ReplacedString(line).Split();
                    Array.Reverse(words);
                    Console.WriteLine(string.Join(' ', words));
                }
                count++;
            }
        }

        return "";
    }

    static string ReplacedString(string line)
    {
        char[] symbols = new char[] { '-', ',', '.', '!', '?' };
        foreach(char c in symbols)
        {
            line = line.Replace(c, '@');
        }

        return line;
    }
}
