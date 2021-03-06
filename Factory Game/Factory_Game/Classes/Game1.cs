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
using NLua; 

namespace Factory_Game
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        string version = "Pre-Alpha .23"; 
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
        int seed;
        bool flatWorld; 

        public Camera camera;

        GUI gui = new GUI();

        KeyboardState keyboardState;
        KeyboardState oldKeyboardState; 
        public QuarryManagement quarryManagement; 
        public TileObjectManagement tileObjectManagement;
        public StorageManagement storageManagement;
        public GuiManagement guiManagement; 
        public float _fps = 0;
        public int chunkWidth;
        public int chunkHeight;
        Texture2D rectangleTexture;
        Lua lua;

        bool pause; 
        public Game1()
        {
            
            
            
            graphics = new GraphicsDeviceManager(this);
            
           // graphics.ToggleFullScreen(); 
            IsMouseVisible = true; 
            Content.RootDirectory = "Content";

            lua = new Lua();
            lua.DoFile("LuaScripts/world_properties.lua");
            WIDTH = (int)((double)lua["windowSize"]);
            chunkHeight = (int)((double)lua["chunkHeight"]);
            chunkWidth = (int)((double)lua["chunkWidth"]);
            seed = (int)((double)lua["worldSeed"]);
            flatWorld = (bool)lua["FlatWorld"]; 
            version = (string)lua["version"];

            Window.Title = version;
            HEIGHT = (WIDTH / 16) * 9;
            graphics.PreferredBackBufferHeight = HEIGHT;
            graphics.PreferredBackBufferWidth = WIDTH;
        }
        

        protected override void Initialize()
        {
            mapSize = new int[chunkWidth * 32, chunkHeight * 32]; 
            camera = new Camera(GraphicsDevice.Viewport);
            //IsMouseVisible = false; 
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            keyboardState = new KeyboardState();

            spriteBatch = new SpriteBatch(GraphicsDevice);
                       

            tileMap = new TileMap(mapSize, seed, flatWorld);
            tileMap.LoadContent(Content);

            player = new Player(tileMap.playerStart);
            
      
            tileObjectManagement = new TileObjectManagement(this);
            storageManagement = new StorageManagement(); 
            quarryManagement = new QuarryManagement();
            guiManagement = new GuiManagement(); 
            gui.LoadContnent(Content, GraphicsDevice);


            player.LoadContent(Content, this);
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
            if (keyboardState.IsKeyDown(Keys.P) && oldKeyboardState.IsKeyUp(Keys.P))
            {
                pause = !pause; 
            }
            if (!pause)
            {
                camera.Update(gameTime, this);
                player.Update(gameTime, this);
                if (tileObjectManagement.tileObjects.Count > 0)
                {
                    tileObjectManagement.Update(gameTime, this);
                }
                storageManagement.Update(tileMap, this, gameTime);
                gui.Update(gameTime, player, tileObjectManagement, this);
                tileMap.Update(gameTime, this);
                quarryManagement.Update(gameTime, this);

            }

            oldKeyboardState = keyboardState; 
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
            if (gui.showChunks)
            {
                for (int x = (int)(player.position.X / 1024) - 1; x < (int)(player.position.X / 1024) + 2; x++)
                {
                    for (int y = (int)(player.position.Y / 1024) - 1; y < (int)(player.position.Y / 1024) + 2; y++)
                    {

                        r = new Rectangle(x * 1024, y * 1024, 1024, 1024);
                        int bw = 5; // Border width
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Left, r.Top, bw, r.Height), Color.Red); // Left
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Right, r.Top, bw, r.Height), Color.Red); // Right
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Left, r.Top, r.Width, bw), Color.Red); // Top
                        spriteBatch.Draw(rectangleTexture, new Rectangle(r.Left, r.Bottom, r.Width, bw), Color.Red);
                    }
                }
                

            }

            player.Draw(spriteBatch);

            storageManagement.Draw(spriteBatch, this);
            guiManagement.Draw(spriteBatch, this);
            spriteBatch.End();

            spriteBatch.Begin();



            // HUD
            gui.Draw(spriteBatch);

            

            //guiObj.Draw(spriteBatch); 

            spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
