namespace Paytools.Common;

public interface ITaxBandProvider
{
    TaxBandSet GetBandsForTaxYear(TaxYear taxYear);
}
