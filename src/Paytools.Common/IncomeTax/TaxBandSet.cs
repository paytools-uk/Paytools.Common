namespace Paytools.Common;

public class TaxBandSet //: ITaxBandSet
{
    public PersonalAllowance[] PersonalAllowances { get; set; } = Array.Empty<PersonalAllowance>();
    public TaxYearEnding ApplicableTaxYearEnding { get; set; }
    public CountriesForTaxPurposes ApplicableCountries { get; set; }
    public TaxBand[] TaxBands { get; set; } = Array.Empty<TaxBand>();
}