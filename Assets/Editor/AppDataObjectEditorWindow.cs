using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class AppDataObjectEditorWindow : ExtendedEditorWindow
{
    public static void Open(AppDataObject dataObject)
    {
        AppDataObjectEditorWindow window = GetWindow<AppDataObjectEditorWindow>("App Data Editor");
        window.serializedObject = new SerializedObject(dataObject);
    }

    private void OnGUI()
    {
        List<string> properties = new List<string>()
        {
            "appInformation",
            "develInformation"
        };

        EditorGUILayout.BeginHorizontal();

        EditorGUILayout.BeginVertical("box", GUILayout.MaxWidth(150), GUILayout.ExpandHeight(true));

        foreach (string pName in properties)
        {
            currentProperty = serializedObject.FindProperty(pName);
            DrawSidebarBasedOnClass(currentProperty);
            //DrawSidebar(currentProperty);
        }
        
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical("box", GUILayout.ExpandHeight(true));

        if (selectedProperty != null)
        {
            DrawProperties(selectedProperty, true);
        }
        else
        {
            EditorGUILayout.LabelField("Select and item from the list");
        }

        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();

        Apply();
    }
}