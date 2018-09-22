using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerController : MonoBehaviour {
    public string name;
    public float movespeed;
    public Vector2 movement;
    public Vector3 lookCam;
    public Vector2 movevelocity;
    public Rigidbody2D rb;
    private Vector3 offset;
    public Camera camera;
    public GunController gun;
<<<<<<< HEAD
=======
    public Transform gunLook;
>>>>>>> 91bdb9e36232b90354d87204dad4ff56cbbdebd9

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camera = FindObjectOfType<Camera>();
        offset = camera.transform.position - this.transform.position;
    }
    void Update()
    {
        movement = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"));
        movevelocity = movement * movespeed;
<<<<<<< HEAD
        lookCam = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal_2"), CrossPlatformInputManager.GetAxis("Vertical_2"),0);
        transform.LookAt(transform.position + lookCam);
        if (CrossPlatformInputManager.GetAxis("Horizontal") <= 0)
        {

        } else if (CrossPlatformInputManager.GetAxis("Horizontal") >= 0)
        {

        }
=======
        lookCam = new Vector3(0f,0f, CrossPlatformInputManager.GetAxis("Horizontal_2"));
        gunLook.LookAt(gun.transform.position + lookCam);
        
>>>>>>> 91bdb9e36232b90354d87204dad4ff56cbbdebd9
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
