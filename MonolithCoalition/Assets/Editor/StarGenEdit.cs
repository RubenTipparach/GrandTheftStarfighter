using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(StarGenerator))]
public class StarGenEdit : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        StarGenerator myScript = (StarGenerator)target;

        if (GUILayout.Button("Generate Stars"))
        {
            myScript.GenerateStars();
        }

        if (GUILayout.Button("Clear All"))
        {
            myScript.ClearStars();
        }
    }
}
