using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryController : MonoBehaviour {

    public GameObject theDots;
    public GameObject theText;

    public GameObject imageOfJustice;
    public float waitForImage;

    public string credits;

	// Use this for initialization
	void Start () {
        imageOfJustice.SetActive(false);
        theText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(!theDots.activeInHierarchy)
        {
            theText.SetActive(true);
        }

        waitForImage -= Time.deltaTime;

        if (waitForImage <= 0)
        {            
            imageOfJustice.SetActive(true);
            SceneManager.LoadScene(credits);
        }

        
	}

   
}
