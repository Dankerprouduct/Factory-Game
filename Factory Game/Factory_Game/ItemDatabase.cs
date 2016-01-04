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
            items.Add(new Item(Tile.TileType.BlankTile, "Blank Tile", "A blank Tile", 0, content));
            items.Add(new Item(Tile.TileType.DryTile1, "Dry Tile 1", "Dry Tile", 1, content));
            items.Add(new Item(Tile.TileType.DryTile2, "Dry Tile 2", "Dry Tile", 2, content));
            items.Add(new Item(Tile.TileType.DryTile3, "Dry Tile 3", "Dry Tile", 3, content));
            items.Add(new Item(Tile.TileType.Granite1, "Granite 1", "Granite", 4, content));
            items.Add(new Item(Tile.TileType.Granite2, "Granite 2", "Granite", 5, content));
            items.Add(new Item(Tile.TileType.Granite3, "Granite 3", "Granite", 6, content));
            items.Add(new Item(Tile.TileType.Grass1, "Grass 1", "Grass", 7, content));
            items.Add(new Item(Tile.TileType.Grass2, "Grass 2", "Grass", 8, content));
            items.Add(new Item(Tile.TileType.Grass3, "Grass 3", "Grass", 9, content));
            items.Add(new Item(Tile.TileType.Water, "Water", "Water", 10, content));
            items.Add(new Item(Tile.TileType.ConstructionBlock, "Construction Block", "Construction Block", 11, content));
            items.Add(new Item(Tile.TileType.MarkerBlock, "Marker", "Place to designate machines", 12, content));
            items.Add(new Item(Tile.TileType.ConstructionDrillBit, "Drill Bit", "Drill Bit", 13, content));
            items.Add(new Item(Tile.TileType.ConstructionTube, "Construction Tube", "Construction Tube", 14, content)); 
            items.Add(new Item(Tile.TileType.QuarryBlock, "Quarry Block", "Place next to Marker", 15, content));
            items.Add(new Item(Tile.TileType.ItemPipeNorth, "Item Pipe", "Item Pipe facing Nort", 16, content));
            items.Add(new Item(Tile.TileType.ItemPipeEast, "Item Pipe", "Item Pipe facing East", 17, content));
            items.Add(new Item(Tile.TileType.ItemPipeSouth, "Item Pipe", "Item Pipe facing South", 18, content));
            items.Add(new Item(Tile.TileType.ItemPipeWest, "Item Pipe", "ItemPipe facing West", 19, content)); 
        }
    }
}
