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
    public class TileObject
    {
        public Vector2 position;
        Texture2D objectTexture;
        public Tile.TileType type;
        Rectangle tileBounds;
        public Rectangle rect;
        public bool alive;
        public Vector2 velocity;
        float currentTime = 0;
        int counter = 1;
        float countDuration = 25f;
        ItemDatabase dataBase;
        Item item; 
        public TileObject(Vector2 pos, Tile.TileType typ)
        {
            
            position = pos; 
            type = typ;
            alive = true;

        }
        public void LoadContent(ContentManager content)
        {
            dataBase = new ItemDatabase(content);
            switch (type)
            {
                case Tile.TileType.DryTile1:
                    {
                        item = dataBase.items[1]; 
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile1Item");
                        break;
                    }
                case Tile.TileType.DryTile2:
                    {
                        item = dataBase.items[2];
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile2Item");
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        item = dataBase.items[3];
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile3Item");
                        break; 
                    }
                case Tile.TileType.Granite1:
                    {
                        item = dataBase.items[4];
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite1Item");
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        item = dataBase.items[5];
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite2Item");
                        break; 
                    }
                case Tile.TileType.Granite3:
                    {
                        item = dataBase.items[6];
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite3Item");
                        break;
                    }
                case Tile.TileType.Grass1:
                    {
                        item = dataBase.items[7];
                        objectTexture = content.Load<Texture2D>("TileObjects/Grass1Item");
                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        item = dataBase.items[8];
                        objectTexture = content.Load<Texture2D>("TileObjects/Grass2Item");
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        item = dataBase.items[9];
                        objectTexture = content.Load<Texture2D>("TileObjects/Grass3Item");
                        break; 
                    }
                case Tile.TileType.ConstructionBlock:
                    {
                        item = dataBase.items[11];
                        objectTexture = content.Load<Texture2D>("TileObjects/ConstructionBlockItem");
                        break;
                    }
                case Tile.TileType.MarkerBlock:
                    {
                        item = dataBase.items[12];
                        objectTexture = content.Load<Texture2D>("TileObjects/MarkerBlockItem");
                        break;
                    }
                case Tile.TileType.QuarryBlock:
                    {
                        item = dataBase.items[15];
                        objectTexture = content.Load<Texture2D>("TileObjects/QuarryBlockItem");
                        break; 
                    }
                case Tile.TileType.ItemPipeNorth:
                    {
                        item = dataBase.items[16];
                        objectTexture = content.Load<Texture2D>("TileObjects/NorthTubeItem");
                        break;
                    }
                case Tile.TileType.ItemPipeEast:
                    {
                        item = dataBase.items[17];
                        objectTexture = content.Load<Texture2D>("TileObjects/EastTubeItem");
                        break;
                    }
                case Tile.TileType.ItemPipeSouth:
                    {
                        item = dataBase.items[18];
                        objectTexture = content.Load<Texture2D>("TileObjects/SouthTubeItem");
                        break;
                    }
                case Tile.TileType.ItemPipeWest:
                    {
                        item = dataBase.items[19];
                        objectTexture = content.Load<Texture2D>("TileObjects/WestTubeItem");
                        break;
                    }
                case Tile.TileType.StorageCrate:
                    {
                        item = dataBase.items[20];
                        objectTexture = content.Load<Texture2D>("TileObjects/StorageCrateItem");
                        break;  
                    }
                case Tile.TileType.RedWire1:
                    {
                        item = dataBase.items[21];
                        objectTexture = content.Load<Texture2D>("TileObjects/RedWire2Item");
                        break;
                    }
                case Tile.TileType.RedWire2:
                    {
                        item = dataBase.items[21];
                        objectTexture = content.Load<Texture2D>("TileObjects/RedWire2Item");
                        break;
                    }
                case Tile.TileType.GreenWire1:
                    {
                        item = dataBase.items[22];
                        objectTexture = content.Load<Texture2D>("TileObjects/GreenWire2Item");
                        break;
                    }
                case Tile.TileType.GreenWire2:
                    {
                        item = dataBase.items[22];
                        objectTexture = content.Load<Texture2D>("TileObjects/GreenWire2Item");
                        break;
                    }
                case Tile.TileType.GoldWire1:
                    {
                        item = dataBase.items[23];
                        objectTexture = content.Load<Texture2D>("TileObjects/GoldWire2Item");
                        break;
                    }
                case Tile.TileType.GoldWire2:
                    {
                        item = dataBase.items[23];
                        objectTexture = content.Load<Texture2D>("TileObjects/GoldWire2Item");
                        break;
                    }
                case Tile.TileType.BatteryBlock:
                    {
                        item = dataBase.items[24];
                        objectTexture = content.Load<Texture2D>("TileObjects/BatteryBlockItem");
                        break;
                    }
                case Tile.TileType.SolarPanel:
                    {
                        item = dataBase.items[25];
                        objectTexture = content.Load<Texture2D>("TileObjects/SolarPanelItem");
                        break;
                    }
                default:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/GoldWire2Item");
                        break;
                    }


            }
            rect = new Rectangle((int)position.X, (int)position.Y, objectTexture.Width, objectTexture.Height); 
        }

        public void Update(GameTime gameTime, Player player, QuarryManagement management)
        {
            rect = new Rectangle((int)position.X, (int)position.Y, objectTexture.Width, objectTexture.Height);
            position += velocity; 
            int i = 1;
            velocity.Y += i * .15f;
            PlayerCollision(player);
            DrillCollision(management); 
            DeathTimer(gameTime);
        }
        public void PlayerCollision(Player player)
        {
            if (rect.Intersects(player.rect))
            {
                player.inventory.AddToInventory(item, 1); 

                this.alive = false; 
            }
        }
        public void DrillCollision(QuarryManagement management)
        {
            foreach(QuarryDrill qDrill in management.drills)
            {
                if (qDrill.rect.Intersects(rect))
                {
                    qDrill.tile.inventory.AddToInventory(item, 1);
                    alive = false; 
                }
            }
        }

        void DeathTimer(GameTime gameTime)
        {
            
            currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds; //Time passed since last Update() 

            if (currentTime >= countDuration)
            {
                counter++;
                currentTime -= countDuration; // "use up" the time
                                              //any actions to perform
                alive = false; 
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(objectTexture, position, Color.White);
            
            
        }
    }
}
