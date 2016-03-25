using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                    storages[i].Update(tileMap, game);
                }
            }
        }

    }
}
