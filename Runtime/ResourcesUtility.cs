using System.Linq;
using UnityEngine;

namespace IronMountain.ResourceUtilities
{
    public static class ResourcesUtility
    {
        public static T Search<T>(string fileName) where T : UnityEngine.Object
        {
            T[] results = UnityEngine.Resources.LoadAll<T>("/");
            foreach(T result in results)
            {
                if (result.name == fileName) return result;
            }
            return null;
        }

        public static Sprite LoadSprite(string pathToFolder, string fileName) 
        {
            return UnityEngine.Resources.Load<Sprite>(pathToFolder + fileName);
        }
    
        public static Sprite LoadSlicedSprite(string imagePath, string spriteName)
        {
            Sprite[] sprites = UnityEngine.Resources.LoadAll<Sprite>(imagePath);
            return sprites.FirstOrDefault(sprite => sprite.name == spriteName);
        }
    }
}