using System.Linq;
using UnityEngine;

namespace IronMountain.ResourceUtilities
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Utilities/Resources/Resource Sprite")]
    public class ResourceSprite : ResourceAsset<Sprite>
    {
        [SerializeField] private string spriteFolder;
        [SerializeField] private string spriteName;
        [SerializeField] private bool sliced;
        [SerializeField] private string slicedSpriteName;

        protected override string Folder
        {
            get => spriteFolder;
            set => spriteFolder = value;
        }

        protected override string Name
        {
            get => spriteName;
            set => spriteName = value;
        }
        
        public override Sprite Asset
        {
            get
            {
                if (!sliced) return UnityEngine.Resources.Load<Sprite>(ResourcePath);
                Sprite[] sprites = UnityEngine.Resources.LoadAll<Sprite>(ResourcePath);
                return sprites.FirstOrDefault(sprite => sprite.name == slicedSpriteName);
            }
        }
    }
}