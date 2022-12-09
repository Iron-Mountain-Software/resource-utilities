using UnityEditor;
using UnityEngine;

namespace SpellBoundAR.ResourceUtilities.Editor
{
    [CustomEditor(typeof(ResourceGameObject), true), CanEditMultipleObjects]
    public class ResourceGameObjectInspector : ResourceAssetInspector
    {
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Refresh Folder"))
            {
                serializedObject.FindProperty("gameObjectFolder").stringValue = GetCurrentRelativeFolder();
                EditorUtility.SetDirty(target);
            }

            EditorGUILayout.PropertyField(serializedObject.FindProperty("gameObjectFolder"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("gameObjectName"));

            serializedObject.ApplyModifiedProperties();
        }
    }
}
