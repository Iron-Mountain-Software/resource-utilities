using UnityEngine;

namespace SpellBoundAR.ResourceUtilities
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Utilities/Resources/Resource GameObject")]
    public class ResourceGameObject : ResourceAsset<GameObject>
    {
        [SerializeField] private string gameObjectFolder;
        [SerializeField] private string gameObjectName;

        protected override string Folder
        {
            get => gameObjectFolder;
            set => gameObjectFolder = value;
        }

        protected override string Name
        {
            get => gameObjectName;
            set => gameObjectName = value;
        }
    }
}