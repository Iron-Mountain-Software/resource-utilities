using System.IO;
using UnityEngine;

namespace SpellBoundAR.ResourceUtilities
{
    public abstract class ResourceAsset<T> : ScriptableObject where T : Object
    {
        protected abstract string Folder { get; set; }
        protected abstract string Name { get; set; }
        
        public string ResourcePath => Path.Combine(Folder, Name);
        
        public virtual T Asset => UnityEngine.Resources.Load<T>(ResourcePath);

        public void Initialize(string assetFolder, string assetName)
        {
            Folder = assetFolder;
            Name = assetName;
        }
    }
}
