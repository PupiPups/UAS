using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_sound : MonoBehaviour {
    public AudioSource[] musica;
	// Use this for initialization
	void Start () {
        musica = FindObjectsOfType<AudioSource>();
	}
	
	// Update is called once per frame
	public void silenciar () {
		    foreach(AudioSource s in musica)
        {
            s.Stop();

        }
	}
}
