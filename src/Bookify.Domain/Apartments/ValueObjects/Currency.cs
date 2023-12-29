namespace Bookify.Domain.Apartments.ValueObjects;

public record Currency
{
    internal static readonly Currency None = new("");

    private static readonly Currency Usd = new("USD");

    private static readonly Currency Eur = new("EUR");

    private Currency(string code) => Code = code;

    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code.Equals(code)) ?? 
               throw new ApplicationException("The currency code is invalid.");
    }

    private static readonly IReadOnlyCollection<Currency> All = new[] { Usd, Eur };
}