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
        public Matrix rawTransform;
        public Vector2 center;
        Viewport view;
        Game1 gme;
        float scale = 1f;
        float speed = .05f; 

        public Camera(Viewport vPort)
        {
            view = vPort;

        }
        public void Update(GameTime gameTime, Game1 game)
        {
            speed = 1f;
            scale = 1f;
            gme = game;
            center = new Vector2((game.player.position.X - (game.player.CurrentBounds().Width / 2) - (game.WIDTH / 2)) * scale,
                (game.player.position.Y - (game.player.CurrentBounds().Height / 2) - (game.HEIGHT / 2)) * scale);

            transform = Matrix.Lerp(transform, rawTransform, speed);


            rawTransform = Matrix.CreateScale(new Vector3(scale, scale, 1)) * Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0));

        }


    }
}

