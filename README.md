# Resource Utilities

Scriptable-objects that store references to assets in the Unity "Resources" folder. 

EASY SET UP!

When assets are directly referenced in a Unity scene, they are loaded into memory. Furthermore, when prefabs are loaded into memory, their dependencies are loaded with them. These assets are occupying valuable space, even if they aren't active in the scene.

This package allows the user to control when referenced "Resource" assets are loaded into memory.

To use:

1. Place the asset ("X") you want to reference in a folder called "Resources" (or a subfolder of "Resources")
2. If X is a prefab: Create > Scriptable Objects > Utilities > Resources > Resource GameObject. If X is a sprite: Create > Scriptable Objects > Utilities > Resources > Resource Sprite.
3. Select the Scriptable Object from step 2 and press the button that says "Refresh Folder".
4. Enter X's name into the name field of the Scriptable Object.
5. When scripts want to reference X, they should instead reference the paired Scriptable Object, and use the "Asset" property to load the original asset.

---

### Use this package to:
* Restructure your Resources folder without breaking string references.
* "Directly" reference resource assets without keeping them loaded in the scene.

---

### Key components:

1. ResourceGameObject
	* Create > Scriptable Objects > Utilities > Resources > Resource GameObject
2. ResourceSprite
	* Create > Scriptable Objects > Utilities > Resources > Resource Sprite