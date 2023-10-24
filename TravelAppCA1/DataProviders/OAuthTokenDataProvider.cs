using RestSharp;
using System.Net;
using System.Text.Json;

namespace TravelAppCA1
{
    public class OAuthTokenDataProvider : OAuthTokenProviderBase
    {
        public OAuthTokenDataProvider(string baseUrl, string requestParams, string clientId, string clientSecret) : base(baseUrl, requestParams, clientId, clientSecret) { }

        public override OAuthResults GetOAuthToken()
        {
            try
            {
                restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");

                string clientId = this.clientId;
                string clientSecret = this.clientSecret;

                restRequest.AddParameter("grant_type", "client_credentials");
                restRequest.AddParameter("client_id", clientId);
                restRequest.AddParameter("client_secret", clientSecret);

                var tokenResponse = restClient.Execute(restRequest);

                if (tokenResponse.StatusCode == HttpStatusCode.OK)
                {
                    OAuthResults oauthResult = JsonSerializer.Deserialize<OAuthResults>(tokenResponse.Content);
                    return oauthResult;
                }
                else
                {
                    MessageBox.Show("API request failed. Status code: " + tokenResponse.Content);
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
