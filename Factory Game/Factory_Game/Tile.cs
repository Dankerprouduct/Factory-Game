using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Game
{
    public class Tile
    {
        KeyboardState keyboardState;
        public List<Texture2D> tiles = new List<Texture2D>();
        public Vector2 position;
        public int index;
        // alive - in renderbox
        bool alive = true;
        Rectangle bounds;
        int durability;
        bool draw = true;  
        public enum TileType
        {
            BlankTile, 
            DryTile1,
            DryTile2,
            DryTile3,
            Granite1,
            Granite2,
            Granite3,
            Grass1, 
            Grass2, 
            Grass3
        }
        TileType tileType; 
        public Tile()
        {
            tileType = new TileType(); 
            durability = 10; 
        }
        public void LoadContent(ContentManager content)
        {
            tiles.Add(content.Load<Texture2D>("Tiles/BlankTile")); // 0
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile1")); // 1
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile2")); // 2
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile3")); // 3 
            tiles.Add(content.Load<Texture2D>("Tiles/Granite1")); // 4
            tiles.Add(content.Load<Texture2D>("Tiles/Granite2")); // 5
            tiles.Add(content.Load<Texture2D>("Tiles/Granite3")); // 6
            tiles.Add(content.Load<Texture2D>("Tiles/Grass1"));   // 7
            tiles.Add(content.Load<Texture2D>("Tiles/Grass2"));   // 8
            tiles.Add(content.Load<Texture2D>("Tiles/Grass3"));   // 9
            tiles.Add(content.Load<Texture2D>("Tiles/Water1"));   // 10
        }
        public void Final()
        {
         bounds = new Rectangle((int)position.X, (int)position.Y, 32, 32);
         // secBounds = bounds;
          //  Console.WriteLine(bounds); 

            if(index == 0)
            {
                alive = false; 
            }

            switch (index)
            {
                case 0:
                    {
                        tileType = TileType.BlankTile; 
                        break;
                    }
                case 1:
                    {

                        tileType = TileType.DryTile1; 
                        break; 
                    }
                case 2:
                    {
                        tileType = TileType.DryTile2;
                        break; 
                    }
                case 3:
                    {
                        tileType = TileType.DryTile3;
                        break;
                    }
                case 4:
                    {
                        tileType = TileType.Granite1;
                        break;
                    }
                case 5:
                    {
                        tileType = TileType.Granite2;
                        break; 
                    }
                case 6:
                    {
                        tileType = TileType.Granite3;
                        break;
                    }
                case 7:
                    {
                        tileType = TileType.Grass1;
                        break;
                    }
                case 8:
                    {
                        tileType = TileType.Grass2;
                        break;
                    }
                case 9:
                    {
                        tileType = TileType.Grass3;
                        break;
                    }
            }

        }
        public void UpdateIndex(int indx)
        {
            index = indx;
            switch (index)
            {
                case 0:
                    {
                        tileType = TileType.BlankTile;
                        break;
                    }
                case 1:
                    {

                        tileType = TileType.DryTile1;
                        break;
                    }
                case 2:
                    {
                        tileType = TileType.DryTile2;
                        break;
                    }
                case 3:
                    {
                        tileType = TileType.DryTile3;
                        break;
                    }
                case 4:
                    {
                        tileType = TileType.Granite1;
                        break;
                    }
                case 5:
                    {
                        tileType = TileType.Granite2;
                        break;
                    }
                case 6:
                    {
                        tileType = TileType.Granite3;
                        break;
                    }
                case 7:
                    {
                        tileType = TileType.Grass1;
                        break;
                    }
                case 8:
                    {
                        tileType = TileType.Grass2;
                        break;
                    }
                case 9:
                    {
                        tileType = TileType.Grass3;
                        break;
                    }
            }
        }
        public void Update(GameTime gameTime, Player player, Game1 game)
        {

            if (alive)
            {
                if (draw)
                {
                    if (bounds.Intersects(player.rect) && index != 0)
                    {
                        player.Collision(bounds);
                        player.j = 1f;
                        // alive = false; 
                        if (player.canBreak)
                        {
                            alive = false;
                        }

                    }


                    if (durability <= 0)
                    {
                        alive = false;
                    }
                }
            }
            if (!alive)
            {
                index = 0; 
            }

            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
            if (draw)
            {
                spriteBatch.Draw(tiles[index], position, Color.White);
                //Console.WriteLine("Drawing!"); 
            }
        }
    }
}
