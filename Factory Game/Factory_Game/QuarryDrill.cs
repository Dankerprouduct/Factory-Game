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
        TimeSpan time = TimeSpan.FromMilliseconds(100); 
        TimeSpan lastTime;
        public Rectangle rect;
        Vector2 position; 
        int height;
        int width;
        int x = 0;
        int y = 0; 
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
            
            Console.WriteLine("width "+width);
            Console.WriteLine("height " +height);
            position = quarryPositions[1, 1]; 
        }
        public void LoadContent(ContentManager content)
        {
            drillTexture = content.Load<Texture2D>("Tiles/ConstructionDrillBit");
            tubeTexture = content.Load<Texture2D>("Tiles/ConstructionTube");
           
        }
        public void Update(GameTime gameTime)
        {
            alive = tile.alive; 
            if(lastTime + time < gameTime.TotalGameTime)
            {
                position = quarryPositions[x, y];
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
            spriteBatch.Draw(drillTexture, position, Color.White);
        }
    }
}
