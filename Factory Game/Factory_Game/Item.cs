using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Factory_Game
{
    public class Item
    {
        public Tile.TileType tileType;
        public string tileName;
        public string tileDescription;
        public int itemID;
        public Texture2D texture; 
        public Item()
        {

        }

        public Item(Tile.TileType type, string name, string description, int id, ContentManager content)
        {
            tileType = type;
            tileName = name;
            tileDescription = description;
            itemID = id;
            switch (type)
            {
                case Tile.TileType.BlankTile:
                    {
                       // texture = content.Load<Texture2D>("")
                        break;
                    }
                case Tile.TileType.DryTile1:
                    {
                        texture = content.Load<Texture2D>("TileObjects/DryTile1Item");
                        break;
                    }
                case Tile.TileType.DryTile2:
                    {
                        texture = content.Load<Texture2D>("TileObjects/DryTile2Item");
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        texture = content.Load<Texture2D>("TileObjects/DryTile3Item");
                        break;
                    }
                case Tile.TileType.Granite1:
                    {
                        texture = content.Load<Texture2D>("TileObjects/Granite1Item");
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        texture = content.Load<Texture2D>("TileObjects/Granite2Item");
                        break;
                    }
                case Tile.TileType.Granite3:
                    {
                        texture = content.Load<Texture2D>("TileObjects/Granite3Item");
                        break;
                    }
                case Tile.TileType.Grass1:
                    {
                        texture = content.Load<Texture2D>("TileObjects/Grass1Item");
                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        texture = content.Load<Texture2D>("TileObjects/Grass2Item");
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        texture = content.Load<Texture2D>("TileObjects/Grass3Item");
                        break;
                    }
                case Tile.TileType.ConstructionBlock:
                    {
                        texture = content.Load<Texture2D>("TileObjects/ConstructionBlockItem");
                        break;
                    }
                case Tile.TileType.MarkerBlock:
                    {
                        texture = content.Load<Texture2D>("TileObjects/MarkerBlockItem");
                        break;
                    }
                case Tile.TileType.ConstructionTube:
                    {
                       // texture = content.Load<Texture2D>("TileObject/")
                        break;
                    }
                case Tile.TileType.ConstructionDrillBit:
                    {

                        break;
                    }
                case Tile.TileType.QuarryBlock:
                    {
                        texture = content.Load<Texture2D>("TileObjects/QuarryBlockItem");
                        break;
                    }
                case Tile.TileType.ItemPipeNorth:
                    {
                        texture = content.Load<Texture2D>("TileObjects/NorthTubeItem");
                        break;
                    }
                case Tile.TileType.ItemPipeEast:
                    {
                        texture = content.Load<Texture2D>("TileObjects/EastTubeItem");
                        break;
                    }
                case Tile.TileType.ItemPipeSouth:
                    {
                        texture = content.Load<Texture2D>("TileObjects/SouthTubeItem");
                        break;
                    }
                case Tile.TileType.ItemPipeWest:
                    {
                        texture = content.Load<Texture2D>("TileObjects/WestTubeItem");
                        break;
                    }
                case Tile.TileType.StorageCrate:
                    {
                        texture = content.Load<Texture2D>("TileObjects/StorageCrateItem");
                        break;
                    }



            }
        }

    }
}
