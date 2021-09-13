using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickEvent : MonoBehaviour
{
    public UnityEvent onClickEvent;
    private void Start()
    {
        CallPersonajeManager.instance.onCallPersonaje += CallThisPersonaje;
    }

    public void CallThisPersonaje()
    {
        onClickEvent?.Invoke();

    }    
}
