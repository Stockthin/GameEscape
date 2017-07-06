using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {
   
    Text text;
    int _Score = 0;
    //const string SCORE_TEXT = "= ";
    // Use this for initialization
    void Start () {
        if (Door.instance != null)
        {
            Door.instance.CollectableCount++;
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            Destroy(gameObject);
            _Score += 1;
            text.text += _Score;
            //_Score++;
            //Score.text = SCORE_TEXT + _Score;
            if (Door.instance != null)
            {
                Door.instance.Decrecollect();
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
