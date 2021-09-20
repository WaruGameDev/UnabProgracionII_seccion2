using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit 
{
    public string nombreColor;
    public Fruit()
    {
        nombreColor = "orange";
        // el primer constructor
    }

    public Fruit(string newColor)
    {
        nombreColor = newColor;
        // segundo contructor
    }

    public void Chop()
    {
        Debug.Log("La fruta " + nombreColor + " ha sido cortada.");
    }

    public void SayHello()
    {
        Debug.Log("Hola, soy una fruta " + nombreColor + ".");
    }

}
