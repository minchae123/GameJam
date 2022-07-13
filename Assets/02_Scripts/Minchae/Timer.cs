using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float gameTime = 0f;
    public Text timeTxt;

    private void Update()
    {
        gameTime += Time.deltaTime;
        timeTxt.text = " " + gameTime.ToString("F2"); 
    }
}
