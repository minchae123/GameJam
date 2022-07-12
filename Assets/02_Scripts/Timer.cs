using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float gameTime = 0;
    public Text timeTxt;

    private void Update()
    {
        gameTime += Time.deltaTime;
        timeTxt.text = "½Ã°£ : " + (int)gameTime; 
    }
}
