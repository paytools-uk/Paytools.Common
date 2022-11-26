namespace Paytools.Common;

public readonly struct PayDate
{
	public DateOnly Date { get; init; }
	public PayFrequency PayFrequency { get; init; }
	public TaxYear TaxYear { get; init; }
	public int TaxPeriodCount {get;init; }

	public PayDate(DateOnly date, PayFrequency payFrequency)
	{
		Date = date;
		PayFrequency = payFrequency;
		TaxYear = new TaxYear(date);
		TaxPeriodCount = TaxYear.GetTaxPeriodCount(payFrequency);
	}
}