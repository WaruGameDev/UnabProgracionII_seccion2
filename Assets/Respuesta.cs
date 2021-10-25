using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta : MonoBehaviour
{
    public bool isCorrect;
    public void Response()
    {
        if(isCorrect)
        {
            print("Yay");
        }
        else
        {
            print("Nay");
        }
    }
}
