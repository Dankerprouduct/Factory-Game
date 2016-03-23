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
        KeyboardState keyboardState;
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
        }

        public void Update(GameTime gameTime, Game1 game)
        {
            keyboardState = Keyboard.GetState();

            if(game._fps < 15)
            {
                if(tileObjects.Count > 0)
                {
                    tileObjects.RemoveAt(0); 
                }
            }
            if (keyboardState.IsKeyDown(Keys.R))
            {
                for(int i = 0; i < tileObjects.Count; i++)
                {
                    tileObjects.RemoveAt(i); 
                }
            }

            for(int i = 0; i < tileObjects.Count; i++)
            {
                tileObjects[i].Update(gameTime, game.player, game.quarryManagement);
                if (!tileObjects[i].alive)
                {
                    tileObjects.RemoveAt(i);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            foreach(TileObject ti in tileObjects)
            {
                ti.Draw(spriteBatch); 
            }
        }
    }
}
