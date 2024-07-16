namespace StringManipulationTest;
using StringManipulation;
public class UnitTest1
{
    [Fact]
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

    [Fact]
    public void IsPalindrome_True()
    {
        //Arrange
        var stroperations = new StringOperations();
        //Act
        var result = stroperations.IsPalindrome("ana");
        //Assert
        Assert.True(result);
    }
        [Fact]
    public void IsPalindrome_False()
    {
        //Arrange
        var stroperations = new StringOperations();
        //Act
        var result = stroperations.IsPalindrome("hello");
        //Assert
        Assert.False(result);
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
}