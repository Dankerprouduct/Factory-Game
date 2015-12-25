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
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, playerPos, new Vector2(10, 10), Color.White);
            spriteBatch.DrawString(font, inAir, new Vector2(10, 25), Color.White); 
        }

    }
}
