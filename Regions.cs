using System;
using System.Collections.Generic;
using System.Text;

namespace Echo_Arena_Private_Match_Creator
{
    class Regions
    {
        public string Region(int reg)
        {
            string region = "null";
            string[] regions = { "usw", "usc", "uscn", "use", "euw", "jp", "aus", "sin" };

            switch (reg)
            {
                case 1:
                    region = regions[0]; //US West
                    break;
                case 2:
                    region = regions[1]; //US Central
                    break;
                case 3:
                    region = regions[2]; //US Central North
                    break;
                case 4:
                    region = regions[3]; //US East
                    break;
                case 5:
                    region = regions[4]; //EU
                    break;
                case 6:
                    region = regions[5]; //Japan
                    break;
                case 7:
                    region = regions[6]; //Australia
                    break;
                case 8:
                    region = regions[7]; //Singapore
                    break;
                default:
                    region = "null";
                    break;
            }

            return region;
        }
    }
}
