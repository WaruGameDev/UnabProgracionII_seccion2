using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInventory
{
    public string nameItemInventory;
    public Item item1;
    public int count;

    public void GetName()
    {
        nameItemInventory = item1.nameItem;
    }
}

[System.Serializable]
public enum TYPE_MATERIAL
{
    Consumible,
    Material,
    Trash
}

[System.Serializable]
public class Item
{
    public string nameItem;
    public TYPE_MATERIAL typeMaterial;
    
}

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<ItemInventory> inventory;

    public void Awake()
    {
        instance = this;

    }
    public void AddItem(Item item, int count)
    {
        if(inventory.Count > 0)
        {
            foreach(ItemInventory i in inventory)
            {
                if(i.item1.nameItem == item.nameItem)
                {
                    i.count += count;
                    return;
                }
            }
            AddItemToInventory(item, count);
        }
        else
        {
            AddItemToInventory(item, count);
        }
    }
    public void AddItemToInventory(Item item, int count)
    {
        ItemInventory itemTemp = new ItemInventory();
        itemTemp.item1 = item;
        itemTemp.count = count;
        itemTemp.GetName();
        inventory.Add(itemTemp);
    }
}
