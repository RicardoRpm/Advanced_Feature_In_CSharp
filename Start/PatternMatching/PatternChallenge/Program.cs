

SecuritiesTrade[] tradeList = new SecuritiesTrade[]
{
    new StockTrade() {Symbol = "WXYZ", Quantity = 1200, Price = 27.81},
    new BondTrade() {Symbol = "ABCD", Quantity = 1200, Price = 27.81},
};

foreach (var tradeItem in tradeList)
{
    try
    {
        CommisionCalculator.PrintTradeCommision(tradeItem);
    }
    catch (System.Exception)
    {
        Console.WriteLine($"{e.Message}");
    }
}

