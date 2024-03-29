﻿using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine.SceneManagement;

namespace EnterKratos.Editor
{
    internal class SceneLoaderBuildProcessor : IProcessSceneWithReport
    {
        public int callbackOrder => 0;

        public void OnProcessScene(Scene scene, BuildReport report)
        {
            foreach (var gameObject in scene.GetRootGameObjects())
            {
                var sceneLoaders = gameObject.GetComponentsInChildren<SceneLoader>(true);
                foreach (var sceneLoader in sceneLoaders)
                {
                    sceneLoader.scenePath = AssetDatabase.GUIDToAssetPath(sceneLoader.sceneGuid);
                }
            }
        }
    }
}