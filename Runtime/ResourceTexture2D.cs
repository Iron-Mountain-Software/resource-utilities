using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IronMountain.ResourceUtilities
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Utilities/Resources/Resource Texture2D")]
    public class ResourceTexture2D : ResourceAsset<Texture2D>
    {
        [SerializeField] private string textureFolder;
        [SerializeField] private string textureName;

        protected override string Folder
        {
            get => textureFolder;
            set => textureFolder = value;
        }

        protected override string Name
        {
            get => textureName;
            set => textureName = value;
        }
        
        public override Texture2D Asset => Resources.Load<Texture2D>(ResourcePath);
    }
}