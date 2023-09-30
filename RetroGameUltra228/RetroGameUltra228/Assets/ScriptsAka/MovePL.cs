using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePL : Sounds
{
    public float speed;
    public Rigidbody2D rb;
    public float jump;
    public float maxJump;
    SpriteRenderer sr;
    private Animator anim;
    public bool onGround;
    public Transform GroundCHECK;
    public float checkRadius = 0.8f;
    public LayerMask Ground;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump += 3;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            jump -= 3;
        }
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;
        if (movement < 0)
        {
            sr.flipX = true;
            anim.SetFloat("movement", Mathf.Abs(movement));
        }
        if (movement > 0)
        {
            sr.flipX = false; 
            anim.SetFloat("movement", Mathf.Abs(movement));
        }

        Jump();
        CheckingGround();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < maxJump && onGround)
        {
            PlaySounds(sounds[Random.Range(0, 2)]);
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }

    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCHECK.position, checkRadius, Ground);
        if(onGround == false)
        {
            anim.SetBool("onGround", true);
        }
        else
        {
            anim.SetBool("onGround", false);
        }
    }

}
    
