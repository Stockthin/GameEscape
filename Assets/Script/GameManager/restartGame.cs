using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour {
    public float restartTime;
    bool restartNow = false;
    float resetTime;
    //public GameObject endgame;


	void Start () {
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {
      
        if (restartNow && resetTime <= Time.time)
        {
            GameObject.Find("GameController").GetComponent<AudioManager>().stopAudio();
            GameObject.Find("GameController").GetComponent<GamePlayController>().playerDIE();
            //Time.timeScale = 1;
            //return;
           // endgame.SetActive(true);
            
        }


    }
    public void restartTheGame()
    {
        restartNow = true;
        resetTime = Time.time + restartTime;
       
    }
}
