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
    class GUI
    {
        SpriteFont font;

        string playerPos;
        string inAir;
        string canBreak;
        string velocity;
        string colliding;
        string fps;
        string tilePos;
        string entitys;
        string chunkPos;
        string acceleration; 

        Texture2D backGround;
        public bool showDebug;
        public bool showChunks; 
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;

        Game1 game1; 
        public GUI()
        {

        }

        public void LoadContnent(ContentManager content, GraphicsDevice graphicsDevice)
        {
            backGround = content.Load<Texture2D>("Fonts/DarkGrayBack"); 
            font = content.Load<SpriteFont>("Fonts/Font1");

        }

        public void Update(GameTime gameTime, Player player, TileObjectManagement tileManagement, Game1 game)
        {
            game1 = game1; 
            keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.L) && oldKeyboardState.IsKeyUp(Keys.L))
            {
                showDebug = !showDebug; 
            }
            if (showDebug)
            {
                if (keyboardState.IsKeyDown(Keys.K) && oldKeyboardState.IsKeyUp(Keys.K))
                {
                    showChunks = !showChunks;
                }
            }
            oldKeyboardState = keyboardState;
            if (showDebug)
            {
                playerPos = "Position " + player.CurrentBounds().ToString();
                inAir = "In Air " + player.jumping.ToString();
                canBreak = "Can Break " + player.canBreak.ToString();
                velocity = "Velocity " + player.velocity.ToString();
                colliding = "Colliding " + player.colliding.ToString();
                try
                {
                    fps = "fps " + Convert.ToInt32(game._fps).ToString();
                }
                catch(Exception ex)
                {

                }
                tilePos = "Tile Position " + ((player.rect.X % 1024) / 32).ToString() + " " + (((player.rect.Y  % 1024) / 32) + 2).ToString();
                entitys = "Entitys " + tileManagement.tileObjects.Count;
                chunkPos = "Chunk X:" + (int)(player.position.X / 1024) + " Chunk Y:"+ (int)(player.position.Y / 1024);
               // acceleration = "Acceleration: " + player.physics.acceleration; 
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (showDebug)
            {
                spriteBatch.Draw(backGround, new Rectangle(0, 0, 450, 150), Color.White);

                spriteBatch.DrawString(font, playerPos, new Vector2(10, 10), Color.White);
                spriteBatch.DrawString(font, inAir, new Vector2(10, 25), Color.White);
         //       spriteBatch.DrawString(font, acceleration, new Vector2(10, 40), Color.White);
                spriteBatch.DrawString(font, velocity, new Vector2(10, 55), Color.White);
                spriteBatch.DrawString(font, tilePos, new Vector2(10, 70), Color.White);
                spriteBatch.DrawString(font, entitys, new Vector2(10, 85), Color.White);
                spriteBatch.DrawString(font, fps, new Vector2(10, 115), Color.White);
                spriteBatch.DrawString(font, chunkPos, new Vector2(10, 130), Color.White);

                
                
            }
        }

    }
}
