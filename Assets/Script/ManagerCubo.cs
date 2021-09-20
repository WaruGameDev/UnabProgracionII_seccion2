using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCubo : MonoBehaviour
{
    public static ManagerCubo instance;
    public GameObject cuboGenerado;
    public System.Action<float> onCallCubos;
    private void Awake()
    {
        instance = this;
    }
    public void CallCubos()
    {
        onCallCubos?.Invoke(Random.Range(100,400));
    }
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Instantiate(cuboGenerado, hit.point, Quaternion.identity);
            }
        }
    }
}
