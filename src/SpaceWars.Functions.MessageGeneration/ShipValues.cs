using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars.Functions.MessageGeneration
{
    public class Ship
    {
        public string ShipDesignation { get; set; }

        public string ShipType { get; set; }
    }

    public static class ShipValues
    {
        public static string[] sensorTypes = new string[4] { "TargetAccuracy",
                                                             "ShieldRechargeRate",
                                                             "EnergyGridRechargeLevel",
                                                             "PrimaryCapacitorLevel"};

        public static string[] shipTypes = new string[7] { "Tie Fighter",
                                                            "Tie Advanced",
                                                            "Tie Interceptor",
                                                            "Tie Bomber",
                                                            "Tie Defender",
                                                            "Imperal Lamda",
                                                            "Imperial Patrol Ship" };

        public static string[] repairTypes = new string[5] { "Drive",
                                                             "Weapons",
                                                             "Structure",
                                                             "Internal Systems",
                                                             "Shields"};

        public static List<Ship> FleetShips { get; set; }

        static ShipValues()
        {

            ShipValues.FleetShips = new List<Ship>();

            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF001", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF002", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF003", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF004", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF005", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF006", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF007", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF008", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF009", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF010", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF011", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF012", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF013", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF014", ShipType = "Tie Fighter" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TF015", ShipType = "Tie Fighter" });

            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TA001", ShipType = "Tie Advanced" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TA002", ShipType = "Tie Advanced" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TA003", ShipType = "Tie Advanced" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TA004", ShipType = "Tie Advanced" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TA005", ShipType = "Tie Advanced" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TA006", ShipType = "Tie Advanced" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TA007", ShipType = "Tie Advanced" });

            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TI001", ShipType = "Tie Interceptor" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TI002", ShipType = "Tie Interceptor" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TI003", ShipType = "Tie Interceptor" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TI004", ShipType = "Tie Interceptor" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TI005", ShipType = "Tie Interceptor" });

            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TB001", ShipType = "Tie Bomber" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TB002", ShipType = "Tie Bomber" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TB003", ShipType = "Tie Bomber" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TB004", ShipType = "Tie Bomber" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TB005", ShipType = "Tie Bomber" });

            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TD002", ShipType = "Tie Defender" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TD002", ShipType = "Tie Defender" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TD003", ShipType = "Tie Defender" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TD004", ShipType = "Tie Defender" });

            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TL003", ShipType = "Imperial Lamda Transport" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TL004", ShipType = "Imperial Lamda Transport" });
            ShipValues.FleetShips.Add(new Ship() { ShipDesignation = "TL005", ShipType = "Imperial Lamda Transport" });


        }


    }
}
