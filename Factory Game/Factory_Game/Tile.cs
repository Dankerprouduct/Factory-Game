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
        public float light = 1; 
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
            UraniumBlock,
            RedWire1,
            RedWire2,
            GreenWire1,
            GreenWire2,
            GoldWire1,
            GoldWire2
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

        public int xPos;
        public int yPos;
        public int localxPos;
        public int localyPos;
        public int chunkX;
        public int chunkY; 
        bool inInventory = false; 
        
        public Tile()
        {
            time2 = TimeSpan.FromMilliseconds(inventorySpeed);
            storageTier = new StorageTier(); 
            tileProperty = new TileProperty(); 
            tileType = new TileType(); 
            durability = 10;

        }

        public void LoadContent(ContentManager content)
        {
            contentManager = content;

            texture = content.Load<Texture2D>("Tiles/Tile_SpriteSheet"); 
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
                case 27:
                    {
                        tileType = TileType.RedWire2;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 28:
                    {
                        tileType = TileType.RedWire2;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 29:
                    {
                        tileType = TileType.GreenWire2;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 30:
                    {
                        tileType = TileType.GreenWire2;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 31:
                    {
                        tileType = TileType.GoldWire2;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 32:
                    {
                        tileType = TileType.GoldWire2;
                        tileProperty = TileProperty.CanPass;
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
                case TileType.RedWire1:
                    {
                        tileType = TileType.RedWire2;
                        tileProperty = TileProperty.CanPass;
                        index = 27;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false;
                        break;
                    }
                case TileType.RedWire2:
                    {
                        tileType = TileType.RedWire2;
                        tileProperty = TileProperty.CanPass;
                        index = 28;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false;
                        break;
                    }
                case TileType.GreenWire1:
                    {
                        tileType = TileType.GreenWire2;
                        tileProperty = TileProperty.CanPass;
                        index = 29;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false;
                        break;
                    }
                case TileType.GreenWire2:
                    {
                        tileType = TileType.GreenWire2;
                        tileProperty = TileProperty.CanPass;
                        index = 30;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false;
                        break;
                    }
                case TileType.GoldWire1:
                    {
                        tileType = TileType.GoldWire2;
                        tileProperty = TileProperty.CanPass;
                        index = 31;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false;
                        break;
                    }
                case TileType.GoldWire2:
                    {
                        tileType = TileType.GoldWire2;
                        tileProperty = TileProperty.CanPass;
                        index = 32;
                        madeItemPipe = false;
                        madeStorage = false;
                        madeQuarry = false;
                        break;
                    }


            }
            sourceRectangle = Animation.SourceRect(tileType); 
            
        }
        // 51
        Color lightColor;
        public float lightLevel; 
        public void DamageTile(float amount)
        {
           // Console.WriteLine("Damaging Tiles"); 
            durability -= amount; 
        }

        #region // Updates

        public void Update(GameTime gameTime, Player player, Game1 game, Chunk tileMap)
        {

            
            
            if (alive)
            {
                                
                if (draw)
                {

                    if (game.tileObjectManagement.tileObjects.Count > 0)
                    {
                        TileEntityCollision(game);
                    }

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
                                ItemPipe(tileMap, gameTime, game);
                            }
                            if (this.tileType == TileType.ItemPipeEast)
                            {
                                ItemPipe(tileMap, gameTime, game);
                            }
                            if (this.tileType == TileType.ItemPipeSouth)
                            {
                                ItemPipe(tileMap, gameTime, game);
                            }
                            if (this.tileType == TileType.ItemPipeWest)
                            {
                                ItemPipe(tileMap, gameTime, game);
                            }
                        }
                        
                        if (this.tileType == TileType.StorageCrate)
                        {
                             
                             ItemStorage(tileMap, gameTime, game);
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
                        // comented
                        quarryDrill.Update(gameTime, game);
                    }
                }

            }
        }

        public void TileEntityCollision(Game1 game)
        {
            // Tile Entities
            for (int i = 0; i < game.tileObjectManagement.tileObjects.Count; i++)
            {
                
                if (bounds.Intersects(game.tileObjectManagement.tileObjects[i].rect))
                {
                    if (tileType != TileType.BlankTile || tileType != TileType.MarkerBlock || tileType != TileType.ConstructionBlock)
                    {
                        game.tileObjectManagement.tileObjects[i].velocity.Y = 0;
                        game.tileObjectManagement.tileObjects[i].position.Y -= 1f;
                        //  Console.WriteLine("i tried");
                    }
                }
                

            }
        }
                                
        public void Quarry(Chunk chunk, GameTime gameTime, Game1 game)
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

                int qTileX;
                int qTileY;
                int qChunkX;
                int qChunkY; 
                #region 

                if (chunk.tiles[localxPos + 1, localyPos].tileType == TileType.MarkerBlock)
                {
                    Vector2 pos;
                    for (int i = 2; i < searchRadius; i++)
                    {
                        pos = new Vector2(position.X + (i * 32), position.Y); 
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY;
                        Console.WriteLine("Tile X: "+qTileX+" Tile Y:" + qTileY +" ChunkX:" + qChunkX + " ChunkY:"+ qChunkY);
                        if (game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].tileType == TileType.MarkerBlock)
                        {
                             
                            offSet = i;
                            i = searchRadius;
                            Console.WriteLine("Quarry Made");
                            break;
                        }
                    }

                    qTileX = game.tileMap.FindTile(position).tileX;
                    qTileY = game.tileMap.FindTile(position).tileY;
                    qChunkX = game.tileMap.FindTile(position).chunkX;
                    qChunkY = game.tileMap.FindTile(position).chunkY; 
                    game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX + 1, qTileY].UpdateIndex(TileType.ConstructionBlock);

                    pos = new Vector2(position.X + (offSet * 32), position.Y);
                    qTileX = game.tileMap.FindTile(pos).tileX;
                    qTileY = game.tileMap.FindTile(pos).tileY; 
                    qChunkX = game.tileMap.FindTile(pos).chunkX;
                    qChunkY = game.tileMap.FindTile(pos).chunkY; 
                    game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(TileType.ConstructionBlock);

                    for (int y = 1; y < height; y++)
                    {
                        pos = new Vector2(position.X + (1 * 32), position.Y - (y * 32));
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY; 
                        game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(TileType.ConstructionBlock);

                        pos = new Vector2(position.X + (offSet * 32), position.Y - (y * 32));
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY; 
                        game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(TileType.ConstructionBlock);
                    }
                     
                    for (int x = 0; x < offSet; x++)
                    {
                        pos = new Vector2(position.X + ((1 + x) * 32), position.Y - (height * 32));
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY;
                        game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(TileType.ConstructionBlock);
                    }

                    // comented 



                    Vector2 position1;
                    Vector2 position2;
                    position1 = new Vector2(position.X + (2 * 32), position.Y + (1 * 32));
                    position2 = new Vector2(position.X + ((offSet - 1) * 32), position.Y - (1 * 32));

                    quarryDrill = new QuarryDrill(position1, position2, height, game, this); 

                    quarryDrill.LoadContent(contentManager);
                    game.quarryManagement.drills.Add(quarryDrill);
                    madeQuarry = true;
                }
                #endregion

                
                
            }
        }
        
        public void ItemPipe(Chunk tileMap, GameTime gameTime, Game1 game)
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
                        Vector2 pos;
                        pos = new Vector2(position.X, position.Y + (1 * 32));
                        int tileX;
                        int tileY;
                        int chunkx;
                        int chunky;

                        tileX = game.tileMap.FindTile(pos).tileX;
                        tileY = game.tileMap.FindTile(pos).tileY;
                        chunkx = game.tileMap.FindTile(pos).chunkX;
                        chunky = game.tileMap.FindTile(pos).chunkY;

                        Tile checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY]; 
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
                        Vector2 pos;
                        pos = new Vector2(position.X - (1 * 32), position.Y);
                        int tileX;
                        int tileY;
                        int chunkx;
                        int chunky;

                        tileX = game.tileMap.FindTile(pos).tileX;
                        tileY = game.tileMap.FindTile(pos).tileY;
                        chunkx = game.tileMap.FindTile(pos).chunkX;
                        chunky = game.tileMap.FindTile(pos).chunkY;

                        Tile checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY];

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
                        Vector2 pos;
                        pos = new Vector2(position.X, position.Y - (1 * 32));
                        int tileX;
                        int tileY;
                        int chunkx;
                        int chunky;

                        tileX = game.tileMap.FindTile(pos).tileX;
                        tileY = game.tileMap.FindTile(pos).tileY;
                        chunkx = game.tileMap.FindTile(pos).chunkX;
                        chunky = game.tileMap.FindTile(pos).chunkY;

                        Tile checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY];

                    
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
                        Vector2 pos;
                        pos = new Vector2(position.X + (1 * 32), position.Y);
                        int tileX;
                        int tileY;
                        int chunkx;
                        int chunky;

                        tileX = game.tileMap.FindTile(pos).tileX;
                        tileY = game.tileMap.FindTile(pos).tileY;
                        chunkx = game.tileMap.FindTile(pos).chunkX;
                        chunky = game.tileMap.FindTile(pos).chunkY;

                        Tile checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY];


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
        
        public void ItemStorage(Chunk tileMap, GameTime gameTime, Game1 game)
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

            Vector2 pos;
            pos = new Vector2(position.X, position.Y - (1 * 32));
            int tileX;
            int tileY;
            int chunkx;
            int chunky;

            tileX = game.tileMap.FindTile(pos).tileX;
            tileY = game.tileMap.FindTile(pos).tileY;
            chunkx = game.tileMap.FindTile(pos).chunkX;
            chunky = game.tileMap.FindTile(pos).chunkY;

            Tile checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY];
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

            pos = new Vector2(position.X, position.Y + (1 * 32));

            tileX = game.tileMap.FindTile(pos).tileX;
            tileY = game.tileMap.FindTile(pos).tileY;
            chunkx = game.tileMap.FindTile(pos).chunkX;
            chunky = game.tileMap.FindTile(pos).chunkY;

            checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY];

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

            pos = new Vector2(position.X + (1 * 32), position.Y);

            tileX = game.tileMap.FindTile(pos).tileX;
            tileY = game.tileMap.FindTile(pos).tileY;
            chunkx = game.tileMap.FindTile(pos).chunkX;
            chunky = game.tileMap.FindTile(pos).chunkY;

            checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY];

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
            pos = new Vector2(position.X - (1 * 32), position.Y);

            tileX = game.tileMap.FindTile(pos).tileX;
            tileY = game.tileMap.FindTile(pos).tileY;
            chunkx = game.tileMap.FindTile(pos).chunkX;
            chunky = game.tileMap.FindTile(pos).chunkY;

            checkedTile = game.tileMap.chunks[chunkx, chunky].tiles[tileX, tileY];
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

        /// <summary>
        /// Range from 0 - 5 
        /// 5 being the whitest
        /// 0 being the blackest
        /// </summary>
        /// <param name="level"></param>

        public void Lighting(TileMap tileMap)
        {
            if (index == 0)
            {
                lightLevel = 0;
            }
            if (xPos - 1 < 32)
            {
                if (tileMap.chunks[chunkX, chunkY].tiles[localxPos - 1, localyPos].lightLevel > 0 && tileMap.chunks[chunkX, chunkY].tiles[localxPos - 1, localyPos].tileType != TileType.BlankTile)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[localxPos - 1, localyPos].lightLevel = lightLevel + .25f;
                }
            }
            if (xPos + 1 < 32)
            {
                if (tileMap.chunks[chunkX, chunkY].tiles[localxPos + 1, localyPos].lightLevel > 0 && tileMap.chunks[chunkX, chunkY].tiles[localxPos + 1, localyPos].tileType != TileType.BlankTile)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[localxPos + 1, localyPos].lightLevel = lightLevel + .25f;
                }
            }
            if (yPos + 1 < 32 && yPos - 1 > 0)
            {
                if (tileMap.chunks[chunkX, chunkY].tiles[localxPos, localyPos + 1].lightLevel > 0 && tileMap.chunks[chunkX, chunkY].tiles[localxPos, localyPos + 1].tileType != TileType.BlankTile)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[localxPos, localyPos + 1].lightLevel = lightLevel + .25f;
                }
                if (tileMap.chunks[chunkX, chunkY].tiles[localxPos, localyPos - 1].lightLevel > 0 && tileMap.chunks[chunkX, chunkY].tiles[localxPos, localyPos - 1].tileType != TileType.BlankTile)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[localxPos, localyPos - 1].lightLevel = lightLevel + .25f;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Player player)
        {
           // draw = true;
           // sourceRectangle = Animation.SourceRect(TileType.DryTile1);
            if (draw)
            {
                spriteBatch.Draw(texture, position, sourceRectangle, Color.White);
               // spriteBatch.Draw()
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
