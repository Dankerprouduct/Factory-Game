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
using System.Threading; 
namespace Factory_Game
{
    public class QuarryDrill
    {

        Texture2D drillTexture;
        Texture2D tubeTexture;
        // 250
        TimeSpan time = TimeSpan.FromMilliseconds(50);
        TimeSpan lastTime;
        public Rectangle rect;
        public Vector2 position; 
        int height;
        int width;
        int x = 0;
        int y = 0;
        public int X;
        public int Y; 
        public int chunkRadius = 1; 
        Vector2[,] quarryPositions;
        public Tile tile;
        public bool alive;
        public Game1 game2;
        public GameTime gameTime2;
        // position 1
        // position 2
        int tileX;
        int tileY;
        int chunkX;
        int chunkY;

        int tileX2;
        int tileY2;
        int chunkY2;
        int chunkX2; 
        public QuarryDrill(Vector2 pos1, Vector2 pos2, int hight, Game1 game, Tile mtile)
        {
            tileX = game.tileMap.FindTile(pos1).tileX;
            tileY = game.tileMap.FindTile(pos1).tileY;
            chunkX = game.tileMap.FindTile(pos1).chunkX;
            chunkY = game.tileMap.FindTile(pos1).chunkY;

            tileX2 = game.tileMap.FindTile(pos2).tileX;
            tileY2 = game.tileMap.FindTile(pos2).tileY;
            chunkX2 = game.tileMap.FindTile(pos2).chunkX;
            chunkY2 = game.tileMap.FindTile(pos2).chunkY;
            tile = mtile;
            width = Math.Abs(((int)pos1.X / 32) - ((int)pos2.X / 32) - 1);
            height = Math.Abs(((int)pos1.Y /32) - game.mapSize.GetLength(1));
            height += 7;

            quarryPositions = new Vector2[width, height];  
            
            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    quarryPositions[x, y] = new Vector2((((int)pos1.X / 32) + x) * 32, (((int)pos1.Y / 32) + y - hight) * 32);
                }
            }
            position = quarryPositions[0, 0]; 
        }

        public void LoadContent(ContentManager content)
        {
            chunkRadius = chunkRadius * 32; 
            drillTexture = content.Load<Texture2D>("Tiles/ConstructionDrillBit");
            tubeTexture = content.Load<Texture2D>("Tiles/ConstructionTube");
           
        }
        public void Update(GameTime gameTime, Game1 game)
        {
            //alive = tile.alive;
            gameTime2 = gameTime;
            game2 = game; 
            if(lastTime + time < gameTime.TotalGameTime)
            {
                position = Vector2.Lerp(position, quarryPositions[x, y], 1f);
                x++;
                if (x >= width)
                {
                    y++;
                    x = 0;
                    if(y >= height)
                    {
                        y = 0; 
                    }
                }

                lastTime = gameTime.TotalGameTime;

            }

            rect = new Rectangle((int)position.X, (int)position.Y, drillTexture.Width, drillTexture.Height);


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            for (int i = 1; i < y; i++)
            {
                 spriteBatch.Draw(tubeTexture, new Vector2(position.X, position.Y - (32 * i)), Color.White);
            }
            if (y > 0)
            {
                spriteBatch.Draw(tubeTexture, new Vector2(position.X, quarryPositions[0, 0].Y), Color.White);
            }
            spriteBatch.Draw(drillTexture, position, Color.White);

        }
    }
}
