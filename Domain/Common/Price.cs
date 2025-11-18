namespace Domain.Common;

public record Price
{
    public float Amount;
    public string Currency;

    private Price(float amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Price Create(float amount, string currency)
    {
        return new Price(amount, currency);
    }
}