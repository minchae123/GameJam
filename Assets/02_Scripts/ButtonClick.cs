using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoStart()
    {
        Debug.Log("ó������");
        //SceneManager.LoadScene("");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
