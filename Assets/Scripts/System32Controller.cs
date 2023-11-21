using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class System32Controller : MonoBehaviour {

    public string gameOverScene;

    public float secondsToWait;

	// Use this for initialization
	void Start () {
        //resets playerprefs
        PlayerPrefs.SetInt("level1Completed", 0);
        PlayerPrefs.SetInt("level2Completed", 0);
        PlayerPrefs.SetInt("level3Completed", 0);
        PlayerPrefs.SetInt("level4Completed", 0);
        PlayerPrefs.SetInt("level5Completed", 0);
        PlayerPrefs.SetInt("level6Completed", 0);
        PlayerPrefs.SetInt("level7Completed", 0);
        PlayerPrefs.SetInt("PlayedSound", 0);
    }
	
	// Update is called once per frame
	void Update () {
        secondsToWait -= Time.deltaTime;

        if(secondsToWait <= 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
	}
}
