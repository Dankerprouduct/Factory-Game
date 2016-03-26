using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Factory_Game
{
    class GUIObject
    {

        private Rectangle size;
        private Texture2D background;
        SpriteFont spriteFont;
        string text; 
        public GUIObject()
        {
             
        }
        public void GuiBox(Rectangle _size, string _text)
        {
            string[] strings = _text.Split(' ');
            int sum = 0;
            List<string> listStrings = new List<string>(); 
            for (int i = 0; i < strings.Length; i++)
            {
                
                sum += (int)spriteFont.MeasureString(strings[i]).X; 
                
                if(sum > _size.Width)
                {
                    sum = 0; 
                    listStrings.Add("\n");
                    listStrings.Add(strings[i] + " ");
                    Console.WriteLine("Break Added"); 
                }
                else
                {
                    listStrings.Add(strings[i] +" "); 
                }
            }
            size = _size; 
            
            for(int i = 0; i < listStrings.Count; i++)
            {
                text += listStrings[i];
                Console.WriteLine(text); 
            }
        }
        public void LoadContent(ContentManager _content)
        {
            spriteFont = _content.Load<SpriteFont>("Fonts/Font1");
            background = _content.Load<Texture2D>("Fonts/DarkGrayBack"); 
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, size, Color.White); 
            spriteBatch.DrawString(spriteFont, text, new Vector2(size.X, size.Y), Color.White); 
        }
    }
}
