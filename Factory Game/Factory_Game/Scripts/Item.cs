using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework; 

namespace Factory_Game
{
    public class Item
    {
        
        public string tileName;
        public string tileDescription;
        public int itemID;
        public Texture2D texture;
        public int sValue;
        public int stackMaxCount;
        public bool canSmelt;
        public Rectangle sourceRect; 

        public Item()
        {
            sValue = 0; 
        }
        
        public Item(string name, string description, int id, bool smelt, int stackCount, ContentManager content)
        {
            sourceRect = Animation.SourceRect(id, "TileObjectSpriteSheet", content);
            texture = content.Load<Texture2D>("TileObjects/TileObjectSpriteSheet");
            tileName = name;
            tileDescription = description;
            itemID = id;
            sValue = 1;
            stackMaxCount = stackCount;
            canSmelt = smelt;
        }

    }
}
