using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jump;
    int jumpCount;
    public GameObject player;
    Rigidbody2D rigid;
    Animator ani;
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount==0)
            {
                rigid.velocity = new Vector3(0, jump, 0);
                jumpCount++;
                ani.Play("DDongJump");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
            ani.Play("DDongRun");
        }
    }
}
