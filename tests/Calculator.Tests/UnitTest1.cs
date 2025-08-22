using Calculator.Core;
using Xunit;

namespace Calculator.Tests;

public class CalculatorServiceTests
{
    [Fact]
    public void Add_Works()
    {
        var svc = new CalculatorService();
        Assert.Equal(5, svc.Add(2, 3));
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        var svc = new CalculatorService();
        Assert.Throws<DivideByZeroException>(() => svc.Divide(1, 0));
    }
}
