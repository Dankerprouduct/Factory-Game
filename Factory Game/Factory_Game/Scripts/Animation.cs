using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.IO; 
namespace Factory_Game
{
    public static class Animation
    {

        /// <summary>
        /// GEts the source rect for tile spritesheet
        /// </summary
        /// <param name="sourceWidth"></param>
        /// <param name="sourceHeight"></param>
        /// <param name="tile"></param>
        /// <returns></returns>

        public static Rectangle SourceRect(Tile.TileType tile,string name)
        {
           
            string path = "TileData/" + name + ".txt";
            StreamReader sr = new StreamReader(path); 
            int height = File.ReadLines(path).Count();
            
            char[] splits = { '=', ' ' };
            

            for(int y = 0; y < height; y++)
            {
                string line = sr.ReadLine();
                string[] rectData = line.Split(splits);

                foreach(string s in rectData)
                {
                    if (tile.ToString() == s)
                    {
                        sr.Close(); 

                        return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6])); 
                    }
                }
            }
            return new Rectangle(0, 0, 0,0); 

        }


    }
}
