using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayDialoge : MonoBehaviour
{
    [SerializeField] private NarratorsVoiceLinesSO _narratorsVoiceLinesSo;

    [SerializeField] [Range(0, 2)] private int _naratorVoiceType;
    [SerializeField] [Range(0, 25)] private int _naratorVoiceLine;
    
    private void OnTriggerEnter(Collider other)
    {
        switch (_naratorVoiceType)
        {
            case 0:
                FindObjectOfType<GameManager>().Enqueue(_narratorsVoiceLinesSo._mainStoryVoicelines[_naratorVoiceLine]);
                break;
            case 1:
                FindObjectOfType<GameManager>().Enqueue(_narratorsVoiceLinesSo._extraVoicelines[_naratorVoiceLine]);
                break;
            case 2:
                FindObjectOfType<GameManager>().Enqueue(_narratorsVoiceLinesSo._specialSoundslines[_naratorVoiceLine]);
                break;
        }
        GetComponent<Collider>().gameObject.transform.parent.gameObject.SetActive(false);
    }
}
