namespace Paytools.Common;

public class InvalidReferenceDataException : Exception
{
    public InvalidReferenceDataException(string message)
        : base(message) { }
}
