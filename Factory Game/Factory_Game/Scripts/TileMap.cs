using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NLua; 

namespace Factory_Game
{
    public class TileMap
    {
        public int[,] mapAttributes;
        public bool generateFlatWorld;
        //  private int[,] mapSize;
        int seed;
        List<Vector2> nTilePosition = new List<Vector2>();
        List<int> nTileValue = new List<int>();
        KeyboardState keyboardState;
        KeyboardState oldKeyoardState;
        public Tile[,] tile;
        Game1 gme;
        int mapCount = 0;
        public Vector2 playerStart;

        public Chunk[,] chunks; 

        ContentManager contentManager;
        Lua lua;
        public TextureManager textureManager;
        public ItemDatabase itemDatabase; 
        public struct Coordinate
        {
            public int chunkX;
            public int chunkY; 
            public int tileX;
            public int tileY;
             
        }

        public TileMap(int[,] size, int sed, bool fltWorld)
        {
            lua = new Lua();
            lua.DoFile("LuaScripts/tile_script.lua");

            generateFlatWorld = fltWorld;

            
            seed = sed;
            //     mapSize = size;
            mapAttributes = size;
            Console.WriteLine("Map Attribute Size: " + mapAttributes.Length);
           
            tile = new Tile[size.GetLength(0), size.GetLength(1)];
            // chunks.Add(new Chunk()); 
            MapGeneration(size.GetLength(0), size.GetLength(1));
        }

       
        

        void VectorToList(int x, int y)
        {
            nTilePosition.Add(new Vector2(x * 32, y * 32));
        }
        void ValueToList(int x, int y)
        {
            int i;
            i = mapAttributes[x, y];
            nTileValue.Add(i);
        }

        public void LoadContent(ContentManager content)
        {
            textureManager = new TextureManager(content);
            contentManager = content;
            itemDatabase = new ItemDatabase(content); 
            chunks = new Chunk[mapAttributes.GetLength(0) / 32, mapAttributes.GetLength(1) / 32];
            for (int x = 0; x < mapAttributes.GetLength(0) / 32; x++)
            {
                for (int y = 0; y < mapAttributes.GetLength(1) / 32; y++)
                {
                    chunks[x, y] = new Chunk();

                }
            }
            for (int x = 0; x < mapAttributes.GetLength(0); x++)
            {
                for (int y = 0; y < mapAttributes.GetLength(1); y++)
                {
                   /// mapSize[x, y] = mapCount;
                    mapAttributes[x, y] = 0;
                    mapCount++;
                    tile[x, y] = new Tile();
                    tile[x, y].LoadContent(content);
                }
            }

            lua = new Lua(); 
            MapGeneration(mapAttributes.GetLength(0), mapAttributes.GetLength(1));

            if (!generateFlatWorld)
            {
               GenerateHills(mapAttributes.GetLength(0), mapAttributes.GetLength(1));
            }
            else
            {
                GennerateFlatWorld(mapAttributes.GetLength(0), mapAttributes.GetLength(1));
            }
            
            Final();

        }



        #region // noise 

