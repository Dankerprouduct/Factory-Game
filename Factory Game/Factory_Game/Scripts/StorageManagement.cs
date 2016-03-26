using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics; 

namespace Factory_Game
{
    public class StorageManagement
    {
        public List<Storage> storages = new List<Storage>();
        public StorageManagement()
        {

        }
        public void AddStorage(Storage str)
        {
            storages.Add(str); 
        }
        public void Update(TileMap tileMap, Game1 game)
        {
            if (storages.Count > 0)
            {
                for (int i = 0; i < storages.Count; i++)
                {
                    if (storages[i].alive)
                    {
                        storages[i].Update(tileMap, game);
                    }
                    else
                    {
                        storages.RemoveAt(i);
                        Console.WriteLine("Removed Storage: " + i);
                    }
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if(storages.Count > 0)
            {
                for(int i = 0; i < storages.Count; i++)
                {
                    storages[i].Draw(spriteBatch, game); 
                }
            }
        }

    }
}
