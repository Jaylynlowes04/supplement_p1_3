﻿namespace Supplement_p1_3;
using System;
using System.IO;
using System.Text;

public class Supplement_p1_3
{
    public static void CreateAsciiFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content, Encoding.ASCII);
    }

    public static void CreateBinaryFile(string filePath, byte[] content)
    {
        File.WriteAllBytes(filePath, content);
    }

    public static string ReadAsciiFile(string filePath)
    {
        return File.ReadAllText(filePath, Encoding.ASCII);
    }

    public static byte[] ReadBinaryFile(string filePath)
    {
        return File.ReadAllBytes(filePath);
    }
    public static void CompareFileSizes()
    {
        int[] sizes = { 10, 100, 1000, 10000, 1000000 };
        foreach (int size in sizes)
        {
            string content = GenerateRandomString(size);
            string asciiPath = $"ascii_{size}.txt";
            string binaryPath = $"binary_{size}.bin";

            CreateAsciiFile(asciiPath, content);
            CreateBinaryFile(binaryPath, Encoding.ASCII.GetBytes(content));

            long asciiSize = new FileInfo(asciiPath).Length;
            long binarySize = new FileInfo(binaryPath).Length;

            Console.WriteLine($"Size of ASCII file ({size} chars): {asciiSize} bytes");
            Console.WriteLine($"Size of Binary file ({size} chars): {binarySize} bytes\n");
        }
    }
    private static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        char[] stringChars = new char[length];
        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }
        return new string(stringChars);
    }
}
