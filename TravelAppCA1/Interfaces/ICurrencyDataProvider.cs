namespace TravelAppCA1
{
    public interface ICurrencyDataProvider
    {
        List<Currency> GetCurrenciesList(bool isMock);
    }
}
