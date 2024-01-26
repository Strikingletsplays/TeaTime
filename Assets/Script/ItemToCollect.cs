using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToCollect : MonoBehaviour
{
    [SerializeField] private Items item;

    public Items GetItemType()
    {
        return item;
    }
}
public enum Items
{
    Kettle,
    TeaCup,
    TeaBag,
    Honey
}