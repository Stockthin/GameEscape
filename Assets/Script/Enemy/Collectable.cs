using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {
    private int count;
    public GameObject Door;
    public int total = 10;
   
    void Start () {
        count = 0;
        /*if (Door.instance != null)
        {
            Door.instance.CollectableCount++;
        }*/
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            ScoreManager.AddPoints(1);
            
            Destroy(gameObject);
            count += 1;

            
           /* if (Door.instance != null)
            {
                Door.instance.Decrecollect();
            }*/
        }
    }
    void spawnDoor()
    {
        if(count == total)
        {
            Door.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
        spawnDoor();
	}
}
