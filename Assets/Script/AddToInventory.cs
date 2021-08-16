using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInventory : MonoBehaviour
{
    public Item item;
    public int count;

    public void OnMouseDown()
    {
        gameObject.SetActive(false);
        InventoryManager.instance.AddItem(item, count);
    }


}
