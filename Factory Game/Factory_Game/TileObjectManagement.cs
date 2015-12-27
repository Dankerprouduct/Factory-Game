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
    public class TileObjectManagement
    {
        public List<TileObject> tileObjects = new List<TileObject>();
        ContentManager content; 
        public TileObjectManagement(Game1 game)
        {
            content = game.Content; 
        }

        public void AddTileObject(Vector2 position, Tile.TileType type)
        {
            tileObjects.Add(new TileObject(position, type));
            foreach(TileObject tO in tileObjects)
            {
                tO.LoadContent(content); 
            }
            Console.WriteLine(tileObjects.Count); 
        }
        
        public void Update(GameTime gameTime)
        {
            for(int i = 0; i < tileObjects.Count; i++)
            {
                tileObjects[i].Update(gameTime);
                if (!tileObjects[i].alive)
                {
                    tileObjects.RemoveAt(i);
                    Console.WriteLine("Removed Tile Object"); 
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(TileObject tiObject in tileObjects)
            {
                tiObject.Draw(spriteBatch);
               // Console.WriteLine("drawing"); 
            }
        }
    }
}
