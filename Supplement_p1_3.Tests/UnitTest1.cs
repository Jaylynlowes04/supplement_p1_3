namespace Supplement_p1_3.Tests;

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
}
