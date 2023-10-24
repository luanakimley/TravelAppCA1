using System.ComponentModel;
using System.Xml;
using TravelAppCA1.UserControls;

namespace TravelAppCA1
{
    public partial class TravelApp : Form
    {
        private IFlightOfferOAuthTokenProvider oauthTokenProvider;
        private IFlightOfferProvider flightOfferProvider;
        private IAirportDataProvider airportDataProvider;
        private ICurrencyDataProvider currencyDataProvider;


        public TravelApp()
        {
            InitializeComponent();

            InitialiseDataProviders();

            InitialiseControls();
        }

        private void InitialiseDataProviders()
        {
            oauthTokenProvider = new OAuthTokenDataProvider("https://test.api.amadeus.com/v1/security/oauth2/token",
                                                            "v1/security/oauth2/token", "Z7sKsYe9scrsXCPR6AiASJ2CSVzHeAYz", "t9WpDY3qBakNkkUV");
            flightOfferProvider = new FlightOfferDataProvider("https://test.api.amadeus.com/v2/shopping/flight-offers",
                                                              oauthTokenProvider.GetOAuthToken().access_token);
            airportDataProvider = new AirportDataProvider("https://airlabs.co/api/v9/airports", "ae366993-c2b1-4ea7-b072-8bd750bee12b");
            currencyDataProvider = new CurrencyDataProvider("https://openexchangerates.org/api/currencies.json", "d3eaffb2607c4cd4923cec1d5c94d497");
        }

        private void InitialiseControls()
        {
            Airport[] airports = airportDataProvider.GetAirportList(true);
            InitialiseAirportsComboBox(originComboBox, airports);
            InitialiseAirportsComboBox(destinationComboBox, airports);
            InitialiseCurrenciesComboBox(currencyComboBox, currencyDataProvider.GetCurrenciesList(true));
            InitialiseDatePickerMinValue();
        }

        private void InitialiseDatePickerMinValue()
        {
            DateTime dayAfterToday = DateTime.Today.AddDays(1);

            departureDatePicker.MinDate = dayAfterToday;
        }

        public static string GetDescription(TravelClassEnum travelClass)
        {
            var fieldInfo = travelClass.GetType().GetField(travelClass.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : travelClass.ToString();
        }

        private void InitialiseCurrenciesComboBox(ComboBox comboBox, List<Currency> currencies)
        {
            foreach (var currency in currencies)
            {
                comboBox.Items.Add($"{currency.code} - {currency.name}");
            }
            comboBox.SelectedItem = "EUR - Euro";
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

        private string GetCodeFromSelectedItem(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                return comboBox.SelectedItem.ToString().Split("-")[0].Trim();
            }

            return "";
        }

        private string GetFormattedPrice(decimal grandTotal)
        {
            if (grandTotal > 99999)
            {
                return String.Format("{0:#,###}k", grandTotal / 1000);
            }
            return grandTotal.ToString("N0");
        }

        private void searchFlightButton_Click(object sender, EventArgs e)
        {
            flightsFlowLayoutPanel.Controls.Clear();
            if (ValidateSearchForm())
            {
                string originAirport = GetCodeFromSelectedItem(originComboBox);
                string destinationAirport = GetCodeFromSelectedItem(destinationComboBox);

                DateTime departureDate = departureDatePicker.Value.Date;
                int numAdults = (int)numAdultsForm.Value;
                int numChildren = (int)numChildrenForm.Value;
                TravelClassEnum travelClass = GetSelectedTravelClass();
                string currencyCode = GetCodeFromSelectedItem(currencyComboBox);
                bool nonStop = nonStopCheckBox.Checked;

                FlightData[] flights = flightOfferProvider.GetFlightOffers(true, originAirport, destinationAirport,
                    departureDate, numAdults, numChildren, travelClass, currencyCode, nonStop);

                DisplayFlightOffers(flights, originAirport, destinationAirport, travelClass);
            }
        }

        private void DisplayFlightOffers(FlightData[] flights, string originAirport, string destinationAirport, TravelClassEnum travelClass)
        {
            if (flights != null)
            {
                if (flights.Length == 0)
                {
                    flightsFlowLayoutPanel.Controls.Add(new NoFlightsUserControl());
                }
                else
                {
                    foreach (var flight in flights)
                    {
                        FlightOfferUserControl flightOfferUserControl = CreateFlightOfferUserControl(flight, originAirport, destinationAirport, travelClass);

                        flightsFlowLayoutPanel.Controls.Add(flightOfferUserControl);
                    }
                }
            }
        }

        private FlightOfferUserControl CreateFlightOfferUserControl(FlightData flight, string originAirport, string destinationAirport, TravelClassEnum travelClass)
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
            flightOfferUserControl.flightPrice.Text = GetFormattedPrice(decimal.Parse(flight.price.grandTotal));
            flightOfferUserControl.travelClassLabel.Text = GetDescription(travelClass);
            flightOfferUserControl.flightDetailsButton.Tag = flightOfferUserControl;
            flightOfferUserControl.flightDetailsButton.Click += new System.EventHandler(flightDetailsButton_Click);

            return flightOfferUserControl;
        }


