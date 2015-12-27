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

        // TODO move all g craps to just a list of types 
        public Inventory()
        {
            itemIndex.Add(0); //  Dirt Tile 1 
            itemIndex.Add(0); //  Dirt Tile 2
            itemIndex.Add(0); //  Dirt Tile 3
            itemIndex.Add(0); //  Granite Tile 1
            itemIndex.Add(0); //  Granite Tile 2
            itemIndex.Add(0); //  Granite Tile 3
            itemIndex.Add(0); //  Grass Tile 1
            itemIndex.Add(0); //  Grass Tile 2
            itemIndex.Add(0); //  Grass Tile 3
               
        }
        public void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();

            if(keyboardState.IsKeyDown(Keys.E) && oldKeyboardState.IsKeyUp(Keys.E))
            {
                
                selectedItem++; 
                if(selectedItem > 8)
                {
                    selectedItem = 0; 
                    
                }
            }

            oldKeyboardState = keyboardState; 
        }
        public void AddToInventory(Tile.TileType type, int ammount)
        {
            switch (type)
            {
                case Tile.TileType.DryTile1:
                    {
                        itemIndex[0] += ammount; 
                        break; 
                    }
                case Tile.TileType.DryTile2:
                    {
                        itemIndex[1] += ammount;
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        itemIndex[2] += ammount;
                        break; 
                    }
                case Tile.TileType.Granite1:
                    {
                        itemIndex[3] += ammount;
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        itemIndex[4] += ammount;
                        break; 
                    }
                case Tile.TileType.Granite3:
                    {
                        itemIndex[5] += ammount;
                        break; 
                    }
                case Tile.TileType.Grass1:
                    {
                        itemIndex[6] += ammount;
                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        itemIndex[7] += ammount;
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        itemIndex[8] += ammount;
                        break; 
                    }
            }
        }
    }
}
