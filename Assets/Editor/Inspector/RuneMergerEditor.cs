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

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Merge Runes"))
        {
            merger.Merge();
        }

        if (GUILayout.Button("Clear Selected Runes"))
        {
            merger.ClearRunes();
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(15);

        base.OnInspectorGUI();
    }
}
