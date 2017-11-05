using UnityEditor;
using UnityEngine;

using Tiles;

[CustomEditor(typeof(Field))]
class FieldEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var field = target as Field;

        if (GUILayout.Button("Show all tiles"))
        {
            foreach (Tile tile in field.Tiles)
            {
                tile.SetTransparent(true);
            }
        }

        if (GUILayout.Button("Restore"))
        {
            foreach (Tile tile in field.Tiles)
            {
                tile.SetTransparent(false);
            }
        }
    }
}