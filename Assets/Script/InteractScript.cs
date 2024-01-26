using System;
using Unity.VisualScripting;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    private int objectsToCollect = 4;
    private int collectedItems = 0;
    

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

    private void CheckIfWin()
    {
        if (collectedItems == objectsToCollect)
        {
            //WakeUp!
            Debug.Log("Can Make Tea!");
        }
    }
}
