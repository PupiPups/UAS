using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject player;
    public GameObject torreta;
    public float speed;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        torreta = GameObject.FindGameObjectWithTag("Torreta");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerData>().life -= 10;
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Torreta")
        {
            torreta.GetComponent<TorretaController>().life -= 10;
            Destroy(gameObject);
        }
    }
}
