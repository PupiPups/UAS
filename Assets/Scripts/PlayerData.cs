﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {
    public int life;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (life==0)
        {
            Destroy(gameObject);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hurt")
        {
            life -= 5;
        }

    }
}
