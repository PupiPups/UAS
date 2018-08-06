using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float life = 100;
    public float visionRadius;
    public float speed;
    public GameObject player;
    Vector3 target;
    public GunController gun;
    public GameController gameController;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        target = player.transform.position;
        float fixedspeed = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedspeed);
    }

    // Update is called once per frame
    void Update()
    {
        target = player.transform.position;
        float fixedspeed = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedspeed);
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadius)
        {
            speed = 0;
            transform.LookAt(target);
            Fire();

        }
        else
        {
            NotFire();
            speed = 10;
        }
        Debug.DrawLine(transform.position, target, Color.green);
        if (life == 0)
        {
            gameController.objetivos += 1;
        }
    }

    public void Fire()
    {
        gun.isFiring = true;
    }
    public void NotFire()
    {
        gun.isFiring = false;
    }
}
