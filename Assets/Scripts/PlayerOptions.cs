using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOptions : MonoBehaviour {
    public int clase;
	// Use this for initialization
	void Start () {
        clase = PlayerPrefs.GetInt("PlayerClass");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void basico()
    {
        switch (clase)
        {

            case 1:  //perro
                //codigo de ataque basico
                break;
            case 2: //gato
                    //codigo de ataque basico
                break;
            case 3: //panda
                    //codigo de ataque basico
                break;
            case 4: //cabra
                //codigo de ataque basico
                break;
        }

    }

    public void poder1()
    {
        switch (clase)
        {

            case 1:  //perro
                //codigo de poder 1
                break;
            case 2: //gato
                    //codigo de poder 1
                break;
            case 3: //panda
                    //codigo de poder 1
                break;
            case 4:
                //codigo de poder 1
                break;
        }

    }

    public void poder2()
    {
        switch (clase)
        {

            case 1:  //perro
                //codigo de poder 2
                break;
            case 2: //gato
                    //codigo de poder 2
                break;
            case 3: //panda
                    //codigo de poder 2
                break;
            case 4:
                //codigo de poder 2
                break;
        }

    }

    public void poder3()
    {
        switch (clase)
        {

            case 1:  //perro
                //codigo de poder 3
                break;
            case 2: //gato
                    //codigo de poder 3
                break;
            case 3: //panda
                    //codigo de poder 3
                break;
            case 4:
                //codigo de poder 3
                break;
        }

    }

}
