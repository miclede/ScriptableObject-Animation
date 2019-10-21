using UnityEngine;

[CreateAssetMenu(fileName = "Run", menuName = "Anims/Run")]
public class Anim_Run : Animation_Base
{
    public override void getAnimation(Controller Actor)
    {
        //logic for playing run animations here
        if (Input.GetKeyDown(KeyCode.W))
            Debug.Log("Run");
    }
}
