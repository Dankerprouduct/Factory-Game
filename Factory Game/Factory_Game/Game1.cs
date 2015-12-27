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

        public TileMap tileMap;
        // 4200 1200
        int[,] mapSize = new int[200, 200];
        // 932480
        int seed = 194858; 

        public Camera camera;

        GUI gui = new GUI();

        KeyboardState keyboardState;

        public TileObjectManagement tileObjectManagement;
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
            keyboardState = new KeyboardState(); 

            spriteBatch = new SpriteBatch(GraphicsDevice);

            player = new Player(new Vector2(50, -50)); 
            player.LoadContent(Content);

            tileMap = new TileMap(mapSize, seed);
            tileMap.LoadContent(Content);
            tileObjectManagement = new TileObjectManagement(this); 
            gui.LoadContnent(Content); 
        }
        
        protected override void UnloadContent()
        {

        }
        
        protected override void Update(GameTime gameTime)
        {

            keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }
            camera.Update(gameTime, this); 
            player.Update(gameTime, this);
            if (tileObjectManagement.tileObjects.Count > 0)
            {
                tileObjectManagement.Update(gameTime);
            }
            gui.Update(gameTime, player, tileObjectManagement); 
            tileMap.Update(gameTime, this); 
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
                null, null, null, null,
                camera.transform); 

            tileMap.Draw(spriteBatch, player);

            tileObjectManagement.Draw(spriteBatch);
            player.Draw(spriteBatch); 

            spriteBatch.End();

            spriteBatch.Begin();
            gui.Draw(spriteBatch); 
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
