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
    public class Player : GameObject
    {
        public float j = 1; 
        // input
        KeyboardState keyboardState;
        KeyboardState oldKeboardState;

        public bool canBreak; 
        public bool jumping;
        public Rectangle rect;
        public bool colliding;
        Rectangle tileBounds; 
        public Player(Vector2 startPosition)
        {
            position = startPosition;
            // regular = 3 
            speed = 3; 
        }
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Sprites/TempPlayer");
        }
        public void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();
            Movement();

            if(keyboardState.IsKeyDown(Keys.B) && oldKeboardState.IsKeyUp(Keys.B))
            {
                canBreak = !canBreak;
            }
            oldKeboardState = keyboardState; 
            
        }
        public enum Direction
        {
            Horizontal,
            Vertical
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
            if (jumping)
            {
                float i = 1;
                velocity.Y += .15f * i;
                
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
            int previous = (int)position.Y;
            int averagePosY = (int)Math.Floor(position.Y + previous) / 2;
            spriteBatch.Draw(texture, new Vector2(position.X, averagePosY), Color.White);
            
        }
    }
}