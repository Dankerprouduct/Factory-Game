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
        public int dT1;
        public int dT2;
        public int dT3;
        public int gT1;
        public int gT2;
        public int gT3;
        public int gR1;
        public int gR2;
        public int gR3;
        public int selectedItem = 1;
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;

        // TODO move all g craps to just a list of types 
        public Inventory()
        {
            dT1 = 0;
            dT2 = 0;
            dT3 = 0;
            gT1 = 0;
            gT2 = 0;
            gT3 = 0;
            gR1 = 0;
            gR2 = 0;
            gR3 = 0; 
            
        }
        public void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();

            if(keyboardState.IsKeyDown(Keys.E) && oldKeyboardState.IsKeyUp(Keys.E))
            {
                
                selectedItem++; 
                if(selectedItem > 9)
                {
                    selectedItem = 1; 
                    
                }
                switch (selectedItem)
                {
                    case 1:
                        {
                            if(dT1 > 0)
                            {
                              //  dT1--; 
                            }
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break; 
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            break;
                        }
                    case 9:
                        {
                            break;
                        }
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
                        dT1 += ammount; 
                        break; 
                    }
                case Tile.TileType.DryTile2:
                    {
                        dT2 += ammount;
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        dT3 += ammount;
                        break; 
                    }
                case Tile.TileType.Granite1:
                    {
                        gT1 += ammount;
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        gT2 += ammount;
                        break; 
                    }
                case Tile.TileType.Granite3:
                    {
                        gT3 += ammount;
                        break; 
                    }
                case Tile.TileType.Grass1:
                    {
                        gR1 += ammount;
                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        gR2 += ammount;
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        gR3 += ammount;
                        break; 
                    }
            }
        }
    }
}
