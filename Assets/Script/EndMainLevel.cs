using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMainLevel : MonoBehaviour
{
    [SerializeField] private InteractScript _interactScript;

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
        yield return new WaitForSeconds(9);
        //Jump Scare
        yield return new WaitForSeconds(1);
        //Disable jump scare
        SceneManager.LoadScene(2);
    }
}
