using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour {

    public string levelToLoad;

    public float secondsToWait;

    public GameObject theBG;
    public GameObject theLoadingSider;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("level1Completed", 0);
        PlayerPrefs.SetInt("level2Completed", 0);
        PlayerPrefs.SetInt("level3Completed", 0);
        PlayerPrefs.SetInt("level4Completed", 0);
        PlayerPrefs.SetInt("level5Completed", 0);
        PlayerPrefs.SetInt("level6Completed", 0);
        PlayerPrefs.SetInt("level7Completed", 0);
        PlayerPrefs.SetInt("PlayedSound", 0);
        Time.timeScale = 1f;
	}

    public void EndSplashScreem()
    {
        SceneManager.LoadScene(levelToLoad);
    }

	// Update is called once per frame
	void Update () {
        if (theBG.activeInHierarchy)
        {
            theLoadingSider.SetActive(false);

        }
        else
        {
            theLoadingSider.SetActive(true);
        }

        secondsToWait -= Time.deltaTime;

        if(secondsToWait <= 0)
        {
            EndSplashScreem();
        }
	}
}
