using UnityEngine;
using System.Collections;

public class enemyMovementController : MonoBehaviour {
    public float enemySpeed;
    Animator enemyAnimator;
    public GameObject enemyGraphic;
    bool canFlip = true;
    bool facingRight = false;
    float flipTime = 5f;
    float nextFlipChange = 0f;
    public float chargeTime;
    float startChargeTime;
    bool charging;
    Rigidbody2D enemyRB;
    public Transform shootFrom;
    public GameObject bullet;
    public GameObject bullet2;
    
    public float shootTime;
    public int changeShoot;
    float nextShootTime;
    public GameObject knief;

    // Use this for initialization
    void Start()
    {
        if (gameObject != null)
        {
            enemyAnimator = GetComponentInChildren<Animator>();
            enemyRB = GetComponent<Rigidbody2D>();
            nextShootTime = 0f;

        }
    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time > nextFlipChange)
        {
            if(Random.Range (0,10)>=5) flipFacing();
            nextFlipChange = Time.time + flipTime;
        }
        //enemyAnimator.SetBool("Attrack", false);

    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if (enemyRB.gameObject != null)
        {
            if (other.tag == "Player")
            {
                if (facingRight && other.transform.position.x < transform.position.x)
                {
                    flipFacing();
                }
                else if (!facingRight && other.transform.position.x > transform.position.x)
                {
                    flipFacing();
                }
                canFlip = false;
                charging = true;
                //enemyAnimator.SetBool("Atrack", true);
                startChargeTime = Time.time + chargeTime;
            }
        }

        
    }
    void OnTriggerStay2D(Collider2D other)
    {
       
            if (other.tag == "Player" && nextShootTime < Time.time)
            {
            if (gameObject != null)
            {
                nextShootTime = Time.time + shootTime;
                enemyAnimator.SetBool("Atrack", true);
            
                Instantiate(bullet, shootFrom.position, shootFrom.rotation);
                knief.SetActive(false);
                /* if (!facingRight) ; //enemyRB.AddForce(new Vector2(-1, 0) * enemySpeed);
                 else enemyRB.AddForce(new Vector2(1, 0) * enemySpeed);*/
            }

            
        }
 
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (enemyRB.gameObject != null)
        {
            if (other.tag == "Player")
            {
                canFlip = true;
                charging = false;
                enemyRB.velocity = new Vector2(0f, 0f);
                knief.SetActive(true);
                enemyAnimator.SetBool("Atrack", false);
                
            }
        }
    }
    void flipFacing()
    {
        if (enemyRB.gameObject != null)
        {
            if (!canFlip) return;
            float facingX = enemyGraphic.transform.localScale.x;
            facingX *= -1f;
            enemyGraphic.transform.localScale = new Vector3(facingX, enemyGraphic.transform.localScale.y, enemyGraphic.transform.localScale.z);
            facingRight = !facingRight;
        }
    }
}
