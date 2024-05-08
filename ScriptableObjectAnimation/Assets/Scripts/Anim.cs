using UnityEngine;

//There can be more checks and balances in here, depending on your need or desired complexity
[CreateAssetMenu (fileName = "AnimCommand", menuName = "Anim/Command")]
public class Anim : ScriptableObject
{
    [SerializeField] private AnimationClip _clip;
    public string clipName => _clip.name;

    [SerializeField] private bool _playImmediate;

    public void PlayAnimation(Animation toPlayOn)
    {
        if (_playImmediate && toPlayOn.clip != _clip)
            toPlayOn.Stop();

        else if (toPlayOn.isPlaying)
            return;

        if (!toPlayOn.GetClip(clipName))
            toPlayOn.AddClip(_clip, clipName);

        toPlayOn.clip = _clip;
    } 
}
