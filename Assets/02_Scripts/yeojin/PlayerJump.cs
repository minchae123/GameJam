using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    public Text changeTxt;
    public float jump;
    //public float jump2;
    int jumpCount;
    public GameObject player;
    Rigidbody2D rigid;
    Animator ani;
    Height heightt;
    public RuntimeAnimatorController[] change;
    private RuntimeAnimatorController currentAnimationController;
    //bool isChange = false;

    private void Start()
    {
        heightt = GameObject.Find("Manager").GetComponent<Height>();
        rigid = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        if(heightt.height <= 44f)
        {
            transform.position += Vector3.right * 5f * Time.deltaTime;
        }
        if(transform.position.x > 11)
        {
            Debug.Log("¿¹»Û ¿£µù");
            //SceneManager.LoadScene();
        }

        ChangeAni();
        if(currentAnimationController != ani.runtimeAnimatorController)
        {
            StartCoroutine(Size());
            ani.runtimeAnimatorController = currentAnimationController;    
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount==0)
            {
                rigid.velocity = new Vector3(0, jump, 0);
                jumpCount++;
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

    private void ChangeAni()
    {
        if (heightt.height > 60)
        {
            //ani.runtimeAnimatorController = change[0];
            currentAnimationController = change[0];
        }
        if (heightt.height <= 60)
        {
            //ani.runtimeAnimatorController = change[1];
            currentAnimationController = change[1];
        }
        if (heightt.height <= 50)
        {
            //ani.runtimeAnimatorController = change[2];
            currentAnimationController = change[2];
        }
    }

    IEnumerator Size()
    {
        changeTxt.gameObject.SetActive(true);
        changeTxt.DOColor(Color.red, 1f);
        yield return new WaitForSeconds(0.3f);
        changeTxt.DOColor(Color.white, 1f);
        yield return new WaitForSeconds(0.3f);
        changeTxt.DOColor(Color.red, 1f);
        changeTxt.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;

            ani.Play("Run");
        }
    }
}
