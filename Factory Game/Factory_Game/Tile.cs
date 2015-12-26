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
        public List<Texture2D> tiles = new List<Texture2D>();
        public Vector2 position;
        public int index;
        // alive - in renderbox
        bool alive = true;
        Rectangle bounds;
        Rectangle secBounds;
        int durability;
        bool canBreak = false;
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;
        bool draw = true;  
        public Tile()
        {
            durability = 10; 
        }
        public void LoadContent(ContentManager content)
        {
            tiles.Add(content.Load<Texture2D>("Tiles/BlankTile")); 
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile1")); // 0
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile2")); // 1
            tiles.Add(content.Load<Texture2D>("Tiles/DryTile3")); // 2 
            tiles.Add(content.Load<Texture2D>("Tiles/Granite1")); // 3
            tiles.Add(content.Load<Texture2D>("Tiles/Granite2")); // 4
            tiles.Add(content.Load<Texture2D>("Tiles/Granite3")); // 5
            tiles.Add(content.Load<Texture2D>("Tiles/Grass1"));   // 6
            tiles.Add(content.Load<Texture2D>("Tiles/Grass2"));   // 7
            tiles.Add(content.Load<Texture2D>("Tiles/Grass3"));   // 8
            tiles.Add(content.Load<Texture2D>("Tiles/Water1"));   // 9
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
            
        }

        public void Update(GameTime gameTime, Player player, Game1 game)
        {


            if (alive)
            {
                if (bounds.Intersects(player.rect) && index != 0)
                {
                    player.Collision(bounds);
                    player.j = 1;
                    // alive = false; 
                    if (player.canBreak)
                    {
                        alive = false; 
                    }
                    
                }

                
                if(durability <= 0)
                {
                    alive = false; 
                }

            }
            if (!alive)
            {
                index = 0; 
            }
            Rectangle drawRect;
            drawRect = new Rectangle(player.rect.X - (game.WIDTH / 2) - 96,
                player.rect.Y - (game.HEIGHT / 2) - 128,
                player.rect.X + game.WIDTH + 200,
                player.rect.Y + game.HEIGHT + 350);
            
            if (bounds.Intersects(drawRect))
            {
                draw = true; 
            }
            else
            {
                draw = false; 
            }
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (draw)
            {
                spriteBatch.Draw(tiles[index], position, Color.White);
            }
        }
    }
}
