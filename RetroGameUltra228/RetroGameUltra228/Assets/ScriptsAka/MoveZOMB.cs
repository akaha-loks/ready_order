using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZOMB : MonoBehaviour
{
    public float speed;
    public Transform[] points;
    public int lol;
    private Animator anim;
    public SpriteRenderer sr;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[lol].position, speed * Time.deltaTime);
        anim.SetBool("move", true);
        if(Vector2.Distance(transform.position, points[lol].position) < 0.2f)
        {
           if(lol > 0)
            {
                lol = 0;
                sr.flipX = false;
            }
            else
            {
                lol = 1;
                sr.flipX = true;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Kill")
        {
            Destroy(gameObject);
        }

    }
}
