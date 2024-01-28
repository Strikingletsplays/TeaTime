using System;
using System.Collections;
using Cinemachine;
using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractScript : MonoBehaviour
{
    private int objectsToCollect = 4;
    public int collectedItems = 0;
    private CharacterController _thirdPersonController;
    [SerializeField] private UIManager _uiManager;
    bool zoom = true;


    private void Start()
    {
        _thirdPersonController = GetComponent<CharacterController>();
    }

    public bool CheckIfAllCollected()
    {
        return objectsToCollect == collectedItems;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.TryGetComponent<ItemToCollect>(out var ItemToCollect);
        if (ItemToCollect == null) return;
        switch (ItemToCollect.GetItemType())
        {
            case Items.Honey:
                Debug.Log("Honey");
                collectedItems++;
                Destroy(other.gameObject);
                CheckIfWin();
                break;
            case Items.Kettle:
                Debug.Log("Kettle");
                collectedItems++;
                Destroy(other.gameObject);
                CheckIfWin();
                break;
            case Items.TeaBag:
                Debug.Log("TeaBag");
                collectedItems++;
                Destroy(other.gameObject);
                CheckIfWin();
                break;
            case Items.TeaCup:
                Debug.Log("TeaCup");
                collectedItems++;
                Destroy(other.gameObject);
                CheckIfWin();
                break;
        }
    }

    IEnumerator disableZoom()
    {
        yield return new WaitForSeconds(2);
        zoom = false;
        SceneManager.LoadScene(1);
    }

    IEnumerator DrinkTeaF()
    {
        bool zoom = true;
        yield return new WaitForSeconds(1);
        while (zoom)
        {
            yield return null;
            FindObjectOfType<CinemachineVirtualCamera>().m_Lens.FieldOfView -= 50 * Time.deltaTime;
        }
    }

    //Interacting with Doors
    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent<DrinkTea>(out var DrinkTea) && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(DrinkTeaF());
            StartCoroutine(disableZoom());
        }
        if (!other.TryGetComponent<TeleportScript>(out var teleportScript)) return;
        if (teleportScript != null && teleportScript.GetLevel() == collectedItems && Input.GetKeyDown(KeyCode.E))
        {
            _thirdPersonController.enabled = false;
            _thirdPersonController.transform.position = teleportScript.GetTeleportPoint().position;
            _thirdPersonController.enabled = true;
            _uiManager.DisablePressEText();
        }
    }

    private void CheckIfWin()
    {
        if (collectedItems == objectsToCollect)
        {
            //WakeUp!
            Debug.Log("Can Make Tea!");
        }
    }
}
