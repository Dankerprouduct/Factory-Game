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
        /*
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
        */
        public static Rectangle SourceRect(int id, string name, ContentManager content)
        {

            DatabaseLibrary.ItemDatabase[] items = content.Load<DatabaseLibrary.ItemDatabase[]>("Xml/ItemDatabase"); 
            string path = "TileData/" + name + ".txt";
            StreamReader sr = new StreamReader(path);

            int curId = 0; 
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].itemId == id)
                {
                    curId = i;
                }
            }
            int height = File.ReadLines(path).Count();

            char[] splits = { '=', ' ' };

            
            for (int y = 0; y < height; y++)
            {
                string line = sr.ReadLine();
                string[] rectData = line.Split(splits);

                foreach (string s in rectData)
                {
                    //Console.WriteLine("tile: " + s);
                    for (int i = 0; i < items.Length; i++)
                    {
                        // Console.WriteLine(s); 
                        if (name == "TileObjectSpriteSheet")
                        {
                           // Console.WriteLine(items[i].name); 
                            if (items[curId].name + "Item"  == s)
                            {
                                sr.Close();

                                return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6]));
                            }
                        }
                        else
                        {
                            if (items[curId].name == s)
                            {
                                sr.Close();
                                // Console.WriteLine("POP");

                                return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6]));
                            }
                        }
                    }
                }
            }

            return new Rectangle(0, 0, 0, 0);
        }

        public static Rectangle SourceRect(int id,Game1 game)
        {

            return game.tileMap.textureManager.SourceRect(id);

        }
        /*
        public static Rectangle SourceRect(int id, string name, ContentManager content)
        {

            DatabaseLibrary.ItemDatabase[] items = content.Load<DatabaseLibrary.ItemDatabase[]>("Xml/ItemDatabase");
            string path = "TileData/" + name + ".txt";
            StreamReader sr = new StreamReader(path);

            int curId = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].itemId == id)
                {
                    curId = i;
                }
            }
            int height = File.ReadLines(path).Count();

            char[] splits = { '=', ' ' };


            for (int y = 0; y < height; y++)
            {
                string line = sr.ReadLine();
                string[] rectData = line.Split(splits);

                foreach (string s in rectData)
                {
                    //Console.WriteLine("tile: " + s);
                    for (int i = 0; i < items.Length; i++)
                    {
                        // Console.WriteLine(s); 
                        if (name == "TileObjectSpriteSheet")
                        {
                            // Console.WriteLine(items[i].name); 
                            if (items[curId].name + "Item" == s)
                            {
                                sr.Close();

                                return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6]));
                            }
                        }
                        else
                        {
                            if (items[curId].name == s)
                            {
                                sr.Close();
                                // Console.WriteLine("POP");

                                return new Rectangle(Convert.ToInt32(rectData[3]), Convert.ToInt32(rectData[4]), Convert.ToInt32(rectData[5]), Convert.ToInt32(rectData[6]));
                            }
                        }
                    }
                }
            }

            return new Rectangle(0, 0, 0, 0);
        }
        */
    }
}
