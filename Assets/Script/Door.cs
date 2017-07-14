 using System.Collections;
using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject nextLevel;
    Animator myAmin;
    public GameObject pause;
   
  
 
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            pause.SetActive(false);
            Time.timeScale = 0;
            nextLevel.SetActive(true);
        }
    }
}
