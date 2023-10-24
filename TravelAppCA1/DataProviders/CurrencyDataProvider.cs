using RestSharp;
using System.Net;
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

            try
            {
                var apiClient = new RestClient(baseUrl);
                var apiRequest = new RestRequest();

                apiRequest.AddParameter("app_id", apiKey);

                var apiResponse = apiClient.Execute(apiRequest);

                if (apiResponse.StatusCode == HttpStatusCode.OK)
                {
                    Dictionary<string, string> currencyDict = JsonSerializer.Deserialize<Dictionary<string, string>>(apiResponse.Content);

                    var result = new
                    {
                        currencies = currencyDict.Select(c => new { name = c.Value, code = c.Key }).ToList()
                    };

                    string resultJson = JsonSerializer.Serialize(result);

                    CurrencyData currencyData = JsonSerializer.Deserialize<CurrencyData>(resultJson);

                    return currencyData.currencies;
                }
                else
                {
                    MessageBox.Show("API request failed. Status code: " + apiResponse.StatusCode);
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
