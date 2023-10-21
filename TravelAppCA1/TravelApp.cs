using RestSharp;
using RestSharp.Serializers;
using System.Net;
using System.Text.Json;

namespace TravelAppCA1
{
    public partial class TravelApp : Form
    {
        public TravelApp()
        {
            InitializeComponent();
        }

        private void GetFlightOffers()
        {
            var amadeusTokenBaseUrl = "https://test.api.amadeus.com/v1/security/oauth2/token";
            var tokenClient = new RestClient(amadeusTokenBaseUrl);
            var tokenRequest = new RestRequest("v1/security/oauth2/token", Method.Post);
            tokenRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            string clientId = "Z7sKsYe9scrsXCPR6AiASJ2CSVzHeAYz";
            string clientSecret = "t9WpDY3qBakNkkUV";

            tokenRequest.AddParameter("grant_type", "client_credentials");
            tokenRequest.AddParameter("client_id", clientId);
            tokenRequest.AddParameter("client_secret", clientSecret);

            var tokenResponse = tokenClient.Execute(tokenRequest);

            OAuthResults oauthResult = JsonSerializer.Deserialize<OAuthResults>(tokenResponse.Content);

            var amadeusApiBaseUrl = "https://test.api.amadeus.com/v2/shopping/flight-offers";
            var apiClient = new RestClient(amadeusApiBaseUrl);
            var apiRequest = new RestRequest();

            apiRequest.AddParameter("originLocationCode", "CGK");
            apiRequest.AddParameter("destinationLocationCode", "DUB");
            apiRequest.AddParameter("departureDate", "2023-12-02");
            apiRequest.AddParameter("adults", 1);
            apiRequest.AddParameter("max", 1);

            if (oauthResult != null)
            {
                apiRequest.AddHeader("Authorization", "Bearer " + oauthResult.access_token);
                var apiResponse = apiClient.Execute(apiRequest);
                MessageBox.Show(apiResponse.Content);
            }
        }

        private Airport[] GetAirportList()
        {
            string airportDatabaseUrl = "https://airlabs.co/api/v9/airports";
            var apiClient = new RestClient(airportDatabaseUrl);
            var apiRequest = new RestRequest();
            var apiKey = "ae366993-c2b1-4ea7-b072-8bd750bee12b";

            apiRequest.AddParameter("api_key", apiKey);
            apiRequest.AddParameter("_fields", "name,iata_code,city");

            var apiResponse = apiClient.Execute(apiRequest);

            AirportRootobject airportRootobject = JsonSerializer.Deserialize<AirportRootobject>(apiResponse.Content);

            if (airportRootobject != null && airportRootobject.response != null)
            {
                foreach (var airport in airportRootobject.response)
                {
                    if (airport.iata_code != null)
                    {
                        listBox1.Items.Add(airport.iata_code);
                    }
                }

                return airportRootobject.response;
            }

            return new Airport[1];
        }

        private void InitialiseAirportsComboBox(ComboBox comboBox, Airport[] airports)
        {
            foreach (var airport in airports)
            {
                if (airport.iata_code != null && airport.name != null)
                {
                    string comboBoxText = $"{airport.iata_code} - {airport.name}";
                    comboBox.Items.Add(comboBoxText);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Airport[] airports = GetAirportList();
            InitialiseAirportsComboBox(originComboBox, airports);
            InitialiseAirportsComboBox(destinationComboBox, airports);
        }
    }
}