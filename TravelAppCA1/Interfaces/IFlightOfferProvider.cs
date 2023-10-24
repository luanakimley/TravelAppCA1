using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAppCA1
{
    public interface IFlightOfferProvider
    {
        FlightData[] GetFlightOffers(bool isMock, string originLocationCode, string destinationLocationCode,
        DateTime departureDate, int numAdults, int numChildren, TravelClassEnum travelClass, string currencyCode, bool nonStop);
    }
}
