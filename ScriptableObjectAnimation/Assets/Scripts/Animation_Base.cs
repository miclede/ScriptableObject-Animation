using UnityEngine;

public abstract class Animation_Base : ScriptableObject
{
    public virtual void getAnimation(Controller Actor)
    { }

    /*IF your going to have only one processor you can use 
    something like below to add the animations to the processor via a context menu
    instead of dragging them in the project view*/

#if UNITY_EDITOR
    [ContextMenu("Add to Processor")]
    void AddtoProcessor()
    {
        Processor_Animation proAnim =
            (Processor_Animation)UnityEditor.AssetDatabase.LoadAssetAtPath
                ("Assets/ScriptableObjects/Processor_Animation.asset", typeof(Processor_Animation));

        if (proAnim != null)
            proAnim.Add(this);
    } //end IFs
#endif
}
