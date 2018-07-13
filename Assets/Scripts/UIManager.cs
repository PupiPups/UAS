using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    public Image lifeBar;
    public PlayerData playerData;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifeBar.fillAmount = 0.01f * playerData.life;
	}
    public void backMenu()
    {
        SceneManager.LoadScene(0);

    }
}
