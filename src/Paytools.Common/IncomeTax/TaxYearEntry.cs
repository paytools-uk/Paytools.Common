using System.Collections.Immutable;

namespace Paytools.Common;

public class TaxYearEntry
{
    public CountriesForTaxPurposes ApplicableCountries { get; init; }
    public ImmutableArray<PersonalAllowance> PersonalAllowances { get; init; } = ImmutableArray<PersonalAllowance>.Empty;
    public ImmutableArray<TaxBand> TaxBands { get; init; } = ImmutableArray<TaxBand>.Empty;
}
