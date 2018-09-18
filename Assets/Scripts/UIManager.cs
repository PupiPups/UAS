using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
    public Image lifeBar;
    public PlayerData playerData;
    public GameObject player;
    public GameObject life;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifeBar.fillAmount = 0.01f * playerData.life;
        var target = new Vector3(player.transform.position.x, player.transform.position.y + 1f, player.transform.position.z);
        life.transform.position = Camera.main.WorldToScreenPoint(target);
    }
    public void backMenu()
    {
        SceneManager.LoadScene(0);

    }
}
