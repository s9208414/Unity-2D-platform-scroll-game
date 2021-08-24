using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    Rigidbody2D rb;
    Transform tf;
    public GameObject potato1;
    
    public bool canMove;
    public bool isAnswer;
    
    public float speed;
    public float jumpForce;
    bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float rememberGroundedFor;
    public int facing = 1;
    float lastTimeGrounded;
    public int score;
    public bool canAdd;
    public int temp;
    public GameObject hint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
        canMove = true;
        isAnswer = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        BetterJump();
        CheckIfGrounded();
        Direction();
 
        getLarge();
    }
    void Move()
    {
        if (canMove == true)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float moveBy = x * speed;
            rb.velocity = new Vector2(moveBy, rb.velocity.y);
            if ((facing == 1) && (Input.GetKey(KeyCode.RightArrow)))
            {
                hint.transform.Rotate(Vector3.forward * 0);
                transform.Rotate(Vector3.forward * -5f);
            }
            else if (facing == -1 && (Input.GetKey(KeyCode.LeftArrow)))
            {
                hint.transform.Rotate(Vector3.forward * 0);
                transform.Rotate(Vector3.forward * 5f);
            }
        }
    }
    void Direction()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            facing = 1;

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            GetComponent<SpriteRenderer>().flipX = true;
            facing = -1;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && (isGrounded || Time.time - lastTimeGrounded <= rememberGroundedFor))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    
    void CheckIfGrounded()
    {
        Collider2D colliders = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        if (colliders != null)
        {
            isGrounded = true;
        }
        else
        {
            if (isGrounded)
            {
                lastTimeGrounded = Time.time;
            }
            isGrounded = false;
        }
    }


    
    
    void BetterJump()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
    
    
    public void large()
    {
        
        if (score < 0)
        {
            transform.localScale = new Vector2(0.09f, 0.09f);
            this.checkGroundRadius = 0.3f;
        }
        else if (score == 0)
        {
            transform.localScale = new Vector2(0.12f, 0.12f);
            this.checkGroundRadius = 0.5f;
        }
        else if (score > 0 && score <= 25)
        {
            transform.localScale = new Vector2(0.15f, 0.15f);
            this.checkGroundRadius = 0.7f;
        }
        else if (score > 25 && score <= 50)
        {
            transform.localScale = new Vector2(0.18f, 0.18f);
            this.checkGroundRadius = 0.9f;
        }
        else if (score > 50 && score <= 75)
        {
            transform.localScale = new Vector2(0.21f, 0.21f);
            this.checkGroundRadius = 1.1f;
        }
        else if (score > 75 && score <= 100)
        {
            transform.localScale = new Vector2(0.24f, 0.24f);
            this.checkGroundRadius = 1.3f;
        }
    }
    public void getLarge()
    {
        if (this.score != this.temp)
        {
            large();
            this.temp = this.score;
        }
    }
    
}
