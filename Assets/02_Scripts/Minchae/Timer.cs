using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class Timer : MonoBehaviour
{
    public float gameTime = 0;
    public Text timeTxt;
    PlayerJump playerJump;
    public float lose = 1f;
    //Height heightt;
    private void Start()
    {
        playerJump = GameObject.Find("Player").GetComponent<PlayerJump>();
        //  heightt = GameObject.Find("Manager").GetComponent<Height>();
    }

    private void Update()
    {
        gameTime += Time.deltaTime * lose;
        PlayerPrefs.SetFloat("asdf", gameTime);
        timeTxt.text = " " + gameTime.ToString("F2"); 

       /* if(gameTime > 180)
        {
            playerJump.EndMotion();
            SceneManager.LoadScene(5);
            Debug.Log("���� ����");
        }*/
    }


}
