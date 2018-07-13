using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScrips : MonoBehaviour {
    public RectTransform grupo1;
    public RectTransform grupo2;
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
}
