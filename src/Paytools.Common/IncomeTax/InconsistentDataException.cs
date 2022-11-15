namespace Paytools.Common;

public class InconsistentDataException : Exception
{
    public InconsistentDataException(string message)
        : base(message) { }
}
