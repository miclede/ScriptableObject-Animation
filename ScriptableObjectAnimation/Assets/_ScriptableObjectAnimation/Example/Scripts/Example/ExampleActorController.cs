using UnityEngine;

/// <summary>
/// Example actor controller demonstrating how to manage animations using Unity's Animation component and scriptable objects.
/// </summary>
public class ExampleActorController : MonoBehaviour
{
    [SerializeField] AnimationInvoker _animInvoker;

    int aEventInvoker;

    /// <summary>
    /// Checks for key presses and invokes corresponding animation events.
    /// </summary>
    private void Update()
    {
        if (!Input.anyKeyDown)
            return;

        aEventInvoker = AnimationInvoker.k_NoAnimationValue;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            aEventInvoker = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            aEventInvoker = 1;
        }

        _animInvoker.InvokeAnimEvent(aEventInvoker);
    }
}
