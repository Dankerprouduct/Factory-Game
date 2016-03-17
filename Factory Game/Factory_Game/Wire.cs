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



            #region Red Wire

            #region Up
            // up
            pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY; 

            if(tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
            {
                if(tile.tileType == Tile.TileType.RedWire1)
                {
                     
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].UpdateIndex(Tile.TileType.RedWire2);
                    tile.UpdateIndex(Tile.TileType.RedWire2);
                    tile.wireState = Tile.WireState.State1;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State1;
                }
            }
            #endregion

            #region Down
            // down 
            pos = new Vector2(tile.position.X,  tile.position.Y + (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                if (tile.tileType == Tile.TileType.RedWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].UpdateIndex(Tile.TileType.RedWire2);
                    tile.UpdateIndex(Tile.TileType.RedWire2);
                    tile.wireState = Tile.WireState.State1;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State1;
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {

                if(tile.tileType == Tile.TileType.RedWire1)
                {
                     tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.RedWire2;
                    tile.UpdateIndex(Tile.TileType.RedWire2);
                    tile.wireState = Tile.WireState.State2;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                    tile.UpdateIndex(Tile.TileType.RedWire2);

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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {

                if (tile.tileType == Tile.TileType.RedWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.RedWire2;
                    tile.UpdateIndex(Tile.TileType.RedWire2);
                    tile.wireState = Tile.WireState.State2;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                    tile.UpdateIndex(Tile.TileType.RedWire2);
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State4;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State4;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State4;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State4;
                }
            }


            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;

                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State1;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State1;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State1;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State1;
                }
            }


            // corner 2
            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State3;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State3;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State3;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State3;
                }
            }


            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;

                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType ==  Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State2;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State2;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State2;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    tile.UpdateIndex(Tile.TileType.RedWire3);
                    tile.wireState = Tile.WireState.State2;
                }
            }
            #endregion


            #region T 

            pos = new Vector2(tile.position.X , tile.position.Y + (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire5);
                        tile.wireState = Tile.WireState.State1; 
                        
                    }
                }

            }


            pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire5);
                        tile.wireState = Tile.WireState.State3;

                    }
                }

            }

            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire5);
                        tile.wireState = Tile.WireState.State2;

                    }
                }

            }


            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.RedWire5);
                        tile.wireState = Tile.WireState.State4;

                    }
                }

            }

            #endregion 

            #region Cross
            // Cross
            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;

                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2)
                        {
                            tile.UpdateIndex(Tile.TileType.RedWire4);
                        }
                    }
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;

                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.RedWire1)
                        {
                            tile.UpdateIndex(Tile.TileType.RedWire4);
                        }
                    }
                }
            }

            #endregion
            #endregion

            #region Green Wire

            #region Up
            // up
            pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
            {
                if (tile.tileType == Tile.TileType.GreenWire1)
                {

                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].UpdateIndex(Tile.TileType.GreenWire2);
                    tile.UpdateIndex(Tile.TileType.GreenWire2);
                    tile.wireState = Tile.WireState.State1;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State1;
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                if (tile.tileType == Tile.TileType.GreenWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].UpdateIndex(Tile.TileType.GreenWire2);
                    tile.UpdateIndex(Tile.TileType.GreenWire2);
                    tile.wireState = Tile.WireState.State1;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State1;
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {

                if (tile.tileType == Tile.TileType.GreenWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GreenWire2;
                    tile.UpdateIndex(Tile.TileType.GreenWire2);
                    tile.wireState = Tile.WireState.State2;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                    tile.UpdateIndex(Tile.TileType.GreenWire2);

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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {

                if (tile.tileType == Tile.TileType.GreenWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GreenWire2;
                    tile.UpdateIndex(Tile.TileType.GreenWire2);
                    tile.wireState = Tile.WireState.State2;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                    tile.UpdateIndex(Tile.TileType.GreenWire2);
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State4;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State4;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State4;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State4;
                }
            }


            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;

                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State1;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State1;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State1;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State1;
                }
            }


            // corner 2
            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State3;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State3;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State3;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State3;
                }
            }


            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;

                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State2;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State2;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State2;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GreenWire3);
                    tile.wireState = Tile.WireState.State2;
                }
            }
            #endregion


            #region T 

            pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire5);
                        tile.wireState = Tile.WireState.State1;

                    }
                }

            }


            pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire5);
                        tile.wireState = Tile.WireState.State3;

                    }
                }

            }

            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire5);
                        tile.wireState = Tile.WireState.State2;

                    }
                }

            }


            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GreenWire5);
                        tile.wireState = Tile.WireState.State4;

                    }
                }

            }

            #endregion 

            #region Cross
            // Cross
            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;

                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2)
                        {
                            tile.UpdateIndex(Tile.TileType.GreenWire4);
                        }
                    }
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;

                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GreenWire1)
                        {
                            tile.UpdateIndex(Tile.TileType.GreenWire4);
                        }
                    }
                }
            }

            #endregion
            #endregion

            #region Gold Wire

            #region Up
            // up
            pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
            {
                if (tile.tileType == Tile.TileType.GoldWire1)
                {

                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].UpdateIndex(Tile.TileType.GoldWire2);
                    tile.UpdateIndex(Tile.TileType.GoldWire2);
                    tile.wireState = Tile.WireState.State1;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State1;
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                if (tile.tileType == Tile.TileType.GoldWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].UpdateIndex(Tile.TileType.GoldWire2);
                    tile.UpdateIndex(Tile.TileType.GoldWire2);
                    tile.wireState = Tile.WireState.State1;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State1;
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {

                if (tile.tileType == Tile.TileType.GoldWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GoldWire2;
                    tile.UpdateIndex(Tile.TileType.GoldWire2);
                    tile.wireState = Tile.WireState.State2;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                    tile.UpdateIndex(Tile.TileType.GoldWire2);

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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {

                if (tile.tileType == Tile.TileType.GoldWire1)
                {
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType = Tile.TileType.GoldWire2;
                    tile.UpdateIndex(Tile.TileType.GoldWire2);
                    tile.wireState = Tile.WireState.State2;
                    tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].wireState = Tile.WireState.State2;
                    tile.UpdateIndex(Tile.TileType.GoldWire2);
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
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State4;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State4;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State4;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State4;
                }
            }


            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;

                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State1;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State1;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State1;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State1;
                }
            }


            // corner 2
            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State3;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State3;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State3;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State3;
                }
            }


            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;

                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State2;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State2;
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State2;
                }
                else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    tile.UpdateIndex(Tile.TileType.GoldWire3);
                    tile.wireState = Tile.WireState.State2;
                }
            }
            #endregion


            #region T 

            pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire5);
                        tile.wireState = Tile.WireState.State1;

                    }
                }

            }


            pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire5);
                        tile.wireState = Tile.WireState.State3;

                    }
                }

            }

            pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire5);
                        tile.wireState = Tile.WireState.State2;

                    }
                }

            }


            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;

            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;

                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                    {
                        tile.UpdateIndex(Tile.TileType.GoldWire5);
                        tile.wireState = Tile.WireState.State4;

                    }
                }

            }

            #endregion 

            #region Cross
            // Cross
            pos = new Vector2(tile.position.X + (1 * 32), tile.position.Y);
            tileX = tileMap.FindTile(pos).tileX;
            tileY = tileMap.FindTile(pos).tileY;
            chunkX = tileMap.FindTile(pos).chunkX;
            chunkY = tileMap.FindTile(pos).chunkY;
            if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;

                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2)
                        {
                            tile.UpdateIndex(Tile.TileType.GoldWire4);
                        }
                    }
                }
            }
            else if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
            {
                pos = new Vector2(tile.position.X, tile.position.Y + (1 * 32));
                tileX = tileMap.FindTile(pos).tileX;
                tileY = tileMap.FindTile(pos).tileY;
                chunkX = tileMap.FindTile(pos).chunkX;
                chunkY = tileMap.FindTile(pos).chunkY;
                if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                {
                    pos = new Vector2(tile.position.X, tile.position.Y - (1 * 32));
                    tileX = tileMap.FindTile(pos).tileX;
                    tileY = tileMap.FindTile(pos).tileY;
                    chunkX = tileMap.FindTile(pos).chunkX;
                    chunkY = tileMap.FindTile(pos).chunkY;
                    if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                    {
                        pos = new Vector2(tile.position.X - (1 * 32), tile.position.Y);
                        tileX = tileMap.FindTile(pos).tileX;
                        tileY = tileMap.FindTile(pos).tileY;
                        chunkX = tileMap.FindTile(pos).chunkX;
                        chunkY = tileMap.FindTile(pos).chunkY;

                        if (tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire2 || tileMap.chunks[chunkX, chunkY].tiles[tileX, tileY].tileType == Tile.TileType.GoldWire1)
                        {
                            tile.UpdateIndex(Tile.TileType.GoldWire4);
                        }
                    }
                }
            }

            #endregion
            #endregion
        }
    }
}
