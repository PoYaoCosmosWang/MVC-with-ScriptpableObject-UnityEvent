using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IntEvent), editorForChildClasses: true)]
public class IntEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        IntEvent e = target as IntEvent;
        if (GUILayout.Button("Invoke"))
            e.Invoke(e.integer);
        //if (GUILayout.Button("Log"))
        //   e.Log();
    }
}
