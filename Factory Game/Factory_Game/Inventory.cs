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
        
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;
        public Tile.TileType tileType;
        public bool showInventory;
        public List<ItemStack> inventory = new List<ItemStack>();
        public List<ItemStack> slots = new List<ItemStack>();
        Texture2D inventoryTexture;
        int width;
        int height;
        int offSet = 5;
        public int inventoryCount;
        public int maxInventoryCount; 
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
            StorageInventory,
            TubeInventory
        }
        public InventoryType inventoryType;

        public Inventory()
        {

            inventoryType = new InventoryType();
            width = 20;
            height = 1;
            inventoryCount = 0;
            for (int i = 0; i < width * height; i++)
            {
                slots.Add(new ItemStack());
                inventory.Add(new ItemStack());
            }

            maxInventoryCount = (width * height) * 500; 

            tileType = new Tile.TileType();
            selectedItem = 0;
           // tileType = Tile.TileType.DryTile1;

        }
        public void LoadContent(ContentManager content)
        {
            database = new ItemDatabase(content);

            inventoryTexture = content.Load<Texture2D>("Fonts/DarkGrayBack");
            font = content.Load<SpriteFont>("Fonts/InventoryFont");

            if (inventoryType == InventoryType.StorageInventory)
            {
                width = 3;
                height = 3;
            }
            else if(inventoryType == InventoryType.TubeInventory)
            {
                width = 1;
                height = 1; 
            }
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
            if(inventoryType == InventoryType.StorageInventory)
            {
                PushToBottom(); 
            }
            else if(inventoryType == InventoryType.TubeInventory)
            {
                PushToBottom(); 
            }

            
            oldKeyboardState = keyboardState;
            oldMouseState = mouseState;
        }


        public int ItemStackCount(Item item)
        {
            for(int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].item == item)
                {
                    return inventory[i].count;
                }
                else 
                {
                    return 0; 
                }
            }
            return 0; 
        }


        public void AddToInventory(Item item, int ammount)
        {

            for (int a = 0; a < ammount; a++)
            {
                for (int i = 0; i < inventory.Count; i++)
                {

                    ////////////////////

                    if (item != null)
                    {
                        if (inventory[i].item.tileType == item.tileType && inventory[i].count < 500)
                        {
                            inventory[i].count++;
                            inventoryCount++; 
                            break;
                        }
                        else if (inventory[i].item.tileName == null)
                        {

                            for (int j = 0; j < database.items.Count; j++)
                            {
                                if (database.items[j].tileType == item.tileType)
                                {
                                    inventory[i].item = database.items[j];
                                    inventoryCount++; 
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    ////////////////////

                }
            }

        }
        public void PushToBottom()
        {

            bool flag = true;
            ItemStack temp;
            int numLength = inventory.Count;
            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (inventory[j + 1].item.sValue > inventory[j].item.sValue)
                    {
                        temp = inventory[j];
                        inventory[j] = inventory[j + 1];
                        inventory[j + 1] = temp;
                        flag = true;
                    }
                }
            }

        }
        public void RemoveItem(Item item)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].item.tileType == item.tileType)
                {
                    if (inventory[i].count >= 0)
                    {
                        inventory[i].count--;
                        inventoryCount--; 
                        if(inventory[i].count == 0)
                        {
                            inventory[i] = new ItemStack(); 
                        }
                    }

                    break;
                }
            }


        }
        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            
            if (showInventory)
            {

                if (inventoryType == InventoryType.PlayerInventory)
                {
                    int i = 0;

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Rectangle slotRect = new Rectangle(((32 + offSet) * x) + (int)player.position.X - (width * 32) / 2, ((32 + offSet) * y) + (int)player.position.Y - 64, 32, 32);

                            slots[i] = inventory[i];

                            spriteBatch.Draw(inventoryTexture, slotRect, Color.White);
                            if (slots[i].item.tileName != null)
                            {
                                spriteBatch.Draw(slots[i].item.texture, new Vector2(slotRect.X + (slotRect.Width / 4),
                                    slotRect.Y + (slotRect.Height / 4)), Color.White);
                                spriteBatch.DrawString(font, slots[i].count.ToString(), new Vector2(slotRect.X, slotRect.Y), Color.White);


                                if (slotRect.Contains(point))
                                {
                                    //Console.WriteLine(slots[i].item.tileName);
                                    Rectangle toolTipBox = new Rectangle(slotRect.X - 150 + 16, slotRect.Y - 325 , 300, 300);
                                    spriteBatch.Draw(inventoryTexture, toolTipBox, Color.White);
                                    spriteBatch.DrawString(font, slots[i].item.tileName, new Vector2(toolTipBox.X, toolTipBox.Y), Color.White);
                                    spriteBatch.DrawString(font, slots[i].item.tileDescription, new Vector2(toolTipBox.X, toolTipBox.Y + 20), Color.White);

                                    if (mouseState.LeftButton == ButtonState.Pressed)
                                    {
                                        selectedItem = i; 

                                        selectedItem = i;

                                        if (player.tempTile != null)
                                        {
                                            player.tempTile.inventory.AddToInventory(inventory[selectedItem].item, inventory[selectedItem].count);

                                            for (int ic = 0; ic < inventory[selectedItem].count; ic++)
                                            {
                                                RemoveItem(inventory[selectedItem].item);
                                            }
                                        }

                                    }


                                }
                            }

                            i++;
                        }


                    }

                }
                else if (inventoryType == InventoryType.StorageInventory)
                {
                    int i = 0;

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Rectangle slotRect = new Rectangle(((32 + offSet) * x) + (int)player.position.X - (width * 32) / 2 , ((32 + offSet) * y) + (int)player.position.Y - 192, 32, 32);

                            slots[i] = inventory[i];

                            spriteBatch.Draw(inventoryTexture, slotRect, Color.White);
                            if (slots[i].item.tileName != null && slots[i].item.tileType != Tile.TileType.BlankTile)
                            {


                                spriteBatch.Draw(slots[i].item.texture, new Vector2(slotRect.X + (slotRect.Width / 4),
                                        slotRect.Y + (slotRect.Height / 4)), Color.White);
                                spriteBatch.DrawString(font, slots[i].count.ToString(), new Vector2(slotRect.X, slotRect.Y), Color.White);


                                if (slotRect.Contains(point))
                                {
                                    //Console.WriteLine(slots[i].item.tileName);
                                    Rectangle toolTipBox = new Rectangle(slotRect.X - 150 + 16, slotRect.Y - 325, 300, 300);
                                    spriteBatch.Draw(inventoryTexture, toolTipBox, Color.White);
                                    spriteBatch.DrawString(font, slots[i].item.tileName, new Vector2(toolTipBox.X, toolTipBox.Y), Color.White);
                                    spriteBatch.DrawString(font, slots[i].item.tileDescription, new Vector2(toolTipBox.X, toolTipBox.Y + 20), Color.White);

                                    if (mouseState.LeftButton == ButtonState.Pressed)
                                    {

                                        Console.WriteLine("Moving Item");
                                        selectedItem = i;
                                        player.inventory.AddToInventory(inventory[selectedItem].item, inventory[selectedItem].count);

                                        for (int ic = 0; ic < inventory[selectedItem].count; ic++)
                                        {
                                            RemoveItem(inventory[selectedItem].item);
                                        }

                                    }
                                }
                            }

                            i++;
                        }
                    }
                }
            }
        }
    }
}
