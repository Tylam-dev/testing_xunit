namespace StringManipulationTest;
using StringManipulation;
public class UnitTest1
{
    [Fact]
    public void ConcatenateString()
    {
        var strOperation = new StringOperations();
        var result = strOperation.ConcatenateStrings("Hello", "Platzi");
        Assert.Equal("Hello Platzi", result);
    }
}