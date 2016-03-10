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
    public class QuarryManagement
    {
        public List<QuarryDrill> drills;
        public List<Thread> threads;
        Thread thread; 
        public QuarryManagement()
        {
            drills = new List<QuarryDrill>();
            threads = new List<Thread>(); 
        }

        public void Update(GameTime gameTime, Game1 gme)
        {
            
            foreach (QuarryDrill qDrill in drills)
            {
                if (qDrill.tile.tileType == Tile.TileType.QuarryBlock)
                {
                    
                    // comented 
                   // qDrill.tile.Update(gameTime, gme.player, gme, gme.tileMap);

                    #region // Loading All Tiles around drill
                    for (int x = (int)(qDrill.position.X - (int)(qDrill.chunkRadius)) / 32; x < (((qDrill.position.X) + (qDrill.chunkRadius)) / 32); x++)
                    {
                        for (int y = (int)((qDrill.position.Y) - (int)(qDrill.chunkRadius)) / 32; y < (((qDrill.position.Y) + (qDrill.chunkRadius)) / 32); y++)
                        {
                            qDrill.X = Math.Abs(x);
                            qDrill.Y = Math.Abs(y);

                            /*
                            //tiles[tile[X, Y]].Draw(spriteBatch);
                            if (qDrill.X < qDrill.game2.tileMap.chunks.GetLength(0) && qDrill.Y < qDrill.game2.tileMap.chunks.GetLength(1))
                            {
                                // commented 
                              //  qDrill.game2.tileMap.tile[qDrill.X, qDrill.Y].Update(gameTime, qDrill.game2.player, qDrill.game2, qDrill.game2.tileMap);
                            }
                            */
                        }
                    }
                    #endregion

                }
            }
            for(int i = 0; i < drills.Count; i++)
            {
                if (drills[i].tile.tileType != Tile.TileType.QuarryBlock)
                {
                    drills.RemoveAt(i);

                }

            }
        }
        public void Draw(SpriteBatch spriteBatch, Game1 gme)
        {
            foreach (QuarryDrill qDrill in drills)
            {
                if (qDrill.tile.tileType == Tile.TileType.QuarryBlock)
                {
                    qDrill.tile.Draw(spriteBatch, gme.player);
                }
            }
        }
    }
}
