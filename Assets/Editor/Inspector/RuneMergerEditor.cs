using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Runes;

[CustomEditor(typeof(RuneMerger))]
public class RuneMergerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        RuneMerger merger = (RuneMerger)target;

        base.OnInspectorGUI();

        GUILayout.Space(15);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Merge Runes", GUILayout.Height(35)))
        {
            merger.Merge();
        }

        if (GUILayout.Button("Clear Selected Runes", GUILayout.Width(150), GUILayout.Height(35)))
        {
            merger.ClearRunes();
        }

        GUILayout.EndHorizontal();
    }
}
