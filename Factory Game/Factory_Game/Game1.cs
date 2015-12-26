using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Factory_Game
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public int WIDTH = 1080;
        public int HEIGHT;

        public Player player;

        TileMap tileMap;
        int[,] mapSize = new int[600, 200];
        int seed = 932480; 

        public Camera camera;

        GUI gui = new GUI();


        public Game1()
        {
            HEIGHT = (WIDTH / 16) * 9;
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = HEIGHT;
            graphics.PreferredBackBufferWidth = WIDTH;
            IsMouseVisible = true; 
            Content.RootDirectory = "Content";

        }


        protected override void Initialize()
        {

            camera = new Camera(GraphicsDevice.Viewport); 
            base.Initialize();
        }


        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);

            player = new Player(new Vector2(50, -50)); 
            player.LoadContent(Content);

            tileMap = new TileMap(mapSize, seed);
            tileMap.LoadContent(Content);

            gui.LoadContnent(Content); 
        }


        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {

            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            camera.Update(gameTime, this); 
            player.Update(gameTime);

            gui.Update(gameTime, player); 
            tileMap.Update(gameTime, this); 
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Coral);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
                null, null, null, null,
                camera.transform); 

            tileMap.Draw(spriteBatch, player); 

            player.Draw(spriteBatch); 

            spriteBatch.End();

            spriteBatch.Begin();
            gui.Draw(spriteBatch); 
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
