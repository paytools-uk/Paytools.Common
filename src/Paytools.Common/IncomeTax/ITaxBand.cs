namespace Paytools.Common;

public interface ITaxBand
{
    string Description { get; }
    decimal? From { get; }
    decimal? To { get; }
    decimal Rate { get; }
}