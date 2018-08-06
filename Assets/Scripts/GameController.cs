using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public float objetivos;
    public GameObject player;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		if(objetivos == 7)
        {
            SceneManager.LoadScene(0);
        }
        if (player.GetComponent<PlayerData>().life == 0)
        {
            SceneManager.LoadScene(0);
            
        }
	}
}
