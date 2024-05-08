using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//How you get your Animation componenet to the Anim scriptable object can depend on your specific project, this is just a simple, generic example.
public class ActorController : MonoBehaviour
{
    [SerializeField] private Animation _animation;

    //Using a struct holding an integer and unity event to specifiy animations for input
    [SerializeField] private List<AnimEvent> _animEvents = new List<AnimEvent>();

    //Helper to get animation event invoking
    private void InvokeAnimEvent(int invoker)
    {
        if (invoker == 0)
            return;

        foreach (AnimEvent aEvent in _animEvents)
        {
            if (aEvent.uEventInvoker == invoker)
            {
                aEvent.uEvent.Invoke();
            }
        }
    }

    //If there is a key down try to invoke an animation
    private void Update()
    {
        if (!Input.anyKeyDown)
            return;

        int aEventInvoker = 0;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            aEventInvoker = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            aEventInvoker = 2;
        }

        InvokeAnimEvent(aEventInvoker);
    }

    //LateUpdate to Animate
    private void LateUpdate()
    {
        if (_animation.clip == null)
            return;

        _animation.Play();

        /* This if statement will allow the animation component to loop, only stopping if "_playImmediate" is true on a new Anim
        You can setup your controller to incorporate looping through this, or on the Anim itself.
        if (_animation.isPlaying)
            return;*/

        _animation.clip = null;
    }
}

//Neat trick to isolate UnitEvents using ints
[System.Serializable]
public struct AnimEvent
{
    [SerializeField] private UnityEvent _uEvent;
    public UnityEvent uEvent => _uEvent;

    [SerializeField] private int _uEventInvoker;
    public int uEventInvoker => _uEventInvoker;
}
