using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatusControl : MonoBehaviour {
    Rigidbody2D caTus;
    public float moveSppeed;
    public Vector3 target;
    public float minSpeed = 1;
    public float maxSpeed = 5;
    // Use this for initialization
    void Awake()
    {
        caTus = GetComponent<Rigidbody2D>();
        target.x = (Random.Range(-7, 7));
        target.y = (Random.Range(-2, 3));
        target.z = (0);
    }
	void Start () {
        caTus.AddForce(new Vector2(-3, Random.Range(-3, 3)) * moveSppeed);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
