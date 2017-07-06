using UnityEngine;
using System.Collections;

public class enemyDamage : MonoBehaviour {
    public float damage;
    public float dameRate;
    //public float pushBackForce;
    float NextDamage;
    public GameObject expl;
    // Use this for initialization
    void Start () {
        NextDamage = 0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag == "Player" && NextDamage < Time.time)
        {
            playerHealth thePlayerHealth = coll.gameObject.GetComponent<playerHealth>();
            thePlayerHealth.addDame(damage);
            NextDamage = Time.time + dameRate;
            Destroy(this.gameObject);
            Instantiate(expl, transform.position, Quaternion.identity);
            //pushBack(coll.transform);
            Debug.Log("dadsafsa");
        }
    }
  
    }
   /* void pushBack(Transform pushedObject)
    {
        Vector2 pushDirection = new Vector2(0, (pushedObject.position.y - transform.position.y)).normalized;
        pushDirection *= pushBackForce;
        Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRB.velocity = Vector2.zero;
        pushRB.AddForce(pushDirection, ForceMode2D.Impulse);
    }*/

