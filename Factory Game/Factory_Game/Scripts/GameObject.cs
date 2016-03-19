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
    public class GameObject
    {
        public Texture2D texture;
        public Vector2 position;
        public Vector2 velocity;
        public Rectangle objectBounds;
        public float speed; 

        public Rectangle CurrentBounds()
        {
            return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height); 
        }
    }
}
