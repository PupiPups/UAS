using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public Text Tempo;
    public float tiempo = 0.0f;
    public Text p1;
    public Text p2;
    public Text p3;
    public Text p4;
    public float a;
    public int b;
    public int c;
    public int d;

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        Tempo.text = "Tiempo: " + tiempo.ToString();
        p1.text = a.ToString();
        p2.text = b.ToString();
        p3.text = c.ToString();
        p4.text = d.ToString();
        /*if (tiempo >= 0)
        {
            SceneManager.LoadScene(0);
        }*/
    }
}
