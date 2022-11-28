namespace Paytools.Common;

public static class Rounding
{
    private static readonly decimal[] _factors = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

    public static decimal RoundUp(decimal value, int places)
    {
        if (places < 0 || places > 6)
            throw new ArgumentOutOfRangeException(nameof(places), $"Rounding parameter must lie between 0 and 6");

        return Math.Ceiling(value * _factors[places]) / _factors[places];
    }
    public static decimal Truncate(decimal value, int places)
    {
        if (places < 0 || places > 6)
            throw new ArgumentOutOfRangeException(nameof(places), $"Rounding parameter must lie between 0 and 6");

        return Math.Floor(value * _factors[places]) / _factors[places];
    }
}
