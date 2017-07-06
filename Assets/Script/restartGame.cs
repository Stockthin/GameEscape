using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour {
    public float restartTime;
    bool restartNow = false;
    float resetTime;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("begin");
        }
        if(restartNow && resetTime <= Time.time)
        {
            GameObject.Find("GameController").GetComponent<GamePlayController>().playerDIE();
            // SceneManager.LoadScene("begin");
        }
	
	}
    public void restartTheGame()
    {
        restartNow = true;
        resetTime = Time.time + restartTime;
       
    }
}
