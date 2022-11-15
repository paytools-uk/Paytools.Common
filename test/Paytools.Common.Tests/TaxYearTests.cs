namespace Paytools.Common.Tests;

public class TaxYearTests
{
    [Fact]
    public void TestSpecificTaxYear()
    {
        var date = new DateOnly(2020, 4, 5);
        TaxYearEnding ending = TaxYear.FromDate(date);
        Assert.Equal(TaxYearEnding.Apr5_2020, ending);

        date = new DateOnly(2020, 4, 6);
        ending = TaxYear.FromDate(date);
        Assert.Equal(TaxYearEnding.Apr5_2021, ending);
    }

    [Fact]
    public void TestUnsupportedTaxYears()
    {
        Action action = () => TaxYear.FromDate(new DateOnly((int)TaxYearEnding.MinValue - 1, 1, 1));
        Assert.Throws<ArgumentOutOfRangeException>(action);

        action = () => TaxYear.FromDate(new DateOnly((int)TaxYearEnding.MaxValue + 1, 1, 1));
        Assert.Throws<ArgumentOutOfRangeException>(action);
    }
}