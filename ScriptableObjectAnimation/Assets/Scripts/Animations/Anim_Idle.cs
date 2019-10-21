using UnityEngine;

[CreateAssetMenu(fileName = "Idle", menuName = "Anims/Idle")]
public class Anim_Idle : Animation_Base
{
    public override void getAnimation(Controller Actor)
    {
        //logic for playing the idle animation in here
        if (Input.GetKeyDown(KeyCode.S))
            Debug.Log("Idle");
    }
}
