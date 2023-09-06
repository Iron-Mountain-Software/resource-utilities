using UnityEditor;
using UnityEngine;

namespace IronMountain.ResourceUtilities.Editor
{
    [CustomPreview(typeof(ResourceSprite))]
    public class ResourceSpritePreview : ObjectPreview
    {
        public static void GUIDrawSprite(Rect rect, Sprite sprite)
        {
            if (!sprite) return;
            Rect spriteRect = sprite.rect;
            Texture2D texture = sprite.texture;

            float scale = Mathf.Min(rect.width / spriteRect.width, rect.height / spriteRect.height);
            Rect spriteContainer = rect;
            spriteContainer.width = spriteRect.width * scale;
            spriteContainer.height = spriteRect.height * scale;
            spriteContainer.x += (rect.width - spriteContainer.width) / 2f;
            spriteContainer.y += (rect.height - spriteContainer.height) / 2f;

            GUI.DrawTextureWithTexCoords(spriteContainer, texture, 
                new Rect(
                    spriteRect.x / texture.width, 
                    spriteRect.y / texture.height, 
                    spriteRect.width / texture.width, 
                    spriteRect.height / texture.height));
        }
        
        public override bool HasPreviewGUI()
        {
            return true;
        }

        public override void OnPreviewGUI(Rect rect, GUIStyle background)
        {
            ResourceSprite resourceSprite = (ResourceSprite) target;
            Sprite sprite = resourceSprite ? resourceSprite.Asset : null;
            GUIDrawSprite(rect, sprite);
        }
    }
}

