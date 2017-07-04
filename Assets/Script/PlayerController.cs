using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControllesr : MonoBehaviour {
    public float moveForce = 5;
    Rigidbody2D myBD;
	// Use this for initialization
	void Start () {
        myBD = this.GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 movevec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal") ,CrossPlatformInputManager.GetAxis("Vertical") * moveForce);
        myBD.AddForce(movevec);
       /* Vector2 scale = transform.localScale;
            scale.x = (float)-0.4;
            transform.localScale = scale; */
    }
}
