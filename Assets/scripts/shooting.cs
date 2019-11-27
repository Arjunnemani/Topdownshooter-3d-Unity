using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public bool isFiring;
    public BulletController bullet;
    public float bulletSpeed;
    private float bulletdis;
    public float timeb;
    public Transform firepoint;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(isFiring)
        {
            bulletdis -= Time.deltaTime;
            if(bulletdis<=0)
            {
                bulletdis = timeb;
               BulletController newBullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as BulletController;
                newBullet.speed = bulletSpeed;
            
            }

        }
        else
        {
            bulletdis = 0;
        }
        
    }
}
