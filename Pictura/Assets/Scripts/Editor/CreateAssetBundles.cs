
#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;

public class CreateAssetBundles : EditorWindow {
    
    private string savePath = "C:/Pictura Bundles";
    private int selectedPlatform = 0;

    void OnEnable() {
        
    }

    [MenuItem("Pictura/Build Asset Bundles")]
    public static void ShowWindow() {
        EditorWindow.GetWindow(typeof(CreateAssetBundles));
    }

    void OnGUI() {
        GUILayout.Label("Build Folder", EditorStyles.boldLabel);
        savePath = EditorGUILayout.TextField("Build Folder", savePath);
        
        string[] options = new string[]{ "Windows", "Mac OS", "iOS", "Android" };
        selectedPlatform = EditorGUILayout.Popup("Build Target", selectedPlatform, options);

        if (GUILayout.Button("Build")) {
            RemoveAllScripts();

            if (!Directory.Exists(savePath)) {
                Directory.CreateDirectory(savePath);
            }
            switch (selectedPlatform) {
                case 0: BuildPipeline.BuildAssetBundles(savePath, BuildAssetBundleOptions.ForceRebuildAssetBundle, BuildTarget.StandaloneWindows); break;
                case 1: BuildPipeline.BuildAssetBundles(savePath, BuildAssetBundleOptions.ForceRebuildAssetBundle, BuildTarget.StandaloneOSX); break;
                case 2: BuildPipeline.BuildAssetBundles(savePath, BuildAssetBundleOptions.ForceRebuildAssetBundle, BuildTarget.iOS); break;
                case 3: BuildPipeline.BuildAssetBundles(savePath, BuildAssetBundleOptions.ForceRebuildAssetBundle, BuildTarget.Android); break;
            }
        }
    }

    void RemoveAllScripts() {
        MonoBehaviour[] allObjectsWithScript = GameObject.FindObjectsOfType<MonoBehaviour>();
        foreach(MonoBehaviour mb in allObjectsWithScript) {
            if(mb.GetType() != typeof(PointOfInterest))
                DestroyImmediate(mb);
        }
    }
}

#endif