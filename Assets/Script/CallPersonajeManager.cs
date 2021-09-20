using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class CallPersonajeManager : MonoBehaviour
{
    public static CallPersonajeManager instance;
    public Action onCallPersonaje;

    private void Awake()
    {
        instance = this;
    }

    public void CallPersonaje()
    {
        onCallPersonaje?.Invoke();
    }

    
}
