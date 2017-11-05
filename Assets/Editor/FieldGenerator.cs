using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using Tiles;

public class FieldGenerator : EditorWindow
{
    private bool[,] checks = new bool[11, 11] { { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, true, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false},
                                                { false, false, false, false, false, false, false, false, false, false, false}
                                              };

    private float tileX = 140.8f;
    private float tileY = 83.2f;
    private float fieldX = 0;
    private float fieldY = 0;
    private int levelNum = 1;
    private GameObject prefab;
    private Transform levelsParent;

    [MenuItem("Window/Field Generator")]
    static void OpenWindow()
    {
        var window = GetWindow<FieldGenerator>();
        window.minSize = new Vector2(200, 350);
        window.Show();
    }

    void OnGUI()
    {
        prefab = (GameObject)EditorGUILayout.ObjectField("Tile prefab", prefab, typeof(GameObject), false);
        levelsParent = (Transform)EditorGUILayout.ObjectField("Levels parent", levelsParent, typeof(Transform), true);
        tileX = EditorGUILayout.FloatField("Tile width", tileX);
        tileY = EditorGUILayout.FloatField("Tile height", tileY);
        fieldX = EditorGUILayout.FloatField("X coord of field", fieldX);
        fieldY = EditorGUILayout.FloatField("Y coord of field", fieldY);
        levelNum = EditorGUILayout.IntField("Level number", levelNum);
        
        for (int i = 0; i < 11; ++i)
        {
            for (int j = 0; j < 11; ++j)
            {
                if (i <= 16 - j && i >= 4 - j && i <= j + 4 && i >= j - 4)
                {
                    checks[i, j] = GUI.Toggle(new Rect(10 + 15 * j, 175 + 15 * i, 15, 15), checks[i, j], "");
                }
            }
        }

        if (GUILayout.Button("Create!"))
        {
            GameObject level = new GameObject("Level" + levelNum);
            level.transform.position = new Vector3(fieldX, fieldY);
            level.transform.parent = levelsParent;

            GameObject field = new GameObject("Field" + levelNum);
            field.transform.position = new Vector3(fieldX, fieldY);
            field.transform.parent = level.transform;

            Tile[,] tiles = new Tile[11, 11];
            List<Tile> tilesList = new List<Tile>();

            for (int i = 0; i < 11; ++i)
            {
                for (int j = 0; j < 11; ++j)
                {
                    if (!checks[i, j])
                    {
                        continue;
                    }
                    GameObject spawned = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                    spawned.transform.position = new Vector3(tileX * (j + i - 10) / 2, tileY * (j - i) / 2, 0) + level.transform.position;
                    spawned.transform.parent = field.transform;
                    spawned.name = "F" + levelNum + "T" + i + "-" + j;

                    tiles[i, j] = spawned.GetComponent<Tile>();
                    tilesList.Add(tiles[i, j]);
                }
            }

            for (int i = 0; i < 11; ++i)
            {
                for (int j = 0; j < 11; ++j)
                {
                    if (tiles[i, j] == null)
                    {
                        continue;
                    }

                    if (j > 0 && tiles[i, j - 1] != null)
                    {
                        tiles[i, j].AddNeighbour(tiles[i, j - 1]);
                    }

                    if (j < 10 && tiles[i, j + 1] != null)
                    {
                        tiles[i, j].AddNeighbour(tiles[i, j + 1]);
                    }

                    if (i > 0 && tiles[i - 1, j] != null)
                    {
                        tiles[i, j].AddNeighbour(tiles[i - 1, j]);
                    }

                    if (i < 10 && tiles[i + 1, j] != null)
                    {
                        tiles[i, j].AddNeighbour(tiles[i + 1, j]);
                    }
                }
            }

            Field fc = field.AddComponent<Field>();
            fc.Tiles = tilesList;
        }
    }
}