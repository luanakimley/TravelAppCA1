using RestSharp;
using System.Text.Json;

namespace TravelAppCA1
{
    public class CurrencyDataProvider : DataProviderBase
    {
        public CurrencyDataProvider(string baseUrl, string apiKey) : base(baseUrl, apiKey) { }

        public override List<Currency> GetCurrenciesList(bool isMock)
        {
            if (isMock)
            {
                string json;
                using (StreamReader r = new StreamReader("C:\\Users\\luanakimley\\source\\repos\\TravelAppCA1\\TravelAppCA1\\TestData\\CurrencyMockData.json"))
                {
                    json = r.ReadToEnd();
                }

                CurrencyData mockCurrencyData = JsonSerializer.Deserialize<CurrencyData>(json);

                return mockCurrencyData.currencies;
            }

            string currenciesListUrl = "https://openexchangerates.org/api/currencies.json";
            var apiClient = new RestClient(currenciesListUrl);
            var apiRequest = new RestRequest();
            var appId = "d3eaffb2607c4cd4923cec1d5c94d497";

            apiRequest.AddParameter("app_id", appId);

            var apiResponse = apiClient.Execute(apiRequest);

            Dictionary<string, string> currencyDict = JsonSerializer.Deserialize<Dictionary<string, string>>(apiResponse.Content);

            var result = new
            {
                currencies = currencyDict.Select(c => new { name = c.Value, code = c.Key }).ToList()
            };

            string resultJson = JsonSerializer.Serialize(result);

            CurrencyData currencyData = JsonSerializer.Deserialize<CurrencyData>(resultJson);

            return currencyData.currencies;
        }
    }
}
