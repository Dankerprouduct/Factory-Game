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
        List<Item> myInventory = new List<Item>();

        Texture2D inventoryTexture; 
        int inventorySize; // only multiples of 2
        int width;
        int height;
        int offSet = 5;  
        // TODO move all g craps to just a list of types 
        public Inventory()
        {
            inventorySize = 20;
            width = inventorySize / 2;
            height = inventorySize / 2; 

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
            inventoryTexture = content.Load<Texture2D>("Fonts/DarkGrayBack"); 
        }
        public void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();
            //  itemIndex[9] += 1; 
            if(keyboardState.IsKeyDown(Keys.G) && oldKeyboardState.IsKeyUp(Keys.G))
            {
                showInventory = !showInventory; 
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
        public void AddToInventory(Item item)
        {

            myInventory.Add(item); 
            
        }
        
        public void Draw(SpriteBatch spriteBatch, Player player)
        {

            if (showInventory)
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {

                        spriteBatch.Draw(inventoryTexture, new Vector2(((32 + offSet) * x + player.position.X) + 64,
                            (((32 + offSet) * y  + player.position.Y) - height * 32) - 32), Color.White); 

                    }
                }
            }
        }
    }
}
