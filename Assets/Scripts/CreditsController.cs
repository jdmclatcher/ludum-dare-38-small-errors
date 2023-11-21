using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsController : MonoBehaviour {

    public float timeTilKill;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeTilKill -= Time.deltaTime;

        if(timeTilKill <= 0)
        {
            QuitIt();
        }
	}

    public void QuitIt()
    {
        Debug.Log("Ended");
        Application.Quit();
    }
}
