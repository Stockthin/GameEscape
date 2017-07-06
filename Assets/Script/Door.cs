 using System.Collections;
using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour {

    public static Door instance;
    Animator myAmin;
    private BoxCollider2D box;
    public int CollectableCount;
    void Awake()
    {
        myAmin = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }
    void makeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }   
    public void Decrecollect()
    {
        CollectableCount++;
        if(CollectableCount == 10)
        {
            StartCoroutine(OpenDoor());
        }
    }
    IEnumerator OpenDoor()
    {
        myAmin.Play("door");
        yield return new WaitForSeconds(0.7f);
        box.isTrigger = true;
        
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            GameObject.Find("GameController").GetComponent<GamePlayController>().NEXTLEVEL();
        }
    }
}
