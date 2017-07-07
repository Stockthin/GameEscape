 using System.Collections;
using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject nextLevel;
    Animator myAmin;
   
  
 
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            Time.timeScale = 0;
            nextLevel.SetActive(true);
        }
    }
}
