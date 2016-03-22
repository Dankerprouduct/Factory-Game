using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework; 

namespace Factory_Game
{
    public class Battery
    {

        private int maxCapacity;
        public float power;
        public bool output; 
        /// <summary>
        /// Specify the max battery ammount
        /// </summary>
        /// <param name="maxCapacity"></param>
        public Battery(int cap)
        {
            maxCapacity = cap; 
        }
        public void Output(bool io)
        {
            output = io; 
        }
        public void AddWatts(float watt)
        {
            if (!output)
            {
                if (power <= maxCapacity)
                {
                    power += Electricity.Ressistance(1, watt);
                }
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
        public void Update(Vector2 position, TileMap tileMap)
        {
            Vector2 pos = position;

            // Down
            pos = new Vector2(position.X, position.Y + 32);
            if(tileMap.GetTile(pos).isWire == true)
            {
                AddWatts(tileMap.GetTile(pos).current); 
            }

            // Up
            pos = new Vector2(position.X, position.Y - 32);
            if (tileMap.GetTile(pos).isWire)
            {
                AddWatts(tileMap.GetTile(pos).current);
            }

            // left
            pos = new Vector2(position.X - 32, position.Y );
            if (tileMap.GetTile(pos).isWire)
            {
                AddWatts(tileMap.GetTile(pos).current);
            }
            // Right
            pos = new Vector2(position.X + 32, position.Y);
            if (tileMap.GetTile(pos).isWire)
            {
                AddWatts(tileMap.GetTile(pos).current);
            }

        }
    }
}
