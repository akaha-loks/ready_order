using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZOMB : MonoBehaviour
{
    public Transform tr;
    public GameObject ZOMB;

    void Update()
    {
        Fall();
    }

    void Fall()
    {
        if (tr.position.y <= -10f)
        {
            Destroy(ZOMB);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(ZOMB);
        }
    }
}
