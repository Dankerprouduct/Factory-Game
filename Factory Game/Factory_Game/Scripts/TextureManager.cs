using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Factory_Game
{
    public class TextureManager
    {
        public struct TextureSource
        {
            public int id; 
            public Rectangle source; 
        }
        public List<TextureSource> sources;


        public TextureManager(ContentManager content)
        {
            sources = new List<TextureSource>();

            DatabaseLibrary.ItemDatabase[] items = content.Load<DatabaseLibrary.ItemDatabase[]>("Xml/ItemDatabase"); 
            


            foreach(DatabaseLibrary.ItemDatabase item in items)
            {
                
                TextureSource source = new TextureSource();
                source.id = item.itemId;
                source.source = Animation.SourceRect(item.itemId, "Tile_SpriteSheet", content);
                Console.WriteLine(source.source);
                sources.Add(source); 
            }
        }
        
        public Rectangle SourceRect(int id)
        {
            for(int i = 0; i < sources.Count; i++)
            {
                if(sources[i].id == id)
                {
                    //return new Rectangle(160, 0, 32, 32);
                    return sources[i].source; 
                }
            }
            Console.WriteLine("Couldnt find source"); 
            return Rectangle.Empty; 
        }
        
    }
}
