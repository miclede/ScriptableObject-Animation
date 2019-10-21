using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Processor_Animation", menuName = "Anims/Main Processor", order = -1)]
public class Processor_Animation : ScriptableObject
{
    [SerializeField]
    private List<Animation_Base> Anims = new List<Animation_Base>();

    public void GetAnimation(Controller Actor)
    {
        foreach (Animation_Base Anim in Anims)
        {
            Anim.getAnimation(Actor);
        }
    }

#if UNITY_EDITOR

    /*IF your going to have only one processor you can use 
    something like below to add the animations to the processor via a context menu
    instead of dragging them in the project view*/

    public void Add(Animation_Base anim)
    {
        Anims.Add(anim);
        CleanList();
        Save();
    } //end IF

    //clean list of duplicates and empty entries then save changes
    [ContextMenu("Clean Processor")]
    void CleanList()
    {
        Anims = Anims.Distinct().ToList();
        Anims = Anims.Where(Animation_Base => Animation_Base != null).ToList();
        Save();
    }

    //save changes to this asset
    void Save()
    {
        UnityEditor.EditorUtility.SetDirty(this);
        UnityEditor.AssetDatabase.SaveAssets();
        UnityEditor.AssetDatabase.Refresh();
    }
#endif

}