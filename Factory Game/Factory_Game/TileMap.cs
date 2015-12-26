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
        private int[,] mapAttributes;
        private int[,] mapSize;
        private Random random;
        int seed;
        private List<int> tileTypes = new List<int>()
        {
            8,
            2,
            5,
        };
        // lists
        private List<Tile> tiles = new List<Tile>();
        List<Vector2> nTilePosition = new List<Vector2>();
        List<int> nTileValue = new List<int>(); 
        KeyboardState keyboardState;
        KeyboardState oldKeyoardState;

        Game1 gme; 
        public TileMap(int[,] size, int sed)
        {
            seed = sed; 
            mapSize = size;
            mapAttributes = mapSize;
            Console.WriteLine("Map Size: " + mapSize.Length);
            Console.WriteLine("Map Attribute Size: " + mapAttributes.Length);
            random = new Random();

            Console.WriteLine("map size" + mapSize.Length.ToString());

            int range = random.Next(5, 15);


            int mapCount = 0;

            for (int x = 0; x < mapSize.GetLength(0); x++)
            {
                for (int y = 0; y < mapSize.GetLength(1); y++)
                {
                    mapSize[x, y] = mapCount;
                    mapAttributes[x, y] = 0;
                    mapCount++;
                }
            }

            MapGeneration(size.GetLength(0), size.GetLength(1));

            Final(); 
        }

        void MapGeneration(int width, int height)
        {
            float[,] preGenMap = WhiteNoise(width, height);

            float[,] postGenMap = GeneratePerlinNoise(preGenMap, 5);

            
            for (int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                   // Console.WriteLine(postGenMap[x,y]);

                    if (postGenMap[x,y] <= .3f && postGenMap[x,y] >= .0f)
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
                        if (postGenMap[x, y] <= .65f && postGenMap[x, y] >= .6f)
                        {
                            mapAttributes[x, y] = 5;
                        }
                    }
                    if (postGenMap[x, y] <= .9f && postGenMap[x, y] >= .7f)
                    {
                        mapAttributes[x, y] = 0;
                    }
                }
            }

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

            foreach (int i in mapSize)
            {
                tiles.Add(new Tile());
            }

            foreach (Tile ti in tiles)
            {
                ti.LoadContent(content);
            }

            Final();
        }

        
        public float[,] WhiteNoise(int width, int height)
        {
            Random random = new Random(seed);

            float[,] noise = new float[width, height]; 

            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
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
            
            for(int x = 0; x < width; x++)
            {
                int sample1 = (x / samplePeriod) * samplePeriod;
                int sample2 = (sample1 + samplePeriod) % width;
                float horizonalBlend = (x - sample1) * sampleFrequency; 

                for(int y = 0; y < height; y++)
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

            for(int i = 0; i < OctaveCount; i++)
            {
                smoothNoise[i] = GenerateSmoothNoise(baseNoise, i); 
               
            }

            float[,] perlinNoise = new float[width, height];
            float amplitude = 12;
            float totalAmp = 0.0f; 


            for(int octave = OctaveCount - 1; octave > 0; octave--)
            {
                amplitude *= persistence;
                totalAmp += amplitude; 

                for(int x = 0; x < width; x++)
                {
                    for(int y = 0; y < height; y++)
                    {
                        perlinNoise[x, y] += smoothNoise[octave][x, y] * amplitude; 
                    }
                }
            }

            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
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


        public void Update(GameTime gameTime, Game1 game)
        {
            keyboardState = Keyboard.GetState();

            oldKeyoardState = keyboardState;

            foreach(Tile ti in tiles)
            {
                ti.Update(gameTime, game.player, game); 
            }
            gme = game; 
        }

        void Final()
        {
            for(int x = 0; x < mapSize.GetLength(0); x++)
            {
                for(int y = 0; y < mapSize.GetLength(1); y++)
                {
                    VectorToList(x, y);
                    ValueToList(x, y); 
                }
            }

            for(int i = 0; i < tiles.Count; i++)
            {
                tiles[i].position = nTilePosition[i];
                tiles[i].index = nTileValue[i]; 
                tiles[i].Final(); 
            }
        }

        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            
            foreach(Tile ti in tiles)
            {
                ti.Draw(spriteBatch); 
            }
            

        }
    }
}
