using RestSharp;
using System.Text.Json;

namespace TravelAppCA1
{
    public class OAuthTokenDataProvider : OAuthTokenProviderBase
    {
        public OAuthTokenDataProvider(string baseUrl, string requestParams, string clientId, string clientSecret) : base(baseUrl, requestParams, clientId, clientSecret) { }

        public override OAuthResults GetOAuthToken()
        {
            restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            string clientId = this.clientId;
            string clientSecret = this.clientSecret;

            restRequest.AddParameter("grant_type", "client_credentials");
            restRequest.AddParameter("client_id", clientId);
            restRequest.AddParameter("client_secret", clientSecret);

            var tokenResponse = restClient.Execute(restRequest);

            OAuthResults oauthResult = JsonSerializer.Deserialize<OAuthResults>(tokenResponse.Content);

            return oauthResult;
        }
    }
}
