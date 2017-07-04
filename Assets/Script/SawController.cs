using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour {
    public Vector3 target;
    public float moveSpeed = 5;
    public float minSpeed =1;
    public float maxSpeed =5;
    Rigidbody2D sawRB;

    

	
	void Awake () {
        sawRB = GetComponent<Rigidbody2D>();
        target.x = (Random.Range(-7, 7));
        target.y = (Random.Range(-2, 3));
        target.z = (0);
      //  sawRB.AddForce(new Vector2(target.x,target.y) * moveSpeed, ForceMode2D.Impulse);
    }
    void Start()
    {
        //transform.Translate((transform.position - target)  * Time.deltaTime * -1);
        //sawRB.position = (new Vector3(Random.Range(minSpeed,maxSpeed), Random.Range(minSpeed,maxSpeed),0) *Random.Range(minSpeed, maxSpeed));
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(( transform.position - target ) * Random.Range(minSpeed,maxSpeed) * Time.deltaTime * -1);

        //transform.position = Vector3.Lerp(transform.position, target.transform.position, moveSpeed);
        // transform.Translate(transform.position * moveSpeed * Time.deltaTime * -1);
        //transform.position = Vector3.forward;
       /* if (gameObject.tag == "Finish")
        {
            gameObject.SetActive(false);
            return;
        }*/

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Finish")
            gameObject.SetActive(false);

    }

}
