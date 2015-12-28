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
        Tile.TileType type;
        Rectangle tileBounds;
        public Rectangle rect;
        public bool alive;
        public Vector2 velocity;
        float currentTime = 0;
        int counter = 1;
        float countDuration = 25f; 
        public TileObject(Vector2 pos, Tile.TileType typ)
        {
            position = pos; 
            type = typ;
            alive = true; 
        }
        public void LoadContent(ContentManager content)
        {
            switch (type)
            {
                case Tile.TileType.DryTile1:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile1Item");
                        break;
                    }
                case Tile.TileType.DryTile2:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile2Item");
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile3Item");
                        break; 
                    }
                case Tile.TileType.Granite1:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite1Item");
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite2Item");
                        break; 
                    }
                case Tile.TileType.Granite3:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite3Item");
                        break;
                    }
                case Tile.TileType.Grass1:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Grass1Item");
                        break;
                    }
                case Tile.TileType.Grass2:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Grass2Item");
                        break;
                    }
                case Tile.TileType.Grass3:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Grass3Item");
                        break; 
                    }
                case Tile.TileType.ConstructionBlock:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/ConstructionBlockItem");
                        break;
                    }
                case Tile.TileType.MarkerBlock:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/MarkerBlockItem");
                        break;
                    }
                case Tile.TileType.QuarryBlock:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/QuarryBlockItem");
                        break; 
                    }
                default:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile1Item");
                        break;
                    }


            }
            rect = new Rectangle((int)position.X, (int)position.Y, objectTexture.Width, objectTexture.Height); 
        }

        public void Update(GameTime gameTime, Player player)
        {
            rect = new Rectangle((int)position.X, (int)position.Y, objectTexture.Width, objectTexture.Height);
            position += velocity; 
            int i = 1;
            velocity.Y += i * .15f;
            PlayerCollision(player); 
            DeathTimer(gameTime);
        }
        public void PlayerCollision(Player player)
        {
            if (rect.Intersects(player.rect))
            {
                player.inventory.AddToInventory(this.type, 1); 

                this.alive = false; 
            }
        }
        public void Collision(Rectangle bounds)
        {
            
            tileBounds = bounds;

            Vector2 debth = RectangleExtensions.GetIntersectionDepth(rect, bounds);

            if (debth != Vector2.Zero)
            {
                float absDebthX = Math.Abs(debth.X);
                float absDebthy = Math.Abs(debth.Y);

                if (absDebthy < absDebthX)
                {
                    position = new Vector2(position.X, position.Y + debth.Y);
                }
                else
                {
                    position = new Vector2(position.X + debth.X, position.Y);
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
