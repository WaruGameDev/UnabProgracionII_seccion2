using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazoManager : MonoBehaviour
{
    public List<Card> mazo;

    public void CallCarta()
    {
        mazo[Random.Range(0, mazo.Count)].ShowInfo();
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            CallCarta();
        }
    }

}
