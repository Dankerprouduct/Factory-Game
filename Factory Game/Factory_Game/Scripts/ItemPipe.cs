using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework; 

namespace Factory_Game
{
    public static class ItemPipe
    {
        /// <summary>
        /// Up
        /// Down
        /// Left
        /// Right
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="tile"></param>
        /// <param name="game1"></param>
        public static void GetItem(int direction, Tile tile, Game1 game1)
        {
            Game1 game = game1; 
            // Tile North ~ 56
            // Tile East ~ 57
            // Tile South ~ 58
            // Tile West ~ 59
            
            
            
            switch (direction)
            {
                // Up
                case 1:
                    {
                        Tile nTile;
                        nTile = game.tileMap.GetTile(new Vector2(tile.position.X, tile.position.Y - 32));
                        if (nTile != null)
                        {
                            if (tile.index == 56)
                            {
                                if (nTile != null)
                                {
                                    if (nTile.inventory != null && tile.inventory != null)
                                    {
                                        if (nTile.inventory.inventoryCount > 0)
                                        {
                                            if (nTile.inventory.inventory[0].item.tileName != null)
                                            {
                                                tile.inventory.AddToInventory(nTile.inventory.inventory[0].item, 1);
                                                nTile.inventory.RemoveItem(nTile.inventory.inventory[0].item);
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
                // Down
                case 2:
                    {
                        Tile nTile;
                        nTile = game.tileMap.GetTile(new Vector2(tile.position.X, tile.position.Y + 32));
                        if (nTile != null)
                        {
                            if (tile.index == 57)
                            {
                                if (nTile.inventory != null && tile.inventory != null)
                                {
                                    if (nTile.inventory.inventoryCount > 0)
                                    {
                                        if (nTile.inventory.inventory[0].item.tileName != null)
                                        {
                                            tile.inventory.AddToInventory(nTile.inventory.inventory[0].item, 1);
                                            nTile.inventory.RemoveItem(nTile.inventory.inventory[0].item);
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        break; 
                    }
                // Left 
                case 3:
                    {
                        Tile nTile;
                        nTile = game.tileMap.GetTile(new Vector2(tile.position.X - 32, tile.position.Y));
                        if (nTile != null)
                        {
                            if (tile.index == 58)
                            {
                                if (nTile.inventory != null && tile.inventory != null)
                                {
                                    if (nTile.inventory.inventoryCount > 0)
                                    {
                                        if (nTile.inventory.inventory[0].item.tileName != null)
                                        {
                                            tile.inventory.AddToInventory(nTile.inventory.inventory[0].item, 1);
                                            nTile.inventory.RemoveItem(nTile.inventory.inventory[0].item);
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
                // Right
                case 4:
                    {
                        Tile nTile;
                        nTile = game.tileMap.GetTile(new Vector2(tile.position.X + 32, tile.position.Y));
                        if (nTile != null)
                        {
                            if (tile.index == 59)
                            {
                                if (nTile.inventory != null && tile.inventory != null)
                                {
                                    if (nTile.inventory.maxInventoryCount > 0)
                                    {
                                        if (nTile.inventory.inventory[0].item.tileName != null)
                                        {
                                            tile.inventory.AddToInventory(nTile.inventory.inventory[0].item, 1);
                                            nTile.inventory.RemoveItem(nTile.inventory.inventory[0].item);
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
            }

            
        }        
    }
}
