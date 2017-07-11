using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenControl : MonoBehaviour
{
	public float shurikenSpeed;
	Rigidbody2D myRB;

  
	void Awake ()
	{
		myRB = GetComponent<Rigidbody2D> ();
		//myRB.AddForce(transform.forward * shurikenSpeed);
//		if (transform.localRotation.z > 0)
//			myRB.AddForce (new Vector2 (-1, 0) * shurikenSpeed, ForceMode2D.Impulse);
//		else
//			myRB.AddForce (new Vector2 (1, 0) * shurikenSpeed, ForceMode2D.Impulse);
        

	}

	public void Shoot (Vector2 force)
	{
		myRB.AddForce (force, ForceMode2D.Impulse);
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.Translate(Vector3.forward * Time.deltaTime * shurikenSpeed);
		//myRB.AddForce (transform.forward * shurikenSpeed);
	}
  
}
