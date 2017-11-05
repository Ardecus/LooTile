using System.Collections.Generic;
using UnityEngine;
/*
[System.Serializable]
public class Field : MonoBehaviour
{
	[SerializeField] List<Tile> tiles;

    //-1 - all enemies
    public void GenerateField(int levelNum)
	{
		float objectsRate = Random.Range(0.1f, 2);

		int objectsCount = Random.Range(tiles.Count / 10, tiles.Count / 2);
		int enemiesCount = levelNum % 5 == 0 ? 1 : (int)Mathf.Round(objectsCount / (objectsRate + 1));
		int itemsCount = objectsCount - enemiesCount;

		foreach(Tile tile in tiles)
		{
			tile.Reset();
		}

		List<Tile> randomTiles = new List<Tile>(tiles);

		Spawn(GameResources.Items, randomTiles, itemsCount);
		Spawn(levelNum == -1 ? GameResources.Enemies : GameResources.EnemiesStory[levelNum], randomTiles, enemiesCount);

        int index = Random.Range(0, randomTiles.Count);
        randomTiles[index].SetContent(GameResources.Exit);
        randomTiles.RemoveAt(index);

        index = Random.Range(0, randomTiles.Count);
        randomTiles[index].Avaliable = true;
        randomTiles[index].Reveal();
	}

	void Spawn(List<GameObject> from, List<Tile> tiles, int count)
	{
		for(int i = 0; i < count; i++)
		{
			int index = Random.Range(0, tiles.Count);
			Tile tile = tiles[index];
			tiles.RemoveAt(index);

			index = Random.Range(0, from.Count);
			tile.SetContent(from[index]);
		}
	}
}
*/