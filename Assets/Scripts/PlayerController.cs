using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerController : MonoBehaviour {
    public float speed;
    public float moveHorizontal;
    public float moveVertical;
    public Rigidbody rb;
    private Vector3 offset;
    public GameObject camera;
    void Start()
    {
        offset = camera.transform.position - this.transform.position;
    }

    void FixedUpdate()
    {
        moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        moveVertical = CrossPlatformInputManager.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //transform.Translate()
        rb.AddForce(movement * speed);
    }
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        camera.transform.position = this.transform.position + offset;
    }
}
