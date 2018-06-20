using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars.Functions.Events.Models
{
    public class MaintenanceCheckRequest
    {
        public string ShipDesignation { get; set; }

        public string ShipClass { get; set; }

        public int Priority { get; set; }
    }
}
