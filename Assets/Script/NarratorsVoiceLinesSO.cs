using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NarratorsVoiceLinesSO", menuName = "ScriptableObjects/NarratorsVoiceLinesSO", order = 1)]
public class NarratorsVoiceLinesSO: ScriptableObject
{
    public List<AudioClip> _mainStoryVoicelines;
    public List<AudioClip> _extraVoicelines;
    public List<AudioClip> _specialSoundslines;
}