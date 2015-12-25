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

        Vector2 lastPosition; 
        // input
        KeyboardState keyboardState;

        public bool jumping;
        public Rectangle rect; 

        public Player(Vector2 startPosition)
        {
            position = startPosition;
            speed = 3f; 
        }
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Sprites/TempPlayer");
        }
        public void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();
            Movement();
            
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
                position.Y -= 10;
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
                velocity.Y = 0; 
            }
            position.Y += 1; 

            lastPosition = position; 
        }


        public void Collision(Rectangle bounds) 
        {
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
            spriteBatch.Draw(texture, position, Color.White); 
        }
    }
}
