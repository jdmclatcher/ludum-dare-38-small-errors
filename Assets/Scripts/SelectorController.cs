using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorController : MonoBehaviour {

    public Transform firstLine;
    public Transform secondLine;
    public Transform thirdLine;
    public Transform fourthLine;
    public Transform fifthLine;
    public Transform sixthLine;
    public Transform seventhLine;

    public string level1;
    public string level2;
    public string level3;
    public string level4;
    public string level5;
    public string level6;
    public string level7;

    public GameObject underscore1;
    public GameObject underscore2;
    public GameObject underscore3;
    public GameObject underscore4;
    public GameObject underscore5;
    public GameObject underscore6;
    public GameObject underscore7;

    public AudioSource theSelectSound;

    //private BSODController theBSOD;

    public bool canPress;

    // Use this for initialization
    void Start () {
        //theBSOD = FindObjectOfType<BSODController>();
        transform.position = firstLine.position;
	}
	
	// Update is called once per frame
	void Update () {
        //Navigating Down
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position == firstLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = secondLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position == secondLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = thirdLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position == thirdLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = fourthLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position == fourthLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = fifthLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position == fifthLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = sixthLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position == sixthLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = seventhLine.position;
        }

        //Navigating Up
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position == secondLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = firstLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position == thirdLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = secondLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position == fourthLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = thirdLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position == fifthLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = fourthLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position == sixthLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = fifthLine.position;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position == seventhLine.position && canPress)
        {
            theSelectSound.Play();
            transform.position = sixthLine.position;
        }





        //Loading Levels
        if (transform.position == firstLine.position)
        {
            underscore1.SetActive(true);
            underscore2.SetActive(false);
            underscore3.SetActive(false);
            underscore4.SetActive(false);
            underscore5.SetActive(false);
            underscore6.SetActive(false);
            underscore7.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Return) && canPress)
            {
                SceneManager.LoadScene(level1);
            }
        }

        if (transform.position == secondLine.position)
        {
            underscore1.SetActive(false);
            underscore2.SetActive(true);
            underscore3.SetActive(false);
            underscore4.SetActive(false);
            underscore5.SetActive(false);
            underscore6.SetActive(false);
            underscore7.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Return) && canPress)
            {
                SceneManager.LoadScene(level2);
            }
        }

        if (transform.position == thirdLine.position)
        {
            underscore1.SetActive(false);
            underscore2.SetActive(false);
            underscore3.SetActive(true);
            underscore4.SetActive(false);
            underscore5.SetActive(false);
            underscore6.SetActive(false);
            underscore7.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Return) && canPress)
            {
                SceneManager.LoadScene(level3);
            }
        }

        if (transform.position == fourthLine.position)
        {
            underscore1.SetActive(false);
            underscore2.SetActive(false);
            underscore3.SetActive(false);
            underscore4.SetActive(true);
            underscore5.SetActive(false);
            underscore6.SetActive(false);
            underscore7.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Return) && canPress)
            {
                SceneManager.LoadScene(level4);
            }
        }

        if (transform.position == fifthLine.position)
        {
            underscore1.SetActive(false);
            underscore2.SetActive(false);
            underscore3.SetActive(false);
            underscore4.SetActive(false);
            underscore5.SetActive(true);
            underscore6.SetActive(false);
            underscore7.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Return) && canPress)
            {
                SceneManager.LoadScene(level5);
            }
        }

        if (transform.position == sixthLine.position)
        {
            underscore1.SetActive(false);
            underscore2.SetActive(false);
            underscore3.SetActive(false);
            underscore4.SetActive(false);
            underscore5.SetActive(false);
            underscore6.SetActive(true);
            underscore7.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Return) && canPress)
            {
                SceneManager.LoadScene(level6);
            }
        }

        if (transform.position == seventhLine.position)
        {
            underscore1.SetActive(false);
            underscore2.SetActive(false);
            underscore3.SetActive(false);
            underscore4.SetActive(false);
            underscore5.SetActive(false);
            underscore6.SetActive(false);
            underscore7.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return) && canPress)
            {
                SceneManager.LoadScene(level7);
            }
        }

    }
}
