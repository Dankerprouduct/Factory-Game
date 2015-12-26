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

        int frameCounter;
        double frameTime;
        int frames; 
        public GUI()
        {

        }

        public void LoadContnent(ContentManager content)
        {
            font = content.Load<SpriteFont>("Fonts/Font1"); 
            
        }

        public void Update(GameTime gameTime, Player player)
        {
            playerPos = "Position " + player.CurrentBounds().ToString();
            inAir = "In Air " + player.jumping.ToString();
            canBreak = "Can Break " + player.canBreak.ToString();
            velocity = "Velocity " + player.velocity.ToString();
            colliding = "Colliding " + player.colliding.ToString();
            fps = "fps " + frames.ToString(); 

            frameCounter++;
            frameTime += gameTime.ElapsedGameTime.TotalMilliseconds; 
            if(frameTime >= 1000)
            {
                frames = frameCounter;
                frameTime = 0;
                frameCounter = 0; 
            }

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, playerPos, new Vector2(10, 10), Color.White);
            spriteBatch.DrawString(font, inAir, new Vector2(10, 25), Color.White);
            spriteBatch.DrawString(font, canBreak, new Vector2(10, 40), Color.White);
            spriteBatch.DrawString(font, velocity, new Vector2(10, 55), Color.White);
            spriteBatch.DrawString(font, fps, new Vector2(10, 70), Color.White); 
        }

    }
}
