
#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateAssetBundles : EditorWindow {
    
    private string savePath = "C:/Pictura Bundles";

    void OnEnable() {
        
    }

    [MenuItem("Pictura/Build Asset Bundles")]
    public static void ShowWindow() {
        EditorWindow.GetWindow(typeof(CreateAssetBundles));
    }

    void OnGUI() {
        GUILayout.Label("Build Folder", EditorStyles.boldLabel);
        savePath = EditorGUILayout.TextField("Build Folder", savePath);

        if (GUILayout.Button("Build")) {
            if (!Directory.Exists(savePath)) {
                Directory.CreateDirectory(savePath);
            }
            BuildPipeline.BuildAssetBundles(savePath,
                                            BuildAssetBundleOptions.None,
                                            BuildTarget.StandaloneWindows);
        }
    }
}

#endif