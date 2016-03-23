using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework; 

namespace Factory_Game
{
    public class TextureManager
    {
        public struct TextureSource
        {
            public Tile.TileType type;
            public Rectangle source; 
        }
        public List<TextureSource> sources;


        public TextureManager()
        {
            sources = new List<TextureSource>(); 

            foreach(Tile.TileType type in Enum.GetValues(typeof(Tile.TileType)))
            {
                TextureSource tSource;
                tSource.type = type; 
                tSource.source = Animation.SourceRect(type, "Tile_SpriteSheet");
                sources.Add(tSource); 
            }
        }
        
        public Rectangle SourceRect(Tile.TileType type)
        {
            for(int i = 0; i < sources.Count; i++)
            {
                if(sources[i].type == type)
                {
                    return sources[i].source; 
                }
            }
            return Rectangle.Empty; 
        }
        
    }
}
