using UnityEngine;
using UnityEngine.Events;
//Neat trick to isolate UnitEvents using ints
[System.Serializable]
public struct AnimEvent
{
    [SerializeField] private UnityEvent _uEvent;
    public UnityEvent uEvent => _uEvent;

    [SerializeField] private int _uEventInvoker;
    public int uEventInvoker => _uEventInvoker;
}
