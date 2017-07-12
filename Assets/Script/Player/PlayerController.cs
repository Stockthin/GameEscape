using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
	public float moveForce = 5;
	Rigidbody2D myBD;
	public GameObject bullet;
	public Transform shotFrom;
	public float shootTime;
	public int changeShoot;
	float nextShootTime;
    Animator playerAni;
	// Use this for initialization
	void Start ()
	{
		myBD = this.GetComponent<Rigidbody2D> ();
        playerAni = GetComponent<Animator>();
	}

	public void fire ()
	{
		if ( nextShootTime < Time.time) {
			nextShootTime = Time.time + shootTime;
            playerAni.SetTrigger("Attrack");

            GameObject shuriken = Instantiate (bullet, shotFrom.position, Quaternion.identity).gameObject;
            
			float shootForce = 5;

			if (transform.localScale.x > 0)
				shuriken.GetComponent<ShurikenControl> ().Shoot (new Vector2 (shootForce, 0));
			else
				shuriken.GetComponent<ShurikenControl> ().Shoot (new Vector2 (-shootForce, 0));
		}
	}

	// Update is called once per frame
	void Update ()
	{
		Vector2 movevec = new Vector2 (CrossPlatformInputManager.GetAxis ("Horizontal") * moveForce, CrossPlatformInputManager.GetAxisRaw ("Vertical") * moveForce);
       // playerAni.SetBool("Walking", true);
        transform.Translate (new Vector2 (movevec.x  , movevec.y ));
        if(movevec.x > 0)
        {
            playerAni.SetBool("Walking", true);
            Vector3 scale = transform.localScale;
            scale.x = (float)0.3;
            transform.localScale = scale;
        }
        else if (movevec.x < 0)
        {
            playerAni.SetBool("Walking", true);
            Vector3 scale = transform.localScale;
            scale.x = (float)-0.3;
            transform.localScale = scale;
        }
        else
        {
            playerAni.SetBool("Walking", false);
        }
		//fire ();

		//myBD.AddForce(movevec);
		/* Vector2 scale = transform.localScale;
             scale.x = (float)-0.4;
             transform.localScale = scale; */
	}
}
