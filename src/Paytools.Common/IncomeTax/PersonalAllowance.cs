namespace Paytools.Common;

public class PersonalAllowance : IPersonalAllowance
{
    public PayFrequency PayFrequency { get; set; }
    public decimal Value { get; set; }
}
