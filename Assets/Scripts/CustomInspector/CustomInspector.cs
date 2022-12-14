using System;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MazeGenerator))]       //binds the buttons to a script
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        MazeGenerator mg = (MazeGenerator) target;
        if (GUILayout.Button("Generate maze step by step")) //see the maze generate step by step
            mg.GenerateStepByStep();
         
        if(GUILayout.Button("Generate maze instantly")) // instantly generate the maze
           mg.GenerateInstantMaze();
        
        if(GUILayout.Button("Delete maze"))             // delete the maze so that you get a new one
            mg.DeleteMaze();
    }
}
