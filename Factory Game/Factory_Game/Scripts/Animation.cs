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
        public static Rectangle SourceRect(Tile.TileType tile)
        {

            switch (tile)
            {
                case Tile.TileType.BlankTile:
                    {
                        return new Rectangle(32, 0, 32, 32);
                        // 
                        break;
                    }
                case Tile.TileType.CoalBlock:
                    {
                        return new Rectangle(160, 32, 32, 32);

                        break;
                    }
                case Tile.TileType.ConstructionBlock:
                    {
                        return new Rectangle(64, 32, 32, 32);

                        break;
                    }
                case Tile.TileType.ConstructionDrillBit:
                    {
                        return new Rectangle(96, 0, 32, 32);

                        break;
                    }
                case Tile.TileType.ConstructionTube:
                    {
                        return new Rectangle(96, 32, 32, 32);

                        break;
                    }
                case Tile.TileType.CopperTile:
                    {
                        return new Rectangle(128, 64, 32, 32);

                        break;
                    }
                case Tile.TileType.DryTile1:
                    {
                        return new Rectangle(32, 64, 32, 32);

                        break;
                    }
                case Tile.TileType.DryTile2:
                    {
                        return new Rectangle(64, 64, 32, 32);

                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        return new Rectangle(32, 96, 32, 32);

                        break;
                    }
                case Tile.TileType.Granite1:
                    {
                        return new Rectangle(96, 64, 32, 32);

                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        return new Rectangle(96, 96, 32, 32);
                        break;
                    }
                case Tile.TileType.Granite3:
                    {
                        return new Rectangle(128, 0, 32, 32);

                        break;
                    }
                case Tile.TileType.Grass1:
                    {
                        return new Rectangle(160, 0, 32, 32);

                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        // 3, 2
                        return new Rectangle(128, 32, 32, 32);

                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        // 3, 3
                        return new Rectangle(192, 0, 32, 32);

                        break;
                    }
                case Tile.TileType.IronBlock:
                    {
                        return new Rectangle(160, 64, 32, 32);
                        break;
                    }
                case Tile.TileType.ItemPipeEast:
                    {
                        return new Rectangle(192, 32, 32, 32);

                        break;
                    }
                case Tile.TileType.ItemPipeNorth:
                    {
                        return new Rectangle(32, 160, 32, 32);

                        break;
                    }
                case Tile.TileType.ItemPipeSouth:
                    {
                        return new Rectangle(96, 128, 32, 32);

                        break;
                    }
                case Tile.TileType.ItemPipeWest:
                    {
                        // 1, 5 
                        return new Rectangle(128, 128, 32, 32);

                        break;
                    }
                case Tile.TileType.MarkerBlock:
                    {
                        return new Rectangle(0, 64, 32, 32);

                        break;
                    }
                case Tile.TileType.Platform1:
                    {
                        return new Rectangle(32, 32, 32, 32);

                        break;
                    }
                case Tile.TileType.QuarryBlock:
                    {
                        // 5, 1
                        return new Rectangle(0, 96, 32, 32);

                        break;
                    }
                case Tile.TileType.SandTile:
                    {
                        // 4, 2 
                        return new Rectangle(64, 96, 32, 32);

                        break;
                    }
                case Tile.TileType.StorageCrate:
                    {
                        return new Rectangle(128, 160, 32, 32);

                    }
                case Tile.TileType.UraniumBlock:
                    {
                        return new Rectangle(128, 96, 32, 32);

                    }
                case Tile.TileType.Water:
                    {
                        return new Rectangle(64, 0, 32, 32);

                    }
                case Tile.TileType.RedWire1:
                    {
                        return new Rectangle(0, 192, 32, 32);
                    }
                case Tile.TileType.RedWire2:
                    {
                        return new Rectangle(64, 128, 32, 32);
                    }
                case Tile.TileType.RedWire3:
                    {
                        return new Rectangle(32, 192, 32, 32);
                    }
                case Tile.TileType.RedWire4:
                    {
                        return new Rectangle(0, 224, 32, 32);
                    }
                case Tile.TileType.RedWire5:
                    {
                        return new Rectangle(64, 160, 32, 32); 
                    }
                case Tile.TileType.GreenWire1:
                    {
                        return new Rectangle(224, 64, 32, 32);
                    }
                case Tile.TileType.GreenWire2:
                    {
                        return new Rectangle(224, 96, 32, 32);
                    }
                case Tile.TileType.GreenWire3:
                    {
                        return new Rectangle(0, 128, 32, 32);
                    }
                case Tile.TileType.GreenWire4:
                    {
                        return new Rectangle(32, 128, 32, 32);
                    }
                case Tile.TileType.GreenWire5:
                    {
                        return new Rectangle(0, 160, 32, 32); 
                    }
                case Tile.TileType.GoldWire1:
                    {
                        return new Rectangle(224, 0, 32, 32);
                    }
                case Tile.TileType.GoldWire2:
                    {
                        return new Rectangle(224, 32, 32, 32); 
                    }
                case Tile.TileType.GoldWire3:
                    {
                        return new Rectangle(192, 64, 32, 32); 
                    }
                case Tile.TileType.GoldWire4:
                    {
                        return new Rectangle(160, 96, 32, 32);
                    }
                case Tile.TileType.GoldWire5:
                    {
                        return new Rectangle(192, 96, 32, 32);
                    }
                default:
                    {
                        // put error block right here
                        //Console.WriteLine("Texture for " + tile.ToString() + " could not be found");
                        return new Rectangle(0, 32, 32, 32); 

                    }
            }

        }
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

        /// <summary>
        /// Gets the source rect for tile object spritesheet
        /// </summary>
        /// <param name="sourceWidth"></param>
        /// <param name="sourcHeight"></param>
        /// <param name="tObject"></param>
        /// <returns>Source rect for tile object spritesheet</returns>
        public static Rectangle SourceRect(int sourceWidth, int sourcHeight, TileObject tObject)
        {
            return Rectangle.Empty;

            switch (tObject.type)
            {
                case Tile.TileType.BlankTile:
                    {
                        break;
                    }
                case Tile.TileType.CoalBlock:
                    {
                        break;
                    }
                case Tile.TileType.ConstructionBlock:
                    {
                        break;
                    }
                case Tile.TileType.ConstructionDrillBit:
                    {
                        break;
                    }
                case Tile.TileType.ConstructionTube:
                    {
                        break;
                    }
                case Tile.TileType.CopperTile:
                    {
                        break;
                    }
                case Tile.TileType.DryTile1:
                    {
                        break;
                    }
                case Tile.TileType.DryTile2:
                    {
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        break;
                    }
                case Tile.TileType.Granite1:
                    {
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        break; 
                    }
                case Tile.TileType.Granite3:
                    {
                        break; 
                    }
                case Tile.TileType.Grass1:
                    {
                        break; 
                    }
                case Tile.TileType.Grass2:
                    {
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        break;
                    }
                case Tile.TileType.IronBlock:
                    {
                        break;
                    }
                case Tile.TileType.ItemPipeEast:
                    {
                        break; 
                    }
                case Tile.TileType.ItemPipeNorth:
                    {
                        break; 
                    }
                case Tile.TileType.ItemPipeSouth:
                    {
                        break; 
                    }
                case Tile.TileType.ItemPipeWest:
                    {
                        break; 
                    }
                case Tile.TileType.MarkerBlock:
                    {
                        break; 
                    }
                case Tile.TileType.Platform1:
                    {
                        break;
                    }
                case Tile.TileType.QuarryBlock:
                    {
                        break;
                    }
                case Tile.TileType.SandTile:
                    {
                        break;
                    }
                case Tile.TileType.StorageCrate:
                    {
                        break; 
                    }
                case Tile.TileType.UraniumBlock:
                    {
                        break; 
                    }
                case Tile.TileType.Water:
                    {
                        break;
                    }
                default:
                    {
                        // put error block here 
                        Console.WriteLine("Texture for tile object " + tObject.type.ToString() + " could not be found"); 
                        break; 
                    }
            }
        }
    }
}
