using RestSharp;
using System.ComponentModel;
using System.Text.Json;
using System.Xml;

namespace TravelAppCA1
{
    public partial class TravelApp : Form
    {
        public TravelApp()
        {
            InitializeComponent();

            Airport[] airports = GetAirportList();
            InitialiseAirportsComboBox(originComboBox, airports);
            InitialiseAirportsComboBox(destinationComboBox, airports);
            GetCurrenciesList();
            /*originComboBox.Items.Add("CGK - T");
            originComboBox.Items.Add("DUB - T");
            destinationComboBox.Items.Add("TPE - T");
            destinationComboBox.Items.Add("DPS - T");*/
        }

        private FlightData[] GetFlightOffers(string originLocationCode, string destinationLocationCode, 
            DateTime departureDate, int numAdults, int numChildren, TravelClassEnum travelClass, string currencyCode)
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

            apiRequest.AddParameter("originLocationCode", originLocationCode);
            apiRequest.AddParameter("destinationLocationCode", destinationLocationCode);
            apiRequest.AddParameter("departureDate", departureDate.ToString("yyyy-MM-dd"));
            apiRequest.AddParameter("adults", numAdults);
            apiRequest.AddParameter("children", numChildren);
            apiRequest.AddParameter("travelClass", GetTravelClassString(travelClass));
            apiRequest.AddParameter("currencyCode", currencyCode);

            if (oauthResult != null)
            {
                apiRequest.AddHeader("Authorization", "Bearer " + oauthResult.access_token);
                var apiResponse = apiClient.Execute(apiRequest);

                string json;
                using (StreamReader r = new StreamReader("C:\\Users\\luanakimley\\source\\repos\\TravelAppCA1\\TravelAppCA1\\data.json"))
                {
                    json = r.ReadToEnd();
                }

               // FlightOfferRootobject flightOfferRootobject = JsonSerializer.Deserialize<FlightOfferRootobject>(json);

                FlightOfferRootobject flightOfferRootobject = JsonSerializer.Deserialize<FlightOfferRootobject>(apiResponse.Content);

                if (flightOfferRootobject != null)
                {
                    return flightOfferRootobject.data;
                }
            }

            return new FlightData[1];
        }

        public static string GetTravelClassString(TravelClassEnum travelClass)
        {
            return Enum.GetName(typeof(TravelClassEnum), travelClass);
        }

