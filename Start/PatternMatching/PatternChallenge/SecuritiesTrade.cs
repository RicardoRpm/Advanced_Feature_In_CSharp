
public class SecuritiesTrade
{
    public int Quantity;
    public decimal Price;
}

public class StockTrade : SecurityTrade
{
    public string? Symbol;
}

public class BondTrade : SecurityTrade
{
    public string? Name;
    public int Duration;
}
