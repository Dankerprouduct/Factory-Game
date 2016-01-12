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

        public void Update(GameTime gameTime, Player player, TileObjectManagement tileManagement, Game1 game)
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
                fps = "fps " + player._fps.ToString();
                tilePos = "Tile Position " + ((player.rect.X / 32) - 2).ToString() + " " + (player.rect.Y / 32).ToString();
                entitys = "Entitys " + tileManagement.tileObjects.Count;


            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (showDebug)
            {
                spriteBatch.Draw(backGround, new Rectangle(0, 0, 450, 150), Color.White);

                spriteBatch.DrawString(font, playerPos, new Vector2(10, 10), Color.White);
                spriteBatch.DrawString(font, inAir, new Vector2(10, 25), Color.White);
                spriteBatch.DrawString(font, canBreak, new Vector2(10, 40), Color.White);
                spriteBatch.DrawString(font, velocity, new Vector2(10, 55), Color.White);
                spriteBatch.DrawString(font, tilePos, new Vector2(10, 70), Color.White);
                spriteBatch.DrawString(font, entitys, new Vector2(10, 85), Color.White);
                spriteBatch.DrawString(font, fps, new Vector2(10, 115), Color.White); 
            }
        }

    }
}
