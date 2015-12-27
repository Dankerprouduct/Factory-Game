using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class Item
    {
        Tile.TileType tileType;
        string tileName;
        string tileDescription;
        int itemID;
        
        public Item(Tile.TileType type, string name, string description, int id)
        {
            tileType = type;
            tileName = name;
            tileDescription = description;
            itemID = id; 
        }
    }
}
