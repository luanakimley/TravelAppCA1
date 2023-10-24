using RestSharp;
using System.Net;
using System.Text.Json;

namespace TravelAppCA1
{ 
    public class AirportDataProvider : DataProviderBase
    {
        public AirportDataProvider(string baseUrl, string apiKey) : base(baseUrl, apiKey) { }

        public override Airport[] GetAirportList(bool isMock)
        {
            if (isMock)
            {
                string json;
                using (StreamReader r = new StreamReader("C:\\Users\\luanakimley\\source\\repos\\TravelAppCA1\\TravelAppCA1\\TestData\\AirportMockData.json"))
                {
                    json = r.ReadToEnd();
                }

                AirportRootobject mockAirportRootobject = JsonSerializer.Deserialize<AirportRootobject>(json);

                return mockAirportRootobject.response;
            }

            try
            {
                string airportDatabaseUrl = baseUrl;
                var apiClient = new RestClient(airportDatabaseUrl);
                var apiRequest = new RestRequest();

                apiRequest.AddParameter("api_key", apiKey);
                apiRequest.AddParameter("_fields", "name,iata_code,lat,lng");

                var apiResponse = apiClient.Execute(apiRequest);

                if (apiResponse.StatusCode == HttpStatusCode.OK)
                {
                    AirportRootobject airportRootobject = JsonSerializer.Deserialize<AirportRootobject>(apiResponse.Content);
                    return airportRootobject.response;
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
