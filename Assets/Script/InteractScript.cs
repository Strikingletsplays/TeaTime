using System;
using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    private int objectsToCollect = 4;
    public int collectedItems = 0;
    private CharacterController _thirdPersonController;

    private void Start()
    {
        _thirdPersonController = GetComponent<CharacterController>();
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

    //Interacting with Doors
    private void OnTriggerStay(Collider other)
    {
        if (!other.TryGetComponent<TeleportScript>(out var teleportScript)) return;
        if (teleportScript != null && teleportScript.GetLevel() == collectedItems && Input.GetKeyDown(KeyCode.E))
        {
            _thirdPersonController.enabled = false;
            _thirdPersonController.transform.parent.position = teleportScript.GetTeleportPoint().position;
            _thirdPersonController.enabled = true;
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
