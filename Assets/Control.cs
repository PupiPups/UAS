using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour {
    private Image[] im;
    public Text titulo;
    // Use this for initialization
    void Start () {
        im = FindObjectsOfType<Image>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectClass(int a){
        
        switch (a){
            
            case 1:  //perro
                PlayerPrefs.SetInt("PlayerClass", 1);
                break;
            case 2: //gato
                PlayerPrefs.SetInt("PlayerClass", 2);
                break;
            case 3: //panda
                PlayerPrefs.SetInt("PlayerClass", 3);
                break;
            case 4:
                PlayerPrefs.SetInt("PlayerClass", 4);
                break;
        }
        foreach (Image s in im){
            s.gameObject.SetActive(false);
        }
        titulo.gameObject.SetActive(false);
    }
}
