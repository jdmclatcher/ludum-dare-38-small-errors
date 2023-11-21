using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPController : MonoBehaviour {

    public PlayerController thePlayer;

    public Transform tpPoint;

    public AudioSource theTPSound;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            theTPSound.Play();
            thePlayer.transform.position = tpPoint.position;

        }
    }
}
