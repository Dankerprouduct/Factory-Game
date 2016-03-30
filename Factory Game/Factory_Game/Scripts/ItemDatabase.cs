using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseLibrary; 
namespace Factory_Game
{
    public class ItemDatabase
    {
        //public List<Item> items = new List<Item>(); 
        public DatabaseLibrary.ItemDatabase[] items; 
        public ItemDatabase(ContentManager content)
        {
            
            items = content.Load<DatabaseLibrary.ItemDatabase[]>("Xml/ItemDatabase");

        }
        public Item Item(int id)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i].itemId == id)
                {
                    return new Item(items[id].name, items[id].description, id, items[id].canSmelt, items[id].stackCount);
                }
                
            }
            return new Factory_Game.Item(); 
            
        }

        public void Databse(ContentManager content)
        {
            DatabaseLibrary.ItemDatabase[] dItems = content.Load<DatabaseLibrary.ItemDatabase[]>("ItemDatabase");
        }

        
    }
}
