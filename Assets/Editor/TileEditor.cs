using UnityEditor;
using UnityEngine;

using Tiles;
using Interactables;

[CustomEditor(typeof(Tile))]
class TileEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Tile tile = target as Tile;
        GameObject content = tile.Content == null ? null : tile.Content.gameObject;

        bool avaliable = false;
        bool opened = false;

        avaliable = EditorGUILayout.Toggle("Avaliable", avaliable);
        opened = EditorGUILayout.Toggle("Opened", opened);

        if (opened && !tile.Avaliable)
        {
            avaliable = true;
        }

        tile.Avaliable = avaliable;
        tile.Opened = opened;

        EditorGUI.BeginChangeCheck();
        content = (GameObject)EditorGUILayout.ObjectField(content, typeof(GameObject), false);
        if (EditorGUI.EndChangeCheck() && content.GetComponent<Interactable>() != null)
        {
            GameObject spawned = Instantiate(content);
            tile.Content = spawned.GetComponent<Interactable>();
        }
        EditorGUI.EndChangeCheck();
    }            
}
