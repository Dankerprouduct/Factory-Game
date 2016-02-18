using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    class Chunk
    {
        public Vector2 position;
        public Tile[,] chunk;
        float[,] preChunk; 
        public static int Width = 32;
        public static int Height = 32;
        public static int GlobalWidth = 1024;
        public static int GlobalHeight = 1024; 
        public Chunk()
        {

        }
        public Chunk(float[,] pChunk, ContentManager content)
        {
            //chunk = new Tile[Width, Height];
            //preChunk = pChunk; 
            //position = pos; 
           // BuildChunk(content); 
        }
        public void LoadContent(float[,] pChunk, ContentManager content)
        {
            preChunk = pChunk;
            chunk = new Tile[pChunk.GetLength(0), pChunk.GetLength(1)];
            BuildChunk(content);
             
        }
        public void SetPosition(Vector2 pos)
        {
            position = pos;
            Console.WriteLine(position); 
        }
        public void BuildChunk(ContentManager content)
        {
            Console.WriteLine(chunk.GetLength(1));
            Console.WriteLine(chunk.GetLength(0));
            for (int x = 0; x < chunk.GetLength(0); x++)
            {
                for (int y = 0; y < chunk.GetLength(1); y++)
                {
                    chunk[x, y] = new Tile();
                    chunk[x, y].LoadContent(content);
                    chunk[x, y].SetPosition(new Vector2(position.X + (x * 32), position.Y + (y * 32)));
                    //Console.WriteLine(position.X + (x * 32) + " " + position.X + (x * 32));
                    //Console.WriteLine(chunk[x, y].position); 
                    //Console.WriteLine("Loadingtile"); 
                }

            }
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (preChunk[x, y] <= .3f && preChunk[x, y] >= .0f)
                    {
                        chunk[x, y].index = 0;
                    }
                    if (preChunk[x, y] <= .6f && preChunk[x, y] >= .3f)
                    {
                        chunk[x, y].index = 2;
                        if (preChunk[x, y] <= .4f && preChunk[x, y] >= .3f)
                        {
                            chunk[x, y].index = 3;
                        }
                    }
                    if (preChunk[x, y] <= .7f && preChunk[x, y] >= .6f)
                    {
                        chunk[x, y].index = 4;
                        // GenerateOre(x, y); 
                        if (preChunk[x, y] <= .65f && preChunk[x, y] >= .6f)
                        {
                            chunk[x, y].index = 5;
                            //  GenerateOre(x, y); 

                        }
                    }
                    if (preChunk[x, y] <= .9f && preChunk[x, y] >= .7f)
                    {
                        chunk[x, y].index = 0;
                    }
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch, Player player )
        {
            for(int x = 0; x < Width; x++)
            {
                for(int y = 0; y < Height; y++)
                {
                    if (chunk[x, y] != null)
                    {
                        chunk[x, y].Draw(spriteBatch, player);
                    } 
                }
            }
        }
    }
}
