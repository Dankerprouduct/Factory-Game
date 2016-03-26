using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input; 

namespace Factory_Game
{
    public class GUIObject
    {

        private Rectangle size;
        private Texture2D background;
        private Texture2D inventoryTexture; 
        SpriteFont font;
        string text;


        public bool inventoryGui;
        Inventory inventory; 
        public GUIObject(int type)
        {
            if(type == 1)
            {
                inventoryGui = true; 
            }
             
        }
        public GUIObject(int type, Inventory _inventory)
        {
            inventory = _inventory; 
            if (type == 1)
            {
                inventoryGui = true;
            }

        }
        public void GuiBox(Rectangle _size, string _text)
        {
            string[] strings = _text.Split(' ');
            int sum = 0;
            List<string> listStrings = new List<string>(); 
            for (int i = 0; i < strings.Length; i++)
            {
                
                sum += (int)font.MeasureString(strings[i]).X; 
                
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
            font = _content.Load<SpriteFont>("Fonts/Font1");
            background = _content.Load<Texture2D>("Textures/BackgroundTexture2");

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, size, Color.Gray); 
            spriteBatch.DrawString(font, text, new Vector2(size.X, size.Y), Color.White); 
            
        }
        public void UpdateInventory(Inventory _inventory)
        {
            inventory = _inventory;

        }
        public void DrawInventory(SpriteBatch spriteBatch, Player player)
        {
            
            inventory.Draw(spriteBatch, player); 
        }
    }
}
