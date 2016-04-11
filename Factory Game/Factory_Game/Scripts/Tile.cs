using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using NLua;
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
        public bool alive = true;
        Rectangle bounds;
        public float durability;
        bool draw = true;
        public float current;

        TimeSpan time = TimeSpan.FromMilliseconds(1000);

        TimeSpan time2;
        public int inventorySpeed = 1500;
        TimeSpan lastTime;
        Game1 game1;
        QuarryDrill quarryDrill;
        SpriteFont font;
        public bool madeItemPipe;
        public bool madeQuarry;
        public bool madeStorage;
        public bool madeSmelter;
        public bool madeSolarPanel;
        public bool madeBattery;
        public bool isWire;
        public Item tempItem;
        public Rectangle sourceRectangle;
        public float light = 1;

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
        public enum WireState
        {
            State1,
            State2,
            State3,
            State4
        }

        public StorageTier storageTier;

        public TileProperty tileProperty;
        public WireState wireState;

        public ContentManager contentManager;

        public Inventory inventory;
        public Inventory outPutInventory;

        public int xPos;
        public int yPos;
        public int localxPos;
        public int localyPos;
        public int chunkX;
        public int chunkY;
        public bool inInventory;

        public Battery battery;
        TileMap tMap;
        Storage storage;
        public string name; 
        public Tile()
        {
            time2 = TimeSpan.FromMilliseconds(inventorySpeed);
            storageTier = new StorageTier();
            tileProperty = new TileProperty();
            wireState = new WireState();
            durability = 10;

        }

        public void LoadContent(ContentManager content)
        {
            contentManager = content;

            texture = content.Load<Texture2D>("Tiles/Tile_SpriteSheet");
            font = content.Load<SpriteFont>("Fonts/Font2");
            // itemDatabase = new ItemDatabase(content); 
        }

        public void Final(TileMap tileMap) //This is where everything is finalized from tileMap
        {
            tMap = tileMap;
            xPos = Convert.ToInt32(position.X / 32);
            yPos = Convert.ToInt32(position.Y / 32);
            bounds = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            #region // Tile Properties 
            switch (index)
            {
                case 0:
                    {
                        alive = false;

                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 11:
                    {


                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 12:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 13:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 21:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 22:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 23:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 31:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 32:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 33:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 51:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 52:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 56:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 57:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 58:
                    {

                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 59:
                    {
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 60:
                    {
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 81:
                    {
                        tileProperty = TileProperty.CantPass;
                        break;
                    }
                case 71:
                    {
                        tileProperty = TileProperty.CanPass;
                        break;
                    }

                case 72:
                    {
                        tileProperty = TileProperty.CanPass;
                        break;
                    }

                case 73:
                    {
                        tileProperty = TileProperty.CanPass;
                        break;
                    }

                default:
                    {

                        tileProperty = TileProperty.CanPass;
                        break;
                    }


            }
            #endregion
            sourceRectangle = tileMap.textureManager.SourceRect(index);

        }
        public void SetPosition(Vector2 pos)
        {

            position = pos;
            // Console.WriteLine(position);
        }
        public void UpdateIndex(int id, ContentManager content)
        {
            durability = 10;
            alive = true;
            current = 0;
            isWire = false;
            madeItemPipe = false;
            madeQuarry = false;
            madeStorage = false;
            index = id; 
            sourceRectangle = Animation.SourceRect(id, "Tile_SpriteSheet", content);
        }
        public void UpdateIndex(int id)
        {
            UpdateIndex(id, contentManager); 
        }
        public void UpdateIndex(int id, TileMap tileMap)
        {
            sourceRectangle = tileMap.textureManager.SourceRect(id); 
        }
        public void UpdateTile(Game1 game)
        {
            //   Wires(game);     
            Console.WriteLine("Updating tile");


        }
        public void DamageTile(float amount)
        {
            // Console.WriteLine("Damaging Tiles"); 
            durability -= amount;
        }

        #region  Updates

        public void Update(GameTime gameTime, Player player, Game1 game, Chunk tileMap)
        {
            tMap = game.tileMap; 
            if (alive)
            {

                if (draw)
                {
                    if (durability <= 0)
                    {

                        // worldPosition = Vector2.Transform(position, Matrix.Invert(game.camera.rawTransform)); 
                        game.tileObjectManagement.AddTileObject(new Vector2(position.X + (bounds.Width / 4), position.Y + (bounds.Height / 4)), index);
                        alive = false;
                        current = 0;
                    }
                    else
                    {
                        Wires(game);
                    }

                    
                    
                    if (index == 150)
                    {
                        SolarPanel(game.tileMap);
                    }
                    

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
                    if (index == 55)
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
                    else if (index == 60)
                    {

                        if (bounds.Intersects(player.rect))
                        {
                            keyboardState = Keyboard.GetState();
                            if (keyboardState.IsKeyDown(Keys.F) && oldKeyboardState.IsKeyUp(Keys.F))
                            {
                                inInventory = !inInventory;
                                //inventory.showInventory = !inventory.showInventory;
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
                                //inventory.showInventory = false;
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

                        /*
                        if (madeStorage)
                        {
                            inventory.Update(gameTime, game);
                        }
                        */
                        if (madeQuarry)
                        {
                            inventory.Update(gameTime, game);
                        }
                        if (index == 55)
                        {
                            Quarry(tileMap, gameTime, game);
                        }
                        if (lastTime + time < gameTime.TotalGameTime)
                        {
                            
                            
                            if (index ==50)
                            {

                                MakeBattery(game.tileMap);
                            }
                            
                            lastTime = gameTime.TotalGameTime;
                        }
                        if (lastTime + time < gameTime.TotalGameTime)
                        {

                            
                        }
                        if (index == 56)
                        {
                            ItemPipe(tileMap, gameTime, game);
                        }
                        if (index == 57)
                        {
                            ItemPipe(tileMap, gameTime, game);
                        }
                        if (index == 58)
                        {
                            ItemPipe(tileMap, gameTime, game);
                        }
                        if (index == 59)
                        {
                            ItemPipe(tileMap, gameTime, game);
                        }
                        if (index == 60)
                        {

                               ItemStorage(tileMap, gameTime, game);
                        }


                    }
                }
                if (!alive)
                {
                    index = 0;
                    sourceRectangle = Animation.SourceRect(0000, "Tile_SpriteSheet", contentManager);
                }

                if (index == 55)
                {
                    if (madeQuarry)
                    {

                        quarryDrill.Update(gameTime, game);
                    }
                }

            }
        }
        public void Wires(Game1 game)
        {

            if (index == 71 || index == 72|| index == 73 || index == 74 || index == 75)
            {
                Wire.WireState(this, game.tileMap);
                Wire.Current(this, game.tileMap);
            }
            if (index == 81 || index == 82 || index == 83 || index == 84 || index == 85)
            {
                Wire.WireState(this, game.tileMap);
                Wire.Current(this, game.tileMap);
            }
            if (index == 91 || index == 92 || index == 93 || index == 94 || index == 95)
            {
                Wire.WireState(this, game.tileMap);
                Wire.Current(this, game.tileMap);
            }

        }

        public void TileEntityCollision(Game1 game)
        {
            // Tile Entities
            for (int i = 0; i < game.tileObjectManagement.tileObjects.Count; i++)
            {

                if (bounds.Intersects(game.tileObjectManagement.tileObjects[i].rect))
                {
                    if (index != 0 || index != 52 || index != 54)
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
                int searchRadius = 200;
                int height = 8;
                inventory = new Inventory();
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                inventory.LoadContent(contentManager, game);
                //inventory.inventoryType = Inventory.InventoryType.StorageInventory;

                int qTileX;
                int qTileY;
                int qChunkX;
                int qChunkY;
                #region 

                if (chunk.tiles[localxPos + 1, localyPos].index == 52)
                {
                    Vector2 pos;
                    for (int i = 2; i < searchRadius; i++)
                    {
                        pos = new Vector2(position.X + (i * 32), position.Y);
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY;
                        Console.WriteLine("Tile X: " + qTileX + " Tile Y:" + qTileY + " ChunkX:" + qChunkX + " ChunkY:" + qChunkY);
                        if (game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].index == 52)
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
                    game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX + 1, qTileY].UpdateIndex(51, contentManager);

                    pos = new Vector2(position.X + (offSet * 32), position.Y);
                    qTileX = game.tileMap.FindTile(pos).tileX;
                    qTileY = game.tileMap.FindTile(pos).tileY;
                    qChunkX = game.tileMap.FindTile(pos).chunkX;
                    qChunkY = game.tileMap.FindTile(pos).chunkY;
                    game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(51, contentManager);

                    for (int y = 1; y < height; y++)
                    {
                        pos = new Vector2(position.X + (1 * 32), position.Y - (y * 32));
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY;
                        game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(51, contentManager);

                        pos = new Vector2(position.X + (offSet * 32), position.Y - (y * 32));
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY;
                        game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(51, contentManager);
                    }

                    for (int x = 0; x < offSet; x++)
                    {
                        pos = new Vector2(position.X + ((1 + x) * 32), position.Y - (height * 32));
                        qTileX = game.tileMap.FindTile(pos).tileX;
                        qTileY = game.tileMap.FindTile(pos).tileY;
                        qChunkX = game.tileMap.FindTile(pos).chunkX;
                        qChunkY = game.tileMap.FindTile(pos).chunkY;
                        game.tileMap.chunks[qChunkX, qChunkY].tiles[qTileX, qTileY].UpdateIndex(51, contentManager);
                    }

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
                inventory.LoadContent(contentManager, game);
                madeItemPipe = true;
            }

            switch (index)
            {
                case 56:
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
                        if (checkedTile.index == 55)
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
                        else if (checkedTile.index == 56)
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
                        else if (checkedTile.index == 60)
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
                case 57:
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

                        if (checkedTile.index == 55)
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
                        else if (checkedTile.index == 57)
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
                        else if (checkedTile.index == 60)
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
                case 58:
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


                        if (checkedTile.index == 55)
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
                        if (checkedTile.index == 58)
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
                        if (checkedTile.index == 60)
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
                case 59:
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


                        if (checkedTile.index == 55)
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
                        else if (checkedTile.index == 59)
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
                        else if (checkedTile.index == 60)
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
                /*
                inventory = new Inventory();
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                inventory.LoadContent(contentManager);
                inventory.inventoryType = Inventory.InventoryType.StorageInventory;
                Console.WriteLine("Made storage");
                */
                storage = new Storage(1, this, game.tileMap, game);
                game.storageManagement.AddStorage(storage); 
                madeStorage = true;

            }
            if (madeStorage)
            {
             //   storage.Update(game.tileMap); 
            }
        }
        public Rectangle GetBounds()
        {
            return bounds; 
        }
        public void SolarPanel(TileMap tileMap)
        {
            if (!madeSolarPanel)
            {
                battery = new Battery(500);
                battery.Output(false);
                madeSolarPanel = true;
            }
            else
            {
                if (tileMap.GetTile(new Vector2(position.X, position.Y - 32)).index == 0)
                {
                    // 1 watt per second
                    battery.AddWatts(.016667f);
                    current = battery.CurrentPower();
                }

            }

        }

        public void MakeBattery(TileMap tileMap)
        {
            if (!madeBattery)
            {
                battery = new Battery(20000);
                battery.Output(false);
                madeBattery = true;
            }
            else
            {

                battery.Update(position, tileMap);
                current = battery.CurrentPower();
            }
        }
        #endregion



        public void BuildStructure()
        {
            Lua lua = new Lua();
            lua.RegisterFunction("BuildTile", this, GetType().GetMethod("BuildTile"));
            lua.RegisterFunction("GetXIndex", this, GetType().GetMethod("GetXIndex"));
            lua.RegisterFunction("GetYIndex", this, GetType().GetMethod("GetYIndex"));
            lua.DoString("structureType = 2");
            lua.DoFile("LuaScripts/structure_data.lua");
            
        }

        public void BuildTile(int x,  int y, int type)
        {
            Vector2 pos;
            pos = new Vector2(position.X + (x * 32), position.Y + (y * 32));

            

            int tileX;
            int tileY;
            int chunkX;
            int chunkY;

            chunkX = tMap.FindTile(pos).chunkX;
            chunkY = tMap.FindTile(pos).chunkY;
            tileX = tMap.FindTile(pos).tileX;
            tileY = tMap.FindTile(pos).tileY;

            tMap.DamageTile(chunkX, chunkY, tileX, tileY, 100f);
            tMap.GetTile(pos).UpdateIndex(type, contentManager);
        }

        public int GetXIndex()
        {
            return (int)position.X;

        }
        public int GetYIndex()
        {
            return (int)position.Y; 
        }

        public float Rotation(float degree)
        {
            return (degree * (float)Math.PI) / 180; 
            
        }

        public void Draw(SpriteBatch spriteBatch, Player player)
        {
           // draw = true;
           // sourceRectangle = Animation.SourceRect(TileType.DryTile1);
            if (draw)
            {
                #region // Draw
                if (index == 71)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32,32), sourceRectangle, Color.White, 0, new Vector2(0,0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 72)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 73)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 74)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 75)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if(index == 81)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if(index == 82)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if(index == 83)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if(index == 84)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if(index == 85)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if(index == 91)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 92)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 93)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 94)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else if (index == 95)
                {
                    switch (wireState)
                    {
                        case WireState.State1:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State2:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(90), new Vector2(0, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State3:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(180), new Vector2(31, 31), SpriteEffects.None, 0f);
                                break;
                            }
                        case WireState.State4:
                            {
                                spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, 32, 32), sourceRectangle, Color.White, Rotation(270), new Vector2(31, 0), SpriteEffects.None, 0f);
                                break;
                            }
                    }
                }
                else
                {
                    spriteBatch.Draw(texture, position, sourceRectangle, Color.White);
                   // spriteBatch.Draw(texture, position, Color.White); 
                }
                #endregion

                if (index == 55)
                {
                    if (madeQuarry)
                    {
                        inventory.Draw(spriteBatch, player); 
                        quarryDrill.Draw(spriteBatch);
                    }
                }
                if(index == 60)
                {
                    if (madeStorage)
                    {
                       // inventory.Draw(spriteBatch, player); 
                    }
                }
                if(index == 56 || index == 57 || index == 58 || index == 59)
                {
                    inventory.Draw(spriteBatch, player); 
                }
            }
        }
    }
}