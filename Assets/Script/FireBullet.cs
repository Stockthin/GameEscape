using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FireBullet : MonoBehaviour {
    public Transform Tip;
   public float MinFireTime = 2
        ;
    public float maxFireTime = 4;
    private GameObject samurai;
   // public float lastBomTime = 0;
   // public float BoomTime = 0;
    

    void Start () {
        samurai = GameObject.FindGameObjectWithTag("Player");

        InvokeRepeating("Fire",(Random.Range(MinFireTime,maxFireTime)), (Random.Range(MinFireTime, maxFireTime)));
       // upDateBom();
    }
   /* void Update()
    {
        if (Time.time >= lastBomTime + BoomTime)
        {
            Fire();
        }
    }*/
    /*void upDateBom()
    {
        lastBomTime = Time.time;
        BoomTime = Random.Range(MinFireTime, maxFireTime );
    }*/
    void Fire()
    {
        //upDateBom();
        GameObject obj = ScrollingObject.current.GetPoolerGameObject();
        if(obj == null)
        {
            return;
        }
       
                obj.transform.position = transform.position ;
                //obj.transform.rotation = Tip.rotation;
        GameObject bom = obj as GameObject;
        bom.GetComponent<SawController>().target = samurai.transform.position;
                obj.SetActive(true);
             
        
        
    }
	
	
}
