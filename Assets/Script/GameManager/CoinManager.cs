using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour {
    public static int coinScore;
    Text text;
    //public int totalCoin;
	// Use this for initialization
   
 void Awake()
    {
        DontDestroyOnLoad(this);
        
    }
	void Start () {
        text = GetComponent<Text>();
        //coinScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(coinScore < 0)
        {
            coinScore = 0;
        }

        text.text = " = " + coinScore;
       // totalCoin += coinScore;
	}
    public static void addPoint(int coinAdd)
    {
        coinScore += coinAdd;
    }
}
