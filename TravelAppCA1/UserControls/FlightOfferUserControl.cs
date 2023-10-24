using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAppCA1
{
    public partial class FlightOfferUserControl : UserControl
    {
        public FlightData flightData;

        public FlightOfferUserControl()
        {
            InitializeComponent();
            flightData = new();
        }
    }
}
