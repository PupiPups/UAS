﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Panda : MonoBehaviour {
    public string name = "Panda";
    public float maxHealth = 200;
    public float currentHealth;
    public float speed;
    public GameObject gun;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Look();
    }
    void Move()
    {
        float moveX = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveY = CrossPlatformInputManager.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * speed, moveY * speed);
    }
    void Look()
    {

        float look = Mathf.Atan2(CrossPlatformInputManager.GetAxis("Vertical_2"), CrossPlatformInputManager.GetAxis("Horizontal_2")) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.Euler(0f, 0f, look);
    }
    void Abilty()
    {
        //var hivegenerate = Instantiate("Hive", transform.position, Quaternion rotation);
    }
    void Fire()
    {

    }
}
