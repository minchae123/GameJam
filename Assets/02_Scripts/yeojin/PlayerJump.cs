using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jump;
    //public float jump2;
    int jumpCount;
    public GameObject player;
    Rigidbody2D rigid;
    Animator ani;
    Height heightt;
    public RuntimeAnimatorController[] change;

    private void Start()
    {
        
        heightt = GameObject.Find("Manager").GetComponent<Height>();
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
                if(heightt.height > 60)
                {
                    ani.runtimeAnimatorController = change[0];
                }
                if (heightt.height <= 60)
                {
                    ani.runtimeAnimatorController = change[1];
                }

                if (heightt.height <= 50)
                {
                    ani.runtimeAnimatorController = change[2];
                }
                ani.Play("Jump");
            }

            /*else if(jumpCount==1)
            {
                rigid.velocity = new Vector3(0, jump2, 0);
                jumpCount++;
                ani.Play("DDongJump");
            }*/
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
            if (heightt.height > 60)
            {
                ani.runtimeAnimatorController = change[0];
            }
            if (heightt.height <= 60)
            {
                ani.runtimeAnimatorController = change[1];
            }

            if (heightt.height <= 50)
            {
                ani.runtimeAnimatorController = change[2];
            }
            ani.Play("Run");
        }
    }
}
