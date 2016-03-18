using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public static class Electricity
    {
        // 1 watt = 1 joule / second 
        // energy = power x time 
        // Power(in watts) = Jouls/Second
        // A typical solar panal cell can convert 15% of the sun to electricity. That is about 150 watts

        public static float Watts(float joules)
        {
            return joules / 1;
        }
        /// <summary>
        /// choose number between 1 - 0
        /// 1 being the lowest resistance 
        /// 0 being a dead wire
        /// </summary>
        /// <param name="ressistance"></param>
        /// <param name="Watts"></param>
        /// <returns></returns>
        public static float Ressistance(float ressistance, float Watts)
        {
            return ressistance * Watts;              
        }
    }
}
