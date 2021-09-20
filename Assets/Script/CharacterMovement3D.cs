using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement3D : MonoBehaviour
{
    private Rigidbody rb;
    public float speedCharacter = 500;
    public float maxSpeed = 10;
    public Transform worldReference;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rb.AddForce(worldReference.forward * z * speedCharacter * Time.deltaTime);
        rb.AddForce(worldReference.right * x * speedCharacter * Time.deltaTime);

        if(x ==0 && z == 0)
        {
            rb.velocity *= 0.9f;
        }

        Vector3 vel = rb.velocity;
        vel.x = Mathf.Clamp(vel.x, -maxSpeed, maxSpeed);
        vel.y = Mathf.Clamp(vel.y, -maxSpeed, maxSpeed);
        vel.z = Mathf.Clamp(vel.z, -maxSpeed, maxSpeed);
        rb.velocity = vel;
    }
}
