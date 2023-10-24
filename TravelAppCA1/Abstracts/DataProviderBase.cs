using RestSharp;

namespace TravelAppCA1
{
    public abstract class DataProviderBase : IFlightOfferProvider, IAirportDataProvider, ICurrencyDataProvider
    {
        protected string baseUrl;
        protected string apiKey;

        public DataProviderBase(string baseUrlVal, string apiKeyVal)
        {
            baseUrl = baseUrlVal;
            apiKey = apiKeyVal;
        }

        public virtual FlightData[] GetFlightOffers(bool isMock, string originLocationCode, string destinationLocationCode,
            DateTime departureDate, int numAdults, int numChildren, TravelClassEnum travelClass, string currencyCode, bool nonStop)
        { return new FlightData[1]; }

        public virtual Airport[] GetAirportList(bool isMock)
        { return new Airport[1]; }

        public virtual List<Currency> GetCurrenciesList(bool isMock)
        { return new List<Currency>();  }

    }
}
