using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NoArgEvent), editorForChildClasses: true)]
public class NoArgEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        NoArgEvent e = target as NoArgEvent;
        if (GUILayout.Button("Invoke"))
            e.Invoke();
        //if (GUILayout.Button("Log"))
        //   e.Log();
    }
}
