using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour {
    public Vector3 target;
    public float moveSpeed = 5;

	
	void Start () {
       
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((transform.position - target) * moveSpeed * Time.deltaTime * -1);
       // transform.position = Vector3.Lerp(transform.position, target.transform.position, moveSpeed);


    }
}
