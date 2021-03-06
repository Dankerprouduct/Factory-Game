﻿using Microsoft.Xna.Framework;
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
        Texture2D light;
        int lightLevel = 7; 
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
            //Console.WriteLine(chunkX);
            //Console.WriteLine(chunkY); 

            for (int x = 0; x < 32; x++)
            {
                for(int y = 0; y < 32; y++)
                {
                    tiles[x, y] = chunk[x, y];
                    tiles[x, y].localxPos = x;
                    tiles[x, y].localyPos = y;

                    tiles[x, y].chunkX = chunkX;
                    tiles[x, y].chunkY = chunkY;
                }
            }

            
            // Finished building chunk, you can do whatever you want beneath this
            // Lighting();
        }
        public void Update(GameTime gameTime, Player player, Game1 game)
        {
           // light = game.Content.Load<Texture2D>("Tiles/Black");
            for(int x = 0; x < tiles.GetLength(0); x++)
            {
                for(int y = 0; y < tiles.GetLength(0); y++)
                {
                    if (tiles[x, y].alive)
                    {
                        tiles[x, y].Update(gameTime, player, game, this);
                    }
                }
            }
            
           // Lighting(); 
        }

        void Lighting()
        {
            for(int x = 0; x < tiles.GetLength(0); x++)
            {
                for(int y = 0; y < tiles.GetLength(1); y++)
                {
                   UpdateLights(x, y, lightLevel); 
                }
            }
        }

        void UpdateLights(int X, int Y, int lightlevel)
        {
            NeighbourUpdate(X, Y - 1, lightLevel - 1);
            NeighbourUpdate(X, Y + 1, lightLevel - 1);
            NeighbourUpdate(X - 1, Y, lightLevel - 1);
            NeighbourUpdate(X + 1, Y, lightLevel - 1);

            
        }
        void NeighbourUpdate(int X, int Y, int lightLevel)
        {
            if(lightLevel > tiles[X, Y].light)
            {
                tiles[X, Y].light = lightLevel; 
            }
        }
        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            for(int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    tiles[x, y].Draw(spriteBatch, player);
                   // spriteBatch.Draw(light, tiles[x, y].position, Color.White * tiles[x, y].light); 
                }
            }
        }
    }
}
