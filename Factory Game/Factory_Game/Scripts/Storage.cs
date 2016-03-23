using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLua;
using Microsoft.Xna.Framework;
namespace Factory_Game
{
    public class Storage
    {
        private int level;
        private Lua lua;
        private TileMap tileMap;
        private Tile tile;
        /// <summary>
        /// Storaeg lvs are 1, 2 & 3
        /// </summary>
        /// <param name="storageLv"></param>
        public Storage(int storageLv,Tile mTile, TileMap tMap)
        {
            level = storageLv;
            tileMap = tMap; 
        }
        public void BuildStorage()
        {
            lua = new Lua();
            
        }
        public void BuildStructure()
        {
            Lua lua = new Lua();
            lua.RegisterFunction("BuildTile", this, GetType().GetMethod("BuildTile"));
            lua.RegisterFunction("GetXIndex", this, GetType().GetMethod("GetXIndex"));
            lua.RegisterFunction("GetYIndex", this, GetType().GetMethod("GetYIndex"));
            lua.DoString("structureType = 2");
            lua.DoFile("LuaScripts/structure_data.lua");


        }

        public void BuildTile(int x, int y, int type)
        {
            Vector2 pos;
            pos = new Vector2(tile.position.X + (x * 32), tile.position.Y + (y * 32));

            tileMap.GetTile(pos).UpdateIndex((Tile.TileType)type);
        }

        public int GetXIndex()
        {
            return (int)tile.position.X;

        }
        public int GetYIndex()
        {
            return (int)tile.position.Y;
        }

    }
}
