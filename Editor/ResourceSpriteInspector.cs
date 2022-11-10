using UnityEditor;

namespace SpellBoundAR.ResourceUtilities.Editor
{
    [CustomEditor(typeof(ResourceSprite), true)]
    public class ResourceSpriteInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("spriteFolder"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("spriteName"));
            EditorGUILayout.PropertyField(serializedObject.FindProperty("sliced"));
            if (serializedObject.FindProperty("sliced").boolValue)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("spriteFolder"));
            }
        }
    }
}