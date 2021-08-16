using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card",
    menuName = "CardGame/Card", order = 0)]

public class Card : ScriptableObject
{
    public string nameCard;
    public string description;
    public int attackCard;
    public int defendCard;

    public void ShowInfo()
    {
        Debug.Log(nameCard + " " + description);
    }
}
