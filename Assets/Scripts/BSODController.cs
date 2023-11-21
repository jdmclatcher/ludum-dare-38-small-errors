using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BSODController : MonoBehaviour {

    public GameObject check1;
    public GameObject check2;
    public GameObject check3;
    public GameObject check4;
    public GameObject check5;
    public GameObject check6;
    public GameObject check7;

    public string level1Completed;
    public string level2Completed;
    public string level3Completed;
    public string level4Completed;
    public string level5Completed;
    public string level6Completed;
    public string level7Completed;

    public AudioSource theBSODSound;
    public bool canPlaySound;

    public float secondsToWait;
    public float secondsToWaitToLeave;
    public GameObject victoryEffect;
    public AudioSource victorySound;
    public string victoryScene;

    private SelectorController theSelectorController;

	// Use this for initialization
	void Start () {
        theSelectorController = FindObjectOfType<SelectorController>();

        if (PlayerPrefs.GetInt("PlayedSound") == 0)
        {
            theBSODSound.Play();
            PlayerPrefs.SetInt("PlayedSound", 1);
        }
       
        if (PlayerPrefs.GetInt(level1Completed) == 1)
        {
            check1.SetActive(true);
        }
      

        if (PlayerPrefs.GetInt(level2Completed) == 1)
        {
            check2.SetActive(true);
        }
    

        if (PlayerPrefs.GetInt(level3Completed) == 1)
        {
            check3.SetActive(true);
        }
   

        if (PlayerPrefs.GetInt(level4Completed) == 1)
        {
            check4.SetActive(true);
        }
    

        if (PlayerPrefs.GetInt(level5Completed) == 1)
        {
            check5.SetActive(true);
        }
       

        if (PlayerPrefs.GetInt(level6Completed) == 1)
        {
            check6.SetActive(true);
        }
        

        if (PlayerPrefs.GetInt(level7Completed) == 1)
        {
            check7.SetActive(true);
        }

        theSelectorController.canPress = true;

        if (PlayerPrefs.GetInt(level1Completed) == 1 && PlayerPrefs.GetInt(level2Completed) == 1 && PlayerPrefs.GetInt(level3Completed) == 1 && PlayerPrefs.GetInt(level4Completed) == 1 && PlayerPrefs.GetInt(level5Completed) == 1 && PlayerPrefs.GetInt(level6Completed) == 1 && PlayerPrefs.GetInt(level7Completed) == 1)
        {
            theSelectorController.canPress = false;
            Debug.Log("Congrats. You beat 'em all.");
            StartCoroutine("VictoryCo");
        }
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public IEnumerator VictoryCo()
    {
        
        yield return new WaitForSeconds(secondsToWait);

        victoryEffect.SetActive(true);
        victorySound.Play();

        yield return new WaitForSeconds(secondsToWaitToLeave);
        SceneManager.LoadScene(victoryScene);

    }
}
