using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float visionradius;
    Vector3 initialPosition;
    private Rigidbody rb;
    public float movespeed = 7;
    public PlayerController player;
    public float life;
    public GameObject gameController;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<PlayerController>();
        gameController = GameObject.FindGameObjectWithTag("GameController");
        initialPosition = transform.position;
    }
    private void Update()
    {
        Vector3 target = initialPosition;
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionradius)
        {
            
            transform.LookAt(player.transform.position);
            rb.velocity = (transform.forward * movespeed);
        }
        else
        {
            transform.LookAt(target);
            rb.velocity = (transform.forward * movespeed);
        }
        if(life == 0){
            Destroy(gameObject);
            gameController.GetComponent<GameController>().objetivos++;
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, visionradius);
    }

}
