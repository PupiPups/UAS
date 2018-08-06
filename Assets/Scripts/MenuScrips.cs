using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScrips : MonoBehaviour {
    public RectTransform grupo1;
    public RectTransform grupo2;
    public AudioSource sonido;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CambiarPosicion()
    {
        grupo1.GetComponent<RectTransform>().localPosition = Vector3.zero;

        grupo2.GetComponent<RectTransform>().localPosition = new Vector3(700f, 700f, 700f);

    }
    public void salir()
    {
        Application.Quit();
    }

    public void efecto()
    {
        sonido.Play();
    }

    public void singleplayer() {
        SceneManager.LoadScene(1);
    }
}
