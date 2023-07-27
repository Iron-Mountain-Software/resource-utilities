using System.IO;
using System.Linq;
using UnityEditor;

namespace IronMountain.ResourceUtilities.Editor
{
    [CustomEditor(typeof(ResourceAsset<>), true), CanEditMultipleObjects]
    public class ResourceAssetInspector : UnityEditor.Editor
    {
        protected string GetCurrentRelativeFolder()
        {
            string fullPath = AssetDatabase.GetAssetPath(target);
            string directoryName = Path.GetDirectoryName(fullPath);
            string relativeDirectoryName = directoryName.Split("Resources/").Last();
            return relativeDirectoryName;
        }
    }
}
