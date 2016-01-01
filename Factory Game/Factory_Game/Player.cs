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
    public class Player : GameObject
    {
      //  public float j = 1; 
        // input
        KeyboardState keyboardState;
        KeyboardState oldKeboardState;

        public bool canBreak; 
        public bool jumping;
        public Rectangle rect;
        public bool colliding;
        Rectangle tileBounds;
        MouseState mouseState;
        Vector2 mousePosition;
        Vector2 worldPosition;
        int xCord;
        int yCord;
        public Inventory inventory;
        public ItemDatabase itemDatabase;  
        public Player(Vector2 startPosition)
        {
            inventory = new Inventory();
            inventory.inventoryType = Inventory.InventoryType.PlayerInventory; 
            position = startPosition;
            // regular = 3 
            speed = 3; 
            
        }
        public void LoadContent(ContentManager content)
        {
            itemDatabase = new ItemDatabase(content); 
            texture = content.Load<Texture2D>("Sprites/TempPlayer");
            inventory.LoadContent(content);
        }
        public void Update(GameTime gameTime, Game1 game)
        {
            keyboardState = Keyboard.GetState();
            Movement();
            
            if(keyboardState.IsKeyDown(Keys.B) && oldKeboardState.IsKeyUp(Keys.B))
            {
                canBreak = !canBreak;
            }
            inventory.Update(gameTime, game);
            MouseMovement(game.camera, game.tileMap);
            oldKeboardState = keyboardState; 
            
        }
        void Movement()
        {
            rect = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            position += velocity;
            if (keyboardState.IsKeyDown(Keys.D))
            {
                velocity.X = speed;
            }
            else if(keyboardState.IsKeyDown(Keys.A))
            {
                velocity.X = -speed;
            }
            else
            {
                velocity.X = 0; 
            }

            if (keyboardState.IsKeyDown(Keys.Space) && !jumping)
            {
              //  position = new Vector2(0, 0); 
                position.Y -= 10;
                // regular 5
                velocity.Y = -5;
                jumping = true;


            }
            if (canBreak)
            {
                if (keyboardState.IsKeyDown(Keys.Space))
                {
                    velocity.Y = -speed;
                }
                else
                {
                    velocity.Y = 0; 
                }
            }
            else
            {

            }
            if (jumping)
            {
                float i = 1;
                velocity.Y += .25f * i;
                
            }
            if (!jumping)
            {
                
                velocity.Y = 1; 
            }



            if (rect.Intersects(tileBounds))
            {
                jumping = false; 
            }
            else
            {
                jumping = true; 
            }

        }
        
        /// <summary>
        /// Tile and Inventory interaction 
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="tileMap"></param>
        void MouseMovement(Camera camera, TileMap tileMap)
        {
            if (!inventory.showInventory)
            {
                mouseState = Mouse.GetState();
                mousePosition = new Vector2(mouseState.X, mouseState.Y);
                worldPosition = Vector2.Transform(mousePosition, Matrix.Invert(camera.rawTransform));

                //  Console.WriteLine(worldPosition.X);
                //   Console.WriteLine(worldPosition.Y); 
                xCord = Convert.ToInt32(worldPosition.X) / 32;
                yCord = Convert.ToInt32(worldPosition.Y) / 32;

                if (xCord < tileMap.tile.GetLength(0) && xCord >= 0 && yCord < tileMap.tile.GetLength(1) && yCord >= 0)
                {
                    if (mouseState.RightButton == ButtonState.Pressed)
                    {
                        /*
                        if (inventory.itemIndex[inventory.selectedItem] > 0)
                        {
                            if (tileMap.tile[xCord, yCord].index == 0)
                            {
                                tileMap.ChangeTile(xCord, yCord, inventory.tileType);
                                inventory.itemIndex[inventory.selectedItem]--;
                            }
                        }
                        */
                        if(inventory.inventory[inventory.selectedItem].count > 0)
                        {
                            // only place if on blank tile 
                            if (tileMap.tile[xCord, yCord].index == 0)
                            {
                                tileMap.ChangeTile(xCord, yCord, inventory.inventory[inventory.selectedItem].item.tileType);
                                inventory.inventory[inventory.selectedItem].count--; 
                                if(inventory.inventory[inventory.selectedItem].count <= 0)
                                {
                                    inventory.RemoveItem(inventory.inventory[inventory.selectedItem].item); 
                                }
                            }
                        }

                    }
                    if (mouseState.LeftButton == ButtonState.Pressed)
                    {
                        tileMap.DamageTile(xCord, yCord, 10f);
                    }
                }
            }
        }

        public void Collision(Rectangle bounds) 
        {

            tileBounds = bounds;

            jumping = false;

            Vector2 debth = RectangleExtensions.GetIntersectionDepth(rect, bounds); 
            
            if(debth != Vector2.Zero)
            {
                float absDebthX = Math.Abs(debth.X);
                float absDebthy = Math.Abs(debth.Y);

                if(absDebthy < absDebthX)
                {
                    position = new Vector2(position.X, position.Y + debth.Y + 1);
                }
                else
                {
                    position = new Vector2(position.X + debth.X, position.Y); 
                }
            }

            
        }

               
        
        public void Draw(SpriteBatch spriteBatch)
        {
            int previous = (int)position.Y;
            int averagePosY = (int)Math.Floor(position.Y + previous) / 2;
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y), Color.White);
            inventory.Draw(spriteBatch, this); 
        }
    }
}
