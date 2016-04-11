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
using NLua; 
namespace Factory_Game
{
    public class Player : GameObject
    {

        //  public float j = 1; 
        // input
        Lua lua; 
        KeyboardState keyboardState;
        KeyboardState oldKeboardState;
        
        public bool canBreak; 
        public bool jumping;
        public Rectangle rect;
        public bool colliding;
        Rectangle tileBounds;
        public MouseState mouseState;
        Vector2 mousePosition;
        public Vector2 worldPosition;
        int xCord;
        int yCord;
        // .25; 
        float gravity = .25f; 
        public Inventory inventory;
        public ItemDatabase itemDatabase;
        public float _fps = 0;
        public Tile tempTile;
        Vector2 startPos;
        Texture2D mouseTExture; 
        public Player(Vector2 startPosition)
        {
            inventory = new Inventory();
            inventory.inventoryType = Inventory.InventoryType.PlayerInventory;             
            startPos = startPosition; 

            // regular = 3 
            speed = 3;
            
            
        }
        public void LoadContent(ContentManager content, Game1 game)
        {
            itemDatabase = new ItemDatabase(content); 
            texture = content.Load<Texture2D>("Sprites/TempPlayer");
            mouseTExture = content.Load<Texture2D>("Sprites/MouseSelection");
            inventory.LoadContent(content, game);

            CompileLua();
        }
        public void Update(GameTime gameTime, Game1 game)
        {

            keyboardState = Keyboard.GetState();
            Movement();
            if (keyboardState.IsKeyDown(Keys.Z) && oldKeboardState.IsKeyUp(Keys.Z))
            {
                CompileLua(); 
            }
            if (keyboardState.IsKeyDown(Keys.B) && oldKeboardState.IsKeyUp(Keys.B))
            {
                canBreak = !canBreak;
               // inventory.AddToInventory(itemDatabase.items[11], 200);
            }
            if (keyboardState.IsKeyDown(Keys.O) && oldKeboardState.IsKeyUp(Keys.O))
            {
                velocity = Vector2.Zero; 

            }
            
            inventory.Update(gameTime, game);
            MouseMovement(game.camera, game.tileMap, game);
            oldKeboardState = keyboardState; 
            
        }
        public void CompileLua()
        {
            lua = new Lua();
            
            try
            {
                lua.RegisterFunction("SetPosition", this, this.GetType().GetMethod("SetPosition"));
                lua.RegisterFunction("AddToInventory", this, this.GetType().GetMethod("AddToInventory"));
                lua.RegisterFunction("StartPosition", this, this.GetType().GetMethod("StartPosition"));
                lua.RegisterFunction("SetPosition", this, GetType().GetMethod("SetPosition")); 

                lua.DoFile("LuaScripts/player_script.lua");
                gravity = (float)((double)lua["gravity"]); 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Problem with Lua: " + ex.ToString()); 
            }
            Console.WriteLine((string)lua["myvar"]); 
        }
        public void SetPosition(double x, double y)
        {
            position = new Vector2((float)x, (float)y); 
        }
        public void StartPosition()
        {
            position = startPos; 
        }
        public void AddToInventory(int id, int ammount)
        {
            inventory.AddToInventory(itemDatabase.Item(id), ammount); 
        }
        void Movement()
        {
            Vector2 oldVelocity; 
            rect = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            position += new Vector2((int)velocity.X, (int)velocity.Y);

            if(velocity.Y >= 20)
            {
                velocity.Y = 20; 
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                velocity.X = speed;

            }
            else if (keyboardState.IsKeyDown(Keys.A))
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
                speed = 12;
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
                speed = 3;
            }
            if (jumping)
            {
                float i = 1;
                velocity.Y += gravity * i;
                
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
            oldVelocity = velocity; 
        }
        
        /// <summary>
        /// Tile and Inventory interaction 
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="tileMap"></param>
        void MouseMovement(Camera camera, TileMap tileMap, Game1 game)
        {
            mouseState = Mouse.GetState();
            mousePosition = new Vector2(mouseState.X, mouseState.Y);
            worldPosition = Vector2.Transform(mousePosition, Matrix.Invert(camera.rawTransform));
            if (!inventory.showInventory)
            {
                                               

                // gets the Chunk Cord
                xCord = Convert.ToInt32(worldPosition.X) / 1024;
                yCord = Convert.ToInt32(worldPosition.Y) / 1024;


                
                if (worldPosition.X / 32< tileMap.chunks.GetLength(0) * 32 && worldPosition.X / 32 >= 0 && worldPosition.Y / 32 < tileMap.chunks.GetLength(1) * 32 && worldPosition.Y / 32 >= 0)
                {
                    if(keyboardState.IsKeyDown(Keys.E) && oldKeboardState.IsKeyUp(Keys.E))
                    {
                        Console.WriteLine("Current: " + tileMap.chunks[xCord, yCord].tiles[(((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32)].current);
                        Console.WriteLine("Type: " + tileMap.chunks[xCord, yCord].tiles[(((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32)].index.ToString());
                        Console.WriteLine("Durability: " + tileMap.chunks[xCord, yCord].tiles[(((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32)].durability.ToString());
                    }
                    if (keyboardState.IsKeyDown(Keys.V) && oldKeboardState.IsKeyUp(Keys.V))
                    {
                        tileMap.chunks[xCord, yCord].tiles[(((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32)].current = 1000; 
                        Console.WriteLine("Set Current 1000: " + tileMap.chunks[xCord, yCord].tiles[(((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32)].current);

                    }
                    if (mouseState.RightButton == ButtonState.Pressed)
                    {

                        if(inventory.inventory[inventory.selectedItem].count > 0)
                        {
                            // only place if on blank tile 
                            if (tileMap.chunks[xCord, yCord].tiles[(((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32)].index == 0)
                            {
                                //tileMap.ChangeTile(xCord, yCord, inventory.inventory[inventory.selectedItem].item.tileType);
                                tileMap.ChangeTile(xCord, yCord, (((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32), inventory.inventory[inventory.selectedItem].item.itemID, tileMap);
                                inventory.RemoveItem(inventory.inventory[inventory.selectedItem].item); 

                            } 
                        }

                    }
                    if (mouseState.LeftButton == ButtonState.Pressed)
                    {
                        tileMap.DamageTile(xCord, yCord, (((int)worldPosition.X % 1024) / 32), (((int)worldPosition.Y % 1024) / 32), 10);
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

                if (!jumping)
                {
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

            
        }
                      
        public void Draw(SpriteBatch spriteBatch)
        {
            int previous = (int)position.Y;
            int averagePosY = (int)Math.Floor(position.Y + previous) / 2;
            spriteBatch.Draw(texture, new Vector2(position.X, position.Y), Color.White);
            // spriteBatch.Draw(mouseTExture, new Vector2(worldPosition.X , worldPosition.Y), Color.White); 
            //spriteBatch.Draw(mouseTExture, new Vector2((int)worldPosition.X / 32, (int)worldPosition.Y / 32), Color.White);
            inventory.Draw(spriteBatch, this); 
        }
    }
}
