namespace TravelAppCA1
{
    public interface IAirportDataProvider
    {
        Airport[] GetAirportList(bool isMock);
    }
}
