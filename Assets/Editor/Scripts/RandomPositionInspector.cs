using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomPosition))]
public class RandomPositionInspector : Editor
{
    public override void OnInspectorGUI()
    {
        RandomPosition component = (RandomPosition)target;

        component.min = EditorGUILayout.FloatField("Min", component.min);
        component.max = EditorGUILayout.FloatField("Max", component.max);

        EditorGUILayout.BeginHorizontal();
        
        if (GUILayout.Button("Randomize Position"))
        {
            component.transform.position = new()
            {
                x = Random.Range(component.min, component.max),
                y = Random.Range(component.min, component.max),
                z = Random.Range(component.min, component.max)
            };
        }

        if (GUILayout.Button("Reset Position"))
        {
            component.transform.position = Vector3.zero;
        }
        
        EditorGUILayout.EndHorizontal();
    }
}
