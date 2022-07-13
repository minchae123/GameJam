using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float gameTime = 0f;
    public Text timeTxt;

    private void Update()
    {
        gameTime += Time.deltaTime;
        timeTxt.text = " " + gameTime.ToString("F2"); 

        if(gameTime >= 120)
        {
            Debug.Log("게임 종료");
            //SceneManager.LoadScene("GameOver");
        }
    }


}
