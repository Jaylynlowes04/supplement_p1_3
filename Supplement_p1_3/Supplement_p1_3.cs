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
        throw new NotImplementedException();
    }

    public static string ReadAsciiFile(string filePath)
    {
        throw new NotImplementedException();
    }

    public static byte[] ReadBinaryFile(string filePath)
    {
        throw new NotImplementedException();
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
