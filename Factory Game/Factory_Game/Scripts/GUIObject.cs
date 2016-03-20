using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Factory_Game
{
    class GUIObject
    {

        private Rectangle size;
        private Texture2D background;
        SpriteFont spriteFont;
        public GUIObject()
        {
             
        }
        public void GuiBox(Rectangle size, string text)
        {
            string[] strings = text.Split(' '); 
            
            for(int i = 0; i < strings.Length; i++)
            {
                int sum = 0; 
                sum += (int)spriteFont.MeasureString(strings[i]).X; 

                if(sum > size.Width)
                {
                    strings[i].Insert(i, "\n"); 
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
