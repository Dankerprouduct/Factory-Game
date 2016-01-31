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
        
        // 1500
        public int WIDTH = 1280;
        public int HEIGHT;

        public Player player;

        public TileMap tileMap;
        // 4200 1200
        int[,] mapSize = new int[500, 500];
        // 932480
        // 234561 spawns in flat plane
        int seed = 6753008; 

        public Camera camera;

        GUI gui = new GUI();

        KeyboardState keyboardState;

        public QuarryManagement quarryManagement; 
        public TileObjectManagement tileObjectManagement;

        public float _fps = 0;

        public Game1()
        {
            HEIGHT = (WIDTH / 16) * 9;
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = HEIGHT;
            graphics.PreferredBackBufferWidth = WIDTH;
           // graphics.ToggleFullScreen(); 
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
                       

            tileMap = new TileMap(mapSize, seed);
            tileMap.LoadContent(Content);

            player = new Player(tileMap.playerStart);
            player.LoadContent(Content);

            tileObjectManagement = new TileObjectManagement(this);
            quarryManagement = new QuarryManagement(); 
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

            // Update
            _fps = (int)Math.Ceiling((1 / (float)gameTime.ElapsedGameTime.TotalSeconds));

            camera.Update(gameTime, this); 
            player.Update(gameTime, this);
            if (tileObjectManagement.tileObjects.Count > 0)
            {
                tileObjectManagement.Update(gameTime, this);
            }
            gui.Update(gameTime, player, tileObjectManagement, this); 
            tileMap.Update(gameTime, this);
            quarryManagement.Update(gameTime, this); 

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
                SamplerState.PointClamp, null, null, null,
                camera.transform); 

            

            quarryManagement.Draw(spriteBatch, this); 
            tileObjectManagement.Draw(spriteBatch);
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
