using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class PowerSource
    {

        int type;
        public Battery battery;
        float ressistance; 
        /// <summary>
        /// 1 - Solar Panel 
        /// 2 - Generator 
        /// 3 - WindMill
        /// 4 - BatBox 
        /// </summary>
        /// <param name="_type"></param>
        public PowerSource(int _type)
        {
            type = _type;
            switch (type)
            {
                case 1:
                    {
                        // Solar Panel
                        battery = new Battery(5000);
                        ressistance = .8f; 
                        break;
                    }
                case 4:
                    {
                        // Battery Box
                        battery = new Battery(5000);
                        ressistance = .9f;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Type not accepted");
                        battery = new Battery(250);
                        ressistance = .8f;
                        break;
                    }
            } 
        }

        /// <summary>
        /// Sunny day = 1000
        /// Cloudy day = 500 
        /// Rainy day = 250
        /// </summary>
        /// <param name="lightLevel"></param>
        public void UpdateSolarPanel(float lightLevel)
        {
            if(type == 0)
            {
                battery.AddWatts(lightLevel * .25f);
            }
            else
            {

                Console.WriteLine("Wrong Power Type: power type "  + type);
            }
        }



    }
}
