using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboSuscriptor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ManagerCubo.instance.onCallCubos += Jump;
    }

    public void Jump(float rng)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * rng);
    }
}
