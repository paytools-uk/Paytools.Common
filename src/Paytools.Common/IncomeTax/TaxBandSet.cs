namespace Paytools.Common;

public class TaxBandSet //: ITaxBandSet
{
    public TaxYearEnding ApplicableTaxYearEnding { get; set; }
    public CountriesForTaxPurposes ApplicableCountries { get; set; }
    public PersonalAllowance[] PersonalAllowances { get; set; } = Array.Empty<PersonalAllowance>();
    public TaxBand[] TaxBands { get; set; } = Array.Empty<TaxBand>();
}