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
        // base stats 40mb
        // 1500
        public int WIDTH = 1500;
        public int HEIGHT;

        public Player player;

        public TileMap tileMap;
        // 4200 1200
        public int[,] mapSize;
        // 932480
        // 234561 spawns in flat plane
        int seed = 3421; 

        public Camera camera;

        GUI gui = new GUI();

        KeyboardState keyboardState;

        public QuarryManagement quarryManagement; 
        public TileObjectManagement tileObjectManagement;

        public float _fps = 0;
        public int chunkWidth = 40;
        public int chunkHeight = 20; 
        Texture2D rectangleTexture;
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
            mapSize = new int[chunkWidth * 32, chunkHeight * 32]; 
            camera = new Camera(GraphicsDevice.Viewport); 
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            keyboardState = new KeyboardState(); 

            spriteBatch = new SpriteBatch(GraphicsDevice);
                       

            tileMap = new TileMap(mapSize, seed, false);
            tileMap.LoadContent(Content);

            player = new Player(tileMap.playerStart);
            player.LoadContent(Content);
      
            tileObjectManagement = new TileObjectManagement(this);
            quarryManagement = new QuarryManagement(); 
            gui.LoadContnent(Content, GraphicsDevice);

            rectangleTexture = new Texture2D(GraphicsDevice, 1, 1);
            rectangleTexture.SetData(new[] { Color.White });

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
                tileObjectManagement.Update(gameTime, this);
            }
            
            gui.Update(gameTime, player, tileObjectManagement, this); 
            tileMap.Update(gameTime, this);
            quarryManagement.Update(gameTime, this);


            
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {

            _fps = 1 / (float)gameTime.ElapsedGameTime.TotalSeconds;
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
                SamplerState.PointClamp, null, null, null,
                camera.transform); 

            
            
            quarryManagement.Draw(spriteBatch, this);

            if (tileObjectManagement.tileObjects.Count > 0)
            {
                tileObjectManagement.Draw(spriteBatch);
            }

            tileMap.Draw(spriteBatch, player);
                    


            Rectangle r;
            Rectangle rx;
            if (gui.showChunks)
            {

                for (int x = (int)(player.position.X / 1024) - 1; x < (int)(player.position.X / 1024) + 2; x++)
                {
                    for (int y = (int)(player.position.Y / 1024) - 1; y < (int)(player.position.Y / 1024) + 2; y++)
                    {

                        r = new Rectangle(x * 1024, y * 1024, 1024, 1024);
                        int bw = 2; // Border width
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Left, r.Top, bw, r.Height), Color.Red); // Left
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Right, r.Top, bw, r.Height), Color.Red); // Right
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Left, r.Top, r.Width, bw), Color.Red); // Top
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Left, r.Bottom, r.Width, bw), Color.Red);
                    }
                }

            }

            player.Draw(spriteBatch);

            spriteBatch.End();

            spriteBatch.Begin();

            gui.Draw(spriteBatch); 

            spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
