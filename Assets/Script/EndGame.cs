using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(end());
    }

    IEnumerator end()
    {
        yield return new WaitForSeconds(15);
        Application.Quit();
    }
}
