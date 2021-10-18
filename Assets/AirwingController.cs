using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class AirwingController : MonoBehaviour
{
    public Transform controller;
    public Transform model;
    public Transform barrelRoll;
    public bool duringBarrelRoll;
    public float durationBarrelRoll;
    public float speedAirwing;
    public float speedOnRail;
    public Vector2 limit;
    public float maxRotationY, maxRotationX, maxRotationZ;
    public float speedRotation = 0.03f;
    public CinemachineDollyCart dolly;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if(!duringBarrelRoll)
        {
            controller.Translate(transform.right * speedAirwing * Time.deltaTime * x);
            controller.Translate(transform.up * speedAirwing * Time.deltaTime * y);

            Vector2 pos = controller.localPosition;
            pos.x = Mathf.Clamp(pos.x, -limit.x, limit.x);
            pos.y = Mathf.Clamp(pos.y, -limit.y, limit.y);
            controller.localPosition = pos;

           

            Vector3 airwingRotation = model.localEulerAngles;
            airwingRotation.x = Mathf.LerpAngle(airwingRotation.x, y * -maxRotationX, speedRotation);
            airwingRotation.y = Mathf.LerpAngle(airwingRotation.y, x * maxRotationY, speedRotation);
            airwingRotation.z = Mathf.LerpAngle(airwingRotation.z, x * -maxRotationZ, speedRotation);

            model.localEulerAngles = airwingRotation;
        }
        dolly.m_Position += speedOnRail * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.B) && !duringBarrelRoll)
        {
            StartCoroutine(BarrelRoll());
        }
    }
    public void SetBarrelRoll(bool barrel)
    {
        duringBarrelRoll = barrel;
    }
    IEnumerator BarrelRoll()
    {
        SetBarrelRoll(true);
        Vector3 localForward = barrelRoll.worldToLocalMatrix.MultiplyVector(barrelRoll.forward);
        barrelRoll.DOLocalRotate(localForward * 360, durationBarrelRoll, RotateMode.FastBeyond360);
        yield return new WaitForSeconds(durationBarrelRoll);
        SetBarrelRoll(false);
        yield break;
    }
}
