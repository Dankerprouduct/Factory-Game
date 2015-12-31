using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Factory_Game
{
    public class Inventory
    {

        public int selectedItem = 0;
        public List<int> itemIndex = new List<int>(); 
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;
        public Tile.TileType tileType;
        bool showInventory; 
        public List<Item> inventory = new List<Item>();
        public List<Item> slots = new List<Item>(); 
        Texture2D inventoryTexture; 
        int inventorySize; // only multiples of 2
        int width;
        int height;
        int offSet = 5;
        int inventoryCount;
        SpriteFont font;
        ItemDatabase database;
        public enum InventoryType
        {
            PlayerInventory,
            StorageInventory
        }
        public InventoryType inventoryType; 
        // TODO move all g craps to just a list of types 
        public Inventory()
        {
            inventoryType = new InventoryType(); 
            width = 5;
            height = 5;
            inventoryCount = 0; 
            for(int i = 0; i < width * height; i++)
            {
                slots.Add(new Item());
                inventory.Add(new Item()); 
            }

            tileType = new Tile.TileType();
            selectedItem = 0;
            tileType = Tile.TileType.DryTile1; 
            itemIndex.Add(100); //  Dirt Tile 1 
            itemIndex.Add(100); //  Dirt Tile 2
            itemIndex.Add(100); //  Dirt Tile 3
            itemIndex.Add(100); //  Granite Tile 1
            itemIndex.Add(100); //  Granite Tile 2
            itemIndex.Add(100); //  Granite Tile 3
            itemIndex.Add(100); //  Grass Tile 1
            itemIndex.Add(100); //  Grass Tile 2
            itemIndex.Add(100); //  Grass Tile 3
            itemIndex.Add(100); //  Construction Block 
            itemIndex.Add(100); //  Marker Block; 
            itemIndex.Add(100); //  Quarry Block



        }
        public void LoadContent(ContentManager content)
        {
            database = new ItemDatabase(content);
            inventoryTexture = content.Load<Texture2D>("Fonts/DarkGrayBack");
            font = content.Load<SpriteFont>("Fonts/InventoryFont");
        }
        public void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();
            //  itemIndex[9] += 1; 
            if (inventoryType == InventoryType.PlayerInventory)
            {
                if (keyboardState.IsKeyDown(Keys.G) && oldKeyboardState.IsKeyUp(Keys.G))
                {
                    showInventory = !showInventory;
                }
            }
            #region // old inventory
            if (keyboardState.IsKeyDown(Keys.E) && oldKeyboardState.IsKeyUp(Keys.E))
            {
                selectedItem++;

                if (selectedItem <= itemIndex.Count - 1)
                {

                    switch (selectedItem)
                    {

                        case 0:
                            {
                                tileType = Tile.TileType.DryTile1;

                                break;
                            }
                        case 1:
                            {
                                tileType = Tile.TileType.DryTile2;

                                break;
                            }
                        case 2:
                            {
                                tileType = Tile.TileType.DryTile3;
                                break;
                            }
                        case 3:
                            {
                                tileType = Tile.TileType.Granite1;
                                break;
                            }
                        case 4:
                            {
                                tileType = Tile.TileType.Granite2;
                                break;
                            }
                        case 5:
                            {
                                tileType = Tile.TileType.Granite3;
                                break;
                            }
                        case 6:
                            {
                                tileType = Tile.TileType.Grass1;
                                break;
                            }
                        case 7:
                            {
                                tileType = Tile.TileType.Grass2;
                                break;
                            }
                        case 8:
                            {
                                tileType = Tile.TileType.Grass3;
                                break;
                            }
                        case 9:
                            {
                                tileType = Tile.TileType.ConstructionBlock;
                                break;
                            }
                        case 10:
                            {
                                tileType = Tile.TileType.MarkerBlock;
                                break;
                            }
                        case 11:
                            {
                                tileType = Tile.TileType.QuarryBlock;
                                break;

                            }
                    }

                }
                else
                {
                    selectedItem = 0;
                    tileType = Tile.TileType.DryTile1;
                }


                


            }
            if (keyboardState.IsKeyDown(Keys.Q) && oldKeyboardState.IsKeyUp(Keys.Q))
            {
                selectedItem--;

                if (selectedItem < 0)
                {
                    selectedItem = itemIndex.Count;
                }

                if (selectedItem <= itemIndex.Count - 1)
                {

                    switch (selectedItem)
                    {

                        case 0:
                            {
                                tileType = Tile.TileType.DryTile1;

                                break;
                            }
                        case 1:
                            {
                                tileType = Tile.TileType.DryTile2;

                                break;
                            }
                        case 2:
                            {
                                tileType = Tile.TileType.DryTile3;
                                break;
                            }
                        case 3:
                            {
                                tileType = Tile.TileType.Granite1;
                                break;
                            }
                        case 4:
                            {
                                tileType = Tile.TileType.Granite2;
                                break;
                            }
                        case 5:
                            {
                                tileType = Tile.TileType.Granite3;
                                break;
                            }
                        case 6:
                            {
                                tileType = Tile.TileType.Grass1;
                                break;
                            }
                        case 7:
                            {
                                tileType = Tile.TileType.Grass2;
                                break;
                            }
                        case 8:
                            {
                                tileType = Tile.TileType.Grass3;
                                break;
                            }
                        case 9:
                            {
                                tileType = Tile.TileType.ConstructionBlock;
                                break;
                            }
                        case 10:
                            {
                                tileType = Tile.TileType.MarkerBlock;
                                break;
                            }
                        case 11:
                            {
                                tileType = Tile.TileType.QuarryBlock;
                                break;

                            }
                    }

                }
                else
                {
                    selectedItem = 0;
                    tileType = Tile.TileType.DryTile1;
                }
                

            }
            #endregion


            oldKeyboardState = keyboardState;
        }
        public void AddToInventory(Item item, int ammount)
        {

            for (int g = 0; g < ammount; g++)
            {
                inventoryCount = inventoryCount + 1;

                for (int i = 0; i < inventory.Count; i++)
                {
                    if (inventory[i].itemID == item.itemID)
                    {
                        inventory[i].stackCount++;

                        break;
                    }
                    else if (inventory[i].tileName == null)
                    {

                        for (int j = 0; j < database.items.Count; j++)
                        {
                            if (database.items[j].tileType == item.tileType)
                            {
                                inventory[i] = database.items[j];

                            }

                        }

                        break;
                    }

                }

            }

        //    inventory.Add(item); 
            
        }
        
        public void Draw(SpriteBatch spriteBatch, Player player)
        {

            if (showInventory)
            {
                int i = 0; 

                for(int y = 0; y < height; y++)
                {
                    for(int x = 0; x < width; x++)
                    {
                        Rectangle slotRect = new Rectangle(((32 + offSet) * x) + (int)player.position.X + 100,((32 + offSet) * y) + (int)player.position.Y - 100, 32, 32);

                        slots[i] = inventory[i];

                        spriteBatch.Draw(inventoryTexture, slotRect, Color.White); 
                        if(slots[i].tileName != null)
                        {
                            spriteBatch.Draw(slots[i].texture, new Vector2(slotRect.X + (slotRect.Width / 4),
                                slotRect.Y + (slotRect.Height / 4)), Color.White);
                            spriteBatch.DrawString(font, slots[i].stackCount.ToString(), new Vector2(slotRect.X, slotRect.Y), Color.White); 
                        }

                        i++;
                    }

                    
                }

            }
        }
    }
}
