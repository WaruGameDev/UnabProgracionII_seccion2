using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onTriggerEnter, onTriggerExit;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            onTriggerEnter?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            onTriggerExit?.Invoke();
        }
    }
}
