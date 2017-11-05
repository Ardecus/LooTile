using System;

using UnityEngine;

namespace Interactables
{
    [Serializable]
    internal struct LootItem
    {
        [SerializeField] private GameObject spawnPrefab;
        internal GameObject SpawnPrefab
        {
            get
            {
                return spawnPrefab;
            }
            set
            {
                spawnPrefab = value;
            }
        }

        [SerializeField] private static int chancesSum;
        internal static int ChancesSum
        {
            get
            {
                return chancesSum;
            }
            set
            {
                chancesSum = value;
            }
        }

        [SerializeField] private int dropChance;
        internal int DropChance
        {
            get
            {
                return dropChance;
            }
            set
            {
                ChancesSum -= dropChance;
                ChancesSum += value;
                dropChance = value;
            }
        }
    }
}
