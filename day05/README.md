# 🎯 Day 5 - Importing Assets, Prefabs, and Project Organization in Unity

## 1. Importing Assets
**Assets** are all the resources used in a Unity project, such as 3D models, images, sounds, scripts, materials, and more.

### How to Import Assets in Unity?
- **Using the Unity Asset Store:**  
  `Window -> Asset Store` (for older versions) or `Window -> Package Manager` (for newer versions).  
  Download the asset and click **Import**.
- **Using Drag & Drop:**  
  Open **File Explorer** (Windows) or **Finder** (Mac) and drag the files directly into the **Assets** folder in Unity.
- **Using the Import Menu:**  
  Go to `Assets -> Import New Asset` and select the file you want to import.
- **Importing a Unity Package (`.unitypackage`):**  
  `Assets -> Import Package -> Custom Package...`  
  Select the `.unitypackage` file and click **Import**.

---

## 2. Prefabs
A **Prefab** is a reusable, predefined object that can be instantiated multiple times in a scene.

### How to Create a Prefab?
1. Create an object in the scene.
2. Drag the object from the **Hierarchy** into the **Assets** folder.
3. Unity will automatically create a `.prefab` file.
4. You can now instantiate this Prefab multiple times in your scene.

### How to Edit a Prefab?
1. Double-click the **Prefab** in the **Assets** folder.
2. A separate **Prefab Editing Mode** will open.
3. Any modifications made to the Prefab will automatically update all instances of it in the scene.

---

