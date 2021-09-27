using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPooling : MonoBehaviour
{
    public GameObject bullet;
    public List<GameObject> poolBullet;
    public int poolSize = 100;
    public List<Transform> canones;
   
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bulletGo = Instantiate(bullet, Vector3.zero, Quaternion.identity);
            poolBullet.Add(bulletGo);
            bulletGo.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        foreach(Transform canon in canones)
        {           
            poolBullet[0].transform.position = canon.position;
            poolBullet[0].GetComponent<Bullet>().Shoot(canon);
            poolBullet.Insert(poolBullet.Count - 1, poolBullet[0]);
            poolBullet.RemoveAt(0);            
        }
    }
}
