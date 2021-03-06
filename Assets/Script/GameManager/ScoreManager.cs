﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public static int score;
    Text text;
    public GameObject door;
    public int ScoreTotal;
    public GameObject bamBoo;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (score < 0)
        {
            score = 0;
        }
            text.text = " = " + score;
        spawnDoor();
        
    }
    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }
    public void spawnDoor()
    {
        if(score  == ScoreTotal)
        {
            bamBoo.SetActive(false);
            door.SetActive(true);
        }
    }

}
