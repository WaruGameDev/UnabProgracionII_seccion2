using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fruit myFruit = new Fruit();
        Apple myApple = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();

        Fruit newFruit = new Fruit("Yellow");

        newFruit.SayHello();
        newFruit.Chop();

    }

    
}
