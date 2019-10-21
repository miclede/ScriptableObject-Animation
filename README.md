# ScriptableObject-Animation
Animate using ScriptableObjects in Unity.

ScriptableObjects are relatively new in Unity and I wanted to find some interesting ways to use them. So I made a system that plays animations from them. This case is for animations but the structure can be used in many things.

How it works:
1. Create a Main_Processor ScriptableObject that will store and tell the animations themselves to play.
2. Create a Base logic_processor that all other logic processors will inherit from for communication with the Main_Processor.
    -Possible automatically add all logic_processors to tha Main_Processor using #Unity_Editor code so you don't have to find and drag          them in everytime to the Main_Processor
3. Create individual logic processors that collects information and works with (in this example) an animator to play animations.
4. Take the individual logic processors and add them to the Main Processor's storage (a List in this example) for play.
5. Add the Main Processor to a Character Controller.
6. Call Main_Processor.Process (AnimationProcessor.GetAnimation) (LateUpdate for animations)

In Practice:
1. PlayerAnimation_Processor is made.
2. PlayerAnimationBase is made.
3. Create animations; inherit from PlayerAnimationBase //(Move, Shoot, Jump, ect.)
4. Create ScriptableObject of the animation.
//if not using #UNITY_EDITOR code to add animations to the processor with a context menu you will have to drag them to the processor
