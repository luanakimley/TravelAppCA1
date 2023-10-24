using RestSharp;
using TravelAppCA1;

public abstract class OAuthTokenProviderBase : IFlightOfferOAuthTokenProvider
{
    protected RestClient restClient;
    protected RestRequest restRequest;
    protected string clientId;
    protected string clientSecret;

    public OAuthTokenProviderBase(string baseUrl, string requestParams, string clientIdVal, string clientSecretVal)
    {
        restClient = new RestClient(baseUrl);
        restRequest = new RestRequest(requestParams, Method.Post);
        clientId = clientIdVal;
        clientSecret = clientSecretVal;
    }
    public abstract OAuthResults GetOAuthToken();
}