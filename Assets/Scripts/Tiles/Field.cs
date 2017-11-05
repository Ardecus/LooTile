using System.Collections.Generic;

using UnityEngine;

namespace Tiles
{
    public class Field : MonoBehaviour
    {
        [SerializeField] private List<Tile> tiles;
        public List<Tile> Tiles
        {
            get
            {
                return tiles;
            }
            set
            {
                tiles = value;
            }
        }

        internal void OpenStartTile()
        {
            Tiles[Random.Range(0, Tiles.Count)].Opened = true;
        }

        internal void ResetField()
        {
            foreach (Tile tile in Tiles)
            {
                tile.Content = null;
                tile.Opened = false;
                tile.Avaliable = false;
            }
        }
        
        //spawning in separate functioN
    }
}
