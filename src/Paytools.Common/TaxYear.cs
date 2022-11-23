namespace Paytools.Common;

public class TaxYear
{
    private static readonly CountriesForTaxPurposes _defaultCountriesBefore6Apr2020 =
        CountriesForTaxPurposes.England | CountriesForTaxPurposes.Wales | CountriesForTaxPurposes.NorthernIreland;

    private static readonly CountriesForTaxPurposes _defaultCountriesFrom6Apr2020 =
        CountriesForTaxPurposes.England | CountriesForTaxPurposes.NorthernIreland;

    private static readonly CountriesForTaxPurposes[] _countriesForBefore6Apr2020 = new[]
    {
        _defaultCountriesBefore6Apr2020,
        CountriesForTaxPurposes.Scotland
    };
    private static readonly CountriesForTaxPurposes[] _countriesForFrom6Apr2020 = new[]
    {
        _defaultCountriesFrom6Apr2020,
        CountriesForTaxPurposes.Wales,
        CountriesForTaxPurposes.Scotland
    };

    public TaxYearEnding TaxYearEnding { get; init; }

    public static TaxYearEnding Current => FromDate(DateOnly.FromDateTime(DateTime.Now));

    public TaxYear(TaxYearEnding taxYearEnding)
    {
        TaxYearEnding = taxYearEnding;
    }

    public TaxYear(DateOnly taxDate)
    {
        TaxYearEnding = FromDate(taxDate);
    }

    public static TaxYearEnding FromDate(DateOnly date)
    {
        var apr6 = new DateOnly(date.Year, date.Month, 6);

        var taxYear = date < apr6 ? date.Year : date.Year + 1;

        if (taxYear < (int)TaxYearEnding.MinValue || taxYear > (int)TaxYearEnding.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(taxYear), $"Unsupported tax year; date must fall within range tax year ending 6 April {(int)TaxYearEnding.MinValue} to 6 April {(int)TaxYearEnding.MaxValue}");

        return (TaxYearEnding)taxYear;
    }

    public CountriesForTaxPurposes GetDefaultCountriesForYear()
    {
        return TaxYearEnding switch
        {
            TaxYearEnding.Unspecified => throw new InvalidOperationException("Unable to retrieve default countries for uninitialised tax year"),
            TaxYearEnding.Apr5_2019 => _defaultCountriesBefore6Apr2020,
            _ => _defaultCountriesFrom6Apr2020
        };
    }

    public CountriesForTaxPurposes[] GetCountriesForYear()
    {
        return TaxYearEnding switch
        {
            TaxYearEnding.Unspecified => throw new InvalidOperationException("Unable to verify countries for uninitialised tax year"),
            TaxYearEnding.Apr5_2019 => _countriesForBefore6Apr2020,
            _ => _countriesForFrom6Apr2020
        };
    }

    public bool IsValidForYear(CountriesForTaxPurposes countries)
    {
        var countriesForYear = GetCountriesForYear();

        return countriesForYear.Where(c => c == countries).Any();
    }
}