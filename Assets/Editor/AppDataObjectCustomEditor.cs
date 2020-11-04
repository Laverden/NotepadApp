using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class AssetHandler
{
    [OnOpenAsset()]
    public static bool OpenEditor (int instaceId, int line)
    {
        AppDataObject obj = EditorUtility.InstanceIDToObject(instaceId) as AppDataObject;

        if (obj != null)
        {
            AppDataObjectEditorWindow.Open(obj);
            return true;
        }

        return false;
    }
}

[CustomEditor(typeof(AppDataObject))]
public class AppDataObjectCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Open Editor"))
        {
            AppDataObjectEditorWindow.Open((AppDataObject)target);
        }
    }
}