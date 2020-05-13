# Pictura
This repository contains everything you need to create a custom level for Pictura

## Getting Started
1. Download Unity Hub (optional)
2. Add the "Pictura" project to the Unity Hub. From there, the Hub will tell you that you don't thave the correct version of Unity to Open the project, and will suggest you download & install it. Go ahead and do that.
3. The correct version of Unity is 2020.1.0b5.3485. Make sure you have this specific version installed.
4. Open the "Pictura" project in Unity. 
5. From here, the easiest way to get started is to make a copy of the "SampleScene" found in the Assets/Scenes folder and go from there!

## Building a level
When building a level for Pictura, the following elements must be in the level:

1. PlayerStart: This GameObjet indicates where the player will spawn. There should only be one of these in a level. Make sure it is close to the ground, and tagged with the "PlayStart" tag
2. LevelExit: This determines where the player must go to end the level. There can be more than one of these in a level. Make suertese are tagged with the "LevelExit" tag.
3. Environment: Add all static elements of your scene under this GameObjet. Things like terrain, rocks, houses, etc will be under here. Make sure this GameObject has the "Environment" layer assigned to it, and when asked, change all it's childen too. This is also where you add your post-effects (see next section)
4. Navmesh: Your environment should contain all the static objects for generating the navmesh. Select your environment GameObject, and in the Navigation tab, set it to "Navigation static" then click on "Generate".
5. Interests

## Optional items

1. Post-Effects: This sample project contains the Post-Process v2.3.0 package. Post-Processes are hgihly recommended, as they can give a visual identity, style and greatly enhance the quality of your scene. They are the secret to an amazing environment! The "Environment" GameObject is already setup as a Post-process volume. You can adjust these settings in the inspector, and we encourage you to play around with them!
2. Sun:
4. Lighting:
5. Project: The Sample Project is already setup properly with the correct tags and layers. Do not touch these, as they are very important for pictura to interpretthe game properly. Even the order is important.

## Other Considerations & Pitfalls

1. Camera: You can and should have a camera in the lvel while testing, but make sure to disable it or delete it before publishing. 
2. Wind Zone: Add a windzone if you want trees to sway in the wind.
3. Size & Perormances: 
4. Animations: Animations can be created and added to the scene.

## Where can I find Assets & 3D Models?
There are many places where you can find free assets, 3D models and animatinos to add to your scene. You will want to download files in the .fbx format to import them into Unity. 
Here are a few options:
1. The Unity Asset Store: https://assetstore.unity.com/
2. TurboSquid: https://www.turbosquid.com/
3. 3D Warehouse: https://3dwarehouse.sketchup.com/
4. CGTrader: https://www.cgtrader.com/

## Building an asset bundle
Once you are done building your level, select it in the Project tab, and at the bottom of the inspector window, under "Asset Labels", assign it to an AssetBundle. This is the name of the file that will be created when yuo exoprt your level. 
next, go to the "Pictura" menu item, and select "Build Asset Bundles". Make sure you enter a valid build folder for the Asset Bundle to be built. Click on the "Build" button. This will create a file that you can then load in Pictura, named after your AssetBundle!
For example, if you named your AssetBundle "samplescene" and setthe build path to "C:/Pictura Bundles", a file named "C:/Pictura Bundles/samplescene" will have been created. Share this file toshare yuor level with others! 
You can ignore the rest of the files created.


