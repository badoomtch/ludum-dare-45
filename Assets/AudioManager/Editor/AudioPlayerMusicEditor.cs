﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AudioPlayerMusic))]
public class AudioPlayerMusicEditor : Editor
{
    AudioManager am;

    public override void OnInspectorGUI()
    {
        if (am == null) am = AudioManager.GetInstance();

        AudioPlayerMusic myScript = (AudioPlayerMusic)target;

        List<string> options = new List<string>();

        options.Add("None");
        foreach (string s in am.GetMusicDictionary().Keys)
        {
            options.Add(s);
        }

        string music = serializedObject.FindProperty("music").stringValue;

        if (music == "None" && myScript.GetAttachedFile() == null)
        {
            EditorGUILayout.HelpBox("Choose some music to play before running!", MessageType.Error);
        }

        DrawDefaultInspector();

        GUIContent musicDesc = new GUIContent("Music", "Music that will be played");

        if (music.Equals("") || !options.Contains(music)) // Default to "None"
        {
            music = options[EditorGUILayout.Popup(musicDesc, 0, options.ToArray())];
        }
        else
        {
            music = options[EditorGUILayout.Popup(musicDesc, options.IndexOf(music), options.ToArray())];
        }

        serializedObject.FindProperty("music").stringValue = music;

        serializedObject.ApplyModifiedProperties();
    }
}
