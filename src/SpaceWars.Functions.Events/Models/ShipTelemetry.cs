using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars.Functions.Events.Models
{
    public class ShipTelemetry
    {
        public string ShipDesignation { get; set; }

        public string ShipClass { get; set; }

        public string Sensor { get; set; }

        public int SensorValue { get; set; }
    }
}