        void MapGeneration(int width, int height)
        {
            float[,] preGenMap = WhiteNoise(width, height);
            lua = new Lua();
            lua.DoFile("LuaScripts/world_properties.lua");
            int octave = (int)(double)lua["octave"]; 
            float[,] postGenMap = GeneratePerlinNoise(preGenMap, octave);

            lua = new Lua(); 
            lua.DoFile("LuaScripts/tile_script.lua");
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    
                    if (postGenMap[x, y] <= (float)((double)lua["BlankTileMax"]) && postGenMap[x, y] >= (float)((double)lua["BlankTileMin"]))
                    {
                        mapAttributes[x, y] = 0;
                    }
                    if (postGenMap[x, y] <= (float)((double)lua["DryTile2Max"]) && postGenMap[x, y] >= (float)((double)lua["DryTile2Min"]))
                    {
                        mapAttributes[x, y] = 12;
                        if (postGenMap[x, y] <= (float)((double)lua["DryTile3Max"]) && postGenMap[x, y] >= (float)((double)lua["DryTile3Max"]))
                        {
                            mapAttributes[x, y] = 13;
                        }
                    }
                    if (postGenMap[x, y] <= (float)((double)lua["Granite1Max"]) && postGenMap[x, y] >= (float)((double)lua["Granite1Min"]))
                    {
                        mapAttributes[x, y] = 21;
                        // GenerateOre(x, y); 
                        if (postGenMap[x, y] <= (float)((double)lua["Granite2Max"]) && postGenMap[x, y] >= (float)((double)lua["Granite2Min"]))
                        {
                            mapAttributes[x, y] = 22;
                            //  GenerateOre(x, y); 

                        }
                    }
                    if (postGenMap[x, y] <= .9f && postGenMap[x, y] >= .7f)
                    {
                        mapAttributes[x, y] = 0;
                    }
                }
            }

            

        }


        void GenerateHills(int width, int height)
        {
            Random randomizer = new Random(seed);
            int[] terrainContour = new int[width * height];

            //Make Random Numbers
            double rand1 = randomizer.NextDouble() + 1;
            double rand2 = randomizer.NextDouble() + 2;
            double rand3 = randomizer.NextDouble() + 3;


            lua.DoFile("LuaScripts/world_properties.lua");
            float peakheight = (float)((double)lua["peak"]);
            float flatness = (float)((double)lua["flatness"]);
            int offset = (int)((double)lua["offset"]);

            //Generate basic terrain sine
            for (int x = 0; x < width; x++)
            {

                double height2 = peakheight / rand1 * Math.Sin((float)x / flatness * rand1 + rand1);
                height2 += peakheight / rand2 * Math.Sin((float)x / flatness * rand2 + rand2);
                height2 += peakheight / rand3 * Math.Sin((float)x / flatness * rand3 + rand3);

                height2 += offset;

                terrainContour[x] = (int)height2;

            }

            for (int x = 0; x < mapAttributes.GetLength(0); x++)
            {
                for (int y = 0; y < mapAttributes.GetLength(1); y++)
                {

                    if (y < Math.Abs(terrainContour[x]))
                    {
                        // sets blank tiles
                        mapAttributes[x, y] = 0;
                    }
                    if (y == Math.Abs(terrainContour[x]) && mapAttributes[x, y] != 0)
                    {
                        // sets grass
                        mapAttributes[x, y] = 31;
                    }

                    if (y == Math.Abs(terrainContour[x]) && x == mapAttributes.GetLength(0) / 2)
                    {
                        playerStart = new Vector2(x * 32, y * 32 - 64);


                    }
                }
            }
        }
        void GennerateFlatWorld(int width, int height)
        {
            int halfSize = height / 2;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < halfSize; y++)
                {
                    mapAttributes[x, y] = 0;
                }
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = halfSize; y < height; y++)
                {
                    mapAttributes[x, y] = 23;
                }
            }
            int mapX = mapAttributes.GetLength(0) / 2;
            int mapY = mapAttributes.GetLength(1) / 2;
            playerStart = new Vector2(mapX * 32, mapY * 32 - 64);
        }

        public float[,] WhiteNoise(int width, int height)
        {
            Random random = new Random(seed);

            float[,] noise = new float[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    noise[x, y] = (float)random.NextDouble() % 1;
                }
            }
            return noise;
        }

        float[,] GenerateSmoothNoise(float[,] baseNoise, int octave)
        {


            int width = baseNoise.GetLength(0);
            int height = baseNoise.GetLength(1);

            float[,] smoothNoise = new float[width, height];

            int samplePeriod = 1 << octave;

            float sampleFrequency = 1.0f / samplePeriod;

            for (int x = 0; x < width; x++)
            {
                int sample1 = (x / samplePeriod) * samplePeriod;
                int sample2 = (sample1 + samplePeriod) % width;
                float horizonalBlend = (x - sample1) * sampleFrequency;

                for (int y = 0; y < height; y++)
                {
                    int sampley1 = (y / samplePeriod) * samplePeriod;
                    int sampley2 = (sampley1 + samplePeriod) % height;
                    float verticleBlend = (y - sampley1) * sampleFrequency;


                    float top = Interpolate(baseNoise[sample1, sampley1], baseNoise[sample2, sampley1], horizonalBlend);

                    float bottotm = Interpolate(baseNoise[sample1, sampley2], baseNoise[sample2, sampley2], horizonalBlend);

                    smoothNoise[x, y] = Interpolate(top, bottotm, verticleBlend);
                }
            }
            return smoothNoise;
        }



        float[,] GeneratePerlinNoise(float[,] baseNoise, int OctaveCount)
        {
            int width = baseNoise.GetLength(0);
            int height = baseNoise.GetLength(1);

            float[][,] smoothNoise = new float[OctaveCount][,];


            lua.DoFile("LuaScripts/world_properties.lua");

            float persistence = (float)((double)lua["persistence"]); 

            for (int i = 0; i < OctaveCount; i++)
            {
                smoothNoise[i] = GenerateSmoothNoise(baseNoise, i);

            }

            float[,] perlinNoise = new float[width, height];
            float amplitude = (float)((double)lua["amplitude"]); 
            float totalAmp = 0.0f;


            for (int octave = OctaveCount - 1; octave > 0; octave--)
            {
                amplitude *= persistence;
                totalAmp += amplitude;

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        perlinNoise[x, y] += smoothNoise[octave][x, y] * amplitude;
                    }
                }
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    perlinNoise[x, y] /= totalAmp;
                }
            }

            return perlinNoise;
        }
        
        float Interpolate(float x0, float x1, float alpha)
        {
            return x0 * (1 - alpha) + alpha * x1;
        }
        #endregion

        public void Update(GameTime gameTime, Game1 game)
        {
            keyboardState = Keyboard.GetState();

            oldKeyoardState = keyboardState;
            /// Current Chunk
            if (((int)game.player.position.X / 1024) < chunks.GetLength(0) && ((int)game.player.position.X / 1024) >= 0)
            {
                if (((int)game.player.position.Y / 1024) < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) >= 0)
                {
                    chunks[((int)game.player.position.X / 1024), ((int)game.player.position.Y / 1024)].Update(gameTime, game.player, game);
                    // Console.WriteLine(((int)player.position.X / 1024) +" "+ ((int)player.position.Y / 1024));
                }

            }

            // Left Chunk
            if (((int)game.player.position.X / 1024) - 1 < chunks.GetLength(0) && ((int)game.player.position.X / 1024) - 1 >= 0)
            {
                if (((int)game.player.position.Y / 1024) < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) >= 0)
                {
                    chunks[((int)game.player.position.X / 1024) - 1, ((int)game.player.position.Y / 1024)].Update(gameTime, game.player, game);
                    // Console.WriteLine( (int)(player.position.X / 1024) - 1+ " "+ ((int)player.position.Y / 1024));
                }

            }
            // Right Chunk
            if (((int)game.player.position.X / 1024) + 1 < chunks.GetLength(0) && ((int)game.player.position.X / 1024) + 1 >= 0)
            {
                if (((int)game.player.position.Y / 1024) < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) >= 0)
                {
                    chunks[((int)game.player.position.X / 1024) + 1, ((int)game.player.position.Y / 1024)].Update(gameTime,game.player, game);
                    //Console.WriteLine(((int)player.position.X / 1024) + 1 +" "+ ((int)player.position.Y / 1024));
                }

            }
            // Down Chunk
            if (((int)game.player.position.X / 1024) < chunks.GetLength(0) && ((int)game.player.position.X / 1024) >= 0)
            {
                if (((int)game.player.position.Y / 1024) + 1 < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) + 1 >= 0)
                {
                    chunks[((int)game.player.position.X / 1024), ((int)game.player.position.Y / 1024) + 1].Update(gameTime, game.player, game);
                    //Console.WriteLine(((int)player.position.X / 1024)  + " " + ((int)player.position.Y / 1024) + 1
                }

            }
            // Up Chunk
            if (((int)game.player.position.X / 1024) < chunks.GetLength(0) && ((int)game.player.position.X / 1024) >= 0)
            {
                if (((int)game.player.position.Y / 1024) - 1 < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) - 1 >= 0)
                {
                    chunks[((int)game.player.position.X / 1024), ((int)game.player.position.Y / 1024) - 1].Update(gameTime, game.player, game);

                }

            }

            // Right Down Chunk
            if (((int)game.player.position.X / 1024) + 1 < chunks.GetLength(0) && ((int)game.player.position.X / 1024) + 1 >= 0)
            {
                if (((int)game.player.position.Y / 1024) + 1 < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) + 1 >= 0)
                {
                    chunks[((int)game.player.position.X / 1024) + 1, ((int)game.player.position.Y / 1024) + 1].Update(gameTime, game.player, game);
                }

            }
            // Left Up Chunk
            if (((int)game.player.position.X / 1024) - 1 < chunks.GetLength(0) && ((int)game.player.position.X / 1024) - 1 >= 0)
            {
                if (((int)game.player.position.Y / 1024) - 1 < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) - 1 >= 0)
                {
                    chunks[((int)game.player.position.X / 1024) - 1, ((int)game.player.position.Y / 1024) - 1].Update(gameTime, game.player, game);
                }

            }
            // Right Up Chunk
            if (((int)game.player.position.X / 1024) + 1 < chunks.GetLength(0) && ((int)game.player.position.X / 1024) + 1 >= 0)
            {
                if (((int)game.player.position.Y / 1024) - 1 < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) - 1 >= 0)
                {
                    chunks[((int)game.player.position.X / 1024) + 1, ((int)game.player.position.Y / 1024) - 1].Update(gameTime, game.player, game);
                }

            }
            // Left Down Chunk
            if (((int)game.player.position.X / 1024) - 1 < chunks.GetLength(0) && ((int)game.player.position.X / 1024) - 1 >= 0)
            {
                if (((int)game.player.position.Y / 1024) + 1 < chunks.GetLength(1) && ((int)game.player.position.Y / 1024) + 1 >= 0)
                {
                    chunks[((int)game.player.position.X / 1024) - 1, ((int)game.player.position.Y / 1024) + 1].Update(gameTime, game.player, game);
                }

            }
            gme = game; 
        }

        void Final()
        {
            for(int x = 0; x < mapAttributes.GetLength(0); x++)
            {
                for(int y = 0; y < mapAttributes.GetLength(1); y++)
                {
                    VectorToList(x, y);
                    ValueToList(x, y); 
                }
            }

            int i = 0; 
            for (int x = 0; x < mapAttributes.GetLength(0); x++)
            {
                for (int y = 0; y < mapAttributes.GetLength(1); y++)
                {
                    tile[x, y].position = nTilePosition[i];
                    tile[x,y].index = nTileValue[i];
                    tile[x,y].Final(this);
                    i++; 
                }
            }
            Console.WriteLine("Finalized Tiles");
            nTilePosition = null;
            nTileValue = null;


            Console.WriteLine(mapAttributes.GetLength(0) /32);
            Console.WriteLine(mapAttributes.GetLength(1) / 32);
            Tile[,] tempChunk = new Tile[32, 32];

            Console.WriteLine("Generating Chunks");
            for (int x = 0; x < mapAttributes.GetLength(0) /32 ; x++)
            {
                for (int y = 0; y < mapAttributes.GetLength(1) / 32; y++)
                {
                    
                    for (int cX = 0; cX < 32; cX++)
                    {
                        for (int cY = 0; cY < 32; cY++)
                        {
                            tempChunk[cX, cY] = tile[(x * 32) + cX, (y * 32) + cY];
                        }
                    }
                    chunks[x, y].SetChunkPosition(x, y);
                    chunks[x, y].SetChunks(tempChunk);

                    //Console.WriteLine("Chunk Set");
                }
            }
            
            Console.WriteLine("Chunks Finished");
            tile = null; 

        }

        public void ChangeTile(int chunkX, int chunkY, int x, int y, int id, TileMap tileMap)
        {
            chunks[chunkX, chunkY].tiles[x, y].UpdateIndex(id, contentManager);

        }
        public void DamageTile(int x, int y, float ammount)
        {
            tile[x, y].DamageTile(ammount);
        }
        public void DamageTile(int chunkX, int chunkY, int x, int y, float ammount)
        {
            if(chunks[chunkX, chunkY].tiles[x, y].index != 61)
            {
                if(chunks[chunkX, chunkY].tiles[x, y].index != 62)
                {
                    if(chunks[chunkX, chunkY].tiles[x, y].index != 63)
                    {
                        if(chunks[chunkX, chunkY].tiles[x, y].index != 64)
                        {
                            if(chunks[chunkX, chunkY].tiles[x, y].index != 65)
                            {
                                if(chunks[chunkX, chunkY].tiles[x, y].index != 66)
                                {
                                    if(chunks[chunkX, chunkY].tiles[x, y].index != 67)
                                    {
                                        if(chunks[chunkX, chunkY].tiles[x, y].index != 68)
                                        {
                                            chunks[chunkX, chunkY].tiles[x, y].DamageTile(ammount);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }

        /// <summary>
        /// Find Tile Chunk Index and Tile Index
        /// </summary>
        /// <param name="position"></param>
        /// <returns>Coordinate</returns>
        public Coordinate FindTile(Vector2 position)
        {
            Coordinate coordinate; 
            coordinate.chunkX = (int)position.X / 1024;
            coordinate.chunkY = (int)position.Y / 1024;
            coordinate.tileX = ((int)position.X % 1024) / 32;
            coordinate.tileY = ((int)position.Y % 1024) / 32;
            return coordinate; 
        }
        /// <summary>
        /// Gives the Tile from Vector2
        /// </summary>
        /// <param name="position"></param>
        /// <returns>Tile</returns>
        public Tile GetTile(Vector2 position)
        {
            
            int _tileX;
            int _tileY;
            int _chunkX;
            int _chunkY;

            _tileX = FindTile(position).tileX;
            _tileY = FindTile(position).tileY;
            _chunkX = FindTile(position).chunkX;
            _chunkY = FindTile(position).chunkY;

            return chunks[_chunkX, _chunkY].tiles[_tileX, _tileY]; 
        }


        

        public void Draw(SpriteBatch spriteBatch, Player player)
        {

            // Current Chunk
            if (((int)player.position.X / 1024) < chunks.GetLength(0) && ((int)player.position.X / 1024) >= 0 )
            {
                if (((int)player.position.Y / 1024) < chunks.GetLength(1) && ((int)player.position.Y / 1024) >= 0)
                {
                    chunks[((int)player.position.X / 1024), ((int)player.position.Y / 1024)].Draw(spriteBatch, player);
                   // Console.WriteLine(((int)player.position.X / 1024) +" "+ ((int)player.position.Y / 1024));
                }

            }

            // Left Chunk
            if (((int)player.position.X / 1024) - 1 < chunks.GetLength(0) && ((int)player.position.X / 1024) - 1 >= 0)
            {
                if (((int)player.position.Y / 1024) < chunks.GetLength(1) && ((int)player.position.Y / 1024) >= 0)
                {
                    chunks[((int)player.position.X / 1024) - 1, ((int)player.position.Y / 1024)].Draw(spriteBatch, player);
                   // Console.WriteLine( (int)(player.position.X / 1024) - 1+ " "+ ((int)player.position.Y / 1024));
                }

            }
            // Right Chunk
            if (((int)player.position.X / 1024) +  1< chunks.GetLength(0) && ((int)player.position.X / 1024) + 1 >= 0)
            {
                if (((int)player.position.Y / 1024)< chunks.GetLength(1) && ((int)player.position.Y / 1024) >= 0)
                {
                    chunks[((int)player.position.X / 1024) + 1, ((int)player.position.Y / 1024)].Draw(spriteBatch, player);
                    //Console.WriteLine(((int)player.position.X / 1024) + 1 +" "+ ((int)player.position.Y / 1024));
                }

            }
            // Down Chunk
            if (((int)player.position.X / 1024)  < chunks.GetLength(0) && ((int)player.position.X / 1024) >= 0)
            {
                if (((int)player.position.Y / 1024) + 1 < chunks.GetLength(1) && ((int)player.position.Y / 1024) + 1 >= 0)
                {
                    chunks[((int)player.position.X / 1024), ((int)player.position.Y / 1024) + 1].Draw(spriteBatch, player);
                    //Console.WriteLine(((int)player.position.X / 1024)  + " " + ((int)player.position.Y / 1024) + 1);
                }

            }
            // Up Chunk
            if (((int)player.position.X / 1024) < chunks.GetLength(0) && ((int)player.position.X / 1024) >= 0)
            {
                if (((int)player.position.Y / 1024) - 1 < chunks.GetLength(1) && ((int)player.position.Y / 1024) - 1 >= 0)
                {
                    chunks[((int)player.position.X / 1024), ((int)player.position.Y / 1024) - 1].Draw(spriteBatch, player);

                }

            }

            // Right Down Chunk
            if (((int)player.position.X / 1024) + 1 < chunks.GetLength(0) && ((int)player.position.X / 1024) + 1 >= 0)
            {
                if (((int)player.position.Y / 1024) + 1 < chunks.GetLength(1) && ((int)player.position.Y / 1024) + 1 >= 0)
                {
                    chunks[((int)player.position.X / 1024) + 1, ((int)player.position.Y / 1024) + 1].Draw(spriteBatch, player);
                }

            }
            // Left Up Chunk
            if (((int)player.position.X / 1024) - 1 < chunks.GetLength(0) && ((int)player.position.X / 1024) - 1 >= 0)
            {
                if (((int)player.position.Y / 1024) - 1 < chunks.GetLength(1) && ((int)player.position.Y / 1024) - 1 >= 0)
                {
                    chunks[((int)player.position.X / 1024) - 1, ((int)player.position.Y / 1024) - 1].Draw(spriteBatch, player);
                }

            }
            // Right Up Chunk
            if (((int)player.position.X / 1024) + 1 < chunks.GetLength(0) && ((int)player.position.X / 1024) + 1 >= 0)
            {
                if (((int)player.position.Y / 1024) - 1 < chunks.GetLength(1) && ((int)player.position.Y / 1024) - 1 >= 0)
                {
                    chunks[((int)player.position.X / 1024) + 1, ((int)player.position.Y / 1024) - 1].Draw(spriteBatch, player);
                }

            }
            // Left Down Chunk
            if (((int)player.position.X / 1024) - 1 < chunks.GetLength(0) && ((int)player.position.X / 1024) - 1 >= 0)
            {
                if (((int)player.position.Y / 1024) + 1 < chunks.GetLength(1) && ((int)player.position.Y / 1024) + 1 >= 0)
                {
                    chunks[((int)player.position.X / 1024) - 1, ((int)player.position.Y / 1024) + 1].Draw(spriteBatch, player);
                }

            }

        }
    }
}
