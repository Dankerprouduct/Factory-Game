﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

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
            int width = 32;
            int height = 32; 
            //Rectangle sourceRect;
            switch (tile)
            {
                case Tile.TileType.BlankTile:
                    {
                        return new Rectangle(0, 0, width, height);
                        // 
                        break;
                    }
                case Tile.TileType.CoalBlock:
                    {
                        return new Rectangle(width, 0, width, height);
                         
                        break;
                    }
                case Tile.TileType.ConstructionBlock:
                    {
                        return new Rectangle(0, height, width, height);
                         
                        break;
                    }
                case Tile.TileType.ConstructionDrillBit:
                    {
                        return new Rectangle(width, height, width, height);
                         
                        break;
                    }
                case Tile.TileType.ConstructionTube:
                    {
                        return new Rectangle(width * 2, 0, width, height);
                         
                        break;
                    }
                case Tile.TileType.CopperTile:
                    {
                        return new Rectangle(width * 2, height, width, height);
                         
                        break;
                    }
                case Tile.TileType.DryTile1:
                    {
                        return new Rectangle(width * 3, 0, width, height);
                         
                        break;
                    }
                case Tile.TileType.DryTile2:
                    {
                        return new Rectangle(width * 3, height, width, height);
                         
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        return new Rectangle(0, height * 2, width, height);
                         
                        break;
                    }
                case Tile.TileType.Granite1:
                    {
                        return new Rectangle(width, height * 2, width, height);
                         
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        return new Rectangle(width * 2, height * 2, width, height); 
                        break;
                    }
                case Tile.TileType.Granite3:
                    {
                        return new Rectangle(width, height * 3, width, height);
                         
                        break;
                    }
                case Tile.TileType.Grass1:
                    {
                        return new Rectangle(width * 2, height * 3, width, height);
                         
                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        // 3, 2
                        return new Rectangle(width * 3, height * 2, width, height);
                         
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        // 3, 3
                        return new Rectangle(width * 3, height * 3, width, height);
                         
                        break;
                    }
                case Tile.TileType.IronBlock:
                    {

                        break;
                    }
                case Tile.TileType.ItemPipeEast:
                    {
                        return new Rectangle(0, height * 3, width, height);
                         
                        break;
                    }
                case Tile.TileType.ItemPipeNorth:
                    {
                        return new Rectangle(width * 4, height, width, height);
                         
                        break;
                    }
                case Tile.TileType.ItemPipeSouth:
                    {
                        return new Rectangle(width * 5, height * 2, width, height);
                         
                        break;
                    }
                case Tile.TileType.ItemPipeWest:
                    {
                        // 1, 5 
                        return new Rectangle(width, height * 5, width, height);

                        break;
                    }
                case Tile.TileType.MarkerBlock:
                    {
                        return new Rectangle(width * 5, 0, width, height);
                         
                        break;
                    }
                case Tile.TileType.Platform1:
                    {
                        return new Rectangle(width * 6, 0, width, height);
                         
                        break;
                    }
                case Tile.TileType.QuarryBlock:
                    {
                        // 5, 1
                        return new Rectangle(width * 5, height, width, height);
                         
                        break;
                    }
                case Tile.TileType.SandTile:
                    {
                        // 4, 2 
                        return new Rectangle(width * 4, height * 2, width, height);
                         
                        break;
                    }
                case Tile.TileType.StorageCrate:
                    {
                        return new Rectangle(width * 7, 0, width, height);

                        break;
                    }
                case Tile.TileType.UraniumBlock:
                    {
                        return new Rectangle(width, height * 4, width, height);

                        break;
                    }
                case Tile.TileType.Water:
                    {
                        return new Rectangle(0, height * 5, width, height);
                         
                        break;
                    }
                default:
                    {
                        // put error block right here
                        Console.WriteLine("Texture for " + tile.ToString() + " could not be found");
                        return Rectangle.Empty;
                        break;
                    }
            }
            return Rectangle.Empty; 
             
            //return Rectangle.Empty;
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
