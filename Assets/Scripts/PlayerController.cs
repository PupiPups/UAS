using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerController : MonoBehaviour {
    public float movespeed;
    public Vector3 movement;
    public Vector3 lookCam;
    public Vector3 movevelocity;
    public Rigidbody rb;
    private Vector3 offset;
    public Camera camera;
    public GunController gun;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera = FindObjectOfType<Camera>();
        offset = camera.transform.position - this.transform.position;
    }
    void Update()
    {
        movement = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical"));
        movevelocity = movement * movespeed;
        lookCam = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal_2"), 0, CrossPlatformInputManager.GetAxis("Vertical_2"));
        transform.LookAt(transform.position + lookCam);
        
    }
    void FixedUpdate()
    {
        rb.velocity = movevelocity;
    }
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        camera.transform.position = this.transform.position + offset;
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
