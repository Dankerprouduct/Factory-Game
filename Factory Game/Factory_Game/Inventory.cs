using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    class Inventory
    {
        public int dT1;
        public int dT2;
        public int dT3;
        public int gT1;
        public int gT2;
        public int gT3;
        public int gR1;
        public int gR2;
        public int gR3;

        public Inventory()
        {
            dT1 = 0;
            dT2 = 0;
            dT3 = 0;
            gT1 = 0;
            gT2 = 0;
            gT3 = 0;
            gR1 = 0;
            gR2 = 0;
            gR3 = 0; 
            
        }

        public void AddToInventory(Tile.TileType type, int ammount)
        {
            switch (type)
            {
                case Tile.TileType.DryTile1:
                    {
                        dT1 += ammount; 
                        break; 
                    }
                case Tile.TileType.DryTile2:
                    {
                        dT2 += ammount;
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        dT3 += ammount;
                        break; 
                    }
                case Tile.TileType.Granite1:
                    {
                        gT1 += ammount;
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        gT2 += ammount;
                        break; 
                    }
                case Tile.TileType.Granite3:
                    {
                        gT3 += ammount;
                        break; 
                    }
                case Tile.TileType.Grass1:
                    {
                        gR1 += ammount;
                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        gR2 += ammount;
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        gR3 += ammount;
                        break; 
                    }
            }
        }
    }
}
