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
        AddItem();
    }

    public void AddItem()
    {
        InventoryManager.instance.AddItem(item, count);
    }
    public void DropItem()
    {
        InventoryManager.instance.DropItemFromInventory(item, count);
    }


}
