# Pictura
This repository contains everything you need to create a custom level for Pictura

## Getting Started
1. Download Unity Hub (optional)
2. Add the "Pictura" project to the Unity Hub. From there, the Hub will tell you that you don't thave the correct version of Unity to Open the project, and will suggest you download & install it. Go ahead and do that.
3. The correct version of Unity is 2020.1.0b5.3485. Make sure you have this specific version installed.
4. Open the "Pictura" project in Unity. 
5. Frmo here, the easiest way to get started is to make a copy of the "SampleScene" found in the Assets/Scenes folder and go from there!

## Building a level
When building a level for Pictura, the following elements must be in the level:

1. PlayerStart: This GameObjet indicates where the player will spawn. There should only be one of these in a level. Make sure it is close to the ground.
2. LevelExit: This determines where the player must go to end the level. There can be more than one of these in a level.
3. Environment: Make sure this GameObject has the "Environment" layer assigned to it, and when asked, change all it's childen too. This is also where you add your post-effects (see next section)
4. Navmesh: Your environment should contain all the static objects for generating the navmesh. Select yourenvironment GameObject, set it to "Navigation static" then click on "Generate".
5. Interests

## Additional things to consider

1. Sun
2. Wind Zone
3. Post-Effects
4. Lighting
5. Project: The Sample Project is already setup properly with the correct tags and layers. Do not touch these, as they are very important for pictura to interpretthe game properly. Even the order is important.

## Other Considerations & Pitfalls

1. Camera: You can and should have a camera in the lvel while testing, but make sure to disable it or delete it before publishing. 

## Building an asset bundle
Once you are done building your level, select it in the Project tab, and at the bottom of the inspector window, under "Asset Labels", assign it to an AssetBundle. This is the name of the file that will be created when yuo exoprt your level. 
next, go to the "Pictura" menu item, and select "Build Asset Bundles". Make sure you enter a valid build folder for the Asset Bundle to be built. Click on the "Build" button. This will create a file that you can then load in Pictura, named after your AssetBundle!
For example, if you named your AssetBundle "samplescene" and setthe build path to "C:/Pictura Bundles", a file named "C:/Pictura Bundles/samplescene" will have been created. Share this file toshare yuor level with others! 
You can ignore the rest of the files created.


