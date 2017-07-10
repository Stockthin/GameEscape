using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KniefControl : MonoBehaviour {
    public float speed = 1f;
    Rigidbody2D kRB;
    void Awake()
    {
        kRB = GetComponent<Rigidbody2D>();
    }
	// Use this for initialization
	void Start () {
        kRB.AddForce(new Vector2(-3, 0) * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