        public static string GetDescription(TravelClassEnum travelClass)
        {
            var fieldInfo = travelClass.GetType().GetField(travelClass.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : travelClass.ToString();
        }

        private Airport[] GetAirportList()
        {
            string airportDatabaseUrl = "https://airlabs.co/api/v9/airports";
            var apiClient = new RestClient(airportDatabaseUrl);
            var apiRequest = new RestRequest();
            var apiKey = "ae366993-c2b1-4ea7-b072-8bd750bee12b";

            apiRequest.AddParameter("api_key", apiKey);
            apiRequest.AddParameter("_fields", "name,iata_code,lat,lng");

            var apiResponse = apiClient.Execute(apiRequest);

            AirportRootobject airportRootobject = JsonSerializer.Deserialize<AirportRootobject>(apiResponse.Content);

            if (airportRootobject != null && airportRootobject.response != null)
            {
                return airportRootobject.response;
            }

            return new Airport[1];
        }

        private void GetCurrenciesList()
        {
            string currenciesListUrl = "https://openexchangerates.org/api/currencies.json";
            var apiClient = new RestClient(currenciesListUrl);
            var apiRequest = new RestRequest();
            var appId = "d3eaffb2607c4cd4923cec1d5c94d497";

            apiRequest.AddParameter("app_id", appId);

            var apiResponse = apiClient.Execute(apiRequest);

            Dictionary<string, string> currencyDict = JsonSerializer.Deserialize<Dictionary<string, string>>(apiResponse.Content);

            var result = new
            {
                currencies = currencyDict.Select(kv => new { name = kv.Value, code = kv.Key }).ToList()
            };

            string resultJson = JsonSerializer.Serialize(result);

            CurrencyData currencyData = JsonSerializer.Deserialize<CurrencyData>(resultJson);

            foreach (var currency in currencyData.currencies)
            {
                currencyComboBox.Items.Add($"{currency.code} - {currency.name}");
            }
            currencyComboBox.SelectedItem = "EUR - Euro";
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

        public TimeSpan ParseDuration(string durationString)
        {
            return XmlConvert.ToTimeSpan(durationString);
        }

        private TravelClassEnum GetSelectedTravelClass()
        {
            if (economyRadioButton.Checked)
            {
                return TravelClassEnum.ECONOMY;
            }
            else if (premiumEconomyRadioButton.Checked)
            {
                return TravelClassEnum.PREMIUM_ECONOMY;
            }
            else if (businessRadioButton.Checked)
            {
                return TravelClassEnum.BUSINESS;
            }
            return TravelClassEnum.FIRST;
        }

        private void searchFlightButton_Click(object sender, EventArgs e)
        {
            flightsFlowLayoutPanel.Controls.Clear();
            if (originComboBox.SelectedItem != null && destinationComboBox.SelectedItem != null && currencyComboBox.SelectedItem != null)
            {
                string originAirport = originComboBox.SelectedItem.ToString().Split("-")[0].Trim();
                //string originAirport = "CGK";
                string destinationAirport = destinationComboBox.SelectedItem.ToString().Split("-")[0].Trim();
                //string destinationAirport = "DUB";

                DateTime departureDate = departureDatePicker.Value.Date;
                int numAdults = (int)numAdultsForm.Value;
                int numChildren = (int)numChildrenForm.Value;
                TravelClassEnum travelClass = GetSelectedTravelClass();
                string currencyCode = currencyComboBox.SelectedItem.ToString().Split("-")[0].Trim();

                FlightData[] flights = GetFlightOffers(originAirport, destinationAirport, departureDate, numAdults, numChildren, travelClass, currencyCode);

                if (flights != null)
                {
                    foreach (var flight in flights)
                    {
                        FlightOfferUserControl flightOfferUserControl = new();

                        DateTime departureTimeDate = flight.itineraries[0].segments[0].departure.at;
                        DateTime arrivalTimeDate = flight.itineraries[0].segments[flight.itineraries[0].segments.Length - 1].arrival.at;
                        TimeSpan totalDuration = ParseDuration(flight.itineraries[0].duration);

                        flightOfferUserControl.flightData = flight;
                        flightOfferUserControl.originAirport.Text = originAirport;
                        flightOfferUserControl.destinationAirport.Text = destinationAirport;
                        flightOfferUserControl.numStops.Text = (flight.itineraries[0].segments.Length - 1).ToString() + " stops";
                        flightOfferUserControl.flightDuration.Text = $"{(int)totalDuration.TotalHours}h {totalDuration.Minutes}m";
                        flightOfferUserControl.departureTime.Text = departureTimeDate.ToString("HH:mm");
                        flightOfferUserControl.arrivalTime.Text = arrivalTimeDate.ToString("HH:mm");
                        flightOfferUserControl.currencyLabel.Text = flight.price.currency;
                        decimal grandTotal = decimal.Parse(flight.price.grandTotal);
                        if (grandTotal > 99999)
                        {
                            // If grandTotal is greater than 99,999, format it as "X,XXXk"
                            flightOfferUserControl.flightPrice.Text = String.Format("{0:#,###}k", grandTotal / 1000);
                        }
                        else
                        {
                            // If grandTotal is less than or equal to 99,999, format it normally
                            flightOfferUserControl.flightPrice.Text = grandTotal.ToString("N0");
                        }
                        flightOfferUserControl.travelClassLabel.Text = GetDescription(travelClass);
                        flightOfferUserControl.flightDetailsButton.Tag = flightOfferUserControl;
                        flightOfferUserControl.flightDetailsButton.Click += new System.EventHandler(flightDetailsButton_Click);

                        flightsFlowLayoutPanel.Controls.Add(flightOfferUserControl);
                    }
                }
            }
        }

        private void flightDetailsButton_Click(object sender, EventArgs e)
        {
            flightsFlowLayoutPanel.Visible = false;
            flightDetailsPanel.Visible = true;

            FlightDetailsUserControl flightDetailsUserControl = new();
            flightDetailsUserControl.backToFlightsButton.Click += new System.EventHandler(backToFlightSearchButton_Click);
            flightDetailsUserControl.travelClassValue.Text = GetDescription(GetSelectedTravelClass());
            flightDetailsUserControl.numAdultsValue.Text = numAdultsForm.Value.ToString();
            flightDetailsUserControl.numChildrenValue.Text = numChildrenForm.Value.ToString();
            flightDetailsUserControl.currencyType.Text = $"({currencyComboBox.SelectedItem.ToString().Split("-")[0].Trim()})";

            if (((Button)sender).Tag is FlightOfferUserControl flightOfferUserControl)
            {
                 
                var flight = flightOfferUserControl.flightData;
                 
                flightDetailsUserControl.priceValue.Text = flight.price.grandTotal;

                foreach (Segment segment in flight.itineraries[0].segments)
                {
                    FlightSegmentUserControl flightSegmentUserControl = new();
                    
                    flightSegmentUserControl.departureTime.Text = segment.departure.at.ToString("HH:mm");
                    flightSegmentUserControl.arrivalTime.Text = segment.arrival.at.ToString("HH:mm");
                    
                    flightSegmentUserControl.originAirport.Text = segment.departure.iataCode;
                    flightSegmentUserControl.destinationAirport.Text = segment.arrival.iataCode;
                    
                    flightSegmentUserControl.originTerminal.Text = $"Terminal {segment.departure.terminal}";
                    flightSegmentUserControl.destinationTerminal.Text = $"Terminal {segment.arrival.terminal}";
                    
                    flightSegmentUserControl.airlineNumber.Text = $"{segment.carrierCode}{segment.number}";

                    TimeSpan totalDuration = ParseDuration(segment.duration);
                    flightSegmentUserControl.flightDuration.Text = $"{(int)totalDuration.TotalHours}h {totalDuration.Minutes}m";

                    flightDetailsUserControl.flightSegmentsflowLayoutPanel.Controls.Add(flightSegmentUserControl);
                }
            }

            flightDetailsPanel.Controls.Add(flightDetailsUserControl);
        }

        private void backToFlightSearchButton_Click(object sender, EventArgs e)
        {
            flightsFlowLayoutPanel.Visible = true;
            flightDetailsPanel.Visible = false;
            flightDetailsPanel.Controls.Clear();

        }
    }
}