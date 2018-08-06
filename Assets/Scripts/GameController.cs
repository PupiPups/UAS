using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public float objetivos;
    public GameObject win;
    public GameObject player;
    public GameObject lose;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		if(objetivos == 6)
        {
            win.SetActive(true);
            objetivos -= Time.deltaTime;
            if (objetivos == 0)
            {
                SceneManager.LoadScene(0);
            }
        }
        if (player.GetComponent<PlayerData>().life == 0)
        {
            lose.SetActive(true);
            float a = 3;
            a -= Time.deltaTime;
            if (a == 0)
            {
                SceneManager.LoadScene(0);
            }
        }
	}
}
