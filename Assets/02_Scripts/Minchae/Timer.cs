using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float gameTime = 0;
    public Text timeTxt;
    public float lose = 1f;
    //Height heightt;
    private void Start()
    {
      //  heightt = GameObject.Find("Manager").GetComponent<Height>();
    }

    private void Update()
    {
        gameTime += Time.deltaTime * lose;
        PlayerPrefs.SetFloat("asdf", gameTime);
        timeTxt.text = " " + gameTime.ToString("F2"); 

        if(gameTime > 180)
        {
            SceneManager.LoadScene(5);
            Debug.Log("게임 종료");
        }
    }


}
