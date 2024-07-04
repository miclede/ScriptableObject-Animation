using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent (typeof(Animation))]
public class AnimationInvoker : MonoBehaviour
{
    [SerializeField] List<AnimEvent> _animEvents = new();

    public const int k_NoAnimationValue = -14152529;

    /// <summary>
    /// Invokes the animation event associated with the specified invoker.
    /// </summary>
    /// <param name="invoker">The invoker identifier associated with the animation event to invoke.</param>
    public void InvokeAnimEvent(int invoker)
    {
        if (invoker == k_NoAnimationValue)
            return;

        var animEvent = _animEvents.FirstOrDefault(a => a.uEventInvoker == invoker);

        animEvent.uEvent?.Invoke();
    }
}
