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
    public class Camera
    {
        public Matrix transform;
        Vector2 center;
        Viewport view; 

        public Camera(Viewport vPort)
        {
            view = vPort; 
        }
        public void Update(GameTime gameTime, Game1 game)
        {
            center = new Vector2(game.player.position.X - (game.player.CurrentBounds().Width / 2) -( game.WIDTH /2 ), game.player.position.Y - (game.player.CurrentBounds().Height / 2) -( game.HEIGHT / 2));

            transform = Matrix.CreateScale(new Vector3(1, 1, 1)) * Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0)); 
        }
    }
}
