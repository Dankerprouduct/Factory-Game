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
    public class Chunk
    {
        public Tile[,] tiles;
        public static int chunkSize = 32;

        /// <summary>
        /// This should take parameters to tell how to build chunk
        /// </summary>
        public Chunk()
        {
            //tiles = new Tile[chunkSize, chunkSize]; 
           // chunk = tiles; 

        }
        public void BuildChunk()
        {
            for(int x = 0; x < tiles.GetLength(0); x++)
            {
                for(int y = 0; y < tiles.GetLength(1); y++)
                {
                   // tiles[x, y] = new Tile(true); 
                }
            }
        }
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
