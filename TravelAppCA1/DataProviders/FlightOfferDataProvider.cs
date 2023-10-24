using RestSharp;
using System.Net;
using System.Text.Json;

namespace TravelAppCA1
{
    public class FlightOfferDataProvider : DataProviderBase
    {
        public FlightOfferDataProvider(string baseUrl, string apiKey) : base(baseUrl, apiKey) { }
        public static string GetTravelClassString(TravelClassEnum travelClass)
        {
            return Enum.GetName(typeof(TravelClassEnum), travelClass);
        }

        public override FlightData[] GetFlightOffers(bool isMock, string originLocationCode, string destinationLocationCode,
        DateTime departureDate, int numAdults, int numChildren, TravelClassEnum travelClass, string currencyCode, bool nonStop)
        {
            if (isMock)
            {
                string json;
                using (StreamReader r = new StreamReader("C:\\Users\\luanakimley\\source\\repos\\TravelAppCA1\\TravelAppCA1\\TestData\\FlightOfferMockData.json"))
                {
                    json = r.ReadToEnd();
                }
                
                FlightOfferRootobject mockFlightOfferRootobject = JsonSerializer.Deserialize<FlightOfferRootobject>(json);
                
                return mockFlightOfferRootobject.data;
            }

            try
            {
                var restClient = new RestClient(baseUrl);
                var restRequest = new RestRequest();

                restRequest.AddParameter("originLocationCode", originLocationCode);
                restRequest.AddParameter("destinationLocationCode", destinationLocationCode);
                restRequest.AddParameter("departureDate", departureDate.ToString("yyyy-MM-dd"));
                restRequest.AddParameter("adults", numAdults);
                restRequest.AddParameter("children", numChildren);
                restRequest.AddParameter("travelClass", GetTravelClassString(travelClass));
                restRequest.AddParameter("currencyCode", currencyCode);
                restRequest.AddParameter("nonStop", nonStop.ToString().ToLower());

                restRequest.AddHeader("Authorization", "Bearer " + apiKey);
                var apiResponse = restClient.Execute(restRequest);

                if (apiResponse.StatusCode == HttpStatusCode.OK)
                {
                    FlightOfferRootobject flightOfferRootobject = JsonSerializer.Deserialize<FlightOfferRootobject>(apiResponse.Content);
                    return flightOfferRootobject.data;
                }
                else
                {
                    MessageBox.Show("API request failed. Status code: " + apiResponse.Content);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }

        }

    }
}
