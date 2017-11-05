using System.Collections.Generic;

using UnityEngine;

using Tiles;
using GameCore;

namespace Interactables
{
    internal class Loot : Singleton<Loot>
    {
        [SerializeField] private List<LootItem> lootItems;

        private void Awake()
        {
            foreach (LootItem lootItem in lootItems)
            {
                LootItem.ChancesSum += lootItem.DropChance;
            }
        }

        private static void Drop(GameObject content, Tile tile)
        {
            if (content != null)
            {
                GameObject spawned = GameObject.Instantiate(content);
                tile.Content = spawned.GetComponent<Interactable>();
            }
        }

        internal static void Drop(Tile tile)
        {
            GameObject content = null;
            foreach (LootItem lootItem in Instance.lootItems)
            {
                if (Random.Range(0, LootItem.ChancesSum) < lootItem.DropChance)
                {
                    content = lootItem.SpawnPrefab;
                    break;
                }
            }
            Drop(content, tile);
        }
    }
}
