using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class ItemDatabase
    {
        public List<Item> items = new List<Item>(); 

        public ItemDatabase()
        {
            items.Add(new Item(Tile.TileType.BlankTile, "Blank Tile", "A blank Tile", 0));
            items.Add(new Item(Tile.TileType.DryTile1, "Dry Tile 1", "Dry Tile", 1));
            items.Add(new Item(Tile.TileType.DryTile2, "Dry Tile 2", "Dry Tile", 2));
            items.Add(new Item(Tile.TileType.DryTile3, "Dry Tile 3", "Dry Tile", 3));
            items.Add(new Item(Tile.TileType.Granite1, "Granite 1", "Granite", 4));
            items.Add(new Item(Tile.TileType.Granite2, "Granite 2", "Granite", 5));
            items.Add(new Item(Tile.TileType.Granite3, "Granite 3", "Granite", 6));
            items.Add(new Item(Tile.TileType.Grass1, "Grass 1", "Grass", 7));
            items.Add(new Item(Tile.TileType.Grass2, "Grass 2", "Grass", 8));
            items.Add(new Item(Tile.TileType.Grass3, "Grass 3", "Grass", 9));
            items.Add(new Item(Tile.TileType.Water, "Water", "Water", 10));
            items.Add(new Item(Tile.TileType.ConstructionBlock, "Construction Block", "Construction Block", 11));
            items.Add(new Item(Tile.TileType.MarkerBlock, "Marker", "Place to designate machines", 12));
            items.Add(new Item(Tile.TileType.ConstructionDrillBit, "Drill Bit", "Drill Bit", 13));
            items.Add(new Item(Tile.TileType.ConstructionTube, "Construction Tube", "Construction Tube", 14)); 
            items.Add(new Item(Tile.TileType.QuarryBlock, "Quarry Block", "Place next to Marker", 15));
        }
    }
}
