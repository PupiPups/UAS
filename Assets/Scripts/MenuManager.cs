using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour {
    public GameObject configuration;
    public Tween tween;
    public bool configurationAnimation = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AnimationConfiguration()
    {
        if (configurationAnimation == true)
        {
            tween = configuration.transform.DOMoveX(100f, 1.5f);
            configurationAnimation = false;
        }else
        {
            tween = configuration.transform.DOMoveX(36f, 1.5f);
            configurationAnimation = true;
        }
        
    }
  
}
