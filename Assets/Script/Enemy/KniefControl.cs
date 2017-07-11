using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KniefControl : MonoBehaviour {
    public float speed = 1f;
    Rigidbody2D kRB;
    BoxCollider2D myBox;
    void Awake()
    {
        kRB = GetComponent<Rigidbody2D>();
        myBox = GetComponent<BoxCollider2D>();
    }
	// Use this for initialization
	void Start () {
        kRB.AddForce(new Vector2(-3, 0) * speed);
	}
	void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Saw")
        {
            myBox.isTrigger = true;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
