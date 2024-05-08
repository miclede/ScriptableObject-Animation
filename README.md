# ScriptableObject-Animation
Updated for 2023.2.18f1

Animate using ScriptableObjects in Unity.

This is a simple system meant to help assist with quickly playing simple animations on objects in scene.
It is not meant to replace the more complex animation trees of Mecanim, but instead allow for quick implementaion of simple reusable animations via scriptable objects and the Animation componenet.

How it works:
Animation Clips are stored on a 'Anim' scriptable object, 'Anim' can be adjusted to your specific project needs (i.e. looping, breakpoints, blending), the clips are passed to a referenced Animation component (there is no need to assign the animations manually) and assigned to the active clip. How the animations play and how to assign the correct clip come down to the specific controller in your project, however for examples sake I have included an ActorController that handles this task via UnityEvents.

In Practice:
1. Setup Clip
2. Setup ScriptableObject
3. Setup Controller
4. Play!

[Unite Package Download](https://github.com/miclede/ScriptableObject-Animation/raw/master/SimpleScriptableObjectAnimation.unitypackage)
