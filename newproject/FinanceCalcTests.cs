using Xunit;

public class FinanceCalcTests
{
    [Fact]
    public void CalculateSimpleInterest_ReturnsCorrectResult()
    {
        double result = FinanceCalc.CalculateSimpleInterest(1000, 5, 2);
        Assert.Equal(100, result, 2);
    }

    [Fact]
    public void CalculateCompoundInterest_ReturnsCorrectResult()
    {
        double result = FinanceCalc.CalculateCompoundInterest(1000, 5, 2, 1);
        Assert.Equal(102.5, result, 1);
    }

    [Fact]
    public void CalculateMonthlyPayment_ReturnsCorrectResult()
    {
        double result = FinanceCalc.CalculateMonthlyPayment(1000, 12, 1);
        Assert.Equal(88.85, result, 2);
    }

    [Fact]
    public void CalculateMonthlyPayment_ZeroInterest_ReturnsPrincipalDividedByMonths()
    {
        double result = FinanceCalc.CalculateMonthlyPayment(1200, 0, 1);
        Assert.Equal(100, result, 2);
    }

    [Fact]
    public void CalculateCompoundInterest_QuarterlyCompounding_ReturnsCorrectResult()
