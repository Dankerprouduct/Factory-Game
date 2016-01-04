using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class Tile
    {
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState; 
        public List<Texture2D> tiles = new List<Texture2D>();
        public Vector2 position;
        public int index;
        // alive - in renderbox
        public bool alive = true;
        Rectangle bounds;
        float durability;
        bool draw = true;
        Vector2 worldPosition;

        TimeSpan time = TimeSpan.FromMilliseconds(1000);
        TimeSpan lastTime;

        QuarryDrill quarryDrill; 

        bool madeQuarry;
        public Item tempItem;

        public enum TileType
        {
            BlankTile, 
            DryTile1,
            DryTile2,
            DryTile3,
            Granite1,
            Granite2,
            Granite3,
            Grass1, 
            Grass2, 
            Grass3,
            Water,
            ConstructionBlock,
            MarkerBlock,
            ConstructionTube,
            ConstructionDrillBit,
            QuarryBlock,
            ItemPipeNorth,
            ItemPipeEast, 
            ItemPipeSouth, 
            ItemPipeWest,
            ItemStorage
        }
        public enum TileProperty
        {
            CanPass,
            CantPass
        }
        public TileType tileType;
        public TileProperty tileProperty;

        ContentManager contentManager;

        public Inventory inventory; 

        int xPos;
        int yPos; 
        public Tile()
        {
            tileProperty = new TileProperty(); 
            tileType = new TileType(); 
            durability = 10; 
        }
        public void LoadContent(ContentManager content)
        {
            contentManager = content; 
            tiles.Add(content.Load<Texture2D>("Tiles/BlankTile")); // 0
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile1")); // 1
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile2")); // 2
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile3")); // 3 
            tiles.Add(content.Load<Texture2D>("Tiles/Granite1")); // 4
            tiles.Add(content.Load<Texture2D>("Tiles/Granite2")); // 5
            tiles.Add(content.Load<Texture2D>("Tiles/Granite3")); // 6
            tiles.Add(content.Load<Texture2D>("Tiles/Grass1"));   // 7
            tiles.Add(content.Load<Texture2D>("Tiles/Grass2"));   // 8
            tiles.Add(content.Load<Texture2D>("Tiles/Grass3"));   // 9
            tiles.Add(content.Load<Texture2D>("Tiles/Water1"));   // 10
            tiles.Add(content.Load<Texture2D>("Tiles/ConstructionBlock")); // 11
            tiles.Add(content.Load<Texture2D>("Tiles/MarkerBlock")); // 12
            tiles.Add(content.Load<Texture2D>("Tiles/ConstructionDrillBit")); // 13
            tiles.Add(content.Load<Texture2D>("Tiles/ConstructionTube")); // 14
            tiles.Add(content.Load<Texture2D>("Tiles/QuarryBlock")); // 15
            tiles.Add(content.Load<Texture2D>("Tiles/NorthTube")); //16
            tiles.Add(content.Load<Texture2D>("Tiles/EastTube")); // 17
            tiles.Add(content.Load<Texture2D>("Tiles/SouthTube")); //18
            tiles.Add(content.Load<Texture2D>("Tiles/WestTube")); //19
            
        }

        public void Final() //This is where everything is finalized from tileMap
        {
            xPos = Convert.ToInt32(position.X / 32);
            yPos = Convert.ToInt32(position.Y / 32); 
            bounds = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            if(index == 0)
            {
                alive = false;
                tileProperty = TileProperty.CanPass; 
            }
            else if(index == 11)
            {
                tileProperty = TileProperty.CanPass; 
            }
            else if (index == 12)
            {
                tileProperty = TileProperty.CanPass;
            }
            else if(index == 13)
            {
                tileProperty = TileProperty.CanPass;
            }
            else if(index == 14)
            {
                tileProperty = TileProperty.CanPass; 
            }
            else if(index == 15)
            {
                tileProperty = TileProperty.CanPass; 
            }
            else if(index == 16)
            {
                tileProperty = TileProperty.CanPass;
            }
            else if(index == 17)
            {
                tileProperty = TileProperty.CanPass;
            }
            else if(index == 18)
            {
                tileProperty = TileProperty.CanPass; 
            }
            else if(index == 19)
            {
                tileProperty = TileProperty.CanPass;
            }
            else
            {
                tileProperty = TileProperty.CantPass; 
            }
            switch (index)
            {
                case 0:
                    {
                        tileType = TileType.BlankTile; 
                        break;
                    }
                case 1:
                    {

                        tileType = TileType.DryTile1; 
                        break; 
                    }
                case 2:
                    {
                        tileType = TileType.DryTile2;
                        break; 
                    }
                case 3:
                    {
                        tileType = TileType.DryTile3;
                        break;
                    }
                case 4:
                    {
                        tileType = TileType.Granite1;
                        break;
                    }
                case 5:
                    {
                        tileType = TileType.Granite2;
                        break; 
                    }
                case 6:
                    {
                        tileType = TileType.Granite3;
                        break;
                    }
                case 7:
                    {
                        tileType = TileType.Grass1;
                        break;
                    }
                case 8:
                    {
                        tileType = TileType.Grass2;
                        break;
                    }
                case 9:
                    {
                        tileType = TileType.Grass3;
                        break;
                    }
                case 11:
                    {
                        tileType = TileType.ConstructionBlock;
                        break;
                    }
                case 12:
                    {
                        tileType = TileType.MarkerBlock;
                        break;
                    }
                case 16:
                    {
                        tileType = TileType.ItemPipeNorth;
                        break;
                    }
                case 17:
                    {
                        tileType = TileType.ItemPipeEast;
                        break;
                    }
                case 18:
                    {
                        tileType = TileType.ItemPipeSouth;
                        break;
                    }
                case 19:
                    {
                        tileType = TileType.ItemPipeWest;
                        break;
                    }
            }

        }
        public void UpdateIndex(TileType tiType) // This is where Tiles are updated if changed
        {
            durability = 10;
            alive = true;

            switch (tiType)
            {
                case TileType.BlankTile:
                    {
                        tileType = TileType.BlankTile;
                        tileProperty = TileProperty.CanPass;
                        index = 0;
                        break;
                    }
                case TileType.DryTile1:
                    {
                        tileProperty = TileProperty.CantPass;
                        tileType = TileType.DryTile1;
                        index = 1; 
                        break;
                    }
                case TileType.DryTile2:
                    {
                        tileType = TileType.DryTile2;
                        tileProperty = TileProperty.CantPass;
                        index = 2; 
                        break;
                    }
                case TileType.DryTile3:
                    {
                        tileType = TileType.DryTile3;
                        tileProperty = TileProperty.CantPass;
                        index = 3;
                        break;
                    }
                case TileType.Granite1:
                    {
                        tileType = TileType.Granite1;
                        tileProperty = TileProperty.CantPass;
                        index = 4; 
                        break;
                    }
                case TileType.Granite2:
                    {
                        tileType = TileType.Granite2;
                        tileProperty = TileProperty.CantPass;
                        index = 5; 
                        break;
                    }
                case TileType.Granite3:
                    {
                        tileType = TileType.Granite3;
                        tileProperty = TileProperty.CantPass;
                        index = 6; 
                        break;
                    }
                case TileType.Grass1:
                    {
                        tileType = TileType.Grass1;
                        tileProperty = TileProperty.CantPass;
                        index = 7; 
                        break;
                    }
                case TileType.Grass2:
                    {
                        tileType = TileType.Grass2;
                        tileProperty = TileProperty.CantPass;
                        index = 8; 
                        break;
                    }
                case TileType.Grass3:
                    {
                        tileType = TileType.Grass3;
                        tileProperty = TileProperty.CantPass;
                        index = 9; 
                        break;
                    }
                case TileType.ConstructionBlock:
                    {
                        tileType = TileType.ConstructionBlock;
                        tileProperty = TileProperty.CanPass;
                        index = 11; 
                        break;
                    }
                case TileType.MarkerBlock:
                    {
                        tileType = TileType.MarkerBlock;
                        tileProperty = TileProperty.CanPass; 
                        index = 12; 
                        break; 
                    }
                case TileType.ConstructionTube:
                    {
                        tileType = TileType.ConstructionTube;
                        tileProperty = TileProperty.CanPass;
                        index = 13; 
                        break; 
                    }
                case TileType.ConstructionDrillBit:
                    {
                        tileType = TileType.ConstructionDrillBit;
                        tileProperty = TileProperty.CanPass; 
                        index = 14;
                        break; 
                    }
                case TileType.QuarryBlock:
                    {
                        tileType = TileType.QuarryBlock;
                        tileProperty = TileProperty.CanPass; 
                        index = 15; 
                        break;
                    }
                case TileType.ItemPipeNorth:
                    {
                        tileType = TileType.ItemPipeNorth;
                        tileProperty = TileProperty.CanPass;
                        index = 16;
                        break;
                    }
                case TileType.ItemPipeEast:
                    {
                        tileType = TileType.ItemPipeEast;
                        tileProperty = TileProperty.CanPass;
                        index = 17;
                        break;
                    }
                case TileType.ItemPipeSouth:
                    {
                        tileType = TileType.ItemPipeNorth;
                        tileProperty = TileProperty.CanPass;
                        index = 18;
                        break; 
                    }
                case TileType.ItemPipeWest:
                    {
                        tileType = TileType.ItemPipeWest;
                        tileProperty = TileProperty.CanPass;
                        index = 19;
                        break; 
                    }
                
            }

            
        }
        public void DamageTile(float amount)
        {
            durability -= amount; 
        }
        public void Update(GameTime gameTime, Player player, Game1 game, TileMap tileMap)
        {
           
            if (alive)
            {
                if (draw)
                {
                    if (bounds.Intersects(player.rect) && tileProperty == TileProperty.CantPass)
                    {
                        player.Collision(bounds);
                      //  player.j = 1f;
                        // alive = false; 
                        if (player.canBreak)
                        {
                            alive = false;
                        }

                    }
                    if (tileType == TileType.QuarryBlock)
                    {

                        if (bounds.Intersects(player.rect))
                        {
                            keyboardState = Keyboard.GetState();
                            if (keyboardState.IsKeyDown(Keys.F) && oldKeyboardState.IsKeyUp(Keys.F))
                            {
                                inventory.showInventory = !inventory.showInventory;
                            }
                            oldKeyboardState = keyboardState;
                        }
                        else
                        {
                            if (madeQuarry)
                            {
                                inventory.showInventory = false;
                            }
                        }
                    }

                    for (int i = 0; i < game.tileObjectManagement.tileObjects.Count; i++)
                    {
                        if (bounds.Intersects(game.tileObjectManagement.tileObjects[i].rect) && index != 0)
                        {
                            game.tileObjectManagement.tileObjects[i].velocity.Y = 0;
                            game.tileObjectManagement.tileObjects[i].position.Y -= 2;
                          //  Console.WriteLine("i tried");
                        }
                        else if (bounds.Intersects(game.tileObjectManagement.tileObjects[i].rect) && index != 11)
                        {
                            game.tileObjectManagement.tileObjects[i].velocity.Y = 0;
                            game.tileObjectManagement.tileObjects[i].position.Y -= 2;
                            //  Console.WriteLine("i tried");
                        }
                        else if (bounds.Intersects(game.tileObjectManagement.tileObjects[i].rect) && index != 12)
                        {
                            game.tileObjectManagement.tileObjects[i].velocity.Y = 0;
                            game.tileObjectManagement.tileObjects[i].position.Y -= 2;
                            //  Console.WriteLine("i tried");
                        }
                    }
                    if (game.quarryManagement.drills.Count > 0)
                    {
                        for (int i = 0; i < game.quarryManagement.drills.Count; i++)
                        {
                            if (bounds.Intersects(game.quarryManagement.drills[i].rect))
                            {
                                durability = 0; 
                            }
                        }
                    }
                    if (alive)
                    {
                        if (durability <= 0)
                        {

                            // worldPosition = Vector2.Transform(position, Matrix.Invert(game.camera.rawTransform)); 
                            game.tileObjectManagement.AddTileObject(new Vector2(position.X + (bounds.Width / 4), position.Y + (bounds.Height / 4)), tileType);
                            alive = false;
                        }

                        if(this.tileType == TileType.QuarryBlock)
                        {
                            Quarry(tileMap, gameTime, game); 
                        }

                    }
                }
            }
            if (!alive)
            {
                index = 0;
                tileType = TileType.BlankTile; 
            }

            if(tileType == TileType.QuarryBlock)
            {
                if (madeQuarry)
                {
                    if(lastTime + time < gameTime.TotalGameTime)
                    {
                        lastTime = gameTime.TotalGameTime;
                    }
                    quarryDrill.Update(gameTime, game);
                }
            }
            
        }

        public void Quarry(TileMap tileMap, GameTime gameTime, Game1 game)
        {
            if (!madeQuarry)
            {
                
                int offSet = 3; 
                int searchRadius = 100; 
                int height = 8;
                inventory = new Inventory();
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                inventory.LoadContent(contentManager);
                
                #region 
                if (tileMap.tile[xPos - 1, yPos].tileType == TileType.MarkerBlock)
                {

                    for (int i = 2; i < searchRadius; i++)
                    {
                        if (tileMap.tile[xPos - i, yPos].tileType == TileType.MarkerBlock)
                        {
                            offSet = i;
                            i = searchRadius;
                            break;
                        }

                    }
                    tileMap.tile[xPos - 1, yPos].UpdateIndex(TileType.ConstructionBlock);
                    tileMap.tile[xPos - offSet, yPos].UpdateIndex(TileType.ConstructionBlock);

                    for (int y = 1; y < height; y++)
                    {

                        tileMap.tile[xPos - 1, yPos - y].UpdateIndex(TileType.ConstructionBlock);
                        tileMap.tile[xPos - offSet, yPos - y].UpdateIndex(TileType.ConstructionBlock);
                    }

                    for (int x = 0; x < offSet; x++)
                    {
                        tileMap.tile[xPos - x - 1, yPos - height].UpdateIndex(TileType.ConstructionBlock);
                    }
                    quarryDrill = new QuarryDrill(xPos - 2, yPos + 1, xPos - offSet + 1, yPos - 1, height, tileMap, this);

                    quarryDrill.LoadContent(contentManager);
                    game.quarryManagement.drills.Add(quarryDrill); 
                    madeQuarry = true;


                }
                else if (tileMap.tile[xPos + 1, yPos].tileType == TileType.MarkerBlock)
                {

                    for (int i = 2; i < searchRadius; i++)
                    {
                        if (tileMap.tile[xPos + i, yPos].tileType == TileType.MarkerBlock)
                        {
                            offSet = i;
                            i = searchRadius;
                            break;
                        }

                    }
                    tileMap.tile[xPos + 1, yPos].UpdateIndex(TileType.ConstructionBlock);
                    tileMap.tile[xPos + offSet, yPos].UpdateIndex(TileType.ConstructionBlock);

                    for (int y = 1; y < height; y++)
                    {
                        tileMap.tile[xPos + 1, yPos - y].UpdateIndex(TileType.ConstructionBlock);
                        tileMap.tile[xPos + offSet, yPos - y].UpdateIndex(TileType.ConstructionBlock);
                    }

                    for (int x = 0; x < offSet; x++)
                    {
                        tileMap.tile[xPos + x + 1, yPos - height].UpdateIndex(TileType.ConstructionBlock);
                    }
                    quarryDrill = new QuarryDrill(xPos + 2, yPos + 1, xPos + offSet - 1, yPos - 1,height, tileMap, this);

                    quarryDrill.LoadContent(contentManager);
                    game.quarryManagement.drills.Add(quarryDrill);
                    madeQuarry = true;
                }
                #endregion

                
                
            }
        }

        public void ItemPipe(TileMap tileMap)
        {
            switch (tileType)
            {
                case TileType.ItemPipeNorth:
                    {
                        // TODO: change tempitem to a global varible to be accessed by other pipes
                        Tile checkedTile = tileMap.tile[xPos, yPos - 1]; 
                        if (checkedTile.tileType == TileType.QuarryBlock)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem);
                        }
                        else if (checkedTile.tileType == TileType.ItemPipeNorth)
                        {
                            tempItem = checkedTile.tempItem; 
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        else if(checkedTile.tileType == TileType.ItemStorage)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        break;
                    }
                case TileType.ItemPipeEast:
                    {
                        Tile checkedTile = tileMap.tile[xPos - 1, yPos]; 
                        if(checkedTile.tileType == TileType.QuarryBlock)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        else if(checkedTile.tileType == TileType.ItemPipeEast)
                        {
                            tempItem = checkedTile.tempItem; 
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        else if(checkedTile.tileType == TileType.ItemStorage)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        break; 
                    }
                case TileType.ItemPipeSouth:
                    {
                        Tile checkedTile = tileMap.tile[xPos, yPos + 1]; 
                    
                        if(checkedTile.tileType == TileType.QuarryBlock)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        else if(checkedTile.tileType == TileType.ItemPipeSouth)
                        {
                            tempItem = checkedTile.tempItem; 
                            checkedTile.inventory.RemoveItem(tempItem);
                        }
                        else if(checkedTile.tileType == TileType.ItemPipeSouth)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        break;
                    }
                case TileType.ItemPipeWest:
                    {
                        Tile checkedTile = tileMap.tile[xPos - 1, yPos];
                        if (checkedTile.tileType == TileType.QuarryBlock)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        else if(checkedTile.tileType == TileType.ItemPipeWest)
                        {
                            tempItem = checkedTile.tempItem; 
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        else if(checkedTile.tileType == TileType.ItemStorage)
                        {
                            tempItem = checkedTile.inventory.inventory[0].item;
                            checkedTile.inventory.RemoveItem(tempItem); 
                        }
                        break; 
                    }
            }
        }
        
        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            
            if (draw)
            {
                spriteBatch.Draw(tiles[index], position, Color.White);
                //Console.WriteLine("Drawing!"); 

                if (this.tileType == TileType.QuarryBlock)
                {
                    if (madeQuarry)
                    {
                        inventory.Draw(spriteBatch, player); 
                        quarryDrill.Draw(spriteBatch);
                    }
                }
            }
        }
    }
}
