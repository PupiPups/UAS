using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaController : MonoBehaviour {
    public float life = 100;
    public float visionRadius;
    public float speed;
    public GameObject player;
    Vector3 target;
    public GunController gun;

    public GameController gameController;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadius)
        {
            target = player.transform.position;
            transform.LookAt(target);
            Fire();
            
        } else{
            NotFire();
        }
        Debug.DrawLine(transform.position, target, Color.green);
        if (life == 0)
        {

            Destroy(gameObject);
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
