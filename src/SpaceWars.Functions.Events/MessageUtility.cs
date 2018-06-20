using SpaceWars.Functions.Events.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWars.Functions.Events
{
    public class MessageUtility
    {
        public static string GetShipAscii(string shipClass)
        {
            switch (shipClass)
            {
                case "Tie Fighter":
                    return SpaceWarsResources.Tie;

                case "Tie Advanced":
                    return SpaceWarsResources.TieAdvanced;

                case "Tie Interceptor":
                    return SpaceWarsResources.TieInterceptor;

                case "Tie Bomber":
                    return SpaceWarsResources.TieBomber;

                case "Tie Defender":
                    return SpaceWarsResources.TieDefender;

                case "Imperial Lamda Transport":
                    return SpaceWarsResources.Lamda;

                default:
                    return SpaceWarsResources.Tie;

            }

        }
    }
}
