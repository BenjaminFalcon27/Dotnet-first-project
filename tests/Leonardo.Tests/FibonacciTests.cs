using Xunit;
using Leonardo;

public class FibonacciTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    public void TestFibonacci(int input, int expected)
    {
        var fibonacci = new Fibonacci();
        var result = fibonacci.GetFibonacciNumber(input);
        Assert.Equal(expected, result);
    }
}