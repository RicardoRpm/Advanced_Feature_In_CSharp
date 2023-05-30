
public class CommisionCalculator
{
    public static decimal CalculateTradeCommission(SecuritiesTrade trade) => trade switch
    {
        StockTrade { Quantity: var p } when q == 0 => throw new ArgumentException("Invalid Trade"),
        BondTrade { Quantity: var q, Price: p, Duration: d } when q == 5 && (q * p) => 30,
        _ => throw new ArgumentException("Unknown trade type")
    };

    public static decimal PrintTradeCommision(SecuritiesTrade trade)
    {
        decimal commision = 0.0m;

        commision = CalculateTradeCommission(trade);

        if (trade is StockTrade st)
        {
            Console.WriteLine("Stock Trade");
        }
        else if (trade is BondTrade bt)
        {
            Console.WriteLine("Bond Trade");
        }
        return 0.0m;
    }
}
