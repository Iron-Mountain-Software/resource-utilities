using UnityEditor;
using UnityEngine;

namespace IronMountain.ResourceUtilities.Editor
{
    [CustomEditor(typeof(ResourceTexture2D), true), CanEditMultipleObjects]
    public class ResourceTexture2DInspector : ResourceAssetInspector
    {
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Refresh Folder"))
            {
                serializedObject.FindProperty("textureFolder").stringValue = GetCurrentRelativeFolder();
                EditorUtility.SetDirty(target);
            }

            EditorGUILayout.PropertyField(serializedObject.FindProperty("textureFolder"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("textureName"));

            serializedObject.ApplyModifiedProperties();
        }
    }
}