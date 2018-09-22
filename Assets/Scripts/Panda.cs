using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Panda : MonoBehaviour {
    public string name = "Panda";
    public float maxHealth = 200;
    public float currentHealth;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveX = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveY = CrossPlatformInputManager.GetAxis("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * speed, moveY * speed);
    }
}
