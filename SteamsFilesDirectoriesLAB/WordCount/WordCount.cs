namespace WordCount;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class WordCount
{
    static void Main()
    {
        string wordPath = @"..\..\..\Files\words.txt";
        string textPath = @"..\..\..\Files\text.txt";
        string outputPath = @"..\..\..\Files\output.txt";

        CalculateWordCounts(wordPath, textPath, outputPath);
    }

    public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
    {
        using (StreamReader wordsReader = new StreamReader(wordsFilePath))
        {
            using (StreamReader textReader = new StreamReader(textFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    Dictionary<string, int> wordCount = new();

                    string[] wordsToCheck = wordsReader.ReadToEnd().Split().Select(word => word.ToLower()).ToArray();

                    for(int i = 0; i < wordsToCheck.Length; i++)
                    {
                        wordCount.Add(wordsToCheck[i], 0);
                    }

                    while (!textReader.EndOfStream)
                    {
                        string[] wordsInLine = textReader.ReadLine().ToLower().Split(new[] { ' ', ',', '.', '!', '?', '-', ';', ':', '"' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in wordsInLine)
                        {
                            if (wordCount.ContainsKey(word))
                            {
                                wordCount[word]++;
                            }
                        }
                    }

                    foreach(var kvp in wordCount.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}