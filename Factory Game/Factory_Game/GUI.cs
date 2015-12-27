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

        public string dT1;
        public string dT2;
        public string dT3;
        public string gT1;
        public string gT2;
        public string gT3;
        public string gR1;
        public string gR2;
        public string gR3;


        int frameCounter;
        double frameTime;
        int frames;

        Texture2D backGround;
        bool showDebug;
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState; 
        public GUI()
        {

        }

        public void LoadContnent(ContentManager content)
        {
            backGround = content.Load<Texture2D>("Fonts/DarkGrayBack"); 
            font = content.Load<SpriteFont>("Fonts/Font1"); 
            
        }

        public void Update(GameTime gameTime, Player player, TileObjectManagement tileManagement)
        {
            keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.L) && oldKeyboardState.IsKeyUp(Keys.L))
            {
                showDebug = !showDebug; 
            }
            oldKeyboardState = keyboardState;
            if (showDebug)
            {
                playerPos = "Position " + player.CurrentBounds().ToString();
                inAir = "In Air " + player.jumping.ToString();
                canBreak = "Can Break " + player.canBreak.ToString();
                velocity = "Velocity " + player.velocity.ToString();
                colliding = "Colliding " + player.colliding.ToString();
                fps = "fps " + frames.ToString();
                tilePos = "Tile Position " + ((player.rect.X / 32) - 2).ToString() + " " + (player.rect.Y / 32).ToString();
                entitys = "Entitys " + tileManagement.tileObjects.Count;

                dT1 = player.inventory.itemIndex[0].ToString();
                dT2 = player.inventory.itemIndex[1].ToString();
                dT3 = player.inventory.itemIndex[2].ToString();
                gT1 = player.inventory.itemIndex[3].ToString();
                gT2 = player.inventory.itemIndex[4].ToString();
                gT3 = player.inventory.itemIndex[5].ToString();
                gR1 = player.inventory.itemIndex[6].ToString();
                gR2 = player.inventory.itemIndex[7].ToString();
                gR3 = player.inventory.itemIndex[8].ToString();

                frameCounter++;
                frameTime += gameTime.ElapsedGameTime.TotalMilliseconds;
                if (frameTime >= 1000)
                {
                    frames = frameCounter;
                    frameTime = 0;
                    frameCounter = 0;
                }

            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (showDebug)
            {
                spriteBatch.Draw(backGround, new Rectangle(0, 0, 450, 300), Color.White);

                spriteBatch.DrawString(font, playerPos, new Vector2(10, 10), Color.White);
                spriteBatch.DrawString(font, inAir, new Vector2(10, 25), Color.White);
                spriteBatch.DrawString(font, canBreak, new Vector2(10, 40), Color.White);
                spriteBatch.DrawString(font, velocity, new Vector2(10, 55), Color.White);
                spriteBatch.DrawString(font, tilePos, new Vector2(10, 70), Color.White);
                spriteBatch.DrawString(font, entitys, new Vector2(10, 85), Color.White);

                spriteBatch.DrawString(font, "Dry Tile 1     " + dT1, new Vector2(10, 100), Color.White);
                spriteBatch.DrawString(font, "Dry Tile 2     " + dT2, new Vector2(10, 115), Color.White);
                spriteBatch.DrawString(font, "Dry Tile 3     " + dT3, new Vector2(10, 130), Color.White);
                spriteBatch.DrawString(font, "Granite Tile 1 " + gT1, new Vector2(10, 145), Color.White);
                spriteBatch.DrawString(font, "Granite Tile 2 " + gT2, new Vector2(10, 160), Color.White);
                spriteBatch.DrawString(font, "Granite Tile 3 " + gT3, new Vector2(10, 175), Color.White);
                spriteBatch.DrawString(font, "Grass Tile 1   " + gR1, new Vector2(10, 190), Color.White);
                spriteBatch.DrawString(font, "Grass Tile 2   " + gR2, new Vector2(10, 205), Color.White);
                spriteBatch.DrawString(font, "Grass Tile 3   " + gR3, new Vector2(10, 220), Color.White);
            }
        }

    }
}
