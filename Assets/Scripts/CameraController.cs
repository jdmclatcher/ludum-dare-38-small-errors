using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer;

    public bool isFollowing;

    public float xOffset;
    public float yOffset;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();

        isFollowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
            transform.position = new Vector3(thePlayer.transform.position.x + xOffset, thePlayer.transform.position.y + yOffset, transform.position.z);
    }
}
