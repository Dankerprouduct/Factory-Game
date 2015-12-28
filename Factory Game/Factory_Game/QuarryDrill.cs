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
    public class QuarryDrill
    {
        Vector2 startPositionX;
        Vector2 endPositionX;
        Texture2D drillTexture;
        Texture2D tubeTexture;
        TimeSpan time = TimeSpan.FromMilliseconds(500); 
        TimeSpan lastTime;
        bool nextLayer;
        public Rectangle rect; 
        public QuarryDrill(Vector2 startPosX, Vector2 endPosX)
        {
            startPositionX = startPosX;
            endPositionX = endPosX;
            Console.WriteLine("A Quarry Drill has been created" + " " + startPositionX);
        }
        public void LoadContent(ContentManager content)
        {
            drillTexture = content.Load<Texture2D>("Tiles/ConstructionDrillBit");
            tubeTexture = content.Load<Texture2D>("Tiles/ConstructionTube");
            rect = new Rectangle((int)startPositionX.X, (int)startPositionX.Y, drillTexture.Width, drillTexture.Height);
        }
        public void Update(GameTime gameTime)
        {
            rect = new Rectangle((int)startPositionX.X, (int)startPositionX.Y, drillTexture.Width, drillTexture.Height);
            if (lastTime + time < gameTime.TotalGameTime)
            {
                Console.WriteLine(startPositionX); 
                lastTime = gameTime.TotalGameTime;
            }
            startPositionX = Vector2.Lerp(startPositionX, endPositionX, .05f); 
            if(startPositionX.X >= endPositionX.X - .05f)
            {
                endPositionX.Y += 32; 
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(drillTexture, startPositionX, Color.White);
           // Console.WriteLine("drawing"); 
        }
    }
}
