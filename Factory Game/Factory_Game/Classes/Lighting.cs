using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game.Classes
{
    public class Lighting
    {
        float lightLevel = 1; // 0 being lowest 1 being highest 
        
        public Lighting()
        {
            
        }

        public void Update()
        {
            
        }

        public float[,] ChunkLighting(Tile[,] tiles )
        {
            float[,] lightMap = new float[32, 32];

            for(int x = 0; x < tiles.GetLength(0); x++)
            {
                for(int y = 0; y < tiles.GetLength(1); y++)
                {

                }
            }


            return lightMap;  
        }
    }
}
