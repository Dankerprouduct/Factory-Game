using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Media; 
namespace Factory_Game
{
    public class Chunk
    {
        int chunkX;
        int chunkY; 
        public Tile[,] tiles;
        
        public Chunk()
        {
            
            tiles = new Tile[32, 32]; 
        }
        public void SetChunkPosition(int x, int y)
        {
            chunkX = x;
            chunkY = y; 
        }
        public void SetChunks(Tile[,] chunk)
        {
            Console.WriteLine(chunkX);
            Console.WriteLine(chunkY); 

            for (int x = 0; x < 32; x++)
            {
                for(int y = 0; y < 32; y++)
                {
                    tiles[x, y] = chunk[x, y];
                    tiles[x, y].localxPos = x;
                    tiles[x, y].localyPos = y; 
                }
            }

         //   Console.WriteLine("Built Chunk" + chunkX + " " + chunkY); 

        }
        public void Update(GameTime gameTime, Player player, Game1 game)
        {
            for(int x = 0; x < tiles.GetLength(0); x++)
            {
                for(int y = 0; y < tiles.GetLength(0); y++)
                {
                    tiles[x, y].Update(gameTime, player, game, this);
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            for(int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    tiles[x, y].Draw(spriteBatch, player);
                }
            }
        }
    }
}
