namespace Paytools.Common;

public interface ITaxBandSet
{
    IPersonalAllowance[] PersonalAllowances { get; }
    TaxYearEnding ApplicableTaxYearEnding { get; }
    CountriesForTaxPurposes ApplicableCountries { get; }
    ITaxBand[] TaxBands { get; }
}
