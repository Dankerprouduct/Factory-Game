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
            RedWire3,
            RedWire4,
            RedWire5,
            GreenWire1,
            GreenWire2,
            GreenWire3,
            GreenWire4,
            GreenWire5,
            GoldWire1,
            GoldWire2,
            GoldWire3,
            GoldWire4,
            GoldWire5,
            MissingTile,
            BatteryBlock,
            SolarPanel,
            StorageBL,
            StorageBR ,
            StorageMB,
            StorageML,
            StorageMR,
            StorageMT,
            StorageTL,
            StorageTR,
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
        public enum WireState
        {
            State1,
            State2,
            State3,
            State4
        }

        public StorageTier storageTier;
        public TileType tileType;

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
            tileType = new TileType();
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
                        tileType = TileType.RedWire1;
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
                        tileType = TileType.RedWire3;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 30:
                    {
                        tileType = TileType.GreenWire1;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 31:
                    {
                        tileType = TileType.GreenWire2;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 32:
                    {
                        tileType = TileType.GreenWire3;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 33:
                    {
                        tileType = TileType.GoldWire1;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 34:
                    {
                        tileType = TileType.GoldWire2;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                case 35:
                    {
                        tileType = TileType.GoldWire3;
                        tileProperty = TileProperty.CanPass;
                        break;
                    }
                default:
                    {
                        tileType = TileType.MissingTile;
                        tileProperty = TileProperty.CantPass;
                        break;
                    }


            }
            #endregion
            sourceRectangle = tileMap.textureManager.SourceRect(tileType);

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
            current = 0;
            isWire = false;
            madeItemPipe = false;
            madeQuarry = false;
            madeStorage = false;
            //tileProperty = TileProperty.CantPass; 
            if (tiType != tileType)
            {
                //Console.WriteLine(tiType.ToString() + " " + tileType.ToString()); 
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
                            // BuildStructure(); 
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
                            tileType = TileType.RedWire1;
                            tileProperty = TileProperty.CanPass;
                            index = 27;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
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
                            isWire = true;
                            break;
                        }
                    case TileType.RedWire3:
                        {
                            tileType = TileType.RedWire3;
                            tileProperty = TileProperty.CanPass;
                            index = 29;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.RedWire4:
                        {
                            tileType = TileType.RedWire4;
                            tileProperty = TileProperty.CanPass;
                            index = 30;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.RedWire5:
                        {
                            tileType = TileType.RedWire5;
                            tileProperty = TileProperty.CanPass;
                            index = 31;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GreenWire1:
                        {
                            tileType = TileType.GreenWire1;
                            tileProperty = TileProperty.CanPass;
                            index = 32;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GreenWire2:
                        {
                            tileType = TileType.GreenWire2;
                            tileProperty = TileProperty.CanPass;
                            index = 33;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GreenWire3:
                        {
                            tileType = TileType.GreenWire3;
                            tileProperty = TileProperty.CanPass;
                            index = 34;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GreenWire4:
                        {
                            tileType = TileType.GreenWire4;
                            tileProperty = TileProperty.CanPass;
                            index = 35;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GreenWire5:
                        {
                            tileType = TileType.GreenWire5;
                            tileProperty = TileProperty.CanPass;
                            index = 36;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GoldWire1:
                        {
                            tileType = TileType.GoldWire1;
                            tileProperty = TileProperty.CanPass;
                            index = 37;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GoldWire2:
                        {
                            tileType = TileType.GoldWire2;
                            tileProperty = TileProperty.CanPass;
                            index = 38;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GoldWire3:
                        {
                            tileType = TileType.GoldWire3;
                            tileProperty = TileProperty.CanPass;
                            index = 39;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GoldWire4:
                        {
                            tileType = TileType.GoldWire4;
                            tileProperty = TileProperty.CanPass;
                            index = 40;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;
                            break;
                        }
                    case TileType.GoldWire5:
                        {
                            tileType = TileType.GoldWire5;
                            tileProperty = TileProperty.CanPass;
                            index = 41;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            isWire = true;

                            break;
                        }
                    case TileType.BatteryBlock:
                        {
                            tileType = TileType.BatteryBlock;
                            tileProperty = TileProperty.CantPass;
                            index = 43;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            break;
                        }
                    case TileType.SolarPanel:
                        {
                            tileType = TileType.SolarPanel;
                            tileProperty = TileProperty.CantPass;
                            index = 44;
                            madeItemPipe = false;
                            madeStorage = false;
                            madeQuarry = false;
                            break;
                        }
                    case TileType.StorageBL:
                        {
                            tileProperty = TileProperty.CanPass;
                            index = 45;
                            break;
                        }
                    case TileType.StorageBR:
                        {
                            tileProperty = TileProperty.CanPass;
                            index = 46;
                            break;
                        }
                    case TileType.StorageMB:
                        {
                            tileProperty = TileProperty.CanPass; 
                            index = 47;
                            break;
                        }
                    case TileType.StorageML:
                        {
                            tileProperty = TileProperty.CanPass;
                            index = 48;
                            break;
                        }
                    case TileType.StorageMR:
                        {
                            tileProperty = TileProperty.CanPass;
                            index = 49; 
                            break;
                        }
                    case TileType.StorageMT:
                        {
                            tileProperty = TileProperty.CanPass;
                            index = 50;
                            break;
                        }
                    case TileType.StorageTL:
                        {
                            tileProperty = TileProperty.CanPass;

                            index = 51; 
                            break;
                        }
                    case TileType.StorageTR:
                        {
                            tileProperty = TileProperty.CanPass;
                            index = 52; 
                            break;
                        }



                }
                tileType = tiType; 
                sourceRectangle = Animation.SourceRect(tileType, "Tile_SpriteSheet", this);
            }

        }
        public void UpdateIndex(int id, ContentManager content)
        {

            sourceRectangle = Animation.SourceRect(id, "Tile_SpriteSheet", content);
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
                        game.tileObjectManagement.AddTileObject(new Vector2(position.X + (bounds.Width / 4), position.Y + (bounds.Height / 4)), tileType);
                        alive = false;
                        current = 0;
                    }
                    else
                    {
                        Wires(game);
                    }
                    if (tileType == TileType.SolarPanel)
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
                        if (this.tileType == TileType.QuarryBlock)
                        {
                            Quarry(tileMap, gameTime, game);
                        }
                        if (lastTime + time < gameTime.TotalGameTime)
                        {
                            if (tileType == TileType.BatteryBlock)
                            {

                                MakeBattery(game.tileMap);
                            }
                            lastTime = gameTime.TotalGameTime;
                        }
                        if (lastTime + time < gameTime.TotalGameTime)
                        {

                            
                        }
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
                    sourceRectangle = Animation.SourceRect(tileType, "Tile_SpriteSheet", this);
                }

                if (tileType == TileType.QuarryBlock)
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

            if (tileType == TileType.RedWire1 || tileType == TileType.RedWire2 || tileType == TileType.RedWire3 || tileType == TileType.RedWire4 || tileType == TileType.RedWire5)
            {
                Wire.WireState(this, game.tileMap);
                Wire.Current(this, game.tileMap);
            }
            if (tileType == TileType.GreenWire1 || tileType == TileType.GreenWire2 || tileType == TileType.GreenWire3 || tileType == TileType.GreenWire4 || tileType == TileType.GreenWire5)
            {
                Wire.WireState(this, game.tileMap);
                Wire.Current(this, game.tileMap);
            }
            if (tileType == TileType.GoldWire1 || tileType == TileType.GoldWire2 || tileType == TileType.GoldWire3 || tileType == TileType.GoldWire4 || tileType == TileType.GoldWire5)
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
                        Console.WriteLine("Tile X: " + qTileX + " Tile Y:" + qTileY + " ChunkX:" + qChunkX + " ChunkY:" + qChunkY);
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
                inventory.LoadContent(contentManager, game);
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
                        else if (checkedTile.tileType == TileType.StorageCrate)
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
                        else if (checkedTile.tileType == TileType.ItemPipeEast)
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
                        else if (checkedTile.tileType == TileType.StorageCrate)
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
                        if (checkedTile.tileType == TileType.ItemPipeSouth)
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
                        if (checkedTile.tileType == TileType.StorageCrate)
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
                        else if (checkedTile.tileType == TileType.ItemPipeWest)
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
                        else if (checkedTile.tileType == TileType.StorageCrate)
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
            #region
            /*
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
            */
            #endregion
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
                if (tileMap.GetTile(new Vector2(position.X, position.Y - 32)).tileType == TileType.BlankTile)
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
            tMap.GetTile(pos).UpdateIndex((TileType)type);
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
                if (tileType == TileType.RedWire1)
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
                else if (tileType == TileType.RedWire2)
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
                else if (tileType == TileType.RedWire3)
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
                else if (tileType == TileType.RedWire4)
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
                else if (tileType == TileType.RedWire5)
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
                else if(tileType == TileType.GreenWire1)
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
                else if(tileType == TileType.GreenWire2)
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
                else if(tileType == TileType.GreenWire3)
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
                else if(tileType == TileType.GoldWire1)
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
                else if(tileType == TileType.GoldWire2)
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
                else if(tileType == TileType.GoldWire3)
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
                else if (tileType == TileType.GoldWire4)
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
                else if (tileType == TileType.GoldWire5)
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
                }
                #endregion
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
                       // inventory.Draw(spriteBatch, player); 
                    }
                }
                if(this.tileType == TileType.ItemPipeNorth || tileType == TileType.ItemPipeEast || tileType == TileType.ItemPipeSouth || tileType == TileType.ItemPipeWest)
                {
                    inventory.Draw(spriteBatch, player); 
                }
            }
        }
    }
}
