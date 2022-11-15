namespace Paytools.Common;

public class TaxBand : ITaxBand
{
    public string Description { get; set; } = default!;
    public decimal? From { get; set; }
    public decimal? To { get; set; }
    public decimal Rate { get; set; }
}