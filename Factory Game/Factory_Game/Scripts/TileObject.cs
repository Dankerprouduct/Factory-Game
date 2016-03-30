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
            objectTexture = content.Load<Texture2D>("TileObjects/GoldWire2Item");


        
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
