﻿using System;
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
    public class QuarryManagement
    {
        public List<QuarryDrill> drills;
        public QuarryManagement()
        {
            drills = new List<QuarryDrill>(); 
        }

        public void Update(GameTime gameTime, Game1 gme)
        {
            foreach (QuarryDrill qDrill in drills)
            {
                if (qDrill.tile.tileType == Tile.TileType.QuarryBlock)
                {
                    qDrill.tile.Update(gameTime, gme.player, gme, gme.tileMap); 
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
                    qDrill.tile.Draw(spriteBatch);
                }
            }
        }
    }
}
