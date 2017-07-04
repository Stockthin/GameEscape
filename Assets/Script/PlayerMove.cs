using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float speed;

    public float maxX = 7;
    public float minX = -7;
    public float maxY = 4;
    public float minY = -4;

    public float maxVelocity;
    private Rigidbody2D myRB;
    private Animator amin;
    public bool moveLeft, moveRight, moveUp, moveDown;
	void Awake () {
        myRB = GetComponent<Rigidbody2D>();
        amin = GetComponent<Animator>();
	}
    public void setMoveLeft(bool moveLeft)
    {
        this.moveLeft = moveLeft;
    }
    public void setMoveRight(bool moveRight)
    {
        this.moveRight = moveRight;
    }
    public void setMoveUp(bool moveUp)
    {
        this.moveUp = moveUp;
    }
    public void setMoveDown(bool moveDown)
    {
        this.moveDown = moveDown;
    }
    public void stopMove()
    {
        this.moveLeft = false;
        this.moveRight = false;
        this.moveUp = false;
        this.moveDown = false;
    }

    // Update is called once per frame
    void Update () {
        playerWalkJoystick();
       // walk();
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
        //playerWalk();
	}
    void playerWalkJoystick()
    {
        if (moveLeft)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
            Vector3 scale = transform.localScale;
            scale.x = (float)-0.4;
            transform.localScale = scale;
        }
        else if (moveRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
            Vector3 scale = transform.localScale;
            scale.x = (float)0.4;
            transform.localScale = scale;
        }
        else if (moveUp)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
        }
        else if (moveDown)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
        }
        else
        {
            amin.SetBool("Walking", false);
        }
    }
    void walk()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
            Vector3 scale = transform.localScale;
            scale.x = (float)-0.4;
            transform.localScale = scale;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
            Vector3 scale = transform.localScale;
            scale.x = (float)0.4;
            transform.localScale = scale;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            amin.SetBool("Walking", true);
        }
        else
        {
            amin.SetBool("Walking", false);
        }
    }
    /*void playerWalk()
    {
        float forceX = 0f;
        float forceY = 0f;
        float vel = Mathf.Abs(myRB.velocity.x);
        float h = Input.GetAxisRaw("Horizontal");
        if(h >0)
        {
            if(vel < maxVelocity)
            {
                forceX = MoveForce;
            }
            Vector3 scale = transform.localScale;
            scale.x =(float) 0.55;
            transform.localScale = scale;
            amin.SetBool("Walking", true);
        }
        else if(h <0) 

        {
            if(vel < maxVelocity)
            {
                forceX = -MoveForce;
            }
            Vector3 scale = transform.localScale;
            scale.x = (float)-0.55;
            transform.localScale = scale;
            amin.SetBool("Walking", true);
            
        }
        else
        {
            amin.SetBool("Walking", false);
        }
        myRB.AddForce(new Vector2(forceX, forceY));
    }*/
}
