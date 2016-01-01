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
        TimeSpan time = TimeSpan.FromMilliseconds(250); 
        TimeSpan lastTime;
        public Rectangle rect;
        Vector2 position; 
        int height;
        int width;
        int x = 0;
        int y = 0;
        int chunkRadius = 800; 
        Vector2[,] quarryPositions;
        public Tile tile;
        public bool alive;  
        public QuarryDrill(int xPos, int yPos, int xxPos, int yyPos, int hight, TileMap tileMap, Tile mTile)
        {
            tile = mTile; 
            width = Math.Abs(xPos - xxPos - 1);
            height = Math.Abs(yPos - tileMap.tile.GetLength(1));

            quarryPositions = new Vector2[width, height]; 

            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    quarryPositions[x, y] = new Vector2((xPos + x) * 32, (yPos + y - hight) * 32);
                   // Console.WriteLine(quarryPositions[x, y]); 
                }
            }

            //start x = xpos * 32 
            // x = xpos + i * 32
            
            position = quarryPositions[0, 0]; 
        }
        public void LoadContent(ContentManager content)
        {
            drillTexture = content.Load<Texture2D>("Tiles/ConstructionDrillBit");
            tubeTexture = content.Load<Texture2D>("Tiles/ConstructionTube");
           
        }
        public void Update(GameTime gameTime, Game1 game)
        {
            alive = tile.alive; 
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

                #region // Loading All Tiles around drill
                for (int x = (int)(position.X - (int)(chunkRadius)) / 32; x < (((position.X) + (chunkRadius)) / 32); x++)
                {
                    for (int y = (int)((position.Y) - (int)(chunkRadius)) / 32; y < (((position.Y) + (chunkRadius)) / 32); y++)
                    {
                        int X = Math.Abs(x);
                        int Y = Math.Abs(y);

                        //tiles[tile[X, Y]].Draw(spriteBatch);
                        if (X < game.tileMap.tile.GetLength(0) && Y < game.tileMap.tile.GetLength(1))
                        {
                            game.tileMap.tile[X, Y].Update(gameTime, game.player, game, game.tileMap);
                        }
                    }
                }
#endregion
            }

            rect = new Rectangle((int)position.X, (int)position.Y, drillTexture.Width, drillTexture.Height);

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 1; i < y; i++)
            {
                spriteBatch.Draw(tubeTexture, new Vector2(position.X, position.Y - (32 * i)), Color.White);
            }            if (y > 0)

            {
                spriteBatch.Draw(tubeTexture, new Vector2(position.X, quarryPositions[0, 0].Y), Color.White);
            }
            spriteBatch.Draw(drillTexture, position, Color.White);

        }
    }
}
