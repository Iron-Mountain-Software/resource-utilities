using System;
using UnityEditor;
using UnityEngine;

namespace IronMountain.ResourceUtilities.Editor
{
    [CustomEditor(typeof(ResourceSprite), true), CanEditMultipleObjects]
    public class ResourceSpriteInspector : ResourceAssetInspector
    {
        private ResourceSprite _resourceSprite;
        
        private void OnEnable()
        {
            _resourceSprite = (ResourceSprite) target;
        }

        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Refresh Folder"))
            {
                serializedObject.FindProperty("spriteFolder").stringValue = GetCurrentRelativeFolder();
                EditorUtility.SetDirty(target);
            }

            EditorGUILayout.PropertyField(serializedObject.FindProperty("spriteFolder"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("spriteName"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("sliced"));
            if (serializedObject.FindProperty("sliced").boolValue)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("slicedSpriteName"));
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}