using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
namespace Factory_Game
{
    public static class Wire
    {

        public static void WireState(Tile tile, TileMap tileMap)
        {


            Vector2 pos;
            int tileX;
            int tileY;
            int chunkX;
            int chunkY;

            if (tile.index == 71 || tile.index == 72 || tile.index == 73 || tile.index == 74 ||
                tile.index == 75)
            {
                #region Red Wire

                #region Cross
                // Cross
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150 )
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                            tileX = tileMap.FindTile(pos).tileX;
                            tileY = tileMap.FindTile(pos).tileY;
                            chunkX = tileMap.FindTile(pos).chunkX;
                            chunkY = tileMap.FindTile(pos).chunkY;

                            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                            {
                                tile.UpdateIndex(74, tileMap);
                                return;
                            }
                        }
                    }
                }


                #endregion

                #region T 

                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(75, tileMap);
                            tile.wireState = Tile.WireState.State1;
                            return;
                        }
                    }

                }


                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(75, tileMap);
                            tile.wireState = Tile.WireState.State3;
                            return;
                        }
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(75, tileMap);
                            tile.wireState = Tile.WireState.State2;
                            return;
                        }
                    }

                }


                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(75, tileMap);
                            tile.wireState = Tile.WireState.State4;
                            return;
                        }
                    }

                }

                #endregion

                #region Corners
                // corner
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(73, tileMap);
                        tile.wireState = Tile.WireState.State4;
                        return;
                    }

                }


                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(73, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }

                }
                // corner 2
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(73, tileMap);
                        tile.wireState = Tile.WireState.State3;
                        return;
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(73, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        return;
                    }

                }

                #endregion

                #region Up
                // up
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    if (tile.index == 71)
                    {


                        tile.UpdateIndex(72, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }
                }
                #endregion

                #region Down
                // down 
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    if (tile.index == 71)
                    {
                        tile.UpdateIndex(72, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }
                }
                #endregion

                #region Left
                // left
                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {

                    if (tile.index == 71)
                    {
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index = 72;
                        tile.UpdateIndex(72, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                        //  tile.UpdateIndex(72);
                        return;
                    }
                }
                #endregion

                #region Right
                // right
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 71 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 72 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 73 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 74 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 75 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {

                    if (tile.index == 71)
                    {
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index = 72;
                        tile.UpdateIndex(72,tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                       // tile.UpdateIndex(72, tileMap);
                        return;
                    }
                }
                #endregion







                #endregion
            }
            else if (tile.index == 81 || tile.index == 82 || tile.index == 83 || tile.index == 84 ||
                tile.index == 85)
            {

                #region Green Wire

                #region Cross
                // Cross
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                            tileX = tileMap.FindTile(pos).tileX;
                            tileY = tileMap.FindTile(pos).tileY;
                            chunkX = tileMap.FindTile(pos).chunkX;
                            chunkY = tileMap.FindTile(pos).chunkY;

                            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                            {
                                tile.UpdateIndex(84, tileMap);
                                return;
                            }
                        }
                    }
                }


                #endregion

                #region T 

                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(85, tileMap);
                            tile.wireState = Tile.WireState.State1;
                            return;
                        }
                    }

                }


                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(85, tileMap);
                            tile.wireState = Tile.WireState.State3;
                            return;
                        }
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(85, tileMap);
                            tile.wireState = Tile.WireState.State2;
                            return;
                        }
                    }

                }


                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(85, tileMap);
                            tile.wireState = Tile.WireState.State4;
                            return;
                        }
                    }

                }

                #endregion

                #region Corners
                // corner
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(83, tileMap);
                        tile.wireState = Tile.WireState.State4;
                        return;
                    }

                }


                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(83, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }

                }
                // corner 2
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(83, tileMap);
                        tile.wireState = Tile.WireState.State3;
                        return;
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(83, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        return;
                    }

                }

                #endregion

                #region Up
                // up
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    if (tile.index == 81)
                    {


                        tile.UpdateIndex(82, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }
                }
                #endregion

                #region Down
                // down 
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    if (tile.index == 81)
                    {
                        tile.UpdateIndex(82, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }
                }
                #endregion

                #region Left
                // left
                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {

                    if (tile.index == 81)
                    {
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index = 82;
                        tile.UpdateIndex(82, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                        //  tile.UpdateIndex(82);
                        return;
                    }
                }
                #endregion

                #region Right
                // right
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 81 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 82 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 83 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 84 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 85 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {

                    if (tile.index == 81)
                    {
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index = 82;
                        tile.UpdateIndex(82, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                     //   tile.UpdateIndex(82);
                        return;
                    }
                }
                #endregion







                #endregion
            }
            else if (tile.index == 91 || tile.index == 92 || tile.index == 93 || tile.index == 94 ||
                tile.index == 95)
            {
                #region Gold Wire

                #region Cross
                // Cross
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                            tileX = tileMap.FindTile(pos).tileX;
                            tileY = tileMap.FindTile(pos).tileY;
                            chunkX = tileMap.FindTile(pos).chunkX;
                            chunkY = tileMap.FindTile(pos).chunkY;

                            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                            {
                                tile.UpdateIndex(94, tileMap);
                                return;
                            }
                        }
                    }
                }


                #endregion

                #region T 

                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(95, tileMap);
                            tile.wireState = Tile.WireState.State1;
                            return;
                        }
                    }

                }


                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(95, tileMap);
                            tile.wireState = Tile.WireState.State3;
                            return;
                        }
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(95, tileMap);
                            tile.wireState = Tile.WireState.State2;
                            return;
                        }
                    }

                }


                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                        {
                            tile.UpdateIndex(95, tileMap);
                            tile.wireState = Tile.WireState.State4;
                            return;
                        }
                    }

                }

                #endregion

                #region Corners
                // corner
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(93, tileMap);
                        tile.wireState = Tile.WireState.State4;
                        return;
                    }

                }


                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(93, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }

                }
                // corner 2
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(93, tileMap);
                        tile.wireState = Tile.WireState.State3;
                        return;
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                    {
                        tile.UpdateIndex(93, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        return;
                    }

                }

                #endregion

                #region Up
                // up
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    if (tile.index == 91)
                    {


                        tile.UpdateIndex(92, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }
                }
                #endregion

                #region Down
                // down 
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {
                    if (tile.index == 91)
                    {
                        tile.UpdateIndex(92, tileMap);
                        tile.wireState = Tile.WireState.State1;
                        return;
                    }
                }
                #endregion

                #region Left
                // left
                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {

                    if (tile.index == 91)
                    {
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index = 92;
                        tile.UpdateIndex(92, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                        //  tile.UpdateIndex(92);
                        return;
                    }
                }
                #endregion

                #region Right
                // right
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 91 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 92 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 93 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 94 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 95 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 50 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index == 150)
                {

                    if (tile.index == 91)
                    {
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].index = 92;
                        tile.UpdateIndex(92, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                       // tile.UpdateIndex(92);
                        return;
                    }
                }
                #endregion







                #endregion
            }

        }



        public static void Current(Tile tile, TileMap tileMap)
        {
            Vector2 pos;
            float ressistance; 

            pos = tile.position;

            
            #region Red Wire

            ressistance = .755f;

            #region Up
            // Up
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X, pos.Y - 32);

            
            if (tileMap.GetTile(pos).index == 81)
            {
                if(tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current); 
                }
            }
            else if(tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if(tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if(tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if(tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 50)
            {
                
               // tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {
                
                 tileMap.GetTile(pos).current = tile.current; 
            }
            #endregion


            #region Down
            // Down
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X, pos.Y + 32);

            if (tileMap.GetTile(pos).index == 81)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 50)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {

                tileMap.GetTile(pos).current = tile.current;
            }
            #endregion

            #region Right
            // Right 
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X + 32, pos.Y);

            if (tileMap.GetTile(pos).index == 81)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 150)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {
                
                tileMap.GetTile(pos).current = tile.current;
                //Console.WriteLine("Quarry Block " + tileMap.GetTile(pos).current);
               // Console.WriteLine(tile.current); 
            }
            #endregion


            #region Left
            //Left
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X - 32, pos.Y);

            if (tileMap.GetTile(pos).index == 81)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 50)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {

                tileMap.GetTile(pos).current = tile.current;
            }
            #endregion

            #endregion

            #region Green Wire

            ressistance = .855f;

            #region Up
            // Up
            pos = new Vector2(tile.position.X, tile.position.Y); 
            pos = new Vector2(pos.X, pos.Y - 32);

            if (tileMap.GetTile(pos).index == 81)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 50)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion


            #region Down
            // Down
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X, pos.Y + 32);

            if (tileMap.GetTile(pos).index == 81)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 50)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion

            #region Right
            // Right 
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X + 32, pos.Y);

            if (tileMap.GetTile(pos).index == 81)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 150)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion


            #region Left
            //Left
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X - 32, pos.Y);

            if (tileMap.GetTile(pos).index == 81)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 82)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 83)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 84)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 85)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 50)
            {
               // tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion

            #endregion

            #region Gold Wire

            ressistance = .955f;

            #region Up
            // Up
            
            pos = new Vector2(tile.position.X, tile.position.Y - 32);

            if (tileMap.GetTile(pos).index == 91)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 92)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 93)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 94)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 95)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 150)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {

                tileMap.GetTile(pos).current = tile.current;
            }
            #endregion


            #region Down
            // Down
            pos = new Vector2(tile.position.X, tile.position.Y + 32);

            if (tileMap.GetTile(pos).index == 91)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 92)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 93)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 94)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 95)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 150)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {

                tileMap.GetTile(pos).current = tile.current;
            }
            #endregion

            #region Right
            // Right 
            pos = new Vector2(tile.position.X + 32, tile.position.Y);

            if (tileMap.GetTile(pos).index == 91)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 92)
            {

                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 93)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 94)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 95)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 150)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {

                tileMap.GetTile(pos).current = tile.current;
            }
            #endregion


            #region Left
            //Left
            pos = new Vector2(tile.position.X - 32, tile.position.Y);

            if (tileMap.GetTile(pos).index == 91)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 92)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 93)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 94)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 95)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).index == 150)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            else if (tileMap.GetTile(pos).index ==55)
            {

                tileMap.GetTile(pos).current = tile.current;
            }
            #endregion

            #endregion





        }
    }
}
