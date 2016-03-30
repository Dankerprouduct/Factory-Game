using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.IO;
using DatabaseLibrary;
using Microsoft.Xna.Framework.Content;

namespace Factory_Game
{
    public static class Animation
    {

        
        public static Rectangle SourceRect(Tile.TileType tileType,string name, Tile tile)
        {

            string path = "TileData/" + name + ".txt";
            StreamReader sr = new StreamReader(path);
            int height = File.ReadLines(path).Count();

            char[] splits = { '=', ' ' };


            for (int y = 0; y < height; y++)
            {
                string line = sr.ReadLine();
                string[] rectData = line.Split(splits);

                foreach (string s in rectData)
                {
                    if (tileType.ToString() == s)
                    {
                        sr.Close();

                        return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6]));
                    }
                }
            }
            return new Rectangle(0, 0, 0, 0);
        }
        public static Rectangle SourceRect(Tile.TileType tileType, string name)
        {

            string path = "TileData/" + name + ".txt";
            StreamReader sr = new StreamReader(path);
            int height = File.ReadLines(path).Count();

            char[] splits = { '=', ' ' };


            for (int y = 0; y < height; y++)
            {
                string line = sr.ReadLine();
                string[] rectData = line.Split(splits);

                foreach (string s in rectData)
                {
                    if (tileType.ToString() == s)
                    {
                        sr.Close();

                        return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6]));
                    }
                }
            }
            return new Rectangle(0, 0, 0, 0);
        }

        public static Rectangle SourceRect(int id, string name, ContentManager content)
        {

            DatabaseLibrary.ItemDatabase[] items = content.Load<DatabaseLibrary.ItemDatabase[]>("ItemDatabase"); 
            string path = "TileData/" + name + ".txt";
            StreamReader sr = new StreamReader(path);
            int height = File.ReadLines(path).Count();

            char[] splits = { '=', ' ' };


            for (int y = 0; y < height; y++)
            {
                string line = sr.ReadLine();
                string[] rectData = line.Split(splits);

                foreach (string s in rectData)
                {
                    if (items[id].name == s)
                    {
                        sr.Close();

                        return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6]));
                    }
                }
            }
            return new Rectangle(0, 0, 0, 0);
        }

    }
}
