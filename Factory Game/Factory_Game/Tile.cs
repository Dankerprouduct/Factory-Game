using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
namespace Factory_Game
{
    public class Tile
    {
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState; 
        //public List<Texture2D> tiles = new List<Texture2D>();
        Texture2D texture; 
        public Vector2 position;
        public int index;
        // alive - in renderbox
        public bool alive = true;
        Rectangle bounds;
        float durability;
        bool draw = true;

        TimeSpan time = TimeSpan.FromMilliseconds(1000);

        TimeSpan time2;
        public int inventorySpeed = 1500; 
        TimeSpan lastTime;

        QuarryDrill quarryDrill;
        SpriteFont font; 
        public bool madeItemPipe; 
        public bool madeQuarry;
        public bool madeStorage;
        public bool madeSmelter; 
        public Item tempItem;
        public Rectangle sourceRectangle;

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
            StorageCrate,
            CoalBlock,
            CopperTile, 
            IronBlock,
            SandTile,
            Platform1, 
            UraniumBlock
        }
        public enum TileProperty
        {
            CanPass,
            CantPass
        }
        public enum StorageTier
        {
            Tier1,
            Tier2, 
            Tier3
        }

        public StorageTier storageTier; 
        public TileType tileType;
        public TileProperty tileProperty;

        ContentManager contentManager;

        public Inventory inventory;
        public Inventory outPutInventory;
       // ItemDatabase itemDatabase;

        int xPos;
        int yPos;
        bool inInventory = false; 
        public Tile()
        {
            time2 = TimeSpan.FromMilliseconds(inventorySpeed);
            storageTier = new StorageTier(); 
            tileProperty = new TileProperty(); 
            tileType = new TileType(); 
            durability = 10;         }

        public void LoadContent(ContentManager content)
        {
            contentManager = content;

            texture = content.Load<Texture2D>("Tiles/SpriteSheet1"); 
            font = content.Load<SpriteFont>("Fonts/Font2");
           // itemDatabase = new ItemDatabase(content); 
        }

