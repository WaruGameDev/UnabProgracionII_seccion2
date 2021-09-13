using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CatManager : MonoBehaviour
{
    public static CatManager instance;
    public int dinero;
    public System.Action onGetMoney;
    public TextMeshProUGUI dineroText;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        AddDinero(0);
    }
    public void AddDinero(int i)
    {
        dinero += i;
        onGetMoney?.Invoke();
        dineroText.text = dinero.ToString();
    }
    
}
