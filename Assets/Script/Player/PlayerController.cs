using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {
    public float moveForce = 5;
    Rigidbody2D myBD;
    public GameObject bullet;
    public Transform shotFrom;
    public float shootTime;
    public int changeShoot;
    float nextShootTime;
    // Use this for initialization
    void Start () {
        myBD = this.GetComponent<Rigidbody2D>();

    }
    void fire()
    {
        if (Input.GetKey(KeyCode.Space) && nextShootTime < Time.time)
        {
            nextShootTime = Time.time + shootTime;
            
            Instantiate(bullet, shotFrom.position,Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update () {
        Vector2 movevec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal") ,CrossPlatformInputManager.GetAxisRaw("Vertical") * moveForce);

        transform.Translate(new Vector2(0, movevec.y * Time.deltaTime));
        fire();

        //myBD.AddForce(movevec);
        /* Vector2 scale = transform.localScale;
             scale.x = (float)-0.4;
             transform.localScale = scale; */
    }
}
