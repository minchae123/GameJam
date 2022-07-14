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
    Timer timer;
    public RuntimeAnimatorController[] change;
    private RuntimeAnimatorController currentAnimationController;
    public ObstacleSpawn obstacleSpawn;
    public VeSpawn veSpawn;
    //bool isChange = false;
    bool isClear = false;
    bool isFail = false;

    private void Start()
    {
        veSpawn = GameObject.Find("Manager").GetComponent<VeSpawn>();
        timer = GameObject.Find("Manager").GetComponent<Timer>();
        obstacleSpawn = GameObject.Find("Manager").GetComponent<ObstacleSpawn>();
        heightt = GameObject.Find("Manager").GetComponent<Height>();
        rigid = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        if (heightt.height <= 44f)
        {
            EndMotion();
            isClear = true;
        }
        if(timer.gameTime > 180)
        {
            EndMotion();
            isFail = true;
        }
        if(transform.position.x > 11 && isClear == true)
        {
            SceneManager.LoadScene(4);
            /*if(timer.gameTime <= 110)
            {
                SceneManager.LoadScene(7);
            }
            if(timer.gameTime >=111 && timer.gameTime <= 140)
            {
                SceneManager.LoadScene(8);
            }
            if(timer.gameTime >= 141 && timer.gameTime <= 180)
            {
                SceneManager.LoadScene(6);
            }*/
        }


        if(transform.position.x > 11 && isFail == true)
        {
            SceneManager.LoadScene(5);
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

    public void EndMotion()
    {
        transform.position += Vector3.right * 5f * Time.deltaTime;
        obstacleSpawn.enabled = false;
        veSpawn.enabled = false;
        heightt.lose = 0;
        timer.lose = 0;
        foreach (GameObject cake in GameObject.FindGameObjectsWithTag("Cake"))
        {
            Destroy(cake);
        }
        foreach (GameObject vet in GameObject.FindGameObjectsWithTag("Vegetable"))
        {
            Destroy(vet);
        }
        foreach (GameObject yum in GameObject.FindGameObjectsWithTag("Yummy"))
        {
            Destroy(yum);
        }
        foreach (GameObject sli in GameObject.FindGameObjectsWithTag("Clickslider"))
        {
            Destroy(sli);
        }
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