        private void flightDetailsButton_Click(object sender, EventArgs e)
        {
            HideFlightSearchAndShowDetailsPanel();

            FlightDetailsUserControl flightDetailsUserControl = CreateFlightDetailsUserControl((Button)sender);

            flightDetailsPanel.Controls.Add(flightDetailsUserControl);
        }

        private void HideFlightSearchAndShowDetailsPanel()
        {
            flightsFlowLayoutPanel.Visible = false;
            flightDetailsPanel.Visible = true;
            searchFlightButton.Enabled = false;
        }

        private FlightDetailsUserControl CreateFlightDetailsUserControl(Button senderButton)
        {
            FlightDetailsUserControl flightDetailsUserControl = new();

            flightDetailsUserControl.backToFlightsButton.Click += new System.EventHandler(backToFlightSearchButton_Click);
            flightDetailsUserControl.travelClassValue.Text = GetDescription(GetSelectedTravelClass());
            flightDetailsUserControl.numAdultsValue.Text = numAdultsForm.Value.ToString();
            flightDetailsUserControl.numChildrenValue.Text = numChildrenForm.Value.ToString();
            flightDetailsUserControl.currencyType.Text = $"({GetCodeFromSelectedItem(currencyComboBox)})";

            if (senderButton.Tag is FlightOfferUserControl flightOfferUserControl)
            {
                var flight = flightOfferUserControl.flightData;

                DisplayFlightSegments(flightDetailsUserControl, flight);
            }

            return flightDetailsUserControl;
        }

        private void DisplayFlightSegments(FlightDetailsUserControl flightDetailsUserControl, FlightData flight)
        {
            flightDetailsUserControl.priceValue.Text = flight.price.grandTotal;

            foreach (Segment segment in flight.itineraries[0].segments)
            {
                FlightSegmentUserControl flightSegmentUserControl = CreateFlightSegmentUserControl(segment);

                flightDetailsUserControl.flightSegmentsflowLayoutPanel.Controls.Add(flightSegmentUserControl);
            }
        }

        private FlightSegmentUserControl CreateFlightSegmentUserControl(Segment segment)
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

            return flightSegmentUserControl;
        }

        private void backToFlightSearchButton_Click(object sender, EventArgs e)
        {
            flightsFlowLayoutPanel.Visible = true;
            flightDetailsPanel.Visible = false;
            flightDetailsPanel.Controls.Clear();

            searchFlightButton.Enabled = true;
        }

        private bool ValidateSearchForm()
        {
            if (originComboBox.SelectedItem == null)
            {
                ShowValidationError("You must select an origin airport,");
                return false;
            }
            else if (destinationComboBox.SelectedItem == null)
            {
                ShowValidationError("You must select a destination airport.");
                return false;
            }
            else if (originComboBox.SelectedItem.ToString() == destinationComboBox.SelectedItem.ToString())
            {
                ShowValidationError("Destination airport should not be the same as origin airport.");
                return false;
            }
            else if ((int)numAdultsForm.Value + (int)numChildrenForm.Value < 1)
            {
                ShowValidationError("Number of travellers must be at least 1.");
                return false;
            }
            else if ((int)numAdultsForm.Value + (int)numChildrenForm.Value > 9)
            {
                ShowValidationError("Number of travellers must be less than 9 in total.");
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message)
        {
            MessageBox.Show(message);
        }
    }
}