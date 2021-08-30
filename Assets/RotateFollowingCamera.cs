using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFollowingCamera : MonoBehaviour
{
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x,Camera.main.transform.eulerAngles.y,
            transform.eulerAngles.z);
    }
    private void LateUpdate()
    {
        transform.position = player.position;
    }
}
