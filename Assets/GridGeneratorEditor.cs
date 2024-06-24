using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridGenerator))]
public class GridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GridGenerator gridGenerator = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid"))
        {
            gridGenerator.GenerateGrid();
        }
        if (GUILayout.Button("Clear Grid"))
        {
            gridGenerator.ClearGrid();
        }
        if (GUILayout.Button("Assign Material"))
        {
            gridGenerator.AssignMaterial();
        }

        if (GUILayout.Button("Assign Tile Script"))
        {
            gridGenerator.AssignTileScript();
        }
    }

    [MenuItem("Tools/Generate Grid")]
    public static void GenerateGridMenu()
    {
        GridGenerator gridGenerator = FindAnyObjectByType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.GenerateGrid();
        }
        else
        {
            Debug.LogError("No Grid Generator Found");
        }
    }
    [MenuItem("Tools/Clear Grid")]
    public static void ClearGridMenu()
    {
        GridGenerator gridGenerator = FindAnyObjectByType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.ClearGrid();
        }
        else
        {
            Debug.LogError("No Grid Generator Found");
        }
    }

    [MenuItem("Tools/Assign Material")]
    public static void AssignMaterialMenu()
    {
        GridGenerator gridGenerator = FindAnyObjectByType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.AssignMaterial();
        }
        else
        {
            Debug.LogError("No Grid Generator Found");
        }
    }

    [MenuItem("Tools/Grid/Generate Grid")]
    public static void AssignTileScript()
    {
        GridGenerator gridGenerator = FindAnyObjectByType<GridGenerator>();
        if (gridGenerator != null)
        {
            gridGenerator.AssignTileScript();
        }
        else
        {
            Debug.LogError("No Grid Generator Found");
        }
    }
}
