namespace Paytools.Common;

public interface ITaxBandProvider
{
    ITaxBandSet GetBands(CountriesForTaxPurposes countries, TaxYearEnding yearEnding);
}
