using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics; 

namespace Factory_Game
{
    public class GuiManagement
    {
        List<GUIObject> guis = new List<GUIObject>();
        public GuiManagement()
        {

        }
        public void Update()
        {
            
        }
        public void AddGuiObjects(GUIObject guiObject)
        {
            Console.WriteLine("Added GUI objects"); 
            guis.Add(guiObject);
        }
        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (guis.Count > 0)
            {
                for (int i = 0; i < guis.Count; i++)
                {
                    guis[i].DrawInventory(spriteBatch, game.player);
                }
            }
        }
        
    }
}
