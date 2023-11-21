using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float moveSpeedStore;
    public float speedyMoveSpeed;
    public float jumpForce;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool isGrounded;

    private Rigidbody2D myRigidbody;

    public GameObject lifeParticleEffect;
    public GameObject pickupParticleEffect;

    public string levelCompletedPref;

    public string mainMenu;

    public bool readyToLeave;
    public float secondsToWait;

    public AudioSource theSpeedySound;

    public Transform playerStartPos;
    public GameObject playerDeathParticleEffect;


    // Use this for initialization
    void Start () {
        moveSpeed = moveSpeedStore;
        myRigidbody = GetComponent<Rigidbody2D>();

        Instantiate(lifeParticleEffect, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        

        //Grounded initialization
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        //Move Right
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidbody.velocity = new Vector3(moveSpeed, myRigidbody.velocity.y, 0f);
        }

        //Move Left
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myRigidbody.velocity = new Vector3(-moveSpeed, myRigidbody.velocity.y, 0f);
        }

        //Stop Input Check
        else
        {
            myRigidbody.velocity = new Vector3(0f, myRigidbody.velocity.y, 0f);
        }

        //JUMP!
        if ((Input.GetButtonDown("Jump") || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && isGrounded)
        {
            Jump();
        }

        if (readyToLeave)
        {
            secondsToWait -= Time.deltaTime;
        }

        if (secondsToWait <= 0)
        {
            SceneManager.LoadScene(mainMenu);
        }
    }

    public void Jump()
    {
        myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jumpForce, 0f);
    }

    public void TakeLife()
    {
        moveSpeed = moveSpeedStore;
        Instantiate(playerDeathParticleEffect, transform.position, transform.rotation);
        transform.position = playerStartPos.position;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Pickup")
        {
            Instantiate(pickupParticleEffect, transform.position, transform.rotation);
            PlayerPrefs.SetInt(levelCompletedPref, 1);
            readyToLeave = true;
            //gameObject.SetActive(false);
        }

        if(other.tag == "Speed")
        {
            if (theSpeedySound.isPlaying)
            {
                //Debug.Log("Already Playing.");
            }
            else
            {
                theSpeedySound.Play();
            }

            moveSpeed = speedyMoveSpeed;

        }

        if (other.tag == "unSpeed")
        {
            if (theSpeedySound.isPlaying)
            {
                //Debug.Log("Already Playing.");
            }
            else
            {
                theSpeedySound.Play();
            }

            moveSpeed = moveSpeedStore;
        }
    }
}
