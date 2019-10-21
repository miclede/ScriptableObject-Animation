using UnityEngine;

public class Controller : MonoBehaviour
{
    //place the processor into the inspector that is tied to that actor this controller is attached to
    [SerializeField]
    private Processor_Animation animationProcessor;
    public Processor_Animation AnimationProcessor => animationProcessor;

    //late update for animations
    private void LateUpdate()
    {
        AnimationProcessor.GetAnimation(this);
    }
}
