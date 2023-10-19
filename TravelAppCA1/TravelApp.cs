using RestSharp;
using RestSharp.Serializers;
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
            var tokenRequest = new RestRequest();
            tokenRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            string clientId = "your_client_id";
            string clientSecret = "your_client_secret";

            tokenRequest.AddParameter("grant_type", "client_credentials");
            tokenRequest.AddParameter("client_id", clientId);
            tokenRequest.AddParameter("client_secret", clientSecret);

            var tokenResponse = tokenClient.Execute(tokenRequest);

            if (tokenResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var accessToken = tokenResponse.Content;

                // Step 2: Make the API request with the obtained access token
                var amadeusApiBaseUrl = "https://test.api.amadeus.com/v1/shopping/flight-destinations";
                var apiClient = new RestClient(amadeusApiBaseUrl);
                var apiRequest = new RestRequest();

                // Add the required query parameters (origin and maxPrice)
                apiRequest.AddParameter("origin", "PAR"); // Replace with your origin
                apiRequest.AddParameter("maxPrice", "200"); // Replace with your desired max price

                // Add the Authorization header with the access token
                apiRequest.AddHeader("Authorization", "Bearer " + accessToken);

                var apiResponse = apiClient.Execute(apiRequest);
                label1.Text = apiResponse.Content;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            GetFlightOffers();
        }
    }
}