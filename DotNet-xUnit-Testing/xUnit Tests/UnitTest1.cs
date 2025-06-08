using Unit_Testing_Proj;

namespace xUnit_Tests;

public class UnitTest1
{
    [Fact]
    public void Divide_DivideByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
    
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, -2, -3)]
    [InlineData(-5, 5, 0)]
    public void Add_WithTestCases_ReturnsExpectedResult(int a, int b, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(a, b);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(2, 3, -1)]
    [InlineData(-2, -3, 1)]
    [InlineData(-5,5,-10)]
    public void Subtract_WithTestCases_ReturnsExpectedResult(int a, int b, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(a, b);
        Assert.Equal(expected, result);
    }
    
    

}