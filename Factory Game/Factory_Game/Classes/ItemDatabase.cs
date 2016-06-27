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
        ContentManager content;
        public DatabaseLibrary.ItemDatabase[] items; 
        public ItemDatabase(ContentManager _content)
        {
            content = _content;
            items = content.Load<DatabaseLibrary.ItemDatabase[]>("Xml/ItemDatabase");

            for(int i = 0; i < items.Length; i++)
            {
                //Console.WriteLine(items[i].name + "\n       " + items[i].itemId); 
            }
            
        }
        public Item Item(int id)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i].itemId == id)
                {
                    return new Item(items[i].name, items[i].description, items[i].itemId, items[i].canSmelt, items[i].stackCount, content);
                }
                
            }
            return new Item(); 
            
        }

        public void Databse(ContentManager content)
        {
            DatabaseLibrary.ItemDatabase[] dItems = content.Load<DatabaseLibrary.ItemDatabase[]>("ItemDatabase");
        }

        
    }
}
