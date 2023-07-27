using System.IO;
using UnityEditor;
using UnityEngine;

namespace IronMountain.ResourceUtilities.Editor
{
    public static class MenuItems
    {
        [MenuItem("Assets/Create Resource", true)]
        static bool ValidateLogSelectedTransformName()
        {
            return Selection.objects.Length > 0;
        }
 
        [MenuItem("Assets/Create Resource", false)]
        private static void CreateResource(MenuCommand menuCommand)
        {
            foreach (Object selection in Selection.objects)
            {
                if (!selection) continue;
                string assetPath = AssetDatabase.GetAssetPath(selection);
                string directory = Path.GetDirectoryName(assetPath);
                if (!directory.Contains("Resources"))
                {
                    Debug.LogError("Error: A Resource can only be created in the resources folder.");
                    return;
                }
                string[] folders = directory.Split("Resources");
                string relativePath = folders[^1].Trim(Path.PathSeparator, Path.DirectorySeparatorChar);
                string filename = Path.GetFileNameWithoutExtension(assetPath);
                if (selection is Texture2D)
                {
                    ResourceSprite resourceSprite = ScriptableObject.CreateInstance(typeof(ResourceSprite)) as ResourceSprite;
                    if (resourceSprite)
                    {
                        resourceSprite.Initialize(relativePath, filename);
                        Save(directory, filename, resourceSprite);
                    }
                }
                else if (selection is GameObject)
                {
                    ResourceGameObject resourceGameObject = ScriptableObject.CreateInstance(typeof(ResourceGameObject)) as ResourceGameObject;
                    if (resourceGameObject)
                    {
                        resourceGameObject.Initialize(relativePath, filename);
                        Save(directory, filename, resourceGameObject);
                    }
                }
            }
        }

        private static void Save(string directory, string filename, Object asset)
        {
            string path = Path.Combine(directory, filename + ".asset");
            AssetDatabase.CreateAsset(asset, path);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }
    }
}