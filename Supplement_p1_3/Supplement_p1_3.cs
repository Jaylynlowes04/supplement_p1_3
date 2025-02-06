namespace Supplement_p1_3;
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
        throw new NotImplementedException();
    }
    private static string GenerateRandomString(int length)
    {
        throw new NotImplementedException();
    }
}