        public void Final() //This is where everything is finalized from tileMap
        {
            xPos = Convert.ToInt32(position.X / 32);
            yPos = Convert.ToInt32(position.Y / 32); 
            bounds = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            #region // Tile Properties 
            switch (index)
            {
                case 0:
                    {
                        alive = false; 
                        tileType = TileType.BlankTile;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 1:
                    {

                        tileType = TileType.DryTile1;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 2:
                    {
                        tileType = TileType.DryTile2;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 3:
                    {
                        tileType = TileType.DryTile3;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 4:
                    {
                        tileType = TileType.Granite1;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 5:
                    {
                        tileType = TileType.Granite2;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 6:
                    {
                        tileType = TileType.Granite3;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 7:
                    {
                        tileType = TileType.Grass1;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 8:
                    {
                        tileType = TileType.Grass2;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 9:
                    {
                        tileType = TileType.Grass3;
                        tileProperty = TileProperty.CantPass; 
                        break;
                    }
                case 11:
                    {
                        tileType = TileType.ConstructionBlock;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 12:
                    {
                        tileType = TileType.MarkerBlock;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 16:
                    {
                        tileType = TileType.ItemPipeNorth;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 17:
                    {
                        tileType = TileType.ItemPipeEast;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 18:
                    {
                        tileType = TileType.ItemPipeSouth;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 19:
                    {
                        tileType = TileType.ItemPipeWest;
                        tileProperty = TileProperty.CantPass; 
                        break;
                    }
                case 20:
                    {
                        tileType = TileType.StorageCrate;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 21:
                    {
                        tileType = TileType.CoalBlock;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 22:
                    {
                        tileType = TileType.CopperTile;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 23:
                    {
                        tileType = TileType.IronBlock;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 24:
                    {
                        tileType = TileType.SandTile;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 25:
                    {
                        tileType = TileType.Platform1;
                        tileProperty = TileProperty.CantPass;
                        break; 
                    }
                case 26:
                    {
                        tileType = TileType.UraniumBlock;
                        tileProperty = TileProperty.CantPass; 
                        break; 
                    }
            }
            #endregion
           sourceRectangle = Animation.SourceRect(tileType) ; 
            
           // Console.WriteLine("Finalized"); 
        }
        public void SetPosition(Vector2 pos)
        {
            
            position = pos;
           // Console.WriteLine(position);
        }
        public void UpdateIndex(TileType tiType) // This is where Tiles are updated if changed
        {
            durability = 10;
            alive = true;
            Console.WriteLine("Updating Index"); 
            switch (tiType)
            {
                case TileType.BlankTile:
                    {
                        tileType = TileType.BlankTile;
                        tileProperty = TileProperty.CanPass;
                        index = 0;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.DryTile1:
                    {
                        tileProperty = TileProperty.CantPass;
                        tileType = TileType.DryTile1;
                        index = 1;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.DryTile2:
                    {
                        tileType = TileType.DryTile2;
                        tileProperty = TileProperty.CantPass;
                        index = 2;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.DryTile3:
                    {
                        tileType = TileType.DryTile3;
                        tileProperty = TileProperty.CantPass;
                        index = 3;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.Granite1:
                    {
                        tileType = TileType.Granite1;
                        tileProperty = TileProperty.CantPass;
                        index = 4;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.Granite2:
                    {
                        tileType = TileType.Granite2;
                        tileProperty = TileProperty.CantPass;
                        index = 5;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.Granite3:
                    {
                        tileType = TileType.Granite3;
                        tileProperty = TileProperty.CantPass;
                        index = 6;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.Grass1:
                    {
                        tileType = TileType.Grass1;
                        tileProperty = TileProperty.CantPass;
                        index = 7;
                        madeStorage = false;
                        madeQuarry = false;
                        madeItemPipe = false; 

                        break;
                    }
                case TileType.Grass2:
                    {
                        tileType = TileType.Grass2;
                        tileProperty = TileProperty.CantPass;
                        index = 8;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 
                        break;
                    }
                case TileType.Grass3:
                    {
                        tileType = TileType.Grass3;
                        tileProperty = TileProperty.CantPass;
                        index = 9;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 

                        break;
                    }
                case TileType.ConstructionBlock:
                    {
                        tileType = TileType.ConstructionBlock;
                        tileProperty = TileProperty.CanPass;
                        index = 11;
                        madeItemPipe = false;
                        madeQuarry = false;
                        madeStorage = false; 

                        break;
                    }
                case TileType.MarkerBlock:
                    {
                        tileType = TileType.MarkerBlock;
                        tileProperty = TileProperty.CanPass; 
                        index = 12;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.ConstructionTube:
                    {
                        tileType = TileType.ConstructionTube;
                        tileProperty = TileProperty.CanPass;
                        index = 13;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.ConstructionDrillBit:
                    {
                        tileType = TileType.ConstructionDrillBit;
                        tileProperty = TileProperty.CanPass; 
                        index = 14;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.QuarryBlock:
                    {
                        tileType = TileType.QuarryBlock;
                        tileProperty = TileProperty.CanPass; 
                        index = 15;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break;
                    }
                case TileType.ItemPipeNorth:
                    {
                        tileType = TileType.ItemPipeNorth;
                        tileProperty = TileProperty.CanPass;
                        index = 16;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break;
                    }
                case TileType.ItemPipeEast:
                    {
                        tileType = TileType.ItemPipeEast;
                        tileProperty = TileProperty.CanPass;
                        index = 17;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break;
                    }
                case TileType.ItemPipeSouth:
                    {
                        tileType = TileType.ItemPipeSouth;
                        tileProperty = TileProperty.CanPass;
                        index = 18;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.ItemPipeWest:
                    {
                        tileType = TileType.ItemPipeWest;
                        tileProperty = TileProperty.CanPass;
                        index = 19;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.StorageCrate:
                    {
                        tileType = TileType.StorageCrate;
                        tileProperty = TileProperty.CanPass;
                        index = 20;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.CoalBlock:
                    {
                        tileType = TileType.CoalBlock;
                        tileProperty = TileProperty.CantPass;
                        index = 21;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.CopperTile:
                    {
                        tileType = TileType.CopperTile;
                        index = 22;
                        tileProperty = TileProperty.CantPass; 
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.IronBlock:
                    {
                        tileType = TileType.IronBlock;
                        tileProperty = TileProperty.CantPass;
                        index = 23;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break;
                    }
                case TileType.Platform1:
                    {
                        tileType = TileType.Platform1;
                        tileProperty = TileProperty.CantPass;
                        index = 25;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false;
                        break; 
                    }
                case TileType.SandTile:
                    {
                        tileType = TileType.SandTile;
                        tileProperty = TileProperty.CantPass;
                        index = 24;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                case TileType.UraniumBlock:
                    {
                        tileType = TileType.UraniumBlock;
                        tileProperty = TileProperty.CantPass;
                        index = 26;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false; 
                        break; 
                    }
                
            }
            sourceRectangle = Animation.SourceRect(tileType); 
            
        }
        public void DamageTile(float amount)
        {
            Console.WriteLine("Damaging Tiles"); 
            durability -= amount; 
        }

        #region // Updates
        public void Update(GameTime gameTime, Player player)
        {
             Console.WriteLine(bounds); 
            if (bounds.Intersects(player.rect) && tileProperty == TileProperty.CantPass)
            {
                Console.WriteLine("collision"); 
                player.Collision(bounds);
            }
            if (alive)
            {
                if (draw)
                {
                    if(bounds.Intersects(player.rect) && tileProperty == TileProperty.CantPass)
                    {
                        player.Collision(bounds); 
                    }
                }
            }
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
                    else if (tileType == TileType.StorageCrate)
                    {

                        if (bounds.Intersects(player.rect))
                        {
                            keyboardState = Keyboard.GetState();
                            if (keyboardState.IsKeyDown(Keys.F) && oldKeyboardState.IsKeyUp(Keys.F))
                            {
                                inInventory = !inInventory;
                                inventory.showInventory = !inventory.showInventory;
                                if (inInventory)
                                {
                                    player.tempTile = this;
                                }
                                else
                                {
                                    player.tempTile = null;
                                }
                            }
                            oldKeyboardState = keyboardState;
                        }
                        else
                        {
                            if (madeStorage)
                            {
                                inventory.showInventory = false;
                                //player.tempTile = null; 
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

                        if (madeStorage)
                        {
                            inventory.Update(gameTime, game);
                        }
                        if (madeQuarry)
                        {
                            inventory.Update(gameTime, game);
                        }
                        if (this.tileType == TileType.QuarryBlock)
                        {
                            Quarry(tileMap, gameTime, game);
                        }
                        if (lastTime + time2 < gameTime.TotalGameTime)
                        {
                            if (this.tileType == TileType.ItemPipeNorth)
                            {
                                ItemPipe(tileMap, gameTime);
                            }
                            if (this.tileType == TileType.ItemPipeEast)
                            {
                                ItemPipe(tileMap, gameTime);
                            }
                            if (this.tileType == TileType.ItemPipeSouth)
                            {
                                ItemPipe(tileMap, gameTime);
                            }
                            if (this.tileType == TileType.ItemPipeWest)
                            {
                                ItemPipe(tileMap, gameTime);
                            }
                        }
                        if (this.tileType == TileType.StorageCrate)
                        {
                            ItemStorage(tileMap, gameTime);
                        }


                    }
                }
                if (!alive)
                {
                    index = 0;
                    tileType = TileType.BlankTile;
                    sourceRectangle = Animation.SourceRect(tileType); 
                }

                if (tileType == TileType.QuarryBlock)
                {
                    if (madeQuarry)
                    {
                        if (lastTime + time < gameTime.TotalGameTime)
                        {
                            lastTime = gameTime.TotalGameTime;
                        }
                        quarryDrill.Update(gameTime, game);
                    }
                }

            }
        }


        public void Quarry(TileMap tileMap, GameTime gameTime, Game1 game)
        {
            if (!madeQuarry)
            {
                
                int offSet = 3; 
                // 100
                int searchRadius = 20; 
                int height = 8;
                inventory = new Inventory();
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                inventory.LoadContent(contentManager);
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                #region 

                if (tileMap.tile[xPos + 1, yPos].tileType == TileType.MarkerBlock)
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
                   // game.quarryManagement.threads.Add(new Thread(new ThreadStart())); 
                    madeQuarry = true;
                }
                #endregion

                
                
            }
        }


        public void ItemPipe(TileMap tileMap, GameTime gameTime)
        {

            if (!madeItemPipe)
            {
                inventory = new Inventory();
                inventory.inventoryType = Inventory.InventoryType.TubeInventory; 
                inventory.LoadContent(contentManager); 
                madeItemPipe = true; 
            }

            switch (tileType)
            {
                case TileType.ItemPipeNorth:
                    {
                        // checks south tile
                        Tile checkedTile = tileMap.tile[xPos, yPos + 1]; 
                        if (checkedTile.tileType == TileType.QuarryBlock)
                        {
                            if (checkedTile.madeQuarry)
                            {
                                //tempItem = checkedTile.inventory.inventory[0].item;
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        // put max inventory
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }

                        }
                        else if (checkedTile.tileType == TileType.ItemPipeNorth)
                        {
                            //error placing tile when nothing below it
                            if (checkedTile.madeItemPipe)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        else if(checkedTile.tileType == TileType.StorageCrate)
                        {
                            if (checkedTile.madeStorage)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
                case TileType.ItemPipeEast:
                    {
                        Tile checkedTile = tileMap.tile[xPos - 1, yPos]; 
                        if(checkedTile.tileType == TileType.QuarryBlock)
                        {
                            if (checkedTile.madeQuarry)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        else if(checkedTile.tileType == TileType.ItemPipeEast)
                        {
                            if (checkedTile.madeItemPipe)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        else if(checkedTile.tileType == TileType.StorageCrate)
                        {
                            if (checkedTile.madeStorage)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        break; 
                    }
                case TileType.ItemPipeSouth:
                    {
                        Tile checkedTile = tileMap.tile[xPos, yPos - 1]; 
                    
                        if(checkedTile.tileType == TileType.QuarryBlock)
                        {
                            if (checkedTile.madeQuarry)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }

                                    }
                                }
                            }
                        }
                        if(checkedTile.tileType == TileType.ItemPipeSouth)
                        {
                            if (checkedTile.madeItemPipe)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        if(checkedTile.tileType == TileType.StorageCrate)
                        {
                            if (checkedTile.madeStorage)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    }
                case TileType.ItemPipeWest:
                    {
                        Tile checkedTile = tileMap.tile[xPos + 1, yPos];

                        if (checkedTile.tileType == TileType.QuarryBlock)
                        {
                            if (checkedTile.madeQuarry)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        else if(checkedTile.tileType == TileType.ItemPipeWest)
                        {
                            if (checkedTile.madeItemPipe)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        else if(checkedTile.tileType == TileType.StorageCrate)
                        {
                            if (checkedTile.madeStorage)
                            {
                                if (checkedTile.inventory.inventoryCount > 0)
                                {
                                    if (checkedTile.inventory.inventory[0].item.tileName != null)
                                    {
                                        if (inventory.inventoryCount < inventory.maxInventoryCount)
                                        {
                                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                                        }
                                    }
                                }
                            }
                        }
                        break; 
                    }
            }
        }
        
        public void ItemStorage(TileMap tileMap, GameTime gameTime)
        {
            if (!madeStorage)
            {
                inventory = new Inventory();
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                inventory.LoadContent(contentManager);
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                Console.WriteLine("Made storage"); 
                madeStorage = true; 
            }

            Tile checkedTile;
            // North
            checkedTile = tileMap.tile[xPos, yPos - 1];
            if (checkedTile.madeItemPipe)
            {
                if (checkedTile.tileType == TileType.ItemPipeSouth)
                {


                    if (checkedTile.inventory.inventoryCount > 0)
                    {
                        if (checkedTile.inventory.inventory[0].item != null && checkedTile.inventory.inventory[0].item.tileType != TileType.BlankTile)
                        {
                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                        }
                    }
                }
            }
            // South
            checkedTile = tileMap.tile[xPos, yPos + 1];
            if (checkedTile.madeItemPipe)
            {
                if (checkedTile.tileType == TileType.ItemPipeNorth)
                {

                    if (checkedTile.inventory.inventoryCount > 0)
                    {
                        if (checkedTile.inventory.inventory[0].item != null && checkedTile.inventory.inventory[0].item.tileType != TileType.BlankTile)
                        {
                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                        }
                    }
                }
            }
            // East
            checkedTile = tileMap.tile[xPos + 1, yPos];
            if (checkedTile.madeItemPipe)
            {
                if (checkedTile.tileType == TileType.ItemPipeWest)
                {

                    if (checkedTile.inventory.inventoryCount > 0)
                    {
                        if (checkedTile.inventory.inventory[0].item != null && checkedTile.inventory.inventory[0].item.tileType != TileType.BlankTile)
                        {
                            inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                            checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                        }
                    }
                }
            }
            // West
            checkedTile = tileMap.tile[xPos - 1, yPos];
            if (checkedTile.madeItemPipe)
            {
                if (checkedTile.tileType == TileType.ItemPipeEast)
                {

                    if (checkedTile.inventory.inventory[0].item != null && checkedTile.inventory.inventory[0].item.tileType != TileType.BlankTile)
                    {
                        if (checkedTile.inventory.inventoryCount > 0)
                        {
                            if (checkedTile.inventory.inventory[0].item != null)
                            {
                                inventory.AddToInventory(checkedTile.inventory.inventory[0].item, 1);
                                checkedTile.inventory.RemoveItem(checkedTile.inventory.inventory[0].item);
                            }
                        }

                    }
                }
            }
        }

        #endregion 


        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            draw = true;
           // sourceRectangle = Animation.SourceRect(TileType.DryTile1);
            if (draw)
            {
                spriteBatch.Draw(texture, position, sourceRectangle,Color.White);
                //Console.WriteLine("Drawing!"); 
               //spriteBatch.DrawString(font, (position.X / 32).ToString(), position, Color.White); 
                if (this.tileType == TileType.QuarryBlock)
                {
                    if (madeQuarry)
                    {
                        inventory.Draw(spriteBatch, player); 
                        quarryDrill.Draw(spriteBatch);
                    }
                }
                if(this.tileType == TileType.StorageCrate)
                {
                    if (madeStorage)
                    {
                        inventory.Draw(spriteBatch, player); 
                    }
                }
                if(this.tileType == TileType.ItemPipeNorth || tileType == TileType.ItemPipeEast || tileType == TileType.ItemPipeSouth || tileType == TileType.ItemPipeWest)
                {
                  //  inventory.Draw(spriteBatch, player); 
                }
            }
        }
    }
}
