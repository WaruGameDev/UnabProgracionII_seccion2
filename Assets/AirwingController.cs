using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class AirwingController : MonoBehaviour
{
    public Transform controller;
    public Transform model;
    public float speedAirwing;
    public float speedOnRail;
    public Vector2 limit;
    public float maxRotationY, maxRotationX, maxRotationZ;
    public CinemachineDollyCart dolly;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        controller.Translate(transform.right * speedAirwing * Time.deltaTime * x);
        controller.Translate(transform.up * speedAirwing * Time.deltaTime * y);

        Vector2 pos = controller.localPosition;
        pos.x = Mathf.Clamp(pos.x, -limit.x, limit.x);
        pos.y = Mathf.Clamp(pos.y, -limit.y, limit.y);
        controller.localPosition = pos;

        dolly.m_Position += speedOnRail * Time.deltaTime;

        Vector3 airwingRotation = model.localEulerAngles;
        airwingRotation.x = Mathf.LerpAngle(airwingRotation.x, y * -maxRotationX, 0.2f);
        airwingRotation.y = Mathf.LerpAngle(airwingRotation.y, x * maxRotationY, 0.2f);
        airwingRotation.z = Mathf.LerpAngle(airwingRotation.z, x * -maxRotationZ, 0.2f);

        model.localEulerAngles = airwingRotation;
    }
}
