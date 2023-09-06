using UnityEditor;
using UnityEngine;

namespace IronMountain.ResourceUtilities.Editor
{
    [CustomPreview(typeof(ResourceTexture2D))]
    public class ResourceTexture2DPreview : ObjectPreview
    {
        public override bool HasPreviewGUI()
        {
            return true;
        }

        public override void OnPreviewGUI(Rect rect, GUIStyle background)
        {
            ResourceTexture2D resourceTexture2D = (ResourceTexture2D) target;
            Texture2D texture2D = resourceTexture2D ? resourceTexture2D.Asset : null;
            GUI.DrawTexture(rect, texture2D, ScaleMode.ScaleToFit);
        }
    }
}