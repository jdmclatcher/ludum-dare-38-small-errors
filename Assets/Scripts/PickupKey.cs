using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupKey : MonoBehaviour {

    public string mainMenu;

    public bool readyToLeave;
    public float secondsToWait;

    //public string levelCompletedPref;

    public AudioSource thePickupSound;

	// Use this for initialization
	void Start () {
        readyToLeave = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(readyToLeave)
        {
            secondsToWait -= Time.deltaTime;
        }

        if (secondsToWait <= 0)
        {
            SceneManager.LoadScene(mainMenu);
        }
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //0 is false, 1 is true
            
            thePickupSound.Play();
            gameObject.SetActive(false);
        }
    }
}
