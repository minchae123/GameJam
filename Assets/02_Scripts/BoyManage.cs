using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BoyManage : MonoBehaviour
{
    private float time = 0;

    private void Start()
    {
        time = PlayerPrefs.GetFloat("asdf");
    }

    public void TouchButton()
    {
        if(time <= 110)
        {
            Good();
        }
        if(time >=111 && time <= 140)
        {
            Normal();
        }
        if(time >= 141 && time <= 180)
        {
            Otaku();
        }
        PlayerPrefs.SetFloat("asdf", 0);
    }
    public void Good()
    {
        SceneManager.LoadScene(7);       
    }

    public void Otaku()
    {
        SceneManager.LoadScene(6);
    }
    public void Normal()
    {
        SceneManager.LoadScene(8);
    }
}
