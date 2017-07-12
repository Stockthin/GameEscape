using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dameEnemy : MonoBehaviour {
    public GameObject Explo;
    public float dameToEnemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Grounds"))
        {
            Instantiate(Explo, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.tag == "Enemy")
            {
                  enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
                hurtEnemy.addDame(dameToEnemy);

            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Grounds"))
        {
           
            Instantiate(Explo, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.tag == "Enemy")
            {
                enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
                hurtEnemy.addDame(dameToEnemy);

            }
        }

    }
}
