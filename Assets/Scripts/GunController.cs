using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
    public bool isFiring;
    public BulletController bullet;
    public float bulletSpeed;
    public Transform firePoint;
    public float timeBetweenShots;
    public float shotCounter;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = (BulletController)Instantiate(bullet, firePoint.position, firePoint.rotation);
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
    }
}
