using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet;
    public float timeToDissapear;
    public Vector3 direction;   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speedBullet * Time.deltaTime);
        
    }
    public void Shoot(Transform model)
    {
        //direction = model.forward;
        direction = model.worldToLocalMatrix.MultiplyVector(model.forward);
        //Vector3 newDirection = direction;
        //newDirection.z = 1;
        //direction = newDirection;

        transform.eulerAngles = model.eulerAngles;        
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z = 0;
        transform.eulerAngles = newRotation;

        gameObject.SetActive(true);
        StartCoroutine(TimeToDissapear());
    }
    IEnumerator TimeToDissapear()
    {
        yield return new WaitForSeconds(timeToDissapear);
        gameObject.SetActive(false);
        yield break;
    }
}
