using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class ItemDatabase
    {
        public List<Item> items = new List<Item>(); 

        public ItemDatabase(ContentManager content)
        {
            items.Add(new Item(Tile.TileType.BlankTile, "Blank Tile", "A blank Tile", 0,false,500, content));
            items.Add(new Item(Tile.TileType.DryTile1, "Dry Tile 1", "Dry Tile", 1,false, 500, content));
            items.Add(new Item(Tile.TileType.DryTile2, "Dry Tile 2", "Dry Tile", 2,false, 500, content));
            items.Add(new Item(Tile.TileType.DryTile3, "Dry Tile 3", "Dry Tile", 3,false, 500, content));
            items.Add(new Item(Tile.TileType.Granite1, "Granite 1", "Granite", 4,true, 500, content));
            items.Add(new Item(Tile.TileType.Granite2, "Granite 2", "Granite", 5,true, 500, content));
            items.Add(new Item(Tile.TileType.Granite3, "Granite 3", "Granite", 6,true, 500, content));
            items.Add(new Item(Tile.TileType.Grass1, "Grass 1", "Grass", 7,false, 500, content));
            items.Add(new Item(Tile.TileType.Grass2, "Grass 2", "Grass", 8,false, 500, content));
            items.Add(new Item(Tile.TileType.Grass3, "Grass 3", "Grass", 9,false, 500, content));
            items.Add(new Item(Tile.TileType.Water, "Water", "Water", 10,false, 500, content));
            items.Add(new Item(Tile.TileType.ConstructionBlock, "Construction Block", "Construction Block", 11,false, 500, content));
            items.Add(new Item(Tile.TileType.MarkerBlock, "Marker", "Place to designate machines", 12,false,  500, content));
            items.Add(new Item(Tile.TileType.ConstructionDrillBit, "Drill Bit", "Drill Bit", 13,false, 500,  content));
            items.Add(new Item(Tile.TileType.ConstructionTube, "Construction Tube", "Construction Tube", 14,false, 500, content)); 
            items.Add(new Item(Tile.TileType.QuarryBlock, "Quarry Block", "Place next to Marker", 15,false, 500, content));
            items.Add(new Item(Tile.TileType.ItemPipeNorth, "Item Pipe", "Item Pipe facing North", 16,false, 500, content));
            items.Add(new Item(Tile.TileType.ItemPipeEast, "Item Pipe", "Item Pipe facing East", 17,false,500, content));
            items.Add(new Item(Tile.TileType.ItemPipeSouth, "Item Pipe", "Item Pipe facing South", 18,false,500, content));
            items.Add(new Item(Tile.TileType.ItemPipeWest, "Item Pipe", "ItemPipe facing West", 19,false, 500, content));
            items.Add(new Item(Tile.TileType.StorageCrate, "Storage Crate", "Item Storage Crate", 20,false, 500, content));
            items.Add(new Item(Tile.TileType.RedWire1, "Red Wire", "A High Ressistance Wire", 21, false, 500, content));
            items.Add(new Item(Tile.TileType.GreenWire1, "Green Wire", "A Medium Resistance Wire", 22, false, 500, content));
            items.Add(new Item(Tile.TileType.GoldWire1, "Gold Wire", "A Low Ressistance Wire", 23, false, 500, content));
            items.Add(new Item(Tile.TileType.BatteryBlock, "Battery Block", "A block that holds power", 24, false, 500, content));
            items.Add(new Item(Tile.TileType.SolarPanel, "Solar Panel", "A block that gets power from the sun", 25, false, 500, content)); 
        }
    }
}
