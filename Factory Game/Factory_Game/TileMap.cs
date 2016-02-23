using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

        List<Chunk> chunks = new List<Chunk>();

        ContentManager contentManager; 
        public static int chunkRange = 2;

        public TileMap(int[,] size, int sed, bool GenerateFlatWorld)
        {
            generateFlatWorld = GenerateFlatWorld;
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
            contentManager = content; 
            for (int x = 0; x < mapAttributes.GetLength(0); x++)
            {
                for (int y = 0; y < mapAttributes.GetLength(1); y++)
                {
                    ///     mapSize[x, y] = mapCount;
                    mapAttributes[x, y] = 0;
                    mapCount++;
                    tile[x, y] = new Tile();
                    tile[x, y].LoadContent(content);
                }
            }

            MapGeneration(mapAttributes.GetLength(0), mapAttributes.GetLength(1));

            if (!generateFlatWorld)
            {
               // GenerateHills(mapAttributes.GetLength(0), mapAttributes.GetLength(1));
            }
            else
            {
               // GennerateFlatWorld(mapAttributes.GetLength(0), mapAttributes.GetLength(1));
            }
           // Final();
        }



        #region // noise 

        void MapGeneration(int width, int height)
        {
            float[,] preGenMap = WhiteNoise(width, height);

            float[,] postGenMap = GeneratePerlinNoise(preGenMap, 6);


            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (postGenMap[x, y] <= .3f && postGenMap[x, y] >= .0f)
                    {
                        mapAttributes[x, y] = 0;
                    }
                    if (postGenMap[x, y] <= .6f && postGenMap[x, y] >= .3f)
                    {
                        mapAttributes[x, y] = 2;
                        if (postGenMap[x, y] <= .4f && postGenMap[x, y] >= .3f)
                        {
                            mapAttributes[x, y] = 3;
                        }
                    }
                    if (postGenMap[x, y] <= .7f && postGenMap[x, y] >= .6f)
                    {
                        mapAttributes[x, y] = 4;
                        // GenerateOre(x, y); 
                        if (postGenMap[x, y] <= .65f && postGenMap[x, y] >= .6f)
                        {
                            mapAttributes[x, y] = 5;
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

            float peakheight = 25;
            float flatness = 100.3234f;
            int offset = 50;

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
                        mapAttributes[x, y] = 7;
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
            int mapX = mapAttributes.GetLength(0) / 2;
            int mapY = mapAttributes.GetLength(1) / 2;
            playerStart = new Vector2(mapX * 32, mapY * 32 - 64);
        }
        void GenerateOre(int x, int y)
        {
            Random random = new Random(seed);
            int mapWidth = mapAttributes.GetLength(0);
            int mapHeight = mapAttributes.GetLength(1);
            int debth;
            //debth = random.Next(x - mapAttributes.GetLength(1), mapAttributes.GetLength(1)); 
            int oreX = x;
            int oreY = y;



            if (mapAttributes[oreX, oreY] == 4)
            {
                for (int i = 0; i < 5; i++)
                {

                    mapAttributes[x, y] = 21;

                    if (x - i < mapAttributes.GetLength(0) && x - i >= 0 && y - i < mapAttributes.GetLength(1) && y - i >= 0)
                    {
                        mapAttributes[x - i, y - i] = 21;
                    }
                    if (x + i < mapAttributes.GetLength(0) && x + i >= 0 && y + i < mapAttributes.GetLength(1) && y + i >= 0)
                    {
                        mapAttributes[x + i, y + i] = 21;
                    }
                    if (x + i < mapAttributes.GetLength(0) && x + i >= 0 && y - i < mapAttributes.GetLength(1) && y - i >= 0)
                    {
                        mapAttributes[x + i, y - i] = 21;
                    }
                    if (x - i < mapAttributes.GetLength(0) && x - i >= 0 && y + i < mapAttributes.GetLength(1) && y + i >= 0)
                    {
                        mapAttributes[x - i, y + i] = 21;
                    }

                }
            }


        }
        void GennerateOreVain(int x, int y)
        {

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

        float[,] GenerateSmoothNoise(float[,] baseNoise, int octave, int globalX, int globalY)
        {


            int width = baseNoise.GetLength(0);
            int height = baseNoise.GetLength(1);

            float[,] smoothNoise = new float[width, height];

            int samplePeriod = 1 << octave;

            float sampleFrequency = 1.0f / samplePeriod;

            for (int x = 0; x < width; x++)
            {
                //Console.WriteLine(x); 
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


            float persistence = 0.5f;

            for (int i = 0; i < OctaveCount; i++)
            {
                smoothNoise[i] = GenerateSmoothNoise(baseNoise, i);

            }

            float[,] perlinNoise = new float[width, height];
            float amplitude = 1;
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
        float[,] GeneratePerlinNoise(float[,] baseNoise, int OctaveCount, int globalX, int GlobalY)
        {
            int width = baseNoise.GetLength(0);
            int height = baseNoise.GetLength(1);

            float[][,] smoothNoise = new float[OctaveCount][,];


            float persistence = 0.5f;

            for (int i = 0; i < OctaveCount; i++)
            {
                smoothNoise[i] = GenerateSmoothNoise(baseNoise, i, globalX, GlobalY);

            }

            float[,] perlinNoise = new float[width, height];
            float amplitude = 1;
            float totalAmp = 0.0f;


            for (int octave = OctaveCount - 1; octave > 0; octave--)
            {
                amplitude *= persistence;
                totalAmp += amplitude;

                for (int x = globalX; x < width * globalX; x++)
                {
                    for (int y = GlobalY; y < height * GlobalY; y++)
                    {
                        perlinNoise[x, y] += smoothNoise[octave][x, y] * amplitude;
                    }
                }
            }

            for (int x = globalX; x < width * globalX; x++)
            {
                for (int y = GlobalY; y < height * GlobalY; y++)
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



            
            for (int x = (int)(game.camera.center.X - (int)(game.WIDTH / 2)) / 32; x < (((game.camera.center.X) + (game.WIDTH)) / 32); x++)
            {
                for (int y = (int)((game.camera.center.Y) - (int)(game.HEIGHT / 2)) / 32; y < (((game.camera.center.Y) + (game.HEIGHT)) / 32); y++)
                {
                    int X = Math.Abs(x);
                    int Y = Math.Abs(y);

                    //tiles[tile[X, Y]].Draw(spriteBatch);
                    if (X < tile.GetLength(0) && Y < tile.GetLength(1))
                    {
                        tile[X, Y].Update(gameTime, game.player, game, this);
                    }
                }
            }
            

            /*
            for (int i = 0; i < chunks.Count; i++)
            {
                chunks[i].Update(gameTime, game.player);
            }

            for (int i = 1; i < chunkRange; i++)
            {
                int playerChunkX = (int)Math.Ceiling(game.player.position.X / Chunk.GlobalWidth);
                //Console.WriteLine(playerChunkX); 
                for (int x = playerChunkX; x < playerChunkX + chunkRange; x++)
                {
                    int globalPos = x * Chunk.GlobalWidth;

                    bool foundChunk = false; 

                    for(int c = 0; c < chunks.Count; c++)
                    {
                        if(globalPos == chunks[c].position.X)
                        {
                            foundChunk = true;
                            break; 
                        }
                        else
                        {
                            foundChunk = false; 
                        }
                    }

                    if(!foundChunk)
                    {
                        // Console.WriteLine("Making new Chunk");
                        int chunkX = playerChunkX;
                        int chunkY;

                        NoiseGen noise;
                        noise = new NoiseGen();
                        noise.Scale = 1;
                        noise.Octaves = 50; 
                        float[,] postGenMap = new float[Chunk.Width, Chunk.Height];
                        for (int xx = 0; xx < Chunk.Width; xx++)
                        {
                            for (int yy = 0; yy < Chunk.Height; yy++)
                            {
                                // change y to globalposY whenever you figure that out
                                postGenMap[xx, yy] = noise.GetNoise(globalPos + xx, yy, 0);
                                
                                
                            }
                        }

                        Chunk newChunk = new Chunk(postGenMap, contentManager);
                        newChunk.SetPosition(new Vector2(globalPos, 0));
                        newChunk.LoadContent(postGenMap, contentManager);
                        Console.WriteLine("Loading Chunk Content"); 
                        
                        Console.WriteLine("Set chunk position at " + globalPos +" "+ globalPos); 
                        chunks.Add(newChunk);
                        Console.WriteLine("chunkAdded");
                        foundChunk = false; 
                    }

                }
            }
            */
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
                    tile[x,y].Final();
                    i++; 
                }
            }
        }
        public void ChangeTile(int x, int y, Tile.TileType type)
        {
            tile[x, y].UpdateIndex(type);
        }
        public void DamageTile(int x, int y, float ammount)
        {
            tile[x, y].DamageTile(ammount);
        }

        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            /*
            foreach (Tile ti in tiles)
            {
                ti.Draw(spriteBatch);
            }
            */
            
            for (int x = (int)(gme.camera.center.X - gme.WIDTH / 2) / 32; x < (((gme.camera.center.X) + (gme.WIDTH)) / 32); x++)
            {
                for(int y = (int)((gme.camera.center.Y) - (int)(gme.HEIGHT / 2)) / 32; y < (((gme.camera.center.Y) + (gme.HEIGHT)) / 32); y++)
                {
                    int X = Math.Abs(x);
                    int Y = Math.Abs(y); 

                    //tiles[tile[X, Y]].Draw(spriteBatch);
                    if(X < tile.GetLength(0) && Y < tile.GetLength(1))
                    {
                        tile[X, Y].Draw(spriteBatch, player);
                    }
                    
                }
            }
            /*
            for (int i = 0; i < chunks.Count; i++)
            {
               // Console.WriteLine(chunks.Count); 
                if (chunks[i].chunk != null)
                {
                    chunks[i].Draw(spriteBatch, player);
                }
            }
            */

        }
    }
}
