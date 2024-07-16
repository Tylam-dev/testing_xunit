namespace StringManipulationTest;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;
using StringManipulation;
public class UnitTest1
{
    [Fact(Skip = "Esta prueba no es valida, TICKET-001")]
    public void ConcatenateString()
    {
        //Arrange
        var strOperation = new StringOperations();
        //Act
        var result = strOperation.ConcatenateStrings("Hello", "Platzi");
        //Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("Hello Platzi", result);
    }

    [Theory]
    [InlineData("ana", true)]
    [InlineData("casa", false)]
    public void IsPalindrome(string word, Boolean expected)
    {
        //Arrange
        var stroperations = new StringOperations();
        //Act
        var result = stroperations.IsPalindrome(word);
        //Assert
        Assert.Equal(result, expected);
    }
    
    [Fact]
    public void RemoveWhiteSpaceTest()
    {
        // Given
        var strOperations = new StringOperations();
        // When
        var result = strOperations.RemoveWhitespace("sdfvsdfv");
        // Then
        Assert.DoesNotContain(" ", result);
    }

    [Fact]
    public void QuantintyInWords()
    {
        var stroperation = new StringOperations();
        var result = stroperation.QuantintyInWords("cat", 10);
        Assert.StartsWith("diez", result);
        Assert.Contains("cat", result);
    }
    [Fact]
    public void GetStringLength_Exception()
    {
        var strOperation = new StringOperations();
        Assert.ThrowsAny<ArgumentNullException>(() => strOperation.GetStringLength(null));
    }
    [Theory]
    [InlineData("V", 5)]
    [InlineData("IV", 4)]
    [InlineData("X", 10)]
    public void FromRomanToNumber(string romanNumber, int expected)
    {
        var strOperation = new StringOperations();
        var result = strOperation.FromRomanToNumber(romanNumber);

        Assert.Equal(expected, result);
    }
    [Fact]
    public void CountOccurrences()
    {
        var mockLogger = new Mock<ILogger<StringOperations>>();
        var strOperation = new StringOperations(mockLogger.Object);
        var result = strOperation.CountOccurrences("Hello platzi", 'l');
        Assert.Equal(3, result);
    }
    [Fact]
    public void RoadFile()
    {
        var mockFileReader = new Mock<IFileReaderConector>();
        var strOperations = new StringOperations();
        mockFileReader.Setup(p => p.ReadString("file.txt")).Returns("Reading file");

        var result = strOperations.ReadFile(mockFileReader.Object, "file.txt");

        Assert.Equal("Reading file", result);
    }
}