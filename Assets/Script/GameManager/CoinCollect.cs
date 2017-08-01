using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {
    public int coinAmount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Player")
        {
            CoinManager.addPoint(coinAmount);
            Destroy(gameObject);
        }
    }
}
