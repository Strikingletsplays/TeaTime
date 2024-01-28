using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMainLevel : MonoBehaviour
{
    [SerializeField] private InteractScript _interactScript;
    [SerializeField] private GameManager _gameManager;

    [SerializeField] private GameObject _scaryCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (_interactScript.CheckIfAllCollected())
        {
            //Trigger narator end dialog 
            StartCoroutine(EndCoroutine());
        }
    }

    IEnumerator EndCoroutine()
    {
        yield return new WaitUntil(_gameManager.AudioSourceIsPlaying);
        //Jump Scare
        _scaryCanvas.SetActive(true);
        yield return new WaitForSeconds(1);
        //Disable jump scare
        SceneManager.LoadScene(2);
    }
}
