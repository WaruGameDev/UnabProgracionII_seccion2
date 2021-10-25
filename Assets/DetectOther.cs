using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOther : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        
    }
}
