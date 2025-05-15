using Xunit;

public class FinanceCalcLargeNumbersTests
{
    [Fact]
    public void CalculateSimpleInterest_LargeNumbers_ReturnsCorrectResult()
    {
        double principal = 1_000_000_000;
        double rate = 7.5;
        int time = 20;
        double expected = principal * rate * time / 100; // 1,500,000,000
        double result = FinanceCalc.CalculateSimpleInterest(principal, rate, time);
        Assert.Equal(expected, result, 2);
    }

    [Fact]
    public void CalculateCompoundInterest_LargeNumbers_ReturnsCorrectResult()
    {
        double principal = 500_000_000;
        double rate = 6.2;
        int time = 15;
        int compoundsPerYear = 12;
        double amount = principal * System.Math.Pow(1 + rate / (100 * compoundsPerYear), compoundsPerYear * time);
        double expected = amount - principal;
        double result = FinanceCalc.CalculateCompoundInterest(principal, rate, time, compoundsPerYear);
        Assert.Equal(expected, result, 2);
    }

    [Fact]
    public void CalculateMonthlyPayment_LargeNumbers_ReturnsCorrectResult()
    {
        double principal = 2_000_000_000;
        double rate = 4.5;
        int years = 30;
        double monthlyRate = rate / (12 * 100);
        int months = years * 12;
        double expected = (principal * monthlyRate * System.Math.Pow(1 + monthlyRate, months)) /
                          (System.Math.Pow(1 + monthlyRate, months) - 1);
        double result = FinanceCalc.CalculateMonthlyPayment(principal, rate, years);
        Assert.Equal(expected, result, 2);
    }
}