using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWithRaycast : MonoBehaviour
{
    public float lenghtRaycast = 3;
    public float stenght = 200;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.up * -lenghtRaycast);
        if(Physics.Raycast(transform.position, -transform.up, out hit, lenghtRaycast))
        {
            rb.AddForce(UpTension(Random.Range(2, 4)) * transform.up);
            ShowInfo(rb.velocity.y.ToString());
        }
    }
    float UpTension(float valor)
    {
        return stenght * valor ;
    }
    public void ShowInfo(string info)
    {
        print(info);
        Humano huma = new Humano();
        huma.nameHuman = "Pedro";
        huma.SetName();
    }
}
