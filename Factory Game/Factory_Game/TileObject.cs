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
    class TileObject
    {
        Vector2 position;
        Texture2D objectTexture;
        Tile.TileType type;
        Rectangle tileBounds;
        Rectangle rect;
        public TileObject(Vector2 pos, Tile.TileType typ)
        {
            position = pos; 
            type = typ; 

        }
        public void LoadContent(ContentManager content)
        {
            switch (type)
            {
                case Tile.TileType.DryTile1:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile1Item");
                        break;
                    }
                case Tile.TileType.DryTile2:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile2Item");
                        break;
                    }
                case Tile.TileType.DryTile3:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/DryTile3Item");
                        break; 
                    }
                case Tile.TileType.Granite1:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite1Item");
                        break;
                    }
                case Tile.TileType.Granite2:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite2Item");
                        break; 
                    }
                case Tile.TileType.Granite3:
                    {
                        objectTexture = content.Load<Texture2D>("TileObjects/Granite3Item");
                        break;
                    }
                case Tile.TileType.Grass1:
                    {

                        break;
                    }
                case Tile.TileType.Grass2:
                    {

                        break;
                    }
                case Tile.TileType.Grass3:
                    {

                        break; 
                    }

            }
            rect = new Rectangle((int)position.X, (int)position.Y, objectTexture.Width, objectTexture.Height); 
        }

        public void Update(GameTime gameTime)
        {
            
        }
        public void Collision(Rectangle bounds)
        {
            tileBounds = bounds;

            Vector2 debth = RectangleExtensions.GetIntersectionDepth(rect, bounds);

            if (debth != Vector2.Zero)
            {
                float absDebthX = Math.Abs(debth.X);
                float absDebthy = Math.Abs(debth.Y);

                if (absDebthy < absDebthX)
                {
                    position = new Vector2(position.X, position.Y + debth.Y);
                }
                else
                {
                    position = new Vector2(position.X + debth.X, position.Y);
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(objectTexture, position, Color.White); 
        }
    }
}
