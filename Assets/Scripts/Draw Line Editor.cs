using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor( typeof( DrawLine ) )]

public class DrawLineEditor : Editor 
{
    private void OnSceneGUI()
    {
        DrawLine t = target as DrawLine;
        Transform handleTransform = t.transform;
    }
}
