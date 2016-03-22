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

            if (tile.tileType == Tile.TileType.RedWire1 || tile.tileType == Tile.TileType.RedWire2 || tile.tileType == Tile.TileType.RedWire3 || tile.tileType == Tile.TileType.RedWire4 ||
                tile.tileType == Tile.TileType.RedWire5)
            {
                #region Red Wire

                #region Cross
                // Cross
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                            tileX = tileMap.FindTile(pos).tileX;
                            tileY = tileMap.FindTile(pos).tileY;
                            chunkX = tileMap.FindTile(pos).chunkX;
                            chunkY = tileMap.FindTile(pos).chunkY;

                            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                            {
                                tile.UpdateIndex(Tile.TileType.RedWire4, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.RedWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.RedWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.RedWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.RedWire5, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire3, tileMap);
                        tile.wireState = Tile.WireState.State4;
                        return;
                    }

                }


                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire3, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire3, tileMap);
                        tile.wireState = Tile.WireState.State3;
                        return;
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire3, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    if (tile.tileType == Tile.TileType.RedWire1)
                    {


                        tile.UpdateIndex(Tile.TileType.RedWire2, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    if (tile.tileType == Tile.TileType.RedWire1)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire2, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {

                    if (tile.tileType == Tile.TileType.RedWire1)
                    {
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.RedWire2;
                        tile.UpdateIndex(Tile.TileType.RedWire2, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                        //  tile.UpdateIndex(Tile.TileType.RedWire2);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {

                    if (tile.tileType == Tile.TileType.RedWire1)
                    {
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.RedWire2;
                        tile.UpdateIndex(Tile.TileType.RedWire2, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                       // tile.UpdateIndex(Tile.TileType.RedWire2, tileMap);
                        return;
                    }
                }
                #endregion







                #endregion
            }
            else if (tile.tileType == Tile.TileType.GreenWire1 || tile.tileType == Tile.TileType.GreenWire2 || tile.tileType == Tile.TileType.GreenWire3 || tile.tileType == Tile.TileType.GreenWire4 ||
                tile.tileType == Tile.TileType.GreenWire5)
            {

                #region Green Wire

                #region Cross
                // Cross
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                            tileX = tileMap.FindTile(pos).tileX;
                            tileY = tileMap.FindTile(pos).tileY;
                            chunkX = tileMap.FindTile(pos).chunkX;
                            chunkY = tileMap.FindTile(pos).chunkY;

                            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                            {
                                tile.UpdateIndex(Tile.TileType.GreenWire4, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GreenWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GreenWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GreenWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GreenWire5, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire3, tileMap);
                        tile.wireState = Tile.WireState.State4;
                        return;
                    }

                }


                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire3, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire3, tileMap);
                        tile.wireState = Tile.WireState.State3;
                        return;
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire3, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    if (tile.tileType == Tile.TileType.GreenWire1)
                    {


                        tile.UpdateIndex(Tile.TileType.GreenWire2, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    if (tile.tileType == Tile.TileType.GreenWire1)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire2, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {

                    if (tile.tileType == Tile.TileType.GreenWire1)
                    {
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GreenWire2;
                        tile.UpdateIndex(Tile.TileType.GreenWire2, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                        //  tile.UpdateIndex(Tile.TileType.GreenWire2);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {

                    if (tile.tileType == Tile.TileType.GreenWire1)
                    {
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GreenWire2;
                        tile.UpdateIndex(Tile.TileType.GreenWire2, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                     //   tile.UpdateIndex(Tile.TileType.GreenWire2);
                        return;
                    }
                }
                #endregion







                #endregion
            }
            else if (tile.tileType == Tile.TileType.GoldWire1 || tile.tileType == Tile.TileType.GoldWire2 || tile.tileType == Tile.TileType.GoldWire3 || tile.tileType == Tile.TileType.GoldWire4 ||
                tile.tileType == Tile.TileType.GoldWire5)
            {
                #region Gold Wire

                #region Cross
                // Cross
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                            tileX = tileMap.FindTile(pos).tileX;
                            tileY = tileMap.FindTile(pos).tileY;
                            chunkX = tileMap.FindTile(pos).chunkX;
                            chunkY = tileMap.FindTile(pos).chunkY;

                            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                            {
                                tile.UpdateIndex(Tile.TileType.GoldWire4, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GoldWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GoldWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GoldWire5, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;

                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;
                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                        {
                            tile.UpdateIndex(Tile.TileType.GoldWire5, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire3, tileMap);
                        tile.wireState = Tile.WireState.State4;
                        return;
                    }

                }


                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire3, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire3, tileMap);
                        tile.wireState = Tile.WireState.State3;
                        return;
                    }

                }

                pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;

                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire3, tileMap);
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

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    if (tile.tileType == Tile.TileType.GoldWire1)
                    {


                        tile.UpdateIndex(Tile.TileType.GoldWire2, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {
                    if (tile.tileType == Tile.TileType.GoldWire1)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire2, tileMap);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {

                    if (tile.tileType == Tile.TileType.GoldWire1)
                    {
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GoldWire2;
                        tile.UpdateIndex(Tile.TileType.GoldWire2, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                        //  tile.UpdateIndex(Tile.TileType.GoldWire2);
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
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire3 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire4 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire5 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.BatteryBlock || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.SolarPanel)
                {

                    if (tile.tileType == Tile.TileType.GoldWire1)
                    {
                        //  tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GoldWire2;
                        tile.UpdateIndex(Tile.TileType.GoldWire2, tileMap);
                        tile.wireState = Tile.WireState.State2;
                        //   tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                       // tile.UpdateIndex(Tile.TileType.GoldWire2);
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

            
            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if(tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current); 
                }
            }
            else if(tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if(tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if(tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if(tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.BatteryBlock)
            {
                
               // tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }

            #endregion


            #region Down
            // Down
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X, pos.Y + 32);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.BatteryBlock)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion

            #region Right
            // Right 
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X + 32, pos.Y);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.SolarPanel)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion


            #region Left
            //Left
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X - 32, pos.Y);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.BatteryBlock)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion

            #endregion

            #region Green Wire

            ressistance = .855f;

            #region Up
            // Up
            pos = new Vector2(tile.position.X, tile.position.Y); 
            pos = new Vector2(pos.X, pos.Y - 32);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.BatteryBlock)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion


            #region Down
            // Down
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X, pos.Y + 32);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.BatteryBlock)
            {
                //tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion

            #region Right
            // Right 
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X + 32, pos.Y);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.SolarPanel)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion


            #region Left
            //Left
            pos = new Vector2(tile.position.X, tile.position.Y);
            pos = new Vector2(pos.X - 32, pos.Y);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GreenWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.BatteryBlock)
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

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.SolarPanel)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion


            #region Down
            // Down
            pos = new Vector2(tile.position.X, tile.position.Y + 32);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.SolarPanel)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion

            #region Right
            // Right 
            pos = new Vector2(tile.position.X + 32, tile.position.Y);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire2)
            {

                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.SolarPanel)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion


            #region Left
            //Left
            pos = new Vector2(tile.position.X - 32, tile.position.Y);

            if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire1)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire2)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire3)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire4)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.GoldWire5)
            {
                if (tileMap.GetTile(pos).current > tile.current)
                {
                    tile.current = Electricity.Ressistance(ressistance, tileMap.GetTile(pos).current);
                }
            }
            else if (tileMap.GetTile(pos).tileType == Tile.TileType.SolarPanel)
            {
                tile.current = tileMap.GetTile(pos).battery.CurrentPower();
            }
            #endregion

            #endregion





        }
    }
}
