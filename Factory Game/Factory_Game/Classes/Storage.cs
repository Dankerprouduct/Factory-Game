using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLua;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;
        public bool showInventory;
        public bool alive; 
        /// <summary>
        /// Storaeg lvs are 1, 2 & 3
        /// </summary>
        /// <param name="storageLv"></param>
        public Storage(int storageLv,Tile mTile, TileMap tMap, Game1 game)
        {
            alive = true; 
            tile = mTile; 
            Console.WriteLine("Storage Class MAde"); 
            level = storageLv;
            tileMap = tMap;
            inventory = new Inventory();
            inventory.inventoryType = Inventory.InventoryType.StorageInventory;
            inventory.LoadContent(mTile.contentManager, game);
            //inventory.inventoryType = Inventory.InventoryType.StorageInventory;
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
            Vector2 pos;
            pos = new Vector2(tile.position.X + (x * 32), tile.position.Y + (y * 32));

            tileMap.GetTile(pos).UpdateIndex(type);
        }
        public void DestroyTile(int x, int y)
        {
            Vector2 pos;
            pos = new Vector2(tile.position.X + (x * 32), tile.position.Y + (y * 32));

            tileMap.GetTile(pos).durability = 0; 
        }
        public void Update(TileMap tileMap, Game1 game, GameTime gameTime)
        {
            PlayerInteraction(game); 
            inventory.Update(gameTime, game); 
            if(game.tileMap.GetTile(tile.position).index != 60)
            {
                DestroyTile(0, 0);
                DestroyTile(1, 0);
                DestroyTile(-1, 0);
                DestroyTile(1, 1);
                DestroyTile(-1, -1);
                DestroyTile(1, -1);
                DestroyTile(0, 1);
                DestroyTile(0, -1);
                DestroyTile(-1, 1);
                alive = false; 
            }
            Vector2 pos = tile.position;
            // X+
            pos = new Vector2(tile.position.X + (2 * 32), tile.position.Y);
            if (game.tileMap.GetTile(pos).index == 59)
            {
                if (game.tileMap.GetTile(pos).inventory != null)
                {
                    //Console.WriteLine(tileMap.GetTile(pos).position);
                    if (game.tileMap.GetTile(pos).inventory.inventoryCount > 0)
                    {
                        inventory.AddToInventory(game.tileMap.GetTile(pos).inventory.inventory[0].item, 1);
                        game.tileMap.GetTile(pos).inventory.RemoveItem(game.tileMap.GetTile(pos).inventory.inventory[0].item);
                    }
                }
            }

            // X- 
            pos = new Vector2(tile.position.X - (2 * 32), tile.position.Y);
            if (tileMap.GetTile(pos).index == 57)
            {
                if (game.tileMap.GetTile(pos).inventory != null)
                {
                    if (game.tileMap.GetTile(pos).inventory.inventoryCount > 0)
                    {
                        inventory.AddToInventory(tileMap.GetTile(pos).inventory.inventory[0].item, 1);
                        game.tileMap.GetTile(pos).inventory.RemoveItem(game.tileMap.GetTile(pos).inventory.inventory[0].item);
                    }
                }
            }

            // Y+
            pos = new Vector2(tile.position.X, tile.position.Y - (2 * 32));
            if (tileMap.GetTile(pos).index == 58)
            {
                if (game.tileMap.GetTile(pos).inventory != null)
                {
                    if (game.tileMap.GetTile(pos).inventory.inventoryCount > 0)
                    {
                        inventory.AddToInventory(tileMap.GetTile(pos).inventory.inventory[0].item, 1);
                        game.tileMap.GetTile(pos).inventory.RemoveItem(game.tileMap.GetTile(pos).inventory.inventory[0].item);
                    }
                }
            }

            // Y- 
            pos = new Vector2(tile.position.X, tile.position.Y + (2 * 32));
            if (tileMap.GetTile(pos).index == 57)
            {
                if (game.tileMap.GetTile(pos).inventory != null)
                {
                    if (game.tileMap.GetTile(pos).inventory.inventoryCount > 0)
                    {
                        inventory.AddToInventory(tileMap.GetTile(pos).inventory.inventory[0].item, 1);
                        game.tileMap.GetTile(pos).inventory.RemoveItem(game.tileMap.GetTile(pos).inventory.inventory[0].item); 
                    }
                }
            }
                       

        }

        public void PlayerInteraction(Game1 game)
        {
            Vector2 pos = new Vector2(tile.position.X, tile.position.Y);

            if (game.tileMap.GetTile(pos).GetBounds().Intersects(game.player.rect))
            {
                
                keyboardState = Keyboard.GetState();
                if (keyboardState.IsKeyDown(Keys.F) && oldKeyboardState.IsKeyUp(Keys.F))
                {
                    showInventory = !showInventory;
                    inventory.showInventory = !inventory.showInventory; 
                }
                oldKeyboardState = keyboardState;
            }
            else
            {
                showInventory = false; 
                inventory.showInventory = false;
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
        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (showInventory)
            {
                //Console.WriteLine("Drawing"); 
               // inventory.Draw(spriteBatch, game.player);
            }
        }
    }
}
