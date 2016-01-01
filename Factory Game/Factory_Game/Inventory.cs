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
        public bool showInventory; 
        public List<ItemStack> inventory = new List<ItemStack>();
        public List<ItemStack> slots = new List<ItemStack>(); 
        Texture2D inventoryTexture; 
        int inventorySize; // only multiples of 2
        int width;
        int height;
        int offSet = 5;
        int inventoryCount;
        SpriteFont font;
        ItemDatabase database;
        MouseState mouseState;
        MouseState oldMouseState; 
        Vector2 mousePosition;
        Vector2 worldPosition;
        Point point; 

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
            width = 20;
            height = 1;
            inventoryCount = 0; 
            for(int i = 0; i < width * height; i++)
            {
                slots.Add(new ItemStack());
                inventory.Add(new ItemStack()); 
            }

            tileType = new Tile.TileType();
            selectedItem = 0;
            tileType = Tile.TileType.DryTile1; 
            itemIndex.Add(10000); //  Dirt Tile 1 
            itemIndex.Add(10000); //  Dirt Tile 2
            itemIndex.Add(10000); //  Dirt Tile 3
            itemIndex.Add(10000); //  Granite Tile 1
            itemIndex.Add(10000); //  Granite Tile 2
            itemIndex.Add(10000); //  Granite Tile 3
            itemIndex.Add(10000); //  Grass Tile 1
            itemIndex.Add(10000); //  Grass Tile 2
            itemIndex.Add(10000); //  Grass Tile 3
            itemIndex.Add(10000); //  Construction Block 
            itemIndex.Add(10000); //  Marker Block; 
            itemIndex.Add(10000); //  Quarry Block



        }
        public void LoadContent(ContentManager content)
        {
            database = new ItemDatabase(content);
            inventoryTexture = content.Load<Texture2D>("Fonts/DarkGrayBack");
            font = content.Load<SpriteFont>("Fonts/InventoryFont");
        }
        public void Update(GameTime gameTime, Game1 game)
        {
            mouseState = Mouse.GetState();
            
            mousePosition = new Vector2(mouseState.X, mouseState.Y);
            worldPosition = Vector2.Transform(mousePosition, Matrix.Invert(game.camera.rawTransform));
            point = new Point((int)worldPosition.X, (int)worldPosition.Y); 
            keyboardState = Keyboard.GetState();
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
            oldMouseState = mouseState;
        }

        public void AddToInventory(Item item, int ammount)
        {

            for (int i = 0; i < inventory.Count; i++)
            {

                ////////////////////
                if(inventory[i].item.tileType == item.tileType && inventory[i].count < 10)
                {
                    inventory[i].count++;
                    break;
                }
                else if(inventory[i].item.tileName == null)
                {

                    for (int j = 0; j < database.items.Count; j++)
                    {
                        if (database.items[j].tileType == item.tileType)
                        {
                            inventory[i].item = database.items[j];
                            
                            break;
                        }
                    }
                    break;
                }
                ////////////////////

            }

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
                        Rectangle slotRect = new Rectangle(((32 + offSet) * x) + (int)player.position.X - (width * 32) / 2,((32 + offSet) * y) + (int)player.position.Y - 64, 32, 32);

                        slots[i] = inventory[i];

                        spriteBatch.Draw(inventoryTexture, slotRect, Color.White); 
                        if(slots[i].item.tileName != null)
                        {
                            spriteBatch.Draw(slots[i].item.texture, new Vector2(slotRect.X + (slotRect.Width / 4),
                                slotRect.Y + (slotRect.Height / 4)), Color.White);
                            spriteBatch.DrawString(font, slots[i].count.ToString(), new Vector2(slotRect.X, slotRect.Y), Color.White);

                            
                            if (slotRect.Contains(point))
                            {
                                Console.WriteLine(slots[i].item.tileName);
                                Rectangle toolTipBox = new Rectangle(slotRect.X - 150 + 16, slotRect.Y - 325, 300, 300);
                                spriteBatch.Draw(inventoryTexture, toolTipBox, Color.White); 
                                spriteBatch.DrawString(font, slots[i].item.tileName , new Vector2(toolTipBox.X, toolTipBox.Y), Color.White);
                                spriteBatch.DrawString(font, slots[i].item.tileDescription, new Vector2(toolTipBox.X, toolTipBox.Y + 20), Color.White);
                            }
                        }

                        i++;
                    }

                    
                }

            }
        }
    }
}
