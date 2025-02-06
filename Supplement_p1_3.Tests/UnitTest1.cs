namespace Supplement_p1_3.Tests;
using System.IO;
using System.Text;
public class UnitTest1
{
    [Fact]
    public void TestCreateAndReadAsciiFiles()
    {
        string filePath = "test_ascii.txt";
        string content = "Hello, ASCII File!";
        
        Supplement_p1_3.CreateAsciiFile(filePath, content);
        string readContent = Supplement_p1_3.ReadAsciiFile(filePath);
        
        Assert.Equal(content, readContent);
        File.Delete(filePath);
    }

    [Fact]
    public void TestCreateAndReadBinaryFiles()
    {
        string filePath = "test_binary.bin";
        byte[] content = Encoding.ASCII.GetBytes("Hello, Binary File!");
        
        Supplement_p1_3.CreateBinaryFile(filePath, content);
        byte[] readContent = Supplement_p1_3.ReadBinaryFile(filePath);
        
        Assert.Equal(content, readContent);
        File.Delete(filePath);
    }
}
