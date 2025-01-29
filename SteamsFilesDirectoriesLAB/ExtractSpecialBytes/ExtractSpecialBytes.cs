namespace ExtractSpecialBytes;

using System;
using System.Collections.Generic;
using System.IO;
public class ExtractSpecialBytes
{
    static void Main()
    {
        string binaryFilePath = @"..\..\..\Files\example.png";
        string bytesFilePath = @"..\..\..\Files\bytes.txt";
        string outputPath = @"..\..\..\Files\output.bin";

        ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
    }

    public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
    {
        HashSet<byte> specialBytes = new HashSet<byte>();
        using (StreamReader reader = new StreamReader(bytesFilePath))
        {
            while(!reader.EndOfStream)
            {
                byte currentByte = byte.Parse(reader.ReadLine());
                specialBytes.Add(currentByte);
            }
        }

        using(FileStream binaryReader = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
        {
            using(FileStream outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while((bytesRead = binaryReader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for(int i = 0; i < bytesRead; i++)
                    {
                        if (specialBytes.Contains(buffer[i]))
                        {
                            outputStream.WriteByte((byte)buffer[i]);
                        }
                    }
                }

                /*while((currentByte = binaryReader.ReadByte()) != -1)
                {
                    if (specialBytes.Contains((byte)currentByte))
                    {
                        outputStream.WriteByte((byte)currentByte);
                    }
                }*/
            }
        }
    }
}
