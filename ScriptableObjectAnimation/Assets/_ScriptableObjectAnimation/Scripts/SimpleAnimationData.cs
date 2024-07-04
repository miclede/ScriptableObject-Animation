using UnityEngine;

/// <summary>
/// Stores data for a simple animation clip and provides functionality to play it on an Animation component.
/// </summary>
[CreateAssetMenu(fileName = "AnimData", menuName = "Animation/Simple Animation Data")]
public class SimpleAnimationData : ScriptableObject
{
    [SerializeField] private AnimationClip _clip;
    public string ClipName => _clip.name;

    [SerializeField] private bool _playImmediate;

    /// <summary>
    /// Plays the stored animation clip on the provided Animation component.
    /// </summary>
    /// <param name="animation">The Animation component on which to play the animation.</param>
    public void PlayAnimation(Animation animation)
    {
        if (animation == null)
        {
            Debug.LogError("Animation component is null.");
            return;
        }

        if (_playImmediate)
        {
            StopCurrentAnimation(animation);
        }

        if (!IsAnimationPlaying(animation))
        {
            AddClipIfNotExists(animation);
            animation.clip = _clip;
            animation.Play();
        }
    }

    private void StopCurrentAnimation(Animation animation)
    {
        if (animation.clip != null && animation.isPlaying)
        {
            animation.Stop();
        }
    }

    private bool IsAnimationPlaying(Animation animation)
    {
        return animation.clip == _clip && animation.isPlaying;
    }

    private void AddClipIfNotExists(Animation animation)
    {
        if (animation.GetClip(ClipName) == null)
        {
            animation.AddClip(_clip, ClipName);
        }
    }
}