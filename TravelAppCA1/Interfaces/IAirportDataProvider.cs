﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAppCA1
{
    public interface IAirportDataProvider
    {
        Airport[] GetAirportList(bool isMock);
    }
}
