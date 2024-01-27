using UnityEngine;

public class PlayDialoge : MonoBehaviour
{
    [SerializeField] private NarratorsVoiceLinesSO _narratorsVoiceLinesSo;

    [SerializeField] [Range(0, 2)] private int _naratorVoiceType;
    [SerializeField] [Range(0, 25)] private int _naratorVoiceLine;

    [SerializeField] private AudioSource _audioSource;
    private void OnTriggerEnter(Collider other)
    {
        switch (_naratorVoiceType)
        {
            case 0:
                _audioSource.PlayOneShot(_narratorsVoiceLinesSo._mainStoryVoicelines[_naratorVoiceLine]);
                break;
            case 1:
                _audioSource.PlayOneShot(_narratorsVoiceLinesSo._extraVoicelines[_naratorVoiceLine]);
                break;
            case 2:
                _audioSource.PlayOneShot(_narratorsVoiceLinesSo._specialSoundslines[_naratorVoiceLine]);
                break;
        }
        GetComponent<Collider>().gameObject.transform.parent.gameObject.SetActive(false);
    }
}
