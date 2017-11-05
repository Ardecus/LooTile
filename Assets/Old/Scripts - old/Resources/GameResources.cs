using System.Collections.Generic;
using UnityEngine;

public class GameResources : MonoBehaviour
{
    public static List<GameObject> Items = new List<GameObject>();
    public static List<GameObject> Enemies = new List<GameObject>();
    public static List<GameObject>[] EnemiesStory = new List<GameObject>[12];
    public static GameObject Exit;

    void Awake()
    {
        Exit = Resources.Load<GameObject>(@"Prefabs/Exit");

        foreach (GameObject item in Resources.LoadAll<GameObject>(@"Prefabs/Items"))
        {
            Items.Add(item);
        }

        for (int i = 0; i < 12; i++)
        {
            EnemiesStory[i] = new List<GameObject>();
            foreach (GameObject enemy in Resources.LoadAll(@"Prefabs/Enemies/" + i, typeof(GameObject)))
            {
                EnemiesStory[i].Add(enemy);
                Enemies.Add(enemy);
            }
        }
    }
}
