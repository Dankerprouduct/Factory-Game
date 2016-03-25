using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLua;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Factory_Game
{
    public class Storage
    {
        private int level;
        private Lua lua;
        private TileMap tileMap;
        private Tile tile;
        public Inventory inventory; 
        
        /// <summary>
        /// Storaeg lvs are 1, 2 & 3
        /// </summary>
        /// <param name="storageLv"></param>
        public Storage(int storageLv,Tile mTile, TileMap tMap)
        {
            tile = mTile; 
            Console.WriteLine("Storage Class MAde"); 
            level = storageLv;
            tileMap = tMap;
            inventory = new Inventory();
            inventory.inventoryType = Inventory.InventoryType.StorageInventory;
            inventory.LoadContent(mTile.contentManager);

            BuildStructure(); 
        }
        public void BuildStorage()
        {
            lua = new Lua();
            
        }
        public void BuildStructure()
        {
            Lua lua = new Lua();
            lua.RegisterFunction("BuildTile", this, GetType().GetMethod("BuildTile"));
            lua.RegisterFunction("GetXIndex", this, GetType().GetMethod("GetXIndex"));
            lua.RegisterFunction("GetYIndex", this, GetType().GetMethod("GetYIndex"));
            lua.DoString("structureType = 1");
            lua.DoFile("LuaScripts/structure_data.lua");


        }

        public void BuildTile(int x, int y, int type)
        {
            Console.WriteLine(type); 
            Vector2 pos;
            pos = new Vector2(tile.position.X + (x * 32), tile.position.Y + (y * 32));

            tileMap.GetTile(pos).UpdateIndex((Tile.TileType)type);
        }
        public void Update(TileMap tileMap, Game1 game)
        {
            
            Vector2 pos = tile.position;
            // X+
            pos = new Vector2(tile.position.X + (2 * 32), tile.position.Y);
            if (game.tileMap.GetTile(pos).tileType == Tile.TileType.ItemPipeWest)
            {
                Console.WriteLine(tileMap.GetTile(pos).position); 
                if (game.tileMap.GetTile(pos).inventory.inventoryCount > 0)
                {
                    inventory.AddToInventory(game.tileMap.GetTile(pos).inventory.inventory[0].item, 1);
                }
            }

            // X- 
            pos = new Vector2(tile.position.X - (2 * 32), tile.position.Y);
            if(tileMap.GetTile(pos).tileType == Tile.TileType.ItemPipeEast)
            {
                inventory.AddToInventory(tileMap.GetTile(pos).inventory.inventory[0].item, 1);
            }

            // Y+
            pos = new Vector2(tile.position.X, tile.position.Y - (2 * 32)); 
            if(tileMap.GetTile(pos).tileType == Tile.TileType.ItemPipeSouth)
            {
                inventory.AddToInventory(tileMap.GetTile(pos).inventory.inventory[0].item, 1);
            }

            // Y- 
            pos = new Vector2(tile.position.X, tile.position.Y + (2 * 32)); 
            if(tileMap.GetTile(pos).tileType == Tile.TileType.ItemPipeEast)
            {
                inventory.AddToInventory(tileMap.GetTile(pos).inventory.inventory[0].item, 1);
            }

            

        }
        
        public int GetXIndex()
        {
            return (int)tile.position.X;

        }
        public int GetYIndex()
        {
            return (int)tile.position.Y;
        }

    }
}
