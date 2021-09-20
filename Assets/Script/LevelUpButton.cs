using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelUpButton : MonoBehaviour
{
    public Button levelUpButton;
    public int priceLevel = 5;

    private void Start()
    {
        CatManager.instance.onGetMoney += CheckButton;
    }
    public void CheckButton()
    {
        if(CatManager.instance.dinero >= priceLevel)
        {
            levelUpButton.interactable = true;
        }
        else
        {
            levelUpButton.interactable = false;
        }
    }
    public void LevelUp()
    {
        CatManager.instance.AddDinero(-priceLevel);
        priceLevel *= 2;
        
    }
}
