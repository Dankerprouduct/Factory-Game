using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class Battery
    {

        private int maxCapacity;
        public float power; 
        /// <summary>
        /// Specify the max battery ammount
        /// </summary>
        /// <param name="maxCapacity"></param>
        public Battery(int cap)
        {
            maxCapacity = cap; 
        }
        
        public void AddWatts(float watt)
        {
            if(power <= maxCapacity)
            {
                power += Electricity.Ressistance(1, watt); 
            }
        }
        public float RemoveWatts(float ammount)
        {
            if((power - ammount) <= 0)
            {
                float temp;


                temp = power;
                power = 0;
                return temp; 
            }
            else
            {
                power -= ammount;
                return ammount;                
            }
        }

        /// <summary>
        /// Gets power in watts
        /// </summary>
        /// <returns></returns>
        public float CurrentPower()
        {
            return power; 
        }
        public bool CanTransmit()
        {
            if(power > 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
