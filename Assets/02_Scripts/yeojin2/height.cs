using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Height: MonoBehaviour
{
    public float height  = 75.0f;
    public float lose = 0.1f;
    public float curHe;
    public Text heighttxt;

    void Update()
    {
        height -= Time.deltaTime * lose;
        heighttxt.text = "¸ö¹«°Ô : " + height.ToString("F2") + "kg";

        if(height >= 85f)
        {
            Debug.Log("½ÇÆÐ");
            //SceneManager.LoadScene("GameOver");
        }
    }
}
