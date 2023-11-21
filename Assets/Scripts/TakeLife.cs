using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLife : MonoBehaviour {

    public PlayerController thePlayer;

    public AudioSource theDeathSound;

    // Use this for initialization
    void Start() {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            theDeathSound.Play();
            thePlayer.TakeLife();
        }
    }


}
