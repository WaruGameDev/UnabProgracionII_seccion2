using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    public Apple()
    {
        nombreColor = "red";
    }
    public Apple(string newColor):base(newColor)
    {

    }
}
